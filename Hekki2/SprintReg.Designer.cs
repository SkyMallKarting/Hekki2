namespace Hekki2
{
    partial class SprintReg
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
            this.DoThreeRaces = new System.Windows.Forms.Button();
            this.DoSemiFinal = new System.Windows.Forms.Button();
            this.DoFinal = new System.Windows.Forms.Button();
            this.DoResult = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Button();
            this.RebuiltKarts = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.numbersOfKarts = new System.Windows.Forms.RichTextBox();
            this.DoOneRace = new System.Windows.Forms.Button();
            this.RebuildPilots = new System.Windows.Forms.Button();
            this.DeleteLastUsedKart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DoThreeRaces
            // 
            this.DoThreeRaces.Location = new System.Drawing.Point(77, 112);
            this.DoThreeRaces.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoThreeRaces.Name = "DoThreeRaces";
            this.DoThreeRaces.Size = new System.Drawing.Size(233, 98);
            this.DoThreeRaces.TabIndex = 0;
            this.DoThreeRaces.Text = "Распределить 3 хита";
            this.DoThreeRaces.UseVisualStyleBackColor = true;
            this.DoThreeRaces.Click += new System.EventHandler(this.DoThreeRaces_Click);
            // 
            // DoSemiFinal
            // 
            this.DoSemiFinal.Location = new System.Drawing.Point(368, 112);
            this.DoSemiFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoSemiFinal.Name = "DoSemiFinal";
            this.DoSemiFinal.Size = new System.Drawing.Size(233, 98);
            this.DoSemiFinal.TabIndex = 1;
            this.DoSemiFinal.Text = "Распределить полуфинал";
            this.DoSemiFinal.UseVisualStyleBackColor = true;
            this.DoSemiFinal.Click += new System.EventHandler(this.DoSemiFinal_Click);
            // 
            // DoFinal
            // 
            this.DoFinal.Location = new System.Drawing.Point(665, 112);
            this.DoFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoFinal.Name = "DoFinal";
            this.DoFinal.Size = new System.Drawing.Size(233, 98);
            this.DoFinal.TabIndex = 2;
            this.DoFinal.Text = "Распределить финал";
            this.DoFinal.UseVisualStyleBackColor = true;
            this.DoFinal.Click += new System.EventHandler(this.DoFinal_Click);
            // 
            // DoResult
            // 
            this.DoResult.Location = new System.Drawing.Point(83, 238);
            this.DoResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoResult.Name = "DoResult";
            this.DoResult.Size = new System.Drawing.Size(144, 98);
            this.DoResult.TabIndex = 3;
            this.DoResult.Text = "Перенести балы в общую таблицу";
            this.DoResult.UseVisualStyleBackColor = true;
            this.DoResult.Click += new System.EventHandler(this.DoResult_Click);
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(272, 238);
            this.Sort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(176, 85);
            this.Sort.TabIndex = 4;
            this.Sort.Text = "Сортировать общую таблицу";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // RebuiltKarts
            // 
            this.RebuiltKarts.Location = new System.Drawing.Point(272, 343);
            this.RebuiltKarts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RebuiltKarts.Name = "RebuiltKarts";
            this.RebuiltKarts.Size = new System.Drawing.Size(176, 85);
            this.RebuiltKarts.TabIndex = 5;
            this.RebuiltKarts.Text = "Пересобрать карты";
            this.RebuiltKarts.UseVisualStyleBackColor = true;
            this.RebuiltKarts.Click += new System.EventHandler(this.button1_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(77, 459);
            this.clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(149, 80);
            this.clear.TabIndex = 7;
            this.clear.Text = "Очистить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // numbersOfKarts
            // 
            this.numbersOfKarts.Location = new System.Drawing.Point(456, 346);
            this.numbersOfKarts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numbersOfKarts.Name = "numbersOfKarts";
            this.numbersOfKarts.Size = new System.Drawing.Size(132, 179);
            this.numbersOfKarts.TabIndex = 8;
            this.numbersOfKarts.Text = "";
            // 
            // DoOneRace
            // 
            this.DoOneRace.Location = new System.Drawing.Point(77, 6);
            this.DoOneRace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoOneRace.Name = "DoOneRace";
            this.DoOneRace.Size = new System.Drawing.Size(233, 98);
            this.DoOneRace.TabIndex = 9;
            this.DoOneRace.Text = "Распределить 1 хит";
            this.DoOneRace.UseVisualStyleBackColor = true;
            this.DoOneRace.Click += new System.EventHandler(this.DoOneRace_Click);
            // 
            // RebuildPilots
            // 
            this.RebuildPilots.Location = new System.Drawing.Point(368, 14);
            this.RebuildPilots.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RebuildPilots.Name = "RebuildPilots";
            this.RebuildPilots.Size = new System.Drawing.Size(176, 85);
            this.RebuildPilots.TabIndex = 10;
            this.RebuildPilots.Text = "Пересобрать пилотов";
            this.RebuildPilots.UseVisualStyleBackColor = true;
            this.RebuildPilots.Click += new System.EventHandler(this.RebuildPilots_Click);
            // 
            // DeleteLastUsedKart
            // 
            this.DeleteLastUsedKart.Location = new System.Drawing.Point(855, 440);
            this.DeleteLastUsedKart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteLastUsedKart.Name = "DeleteLastUsedKart";
            this.DeleteLastUsedKart.Size = new System.Drawing.Size(176, 85);
            this.DeleteLastUsedKart.TabIndex = 11;
            this.DeleteLastUsedKart.Text = "Удалить карты последнего хита";
            this.DeleteLastUsedKart.UseVisualStyleBackColor = true;
            this.DeleteLastUsedKart.Click += new System.EventHandler(this.DeleteLastUsedKart_Click);
            // 
            // SprintReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.DeleteLastUsedKart);
            this.Controls.Add(this.RebuildPilots);
            this.Controls.Add(this.DoOneRace);
            this.Controls.Add(this.numbersOfKarts);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.RebuiltKarts);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.DoResult);
            this.Controls.Add(this.DoFinal);
            this.Controls.Add(this.DoSemiFinal);
            this.Controls.Add(this.DoThreeRaces);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SprintReg";
            this.Text = "SprintReg";
            this.Load += new System.EventHandler(this.SprintReg_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DoThreeRaces;
        private System.Windows.Forms.Button DoSemiFinal;
        private System.Windows.Forms.Button DoFinal;
        private System.Windows.Forms.Button DoResult;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.Button RebuiltKarts;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.RichTextBox numbersOfKarts;
        private System.Windows.Forms.Button DoOneRace;
        private System.Windows.Forms.Button RebuildPilots;
        private System.Windows.Forms.Button DeleteLastUsedKart;
    }
}