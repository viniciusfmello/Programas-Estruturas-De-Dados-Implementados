class FilaIC
{
    public int[] codigos_alunos_IC;
    public int primeiro, ultimo;

    public FilaIC(int tamanho)
    {
        Inicializar(tamanho);
    }
    private void Inicializar(int tamanho)
    {
        this.codigos_alunos_IC = new int[tamanho + 1];
        primeiro = ultimo = 0;
    }
    public void Adicionar(int codigo)
    {
        if ((ultimo + 1) % codigos_alunos_IC.Length == primeiro)
        {
            Console.WriteLine("\n****A LISTA ESTÁ CHEIA****\n");
        }
        else
        {
            codigos_alunos_IC[ultimo] = codigo;
            ultimo = (ultimo + 1) % codigos_alunos_IC.Length;
            Console.WriteLine($"****O ALUNO DE CÓDIGO {codigo} FOI ADICIONADO NA FILA****");
        }
    }
    public int Remover()
    {
        if (primeiro == ultimo)
        {
            return -1;
        }
        else
        {
            int resp = codigos_alunos_IC[primeiro];
            primeiro = (primeiro + 1) % codigos_alunos_IC.Length;
            return resp;
        }
    }
    public void MostrarFila()
    {
        for (int i = primeiro; i < ultimo; i++)
        {
            Console.WriteLine(codigos_alunos_IC[i]);
        }
    }
    public void PesquisarAluno(int codigo)
    {
        bool tem = false;
        if (primeiro == ultimo)
        {
            Console.WriteLine("\n****A FILA ESTÁ VAZIA****\n");
            tem = true;
        }
        if (!tem)
        {
            for (int i = primeiro; i < ultimo; i++)
            {
                if (codigo == codigos_alunos_IC[i])
                {
                    Console.WriteLine($"\n****O ALUNO DE CÓDIGO {codigo} EXISTE NA FILA****\n");
                    tem = true;
                }
            }
            if (!tem)
            {
                Console.WriteLine($"\n****O ALUNO DE CÓDIGO {codigo} NÃO EXISTE NA FILA****\n");
            }
        }
    }
    public void MostrarPrimeiro()
    {
        bool tem = false;
        if (primeiro == ultimo)
        {
            Console.WriteLine("\n****A FILA ESTÁ VAZIA****");
            tem = true;
        }
        if (!tem)
        {
            int codigoPrimeiro = codigos_alunos_IC[primeiro];
            Console.WriteLine($"\n****O PRIMEIRO DA FILA É O ALUNO DE CÓDIGO: {codigoPrimeiro}");
        }
    }
}
class FilaMES
{
    public int[] codigos_alunos_MES;
    public int primeiro, ultimo;

