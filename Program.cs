
using DIO_M3_Desafio_de_projeto.Entities;

namespace DIO_M3_Desafio_de_projeto{
  
  class Program{
    static void Main(string[] args){
      
      Knight hero = new Knight("Arus", "Knight", 20);
      Wizard jennica = new Wizard("Jennica", "White Wizard", 20);
      //Hero oponente = new Hero("Maleficus", "Devil", 99);

      Console.WriteLine($@"
        {hero}
        {jennica}
      ");

      Console.WriteLine(hero.Attack());
      Console.WriteLine(jennica.Attack());
      Console.WriteLine(jennica.Attack(2));
      Console.WriteLine(jennica.Attack(7));

    }
  }
  
}