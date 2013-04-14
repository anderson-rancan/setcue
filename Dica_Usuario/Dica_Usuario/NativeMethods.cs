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
using System.Runtime.InteropServices;

namespace Dica_Usuario
{
    /// <summary>
    /// Classe com os métodos nativos e seus controles
    /// </summary>
    /// <remarks>
    /// Estes métodos ficam em uma classe separada para facilitar futura manutenção do código,
    /// além de aumentar a segurança (para o programador), pois concentramos os métodos que não
    /// são controlados pelo .NET Framework no mesmo lugar
    /// </remarks>
    internal static class NativeMethods
    {
        public const int CB_SETCUEBANNER = 0x1703;
        public const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern Int32 SendMessage
          (IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
    }
}
