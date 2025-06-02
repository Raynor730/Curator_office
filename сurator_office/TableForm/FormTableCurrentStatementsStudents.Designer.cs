namespace сurator_office.TableForm
{
    partial class FormTableCurrentStatementsStudents
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
            dataGridViewCurrentStatementsStudents = new DataGridView();
            flowLayoutPanelTop.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCurrentStatementsStudents).BeginInit();
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
            flowLayoutPanelTop.TabIndex = 3;
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
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewCurrentStatementsStudents);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 61);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(984, 500);
            panelFill.TabIndex = 4;
            // 
            // dataGridViewCurrentStatementsStudents
            // 
            dataGridViewCurrentStatementsStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCurrentStatementsStudents.BackgroundColor = Color.White;
            dataGridViewCurrentStatementsStudents.Dock = DockStyle.Fill;
            dataGridViewCurrentStatementsStudents.Location = new Point(10, 10);
            dataGridViewCurrentStatementsStudents.MultiSelect = false;
            dataGridViewCurrentStatementsStudents.Name = "dataGridViewCurrentStatementsStudents";
            dataGridViewCurrentStatementsStudents.ReadOnly = true;
            dataGridViewCurrentStatementsStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCurrentStatementsStudents.Size = new Size(964, 480);
            dataGridViewCurrentStatementsStudents.TabIndex = 0;
            // 
            // FormTableCurrentStatementsStudents
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 561);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormTableCurrentStatementsStudents";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTableCurrentStatementsStudents";
            flowLayoutPanelTop.ResumeLayout(false);
            flowLayoutPanelTop.PerformLayout();
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCurrentStatementsStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelTop;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Panel panelFill;
        private DataGridView dataGridViewCurrentStatementsStudents;
    }
}