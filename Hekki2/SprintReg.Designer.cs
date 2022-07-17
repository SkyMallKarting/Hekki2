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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DoThreeRaces
            // 
            this.DoThreeRaces.Location = new System.Drawing.Point(58, 167);
            this.DoThreeRaces.Name = "DoThreeRaces";
            this.DoThreeRaces.Size = new System.Drawing.Size(175, 80);
            this.DoThreeRaces.TabIndex = 0;
            this.DoThreeRaces.Text = "Распределить 3 хита";
            this.DoThreeRaces.UseVisualStyleBackColor = true;
            this.DoThreeRaces.Click += new System.EventHandler(this.DoThreeRaces_Click);
            // 
            // DoSemiFinal
            // 
            this.DoSemiFinal.Location = new System.Drawing.Point(280, 167);
            this.DoSemiFinal.Name = "DoSemiFinal";
            this.DoSemiFinal.Size = new System.Drawing.Size(175, 80);
            this.DoSemiFinal.TabIndex = 1;
            this.DoSemiFinal.Text = "Распределить полуфинал";
            this.DoSemiFinal.UseVisualStyleBackColor = true;
            this.DoSemiFinal.Click += new System.EventHandler(this.DoSemiFinal_Click);
            // 
            // DoFinal
            // 
            this.DoFinal.Location = new System.Drawing.Point(499, 167);
            this.DoFinal.Name = "DoFinal";
            this.DoFinal.Size = new System.Drawing.Size(175, 80);
            this.DoFinal.TabIndex = 2;
            this.DoFinal.Text = "Распределить финал";
            this.DoFinal.UseVisualStyleBackColor = true;
            this.DoFinal.Click += new System.EventHandler(this.DoFinal_Click);
            // 
            // DoResult
            // 
            this.DoResult.Location = new System.Drawing.Point(58, 292);
            this.DoResult.Name = "DoResult";
            this.DoResult.Size = new System.Drawing.Size(108, 80);
            this.DoResult.TabIndex = 3;
            this.DoResult.Text = "Перенести балы в общую таблицу";
            this.DoResult.UseVisualStyleBackColor = true;
            this.DoResult.Click += new System.EventHandler(this.DoResult_Click);
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(211, 298);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(132, 69);
            this.Sort.TabIndex = 4;
            this.Sort.Text = "Сортировать общую таблицу";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 69);
            this.button1.TabIndex = 5;
            this.button1.Text = "Пересобрать пилотов";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(542, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 69);
            this.button2.TabIndex = 6;
            this.button2.Text = "Заменить карты у выделенного пилота";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SprintReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.DoResult);
            this.Controls.Add(this.DoFinal);
            this.Controls.Add(this.DoSemiFinal);
            this.Controls.Add(this.DoThreeRaces);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}