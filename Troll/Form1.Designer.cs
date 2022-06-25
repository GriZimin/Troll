namespace Troll
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.YesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.TextWindow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // YesButton
            // 
            this.YesButton.Location = new System.Drawing.Point(12, 62);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(153, 33);
            this.YesButton.TabIndex = 0;
            this.YesButton.Text = "Да";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            this.YesButton.MouseLeave += new System.EventHandler(this.YesButton_MouseLeave);
            this.YesButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.YesButton_MouseMove);
            // 
            // NoButton
            // 
            this.NoButton.Location = new System.Drawing.Point(281, 62);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(153, 33);
            this.NoButton.TabIndex = 1;
            this.NoButton.Text = "Нет";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // TextWindow
            // 
            this.TextWindow.AutoEllipsis = true;
            this.TextWindow.AutoSize = true;
            this.TextWindow.Location = new System.Drawing.Point(12, 9);
            this.TextWindow.Name = "TextWindow";
            this.TextWindow.Size = new System.Drawing.Size(103, 15);
            this.TextWindow.TabIndex = 2;
            this.TextWindow.Text = "Ты Отчим Дигла?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 107);
            this.Controls.Add(this.TextWindow);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button YesButton;
        private Button NoButton;
        private Label TextWindow;
    }
}