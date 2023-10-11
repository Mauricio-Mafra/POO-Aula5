


//Aprimore o sistema do circo.
//Crie propriedades e métodos construtores específicos dos filhos. Por exemplo, tipo de malabarismo,
//se é com bolas ou outros itens. Quantidade máxima de itens empilhados do equilibrista..
//Cada um deles terá o seu método de realizar performance que mostrará suas habilidades específicas,
//caso não possua habilidade especifica ele mostrará "Atração especial em criação!". (isso não é um if :))
//Deixe o Palhaço sem habilidade especifica.
//Crie testes para seu programa, imprima as suas propriedades e realize sua performance utilizando herança e
//polimorfismo.


namespace Circo
{
    internal class Equilibrista : Artista
    {
        public string BaseEquilibrio { get; protected set; }

        internal Equilibrista(string nome, string nomeArtistico, int tempoApresentacao, DateTime dataInicio, DateTime? dataSaida, string baseEquilibrio)
            : base(nome, nomeArtistico, tempoApresentacao, dataInicio, dataSaida)
        {
            BaseEquilibrio = baseEquilibrio;
        }

        public override void RealizarPerformance()
        {
            Console.WriteLine($"Estou me equilibrando em {BaseEquilibrio}.");
        }
    }
}
