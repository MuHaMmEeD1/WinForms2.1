namespace WinForms_C__LESSON_2._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            aramaTextBox = new TextBox();
            aramaButton = new Button();
            qeydiyatText1 = new Label();
            textName = new Label();
            NameTextBox1 = new TextBox();
            SurnameTextBox1 = new TextBox();
            SurnameLabel1 = new Label();
            VetenTextBox1 = new TextBox();
            VetenLabel1 = new Label();
            EmailTextBox1 = new TextBox();
            EmailLabel1 = new Label();
            DogumTarixiLabel1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            Cinsiyetlabel1 = new Label();
            KisiRadioButton1 = new RadioButton();
            QadinRadioButton1 = new RadioButton();
            IsLabel1 = new Label();
            IsVarCheckBox1 = new CheckBox();
            EvlidiCheckBox1 = new CheckBox();
            CreatButton1 = new Button();
            SuspendLayout();
            // 
            // aramaTextBox
            // 
            aramaTextBox.BorderStyle = BorderStyle.FixedSingle;
            aramaTextBox.Cursor = Cursors.IBeam;
            aramaTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            aramaTextBox.Location = new Point(12, 12);
            aramaTextBox.MaxLength = 26;
            aramaTextBox.Name = "aramaTextBox";
            aramaTextBox.Size = new Size(332, 39);
            aramaTextBox.TabIndex = 0;
            aramaTextBox.TextChanged += aramaTextBox_TextChanged;
            // 
            // aramaButton
            // 
            aramaButton.BackColor = SystemColors.Highlight;
            aramaButton.FlatStyle = FlatStyle.Flat;
            aramaButton.ForeColor = SystemColors.ButtonHighlight;
            aramaButton.Location = new Point(350, 12);
            aramaButton.Name = "aramaButton";
            aramaButton.Size = new Size(72, 39);
            aramaButton.TabIndex = 1;
            aramaButton.Text = "Axdar";
            aramaButton.UseVisualStyleBackColor = false;
            aramaButton.Click += aramaButton_Click;
            aramaButton.MouseEnter += aramaButton_MouseEnter;
            aramaButton.MouseLeave += aramaButton_MouseLeave;
            // 
            // qeydiyatText1
            // 
            qeydiyatText1.AutoSize = true;
            qeydiyatText1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            qeydiyatText1.ForeColor = SystemColors.GrayText;
            qeydiyatText1.Location = new Point(113, 94);
            qeydiyatText1.Name = "qeydiyatText1";
            qeydiyatText1.Size = new Size(200, 32);
            qeydiyatText1.TabIndex = 2;
            qeydiyatText1.Text = "Qeydiyyat Hissesi";
            // 
            // textName
            // 
            textName.AutoSize = true;
            textName.Font = new Font("Segoe UI", 15.2F, FontStyle.Regular, GraphicsUnit.Point);
            textName.ForeColor = SystemColors.GrayText;
            textName.Location = new Point(27, 163);
            textName.Name = "textName";
            textName.Size = new Size(47, 36);
            textName.TabIndex = 3;
            textName.Text = "Ad";
            // 
            // NameTextBox1
            // 
            NameTextBox1.BorderStyle = BorderStyle.FixedSingle;
            NameTextBox1.Font = new Font("Segoe UI", 12.2F, FontStyle.Regular, GraphicsUnit.Point);
            NameTextBox1.Location = new Point(133, 163);
            NameTextBox1.MaxLength = 20;
            NameTextBox1.Name = "NameTextBox1";
            NameTextBox1.Size = new Size(263, 35);
            NameTextBox1.TabIndex = 4;
            NameTextBox1.TextChanged += NameTextBox1_TextChanged;
            // 
            // SurnameTextBox1
            // 
            SurnameTextBox1.BorderStyle = BorderStyle.FixedSingle;
            SurnameTextBox1.Font = new Font("Segoe UI", 12.2F, FontStyle.Regular, GraphicsUnit.Point);
            SurnameTextBox1.Location = new Point(133, 213);
            SurnameTextBox1.MaxLength = 20;
            SurnameTextBox1.Name = "SurnameTextBox1";
            SurnameTextBox1.Size = new Size(263, 35);
            SurnameTextBox1.TabIndex = 6;
            SurnameTextBox1.TextChanged += SurnameTextBox1_TextChanged;
            // 
            // SurnameLabel1
            // 
            SurnameLabel1.AutoSize = true;
            SurnameLabel1.Font = new Font("Segoe UI", 15.2F, FontStyle.Regular, GraphicsUnit.Point);
            SurnameLabel1.ForeColor = SystemColors.GrayText;
            SurnameLabel1.Location = new Point(27, 213);
            SurnameLabel1.Name = "SurnameLabel1";
            SurnameLabel1.Size = new Size(96, 36);
            SurnameLabel1.TabIndex = 5;
            SurnameLabel1.Text = "Soy Ad";
            // 
            // VetenTextBox1
            // 
            VetenTextBox1.BorderStyle = BorderStyle.FixedSingle;
            VetenTextBox1.Font = new Font("Segoe UI", 12.2F, FontStyle.Regular, GraphicsUnit.Point);
            VetenTextBox1.Location = new Point(133, 266);
            VetenTextBox1.MaxLength = 20;
            VetenTextBox1.Name = "VetenTextBox1";
            VetenTextBox1.Size = new Size(263, 35);
            VetenTextBox1.TabIndex = 8;
            VetenTextBox1.TextChanged += VetenTextBox1_TextChanged;
            // 
            // VetenLabel1
            // 
            VetenLabel1.AutoSize = true;
            VetenLabel1.Font = new Font("Segoe UI", 15.2F, FontStyle.Regular, GraphicsUnit.Point);
            VetenLabel1.ForeColor = SystemColors.GrayText;
            VetenLabel1.Location = new Point(27, 266);
            VetenLabel1.Name = "VetenLabel1";
            VetenLabel1.Size = new Size(87, 36);
            VetenLabel1.TabIndex = 7;
            VetenLabel1.Text = "Veteni";
            // 
            // EmailTextBox1
            // 
            EmailTextBox1.BorderStyle = BorderStyle.FixedSingle;
            EmailTextBox1.Font = new Font("Segoe UI", 12.2F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTextBox1.Location = new Point(133, 319);
            EmailTextBox1.MaxLength = 26;
            EmailTextBox1.Name = "EmailTextBox1";
            EmailTextBox1.Size = new Size(263, 35);
            EmailTextBox1.TabIndex = 10;
            EmailTextBox1.TextChanged += EmailTextBox1_TextChanged;
            // 
            // EmailLabel1
            // 
            EmailLabel1.AutoSize = true;
            EmailLabel1.Font = new Font("Segoe UI", 15.2F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLabel1.ForeColor = SystemColors.GrayText;
            EmailLabel1.Location = new Point(27, 319);
            EmailLabel1.Name = "EmailLabel1";
            EmailLabel1.Size = new Size(75, 36);
            EmailLabel1.TabIndex = 9;
            EmailLabel1.Text = "Email";
            // 
            // DogumTarixiLabel1
            // 
            DogumTarixiLabel1.AutoSize = true;
            DogumTarixiLabel1.Font = new Font("Segoe UI", 15.2F, FontStyle.Regular, GraphicsUnit.Point);
            DogumTarixiLabel1.ForeColor = SystemColors.GrayText;
            DogumTarixiLabel1.Location = new Point(27, 370);
            DogumTarixiLabel1.Name = "DogumTarixiLabel1";
            DogumTarixiLabel1.Size = new Size(164, 36);
            DogumTarixiLabel1.TabIndex = 11;
            DogumTarixiLabel1.Text = "Dogum Tarixi";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top;
            dateTimePicker1.CalendarForeColor = SystemColors.GrayText;
            dateTimePicker1.CalendarTitleForeColor = SystemColors.GrayText;
            dateTimePicker1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(197, 376);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(199, 30);
            dateTimePicker1.TabIndex = 12;
            // 
            // Cinsiyetlabel1
            // 
            Cinsiyetlabel1.AutoSize = true;
            Cinsiyetlabel1.Font = new Font("Segoe UI", 15.2F, FontStyle.Regular, GraphicsUnit.Point);
            Cinsiyetlabel1.ForeColor = SystemColors.GrayText;
            Cinsiyetlabel1.Location = new Point(27, 421);
            Cinsiyetlabel1.Name = "Cinsiyetlabel1";
            Cinsiyetlabel1.Size = new Size(124, 36);
            Cinsiyetlabel1.TabIndex = 13;
            Cinsiyetlabel1.Text = "Cinsiyyeti";
            // 
            // KisiRadioButton1
            // 
            KisiRadioButton1.AutoSize = true;
            KisiRadioButton1.Checked = true;
            KisiRadioButton1.Location = new Point(175, 430);
            KisiRadioButton1.Name = "KisiRadioButton1";
            KisiRadioButton1.Size = new Size(97, 27);
            KisiRadioButton1.TabIndex = 14;
            KisiRadioButton1.TabStop = true;
            KisiRadioButton1.Text = "Kisi Cinsi";
            KisiRadioButton1.UseVisualStyleBackColor = true;
            // 
            // QadinRadioButton1
            // 
            QadinRadioButton1.AutoSize = true;
            QadinRadioButton1.Location = new Point(278, 430);
            QadinRadioButton1.Name = "QadinRadioButton1";
            QadinRadioButton1.Size = new Size(118, 27);
            QadinRadioButton1.TabIndex = 15;
            QadinRadioButton1.Text = "Qadin Cinsi";
            QadinRadioButton1.UseVisualStyleBackColor = true;
            // 
            // IsLabel1
            // 
            IsLabel1.AutoSize = true;
            IsLabel1.Font = new Font("Segoe UI", 15.2F, FontStyle.Regular, GraphicsUnit.Point);
            IsLabel1.ForeColor = SystemColors.GrayText;
            IsLabel1.Location = new Point(27, 471);
            IsLabel1.Name = "IsLabel1";
            IsLabel1.Size = new Size(0, 36);
            IsLabel1.TabIndex = 16;
            // 
            // IsVarCheckBox1
            // 
            IsVarCheckBox1.CheckAlign = ContentAlignment.MiddleRight;
            IsVarCheckBox1.Font = new Font("Segoe UI", 12.2F, FontStyle.Regular, GraphicsUnit.Point);
            IsVarCheckBox1.ForeColor = SystemColors.GrayText;
            IsVarCheckBox1.Location = new Point(33, 474);
            IsVarCheckBox1.Name = "IsVarCheckBox1";
            IsVarCheckBox1.Size = new Size(101, 33);
            IsVarCheckBox1.TabIndex = 17;
            IsVarCheckBox1.Text = "Is Var?";
            IsVarCheckBox1.TextAlign = ContentAlignment.MiddleCenter;
            IsVarCheckBox1.UseVisualStyleBackColor = true;
            // 
            // EvlidiCheckBox1
            // 
            EvlidiCheckBox1.CheckAlign = ContentAlignment.MiddleRight;
            EvlidiCheckBox1.Font = new Font("Segoe UI", 12.2F, FontStyle.Regular, GraphicsUnit.Point);
            EvlidiCheckBox1.ForeColor = SystemColors.GrayText;
            EvlidiCheckBox1.Location = new Point(295, 474);
            EvlidiCheckBox1.Name = "EvlidiCheckBox1";
            EvlidiCheckBox1.Size = new Size(101, 33);
            EvlidiCheckBox1.TabIndex = 18;
            EvlidiCheckBox1.Text = "Evlidi?";
            EvlidiCheckBox1.TextAlign = ContentAlignment.MiddleCenter;
            EvlidiCheckBox1.UseVisualStyleBackColor = true;
            // 
            // CreatButton1
            // 
            CreatButton1.BackColor = SystemColors.Highlight;
            CreatButton1.Font = new Font("Segoe UI", 13.2F, FontStyle.Bold, GraphicsUnit.Point);
            CreatButton1.ForeColor = SystemColors.ButtonHighlight;
            CreatButton1.Location = new Point(152, 488);
            CreatButton1.Name = "CreatButton1";
            CreatButton1.Size = new Size(137, 65);
            CreatButton1.TabIndex = 19;
            CreatButton1.Text = "Creat";
            CreatButton1.UseVisualStyleBackColor = false;
            CreatButton1.MouseClick += CreatButton1_Click;
            CreatButton1.MouseEnter += CreatButton1_MouseEnter;
            CreatButton1.MouseLeave += CreatButton1_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(434, 571);
            Controls.Add(CreatButton1);
            Controls.Add(EvlidiCheckBox1);
            Controls.Add(IsVarCheckBox1);
            Controls.Add(IsLabel1);
            Controls.Add(QadinRadioButton1);
            Controls.Add(KisiRadioButton1);
            Controls.Add(Cinsiyetlabel1);
            Controls.Add(dateTimePicker1);
            Controls.Add(DogumTarixiLabel1);
            Controls.Add(EmailTextBox1);
            Controls.Add(EmailLabel1);
            Controls.Add(VetenTextBox1);
            Controls.Add(VetenLabel1);
            Controls.Add(SurnameTextBox1);
            Controls.Add(SurnameLabel1);
            Controls.Add(NameTextBox1);
            Controls.Add(textName);
            Controls.Add(qeydiyatText1);
            Controls.Add(aramaButton);
            Controls.Add(aramaTextBox);
            MaximumSize = new Size(452, 618);
            MinimumSize = new Size(452, 618);
            Name = "Form1";
            Text = "Person Hissesi";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox aramaTextBox;
        private Button aramaButton;
        private Label qeydiyatText1;
        private Label textName;
        private TextBox NameTextBox1;
        private TextBox SurnameTextBox1;
        private Label SurnameLabel1;
        private TextBox VetenTextBox1;
        private Label VetenLabel1;
        private TextBox EmailTextBox1;
        private Label EmailLabel1;
        private Label DogumTarixiLabel1;
        private DateTimePicker dateTimePicker1;
        private Label Cinsiyetlabel1;
        private RadioButton KisiRadioButton1;
        private RadioButton QadinRadioButton1;
        private Label IsLabel1;
        private CheckBox IsVarCheckBox1;
        private CheckBox EvlidiCheckBox1;
        private Button CreatButton1;
    }
}