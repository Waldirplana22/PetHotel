using System;

class Program {
  public static void Main (string[] args) {
    
Console.WriteLine("----   Pet Hotel   ----\n");
Console.Write("- Espécie - ");
string especie = Console.ReadLine()!;

Console.Write("- Raça - ");
string raca = Console.ReadLine()!;

Console.Write("- Sexo - ");
string sexo = Console.ReadLine()!;

Console.Write("- Nome do Pet - ");
string nome = Console.ReadLine()!;

Console.Write("- Idade - ");
string idade = Console.ReadLine()!;

Console.Write("- Pelagem/Cor - ");
string pelagem = Console.ReadLine()!; 

Console.WriteLine();
                                                                              
Console.WriteLine("+=========================================================+");
Console.Write("|                  ");
Console.ForegroundColor = ConsoleColor.Red; 
Console.Write("Pet Hotel Nem um Pio");
Console.ResetColor();
Console.WriteLine("                   |");
Console.WriteLine("+=========================================================+");

Console.Write("| Espécie: ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write(especie.Trim().ToUpper().PadLeft(15, '.').Substring(0, 15));
Console.ResetColor();

Console.Write(" | Raça: ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write(raca.Trim().ToUpper().PadLeft(22, '.').Substring(0, 22));
Console.ResetColor();
Console.WriteLine(" |");
Console.WriteLine("+=========================================================+");

Console.Write("| Sexo: ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write(sexo.Trim().ToUpper().PadLeft(49, '.').Substring(0, 49));
Console.ResetColor();
Console.WriteLine(" |");
Console.WriteLine("+=========================================================+");

Console.Write("| Nome do Pet: ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write(nome.Trim().ToUpper().PadLeft(42, '.').Substring(0, 42));
Console.ResetColor();
Console.WriteLine(" |");
Console.WriteLine("+=========================================================+");

Console.Write("| Idade:(anos) ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write(idade.Trim().ToUpper().PadLeft(11, '.').Substring(0, 11));
Console.ResetColor();
Console.Write(" | Pelagem: ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write(pelagem.Trim().ToUpper().PadLeft(19, '.').Substring(0, 19));
Console.ResetColor();
Console.WriteLine(" |");
Console.WriteLine("+=========================================================+");
Console.WriteLine();

  }
}

