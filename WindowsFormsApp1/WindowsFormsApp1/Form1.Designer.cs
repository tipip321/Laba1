namespace WindowsFormsApp1
{
    partial class Analiz
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
            this.Text = new System.Windows.Forms.Label();
            this.LenghtA = new System.Windows.Forms.TextBox();
            this.LenghtB = new System.Windows.Forms.TextBox();
            this.LenghtC = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text
            // 
            this.Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text.ForeColor = System.Drawing.Color.White;
            this.Text.Location = new System.Drawing.Point(154, 135);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(502, 44);
            this.Text.TabIndex = 0;
            this.Text.Text = "Введите длины сторон треугольника";
            this.Text.Click += new System.EventHandler(this.label1_Click);
            // 
            // LenghtA
            // 
            this.LenghtA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LenghtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LenghtA.Location = new System.Drawing.Point(160, 215);
            this.LenghtA.Name = "LenghtA";
            this.LenghtA.Size = new System.Drawing.Size(150, 49);
            this.LenghtA.TabIndex = 1;
            this.LenghtA.TextChanged += new System.EventHandler(this.LenghtA_TextChanged);
            // 
            // LenghtB
            // 
            this.LenghtB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LenghtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LenghtB.Location = new System.Drawing.Point(332, 215);
            this.LenghtB.Name = "LenghtB";
            this.LenghtB.Size = new System.Drawing.Size(150, 49);
            this.LenghtB.TabIndex = 2;
            // 
            // LenghtC
            // 
            this.LenghtC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LenghtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LenghtC.Location = new System.Drawing.Point(506, 215);
            this.LenghtC.Name = "LenghtC";
            this.LenghtC.Size = new System.Drawing.Size(150, 49);
            this.LenghtC.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(309, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 73);
            this.button1.TabIndex = 4;
            this.button1.Text = "Проверить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Analiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(161)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LenghtC);
            this.Controls.Add(this.LenghtB);
            this.Controls.Add(this.LenghtA);
            this.Controls.Add(this.Text);
            this.Name = "Analiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Text;
        public System.Windows.Forms.TextBox LenghtA;
        public System.Windows.Forms.TextBox LenghtB;
        public System.Windows.Forms.TextBox LenghtC;
        private System.Windows.Forms.Button button1;
    }
}

