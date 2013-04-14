namespace DicaUsuario
{
    internal partial class DicaForm
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
            this.SairButton = new System.Windows.Forms.Button();
            this.PrincipalSplitContainer = new System.Windows.Forms.SplitContainer();
            this.ExemploGroupBox = new System.Windows.Forms.GroupBox();
            this.ExemploTextBox = new System.Windows.Forms.TextBox();
            this.ExemploComboBox = new System.Windows.Forms.ComboBox();
            this.ExemploComboBoxLabel = new System.Windows.Forms.Label();
            this.ExemploTextBoxLabel = new System.Windows.Forms.Label();
            this.ConfigGroupBox = new System.Windows.Forms.GroupBox();
            this.DefinirDicaButton = new System.Windows.Forms.Button();
            this.LimparDicaButton = new System.Windows.Forms.Button();
            this.DicaTextBox = new System.Windows.Forms.TextBox();
            this.DicaLabel = new System.Windows.Forms.Label();
            this.PrincipalSplitContainer.Panel1.SuspendLayout();
            this.PrincipalSplitContainer.Panel2.SuspendLayout();
            this.PrincipalSplitContainer.SuspendLayout();
            this.ExemploGroupBox.SuspendLayout();
            this.ConfigGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SairButton
            // 
            this.SairButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SairButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SairButton.Location = new System.Drawing.Point(468, 154);
            this.SairButton.Name = "SairButton";
            this.SairButton.Size = new System.Drawing.Size(75, 23);
            this.SairButton.TabIndex = 0;
            this.SairButton.Text = "Sai&r";
            this.SairButton.UseVisualStyleBackColor = true;
            this.SairButton.Click += new System.EventHandler(this.SairButton_Click);
            // 
            // PrincipalSplitContainer
            // 
            this.PrincipalSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrincipalSplitContainer.Location = new System.Drawing.Point(12, 12);
            this.PrincipalSplitContainer.Name = "PrincipalSplitContainer";
            // 
            // PrincipalSplitContainer.Panel1
            // 
            this.PrincipalSplitContainer.Panel1.Controls.Add(this.ExemploGroupBox);
            this.PrincipalSplitContainer.Panel1MinSize = 120;
            // 
            // PrincipalSplitContainer.Panel2
            // 
            this.PrincipalSplitContainer.Panel2.Controls.Add(this.ConfigGroupBox);
            this.PrincipalSplitContainer.Panel2MinSize = 120;
            this.PrincipalSplitContainer.Size = new System.Drawing.Size(531, 136);
            this.PrincipalSplitContainer.SplitterDistance = 260;
            this.PrincipalSplitContainer.TabIndex = 1;
            // 
            // ExemploGroupBox
            // 
            this.ExemploGroupBox.Controls.Add(this.ExemploTextBox);
            this.ExemploGroupBox.Controls.Add(this.ExemploComboBox);
            this.ExemploGroupBox.Controls.Add(this.ExemploComboBoxLabel);
            this.ExemploGroupBox.Controls.Add(this.ExemploTextBoxLabel);
            this.ExemploGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExemploGroupBox.Location = new System.Drawing.Point(0, 0);
            this.ExemploGroupBox.Name = "ExemploGroupBox";
            this.ExemploGroupBox.Size = new System.Drawing.Size(260, 136);
            this.ExemploGroupBox.TabIndex = 0;
            this.ExemploGroupBox.TabStop = false;
            this.ExemploGroupBox.Text = "Exemplo";
            // 
            // ExemploTextBox
            // 
            this.ExemploTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExemploTextBox.Location = new System.Drawing.Point(9, 43);
            this.ExemploTextBox.Name = "ExemploTextBox";
            this.ExemploTextBox.Size = new System.Drawing.Size(244, 20);
            this.ExemploTextBox.TabIndex = 1;
            // 
            // ExemploComboBox
            // 
            this.ExemploComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExemploComboBox.FormattingEnabled = true;
            this.ExemploComboBox.Location = new System.Drawing.Point(9, 94);
            this.ExemploComboBox.Name = "ExemploComboBox";
            this.ExemploComboBox.Size = new System.Drawing.Size(244, 21);
            this.ExemploComboBox.TabIndex = 1;
            // 
            // ExemploComboBoxLabel
            // 
            this.ExemploComboBoxLabel.AutoSize = true;
            this.ExemploComboBoxLabel.Location = new System.Drawing.Point(6, 78);
            this.ExemploComboBoxLabel.Name = "ExemploComboBoxLabel";
            this.ExemploComboBoxLabel.Size = new System.Drawing.Size(125, 13);
            this.ExemploComboBoxLabel.TabIndex = 0;
            this.ExemploComboBoxLabel.Text = "Aplicação em ComboBox";
            // 
            // ExemploTextBoxLabel
            // 
            this.ExemploTextBoxLabel.AutoSize = true;
            this.ExemploTextBoxLabel.Location = new System.Drawing.Point(6, 27);
            this.ExemploTextBoxLabel.Name = "ExemploTextBoxLabel";
            this.ExemploTextBoxLabel.Size = new System.Drawing.Size(113, 13);
            this.ExemploTextBoxLabel.TabIndex = 0;
            this.ExemploTextBoxLabel.Text = "Aplicação em TextBox";
            // 
            // ConfigGroupBox
            // 
            this.ConfigGroupBox.Controls.Add(this.DefinirDicaButton);
            this.ConfigGroupBox.Controls.Add(this.LimparDicaButton);
            this.ConfigGroupBox.Controls.Add(this.DicaTextBox);
            this.ConfigGroupBox.Controls.Add(this.DicaLabel);
            this.ConfigGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfigGroupBox.Location = new System.Drawing.Point(0, 0);
            this.ConfigGroupBox.Name = "ConfigGroupBox";
            this.ConfigGroupBox.Size = new System.Drawing.Size(267, 136);
            this.ConfigGroupBox.TabIndex = 0;
            this.ConfigGroupBox.TabStop = false;
            this.ConfigGroupBox.Text = "Configuração";
            // 
            // DefinirDicaButton
            // 
            this.DefinirDicaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DefinirDicaButton.Location = new System.Drawing.Point(106, 69);
            this.DefinirDicaButton.Name = "DefinirDicaButton";
            this.DefinirDicaButton.Size = new System.Drawing.Size(75, 23);
            this.DefinirDicaButton.TabIndex = 2;
            this.DefinirDicaButton.Text = "&Definir";
            this.DefinirDicaButton.UseVisualStyleBackColor = true;
            this.DefinirDicaButton.Click += new System.EventHandler(this.DefinirDicaButton_Click);
            // 
            // LimparDicaButton
            // 
            this.LimparDicaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LimparDicaButton.Location = new System.Drawing.Point(187, 69);
            this.LimparDicaButton.Name = "LimparDicaButton";
            this.LimparDicaButton.Size = new System.Drawing.Size(75, 23);
            this.LimparDicaButton.TabIndex = 2;
            this.LimparDicaButton.Text = "&Limpar";
            this.LimparDicaButton.UseVisualStyleBackColor = true;
            this.LimparDicaButton.Click += new System.EventHandler(this.LimparDicaButton_Click);
            // 
            // DicaTextBox
            // 
            this.DicaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DicaTextBox.Location = new System.Drawing.Point(9, 43);
            this.DicaTextBox.Name = "DicaTextBox";
            this.DicaTextBox.Size = new System.Drawing.Size(253, 20);
            this.DicaTextBox.TabIndex = 1;
            this.DicaTextBox.Text = "Entre com os dados";
            // 
            // DicaLabel
            // 
            this.DicaLabel.AutoSize = true;
            this.DicaLabel.Location = new System.Drawing.Point(6, 27);
            this.DicaLabel.Name = "DicaLabel";
            this.DicaLabel.Size = new System.Drawing.Size(99, 13);
            this.DicaLabel.TabIndex = 0;
            this.DicaLabel.Text = "Dica para o usuário";
            // 
            // DicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(555, 189);
            this.Controls.Add(this.PrincipalSplitContainer);
            this.Controls.Add(this.SairButton);
            this.MinimumSize = new System.Drawing.Size(571, 227);
            this.Name = "DicaForm";
            this.Text = "Dica para usuário";
            this.Load += new System.EventHandler(this.DicaForm_Load);
            this.PrincipalSplitContainer.Panel1.ResumeLayout(false);
            this.PrincipalSplitContainer.Panel2.ResumeLayout(false);
            this.PrincipalSplitContainer.ResumeLayout(false);
            this.ExemploGroupBox.ResumeLayout(false);
            this.ExemploGroupBox.PerformLayout();
            this.ConfigGroupBox.ResumeLayout(false);
            this.ConfigGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SairButton;
        private System.Windows.Forms.SplitContainer PrincipalSplitContainer;
        private System.Windows.Forms.GroupBox ExemploGroupBox;
        private System.Windows.Forms.TextBox ExemploTextBox;
        private System.Windows.Forms.ComboBox ExemploComboBox;
        private System.Windows.Forms.Label ExemploComboBoxLabel;
        private System.Windows.Forms.Label ExemploTextBoxLabel;
        private System.Windows.Forms.GroupBox ConfigGroupBox;
        private System.Windows.Forms.Button DefinirDicaButton;
        private System.Windows.Forms.Button LimparDicaButton;
        private System.Windows.Forms.TextBox DicaTextBox;
        private System.Windows.Forms.Label DicaLabel;
    }
}

