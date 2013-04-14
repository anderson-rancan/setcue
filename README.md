setcue
======

/*
 * Este conteúdo está protegido de acordo com a licença CPOL 1.02
 * A licença pode ser encontrada no arquivo em anexo deste projeto (LICENSE.PDF) ou pelo link http://wp.me/p1AUuf-q
 * 
 * Autor: Anderson Rancan
 * Data: 08 de Agosto de 2011
 * Site: http://arancan.wordpress.com/2011/08/08/setcue/
 * 
 */


Quanto mais compreensível seu software for para o usuário, melhor sera sua aceitação. O usuário gosta de software simples, prático e de fácil entendimento (e quem não gosta né?). Neste artigo vou publicar uma maneira simples de melhorar o entendimento de seu software, dicas diretamente no objeto de entrada de dados.

As dicas exibidas nos objetos estão presentes na API do Windows desde o Windows XP, e são muito utilizadas inclusive na Web. Com certeza vocês já viram um campo de pesquisa escrito "digite aqui sua pesquisa", e ao clicar no campo esse texto desaparece, ou em um cadastro com o campo Endereço, e o texto "Ex.: Av. Salgado Filho, 512", e ao clicar o endereço de exemplo desaparece.

Essa dica, apesar de parecer uma dica óbvia em muitas ocasiões, praticamente elimina toda possibilidade de dúvida, pois na maioria dos casos deixa claro objeto daquele campo. Como exemplo, dê uma olhada nos campos de login do Twitter:

Não existe dúvida de qual campo representa o "nome de usuário" e qual é a "senha", mesmo que os campos não tenham um título fixo! Economizamos espaço na janela e o usuário sabe exatamente aonde clicar para entrar com seus dados, simples e direto!

Para definir a dica de nossos objetos, iremos utilizar a função nativa do Windows chamada SendMessage(HWND hWnd, UINT Msg, WPARAM wParam, LPARAM lParam). Este é um comando capaz de enviar diversos tipos de "mensagens" para janelas e objetos, e para utilizar as dicas iremos enviar mensagens do tipo EM_SETCUEBANNER (para TextBox) e CB_SETCUEBANNER (para ComboBox).

Então, primeiro declaramos o método SendMessage da API nativa do Windows:

[DllImport("user32.dll", CharSet = CharSet.Auto)]

public static extern Int32 SendMessage (IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

E, por exemplo, para definir a dica "Ex.: Av. Salgado Filho, 1234" no objeto TextBoxEndereco, utilizamos da seguinte forma:

SendMessage(TextBoxEndereco, EM_SETCUEBANNER, 0, "Ex.: Av. Salgado Filho, 1234");

Simples né?

Coloquei na minha pasta pública do Google Docs um exemplo completo (Microsoft C# 2008 Express Edition), você pode acessá-lo por aqui. Lá eu separei todos os métodos conforme sugerido pela Microsoft, criei uma classe Framework para "filtrar" e organizar a utilização dos métodos nativos, e deixei um formulário pronto para fácil visualização da aplicação desde exemplo.

Bom proveito!
