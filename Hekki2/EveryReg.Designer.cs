namespace Hekki2
{
    partial class EveryReg
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
            this.numbersOfKarts = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.DoResult = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.DoRaces = new System.Windows.Forms.Button();
            this.ReplaceKart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numbersOfKarts
            // 
            this.numbersOfKarts.Location = new System.Drawing.Point(25, 364);
            this.numbersOfKarts.Margin = new System.Windows.Forms.Padding(4);
            this.numbersOfKarts.Name = "numbersOfKarts";
            this.numbersOfKarts.Size = new System.Drawing.Size(132, 179);
            this.numbersOfKarts.TabIndex = 24;
            this.numbersOfKarts.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 364);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 85);
            this.button2.TabIndex = 25;
            this.button2.Text = "Пересобрать карты";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DoResult
            // 
            this.DoResult.Location = new System.Drawing.Point(624, 277);
            this.DoResult.Margin = new System.Windows.Forms.Padding(4);
            this.DoResult.Name = "DoResult";
            this.DoResult.Size = new System.Drawing.Size(144, 98);
            this.DoResult.TabIndex = 29;
            this.DoResult.Text = "Перенести балы в общую таблицу";
            this.DoResult.UseVisualStyleBackColor = true;
            this.DoResult.Click += new System.EventHandler(this.DoResult_Click);
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(792, 277);
            this.Sort.Margin = new System.Windows.Forms.Padding(4);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(164, 98);
            this.Sort.TabIndex = 30;
            this.Sort.Text = "Сортировать общую таблицу по балам";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(619, 451);
            this.clear.Margin = new System.Windows.Forms.Padding(4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(149, 80);
            this.clear.TabIndex = 31;
            this.clear.Text = "Очистить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // DoRaces
            // 
            this.DoRaces.Location = new System.Drawing.Point(34, 46);
            this.DoRaces.Margin = new System.Windows.Forms.Padding(4);
            this.DoRaces.Name = "DoRaces";
            this.DoRaces.Size = new System.Drawing.Size(233, 98);
            this.DoRaces.TabIndex = 32;
            this.DoRaces.Text = "Распределить Заезды";
            this.DoRaces.UseVisualStyleBackColor = true;
            this.DoRaces.Click += new System.EventHandler(this.DoRaces_Click);
            // 
            // ReplaceKart
            // 
            this.ReplaceKart.Location = new System.Drawing.Point(709, 13);
            this.ReplaceKart.Margin = new System.Windows.Forms.Padding(4);
            this.ReplaceKart.Name = "ReplaceKart";
            this.ReplaceKart.Size = new System.Drawing.Size(176, 85);
            this.ReplaceKart.TabIndex = 33;
            this.ReplaceKart.Text = "Заменить карт";
            this.ReplaceKart.UseVisualStyleBackColor = true;
            // 
            // EveryReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 567);
            this.Controls.Add(this.ReplaceKart);
            this.Controls.Add(this.DoRaces);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.DoResult);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numbersOfKarts);
            this.Name = "EveryReg";
            this.Text = "EveryReg";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox numbersOfKarts;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button DoResult;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button DoRaces;
        private System.Windows.Forms.Button ReplaceKart;
    }
}