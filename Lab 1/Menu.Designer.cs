
namespace Lab_1
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Exp1Button = new System.Windows.Forms.Button();
            this.Exp2Button = new System.Windows.Forms.Button();
            this.Exp3Button = new System.Windows.Forms.Button();
            this.DNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ExcelSaveButton = new System.Windows.Forms.Button();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Exp1Button
            // 
            this.Exp1Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exp1Button.Location = new System.Drawing.Point(12, 16);
            this.Exp1Button.Name = "Exp1Button";
            this.Exp1Button.Size = new System.Drawing.Size(284, 39);
            this.Exp1Button.TabIndex = 0;
            this.Exp1Button.Text = "Опыт 1";
            this.Exp1Button.UseVisualStyleBackColor = true;
            this.Exp1Button.Click += new System.EventHandler(this.Exp1Button_Click);
            // 
            // Exp2Button
            // 
            this.Exp2Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exp2Button.Location = new System.Drawing.Point(12, 69);
            this.Exp2Button.Name = "Exp2Button";
            this.Exp2Button.Size = new System.Drawing.Size(284, 39);
            this.Exp2Button.TabIndex = 1;
            this.Exp2Button.Text = "Опыт 2";
            this.Exp2Button.UseVisualStyleBackColor = true;
            this.Exp2Button.Click += new System.EventHandler(this.Exp2Button_Click);
            // 
            // Exp3Button
            // 
            this.Exp3Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exp3Button.Location = new System.Drawing.Point(12, 122);
            this.Exp3Button.Name = "Exp3Button";
            this.Exp3Button.Size = new System.Drawing.Size(284, 39);
            this.Exp3Button.TabIndex = 2;
            this.Exp3Button.Text = "Опыт 3";
            this.Exp3Button.UseVisualStyleBackColor = true;
            this.Exp3Button.Click += new System.EventHandler(this.Exp3Button_Click);
            // 
            // DNumericUpDown
            // 
            this.DNumericUpDown.Location = new System.Drawing.Point(360, 16);
            this.DNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.DNumericUpDown.Name = "DNumericUpDown";
            this.DNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.DNumericUpDown.TabIndex = 6;
            this.DNumericUpDown.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // SNumericUpDown
            // 
            this.SNumericUpDown.Location = new System.Drawing.Point(360, 56);
            this.SNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.SNumericUpDown.Name = "SNumericUpDown";
            this.SNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.SNumericUpDown.TabIndex = 7;
            this.SNumericUpDown.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "D";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "S";
            // 
            // ExcelSaveButton
            // 
            this.ExcelSaveButton.Location = new System.Drawing.Point(12, 184);
            this.ExcelSaveButton.Name = "ExcelSaveButton";
            this.ExcelSaveButton.Size = new System.Drawing.Size(284, 29);
            this.ExcelSaveButton.TabIndex = 10;
            this.ExcelSaveButton.Text = "Запись в эксель";
            this.ExcelSaveButton.UseVisualStyleBackColor = true;
            this.ExcelSaveButton.Click += new System.EventHandler(this.ExcelSaveButton_Click);
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(12, 231);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(468, 207);
            this.LogTextBox.TabIndex = 11;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.ExcelSaveButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SNumericUpDown);
            this.Controls.Add(this.DNumericUpDown);
            this.Controls.Add(this.Exp3Button);
            this.Controls.Add(this.Exp2Button);
            this.Controls.Add(this.Exp1Button);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.DNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exp1Button;
        private System.Windows.Forms.Button Exp2Button;
        private System.Windows.Forms.Button Exp3Button;
        private System.Windows.Forms.NumericUpDown DNumericUpDown;
        private System.Windows.Forms.NumericUpDown SNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ExcelSaveButton;
        private System.Windows.Forms.TextBox LogTextBox;
    }
}

