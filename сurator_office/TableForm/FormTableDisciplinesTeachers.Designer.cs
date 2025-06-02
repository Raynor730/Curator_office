namespace сurator_office.TableForm
{
    partial class FormTableDisciplinesTeachers
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
            flowLayoutPanelTop = new FlowLayoutPanel();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            panelFill = new Panel();
            dataGridViewDisciplinesTeachers = new DataGridView();
            flowLayoutPanelTop.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDisciplinesTeachers).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.AutoSize = true;
            flowLayoutPanelTop.BackColor = Color.White;
            flowLayoutPanelTop.Controls.Add(buttonAdd);
            flowLayoutPanelTop.Controls.Add(buttonUpdate);
            flowLayoutPanelTop.Controls.Add(buttonDelete);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Margin = new Padding(5);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Padding = new Padding(10);
            flowLayoutPanelTop.Size = new Size(984, 61);
            flowLayoutPanelTop.TabIndex = 4;
            // 
            // buttonAdd
            // 
            buttonAdd.AutoSize = true;
            buttonAdd.Location = new Point(13, 13);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(106, 35);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.AutoSize = true;
            buttonUpdate.Location = new Point(125, 13);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(107, 35);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Изменить";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.AutoSize = true;
            buttonDelete.Location = new Point(238, 13);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(100, 35);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewDisciplinesTeachers);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 61);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(984, 500);
            panelFill.TabIndex = 5;
            // 
            // dataGridViewDisciplinesTeachers
            // 
            dataGridViewDisciplinesTeachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewDisciplinesTeachers.BackgroundColor = Color.White;
            dataGridViewDisciplinesTeachers.Dock = DockStyle.Fill;
            dataGridViewDisciplinesTeachers.Location = new Point(10, 10);
            dataGridViewDisciplinesTeachers.MultiSelect = false;
            dataGridViewDisciplinesTeachers.Name = "dataGridViewDisciplinesTeachers";
            dataGridViewDisciplinesTeachers.ReadOnly = true;
            dataGridViewDisciplinesTeachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDisciplinesTeachers.Size = new Size(964, 480);
            dataGridViewDisciplinesTeachers.TabIndex = 0;
            // 
            // FormTableDisciplinesTeachers
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 561);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormTableDisciplinesTeachers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTableDisciplinesTeachers";
            flowLayoutPanelTop.ResumeLayout(false);
            flowLayoutPanelTop.PerformLayout();
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDisciplinesTeachers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelTop;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Panel panelFill;
        private DataGridView dataGridViewDisciplinesTeachers;
    }
}