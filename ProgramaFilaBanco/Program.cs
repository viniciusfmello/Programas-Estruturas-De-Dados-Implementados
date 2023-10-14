class Fila
{
    public string[] nomes;
    public int primeiro, ultimo;

    public Fila(int tamanho)
    {
        Inicializar(tamanho);
    }
    public void Inicializar(int tamanho)
    {
        this.nomes = new string[tamanho + 1];
        primeiro = ultimo = 0;
    }
    public void Adicionar(string nome)
    {
        bool tem = false;
        if ((ultimo + 1) % nomes.Length == primeiro)
        {
            Console.WriteLine("\n****A LISTA ESTÁ CHEIA****\n");
        }
        for (int i = primeiro; i < ultimo; i++)
        {
            if (nome == nomes[i])
            {
                Console.WriteLine("\n****JÁ EXISTE ESSA PESSOA NA FILA****\n");
                tem = true;
            }
        }
        if (!tem)
        {
            nomes[ultimo] = nome;
            ultimo = (ultimo + 1) % nomes.Length;
            Console.WriteLine($"\n****O CLIENTE DE NOME {nome} FOI ADICIONADO NA FILA****");
        }
    }
    public string AtenderCliente()
    {
        if (primeiro == ultimo)
        {
            return "0";
        }
        else
        {
            string resp = nomes[primeiro];
            primeiro = (primeiro + 1) % nomes.Length;
            return resp;
        }
    }
    public void ExibirNumClientes()
    {
        int quant = 0;
        for (int i = primeiro; i < ultimo; i++)
        {
            quant++;
        }
        Console.WriteLine($"\n****A QUANTIDADE DE CLIENTES NA FILA É: {quant}****\n");
    }
    public void ExibirProxCliente()
    {
        string nome;
        nome = nomes[primeiro + 1];
        Console.WriteLine($"\n****O PRÓXIMO CLIENTE A SER ATENDIDO: {nome}****\n");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Fila filaBanco = new Fila(50);
        Console.WriteLine("\n****A FILA DO BANCO COMPORTA 50 PESSOAS****");
        while (true)
        {
            try
            {
                Console.WriteLine("\n--------------------MENU DE OPÇÕES--------------------\n\n1)Adicionar um cliente à fila\n2)Atender um Cliente\n3)Exibir o número de clientes na fila\n4)Exibir o próximo cliente a ser atendido\n5)Encerrar o programa");
                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 5)
                {
                    Console.WriteLine("\n*****PROGRAMA ENCERRADO!*****\n");
                    break;
                }
                switch (opcao)
                {
                    case 1:

                        bool tem = false;
                        Console.WriteLine("Digite o nome do cliente que deseja adicionar na fila de espera");
                        string nome = Console.ReadLine();
                        nome = nome.ToUpper();
                        filaBanco.Adicionar(nome);
                        break;

                    case 2:
                        string nome2 = filaBanco.AtenderCliente();
                        if (nome2 == "0")
                        {
                            Console.WriteLine($"\n****A FILA ESTÁ VAZIA****\n");
                        }
                        else
                        {
                            Console.WriteLine($"\n****O CLIENTE {nome2} FOI ATENDIDO!****\n");
                        }
                        break;
                    case 3:
                        filaBanco.ExibirNumClientes();
                        break;

                    case 4:
                        filaBanco.ExibirProxCliente();
                        break;

                    default:
                        Console.WriteLine("\n*****DIGITE UMA OPÇÃO VÁLIDA****\n");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("OPS, você digitou um caractere inválido. Nosso MENU trabalha apenas com números.");
            }
        }
    }
}