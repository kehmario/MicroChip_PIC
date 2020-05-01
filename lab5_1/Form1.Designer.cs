namespace lab5_1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.portSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.No_Function = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Clear_GUI = new System.Windows.Forms.Button();
            this.Clear_LCD = new System.Windows.Forms.Button();
            this.Trigger_Down = new System.Windows.Forms.Button();
            this.Trigger_Up = new System.Windows.Forms.Button();
            this.SRD_up = new System.Windows.Forms.Button();
            this.SRD_Dwn = new System.Windows.Forms.Button();
            this.Mag_up = new System.Windows.Forms.Button();
            this.Mag_Dwn = new System.Windows.Forms.Button();
            this.Unfine = new System.Windows.Forms.CheckBox();
            this.actual_tb = new System.Windows.Forms.RichTextBox();
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.get_delay = new System.Windows.Forms.Button();
            this.Linear = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portSettingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(690, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // portSettingsToolStripMenuItem
            // 
            this.portSettingsToolStripMenuItem.Name = "portSettingsToolStripMenuItem";
            this.portSettingsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.portSettingsToolStripMenuItem.Text = "Com Port";
            this.portSettingsToolStripMenuItem.Click += new System.EventHandler(this.portSettingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM11";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(195, 34);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(480, 244);
            this.zedGraphControl1.TabIndex = 40;
            this.zedGraphControl1.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // No_Function
            // 
            this.No_Function.Location = new System.Drawing.Point(12, 34);
            this.No_Function.Name = "No_Function";
            this.No_Function.Size = new System.Drawing.Size(177, 36);
            this.No_Function.TabIndex = 42;
            this.No_Function.Text = "Happy Fun Time Button";
            this.No_Function.UseVisualStyleBackColor = true;
            this.No_Function.Click += new System.EventHandler(this.No_Function_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(12, 410);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(50, 36);
            this.Stop.TabIndex = 47;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Clear_GUI
            // 
            this.Clear_GUI.Location = new System.Drawing.Point(12, 242);
            this.Clear_GUI.Name = "Clear_GUI";
            this.Clear_GUI.Size = new System.Drawing.Size(177, 36);
            this.Clear_GUI.TabIndex = 45;
            this.Clear_GUI.Text = "Clear GUI";
            this.Clear_GUI.UseVisualStyleBackColor = true;
            this.Clear_GUI.Click += new System.EventHandler(this.Clear_GUI_Click);
            // 
            // Clear_LCD
            // 
            this.Clear_LCD.Location = new System.Drawing.Point(12, 284);
            this.Clear_LCD.Name = "Clear_LCD";
            this.Clear_LCD.Size = new System.Drawing.Size(177, 36);
            this.Clear_LCD.TabIndex = 44;
            this.Clear_LCD.Text = "Clear_LCD";
            this.Clear_LCD.UseVisualStyleBackColor = true;
            this.Clear_LCD.Click += new System.EventHandler(this.Clear_LCD_Click);
            // 
            // Trigger_Down
            // 
            this.Trigger_Down.Location = new System.Drawing.Point(12, 118);
            this.Trigger_Down.Name = "Trigger_Down";
            this.Trigger_Down.Size = new System.Drawing.Size(177, 34);
            this.Trigger_Down.TabIndex = 48;
            this.Trigger_Down.Text = "Trigger_Down";
            this.Trigger_Down.UseVisualStyleBackColor = true;
            this.Trigger_Down.Click += new System.EventHandler(this.Trigger_Down_Click);
            // 
            // Trigger_Up
            // 
            this.Trigger_Up.Location = new System.Drawing.Point(12, 78);
            this.Trigger_Up.Name = "Trigger_Up";
            this.Trigger_Up.Size = new System.Drawing.Size(177, 34);
            this.Trigger_Up.TabIndex = 49;
            this.Trigger_Up.Text = "Trigger_Up";
            this.Trigger_Up.UseVisualStyleBackColor = true;
            this.Trigger_Up.Click += new System.EventHandler(this.Trigger_Up_Click);
            // 
            // SRD_up
            // 
            this.SRD_up.Location = new System.Drawing.Point(12, 158);
            this.SRD_up.Name = "SRD_up";
            this.SRD_up.Size = new System.Drawing.Size(177, 36);
            this.SRD_up.TabIndex = 50;
            this.SRD_up.Text = "Sample Up";
            this.SRD_up.UseVisualStyleBackColor = true;
            this.SRD_up.Click += new System.EventHandler(this.SRD_up_Click);
            // 
            // SRD_Dwn
            // 
            this.SRD_Dwn.Location = new System.Drawing.Point(12, 200);
            this.SRD_Dwn.Name = "SRD_Dwn";
            this.SRD_Dwn.Size = new System.Drawing.Size(177, 36);
            this.SRD_Dwn.TabIndex = 51;
            this.SRD_Dwn.Text = "Sample Down";
            this.SRD_Dwn.UseVisualStyleBackColor = true;
            this.SRD_Dwn.Click += new System.EventHandler(this.SRD_Dwn_Click);
            // 
            // Mag_up
            // 
            this.Mag_up.Location = new System.Drawing.Point(12, 326);
            this.Mag_up.Name = "Mag_up";
            this.Mag_up.Size = new System.Drawing.Size(177, 36);
            this.Mag_up.TabIndex = 52;
            this.Mag_up.Text = "Magnitude Up";
            this.Mag_up.UseVisualStyleBackColor = true;
            this.Mag_up.Click += new System.EventHandler(this.Mag_up_Click);
            // 
            // Mag_Dwn
            // 
            this.Mag_Dwn.Location = new System.Drawing.Point(12, 368);
            this.Mag_Dwn.Name = "Mag_Dwn";
            this.Mag_Dwn.Size = new System.Drawing.Size(177, 36);
            this.Mag_Dwn.TabIndex = 53;
            this.Mag_Dwn.Text = "Magnitude Down";
            this.Mag_Dwn.UseVisualStyleBackColor = true;
            this.Mag_Dwn.Click += new System.EventHandler(this.Mag_Dwn_Click);
            // 
            // Unfine
            // 
            this.Unfine.AutoSize = true;
            this.Unfine.Location = new System.Drawing.Point(8, 465);
            this.Unfine.Name = "Unfine";
            this.Unfine.Size = new System.Drawing.Size(54, 17);
            this.Unfine.TabIndex = 56;
            this.Unfine.Text = "Turbo";
            this.Unfine.UseVisualStyleBackColor = true;
            // 
            // actual_tb
            // 
            this.actual_tb.Location = new System.Drawing.Point(8, 488);
            this.actual_tb.Name = "actual_tb";
            this.actual_tb.Size = new System.Drawing.Size(181, 36);
            this.actual_tb.TabIndex = 54;
            this.actual_tb.Text = "";
            this.actual_tb.TextChanged += new System.EventHandler(this.actual_tb_TextChanged_1);
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.Location = new System.Drawing.Point(195, 284);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.ScrollGrace = 0D;
            this.zedGraphControl2.ScrollMaxX = 0D;
            this.zedGraphControl2.ScrollMaxY = 0D;
            this.zedGraphControl2.ScrollMaxY2 = 0D;
            this.zedGraphControl2.ScrollMinX = 0D;
            this.zedGraphControl2.ScrollMinY = 0D;
            this.zedGraphControl2.ScrollMinY2 = 0D;
            this.zedGraphControl2.Size = new System.Drawing.Size(480, 244);
            this.zedGraphControl2.TabIndex = 58;
            this.zedGraphControl2.Load += new System.EventHandler(this.zedGraphControl2_Load);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // get_delay
            // 
            this.get_delay.Location = new System.Drawing.Point(68, 410);
            this.get_delay.Name = "get_delay";
            this.get_delay.Size = new System.Drawing.Size(50, 36);
            this.get_delay.TabIndex = 59;
            this.get_delay.Text = "Get Delay";
            this.get_delay.UseVisualStyleBackColor = true;
            this.get_delay.Click += new System.EventHandler(this.get_delay_Click);
            // 
            // Linear
            // 
            this.Linear.AutoSize = true;
            this.Linear.Location = new System.Drawing.Point(68, 465);
            this.Linear.Name = "Linear";
            this.Linear.Size = new System.Drawing.Size(68, 17);
            this.Linear.TabIndex = 60;
            this.Linear.Text = "Linearize";
            this.Linear.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(690, 531);
            this.Controls.Add(this.Linear);
            this.Controls.Add(this.get_delay);
            this.Controls.Add(this.zedGraphControl2);
            this.Controls.Add(this.Unfine);
            this.Controls.Add(this.actual_tb);
            this.Controls.Add(this.Mag_Dwn);
            this.Controls.Add(this.Mag_up);
            this.Controls.Add(this.SRD_Dwn);
            this.Controls.Add(this.SRD_up);
            this.Controls.Add(this.Trigger_Up);
            this.Controls.Add(this.Trigger_Down);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Clear_GUI);
            this.Controls.Add(this.Clear_LCD);
            this.Controls.Add(this.No_Function);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "RS232 Interface";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmMain_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem portSettingsToolStripMenuItem;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button No_Function;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Clear_GUI;
        private System.Windows.Forms.Button Clear_LCD;
        private System.Windows.Forms.Button Trigger_Down;
        private System.Windows.Forms.Button Trigger_Up;
        private System.Windows.Forms.Button SRD_up;
        private System.Windows.Forms.Button SRD_Dwn;
        private System.Windows.Forms.Button Mag_up;
        private System.Windows.Forms.Button Mag_Dwn;
        private System.Windows.Forms.CheckBox Unfine;
        private System.Windows.Forms.RichTextBox actual_tb;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button get_delay;
        private System.Windows.Forms.CheckBox Linear;
    }
}

