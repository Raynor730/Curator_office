namespace сurator_office
{
    partial class FormAddRolesInGroup
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
            textBoxRole = new TextBox();
            labelRole = new Label();
            errorProvider = new ErrorProvider(components);
            errorProvider1 = new ErrorProvider(components);
            panelBottom.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(buttonCancel);
            panelBottom.Controls.Add(buttonSave);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 76);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(10);
            panelBottom.Size = new Size(484, 60);
            panelBottom.TabIndex = 1;
            // 
            // buttonCancel
            // 
            buttonCancel.AutoSize = true;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(133, 13);
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
            buttonSave.Location = new Point(12, 12);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(115, 35);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(textBoxRole);
            panelFill.Controls.Add(labelRole);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(484, 76);
            panelFill.TabIndex = 2;
            // 
            // textBoxRole
            // 
            textBoxRole.Dock = DockStyle.Top;
            textBoxRole.Location = new Point(10, 35);
            textBoxRole.Name = "textBoxRole";
            textBoxRole.Size = new Size(464, 33);
            textBoxRole.TabIndex = 1;
            textBoxRole.Validating += textBoxRole_Validating;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Dock = DockStyle.Top;
            labelRole.Location = new Point(10, 10);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(62, 25);
            labelRole.TabIndex = 0;
            labelRole.Text = "Роль*";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormAddRolesInGroup
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(484, 136);
            Controls.Add(panelFill);
            Controls.Add(panelBottom);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormAddRolesInGroup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddRolesInGroup";
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBottom;
        private Button buttonCancel;
        private Button buttonSave;
        private Panel panelFill;
        protected internal TextBox textBoxRole;
        private Label labelRole;
        private ErrorProvider errorProvider;
        private ErrorProvider errorProvider1;
    }
}