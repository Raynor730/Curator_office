namespace сurator_office
{
    partial class FormAddTeacher
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
            textBoxPatronymic = new TextBox();
            labelPatronymic = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            textBoxSurname = new TextBox();
            labelSurname = new Label();
            errorProvider = new ErrorProvider(components);
            panelBottom.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(buttonCancel);
            panelBottom.Controls.Add(buttonSave);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 201);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(10, 10, 25, 10);
            panelBottom.Size = new Size(584, 60);
            panelBottom.TabIndex = 1;
            // 
            // buttonCancel
            // 
            buttonCancel.AutoSize = true;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(134, 12);
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
            buttonSave.Location = new Point(13, 13);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(115, 35);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(textBoxPatronymic);
            panelFill.Controls.Add(labelPatronymic);
            panelFill.Controls.Add(textBoxName);
            panelFill.Controls.Add(labelName);
            panelFill.Controls.Add(textBoxSurname);
            panelFill.Controls.Add(labelSurname);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10, 10, 25, 10);
            panelFill.Size = new Size(584, 201);
            panelFill.TabIndex = 0;
            // 
            // textBoxPatronymic
            // 
            textBoxPatronymic.Dock = DockStyle.Top;
            textBoxPatronymic.Location = new Point(10, 151);
            textBoxPatronymic.Name = "textBoxPatronymic";
            textBoxPatronymic.Size = new Size(549, 33);
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
            textBoxName.Size = new Size(549, 33);
            textBoxName.TabIndex = 3;
            textBoxName.Validating += textBoxName_Validating;
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
            textBoxSurname.Size = new Size(549, 33);
            textBoxSurname.TabIndex = 1;
            textBoxSurname.Validating += textBoxSurname_Validating;
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
            // FormAddTeacher
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(584, 261);
            Controls.Add(panelFill);
            Controls.Add(panelBottom);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormAddTeacher";
            Text = "добавление\\редактирование учителя";
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBottom;
        private Button buttonCancel;
        private Button buttonSave;
        private Panel panelFill;
        protected internal TextBox textBoxPatronymic;
        private Label labelPatronymic;
        protected internal TextBox textBoxName;
        private Label labelName;
        protected internal TextBox textBoxSurname;
        private Label labelSurname;
        private ErrorProvider errorProvider;
    }
}