namespace WindowsForms_MoPhongKhoanNoMin.CustomControls
{
    partial class UserControl_BanVe
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
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabel
            // 
            this.linkLabel.ActiveLinkColor = System.Drawing.Color.SpringGreen;
            this.linkLabel.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel.LinkColor = System.Drawing.Color.White;
            this.linkLabel.Location = new System.Drawing.Point(0, 0);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Padding = new System.Windows.Forms.Padding(5);
            this.linkLabel.Size = new System.Drawing.Size(300, 30);
            this.linkLabel.TabIndex = 0;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "linkLabel";
            this.linkLabel.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.LightGray;
            this.label.Location = new System.Drawing.Point(300, 0);
            this.label.Name = "label";
            this.label.Padding = new System.Windows.Forms.Padding(5);
            this.label.Size = new System.Drawing.Size(200, 30);
            this.label.TabIndex = 1;
            this.label.Text = "label";
            // 
            // UserControl_BanVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.label);
            this.Controls.Add(this.linkLabel);
            this.Name = "UserControl_BanVe";
            this.Size = new System.Drawing.Size(500, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.Label label;
    }
}
