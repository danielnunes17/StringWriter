using System.Linq.Expressions;

string textReaderText = "As medidas foram tomadas pelo Bureau do Conselho da Fifa, instância da entidade que inclui os" + "presidentes das seis confederações continentais de futebol, e pelo Comitê Executivo da Uefa – órgão que toma todas as" + "decisões mais importantes do futebol europeu. A Uefa também anunciou a rescisão do contrato de patrocínio com a empresa russa Gazprom.\n\n" +

"A dura medida ocorre no mesmo dia em que o COI (Comitê Olímpico Internacional) recomendou às federações de cada modalidade" + "que excluam atletas de Rússia e Belarus de todas as competições internacionais.\n\n" +

"A Rússia disputaria uma partida pela repescagem das Eliminatórias para a Copa no dia 24 de março, contra a Polônia" +
"que se recusava a participar do jogo e enfrentar a Rússia em qualquer circunstância. A mesma posição era compartilhada por" + "República Tcheca e Suécia, que também se enfrentam pelas Eliminatórias – num jogo cujo vencedor pegaria quem ganhasse entre Rússia e Polônia. \n\n";


string linha, paragrafo = null;
var sr = new StreamReader(textReaderText);

while (true)
{
    linha = sr.ReadLine();
    if (linha != null)
    {
        paragrafo += linha + " ";
    }
    else
    {
        paragrafo += '\n';
        break;

    }

}
Console.WriteLine("Texto modificado: {paragrafo} ");
int caracterLido;
char caracterConvertido;
var sw = new StringWriter();
sr = new StreamReader(paragrafo);
while (true)
{
    caracterLido = sr.Read();
    if (caracterLido == -1) break;

    caracterConvertido = Convert.ToChar(caracterLido);

    if (caracterLido == '.')
    {
        sw.Write("\n\n");
        sr.Read();
        sr.Read();
    }
    else
    {
        sw.Write(caracterConvertido);

    }

}
    Console.WriteLine($"Texto armazenado no StringWrite: {sw.ToString()}");
    Console.WriteLine("\n\nDigite [enter] para sair...");
    Console.ReadLine();