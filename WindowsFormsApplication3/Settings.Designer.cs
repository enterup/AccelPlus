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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
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
            resources.ApplyResources(this.closeButton, "closeButton");
            this.closeButton.Name = "closeButton";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // timerTextBox
            // 
            resources.ApplyResources(this.timerTextBox, "timerTextBox");
            this.timerTextBox.Name = "timerTextBox";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // udpRadio
            // 
            resources.ApplyResources(this.udpRadio, "udpRadio");
            this.udpRadio.Checked = true;
            this.udpRadio.Name = "udpRadio";
            this.udpRadio.TabStop = true;
            this.udpRadio.UseVisualStyleBackColor = true;
            this.udpRadio.CheckedChanged += new System.EventHandler(this.udpRadio_CheckedChanged);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // serialRadio
            // 
            resources.ApplyResources(this.serialRadio, "serialRadio");
            this.serialRadio.Name = "serialRadio";
            this.serialRadio.UseVisualStyleBackColor = true;
            this.serialRadio.CheckedChanged += new System.EventHandler(this.serialRadio_CheckedChanged);
            // 
            // flexBox
            // 
            resources.ApplyResources(this.flexBox, "flexBox");
            this.flexBox.Name = "flexBox";
            // 
            // comBox
            // 
            resources.ApplyResources(this.comBox, "comBox");
            this.comBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBox.FormattingEnabled = true;
            this.comBox.Name = "comBox";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // boudRateBox
            // 
            resources.ApplyResources(this.boudRateBox, "boudRateBox");
            this.boudRateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boudRateBox.FormattingEnabled = true;
            this.boudRateBox.Items.AddRange(new object[] {
            resources.GetString("boudRateBox.Items"),
            resources.GetString("boudRateBox.Items1"),
            resources.GetString("boudRateBox.Items2"),
            resources.GetString("boudRateBox.Items3"),
            resources.GetString("boudRateBox.Items4"),
            resources.GetString("boudRateBox.Items5"),
            resources.GetString("boudRateBox.Items6")});
            this.boudRateBox.Name = "boudRateBox";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // portBox
            // 
            resources.ApplyResources(this.portBox, "portBox");
            this.portBox.Name = "portBox";
            // 
            // dzMaskedBox
            // 
            resources.ApplyResources(this.dzMaskedBox, "dzMaskedBox");
            this.dzMaskedBox.Name = "dzMaskedBox";
            this.dzMaskedBox.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dyMaskedBox
            // 
            resources.ApplyResources(this.dyMaskedBox, "dyMaskedBox");
            this.dyMaskedBox.Name = "dyMaskedBox";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // dxMaskedBox
            // 
            resources.ApplyResources(this.dxMaskedBox, "dxMaskedBox");
            this.dxMaskedBox.Name = "dxMaskedBox";
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.Name = "okButton";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // intervalMaskedBox
            // 
            resources.ApplyResources(this.intervalMaskedBox, "intervalMaskedBox");
            this.intervalMaskedBox.Name = "intervalMaskedBox";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // SettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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