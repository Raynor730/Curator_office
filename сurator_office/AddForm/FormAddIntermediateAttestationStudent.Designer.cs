namespace сurator_office.AddForm
{
    partial class FormAddIntermediateAttestationStudent
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
            panelBottom = new Panel();
            buttonCancel = new Button();
            buttonSave = new Button();
            panelFill = new Panel();
            textBoxDisciplineName = new TextBox();
            labelDisciplineName = new Label();
            textBoxKode = new TextBox();
            labelKode = new Label();
            panelBottom.SuspendLayout();
            panelFill.SuspendLayout();
            SuspendLayout();
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(buttonCancel);
            panelBottom.Controls.Add(buttonSave);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 501);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(10, 10, 25, 10);
            panelBottom.Size = new Size(984, 60);
            panelBottom.TabIndex = 4;
            // 
            // buttonCancel
            // 
            buttonCancel.AutoSize = true;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(141, 23);
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
            buttonSave.Location = new Point(20, 23);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(115, 35);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(textBoxDisciplineName);
            panelFill.Controls.Add(labelDisciplineName);
            panelFill.Controls.Add(textBoxKode);
            panelFill.Controls.Add(labelKode);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10, 10, 25, 10);
            panelFill.Size = new Size(984, 501);
            panelFill.TabIndex = 5;
            // 
            // textBoxDisciplineName
            // 
            textBoxDisciplineName.Dock = DockStyle.Top;
            textBoxDisciplineName.Location = new Point(10, 93);
            textBoxDisciplineName.Name = "textBoxDisciplineName";
            textBoxDisciplineName.Size = new Size(949, 33);
            textBoxDisciplineName.TabIndex = 3;
            // 
            // labelDisciplineName
            // 
            labelDisciplineName.AutoSize = true;
            labelDisciplineName.Dock = DockStyle.Top;
            labelDisciplineName.Location = new Point(10, 68);
            labelDisciplineName.Name = "labelDisciplineName";
            labelDisciplineName.Size = new Size(208, 25);
            labelDisciplineName.TabIndex = 2;
            labelDisciplineName.Text = "Название дисциплины";
            // 
            // textBoxKode
            // 
            textBoxKode.Dock = DockStyle.Top;
            textBoxKode.Location = new Point(10, 35);
            textBoxKode.Name = "textBoxKode";
            textBoxKode.Size = new Size(949, 33);
            textBoxKode.TabIndex = 1;
            // 
            // labelKode
            // 
            labelKode.AutoSize = true;
            labelKode.Dock = DockStyle.Top;
            labelKode.Location = new Point(10, 10);
            labelKode.Name = "labelKode";
            labelKode.Size = new Size(155, 25);
            labelKode.TabIndex = 0;
            labelKode.Text = "код дисциплины";
            // 
            // FormAddIntermediateAttestationStudent
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 561);
            Controls.Add(panelFill);
            Controls.Add(panelBottom);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FormAddIntermediateAttestationStudent";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormAddIntermediateAttestationStudent";
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBottom;
        private Button buttonCancel;
        private Button buttonSave;
        private Panel panelFill;
        protected internal TextBox textBoxDisciplineName;
        private Label labelDisciplineName;
        protected internal TextBox textBoxKode;
        private Label labelKode;
    }
}