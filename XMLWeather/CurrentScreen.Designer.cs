namespace XMLWeather
{
    partial class CurrentScreen
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
            this.cityOutput = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.tempOutput = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.windLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(58, 13);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(147, 37);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(131, 136);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(22, 13);
            this.currentOutput.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 40;
            this.label3.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(147, 349);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(83, 28);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "3 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 27);
            this.label5.TabIndex = 42;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.Location = new System.Drawing.Point(60, 264);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(128, 13);
            this.minOutput.TabIndex = 30;
            this.minOutput.Text = "minVAL";
            this.minOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tempOutput
            // 
            this.tempOutput.BackColor = System.Drawing.Color.Transparent;
            this.tempOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempOutput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tempOutput.Location = new System.Drawing.Point(82, 50);
            this.tempOutput.Name = "tempOutput";
            this.tempOutput.Size = new System.Drawing.Size(106, 31);
            this.tempOutput.TabIndex = 43;
            this.tempOutput.Text = "TEMPVAL";
            this.tempOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(63, 101);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(128, 128);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 44;
            this.pb1.TabStop = false;
            // 
            // windLabel
            // 
            this.windLabel.BackColor = System.Drawing.Color.Transparent;
            this.windLabel.Location = new System.Drawing.Point(63, 293);
            this.windLabel.Name = "windLabel";
            this.windLabel.Size = new System.Drawing.Size(125, 13);
            this.windLabel.TabIndex = 45;
            this.windLabel.Text = "windVal";
            this.windLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.windLabel);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.tempOutput);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.label5);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(250, 400);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label tempOutput;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label windLabel;
    }
}
