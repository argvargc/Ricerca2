int[] numbervs = new int[10];

for (int i = 0; i < numbervs.Length; i++)
{
    Console.Write($"Inserisci numero {i}: ");
    numbervs[i] = Convert.ToInt32(Console.ReadLine());
}

int intDaTrovare = 0;
Console.WriteLine($"Inserisci il numero che vuoi trovare: ");
intDaTrovare = Convert.ToInt32(Console.ReadLine());
int contaTrovato = 0;

//ricerca 2
for (int i = 0; i < numbervs.Length; i++)
{
    if (numbervs[i] == intDaTrovare)
    {
        contaTrovato++;
    }
}
Console.WriteLine($"{contaTrovato} occorrenze");
