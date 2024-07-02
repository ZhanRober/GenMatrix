namespace GenMatrix
{
    partial class UserEnterParametres
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PopulationSize = new System.Windows.Forms.TextBox();
            this.CrossoverRate = new System.Windows.Forms.TextBox();
            this.NumberOfGeneration = new System.Windows.Forms.TextBox();
            this.MutationRate = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 140);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.PopulationSize);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(55, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 137);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.CrossoverRate);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(578, 182);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(439, 137);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Controls.Add(this.NumberOfGeneration);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(55, 393);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(439, 141);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.Controls.Add(this.MutationRate);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(578, 393);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(439, 141);
            this.panel5.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(179, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(722, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите параметры генетического алгоритма";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Размер популяции (целое число)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(-2, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(441, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество поколений (целое число)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(419, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Вероятность скрещивания (0<X<1)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(37, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(365, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Вероятность мутации (0<X<1)";
            // 
            // PopulationSize
            // 
            this.PopulationSize.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PopulationSize.Location = new System.Drawing.Point(32, 65);
            this.PopulationSize.Name = "PopulationSize";
            this.PopulationSize.Size = new System.Drawing.Size(209, 35);
            this.PopulationSize.TabIndex = 6;
            // 
            // CrossoverRate
            // 
            this.CrossoverRate.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CrossoverRate.Location = new System.Drawing.Point(23, 65);
            this.CrossoverRate.Name = "CrossoverRate";
            this.CrossoverRate.Size = new System.Drawing.Size(209, 35);
            this.CrossoverRate.TabIndex = 8;
            // 
            // NumberOfGeneration
            // 
            this.NumberOfGeneration.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfGeneration.Location = new System.Drawing.Point(23, 67);
            this.NumberOfGeneration.Name = "NumberOfGeneration";
            this.NumberOfGeneration.Size = new System.Drawing.Size(209, 35);
            this.NumberOfGeneration.TabIndex = 7;
            // 
            // MutationRate
            // 
            this.MutationRate.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MutationRate.Location = new System.Drawing.Point(23, 67);
            this.MutationRate.Name = "MutationRate";
            this.MutationRate.Size = new System.Drawing.Size(209, 35);
            this.MutationRate.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(900, 597);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Далее";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserEnterParametres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserEnterParametres";
            this.Text = "UserEnterParametres";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PopulationSize;
        private System.Windows.Forms.TextBox CrossoverRate;
        private System.Windows.Forms.TextBox NumberOfGeneration;
        private System.Windows.Forms.TextBox MutationRate;
        private System.Windows.Forms.Button button1;
    }
}