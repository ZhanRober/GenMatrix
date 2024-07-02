namespace GenMatrix
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.HandsInput = new System.Windows.Forms.Button();
            this.FileInput = new System.Windows.Forms.Button();
            this.RandomInput = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 172);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(289, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите способ ввода данных";
            // 
            // HandsInput
            // 
            this.HandsInput.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HandsInput.Location = new System.Drawing.Point(392, 214);
            this.HandsInput.Name = "HandsInput";
            this.HandsInput.Size = new System.Drawing.Size(273, 126);
            this.HandsInput.TabIndex = 1;
            this.HandsInput.Text = "Вручную";
            this.HandsInput.UseVisualStyleBackColor = true;
            this.HandsInput.Click += new System.EventHandler(this.HandsInput_Click);
            // 
            // FileInput
            // 
            this.FileInput.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileInput.Location = new System.Drawing.Point(392, 346);
            this.FileInput.Name = "FileInput";
            this.FileInput.Size = new System.Drawing.Size(273, 124);
            this.FileInput.TabIndex = 2;
            this.FileInput.Text = "Из Файла";
            this.FileInput.UseVisualStyleBackColor = true;
            this.FileInput.Click += new System.EventHandler(this.FileInput_Click);
            // 
            // RandomInput
            // 
            this.RandomInput.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RandomInput.Location = new System.Drawing.Point(392, 476);
            this.RandomInput.Name = "RandomInput";
            this.RandomInput.Size = new System.Drawing.Size(273, 114);
            this.RandomInput.TabIndex = 3;
            this.RandomInput.Text = "Случайная генерация";
            this.RandomInput.UseVisualStyleBackColor = true;
            this.RandomInput.Click += new System.EventHandler(this.RandomInput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.RandomInput);
            this.Controls.Add(this.FileInput);
            this.Controls.Add(this.HandsInput);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HandsInput;
        private System.Windows.Forms.Button FileInput;
        private System.Windows.Forms.Button RandomInput;
    }
}

