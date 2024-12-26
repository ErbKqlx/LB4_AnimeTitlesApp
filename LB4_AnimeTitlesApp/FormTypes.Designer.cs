namespace LB4_AnimeTitlesApp
{
    partial class FormTypes
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
            flowLayoutPanelTop = new FlowLayoutPanel();
            buttonTypeAdd = new Button();
            buttonTypeUpdate = new Button();
            buttonTypeDelete = new Button();
            panelFill = new Panel();
            dataGridViewTypes = new DataGridView();
            flowLayoutPanelTop.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.AutoSize = true;
            flowLayoutPanelTop.Controls.Add(buttonTypeAdd);
            flowLayoutPanelTop.Controls.Add(buttonTypeUpdate);
            flowLayoutPanelTop.Controls.Add(buttonTypeDelete);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Margin = new Padding(5);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Padding = new Padding(16, 17, 16, 17);
            flowLayoutPanelTop.Size = new Size(1096, 90);
            flowLayoutPanelTop.TabIndex = 0;
            // 
            // buttonTypeAdd
            // 
            buttonTypeAdd.BackColor = Color.White;
            buttonTypeAdd.Location = new Point(21, 22);
            buttonTypeAdd.Margin = new Padding(5);
            buttonTypeAdd.Name = "buttonTypeAdd";
            buttonTypeAdd.Size = new Size(157, 46);
            buttonTypeAdd.TabIndex = 0;
            buttonTypeAdd.Text = "Добавить";
            buttonTypeAdd.UseVisualStyleBackColor = false;
            buttonTypeAdd.Click += ButtonTypeAdd_Click;
            // 
            // buttonTypeUpdate
            // 
            buttonTypeUpdate.BackColor = Color.White;
            buttonTypeUpdate.Location = new Point(188, 22);
            buttonTypeUpdate.Margin = new Padding(5);
            buttonTypeUpdate.Name = "buttonTypeUpdate";
            buttonTypeUpdate.Size = new Size(157, 46);
            buttonTypeUpdate.TabIndex = 1;
            buttonTypeUpdate.Text = "Редактировать";
            buttonTypeUpdate.UseVisualStyleBackColor = false;
            buttonTypeUpdate.Click += ButtonTypeUpdate_Click;
            // 
            // buttonTypeDelete
            // 
            buttonTypeDelete.BackColor = Color.White;
            buttonTypeDelete.Location = new Point(355, 22);
            buttonTypeDelete.Margin = new Padding(5);
            buttonTypeDelete.Name = "buttonTypeDelete";
            buttonTypeDelete.Size = new Size(157, 46);
            buttonTypeDelete.TabIndex = 2;
            buttonTypeDelete.Text = "Удалить";
            buttonTypeDelete.UseVisualStyleBackColor = false;
            buttonTypeDelete.Click += ButtonTypeDelete_Click;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewTypes);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 90);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(1096, 516);
            panelFill.TabIndex = 1;
            // 
            // dataGridViewTypes
            // 
            dataGridViewTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dataGridViewTypes.BackgroundColor = Color.White;
            dataGridViewTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTypes.Dock = DockStyle.Fill;
            dataGridViewTypes.Location = new Point(10, 10);
            dataGridViewTypes.MultiSelect = false;
            dataGridViewTypes.Name = "dataGridViewTypes";
            dataGridViewTypes.ReadOnly = true;
            dataGridViewTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTypes.Size = new Size(1076, 496);
            dataGridViewTypes.TabIndex = 0;
            // 
            // FormTypes
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1096, 606);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelTop);
            Font = new Font("Segoe UI", 14.25F);
            Margin = new Padding(5);
            Name = "FormTypes";
            Text = "Типы аниме";
            WindowState = FormWindowState.Minimized;
            flowLayoutPanelTop.ResumeLayout(false);
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelTop;
        private Button buttonTypeAdd;
        private Button buttonTypeUpdate;
        private Button buttonTypeDelete;
        private Panel panelFill;
        private DataGridView dataGridViewTypes;
    }
}
