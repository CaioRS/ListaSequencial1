using System;

class MainClass {

  public static void ex3(){
    float num1, num2;

    Console.WriteLine ("Digite o primeiro numero : ");
    num1 = float.Parse(Console.ReadLine());

    Console.WriteLine ("Digite o segundo numero : ");
    num2 = float.Parse(Console.ReadLine());

    Console.WriteLine ("A soma dos numeros eh : {0}", num1+num2);

  }

  public static void ex4(){
    float num1, num2, num3, num4;

    Console.WriteLine ("Digite o primeiro numero : ");
    num1 = float.Parse(Console.ReadLine());

    Console.WriteLine ("Digite o segundo numero : ");
    num2 = float.Parse(Console.ReadLine());

    Console.WriteLine ("Digite o terceiro numero : ");
    num3 = float.Parse(Console.ReadLine());

    Console.WriteLine ("Digite o quarto numero : ");
    num4 = float.Parse(Console.ReadLine());

    Console.WriteLine ("A media dos numeros eh : {0}", (num1+num2+num3+num4)/4);

  }




  public static void Main (string[] args) {
    int escolha;

    Console.WriteLine ("Apresentação Exercicio...escolha entre 3 ou 4: ");
    escolha = int.Parse(Console.ReadLine());
    
   
     if(escolha != 3 && escolha !=4){
      Console.WriteLine ("Numero digitado incorreto, escolha entre 3 ou 4");
     }

     if(escolha ==3){
      ex3();
     }

     if(escolha ==4){
      ex4();
    }
}
}