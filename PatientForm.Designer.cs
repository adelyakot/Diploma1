namespace WindowsFormsApp_Diplom
{
    partial class PatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cB_genger = new System.Windows.Forms.ComboBox();
            this.btn_to_ES = new System.Windows.Forms.Button();
            this.tb_lastname = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tB_firstname = new System.Windows.Forms.TextBox();
            this.dateTimePicker_BirthD = new System.Windows.Forms.DateTimePicker();
            this.lb_BirthD = new System.Windows.Forms.Label();
            this.lb_Gender = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_Fam = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(28, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 3;
            // 
            // cB_genger
            // 
            this.cB_genger.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cB_genger.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cB_genger.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cB_genger.FormattingEnabled = true;
            this.cB_genger.Items.AddRange(new object[] {
            "Женский",
            "Мужской"});
            this.cB_genger.Location = new System.Drawing.Point(191, 341);
            this.cB_genger.Name = "cB_genger";
            this.cB_genger.Size = new System.Drawing.Size(189, 32);
            this.cB_genger.TabIndex = 10;
            // 
            // btn_to_ES
            // 
            this.btn_to_ES.AutoSize = true;
            this.btn_to_ES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_to_ES.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_to_ES.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_to_ES.FlatAppearance.BorderSize = 2;
            this.btn_to_ES.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btn_to_ES.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_to_ES.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_to_ES.Location = new System.Drawing.Point(342, 515);
            this.btn_to_ES.Name = "btn_to_ES";
            this.btn_to_ES.Size = new System.Drawing.Size(147, 37);
            this.btn_to_ES.TabIndex = 7;
            this.btn_to_ES.Text = "ОК";
            this.btn_to_ES.UseVisualStyleBackColor = true;
            this.btn_to_ES.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_lastname
            // 
            this.tb_lastname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_lastname.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tb_lastname.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_lastname.Location = new System.Drawing.Point(191, 239);
            this.tb_lastname.Name = "tb_lastname";
            this.tb_lastname.Size = new System.Drawing.Size(189, 32);
            this.tb_lastname.TabIndex = 0;
            // 
            // tb_name
            // 
            this.tb_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_name.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tb_name.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_name.Location = new System.Drawing.Point(191, 137);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(189, 32);
            this.tb_name.TabIndex = 0;
            // 
            // tB_firstname
            // 
            this.tB_firstname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tB_firstname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tB_firstname.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_firstname.Location = new System.Drawing.Point(191, 36);
            this.tB_firstname.Name = "tB_firstname";
            this.tB_firstname.Size = new System.Drawing.Size(189, 32);
            this.tB_firstname.TabIndex = 0;
            // 
            // dateTimePicker_BirthD
            // 
            this.dateTimePicker_BirthD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker_BirthD.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_BirthD.Location = new System.Drawing.Point(191, 443);
            this.dateTimePicker_BirthD.Name = "dateTimePicker_BirthD";
            this.dateTimePicker_BirthD.Size = new System.Drawing.Size(189, 32);
            this.dateTimePicker_BirthD.TabIndex = 1;
            // 
            // lb_BirthD
            // 
            this.lb_BirthD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_BirthD.AutoSize = true;
            this.lb_BirthD.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_BirthD.Location = new System.Drawing.Point(16, 447);
            this.lb_BirthD.Name = "lb_BirthD";
            this.lb_BirthD.Size = new System.Drawing.Size(155, 24);
            this.lb_BirthD.TabIndex = 9;
            this.lb_BirthD.Text = "Дата рождения";
            this.lb_BirthD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Gender
            // 
            this.lb_Gender.AutoSize = true;
            this.lb_Gender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Gender.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Gender.Location = new System.Drawing.Point(6, 308);
            this.lb_Gender.Name = "lb_Gender";
            this.lb_Gender.Size = new System.Drawing.Size(176, 99);
            this.lb_Gender.TabIndex = 8;
            this.lb_Gender.Text = "Пол";
            this.lb_Gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(6, 104);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(176, 99);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Имя";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 99);
            this.label4.TabIndex = 5;
            this.label4.Text = "Отчество";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Fam
            // 
            this.lb_Fam.AutoSize = true;
            this.lb_Fam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Fam.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Fam.Location = new System.Drawing.Point(6, 3);
            this.lb_Fam.Name = "lb_Fam";
            this.lb_Fam.Size = new System.Drawing.Size(176, 98);
            this.lb_Fam.TabIndex = 0;
            this.lb_Fam.Text = "Фамилия";
            this.lb_Fam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel1.Controls.Add(this.lb_Fam, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_Gender, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_BirthD, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker_BirthD, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tB_firstname, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_name, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_lastname, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_to_ES, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cB_genger, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.72921F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0677F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0677F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0677F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0677F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(495, 558);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(495, 558);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "PatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные о пациенте";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cB_genger;
        private System.Windows.Forms.Button btn_to_ES;
        private System.Windows.Forms.TextBox tb_lastname;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tB_firstname;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BirthD;
        private System.Windows.Forms.Label lb_BirthD;
        private System.Windows.Forms.Label lb_Gender;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_Fam;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}