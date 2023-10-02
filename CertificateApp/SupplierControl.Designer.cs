
namespace CertificateApp
{
    partial class SupplierControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.SUPNInfo = new System.Windows.Forms.Label();
            this.RadioBtn = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SUPIInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SUPCInfo = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SUPNInfo);
            this.panel3.Location = new System.Drawing.Point(60, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 31);
            this.panel3.TabIndex = 485;
            // 
            // SUPNInfo
            // 
            this.SUPNInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SUPNInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.SUPNInfo.ForeColor = System.Drawing.Color.Black;
            this.SUPNInfo.Location = new System.Drawing.Point(0, 0);
            this.SUPNInfo.MinimumSize = new System.Drawing.Size(117, 31);
            this.SUPNInfo.Name = "SUPNInfo";
            this.SUPNInfo.Size = new System.Drawing.Size(208, 31);
            this.SUPNInfo.TabIndex = 102;
            this.SUPNInfo.Text = "Empty";
            this.SUPNInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RadioBtn
            // 
            this.RadioBtn.AutoSize = true;
            this.RadioBtn.Location = new System.Drawing.Point(14, 17);
            this.RadioBtn.Name = "RadioBtn";
            this.RadioBtn.Size = new System.Drawing.Size(14, 13);
            this.RadioBtn.TabIndex = 486;
            this.RadioBtn.TabStop = true;
            this.RadioBtn.UseVisualStyleBackColor = true;
            this.RadioBtn.CheckedChanged += new System.EventHandler(this.RadioBtn_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SUPIInfo);
            this.panel1.Location = new System.Drawing.Point(292, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 31);
            this.panel1.TabIndex = 487;
            // 
            // SUPIInfo
            // 
            this.SUPIInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SUPIInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.SUPIInfo.ForeColor = System.Drawing.Color.Black;
            this.SUPIInfo.Location = new System.Drawing.Point(0, 0);
            this.SUPIInfo.MinimumSize = new System.Drawing.Size(117, 31);
            this.SUPIInfo.Name = "SUPIInfo";
            this.SUPIInfo.Size = new System.Drawing.Size(208, 31);
            this.SUPIInfo.TabIndex = 102;
            this.SUPIInfo.Text = "Empty";
            this.SUPIInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SUPCInfo);
            this.panel2.Location = new System.Drawing.Point(580, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 31);
            this.panel2.TabIndex = 488;
            // 
            // SUPCInfo
            // 
            this.SUPCInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SUPCInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.SUPCInfo.ForeColor = System.Drawing.Color.Black;
            this.SUPCInfo.Location = new System.Drawing.Point(0, 0);
            this.SUPCInfo.MinimumSize = new System.Drawing.Size(117, 31);
            this.SUPCInfo.Name = "SUPCInfo";
            this.SUPCInfo.Size = new System.Drawing.Size(208, 31);
            this.SUPCInfo.TabIndex = 102;
            this.SUPCInfo.Text = "Empty";
            this.SUPCInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SupplierControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RadioBtn);
            this.Controls.Add(this.panel3);
            this.Name = "SupplierControl";
            this.Size = new System.Drawing.Size(801, 45);
            this.Load += new System.EventHandler(this.SupplierControl_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label SUPNInfo;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label SUPIInfo;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label SUPCInfo;
        public System.Windows.Forms.RadioButton RadioBtn;
    }
}
