using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace TappingData_demo
{
    
    public partial class Form1 : Form
    {
        OpenFileDialog input_path = new OpenFileDialog();
        DataTable input = new DataTable();
        double peekThreshold = 0.5;
        double[,] N_ = new double[15,2];
        double theLeng = 67.14 * 2;
        static string dbHost = "";
        static string dbUser = "";
        static string dbPass = "";
        static string dbName = "";
        MySqlConnection conn;
        MySqlCommand command;
        double length = 0;
        double captureFre = 5000.00;
        double tapperRPM = 443.00;
        double tapperPitch = 1.25;
        double unit_length = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void ReadCSV_Click(object sender, EventArgs e)
        {
            DataTable ds = new DataTable();
            StreamReader s = new StreamReader(input_path.FileName, Encoding.Default);
            //string ss = s.ReadLine();//skip the first line
            string[] columns = s.ReadLine().Split(',');
            //ds.Tables.Add();

            foreach (string col in columns)
            {
                bool added = false;
                string next = "";
                int i = 0;
                while (!added)
                {
                    string columnname = col + next;
                    columnname = columnname.Replace("#", "");
                    columnname = columnname.Replace("'", "");
                    columnname = columnname.Replace("&", "");

                    if (!ds.Columns.Contains(columnname))
                    {
                        ds.Columns.Add(columnname.ToUpper());
                        added = true;
                    }
                    else
                    {
                        i++;
                        next = "_" + i.ToString();
                    }
                }
            }

            string AllData = s.ReadToEnd();
            string[] rows = AllData.Split('\n');

            foreach (string r in rows)
            {
                string[] items = r.Split(',');
                ds.Rows.Add(items);
            }
            s.Close();
            input = ds.Copy();
            dataGridView1.DataSource = input;
            dataGridView1.Update();
            chart1.Series.Clear();
            chart2.Series.Clear();
            scanforerrorpeek(ref input);
            ChartDrawing("Input", input, "Torq1");
        }
        private void IBrowse_Click(object sender, EventArgs e)
        {
            input_path.Filter = "逗號分隔值 (*.csv*)|*.csv";
            input_path.ShowDialog();
            IPath.Text = input_path.FileName;
        }
        private void calculate_Click(object sender, EventArgs e)
        {
            //chart1.Series.Clear();
            //chart2.Series.Clear();
            //scanforerrorpeek(ref input);
            scanValue(input, 400.00);
            unit_length = cal_unit_length(tapperRPM, tapperPitch, captureFre);
            lengthtodata();
            updateTable();
            chart2.Series.Add("result");
            chart2.Series["result"].ChartType = SeriesChartType.Line;
            chart2.ChartAreas[0].AxisY.Maximum = 5;
            chart2.ChartAreas[0].AxisY.Minimum = -3;
            chart2.ChartAreas[0].AxisX.Interval = 30;
            chart2.Series["result"].Points.AddXY(0,0);
            for (int i = 1; i <= 14; i++)
            {
                chart2.Series["result"].Points.AddXY(N_[i, 0], N_[i, 1]);
            }
            //chart2.Series["result"].Points.AddXY(180, 0);
            //ChartDrawing("Input", input, "Torq1");

            MySqlConn("140.130.20.195", "10657101", "10657101", "nut_machine");
            DBupload(IDs.Text, N_, grade.Text, tapper.Text);
        }
        private void scanforerrorpeek(ref DataTable peekinput)
        {
            double[] scale = { 200, 1, 20, 5 };
            for (int i = 1; i < peekinput.Rows.Count - 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Math.Abs(Convert.ToDouble(peekinput.Rows[i - 1][j]) - Convert.ToDouble(peekinput.Rows[i][j])) / scale[j] > peekThreshold && Math.Abs(Convert.ToDouble(peekinput.Rows[i + 1][j]) - Convert.ToDouble(peekinput.Rows[i][j])) / scale[j] > peekThreshold)
                        peekinput.Rows[i][j] = (Convert.ToDouble(peekinput.Rows[i - 1][j]) + Convert.ToDouble(peekinput.Rows[i + 1][j])) / 2.000;
                }
            }
        }
        private void ChartDrawing(string title, DataTable dt, string colname)
        {
            chart1.DataSource = dt;
            chart1.Series.Add(title);
            chart1.Series[title].ChartType = SeriesChartType.Line;
            chart1.Series[title].YValueMembers = colname;
            chart1.DataBind();
        }
        private void scanValue(DataTable dt, double TrpmSET)
        {
            int rpmChange = 0;
            double rpmTre = 0.1;
            bool is0_400 = true;
            bool recorded = true;
            double maxT = Convert.ToDouble(dt.Rows[0]["Torq1"]);
            for (int i = 0; i < dt.Rows.Count - 2; i++)
            {
                if (maxT <= Convert.ToDouble(dt.Rows[i]["Torq1"])) //find Max Torque POS
                {
                    N_[5,0] = i;
                    N_[5,1] = Convert.ToDouble(dt.Rows[i]["Torq1"]);
                    maxT = Convert.ToDouble(dt.Rows[i]["Torq1"]);
                }
                double value = Math.Abs(Convert.ToDouble(dt.Rows[i]["RPM1"]) + Convert.ToDouble(dt.Rows[i + 1]["RPM1"])) / 2;

                if (value <= (1 + rpmTre) * TrpmSET && value >= (1 - rpmTre) * TrpmSET && is0_400)
                {
                    is0_400 = false;
                    recorded = false;
                    rpmChange++;
                }
                else if (value < (1 - rpmTre - 0.5) * TrpmSET && !is0_400)
                {
                    is0_400 = true;
                    recorded = false;
                    rpmChange++;
                    
                }

                if (!recorded)
                {
                    switch (rpmChange)
                    {
                        case 1:
                            N_[1, 0] = i;
                            //N_[1, 1] = Convert.ToDouble(dt.Rows[i]["Torq1"]);
                            break;
                        case 2:
                            N_[7, 0] = i;
                            //N_[7, 1] = Convert.ToDouble(dt.Rows[i]["Torq1"]);
                            break;
                        case 3:
                            N_[9, 0] = i;
                            //N_[9, 1] = Convert.ToDouble(dt.Rows[i]["Torq1"]);
                            break;
                        case 4:
                            N_[14, 0] = i;
                            //N_[14, 1] = Convert.ToDouble(dt.Rows[i]["Torq1"]);
                            break;
                    }
                    recorded = true;
                }
            }
            length = dt.Rows.Count;
            //check N_1 POS is in 0%~10%
            if (N_[1, 0] <= (dt.Rows.Count * 0) || N_[5, 0] > (dt.Rows.Count * 0.1))
            {
                N_[1, 0] = Math.Ceiling(length * 0.05);
                average("torq1", N_[1, 0], length * 0.05 - 5, ref N_[1, 1]);
            }
            //check N_7 POS is in 40%~50%
            if (N_[7, 0] < (dt.Rows.Count * 0.40) || N_[7, 0] > (dt.Rows.Count * 0.50))
            {
                N_[7, 0] = Math.Ceiling(length * 0.45) + N_[1, 0];
                average("torq1", N_[7, 0], 100, ref N_[7, 1]);
            }
            //check N_9 POS is in 50%~60%
            if (N_[9, 0] < (dt.Rows.Count * 0.50) || N_[9, 0] > (dt.Rows.Count * 0.60))
            {
                N_[9, 0] = Math.Ceiling(length * 0.55) + N_[1, 0];
                average("torq1", N_[9, 0], 100, ref N_[9, 1]);
            }
            //check N_14 POS is in 90%~100%
            if (N_[14, 0] < (dt.Rows.Count * 0.9) || N_[14, 0] >= (dt.Rows.Count * 1))
            {
                N_[14, 0] = Math.Ceiling(length * 0.95) + N_[1, 0];
                average("torq1", N_[14, 0], length * 0.05 - 5, ref N_[14, 1]);
            }
            //check N_5 POS is in 24%~46%
            if (N_[5, 0] < (dt.Rows.Count * 0.24) || N_[5, 0] > (dt.Rows.Count * 0.46))
            {
                N_[5, 0] = Math.Ceiling(length * 0.35) + N_[1, 0];
                average("torq1", N_[5, 0], 100, ref N_[5, 1]);
            }
            //define new length
            length = N_[14, 0] - N_[1, 0];
            
            N_[10, 0] = (N_[9, 0] + 1);
            //N_[10, 1] = Convert.ToDouble(dt.Rows[Convert.ToInt32(N_[10, 0])]["Torq1"]);
        }
        private void updateTable()
        {
            N1.Text  = txtret(N_[ 1, 0], N_[ 1, 1]);
            N2.Text  = txtret(N_[ 2, 0], N_[ 2, 1]);
            N3.Text  = txtret(N_[ 3, 0], N_[ 3, 1]);
            N4.Text  = txtret(N_[ 4, 0], N_[ 4, 1]);
            N5.Text  = txtret(N_[ 5, 0], N_[ 5, 1]);
            N6.Text  = txtret(N_[ 6, 0], N_[ 6, 1]);
            N7.Text  = txtret(N_[ 7, 0], N_[ 7, 1]);
            N8.Text  = txtret(N_[ 8, 0], N_[ 8, 1]);
            N9.Text  = txtret(N_[ 9, 0], N_[ 9, 1]);
            N10.Text = txtret(N_[10, 0], N_[10, 1]);
            N11.Text = txtret(N_[11, 0], N_[11, 1]);
            N12.Text = txtret(N_[12, 0], N_[12, 1]);
            N13.Text = txtret(N_[13, 0], N_[13, 1]);
            N14.Text = txtret(N_[14, 0], N_[14, 1]);

        }
        private string txtret(double x, double y)
        {
            return "(" + x.ToString("0.###") + " , " + y.ToString("0.###") + ")";
        }
        private void average(string colnum, double start, double end, ref double XsaveAT, ref double YsaveAT)
        {

            double sum = 0; ;
            for(int s = Convert.ToInt32(start); s <= end; s++)
            {
                sum += Convert.ToDouble(input.Rows[s][colnum]);
            }
            XsaveAT = (end + start) / 2;
            YsaveAT = sum / (end - start + 1);
        }
        private void average(string colnum, double mid, double sample, ref double YsaveAT)
        {

            double sum = 0; ;
            for (int s = Convert.ToInt32(mid-sample); s <= mid + sample; s++)
            {
                sum += Convert.ToDouble(input.Rows[s][colnum]);
            }
            YsaveAT = sum / (2*sample + 1);
        }
        private void lengthtodata()
        {
            double avrSample = 200.0;
            callength(-6.845, N_[ 5, 0], ref N_[ 3, 0]);
            callength(-5.015, N_[ 5, 0], ref N_[ 4, 0]);
            callength(15.155, N_[5, 0], ref N_[6, 0]);
            N_[12, 0] = N_[10, 0] + N_[7, 0] - N_[3, 0];
            average("torq1", N_[ 1, 0],               avrSample, ref N_[ 1, 1]                );
            average("torq1", N_[ 1, 0], N_[ 3, 0],               ref N_[ 2, 0], ref N_[ 2, 1] );
            average("torq1", N_[ 3, 0],               avrSample, ref N_[ 3, 1]                );
            average("torq1", N_[ 4, 0],               avrSample, ref N_[ 4, 1]                );
            average("torq1", N_[ 6, 0],               avrSample, ref N_[ 6, 1]                );
            average("torq1", N_[ 7, 0], N_[ 9, 0],               ref N_[ 8, 0], ref N_[ 8, 1] );
            average("torq1", N_[ 9, 0],               avrSample, ref N_[ 9, 1]                );
            average("torq1", N_[10, 0],               avrSample, ref N_[10, 1]                );
            average("torq1", N_[10, 0], N_[12, 0],               ref N_[11, 0], ref N_[11, 1] );
            average("torq1", N_[12, 0],               avrSample, ref N_[12, 1]                );
            average("torq1", N_[12, 0], N_[14, 0],               ref N_[13, 0], ref N_[13, 1] );
            average("torq1", N_[14, 0],               avrSample, ref N_[14, 1]                );
            for(int i = 1; i <=14; i++)
            {
                scaleX(ref N_[i, 0], N_[1, 0]);
            }
        }
        private void scaleX(ref double X, double offset)
        {
            X = (X -offset)*unit_length;
        }
        private void callength(double tar_length,double from, ref double Xval)
        {
            double lengTOdatarows = tar_length / unit_length;
            Xval = Math.Ceiling(from + lengTOdatarows);
        }
        private void MySqlConn(string server, string account, string password, string dbname)
        {
            string connStr = "server=" + server + ";uid=" + account + ";pwd=" + password + ";database=" + dbName;
            conn = new MySqlConnection(connStr);
            command = conn.CreateCommand();
            conn.Open();
        }
        private void DBupload(string ID, double[,] data, string gradeStr, string tapperStr)
        {
            string insertValue = "";
            //insertValue = "'" + ID + "',";
            for (int i = 1; i<=14; i++)
            {
                insertValue += "'" + data[i, 0].ToString("0.000") + "," + data[i, 1].ToString("0.000") + "',";
            }
            insertValue += "'" + gradeStr + "','" + tapperStr + "','" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "'";
            command.CommandText = "INSERT INTO nut_machine.machine_m01 (N1,N2,N3,N4,N5,N6,N7,N8,N9,N10,N11,N12,N13,N14,grade,tapper_01,date) values(" + insertValue + ")";
            command.ExecuteNonQuery();
            conn.Close();
        }
        private double cal_unit_length(double TRPM,double TPitch, double FREQ)
        {
            double velo = TRPM * TPitch / 60;
            return velo / 5000;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
