using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ZedGraph;

namespace lab5_1
{

    public partial class frmMain : Form
    {
        
        double HIGHE = 5;
        double LOWE = 0;
        string SRD; 
        double[] samples = new double[200];
        double[] X_array = new double[200];
        double[] real = new double[200];
        double[] imaginary = new double[200];
        double[] wave = new double[200];
        double max_value = 0, min_value = 0, sampling_freq = 0, signal_period = 1;
        RollingPointPairList list = new RollingPointPairList(200);
        RollingPointPairList list1 = new RollingPointPairList(200);
        byte[] buffer = new byte[200];

        public delegate void AppendText(string Volt1);
        public void AddTextToLabelVolt1(string Volt1)
        {
            if (this.actual_tb.InvokeRequired)
            {
                this.Invoke(new AppendText(AddTextToLabelVolt1), Volt1);
            }
            else
            {
                this.actual_tb.Text = "";
                actual_tb.Text += SRD;
            }
        }

        public void CreateChart(ZedGraphControl zedGraphControl1)
        {
            GraphPane myPane = zedGraphControl1.GraphPane;
            myPane.Title.Text = "Oscilloscope";
            myPane.XAxis.Title.Text = "Time, Samples";
            myPane.YAxis.Title.Text = "Volts";
            zedGraphControl1.GraphPane.CurveList.Clear();
            zedGraphControl1.GraphPane.GraphObjList.Clear();
            zedGraphControl1.IsZoomOnMouseCenter = true;
            LineItem myCurve = myPane.AddCurve("", list, Color.Red, SymbolType.None);
            //
            myPane.XAxis.MajorGrid.IsVisible = true;
            myPane.YAxis.Scale.FontSpec.FontColor = Color.Red;
            myPane.YAxis.Title.FontSpec.FontColor = Color.Red;
            myPane.YAxis.MajorTic.IsOpposite = false;
            myPane.YAxis.MinorTic.IsOpposite = false;
            myPane.YAxis.MajorGrid.IsZeroLine = false;
            myPane.YAxis.Scale.Align = AlignP.Inside;
            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = 200;
            myPane.YAxis.Scale.Min = LOWE;
            myPane.YAxis.Scale.Max = HIGHE;
            myPane.Chart.Fill = new Fill(Color.White, Color.LightGray, 45.0f);
            zedGraphControl1.AxisChange();
            
        
        }
        
        public void CreateChart2(ZedGraphControl zedGraphControl2)
        {
            ZedGraph.GraphPane myPane2 = zedGraphControl2.GraphPane;
            myPane2.Title.Text = "Spectrum Analysis (DFT)";
            myPane2.XAxis.Title.Text = "Frequency";
            zedGraphControl2.GraphPane.CurveList.Clear();
            zedGraphControl2.GraphPane.GraphObjList.Clear();
            if (Linear.Checked)
            {
                myPane2.YAxis.Title.Text = "[Linearized]";
                for (int x = 199; x > 0; x--)
                { 
                    list1.Add(-1 * x, wave[x]);
                }
                for (int x = 0; x < 199; x++)
                {
                    list1.Add(x, wave[x]);
                }
            }
            else
            {
                myPane2.YAxis.Title.Text = "[dB]";

                for (int x = 199; x > 0; x--)
                {
                    list1.Add(-1 * x, 20 * Math.Log10(wave[x]));
                }
                for (int x = 0; x < 199; x++)
                {
                    list1.Add(x, 20 * Math.Log10(wave[x]));
                }
            }
            ZedGraph.LineItem myCurve = myPane2.AddCurve("", list1, Color.Black, SymbolType.None);
            myPane2.Chart.Fill = new Fill(Color.White, Color.LightGray, 45.0f);
            myPane2.XAxis.MajorGrid.IsVisible = true;
            myPane2.YAxis.MajorGrid.IsVisible = true;
            zedGraphControl2.GraphPane.YAxis.Scale.MaxAuto = true;
            myPane2.XAxis.Scale.Min = 0;
            myPane2.XAxis.Scale.Max = 200;
            myPane2.XAxis.Scale.MinorStep = 1;
            myPane2.XAxis.Scale.MajorStep = 10;
            zedGraphControl2.AxisChange();
            zedGraphControl2.Invalidate();         
}
      
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load (object sender, EventArgs e)
        {
            CreateChart(zedGraphControl1);
            CreateChart2(zedGraphControl2);
        }

        private void tb_Send_TextChanged(object sender, EventArgs e)
        {  
        
        } 

        private void portSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPortSettings frm = new frmPortSettings();
            frm.Show();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //char[] str = new char[200];
            //str = data.Split('#');      
            
