namespace Hekki2
{
    partial class JuniorReg
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
            this.RebuildPilots = new System.Windows.Forms.Button();
            this.DoRace1 = new System.Windows.Forms.Button();
            this.DoRace2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DoFinal = new System.Windows.Forms.Button();
            this.numbersOfKarts = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.WriteTime = new System.Windows.Forms.Button();
            this.SortAllTimes = new System.Windows.Forms.Button();
            this.DoResult = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RebuildPilots
            // 
            this.RebuildPilots.Location = new System.Drawing.Point(366, 344);
            this.RebuildPilots.Margin = new System.Windows.Forms.Padding(4);
            this.RebuildPilots.Name = "RebuildPilots";
            this.RebuildPilots.Size = new System.Drawing.Size(176, 85);
            this.RebuildPilots.TabIndex = 7;
            this.RebuildPilots.Text = "Пересобрать пилотов";
            this.RebuildPilots.UseVisualStyleBackColor = true;
            this.RebuildPilots.Click += new System.EventHandler(this.RebuildPilots_Click);
            // 
            // DoRace1
            // 
            this.DoRace1.Location = new System.Drawing.Point(283, 58);
            this.DoRace1.Margin = new System.Windows.Forms.Padding(4);
            this.DoRace1.Name = "DoRace1";
            this.DoRace1.Size = new System.Drawing.Size(233, 98);
            this.DoRace1.TabIndex = 16;
            this.DoRace1.Text = "Распределить Гонку 1";
            this.DoRace1.UseVisualStyleBackColor = true;
            this.DoRace1.Click += new System.EventHandler(this.DoRace1_Click);
            // 
            // DoRace2
            // 
            this.DoRace2.Location = new System.Drawing.Point(547, 58);
            this.DoRace2.Margin = new System.Windows.Forms.Padding(4);
            this.DoRace2.Name = "DoRace2";
            this.DoRace2.Size = new System.Drawing.Size(233, 98);
            this.DoRace2.TabIndex = 17;
            this.DoRace2.Text = "Распределить Гонку 2";
            this.DoRace2.UseVisualStyleBackColor = true;
            this.DoRace2.Click += new System.EventHandler(this.DoRace2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 98);
            this.button1.TabIndex = 18;
            this.button1.Text = "Распределить Квалу случайно";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DoFinal
            // 
            this.DoFinal.Location = new System.Drawing.Point(810, 58);
            this.DoFinal.Margin = new System.Windows.Forms.Padding(4);
            this.DoFinal.Name = "DoFinal";
            this.DoFinal.Size = new System.Drawing.Size(233, 98);
            this.DoFinal.TabIndex = 22;
            this.DoFinal.Text = "Распределить Финал";
            this.DoFinal.UseVisualStyleBackColor = true;
            this.DoFinal.Click += new System.EventHandler(this.DoFinal_Click);
            // 
            // numbersOfKarts
            // 
            this.numbersOfKarts.Location = new System.Drawing.Point(22, 344);
            this.numbersOfKarts.Margin = new System.Windows.Forms.Padding(4);
            this.numbersOfKarts.Name = "numbersOfKarts";
            this.numbersOfKarts.Size = new System.Drawing.Size(132, 179);
            this.numbersOfKarts.TabIndex = 23;
            this.numbersOfKarts.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 344);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 85);
            this.button2.TabIndex = 24;
            this.button2.Text = "Пересобрать карты";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(162, 472);
            this.clear.Margin = new System.Windows.Forms.Padding(4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(149, 80);
            this.clear.TabIndex = 25;
            this.clear.Text = "Очистить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // WriteTime
            // 
            this.WriteTime.Location = new System.Drawing.Point(708, 454);
            this.WriteTime.Margin = new System.Windows.Forms.Padding(4);
            this.WriteTime.Name = "WriteTime";
            this.WriteTime.Size = new System.Drawing.Size(144, 98);
            this.WriteTime.TabIndex = 26;
            this.WriteTime.Text = "Перенести время в общую таблицу";
            this.WriteTime.UseVisualStyleBackColor = true;
            this.WriteTime.Click += new System.EventHandler(this.WriteTime_Click);
            // 
            // SortAllTimes
            // 
            this.SortAllTimes.Location = new System.Drawing.Point(879, 454);
            this.SortAllTimes.Margin = new System.Windows.Forms.Padding(4);
            this.SortAllTimes.Name = "SortAllTimes";
            this.SortAllTimes.Size = new System.Drawing.Size(164, 98);
            this.SortAllTimes.TabIndex = 27;
            this.SortAllTimes.Text = "Сортировать времена";
            this.SortAllTimes.UseVisualStyleBackColor = true;
            this.SortAllTimes.Click += new System.EventHandler(this.SortAllTimes_Click);
            // 
            // DoResult
            // 
            this.DoResult.Location = new System.Drawing.Point(708, 337);
            this.DoResult.Margin = new System.Windows.Forms.Padding(4);
            this.DoResult.Name = "DoResult";
            this.DoResult.Size = new System.Drawing.Size(144, 98);
            this.DoResult.TabIndex = 28;
            this.DoResult.Text = "Перенести балы в общую таблицу";
            this.DoResult.UseVisualStyleBackColor = true;
            this.DoResult.Click += new System.EventHandler(this.DoResult_Click);
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(879, 337);
            this.Sort.Margin = new System.Windows.Forms.Padding(4);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(164, 98);
            this.Sort.TabIndex = 29;
            this.Sort.Text = "Сортировать общую таблицу по балам";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 109);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 98);
            this.button3.TabIndex = 30;
            this.button3.Text = "Распределить Квалу По списку";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // JuniorReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 574);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.DoResult);
            this.Controls.Add(this.SortAllTimes);
            this.Controls.Add(this.WriteTime);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numbersOfKarts);
            this.Controls.Add(this.DoFinal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DoRace2);
            this.Controls.Add(this.DoRace1);
            this.Controls.Add(this.RebuildPilots);
            this.Name = "JuniorReg";
            this.Text = "JuniorReg";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RebuildPilots;
        private System.Windows.Forms.Button DoRace1;
        private System.Windows.Forms.Button DoRace2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DoFinal;
        private System.Windows.Forms.RichTextBox numbersOfKarts;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button WriteTime;
        private System.Windows.Forms.Button SortAllTimes;
        private System.Windows.Forms.Button DoResult;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.Button button3;
    }
}