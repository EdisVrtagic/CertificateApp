
namespace CertificateApp
{
    partial class ParticipantControl
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
            this.PartNameBox = new System.Windows.Forms.Label();
            this.DeletePartBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PartDepBox = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PartEmailBox = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.PartNameBox);
            this.panel3.Location = new System.Drawing.Point(67, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(155, 31);
            this.panel3.TabIndex = 489;
            // 
            // PartNameBox
            // 
            this.PartNameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PartNameBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.PartNameBox.ForeColor = System.Drawing.Color.Black;
            this.PartNameBox.Location = new System.Drawing.Point(0, 0);
            this.PartNameBox.MinimumSize = new System.Drawing.Size(117, 31);
            this.PartNameBox.Name = "PartNameBox";
            this.PartNameBox.Size = new System.Drawing.Size(155, 31);
            this.PartNameBox.TabIndex = 102;
            this.PartNameBox.Text = "Empty";
            this.PartNameBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeletePartBtn
            // 
            this.DeletePartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeletePartBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeletePartBtn.CustomClick = true;
            this.DeletePartBtn.FillColor = System.Drawing.Color.Transparent;
            this.DeletePartBtn.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.DeletePartBtn.IconColor = System.Drawing.Color.Black;
            this.DeletePartBtn.Location = new System.Drawing.Point(17, 17);
            this.DeletePartBtn.Name = "DeletePartBtn";
            this.DeletePartBtn.PressedDepth = 0;
            this.DeletePartBtn.Size = new System.Drawing.Size(14, 14);
            this.DeletePartBtn.TabIndex = 494;
            this.DeletePartBtn.Click += new System.EventHandler(this.DeletePartBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PartDepBox);
            this.panel1.Location = new System.Drawing.Point(276, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 31);
            this.panel1.TabIndex = 495;
            // 
            // PartDepBox
            // 
            this.PartDepBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PartDepBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.PartDepBox.ForeColor = System.Drawing.Color.Black;
            this.PartDepBox.Location = new System.Drawing.Point(0, 0);
            this.PartDepBox.MinimumSize = new System.Drawing.Size(117, 31);
            this.PartDepBox.Name = "PartDepBox";
            this.PartDepBox.Size = new System.Drawing.Size(155, 31);
            this.PartDepBox.TabIndex = 102;
            this.PartDepBox.Text = "Empty";
            this.PartDepBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PartEmailBox);
            this.panel2.Location = new System.Drawing.Point(497, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 31);
            this.panel2.TabIndex = 496;
            // 
            // PartEmailBox
            // 
            this.PartEmailBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PartEmailBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.PartEmailBox.ForeColor = System.Drawing.Color.Black;
            this.PartEmailBox.Location = new System.Drawing.Point(0, 0);
            this.PartEmailBox.MinimumSize = new System.Drawing.Size(117, 31);
            this.PartEmailBox.Name = "PartEmailBox";
            this.PartEmailBox.Size = new System.Drawing.Size(171, 31);
            this.PartEmailBox.TabIndex = 102;
            this.PartEmailBox.Text = "Empty";
            this.PartEmailBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.DarkGray;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 37);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(678, 10);
            this.guna2Separator1.TabIndex = 497;
            // 
            // ParticipantControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DeletePartBtn);
            this.Controls.Add(this.panel3);
            this.Name = "ParticipantControl";
            this.Size = new System.Drawing.Size(671, 45);
            this.Load += new System.EventHandler(this.ParticipantControl_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label PartNameBox;
        internal Guna.UI2.WinForms.Guna2ControlBox DeletePartBtn;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label PartDepBox;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label PartEmailBox;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}
