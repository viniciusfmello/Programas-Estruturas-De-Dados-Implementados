class Lista
{
    public string[] nomesFilmes;
    public int n;
    public Lista(int tamanho)
    {
        Inicializar(tamanho);
    }
    private void Inicializar(int tamanho)
    {
        this.nomesFilmes = new string[tamanho];
        this.n = 0;
    }
    public void InserirInicio(string nome)
    {
        if (n >= nomesFilmes.Length)
        {
            Console.WriteLine("\n****LISTA LOTADA****\n");
        }
        for (int i = n; i > 0; i--)
        {
            nomesFilmes[i] = nomesFilmes[i - 1];
        }
        nomesFilmes[0] = nome;
        Console.WriteLine("\n****FILME ADICIONADO NO FINAL DA LISTA****\n");
        n++;
    }
    public void InserirPosiEspe(int posicao, string nome)
    {
        if (n >= nomesFilmes.Length || posicao < 0 || posicao > n)
        {
            Console.WriteLine("\n****POSIÇÃO INVÁLIDA****\n");
        }
        for (int i = n; i > posicao; i--)
        {
            nomesFilmes[i] = nomesFilmes[i - 1];
        }
        nomesFilmes[posicao] = nome;
        Console.WriteLine($"****FILME ADICIONADO NA POSIÇÃO {posicao} DA LISTA****");
        n++;
    }
    public void RemoverFilme(string nome)
    {
        for (int i = 0; i < n; i++)
        {
            if (nomesFilmes[i] == nome)
            {
                nomesFilmes[i] = nomesFilmes[i + 1];
            }
            n--;
        }
        Console.WriteLine($"\n****O FILME {nome} FOI REMOVIDO DA LISTA****\n");
    }
    public string RemoverPosi(int posicao)
    {
        if (n == 0 || n < 0)
        {
            Console.WriteLine("\n****NÃO EXISTEM FILMES NESSA POSIÇÃO****\n");
        }
        string nome1 = nomesFilmes[posicao];

        for (int i = posicao; i < n; i++)
        {
            nomesFilmes[i] = nomesFilmes[i + 1];
        }
        return nome1;
    }
    public void PesquisarFilme(string nome)
    {
        bool tem = false;
        for (int i = 0; i < n; i++)
        {
            if (nomesFilmes[i] == nome)
            {
                Console.WriteLine($"\n****O FILME {nome} EXISTE NA LISTA****\n");
                tem = true;
            }
        }
        if (!tem)
        {
            Console.WriteLine($"\n****O FILME NÃO {nome} EXISTE NA LISTA****\n");
        }
    }
    public void Listar()
    {
        Console.WriteLine("\n*****LISTA DE FILMES****\n");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Nome: " + nomesFilmes[i]);
        }
    }
    public void InverterOrdem()
    {
        Console.WriteLine("\n*****LISTA DE FILMES INVERTIDOS****\n");
        for (int i = n-1; i >= 0; i--)
        {
            Console.WriteLine("Nome: " + nomesFilmes[i]);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Lista listaFilmes = new Lista(50);
        Console.WriteLine("\n****NOSSA LISTA COMPORTA ATÉ 50 LIVROS****");
        while (true)
        {
            try
            {
                Console.WriteLine("\n--------------------MENU DE OPÇÕES--------------------\n\n1)Inserir filme no final da lista\n2)Inserir um filme em uma posição específica\n3)Remover um filme da lista\n4)Remover um filme em uma posição específica da lista\n5)Pesquisar se um filme consta na lista\n6)Listar todos os filmes da lista\n7)Inverter a ordem dos filmes presentes na lista\n8)Encerrar o Programa\n");
                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 8)
                {
                    Console.WriteLine("\n****PROGRAMA FINALIZADO****");
                    break;
                }
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do filme que você deseja adicionar no final da lista.");
                        string nomeFilme1 = Console.ReadLine();
                        nomeFilme1 = nomeFilme1.ToUpper();
                        bool tem = false;
                        for (int i = 0; i < listaFilmes.n; i++)
                        {
                            if (listaFilmes.nomesFilmes[i] == nomeFilme1)
                            {
                                Console.WriteLine("\n****ESSE FILME JÁ EXISTE NA LISTA****\n");
                                tem = true;
                            }
                        }
                        if (!tem)
                        {
                            listaFilmes.InserirInicio(nomeFilme1);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Digite o nome do filme que você deseja adicionar");
                        string nomeFilme2 = Console.ReadLine();
                        nomeFilme2 = nomeFilme2.ToUpper();
                        bool tem1 = false;
                        for (int i = 0; i < listaFilmes.n; i++)
                        {
                            if (listaFilmes.nomesFilmes[i] == nomeFilme2)
                            {
                                Console.WriteLine("\n****ESSE FILME JÁ EXISTE NA LISTA****\n");
                                tem1 = true;
                            }
                        }
                        if (!tem1)
                        {
                            Console.WriteLine("Digite a posição específica que você deseja adicionar o filme");
                            int posicao1 = int.Parse(Console.ReadLine());
                            listaFilmes.InserirPosiEspe(posicao1, nomeFilme2);
                        }
                        break;

                    case 3:
                        Console.WriteLine("Digite o nome do filme que você deseja remover da lista");
                        string nomeFilme3 = Console.ReadLine();
                        nomeFilme3 = nomeFilme3.ToUpper();
                        bool tem3 = false;
                        for (int i = 0; i < listaFilmes.n; i++)
                        {
                            if (listaFilmes.nomesFilmes[i] == nomeFilme3)
                            {
                                listaFilmes.RemoverFilme(nomeFilme3);
                                tem3 = true;
                            }
                        }
                        if (!tem3)
                        {
                            Console.WriteLine("\n****ESSE FILME NÃO EXISTE NA LISTA****\n");
                        }

                        break;

                    case 4:
                        int posicao = 0;
                        Console.WriteLine("Digite a posição do filme deseja remover:");
                        posicao = int.Parse(Console.ReadLine());

                        if (posicao > listaFilmes.n)
                        {
                            Console.WriteLine("****POSIÇÃO NÃO EXISTE NA LISTA****\n");
                        }
                        else
                        {
                            string nomeFilme4 = listaFilmes.RemoverPosi(posicao);
                            Console.WriteLine($"*****FILME {nomeFilme4} FOI REMOVIDO****\n");
                        }
                        break;

                    case 5:
                        bool tem4 = false;
                        Console.WriteLine("Digite o nome do filme");
                        string nomeFilme5 = Console.ReadLine();
                        nomeFilme5 = nomeFilme5.ToUpper();

                        listaFilmes.PesquisarFilme(nomeFilme5);
                        break;

                    case 6:
                        listaFilmes.Listar();
                        break;

                    case 7:
                        listaFilmes.InverterOrdem();
                        break;

                    default:
                        Console.WriteLine("\n****Digite uma opção válida:****\n");
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