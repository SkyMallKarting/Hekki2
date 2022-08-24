namespace Hekki2
{
    partial class CherkasyReg
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
            this.RebuildKarts = new System.Windows.Forms.Button();
            this.DoQual1 = new System.Windows.Forms.Button();
            this.DoResult = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.DoHeat1 = new System.Windows.Forms.Button();
            this.DoQual2 = new System.Windows.Forms.Button();
            this.DoHeat2 = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Button();
            this.SortQual = new System.Windows.Forms.Button();
            this.WriteQual = new System.Windows.Forms.Button();
            this.DoFinal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numbersOfKarts
            // 
            this.numbersOfKarts.Location = new System.Drawing.Point(32, 347);
            this.numbersOfKarts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numbersOfKarts.Name = "numbersOfKarts";
            this.numbersOfKarts.Size = new System.Drawing.Size(132, 179);
            this.numbersOfKarts.TabIndex = 9;
            this.numbersOfKarts.Text = "";
            // 
            // RebuildKarts
            // 
            this.RebuildKarts.Location = new System.Drawing.Point(32, 255);
            this.RebuildKarts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RebuildKarts.Name = "RebuildKarts";
            this.RebuildKarts.Size = new System.Drawing.Size(176, 85);
            this.RebuildKarts.TabIndex = 10;
            this.RebuildKarts.Text = "Пересобрать карты";
            this.RebuildKarts.UseVisualStyleBackColor = true;
            this.RebuildKarts.Click += new System.EventHandler(this.RebuildKarts_Click);
            // 
            // DoQual1
            // 
            this.DoQual1.Location = new System.Drawing.Point(32, 89);
            this.DoQual1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoQual1.Name = "DoQual1";
            this.DoQual1.Size = new System.Drawing.Size(233, 98);
            this.DoQual1.TabIndex = 11;
            this.DoQual1.Text = "Распределить Квала 1";
            this.DoQual1.UseVisualStyleBackColor = true;
            this.DoQual1.Click += new System.EventHandler(this.DoQual1_Click);
            // 
            // DoResult
            // 
            this.DoResult.Location = new System.Drawing.Point(671, 340);
            this.DoResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoResult.Name = "DoResult";
            this.DoResult.Size = new System.Drawing.Size(144, 98);
            this.DoResult.TabIndex = 12;
            this.DoResult.Text = "Перенести балы в общую таблицу";
            this.DoResult.UseVisualStyleBackColor = true;
            this.DoResult.Click += new System.EventHandler(this.DoResult_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(273, 459);
            this.clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(149, 80);
            this.clear.TabIndex = 13;
            this.clear.Text = "Очистить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // DoHeat1
            // 
            this.DoHeat1.Location = new System.Drawing.Point(293, 89);
            this.DoHeat1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoHeat1.Name = "DoHeat1";
            this.DoHeat1.Size = new System.Drawing.Size(233, 98);
            this.DoHeat1.TabIndex = 14;
            this.DoHeat1.Text = "Распределить 1 хит";
            this.DoHeat1.UseVisualStyleBackColor = true;
            this.DoHeat1.Click += new System.EventHandler(this.DoHeat1_Click);
            // 
            // DoQual2
            // 
            this.DoQual2.Location = new System.Drawing.Point(552, 89);
            this.DoQual2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoQual2.Name = "DoQual2";
            this.DoQual2.Size = new System.Drawing.Size(233, 98);
            this.DoQual2.TabIndex = 15;
            this.DoQual2.Text = "Распределить Квала 2";
            this.DoQual2.UseVisualStyleBackColor = true;
            this.DoQual2.Click += new System.EventHandler(this.DoQual2_Click);
            // 
            // DoHeat2
            // 
            this.DoHeat2.Location = new System.Drawing.Point(817, 89);
            this.DoHeat2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoHeat2.Name = "DoHeat2";
            this.DoHeat2.Size = new System.Drawing.Size(233, 98);
            this.DoHeat2.TabIndex = 16;
            this.DoHeat2.Text = "Распределить 2 хит";
            this.DoHeat2.UseVisualStyleBackColor = true;
            this.DoHeat2.Click += new System.EventHandler(this.DoHeat2_Click);
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(863, 347);
            this.Sort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(176, 85);
            this.Sort.TabIndex = 17;
            this.Sort.Text = "Сортировать общую таблицу по балам";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // SortQual
            // 
            this.SortQual.Location = new System.Drawing.Point(863, 454);
            this.SortQual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SortQual.Name = "SortQual";
            this.SortQual.Size = new System.Drawing.Size(176, 85);
            this.SortQual.TabIndex = 18;
            this.SortQual.Text = "Сортировать время";
            this.SortQual.UseVisualStyleBackColor = true;
            this.SortQual.Click += new System.EventHandler(this.SortQual_Click);
            // 
            // WriteQual
            // 
            this.WriteQual.Location = new System.Drawing.Point(671, 447);
            this.WriteQual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WriteQual.Name = "WriteQual";
            this.WriteQual.Size = new System.Drawing.Size(144, 98);
            this.WriteQual.TabIndex = 20;
            this.WriteQual.Text = "Перенести время в общую таблицу";
            this.WriteQual.UseVisualStyleBackColor = true;
            this.WriteQual.Click += new System.EventHandler(this.WriteQual_Click);
            // 
            // DoFinal
            // 
            this.DoFinal.Location = new System.Drawing.Point(817, 194);
            this.DoFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoFinal.Name = "DoFinal";
            this.DoFinal.Size = new System.Drawing.Size(233, 98);
            this.DoFinal.TabIndex = 21;
            this.DoFinal.Text = "Распределить Финал";
            this.DoFinal.UseVisualStyleBackColor = true;
            this.DoFinal.Click += new System.EventHandler(this.DoFinal_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 353);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 85);
            this.button1.TabIndex = 22;
            this.button1.Text = "Пересобрать пилотов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CherkasyReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DoFinal);
            this.Controls.Add(this.WriteQual);
            this.Controls.Add(this.SortQual);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.DoHeat2);
            this.Controls.Add(this.DoQual2);
            this.Controls.Add(this.DoHeat1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.DoResult);
            this.Controls.Add(this.DoQual1);
            this.Controls.Add(this.RebuildKarts);
            this.Controls.Add(this.numbersOfKarts);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CherkasyReg";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Cherkasy_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox numbersOfKarts;
        private System.Windows.Forms.Button RebuildKarts;
        private System.Windows.Forms.Button DoQual1;
        private System.Windows.Forms.Button DoResult;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button DoHeat1;
        private System.Windows.Forms.Button DoQual2;
        private System.Windows.Forms.Button DoHeat2;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.Button SortQual;
        private System.Windows.Forms.Button WriteQual;
        private System.Windows.Forms.Button DoFinal;
        private System.Windows.Forms.Button button1;
    }
}