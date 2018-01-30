namespace Droid_Speaker
{
    partial class ToSpeakForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSayIt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(457, 71);
            this.textBox1.TabIndex = 0;
            // 
            // buttonSayIt
            // 
            this.buttonSayIt.Location = new System.Drawing.Point(394, 89);
            this.buttonSayIt.Name = "buttonSayIt";
            this.buttonSayIt.Size = new System.Drawing.Size(75, 23);
            this.buttonSayIt.TabIndex = 1;
            this.buttonSayIt.Text = "Say it";
            this.buttonSayIt.UseVisualStyleBackColor = true;
            this.buttonSayIt.Click += new System.EventHandler(this.buttonSayIt_Click);
            // 
            // ToSpeakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 124);
            this.Controls.Add(this.buttonSayIt);
            this.Controls.Add(this.textBox1);
            this.Name = "ToSpeakForm";
            this.Text = "ToSpeak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSayIt;
    }
}