using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab5_1
{
    public partial class frmPortSettings : Form
    {
        public frmPortSettings()
        {
            InitializeComponent();
 
        }

        private void frmPortSettings_Load(object sender, EventArgs e)
        {
            //disable the main form until port settings is done
            foreach (Form tempForm in Application.OpenForms)
            {
                if (tempForm.Name == "frmMain") {
                    tempForm.Enabled = false;
                    break;
                }
            }
            Fill_PortSettingOptions(); // fill the available port options in the combo boxes
            Show_CurrentSettings(); //show the current port options
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Reset_Settings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Intitialize the RS232 port with the selection made by user
            frmMain mainForm;
            mainForm = new frmMain();

            foreach (frmMain tmpForm in Application.OpenForms)
                if (tmpForm.Name == "frmMain") { mainForm = tmpForm; break; }

            mainForm.serialPort1.Close(); // close the serial port before changing settings
            mainForm.serialPort1.PortName = combo_Port.SelectedItem.ToString();
            mainForm.serialPort1.BaudRate = int.Parse(combo_bps.SelectedItem.ToString());
            mainForm.serialPort1.DataBits = int.Parse(combo_DataBits.SelectedItem.ToString());
            mainForm.serialPort1.Parity = (System.IO.Ports.Parity)Enum.Parse(typeof(System.IO.Ports.Parity), combo_Parity.SelectedItem.ToString());
            mainForm.serialPort1.StopBits = (System.IO.Ports.StopBits)Enum.Parse(typeof(System.IO.Ports.StopBits), combo_StopBits.SelectedItem.ToString());
            mainForm.serialPort1.Handshake = (System.IO.Ports.Handshake)Enum.Parse(typeof(System.IO.Ports.Handshake), combo_FlowCtrl.SelectedItem.ToString());

            try
            {
                mainForm.serialPort1.Open(); // open the serial port with the new settings
                this.Close(); // close the portsettings form
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Cannot open " + combo_Port.SelectedItem.ToString() + "\nPlease select another port");
            }
            catch
            {
                MessageBox.Show("Cannot open serial port");
            }
        }
            private void Fill_PortSettingOptions()
            {
                //Get Available Ports
                foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
                {
                    combo_Port.Items.Add(s);
                }//fill the available port name in the combo box

                //Get Available Parity
                foreach (string s in Enum.GetNames(typeof(System.IO.Ports.Parity)))
                {combo_Parity.Items.Add(s); }// fill the available parity in the combo box

                //Get Available StopBits
                foreach (string s in Enum.GetNames(typeof(System.IO.Ports.StopBits)))
                { combo_StopBits.Items.Add(s);} // fill the available port name in the combo box

                //Get Available Handshake
                foreach (string s in Enum.GetNames(typeof(System.IO.Ports.Handshake)))
                { combo_FlowCtrl.Items.Add(s);} //fill the available port names in the combo box
        }
        public void Reset_Settings()
        {
            combo_Port.SelectedItem = "COM6";
            combo_bps.SelectedItem = "115200";
            combo_DataBits.SelectedItem = "8";
            combo_Parity.SelectedItem = "None";
            combo_StopBits.SelectedItem = "One";
            combo_FlowCtrl.SelectedItem = "None";
        }
        private void Show_CurrentSettings()
        {
            frmMain mainForm;
            mainForm = new frmMain();
            foreach (frmMain tmpForm in Application.OpenForms)
                if (tmpForm.Name == "frmMain") { mainForm = tmpForm; break; }
            combo_Port.SelectedItem = mainForm.serialPort1.PortName.ToString();

            combo_bps.SelectedItem = mainForm.serialPort1.BaudRate.ToString();

            combo_DataBits.SelectedItem = mainForm.serialPort1.DataBits.ToString();

            combo_Parity.SelectedItem = mainForm.serialPort1.Parity.ToString();

            combo_StopBits.SelectedItem = mainForm.serialPort1.StopBits.ToString();

            combo_FlowCtrl.SelectedItem = mainForm.serialPort1.Handshake.ToString();

        }


        private void frmPortSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Form tempForm in Application.OpenForms)
            {
                if (tempForm.Name == "frmMain") { tempForm.Enabled = true; break; }
            }
        }




    }
}
