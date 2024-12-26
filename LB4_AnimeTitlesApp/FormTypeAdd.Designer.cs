namespace LB4_AnimeTitlesApp
{
    partial class FormTypeAdd
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
            panelFill = new Panel();
            textBoxTypeName = new TextBox();
            labelTypeName = new Label();
            flowLayoutPanelBottom = new FlowLayoutPanel();
            buttonCancel = new Button();
            buttonSave = new Button();
            errorProvider = new ErrorProvider(components);
            panelFill.SuspendLayout();
            flowLayoutPanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.Controls.Add(textBoxTypeName);
            panelFill.Controls.Add(labelTypeName);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(20);
            panelFill.Size = new Size(384, 151);
            panelFill.TabIndex = 0;
            // 
            // textBoxTypeName
            // 
            textBoxTypeName.Dock = DockStyle.Top;
            textBoxTypeName.Location = new Point(20, 45);
            textBoxTypeName.Name = "textBoxTypeName";
            textBoxTypeName.Size = new Size(344, 33);
            textBoxTypeName.TabIndex = 1;
            textBoxTypeName.TextChanged += TextBoxTypeName_TextChanged;
            textBoxTypeName.Validating += TextBoxTypeName_Validating;
            // 
            // labelTypeName
            // 
            labelTypeName.Dock = DockStyle.Top;
            labelTypeName.Location = new Point(20, 20);
            labelTypeName.Name = "labelTypeName";
            labelTypeName.Size = new Size(344, 25);
            labelTypeName.TabIndex = 0;
            labelTypeName.Text = "Тип аниме";
            // 
            // flowLayoutPanelBottom
            // 
            flowLayoutPanelBottom.AutoSize = true;
            flowLayoutPanelBottom.Controls.Add(buttonCancel);
            flowLayoutPanelBottom.Controls.Add(buttonSave);
            flowLayoutPanelBottom.Dock = DockStyle.Bottom;
            flowLayoutPanelBottom.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelBottom.Location = new Point(0, 91);
            flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            flowLayoutPanelBottom.Padding = new Padding(10);
            flowLayoutPanelBottom.Size = new Size(384, 60);
            flowLayoutPanelBottom.TabIndex = 1;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.White;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(237, 13);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(124, 34);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.White;
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Location = new Point(106, 13);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(125, 34);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormTypeAdd
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 151);
            Controls.Add(flowLayoutPanelBottom);
            Controls.Add(panelFill);
            Font = new Font("Segoe UI", 14.25F);
            Margin = new Padding(5);
            Name = "FormTypeAdd";
            StartPosition = FormStartPosition.CenterScreen;
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            flowLayoutPanelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelFill;
        private Label labelTypeName;
        private FlowLayoutPanel flowLayoutPanelBottom;
        private Button buttonCancel;
        private Button buttonSave;
        protected internal TextBox textBoxTypeName;
        private ErrorProvider errorProvider;
    }
}