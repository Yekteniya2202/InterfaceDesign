
namespace Lab_1
{
    partial class Experiment1
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
            this.StartButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuccessTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtextBox = new System.Windows.Forms.TextBox();
            this.StextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.Location = new System.Drawing.Point(750, 67);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(96, 61);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Начать";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(750, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 61);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SuccessTextBox
            // 
            this.SuccessTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SuccessTextBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.SuccessTextBox.Location = new System.Drawing.Point(624, 12);
            this.SuccessTextBox.Name = "SuccessTextBox";
            this.SuccessTextBox.Size = new System.Drawing.Size(120, 22);
            this.SuccessTextBox.TabIndex = 3;
            this.SuccessTextBox.Text = "Не определено";
            this.SuccessTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(658, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "D";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(658, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "S";
            // 
            // DtextBox
            // 
            this.DtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DtextBox.Location = new System.Drawing.Point(682, 45);
            this.DtextBox.Name = "DtextBox";
            this.DtextBox.Size = new System.Drawing.Size(63, 22);
            this.DtextBox.TabIndex = 6;
            // 
            // StextBox
            // 
            this.StextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StextBox.Location = new System.Drawing.Point(681, 86);
            this.StextBox.Name = "StextBox";
            this.StextBox.Size = new System.Drawing.Size(63, 22);
            this.StextBox.TabIndex = 7;
            // 
            // Experiment1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 528);
            this.Controls.Add(this.StextBox);
            this.Controls.Add(this.DtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SuccessTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Experiment1";
            this.Text = "Experiment1";
            this.Shown += new System.EventHandler(this.Experiment1_Shown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Experiment1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SuccessTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DtextBox;
        private System.Windows.Forms.TextBox StextBox;
    }
}