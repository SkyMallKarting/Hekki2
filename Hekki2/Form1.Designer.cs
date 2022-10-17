namespace Hekki2
{
    partial class Main
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
            this.sprintButton = new System.Windows.Forms.Button();
            this.juniorButton = new System.Windows.Forms.Button();
            this.everyButton = new System.Windows.Forms.Button();
            this.numbersOfKarts = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cherkasy = new System.Windows.Forms.Button();
            this.schoolButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sprintButton
            // 
            this.sprintButton.Location = new System.Drawing.Point(101, 226);
            this.sprintButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sprintButton.Name = "sprintButton";
            this.sprintButton.Size = new System.Drawing.Size(239, 92);
            this.sprintButton.TabIndex = 0;
            this.sprintButton.Text = "Sprint";
            this.sprintButton.UseVisualStyleBackColor = true;
            this.sprintButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // juniorButton
            // 
            this.juniorButton.Location = new System.Drawing.Point(392, 226);
            this.juniorButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.juniorButton.Name = "juniorButton";
            this.juniorButton.Size = new System.Drawing.Size(239, 92);
            this.juniorButton.TabIndex = 1;
            this.juniorButton.Text = "Junior";
            this.juniorButton.UseVisualStyleBackColor = true;
            this.juniorButton.Click += new System.EventHandler(this.juniorButton_Click);
            // 
            // everyButton
            // 
            this.everyButton.Location = new System.Drawing.Point(685, 226);
            this.everyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.everyButton.Name = "everyButton";
            this.everyButton.Size = new System.Drawing.Size(239, 92);
            this.everyButton.TabIndex = 2;
            this.everyButton.Text = "Every On Every";
            this.everyButton.UseVisualStyleBackColor = true;
            this.everyButton.Click += new System.EventHandler(this.every_btn_Click);
            // 
            // numbersOfKarts
            // 
            this.numbersOfKarts.Location = new System.Drawing.Point(117, 359);
            this.numbersOfKarts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numbersOfKarts.Name = "numbersOfKarts";
            this.numbersOfKarts.Size = new System.Drawing.Size(132, 179);
            this.numbersOfKarts.TabIndex = 3;
            this.numbersOfKarts.Text = "";
            this.numbersOfKarts.TextChanged += new System.EventHandler(this.numbersOfKarts_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 340);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Номера картов, через enter";
            // 
            // Cherkasy
            // 
            this.Cherkasy.Location = new System.Drawing.Point(101, 78);
            this.Cherkasy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cherkasy.Name = "Cherkasy";
            this.Cherkasy.Size = new System.Drawing.Size(239, 92);
            this.Cherkasy.TabIndex = 5;
            this.Cherkasy.Text = "Черкасы";
            this.Cherkasy.UseVisualStyleBackColor = true;
            this.Cherkasy.Click += new System.EventHandler(this.Cherkasy_Click);
            // 
            // schoolButton
            // 
            this.schoolButton.Location = new System.Drawing.Point(755, 78);
            this.schoolButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.schoolButton.Name = "schoolButton";
            this.schoolButton.Size = new System.Drawing.Size(239, 92);
            this.schoolButton.TabIndex = 6;
            this.schoolButton.Text = "School";
            this.schoolButton.UseVisualStyleBackColor = true;
            this.schoolButton.Click += new System.EventHandler(this.schoolButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.schoolButton);
            this.Controls.Add(this.Cherkasy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numbersOfKarts);
            this.Controls.Add(this.everyButton);
            this.Controls.Add(this.juniorButton);
            this.Controls.Add(this.sprintButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sprintButton;
        private System.Windows.Forms.Button juniorButton;
        private System.Windows.Forms.Button everyButton;
        private System.Windows.Forms.RichTextBox numbersOfKarts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cherkasy;
        private System.Windows.Forms.Button schoolButton;
    }
}