    public FilaMES(int tamanho)
    {
        Inicializar(tamanho);
    }
    private void Inicializar(int tamanho)
    {
        this.codigos_alunos_MES = new int[tamanho + 1];
        primeiro = ultimo = 0;
    }
    public void Adicionar(int codigo)
    {
        if ((ultimo + 1) % codigos_alunos_MES.Length == primeiro)
        {
            Console.WriteLine("\n****A LISTA ESTÁ CHEIA****\n");
        }
        else
        {
            codigos_alunos_MES[ultimo] = codigo;
            ultimo = (ultimo + 1) % codigos_alunos_MES.Length;
            Console.WriteLine($"****O ALUNO DE CÓDIGO {codigo} FOI ADICIONADO NA FILA****");
        }
    }
    public int Remover()
    {
        if (primeiro == ultimo)
        {
            return -1;
        }
        else
        {
            int resp = codigos_alunos_MES[primeiro];
            primeiro = (primeiro + 1) % codigos_alunos_MES.Length;
            return resp;
        }
    }
    public void MostrarFila()
    {
        for (int i = primeiro; i < ultimo; i++)
        {
            Console.WriteLine(codigos_alunos_MES[i]);
        }
    }
    public void PesquisarAluno(int codigo)
    {
        bool tem = false;
        if (primeiro == ultimo)
        {
            Console.WriteLine("\n****A FILA ESTÁ VAZIA****\n");
            tem = true;
        }
        if (!tem)
        {
            for (int i = primeiro; i < ultimo; i++)
            {
                if (codigo == codigos_alunos_MES[i])
                {
                    Console.WriteLine($"\n****O ALUNO DE CÓDIGO {codigo} EXISTE NA FILA****\n");
                    tem = true;
                }
            }
            if (!tem)
            {
                Console.WriteLine($"\n****O ALUNO DE CÓDIGO {codigo} NÃO EXISTE NA FILA****\n");
            }
        }
    }
    public void MostrarPrimeiro()
    {
        bool tem = false;
        if (primeiro == ultimo)
        {
            Console.WriteLine("\n****A FILA ESTÁ VAZIA****");
            tem = true;
        }
        if (!tem)
        {
            int codigoPrimeiro = codigos_alunos_MES[primeiro];
            Console.WriteLine($"\n****O PRIMEIRO DA FILA É O ALUNO DE CÓDIGO: {codigoPrimeiro}");
        }
    }
}
class Program
{
    static FilaIC Fila_IC = new FilaIC(50);
    static FilaMES Fila_MES = new FilaMES(50);
    static void Main(string[] args)
    {
        Console.WriteLine("\n*****AMBAS FILAM COMPORTAM 50 PESSOAS****\n");
        while (true)
        {
            try
            {
                Console.WriteLine("\n--------------------MENU PRINCIPAL--------------------\n\nQual fila você deseja gerenciar?\n\n1)Fila de espera interessados em bolsas de INICIAÇÃO CIENTÍFICA\n2)Fila de espera de interessados em bolsas de MESTRADO\n3)Encerrar o programa");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 3)
                {
                    Console.WriteLine("\n****PROGRAMA FINALIZADO****\n");
                    break;
                }
                switch (opcao)
                {
                    case 1:
                        MenuIniciacao(Fila_IC, Fila_MES);
                        break;

                    case 2:
                        MenuMestrado(Fila_MES, Fila_IC);
                        break;

                    default:
                        Console.WriteLine("****OPÇÃO INVÁLIDA****");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("OPS, você digitou um caractere inválido. Nosso MENU trabalha apenas com números.");
            }
        }
    }
    static void MenuIniciacao(FilaIC Fila_IC, FilaMES Fila_MES)
    {
        while (true)
        {
            Console.WriteLine("\n--------------------MENU DE OPÇÕES INICIAÇÃO CIENTÍFICA--------------------\n\n1)Inserir um aluno na fila de espera de bolsas de IC\n2)Remover um aluno da fila de espera de IC\n3)Mostrar fila de espera de bolsas de IC\n4)Pesquisar aluno na fila de espera de IC\n5)Mostrar qual aluno que está no início da fila de espera de bolsas de IC\n6)Ir ao MENU de MESTRADO\n7)Voltar ao MENU principal");
            int opcao = int.Parse(Console.ReadLine());
            try
            {
                if (opcao == 7)
                {
                    Console.WriteLine("\n");
                    break;
                }
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o código do aluno que deseja adicionar");
                        int codigo1 = int.Parse(Console.ReadLine());
                        bool tem1 = false;
                        for (int i = Fila_IC.primeiro; i < Fila_IC.ultimo; i++)
                        {
                            if (codigo1 == Fila_IC.codigos_alunos_IC[i])
                            {
                                Console.WriteLine("\n****JÁ EXISTE ALUNO COM ESSE CÓDIGO****\n");
                                tem1 = true;
                            }
                        }
                        if (!tem1)
                        {
                            Fila_IC.Adicionar(codigo1);
                        }
                        break;
                    case 2:
                        int codigoRemovido = Fila_IC.Remover();
                        if (codigoRemovido == -1)
                        {
                            Console.WriteLine("\n****A FILA ESTÁ VAZIA****\n");
                        }
                        else
                        {
                            Console.WriteLine($"\n****ALUNO DE CÓDIGO {codigoRemovido} REMOVIDO DA FILA****\n");
                        }
                        break;
                    case 3:
                        Fila_IC.MostrarFila();
                        break;
                    case 4:
                        Console.WriteLine("Digite o código do aluno que deseja pesquisar na fila.");
                        int codigo2 = int.Parse(Console.ReadLine());
                        Fila_IC.PesquisarAluno(codigo2);
                        break;
                    case 5:
                        Fila_IC.MostrarPrimeiro();
                        break;
                    case 6:
                        MenuMestrado(Fila_MES, Fila_IC);
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
    static void MenuMestrado(FilaMES Fila_MES, FilaIC Fila_IC)
    {
        while (true)
        {
            Console.WriteLine("\n--------------------MENU DE OPÇÕES MESTRADO--------------------\n\n1)Inserir um aluno na fila de espera de bolsas de MESTRADO\n2)Remover um aluno da fila de espera de MESTRADO\n3)Mostrar fila de espera de bolsas de MESTRADO\n4)Pesquisar aluno na fila de espera de MESTRADO\n5)Mostrar qual aluno que está no início da fila de espera de bolsas de MESTRADO\n6)Ir ao MENU de Iniciação Científica\n7)Voltar ao menu principal");
            int opcao = int.Parse(Console.ReadLine());
            try
            {
                if (opcao == 7)
                {
                    Console.WriteLine("\n");
                    break;
                }
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o código do aluno que deseja adicionar");
                        int codigo1 = int.Parse(Console.ReadLine());
                        bool tem1 = false;
                        for (int i = Fila_MES.primeiro; i < Fila_MES.ultimo; i++)
                        {
                            if (codigo1 == Fila_MES.codigos_alunos_MES[i])
                            {
                                Console.WriteLine("\n****JÁ EXISTE ALUNO COM ESSE CÓDIGO****\n");
                                tem1 = true;
                            }
                        }
                        if (!tem1)
                        {
                            Fila_MES.Adicionar(codigo1);
                        }
                        break;
                    case 2:
                        int codigoRemovido = Fila_MES.Remover();
                        if (codigoRemovido == -1)
                        {
                            Console.WriteLine("\n****A FILA ESTÁ VAZIA****\n");
                        }
                        else
                        {
                            Console.WriteLine($"\n****ALUNO DE CÓDIGO {codigoRemovido} REMOVIDO DA FILA****\n");
                        }
                        break;
                    case 3:
                        Fila_MES.MostrarFila();
                        break;
                    case 4:
                        Console.WriteLine("Digite o código do aluno que deseja pesquisar na fila.");
                        int codigo2 = int.Parse(Console.ReadLine());
                        Fila_MES.PesquisarAluno(codigo2);
                        break;
                    case 5:
                        Fila_MES.MostrarPrimeiro();
                        break;
                    case 6:
                        MenuIniciacao(Fila_IC, Fila_MES);
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