setcue
======

/*
 * Este conte�do est� protegido de acordo com a licen�a CPOL 1.02
 * A licen�a pode ser encontrada no arquivo em anexo deste projeto (LICENSE.PDF) ou pelo link http://wp.me/p1AUuf-q
 * 
 * Autor: Anderson Rancan
 * Data: 08 de Agosto de 2011
 * Site: http://arancan.wordpress.com/2011/08/08/setcue/
 * 
 */


Quanto mais compreens�vel seu software for para o usu�rio, melhor sera sua aceita��o. O usu�rio gosta de software simples, pr�tico e de f�cil entendimento (e quem n�o gosta n�?). Neste artigo vou publicar uma maneira simples de melhorar o entendimento de seu software, dicas diretamente no objeto de entrada de dados.

As dicas exibidas nos objetos est�o presentes na API do Windows desde o Windows XP, e s�o muito utilizadas inclusive na Web. Com certeza voc�s j� viram um campo de pesquisa escrito "digite aqui sua pesquisa", e ao clicar no campo esse texto desaparece, ou em um cadastro com o campo Endere�o, e o texto "Ex.: Av. Salgado Filho, 512", e ao clicar o endere�o de exemplo desaparece.

Essa dica, apesar de parecer uma dica �bvia em muitas ocasi�es, praticamente elimina toda possibilidade de d�vida, pois na maioria dos casos deixa claro objeto daquele campo. Como exemplo, d� uma olhada nos campos de login do Twitter:

N�o existe d�vida de qual campo representa o "nome de usu�rio" e qual � a "senha", mesmo que os campos n�o tenham um t�tulo fixo! Economizamos espa�o na janela e o usu�rio sabe exatamente aonde clicar para entrar com seus dados, simples e direto!

Para definir a dica de nossos objetos, iremos utilizar a fun��o nativa do Windows chamada SendMessage(HWND hWnd, UINT Msg, WPARAM wParam, LPARAM lParam). Este � um comando capaz de enviar diversos tipos de "mensagens" para janelas e objetos, e para utilizar as dicas iremos enviar mensagens do tipo EM_SETCUEBANNER (para TextBox) e CB_SETCUEBANNER (para ComboBox).

Ent�o, primeiro declaramos o m�todo SendMessage da API nativa do Windows:

[DllImport("user32.dll", CharSet = CharSet.Auto)]

public static extern Int32 SendMessage (IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

E, por exemplo, para definir a dica "Ex.: Av. Salgado Filho, 1234" no objeto TextBoxEndereco, utilizamos da seguinte forma:

SendMessage(TextBoxEndereco, EM_SETCUEBANNER, 0, "Ex.: Av. Salgado Filho, 1234");

Simples n�?

Coloquei na minha pasta p�blica do Google Docs um exemplo completo (Microsoft C# 2008 Express Edition), voc� pode acess�-lo por aqui. L� eu separei todos os m�todos conforme sugerido pela Microsoft, criei uma classe Framework para "filtrar" e organizar a utiliza��o dos m�todos nativos, e deixei um formul�rio pronto para f�cil visualiza��o da aplica��o desde exemplo.

Bom proveito!