            if (serialPort1.BytesToRead >= 200)
            {
                double[] x_axis = new double[200];
                for(int i = 0; i < 200; i ++)
                {
                    buffer[i] = 0;
                }
                int values = serialPort1.Read(buffer, 0, 200);
                //list.Clear();
                for (int x = 0; x < 200; x++)
                {
                    samples[x] = System.Convert.ToDouble((buffer[x]));
                    x_axis[x] = System.Convert.ToDouble(x);
                    //Double.TryParse([x], out samples[x]);
                    //list.Add((double)x, (samples[x] * 5) / 255);
                    //list.Add(Convert.ToDouble(x), Convert.ToDouble(buffer[x]));
                    list.Add(x_axis[x] , ((samples[x]*5)/255));
                }
                zedGraphControl1.Invalidate();
                zedGraphControl1.AxisChange();
                serialPort1.Write("@");
                
                /////////////////////////////////////////////
                for (int c = 0; c < 200; c++)
                {
                    imaginary[c] = 0;
                    real[c] = 0;
                }

                for (int a = 0; a < 200; a++)
                {
                    for (int n = 0; n < 200; n++)
                    {
                        real[a] += samples[n] * Math.Cos((2 * Math.PI * a * n) / 200);
                        imaginary[a] += samples[n] * Math.Sin((2 * Math.PI * a * n) / 200);
                    }
                }

                for (int x = 0; x < 200; x++)
                {
                    wave[x] = Math.Sqrt(real[x] * real[x] + imaginary[x] * imaginary[x]);
                }
                max_value = 0;
                min_value = 1;
                for (int x = 1; x < 200; x++)
                {
                    if (max_value < wave[x])
                    {
                        max_value = wave[x];
                        min_value = x;
                    }
                } 
                CreateChart2(zedGraphControl2);
                CreateChart(zedGraphControl1);
                serialPort1.DiscardInBuffer();

                if (serialPort1.IsOpen)
                {
                    serialPort1.Write("@");
                }
                
            }
        }
        

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close(); // close the serial port connection
        }

        public delegate void Addnewtext(string str);
        public void AddTextToLabel(string str)
        {
            if (this.actual_tb.InvokeRequired)
            {
                this.Invoke(new Addnewtext(AddTextToLabel), str);
            }
            else
            {
                this. actual_tb.Text = "";
                this. actual_tb.Text += str;        //add input to the textbox
            }
        }

       
        private void actual_tb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void actual_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }

        private void No_Function_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Write("*");
            }
        }

        private void Clear_LCD_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Write("4");
                this.actual_tb.Text = " ";
                
            }

        }

        private void Clear_GUI_Click(object sender, EventArgs e)
        {
            actual_tb.Clear();
            zedGraphControl1.GraphPane.CurveList.Clear();
            zedGraphControl1.GraphPane.GraphObjList.Clear();
            zedGraphControl1.Refresh();
            list.Clear();

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Write("#");
                Thread.Sleep(10);
                serialPort1.Write("@");
            }
        }

        private void Trigger_Up_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                if(Unfine.Checked)
                {
                    serialPort1.Write("+");
                    Thread.Sleep(10);
                    serialPort1.Write("@");
                }
                else
                serialPort1.Write("D");
                Thread.Sleep(10);
                serialPort1.Write("@");
            }
        }

        private void Trigger_Down_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                if(Unfine.Checked)
                {
                    serialPort1.Write("-");
                    Thread.Sleep(10);
                    serialPort1.Write("@");
                }
                else
                serialPort1.Write("U");
                Thread.Sleep(10);
                serialPort1.Write("@");
            }
        }

        private void SRD_up_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                if(Unfine.Checked)
                {
                    serialPort1.Write("^");
                    Thread.Sleep(10);
                    serialPort1.Write("@");
                }
                else
                serialPort1.Write("3");
                Thread.Sleep(10);
                serialPort1.Write("@");
            }
        }

        private void SRD_Dwn_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                if(Unfine.Checked)
                {
                    serialPort1.Write("v");
                    Thread.Sleep(10);
                    serialPort1.Write("@");
                }
                else
                serialPort1.Write("2");
                Thread.Sleep(10);
                serialPort1.Write("@");
            }
        }

        private void actual_tb_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void Mag_up_Click(object sender, EventArgs e)
        {
            if(Unfine.Checked)
            {
                HIGHE -= 10;
                LOWE += 10;
            }
            HIGHE -= 1;
            LOWE += 1;

        }

        private void Mag_Dwn_Click(object sender, EventArgs e)
        {
            if (Unfine.Checked)
            {
                HIGHE += 10;
                LOWE -= 10;
            }
            HIGHE += 1;
            LOWE -= 1;
        }

        private void zedGraphControl2_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void get_delay_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Write("X");
                Thread.Sleep(1);
                SRD = serialPort1.ReadLine();
                Thread.Sleep(1);
                AddTextToLabelVolt1(SRD);
                serialPort1.Write("@");

            }

        }
   
    }
}
