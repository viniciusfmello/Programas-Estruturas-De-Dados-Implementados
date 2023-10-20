class Celula
{
    private char elemento;
    private Celula prox;
    public Celula(char elemento)
    {
        this.elemento = elemento;
        this.prox = null;
    }
    public Celula()
    {
        this.elemento = '0';
        this.prox = null;
    }
    public Celula Prox
    {
        get { return prox; }
        set { prox = value; }
    }
    public char Elemento
    {
        get { return elemento; }
        set { elemento = value; }
    }
}
class Pilha
{
    private Celula topo;
    public Pilha()
    {
        topo = null;
    }
    public void Inserir(char letra)
    {
        Celula tmp = new Celula(letra);
        tmp.Prox = topo;
        topo = tmp;
        tmp = null;
    }
    public Celula getTopo()
    {
        return topo;
    }
    public void Mostrar()
    {
        for (Celula i = topo; i != null; i = i.Prox)
        {
            Console.WriteLine(i.Elemento);
        }
    }
    public bool Verifica(Pilha P, Pilha PilhaInvertida)
    {
        bool verificadora = true;
        for (Celula i = PilhaInvertida.getTopo(); i != null; i = i.Prox)
        {
            for (Celula j = this.topo; j != null; j = j.Prox)
            {
                if (i.Elemento == j.Elemento)
                { verificadora = true; }
                else
                { verificadora = false; }
            }
        }
        if (verificadora) { return true; }
        else { return false; }
    }
    public void Inverte(Pilha P, Pilha PilhaInvertida)
    {
        for (Celula i = P.getTopo(); i != null; i = i.Prox)
        {
            PilhaInvertida.Inserir(i.Elemento);
        }
    }
}
class Program
{
    static Pilha P = new Pilha();
    static Pilha PilhaInvertida = new Pilha();
    static void Main(string[] args)
    {
        Console.WriteLine("\n*****VERIFICADOR DE PALÍNDROMO****\n");
        Console.WriteLine("Digite cada letra da palavra em uma linha ou 0 para verificar se a letra forma um palíndromo");
        char letra;
        while (true)
        {
            letra = char.Parse(Console.ReadLine());
            if (letra == '0')
            {
                PilhaInvertida.Inverte(P, PilhaInvertida);
                bool EhouNao = P.Verifica(P, PilhaInvertida);
                if (EhouNao)
                {
                    Console.WriteLine("\n****A PALAVRA FORMA UM PALÍNDROMO****\n");
                }
                else
                {
                    Console.WriteLine("\n****A PALAVRA NÃO FORMA UM PALÍNDROMO****\n");
                }
                
                Console.WriteLine("\n****PILHA P NA MESMA ORDEM QUE FOI PASSADA POR PARÂMETRO:\n");

                for (Celula i = P.getTopo(); i != null; i = i.Prox)
                {
                    Console.Write(i.Elemento + " ");
                }
                break;
            }
            else
            {
                P.Inserir(letra);
            }

        }
    }
}