public class Students
{
    public string Name { get; set; }
    public decimal Nota1 { get; set; }
    public decimal Nota2 { get; set; }

    public Students(string name, decimal nota1, decimal nota2)
    {
        Name = name;
        Nota1 = nota1;
        Nota2 = nota2;
    }
    // Other properties, methods, events...
}
class Program
{
    static void Main()
    {
           List<Students> aluninhos = new List<Students>();
           Boolean a = true;
        while (a) {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------------------------");
            Console.WriteLine("            MENU           ");
            Console.WriteLine("1 - Criar aluno novo");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Media Geral");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("----------------------------");
            Console.ResetColor();
            Console.Write("Digite sua opção: ");
            string op = Console.ReadLine();

            switch (op){
                case "1":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("*****************************");
                    Console.Write("Digite seu nome: ");
                    Console.ResetColor();
                    string nome = Console.ReadLine();
                     Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Digite sua primeira nota: ");
                    Console.ResetColor();
                    string nota1 = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Digite sua segunda nota: ");
                     Console.ResetColor();
                    string nota2 = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("*****************************");
                    Console.ResetColor();
                    Students aluno = new Students(nome, System.Convert.ToDecimal(nota1), System.Convert.ToDecimal(nota2));
                    aluninhos.Add(aluno);
                    break;
                
                case "2":
                    foreach(Students alunoo in aluninhos){
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
                        Console.WriteLine($"Aluno: {alunoo.Name}");
                        Console.WriteLine($"Notas: {alunoo.Nota1} | {alunoo.Nota2}");
                        Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
                        Console.ResetColor();
                    }  
                    break;
                  case "3":

                    foreach(Students alunoo in aluninhos){
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        decimal payload = 0;
                        payload += (alunoo.Nota1 + alunoo.Nota2)/2;
                        Console.WriteLine("=================================");
                        Console.WriteLine($"Aluno: {alunoo.Name}");
                        Console.WriteLine($"Notas: {alunoo.Nota1} | {alunoo.Nota2}");
                        Console.WriteLine($"Media: {payload}");
                        if(payload >= 7){
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Situaçao: Aprovado");
                        }
                        else{
                              Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Situaçao: Reprovado");
                        }
                         Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("=================================");
                        Console.ResetColor();
                    }  
                    break; 
                case "0":
                    a = false;
                    break;
                   
            


            }
            

        }
    }
    
}
