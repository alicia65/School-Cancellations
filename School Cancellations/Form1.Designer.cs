namespace School_Cancellations
{
    partial class Form1
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
            this.lblAirTemperature = new System.Windows.Forms.Label();
            this.lblWindChill = new System.Windows.Forms.Label();
            this.lblSnowfall = new System.Windows.Forms.Label();
            this.txtAirTemperature = new System.Windows.Forms.TextBox();
            this.txtWindChill = new System.Windows.Forms.TextBox();
            this.txtSnowfall = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAirTemperature
            // 
            this.lblAirTemperature.Location = new System.Drawing.Point(47, 34);
            this.lblAirTemperature.Name = "lblAirTemperature";
            this.lblAirTemperature.Size = new System.Drawing.Size(129, 23);
            this.lblAirTemperature.TabIndex = 0;
            this.lblAirTemperature.Text = "Air Temperature";
            this.lblAirTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWindChill
            // 
            this.lblWindChill.Location = new System.Drawing.Point(56, 99);
            this.lblWindChill.Name = "lblWindChill";
            this.lblWindChill.Size = new System.Drawing.Size(100, 23);
            this.lblWindChill.TabIndex = 1;
            this.lblWindChill.Text = "Wind Chill";
            this.lblWindChill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSnowfall
            // 
            this.lblSnowfall.Location = new System.Drawing.Point(21, 180);
            this.lblSnowfall.Name = "lblSnowfall";
            this.lblSnowfall.Size = new System.Drawing.Size(198, 23);
            this.lblSnowfall.TabIndex = 2;
            this.lblSnowfall.Text = "Number of inches of snowfall";
            this.lblSnowfall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAirTemperature
            // 
            this.txtAirTemperature.Location = new System.Drawing.Point(255, 34);
            this.txtAirTemperature.Name = "txtAirTemperature";
            this.txtAirTemperature.Size = new System.Drawing.Size(165, 22);
            this.txtAirTemperature.TabIndex = 0;
            // 
            // txtWindChill
            // 
            this.txtWindChill.Location = new System.Drawing.Point(255, 99);
            this.txtWindChill.Name = "txtWindChill";
            this.txtWindChill.Size = new System.Drawing.Size(165, 22);
            this.txtWindChill.TabIndex = 1;
            // 
            // txtSnowfall
            // 
            this.txtSnowfall.Location = new System.Drawing.Point(255, 180);
            this.txtSnowfall.Name = "txtSnowfall";
            this.txtSnowfall.Size = new System.Drawing.Size(165, 22);
            this.txtSnowfall.TabIndex = 2;
            this.txtSnowfall.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 340);
            this.Controls.Add(this.txtSnowfall);
            this.Controls.Add(this.txtWindChill);
            this.Controls.Add(this.txtAirTemperature);
            this.Controls.Add(this.lblSnowfall);
            this.Controls.Add(this.lblWindChill);
            this.Controls.Add(this.lblAirTemperature);
            this.Name = "Form1";
            this.Text = "School Cancellations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAirTemperature;
        private System.Windows.Forms.Label lblWindChill;
        private System.Windows.Forms.Label lblSnowfall;
        private System.Windows.Forms.TextBox txtAirTemperature;
        private System.Windows.Forms.TextBox txtWindChill;
        private System.Windows.Forms.TextBox txtSnowfall;
    }
}

