string fraseSecreta;
string letra;

Console.Write("Digite a palavra secreta: ");
fraseSecreta = Console.ReadLine()!;

Console.Write("Qual é a letra: ");
letra = Console.ReadLine()!
    .Trim()
    .Substring(0, 1)
    .ToLower();

bool letraExiste = fraseSecreta
    .ToLower()
    .Contains(letra);

Console.WriteLine($"\nA letra \"{letra}\" existe na palavra secreta => {letraExiste}");
