namespace Events
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
            this.Capture = new System.Windows.Forms.Button();
            this.stream = new System.Windows.Forms.PictureBox();
            this.Stop_Capture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stream)).BeginInit();
            this.SuspendLayout();
            // 
            // Capture
            // 
            this.Capture.Location = new System.Drawing.Point(33, 12);
            this.Capture.Name = "Capture";
            this.Capture.Size = new System.Drawing.Size(75, 23);
            this.Capture.TabIndex = 0;
            this.Capture.Text = "Capture";
            this.Capture.UseVisualStyleBackColor = true;
            this.Capture.Click += new System.EventHandler(this.Capture_Click);
            // 
            // stream
            // 
            this.stream.Location = new System.Drawing.Point(12, 41);
            this.stream.Name = "stream";
            this.stream.Size = new System.Drawing.Size(258, 202);
            this.stream.TabIndex = 1;
            this.stream.TabStop = false;
            // 
            // Stop_Capture
            // 
            this.Stop_Capture.Location = new System.Drawing.Point(158, 12);
            this.Stop_Capture.Name = "Stop_Capture";
            this.Stop_Capture.Size = new System.Drawing.Size(99, 23);
            this.Stop_Capture.TabIndex = 2;
            this.Stop_Capture.Text = "Stop Capture";
            this.Stop_Capture.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.Stop_Capture);
            this.Controls.Add(this.stream);
            this.Controls.Add(this.Capture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.stream)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Capture;
        private System.Windows.Forms.PictureBox stream;
        private System.Windows.Forms.Button Stop_Capture;
    }
}

