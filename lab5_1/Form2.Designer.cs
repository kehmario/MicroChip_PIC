namespace lab5_1
{
    partial class frmPortSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_Port = new System.Windows.Forms.ComboBox();
            this.combo_bps = new System.Windows.Forms.ComboBox();
            this.combo_DataBits = new System.Windows.Forms.ComboBox();
            this.combo_Parity = new System.Windows.Forms.ComboBox();
            this.combo_StopBits = new System.Windows.Forms.ComboBox();
            this.combo_FlowCtrl = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bits Per Second";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stop Bits";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Flow Control";
            // 
            // combo_Port
            // 
            this.combo_Port.FormattingEnabled = true;
            this.combo_Port.Location = new System.Drawing.Point(124, 29);
            this.combo_Port.Name = "combo_Port";
            this.combo_Port.Size = new System.Drawing.Size(121, 21);
            this.combo_Port.TabIndex = 6;
            // 
            // combo_bps
            // 
            this.combo_bps.FormattingEnabled = true;
            this.combo_bps.Items.AddRange(new object[] {
            "110",
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.combo_bps.Location = new System.Drawing.Point(124, 56);
            this.combo_bps.Name = "combo_bps";
            this.combo_bps.Size = new System.Drawing.Size(121, 21);
            this.combo_bps.TabIndex = 7;
            // 
            // combo_DataBits
            // 
            this.combo_DataBits.FormattingEnabled = true;
            this.combo_DataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.combo_DataBits.Location = new System.Drawing.Point(124, 86);
            this.combo_DataBits.Name = "combo_DataBits";
            this.combo_DataBits.Size = new System.Drawing.Size(121, 21);
            this.combo_DataBits.TabIndex = 8;
            // 
            // combo_Parity
            // 
            this.combo_Parity.FormattingEnabled = true;
            this.combo_Parity.Location = new System.Drawing.Point(124, 116);
            this.combo_Parity.Name = "combo_Parity";
            this.combo_Parity.Size = new System.Drawing.Size(121, 21);
            this.combo_Parity.TabIndex = 9;
            // 
            // combo_StopBits
            // 
            this.combo_StopBits.FormattingEnabled = true;
            this.combo_StopBits.Location = new System.Drawing.Point(124, 144);
            this.combo_StopBits.Name = "combo_StopBits";
            this.combo_StopBits.Size = new System.Drawing.Size(121, 21);
            this.combo_StopBits.TabIndex = 10;
            // 
            // combo_FlowCtrl
            // 
            this.combo_FlowCtrl.FormattingEnabled = true;
            this.combo_FlowCtrl.Location = new System.Drawing.Point(124, 172);
            this.combo_FlowCtrl.Name = "combo_FlowCtrl";
            this.combo_FlowCtrl.Size = new System.Drawing.Size(121, 21);
            this.combo_FlowCtrl.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Apply Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Reset to Default";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmPortSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.combo_FlowCtrl);
            this.Controls.Add(this.combo_StopBits);
            this.Controls.Add(this.combo_Parity);
            this.Controls.Add(this.combo_DataBits);
            this.Controls.Add(this.combo_bps);
            this.Controls.Add(this.combo_Port);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPortSettings";
            this.Text = "Port Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPortSettings_FormClosed);
            this.Load += new System.EventHandler(this.frmPortSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Reset_Settings(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combo_Port;
        private System.Windows.Forms.ComboBox combo_bps;
        private System.Windows.Forms.ComboBox combo_DataBits;
        private System.Windows.Forms.ComboBox combo_Parity;
        private System.Windows.Forms.ComboBox combo_StopBits;
        private System.Windows.Forms.ComboBox combo_FlowCtrl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}