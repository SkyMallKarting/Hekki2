namespace Hekki2
{
    partial class SchoolReg
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
            this.numbersOfKarts = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DoRace1 = new System.Windows.Forms.Button();
            this.DoRace2 = new System.Windows.Forms.Button();
            this.WriteTime = new System.Windows.Forms.Button();
            this.SortAllTimes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RebuildPilots
            // 
            this.RebuildPilots.Location = new System.Drawing.Point(79, 76);
            this.RebuildPilots.Name = "RebuildPilots";
            this.RebuildPilots.Size = new System.Drawing.Size(132, 69);
            this.RebuildPilots.TabIndex = 6;
            this.RebuildPilots.Text = "Пересобрать пилотов";
            this.RebuildPilots.UseVisualStyleBackColor = true;
            this.RebuildPilots.Click += new System.EventHandler(this.RebuildPilots_Click);
            // 
            // numbersOfKarts
            // 
            this.numbersOfKarts.Location = new System.Drawing.Point(481, 259);
            this.numbersOfKarts.Name = "numbersOfKarts";
            this.numbersOfKarts.Size = new System.Drawing.Size(100, 146);
            this.numbersOfKarts.TabIndex = 9;
            this.numbersOfKarts.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 69);
            this.button1.TabIndex = 10;
            this.button1.Text = "Пересобрать карты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DoRace1
            // 
            this.DoRace1.Location = new System.Drawing.Point(263, 70);
            this.DoRace1.Name = "DoRace1";
            this.DoRace1.Size = new System.Drawing.Size(175, 80);
            this.DoRace1.TabIndex = 15;
            this.DoRace1.Text = "Распределить Гонку 1";
            this.DoRace1.UseVisualStyleBackColor = true;
            this.DoRace1.Click += new System.EventHandler(this.DoRace1_Click);
            // 
            // DoRace2
            // 
            this.DoRace2.Location = new System.Drawing.Point(492, 70);
            this.DoRace2.Name = "DoRace2";
            this.DoRace2.Size = new System.Drawing.Size(175, 80);
            this.DoRace2.TabIndex = 16;
            this.DoRace2.Text = "Распределить Гонку 2";
            this.DoRace2.UseVisualStyleBackColor = true;
            this.DoRace2.Click += new System.EventHandler(this.DoRace2_Click);
            // 
            // WriteTime
            // 
            this.WriteTime.Location = new System.Drawing.Point(79, 307);
            this.WriteTime.Name = "WriteTime";
            this.WriteTime.Size = new System.Drawing.Size(108, 80);
            this.WriteTime.TabIndex = 21;
            this.WriteTime.Text = "Перенести время в общую таблицу";
            this.WriteTime.UseVisualStyleBackColor = true;
            this.WriteTime.Click += new System.EventHandler(this.WriteTime_Click);
            // 
            // SortAllTimes
            // 
            this.SortAllTimes.Location = new System.Drawing.Point(79, 203);
            this.SortAllTimes.Name = "SortAllTimes";
            this.SortAllTimes.Size = new System.Drawing.Size(108, 80);
            this.SortAllTimes.TabIndex = 22;
            this.SortAllTimes.Text = "Сортировать времена";
            this.SortAllTimes.UseVisualStyleBackColor = true;
            this.SortAllTimes.Click += new System.EventHandler(this.SortAllTimes_Click);
            // 
            // SchoolReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SortAllTimes);
            this.Controls.Add(this.WriteTime);
            this.Controls.Add(this.DoRace2);
            this.Controls.Add(this.DoRace1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numbersOfKarts);
            this.Controls.Add(this.RebuildPilots);
            this.Name = "SchoolReg";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RebuildPilots;
        private System.Windows.Forms.RichTextBox numbersOfKarts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DoRace1;
        private System.Windows.Forms.Button DoRace2;
        private System.Windows.Forms.Button WriteTime;
        private System.Windows.Forms.Button SortAllTimes;
    }
}