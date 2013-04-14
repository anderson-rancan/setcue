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

namespace DicaUsuario
{
    /// <summary>
    /// Formulário principal
    /// </summary>
    internal partial class DicaForm : Form
    {

        #region Construtores

        /// <summary>
        /// Inicializa uma nova instância de Dica_Usuario.DicaForm
        /// </summary>
        public DicaForm()
        {
            InitializeComponent();
        }

        #endregion

        private void DicaForm_Load(object sender, EventArgs e)
        {
            DefinirDicaButton.PerformClick();
        }

        /// <summary>
        /// Fecha o formulário
        /// </summary>
        private void SairButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Define a dica nos objetos TextBox e ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DefinirDicaButton_Click(object sender, EventArgs e)
        {
            Framework.DefinirDica(ExemploTextBox, DicaTextBox.Text);
            Framework.DefinirDica(ExemploComboBox, DicaTextBox.Text);
        }

        /// <summary>
        /// Limpa das dicas dos objetos TextBox e ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LimparDicaButton_Click(object sender, EventArgs e)
        {
            Framework.LimparDica(ExemploTextBox);
            Framework.LimparDica(ExemploComboBox);
        }
    }
}
