namespace WindowsFormsApplication3
{
    partial class SettingsForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.timerTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.udpRadio = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.serialRadio = new System.Windows.Forms.RadioButton();
            this.flexBox = new System.Windows.Forms.MaskedTextBox();
            this.comBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boudRateBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.MaskedTextBox();
            this.dzMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dyMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dxMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.intervalMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closeButton.Location = new System.Drawing.Point(303, 49);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 42;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // timerTextBox
            // 
            this.timerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timerTextBox.Location = new System.Drawing.Point(205, 193);
            this.timerTextBox.Mask = "000";
            this.timerTextBox.Name = "timerTextBox";
            this.timerTextBox.Size = new System.Drawing.Size(58, 20);
            this.timerTextBox.TabIndex = 60;
            this.timerTextBox.Text = "10";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(28, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 17);
            this.label14.TabIndex = 59;
            this.label14.Text = "Timer (s)";
            // 
            // udpRadio
            // 
            this.udpRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.udpRadio.AutoSize = true;
            this.udpRadio.Checked = true;
            this.udpRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.udpRadio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.udpRadio.Location = new System.Drawing.Point(31, 13);
            this.udpRadio.Name = "udpRadio";
            this.udpRadio.Size = new System.Drawing.Size(55, 21);
            this.udpRadio.TabIndex = 43;
            this.udpRadio.TabStop = true;
            this.udpRadio.Text = "UDP";
            this.udpRadio.UseVisualStyleBackColor = true;
            this.udpRadio.CheckedChanged += new System.EventHandler(this.udpRadio_CheckedChanged);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(28, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(163, 17);
            this.label13.TabIndex = 58;
            this.label13.Text = "Number of point for SMA";
            // 
            // serialRadio
            // 
            this.serialRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serialRadio.AutoSize = true;
            this.serialRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.serialRadio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.serialRadio.Location = new System.Drawing.Point(31, 45);
            this.serialRadio.Name = "serialRadio";
            this.serialRadio.Size = new System.Drawing.Size(62, 21);
            this.serialRadio.TabIndex = 44;
            this.serialRadio.Text = "Serial";
            this.serialRadio.UseVisualStyleBackColor = true;
            this.serialRadio.CheckedChanged += new System.EventHandler(this.serialRadio_CheckedChanged);
            // 
            // flexBox
            // 
            this.flexBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flexBox.Location = new System.Drawing.Point(205, 166);
            this.flexBox.Mask = "00";
            this.flexBox.Name = "flexBox";
            this.flexBox.Size = new System.Drawing.Size(58, 20);
            this.flexBox.TabIndex = 57;
            this.flexBox.Text = "03";
            // 
            // comBox
            // 
            this.comBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBox.FormattingEnabled = true;
            this.comBox.Location = new System.Drawing.Point(205, 9);
            this.comBox.Name = "comBox";
            this.comBox.Size = new System.Drawing.Size(58, 21);
            this.comBox.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(28, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 56;
            this.label5.Text = "Z threshold";
            // 
            // boudRateBox
            // 
            this.boudRateBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boudRateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boudRateBox.FormattingEnabled = true;
            this.boudRateBox.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400"});
            this.boudRateBox.Location = new System.Drawing.Point(205, 45);
            this.boudRateBox.Name = "boudRateBox";
            this.boudRateBox.Size = new System.Drawing.Size(58, 21);
            this.boudRateBox.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(28, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 55;
            this.label4.Text = "Y threshold";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(28, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "X threshold";
            // 
            // portBox
            // 
            this.portBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.portBox.Location = new System.Drawing.Point(205, 10);
            this.portBox.Mask = "00000";
            this.portBox.Name = "portBox";
            this.portBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.portBox.Size = new System.Drawing.Size(58, 20);
            this.portBox.TabIndex = 48;
            this.portBox.Text = "5555";
            // 
            // dzMaskedBox
            // 
            this.dzMaskedBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dzMaskedBox.Location = new System.Drawing.Point(205, 136);
            this.dzMaskedBox.Mask = "0.00";
            this.dzMaskedBox.Name = "dzMaskedBox";
            this.dzMaskedBox.Size = new System.Drawing.Size(58, 20);
            this.dzMaskedBox.TabIndex = 53;
            this.dzMaskedBox.TabStop = false;
            this.dzMaskedBox.Text = "006";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(120, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "Port:";
            // 
            // dyMaskedBox
            // 
            this.dyMaskedBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dyMaskedBox.Location = new System.Drawing.Point(205, 110);
            this.dyMaskedBox.Mask = "0.00";
            this.dyMaskedBox.Name = "dyMaskedBox";
            this.dyMaskedBox.Size = new System.Drawing.Size(58, 20);
            this.dyMaskedBox.TabIndex = 52;
            this.dyMaskedBox.Text = "006";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(120, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Boud  Rate";
            // 
            // dxMaskedBox
            // 
            this.dxMaskedBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dxMaskedBox.Location = new System.Drawing.Point(205, 85);
            this.dxMaskedBox.Mask = "0.00";
            this.dxMaskedBox.Name = "dxMaskedBox";
            this.dxMaskedBox.Size = new System.Drawing.Size(58, 20);
            this.dxMaskedBox.TabIndex = 51;
            this.dxMaskedBox.Text = "012";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.okButton.Location = new System.Drawing.Point(303, 9);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 61;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // intervalMaskedBox
            // 
            this.intervalMaskedBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.intervalMaskedBox.Location = new System.Drawing.Point(205, 193);
            this.intervalMaskedBox.Mask = "000";
            this.intervalMaskedBox.Name = "intervalMaskedBox";
            this.intervalMaskedBox.Size = new System.Drawing.Size(58, 20);
            this.intervalMaskedBox.TabIndex = 62;
            this.intervalMaskedBox.Text = "300";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(28, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 63;
            this.label6.Text = "Number of Points";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 264);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.intervalMaskedBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.timerTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.udpRadio);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.serialRadio);
            this.Controls.Add(this.flexBox);
            this.Controls.Add(this.comBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boudRateBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.dzMaskedBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dyMaskedBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dxMaskedBox);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.MaskedTextBox timerTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton udpRadio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton serialRadio;
        private System.Windows.Forms.MaskedTextBox flexBox;
        private System.Windows.Forms.ComboBox comBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox boudRateBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox portBox;
        private System.Windows.Forms.MaskedTextBox dzMaskedBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox dyMaskedBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox dxMaskedBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.MaskedTextBox intervalMaskedBox;
        private System.Windows.Forms.Label label6;
    }
}