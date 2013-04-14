/*
 * Este conteúdo está protegido de acordo com a licença CPOL 1.02
 * A licença pode ser encontrada no arquivo em anexo deste projeto (LICENSE.PDF) ou pelo link http://wp.me/p1AUuf-q
 * 
 * Autor: Anderson Rancan
 * Data: 08 de Agosto de 2011
 * Site: http://arancan.wordpress.com/2011/08/08/setcue/
 * 
 */

using System;
using System.Windows.Forms;

namespace Dica_Usuario
{
    /// <summary>
    /// Formulário principal
    /// </summary>
    public partial class FormDica : Form
    {
        public FormDica()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fecha o formulário
        /// </summary>
        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Define a dica nos objetos TextBox e ComboBox
        /// </summary>
        private void buttonDefinir_Click(object sender, EventArgs e)
        {
            Framework.DefinirDica(textBoxExemplo, textBoxConfig.Text);
            Framework.DefinirDica(comboBoxExemplo, textBoxConfig.Text);
        }

        /// <summary>
        /// Limpa a dica dos objetos TextBox e ComboBox
        /// </summary>
        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            Framework.LimparDica(textBoxExemplo);
            Framework.LimparDica(comboBoxExemplo);
        }

        /// <summary>
        /// Coloca a dica inicial assim que o formulário estiver sendo carregado
        /// </summary>
        private void FormDica_Load(object sender, EventArgs e)
        {
            buttonDefinir.PerformClick();
        }
    }
}
