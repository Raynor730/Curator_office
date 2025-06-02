namespace сurator_office
{
    partial class FormAddStudent
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
            components = new System.ComponentModel.Container();
            panelBottom = new Panel();
            buttonCancel = new Button();
            buttonSave = new Button();
            panelFill = new Panel();
            checkBoxExcluded = new CheckBox();
            checkBoxFullAge = new CheckBox();
            textBoxPhoneNumber = new TextBox();
            labelPhoneNumber = new Label();
            numericUpDownRoleInGroup = new NumericUpDown();
            labelRoleInGrop = new Label();
            numericUpDownGroup = new NumericUpDown();
            labelGroup = new Label();
            numericUpDownSubgroup = new NumericUpDown();
            labelSubgroup = new Label();
            textBoxActualAddress = new TextBox();
            labelActualAddress = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            dateTimePickerBirthday = new DateTimePicker();
            labelBirthday = new Label();
            textBoxPatronymic = new TextBox();
            labelPatronymic = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            textBoxSurname = new TextBox();
            labelSurname = new Label();
            errorProvider = new ErrorProvider(components);
            panelBottom.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRoleInGroup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGroup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSubgroup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(buttonCancel);
            panelBottom.Controls.Add(buttonSave);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 701);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(10);
            panelBottom.Size = new Size(684, 60);
            panelBottom.TabIndex = 0;
            // 
            // buttonCancel
            // 
            buttonCancel.AutoSize = true;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(143, 16);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(100, 35);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.AutoSize = true;
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Location = new Point(22, 16);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(115, 35);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(checkBoxExcluded);
            panelFill.Controls.Add(checkBoxFullAge);
            panelFill.Controls.Add(textBoxPhoneNumber);
            panelFill.Controls.Add(labelPhoneNumber);
            panelFill.Controls.Add(numericUpDownRoleInGroup);
            panelFill.Controls.Add(labelRoleInGrop);
            panelFill.Controls.Add(numericUpDownGroup);
            panelFill.Controls.Add(labelGroup);
            panelFill.Controls.Add(numericUpDownSubgroup);
            panelFill.Controls.Add(labelSubgroup);
            panelFill.Controls.Add(textBoxActualAddress);
            panelFill.Controls.Add(labelActualAddress);
            panelFill.Controls.Add(textBoxEmail);
            panelFill.Controls.Add(labelEmail);
            panelFill.Controls.Add(dateTimePickerBirthday);
            panelFill.Controls.Add(labelBirthday);
            panelFill.Controls.Add(textBoxPatronymic);
            panelFill.Controls.Add(labelPatronymic);
            panelFill.Controls.Add(textBoxName);
            panelFill.Controls.Add(labelName);
            panelFill.Controls.Add(textBoxSurname);
            panelFill.Controls.Add(labelSurname);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(684, 701);
            panelFill.TabIndex = 1;
            // 
            // checkBoxExcluded
            // 
            checkBoxExcluded.AutoSize = true;
            checkBoxExcluded.Dock = DockStyle.Top;
            checkBoxExcluded.Location = new Point(10, 619);
            checkBoxExcluded.Name = "checkBoxExcluded";
            checkBoxExcluded.Size = new Size(664, 29);
            checkBoxExcluded.TabIndex = 49;
            checkBoxExcluded.Text = "Отчислен";
            checkBoxExcluded.UseVisualStyleBackColor = true;
            // 
            // checkBoxFullAge
            // 
            checkBoxFullAge.AutoSize = true;
            checkBoxFullAge.Dock = DockStyle.Top;
            checkBoxFullAge.Location = new Point(10, 590);
            checkBoxFullAge.Name = "checkBoxFullAge";
            checkBoxFullAge.Size = new Size(664, 29);
            checkBoxFullAge.TabIndex = 48;
            checkBoxFullAge.Text = "Совершеннолетний";
            checkBoxFullAge.UseVisualStyleBackColor = true;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Dock = DockStyle.Top;
            textBoxPhoneNumber.Location = new Point(10, 557);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(664, 33);
            textBoxPhoneNumber.TabIndex = 47;
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Dock = DockStyle.Top;
            labelPhoneNumber.Location = new Point(10, 532);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(166, 25);
            labelPhoneNumber.TabIndex = 46;
            labelPhoneNumber.Text = "Номер телефона*";
            // 
            // numericUpDownRoleInGroup
            // 
            numericUpDownRoleInGroup.Dock = DockStyle.Top;
            numericUpDownRoleInGroup.Location = new Point(10, 499);
            numericUpDownRoleInGroup.Name = "numericUpDownRoleInGroup";
            numericUpDownRoleInGroup.Size = new Size(664, 33);
            numericUpDownRoleInGroup.TabIndex = 45;
            // 
            // labelRoleInGrop
            // 
            labelRoleInGrop.AutoSize = true;
            labelRoleInGrop.Dock = DockStyle.Top;
            labelRoleInGrop.Location = new Point(10, 474);
            labelRoleInGrop.Name = "labelRoleInGrop";
            labelRoleInGrop.Size = new Size(141, 25);
            labelRoleInGrop.TabIndex = 43;
            labelRoleInGrop.Text = "Роль в группе*";
            // 
            // numericUpDownGroup
            // 
            numericUpDownGroup.Dock = DockStyle.Top;
            numericUpDownGroup.Location = new Point(10, 441);
            numericUpDownGroup.Name = "numericUpDownGroup";
            numericUpDownGroup.Size = new Size(664, 33);
            numericUpDownGroup.TabIndex = 42;
            // 
            // labelGroup
            // 
            labelGroup.AutoSize = true;
            labelGroup.Dock = DockStyle.Top;
            labelGroup.Location = new Point(10, 416);
            labelGroup.Name = "labelGroup";
            labelGroup.Size = new Size(81, 25);
            labelGroup.TabIndex = 41;
            labelGroup.Text = "Группа*";
            // 
            // numericUpDownSubgroup
            // 
            numericUpDownSubgroup.Dock = DockStyle.Top;
            numericUpDownSubgroup.Location = new Point(10, 383);
            numericUpDownSubgroup.Name = "numericUpDownSubgroup";
            numericUpDownSubgroup.Size = new Size(664, 33);
            numericUpDownSubgroup.TabIndex = 40;
            // 
            // labelSubgroup
            // 
            labelSubgroup.AutoSize = true;
            labelSubgroup.Dock = DockStyle.Top;
            labelSubgroup.Location = new Point(10, 358);
            labelSubgroup.Name = "labelSubgroup";
            labelSubgroup.Size = new Size(114, 25);
            labelSubgroup.TabIndex = 39;
            labelSubgroup.Text = "Подгруппа*";
            // 
            // textBoxActualAddress
            // 
            textBoxActualAddress.Dock = DockStyle.Top;
            textBoxActualAddress.Location = new Point(10, 325);
            textBoxActualAddress.Name = "textBoxActualAddress";
            textBoxActualAddress.Size = new Size(664, 33);
            textBoxActualAddress.TabIndex = 38;
            // 
            // labelActualAddress
            // 
            labelActualAddress.AutoSize = true;
            labelActualAddress.Dock = DockStyle.Top;
            labelActualAddress.Location = new Point(10, 300);
            labelActualAddress.Name = "labelActualAddress";
            labelActualAddress.Size = new Size(312, 25);
            labelActualAddress.TabIndex = 33;
            labelActualAddress.Text = "Фактический адресс проживания*";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Dock = DockStyle.Top;
            textBoxEmail.Location = new Point(10, 267);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(664, 33);
            textBoxEmail.TabIndex = 32;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Dock = DockStyle.Top;
            labelEmail.Location = new Point(10, 242);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(240, 25);
            labelEmail.TabIndex = 31;
            labelEmail.Text = "Адрес электронной почты";
            // 
            // dateTimePickerBirthday
            // 
            dateTimePickerBirthday.Dock = DockStyle.Top;
            dateTimePickerBirthday.Location = new Point(10, 209);
            dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            dateTimePickerBirthday.Size = new Size(664, 33);
            dateTimePickerBirthday.TabIndex = 26;
            // 
            // labelBirthday
            // 
            labelBirthday.AutoSize = true;
            labelBirthday.Dock = DockStyle.Top;
            labelBirthday.Location = new Point(10, 184);
            labelBirthday.Name = "labelBirthday";
            labelBirthday.Size = new Size(157, 25);
            labelBirthday.TabIndex = 6;
            labelBirthday.Text = "День рождения*";
            // 
            // textBoxPatronymic
            // 
            textBoxPatronymic.Dock = DockStyle.Top;
            textBoxPatronymic.Location = new Point(10, 151);
            textBoxPatronymic.Name = "textBoxPatronymic";
            textBoxPatronymic.Size = new Size(664, 33);
            textBoxPatronymic.TabIndex = 5;
            // 
            // labelPatronymic
            // 
            labelPatronymic.AutoSize = true;
            labelPatronymic.Dock = DockStyle.Top;
            labelPatronymic.Location = new Point(10, 126);
            labelPatronymic.Name = "labelPatronymic";
            labelPatronymic.Size = new Size(93, 25);
            labelPatronymic.TabIndex = 4;
            labelPatronymic.Text = "Отчество";
            // 
            // textBoxName
            // 
            textBoxName.Dock = DockStyle.Top;
            textBoxName.Location = new Point(10, 93);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(664, 33);
            textBoxName.TabIndex = 3;
            textBoxName.Validating += TextBoxName_Validating;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Dock = DockStyle.Top;
            labelName.Location = new Point(10, 68);
            labelName.Name = "labelName";
            labelName.Size = new Size(57, 25);
            labelName.TabIndex = 2;
            labelName.Text = "Имя*";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Dock = DockStyle.Top;
            textBoxSurname.Location = new Point(10, 35);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(664, 33);
            textBoxSurname.TabIndex = 1;
            textBoxSurname.Validating += TextBoxSurname_Validating;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Dock = DockStyle.Top;
            labelSurname.Location = new Point(10, 10);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(99, 25);
            labelSurname.TabIndex = 0;
            labelSurname.Text = "Фамилия*";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormAddStudent
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(684, 761);
            Controls.Add(panelFill);
            Controls.Add(panelBottom);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormAddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "добавление\\редактирование студента";
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRoleInGroup).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGroup).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSubgroup).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBottom;
        private Button buttonCancel;
        private Button buttonSave;
        private Panel panelFill;
        private Label labelSurname;
        private Label labelGroup2;
        private Label labelActualAddress2;
        private Label labelBirthday;
        private Label labelPatronymic;
        private Label labelName;
        private Label labelRoleInGrop2;
        protected internal TextBox textBoxPatronymic;
        protected internal TextBox textBoxName;
        protected internal TextBox textBoxSurname;
        protected internal TextBox textBoxPhoneNumber2;
        private Label labelEmail;
        private Label labelActualAddress;
        private Label labelSubgroup;
        private Label labelGroup;
        private Label labelRoleInGrop;
        private Label labelPhoneNumber;
        protected internal DateTimePicker dateTimePickerBirthday;
        protected internal TextBox textBoxEmail;
        protected internal TextBox textBoxActualAddress;
        protected internal NumericUpDown numericUpDownSubgroup;
        protected internal NumericUpDown numericUpDownGroup;
        protected internal NumericUpDown numericUpDownRoleInGroup;
        protected internal TextBox textBoxPhoneNumber;
        protected internal CheckBox checkBoxFullAge;
        protected internal CheckBox checkBoxExcluded;
        private ErrorProvider errorProvider;
    }
}