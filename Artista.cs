//Vamos criar um sistema que represente um circo.
//Neste sistema teremos a classe pai Artista e seus filhos Malabarista, Equilibrista e Palhaço.
//Na classe Artista teremos o Nome, o tempo de apresentação, a data de inicio, data de saída (que pode ser vazia) e se está atualmente ativo. Teremos também um método para exibir as informações e um para registrar a data de saída de algum artista e inativar seu cadastro.
//Crie testes dos seus objetos filhos.


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
    internal class Artista
    {
        public string Nome { get; protected set; }

        public string NomeArtistico { get; protected set; }

        public int TempoApresentacao { get; protected set; }

        public DateTime DataInicio { get; protected set; } = DateTime.MinValue;

        public DateTime? DataSaida { get; protected set; } = null;

        internal Artista(string nome, string nomeArtistico, int tempoApresentacao, DateTime dataInicio, DateTime? dataSaida) { 
        
            Nome = nome;
            NomeArtistico = nomeArtistico;
            TempoApresentacao = tempoApresentacao;
            DataInicio = dataInicio;
            DataSaida = dataSaida;
        }

        public void ImprimirArtista()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Nome artistico: {NomeArtistico}");
            Console.WriteLine($"Tempo de apresentação: {TempoApresentacao}");
            Console.WriteLine($"Data de início: {DataInicio.ToShortDateString()}");

            if (DataSaida is not null)
                Console.WriteLine($"Data de saída: {DataSaida.Value.ToShortDateString()}");

        }

        public virtual void RealizarPerformance()
        {
            Console.WriteLine("Atração especial em criação!");
        }
        public void RegistrarSaida()
        {
            Console.WriteLine("Digite a data de saída do artista:");
            DateTime dataSaida = DateTime.TryParse(Console.ReadLine(), out dataSaida) ? dataSaida : DateTime.MinValue;
            DataSaida = dataSaida;
            Console.WriteLine($"Data de saída: {DataSaida.Value.ToShortDateString()}");
        }


    }
}
