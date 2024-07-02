namespace GenMatrix
{
    partial class UserEnter
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.InputText = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(392, 71);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // InputText
            // 
            this.InputText.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.InputText.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputText.Location = new System.Drawing.Point(12, 86);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(366, 35);
            this.InputText.TabIndex = 1;
            //this.InputText.TextChanged += new System.EventHandler(this.InputText_TextChanged);
            // 
            // Send
            // 
            this.Send.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Send.Location = new System.Drawing.Point(261, 161);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(117, 36);
            this.Send.TabIndex = 2;
            this.Send.Text = "Далее";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(12, 161);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(117, 36);
            this.Add.TabIndex = 3;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // UserEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(390, 209);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UserEnter";
            this.Text = "UserEnter";
            //this.Load += new System.EventHandler(this.UserEnter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button Add;
    }
}