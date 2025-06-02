namespace сurator_office
{
    partial class FormAddGroup
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
            numericUpDownYearOfGraduation = new NumericUpDown();
            labelYearOfGraduation = new Label();
            numericUpDownYearOfAdmission = new NumericUpDown();
            labelYearOfAdmission = new Label();
            textBoxSpecializationName = new TextBox();
            labelSpecializationName = new Label();
            textBoxSpecializationKode = new TextBox();
            labelSpecializationKode = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            errorProvider = new ErrorProvider(components);
            panelBottom.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYearOfGraduation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYearOfAdmission).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(buttonCancel);
            panelBottom.Controls.Add(buttonSave);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 326);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(10, 10, 25, 10);
            panelBottom.Size = new Size(984, 60);
            panelBottom.TabIndex = 2;
            // 
            // buttonCancel
            // 
            buttonCancel.AutoSize = true;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(134, 13);
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
            panelFill.Controls.Add(numericUpDownYearOfGraduation);
            panelFill.Controls.Add(labelYearOfGraduation);
            panelFill.Controls.Add(numericUpDownYearOfAdmission);
            panelFill.Controls.Add(labelYearOfAdmission);
            panelFill.Controls.Add(textBoxSpecializationName);
            panelFill.Controls.Add(labelSpecializationName);
            panelFill.Controls.Add(textBoxSpecializationKode);
            panelFill.Controls.Add(labelSpecializationKode);
            panelFill.Controls.Add(textBoxName);
            panelFill.Controls.Add(labelName);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10, 10, 25, 10);
            panelFill.Size = new Size(984, 326);
            panelFill.TabIndex = 3;
            // 
            // numericUpDownYearOfGraduation
            // 
            numericUpDownYearOfGraduation.Dock = DockStyle.Top;
            numericUpDownYearOfGraduation.Location = new Point(10, 267);
            numericUpDownYearOfGraduation.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownYearOfGraduation.Name = "numericUpDownYearOfGraduation";
            numericUpDownYearOfGraduation.Size = new Size(949, 33);
            numericUpDownYearOfGraduation.TabIndex = 9;
            numericUpDownYearOfGraduation.Validating += numericUpDownYearOfGraduation_Validating;
            // 
            // labelYearOfGraduation
            // 
            labelYearOfGraduation.AutoSize = true;
            labelYearOfGraduation.Dock = DockStyle.Top;
            labelYearOfGraduation.Location = new Point(10, 242);
            labelYearOfGraduation.Name = "labelYearOfGraduation";
            labelYearOfGraduation.Size = new Size(118, 25);
            labelYearOfGraduation.TabIndex = 8;
            labelYearOfGraduation.Text = "Год выпуска";
            // 
            // numericUpDownYearOfAdmission
            // 
            numericUpDownYearOfAdmission.Dock = DockStyle.Top;
            numericUpDownYearOfAdmission.Location = new Point(10, 209);
            numericUpDownYearOfAdmission.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownYearOfAdmission.Name = "numericUpDownYearOfAdmission";
            numericUpDownYearOfAdmission.Size = new Size(949, 33);
            numericUpDownYearOfAdmission.TabIndex = 7;
            numericUpDownYearOfAdmission.Validating += numericUpDownYearOfAdmission_Validating;
            // 
            // labelYearOfAdmission
            // 
            labelYearOfAdmission.AutoSize = true;
            labelYearOfAdmission.Dock = DockStyle.Top;
            labelYearOfAdmission.Location = new Point(10, 184);
            labelYearOfAdmission.Name = "labelYearOfAdmission";
            labelYearOfAdmission.Size = new Size(158, 25);
            labelYearOfAdmission.TabIndex = 6;
            labelYearOfAdmission.Text = "Год поступления";
            // 
            // textBoxSpecializationName
            // 
            textBoxSpecializationName.Dock = DockStyle.Top;
            textBoxSpecializationName.Location = new Point(10, 151);
            textBoxSpecializationName.Name = "textBoxSpecializationName";
            textBoxSpecializationName.Size = new Size(949, 33);
            textBoxSpecializationName.TabIndex = 5;
            textBoxSpecializationName.Validating += textBoxSpecializationName_Validating;
            // 
            // labelSpecializationName
            // 
            labelSpecializationName.AutoSize = true;
            labelSpecializationName.Dock = DockStyle.Top;
            labelSpecializationName.Location = new Point(10, 126);
            labelSpecializationName.Name = "labelSpecializationName";
            labelSpecializationName.Size = new Size(304, 25);
            labelSpecializationName.TabIndex = 4;
            labelSpecializationName.Text = "Полное название специализации";
            // 
            // textBoxSpecializationKode
            // 
            textBoxSpecializationKode.Dock = DockStyle.Top;
            textBoxSpecializationKode.Location = new Point(10, 93);
            textBoxSpecializationKode.Name = "textBoxSpecializationKode";
            textBoxSpecializationKode.Size = new Size(949, 33);
            textBoxSpecializationKode.TabIndex = 3;
            textBoxSpecializationKode.Validating += textBoxSpecializationKode_Validating;
            // 
            // labelSpecializationKode
            // 
            labelSpecializationKode.AutoSize = true;
            labelSpecializationKode.Dock = DockStyle.Top;
            labelSpecializationKode.Location = new Point(10, 68);
            labelSpecializationKode.Name = "labelSpecializationKode";
            labelSpecializationKode.Size = new Size(181, 25);
            labelSpecializationKode.TabIndex = 2;
            labelSpecializationKode.Text = "Код специальности";
            // 
            // textBoxName
            // 
            textBoxName.Dock = DockStyle.Top;
            textBoxName.Location = new Point(10, 35);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(949, 33);
            textBoxName.TabIndex = 1;
            textBoxName.Validating += textBoxName_Validating;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Dock = DockStyle.Top;
            labelName.Location = new Point(10, 10);
            labelName.Name = "labelName";
            labelName.Size = new Size(359, 25);
            labelName.TabIndex = 0;
            labelName.Text = "Сокращенное название специализации";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormAddGroup
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 386);
            Controls.Add(panelFill);
            Controls.Add(panelBottom);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormAddGroup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddGroup";
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYearOfGraduation).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYearOfAdmission).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBottom;
        private Button buttonCancel;
        private Button buttonSave;
        private Panel panelFill;
        private Label labelName;
        private Label labelSpecializationKode;
        private Label labelSpecializationName;
        private Label labelYearOfAdmission;
        private Label labelYearOfGraduation;
        protected internal TextBox textBoxName;
        protected internal TextBox textBoxSpecializationKode;
        protected internal TextBox textBoxSpecializationName;
        protected internal NumericUpDown numericUpDownYearOfAdmission;
        protected internal NumericUpDown numericUpDownYearOfGraduation;
        private ErrorProvider errorProvider;
    }
}