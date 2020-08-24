namespace P1_Code
{
    partial class FormHelloWorld
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
            this.ClickMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClickMe
            // 
            this.ClickMe.Location = new System.Drawing.Point(296, 243);
            this.ClickMe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClickMe.Name = "ClickMe";
            this.ClickMe.Size = new System.Drawing.Size(99, 36);
            this.ClickMe.TabIndex = 0;
            this.ClickMe.Text = "Exit";
            this.ClickMe.UseVisualStyleBackColor = true;
            this.ClickMe.Click += new System.EventHandler(this.ClickMe_Click);
            // 
            // FormHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(439, 317);
            this.Controls.Add(this.ClickMe);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormHelloWorld";
            this.Text = "CSC 470 - P1";
            this.Load += new System.EventHandler(this.FormHelloWorld_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ClickMe;
    }
}

