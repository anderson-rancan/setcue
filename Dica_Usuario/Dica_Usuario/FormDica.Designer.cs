namespace Dica_Usuario
{
    partial class FormDica
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
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonDefinir = new System.Windows.Forms.Button();
            this.groupBoxConfig = new System.Windows.Forms.GroupBox();
            this.labelConfig = new System.Windows.Forms.Label();
            this.textBoxConfig = new System.Windows.Forms.TextBox();
            this.textBoxExemplo = new System.Windows.Forms.TextBox();
            this.labelExemplo = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();
            this.comboBoxExemplo = new System.Windows.Forms.ComboBox();
            this.groupBoxConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLimpar.Location = new System.Drawing.Point(182, 79);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 0;
            this.buttonLimpar.Text = "&Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonDefinir
            // 
            this.buttonDefinir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDefinir.Location = new System.Drawing.Point(101, 79);
            this.buttonDefinir.Name = "buttonDefinir";
            this.buttonDefinir.Size = new System.Drawing.Size(75, 23);
            this.buttonDefinir.TabIndex = 1;
            this.buttonDefinir.Text = "&Definir";
            this.buttonDefinir.UseVisualStyleBackColor = true;
            this.buttonDefinir.Click += new System.EventHandler(this.buttonDefinir_Click);
            // 
            // groupBoxConfig
            // 
            this.groupBoxConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxConfig.Controls.Add(this.labelConfig);
            this.groupBoxConfig.Controls.Add(this.textBoxConfig);
            this.groupBoxConfig.Controls.Add(this.buttonLimpar);
            this.groupBoxConfig.Controls.Add(this.buttonDefinir);
            this.groupBoxConfig.Location = new System.Drawing.Point(15, 71);
            this.groupBoxConfig.Name = "groupBoxConfig";
            this.groupBoxConfig.Size = new System.Drawing.Size(263, 108);
            this.groupBoxConfig.TabIndex = 2;
            this.groupBoxConfig.TabStop = false;
            this.groupBoxConfig.Text = "Configurações";
            // 
            // labelConfig
            // 
            this.labelConfig.AutoSize = true;
            this.labelConfig.Location = new System.Drawing.Point(6, 28);
            this.labelConfig.Name = "labelConfig";
            this.labelConfig.Size = new System.Drawing.Size(99, 13);
            this.labelConfig.TabIndex = 4;
            this.labelConfig.Text = "Dica para o usuário";
            // 
            // textBoxConfig
            // 
            this.textBoxConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxConfig.Location = new System.Drawing.Point(9, 44);
            this.textBoxConfig.Name = "textBoxConfig";
            this.textBoxConfig.Size = new System.Drawing.Size(248, 20);
            this.textBoxConfig.TabIndex = 3;
            this.textBoxConfig.Text = "Entre com os dados";
            // 
            // textBoxExemplo
            // 
            this.textBoxExemplo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExemplo.Location = new System.Drawing.Point(15, 25);
            this.textBoxExemplo.Name = "textBoxExemplo";
            this.textBoxExemplo.Size = new System.Drawing.Size(516, 20);
            this.textBoxExemplo.TabIndex = 3;
            // 
            // labelExemplo
            // 
            this.labelExemplo.AutoSize = true;
            this.labelExemplo.Location = new System.Drawing.Point(12, 9);
            this.labelExemplo.Name = "labelExemplo";
            this.labelExemplo.Size = new System.Drawing.Size(157, 13);
            this.labelExemplo.TabIndex = 4;
            this.labelExemplo.Text = "Exemplo para entrada de dados";
            // 
            // buttonSair
            // 
            this.buttonSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSair.Location = new System.Drawing.Point(456, 156);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 0;
            this.buttonSair.Text = "Sai&r";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // comboBoxExemplo
            // 
            this.comboBoxExemplo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxExemplo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxExemplo.FormattingEnabled = true;
            this.comboBoxExemplo.Items.AddRange(new object[] {
            "Primeira",
            "Segunda",
            "Terceira"});
            this.comboBoxExemplo.Location = new System.Drawing.Point(331, 51);
            this.comboBoxExemplo.Name = "comboBoxExemplo";
            this.comboBoxExemplo.Size = new System.Drawing.Size(200, 21);
            this.comboBoxExemplo.TabIndex = 5;
            // 
            // FormDica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 191);
            this.Controls.Add(this.comboBoxExemplo);
            this.Controls.Add(this.labelExemplo);
            this.Controls.Add(this.textBoxExemplo);
            this.Controls.Add(this.groupBoxConfig);
            this.Controls.Add(this.buttonSair);
            this.MinimumSize = new System.Drawing.Size(559, 229);
            this.Name = "FormDica";
            this.Text = "Dica para usuário";
            this.Load += new System.EventHandler(this.FormDica_Load);
            this.groupBoxConfig.ResumeLayout(false);
            this.groupBoxConfig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonDefinir;
        private System.Windows.Forms.GroupBox groupBoxConfig;
        private System.Windows.Forms.Label labelConfig;
        private System.Windows.Forms.TextBox textBoxConfig;
        private System.Windows.Forms.TextBox textBoxExemplo;
        private System.Windows.Forms.Label labelExemplo;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.ComboBox comboBoxExemplo;
    }
}

