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
    /// Ferramentas para Interface de Usuário
    /// </summary>
    /// <remarks>
    /// Esta é a classe que disponbiliza e controla as ferramentas para o restante do software
    /// </remarks>
    internal sealed class Framework
    {
        /// <summary>
        /// Define a dica no controle especificado
        /// </summary>
        /// <param name="controle">Controle a ser definido</param>
        /// <param name="dica">Dica a exibir</param>
        public static void DefinirDica(Control controle, string dica)
        {
            SetCue(controle, dica);
        }

        /// <summary>
        /// Remove a dica do controle especificado
        /// </summary>
        /// <param name="controle">Controle a ser definido</param>
        public static void LimparDica(Control controle)
        {
            SetCue(controle, string.Empty);
        }

        /// <summary>
        /// Controla de forma particular o evento, para que não ocorram erros
        /// </summary>
        /// <param name="controle">Controle a ser definido</param>
        /// <param name="texto">Texto a ser passado ao controle</param>
        private static void SetCue(Control controle, string texto)
        {
            NativeMethods.SendMessage(
                controle.Handle,
                controle is ComboBox ? NativeMethods.CB_SETCUEBANNER : NativeMethods.EM_SETCUEBANNER,
                0,
                string.IsNullOrEmpty(texto) ? string.Empty : texto.Trim()
                );
        }
    }
}
