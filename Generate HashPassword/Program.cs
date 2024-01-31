// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
using System.Text;


string GenerateHashPassword(string pass)
{
    byte[] passwordBytes = Encoding.UTF8.GetBytes(pass);
    byte[] hashBytes = SHA256.Create().ComputeHash(passwordBytes);
    return Convert.ToBase64String(hashBytes);
}
Console.WriteLine("Hello, World!");
Console.WriteLine("max tries is 10");
int i = 0;
int cont = 0;
while (i < 10)
{
 
    Console.WriteLine("enter pass ::");
    string pass = Console.ReadLine();

    string hashPass = GenerateHashPassword(pass);
    Console.WriteLine("hashed pass ::" + hashPass);


    if (i<10)
    {
        Console.WriteLine("Do you want to continue ? \n 1)Yes \n 2)No");
        cont = int.Parse(Console.ReadLine());
    }
    if (cont == 1) i++;
    else break;


}
Console.WriteLine("Thanks :)");
Console.ReadKey();




