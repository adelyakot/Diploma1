namespace WindowsFormsApp_Diplom
{
    partial class ExpertSystemForm
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
            this.lb = new System.Windows.Forms.Label();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.resinfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb.Location = new System.Drawing.Point(208, 131);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(106, 28);
            this.lb.TabIndex = 0;
            this.lb.Text = "Вопросы";
            // 
            // bt1
            // 
            this.bt1.AutoSize = true;
            this.bt1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt1.Location = new System.Drawing.Point(370, 175);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 38);
            this.bt1.TabIndex = 1;
            this.bt1.Text = "Да";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.AutoSize = true;
            this.bt2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt2.Location = new System.Drawing.Point(370, 219);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(75, 38);
            this.bt2.TabIndex = 2;
            this.bt2.Text = "Нет";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // Start
            // 
            this.Start.AutoSize = true;
            this.Start.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.Location = new System.Drawing.Point(367, 33);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(98, 38);
            this.Start.TabIndex = 3;
            this.Start.Text = "Начать";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // resinfo
            // 
            this.resinfo.AutoSize = true;
            this.resinfo.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resinfo.Location = new System.Drawing.Point(208, 310);
            this.resinfo.Name = "resinfo";
            this.resinfo.Size = new System.Drawing.Size(90, 28);
            this.resinfo.TabIndex = 4;
            this.resinfo.Text = "Ответы";
            this.resinfo.Visible = false;
            // 
            // ExpertSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resinfo);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.lb);
            this.Name = "ExpertSystemForm";
            this.Text = "Диагностика ХОБЛ";
            this.Load += new System.EventHandler(this.ExpertSystemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label resinfo;
    }
}