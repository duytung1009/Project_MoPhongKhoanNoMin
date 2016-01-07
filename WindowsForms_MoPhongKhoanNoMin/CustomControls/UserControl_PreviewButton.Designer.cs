namespace WindowsForms_MoPhongKhoanNoMin.CustomControls
{
    partial class UserControl_PreviewButton
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
            this.radioButtonTemp = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radioButtonTemp
            // 
            this.radioButtonTemp.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonTemp.BackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButtonTemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonTemp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonTemp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.radioButtonTemp.Location = new System.Drawing.Point(0, 0);
            this.radioButtonTemp.Name = "radioButtonTemp";
            this.radioButtonTemp.Size = new System.Drawing.Size(160, 90);
            this.radioButtonTemp.TabIndex = 42;
            this.radioButtonTemp.TabStop = true;
            this.radioButtonTemp.Text = "Template 1";
            this.radioButtonTemp.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonTemp.UseVisualStyleBackColor = false;
            this.radioButtonTemp.CheckedChanged += new System.EventHandler(this.radioButtonTemp_CheckedChanged);
            // 
            // UserControl_PreviewButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radioButtonTemp);
            this.Name = "UserControl_PreviewButton";
            this.Size = new System.Drawing.Size(160, 90);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonTemp;
    }
}
