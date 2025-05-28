namespace сurator_office
{
    partial class FormMenu
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
            panelFill = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            ButtonShowDisciplinesTeachers = new Button();
            ButtonShowInterimStatements = new Button();
            panelLeft = new Panel();
            ButtonShowTypesIntermediateAttestation = new Button();
            ButtonShowRolesInGroup = new Button();
            ButtonShowGroups = new Button();
            labelPanelLeft = new Label();
            ButtonShowTeachers = new Button();
            ButtonShowDisciplines = new Button();
            ButtonShowStudents = new Button();
            panelFill.SuspendLayout();
            panel1.SuspendLayout();
            panelLeft.SuspendLayout();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.Controls.Add(panel1);
            panelFill.Controls.Add(panelLeft);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Margin = new Padding(10);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(684, 461);
            panelFill.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ButtonShowDisciplinesTeachers);
            panel1.Controls.Add(ButtonShowInterimStatements);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(351, 10);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(321, 441);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 10);
            label1.Name = "label1";
            label1.Size = new Size(237, 25);
            label1.TabIndex = 9;
            label1.Text = "Промежуточные таблицы";
            // 
            // ButtonShowDisciplinesTeachers
            // 
            ButtonShowDisciplinesTeachers.AutoSize = true;
            ButtonShowDisciplinesTeachers.Location = new Point(13, 38);
            ButtonShowDisciplinesTeachers.Name = "ButtonShowDisciplinesTeachers";
            ButtonShowDisciplinesTeachers.Size = new Size(295, 35);
            ButtonShowDisciplinesTeachers.TabIndex = 6;
            ButtonShowDisciplinesTeachers.Text = "Дисциплины у преподавателей";
            ButtonShowDisciplinesTeachers.UseVisualStyleBackColor = true;
            // 
            // ButtonShowInterimStatements
            // 
            ButtonShowInterimStatements.AutoSize = true;
            ButtonShowInterimStatements.Location = new Point(13, 109);
            ButtonShowInterimStatements.Name = "ButtonShowInterimStatements";
            ButtonShowInterimStatements.Size = new Size(267, 35);
            ButtonShowInterimStatements.TabIndex = 8;
            ButtonShowInterimStatements.Text = "вид аттестации у предметов";
            ButtonShowInterimStatements.UseVisualStyleBackColor = true;
            // 
            // panelLeft
            // 
            panelLeft.AutoSize = true;
            panelLeft.Controls.Add(ButtonShowTypesIntermediateAttestation);
            panelLeft.Controls.Add(ButtonShowRolesInGroup);
            panelLeft.Controls.Add(ButtonShowGroups);
            panelLeft.Controls.Add(labelPanelLeft);
            panelLeft.Controls.Add(ButtonShowTeachers);
            panelLeft.Controls.Add(ButtonShowDisciplines);
            panelLeft.Controls.Add(ButtonShowStudents);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(10, 10);
            panelLeft.Margin = new Padding(0);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(10);
            panelLeft.Size = new Size(341, 441);
            panelLeft.TabIndex = 5;
            // 
            // ButtonShowTypesIntermediateAttestation
            // 
            ButtonShowTypesIntermediateAttestation.AutoSize = true;
            ButtonShowTypesIntermediateAttestation.Location = new Point(13, 43);
            ButtonShowTypesIntermediateAttestation.Name = "ButtonShowTypesIntermediateAttestation";
            ButtonShowTypesIntermediateAttestation.Size = new Size(315, 35);
            ButtonShowTypesIntermediateAttestation.TabIndex = 7;
            ButtonShowTypesIntermediateAttestation.Text = "Типы промежуточной аттестации";
            ButtonShowTypesIntermediateAttestation.UseVisualStyleBackColor = true;
            // 
            // ButtonShowRolesInGroup
            // 
            ButtonShowRolesInGroup.AutoSize = true;
            ButtonShowRolesInGroup.Location = new Point(13, 155);
            ButtonShowRolesInGroup.Name = "ButtonShowRolesInGroup";
            ButtonShowRolesInGroup.Size = new Size(200, 35);
            ButtonShowRolesInGroup.TabIndex = 5;
            ButtonShowRolesInGroup.Text = "Роли в группе";
            ButtonShowRolesInGroup.UseVisualStyleBackColor = true;
            ButtonShowRolesInGroup.Click += ButtonShowRolesInGroup_Click;
            // 
            // ButtonShowGroups
            // 
            ButtonShowGroups.AutoSize = true;
            ButtonShowGroups.Location = new Point(149, 196);
            ButtonShowGroups.Name = "ButtonShowGroups";
            ButtonShowGroups.Size = new Size(130, 35);
            ButtonShowGroups.TabIndex = 2;
            ButtonShowGroups.Text = "Группы";
            ButtonShowGroups.UseVisualStyleBackColor = true;
            ButtonShowGroups.Click += ButtonShowGroups_Click;
            // 
            // labelPanelLeft
            // 
            labelPanelLeft.AutoSize = true;
            labelPanelLeft.Location = new Point(103, 10);
            labelPanelLeft.Name = "labelPanelLeft";
            labelPanelLeft.Size = new Size(130, 25);
            labelPanelLeft.TabIndex = 0;
            labelPanelLeft.Text = "Справочники";
            // 
            // ButtonShowTeachers
            // 
            ButtonShowTeachers.AutoSize = true;
            ButtonShowTeachers.Location = new Point(152, 114);
            ButtonShowTeachers.Name = "ButtonShowTeachers";
            ButtonShowTeachers.Size = new Size(158, 35);
            ButtonShowTeachers.TabIndex = 3;
            ButtonShowTeachers.Text = "Преподаватели";
            ButtonShowTeachers.UseVisualStyleBackColor = true;
            ButtonShowTeachers.Click += ButtonShowTeachers_Click;
            // 
            // ButtonShowDisciplines
            // 
            ButtonShowDisciplines.AutoSize = true;
            ButtonShowDisciplines.Location = new Point(13, 114);
            ButtonShowDisciplines.Name = "ButtonShowDisciplines";
            ButtonShowDisciplines.Size = new Size(133, 35);
            ButtonShowDisciplines.TabIndex = 4;
            ButtonShowDisciplines.Text = "Дисциплины";
            ButtonShowDisciplines.UseVisualStyleBackColor = true;
            // 
            // ButtonShowStudents
            // 
            ButtonShowStudents.AutoSize = true;
            ButtonShowStudents.Location = new Point(13, 196);
            ButtonShowStudents.Name = "ButtonShowStudents";
            ButtonShowStudents.Size = new Size(130, 35);
            ButtonShowStudents.TabIndex = 1;
            ButtonShowStudents.Text = "Студенты";
            ButtonShowStudents.UseVisualStyleBackColor = true;
            ButtonShowStudents.Click += ButtonShowStudents_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(684, 461);
            Controls.Add(panelFill);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += FormMenu_Load;
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFill;
        private Button ButtonShowStudents;
        private Button ButtonShowTeachers;
        private Button ButtonShowDisciplines;
        private Panel panelLeft;
        private Label labelPanelLeft;
        private Button ButtonShowTypesIntermediateAttestation;
        private Button ButtonShowInterimStatements;
        private Button ButtonShowRolesInGroup;
        private Button ButtonShowGroups;
        private Button ButtonShowDisciplinesTeachers;
        private Panel panel1;
        private Label label1;
    }
}
