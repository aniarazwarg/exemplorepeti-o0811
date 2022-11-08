using System;

class Program {
  public static void Main (string[] args) {
    int qtdAlunos, idadeAluno, diMenor=0, meIdade=150, maIdade=0 , somaIdade=0 ;
    //usa-se valor de variÀvel 0 pois NENHUM VALOR , nao pode ser somado.
  //foi usada menor idade 150 pois no exemplo não terá idade maior que isso, assim que a primeira idade é digitada ela substitui os 150 e é usada com comparação.
    
    do
    {
      Console.WriteLine ("Digite a quantidade de alunos: ");
      qtdAlunos=int.Parse(Console.ReadLine());
      if(qtdAlunos<=0)
        Console.WriteLine("Quantidade de alunos Inválida.");
      
    }while(qtdAlunos<=0);
    
    for(int i=1; i<=qtdAlunos; i++)
    {
      do
      {
        Console.WriteLine ("Idade do {0} aluno: ",i);
        idadeAluno=int.Parse(Console.ReadLine());
        if(idadeAluno<=0)
          Console.WriteLine("Idade inválida");
        if(idadeAluno<18)
          diMenor++; //diMenor=diMenor+1
        if (idadeAluno>maIdade)
          maIdade=idadeAluno;
        if (idadeAluno<meIdade)
          meIdade=idadeAluno;
        somaIdade+=idadeAluno;        
        }while(idadeAluno<=0);
    }
    Console.WriteLine ("{0} Alunos menores ",diMenor);
    Console.WriteLine ("A menor idade é:{0}  ",meIdade);
    Console.WriteLine ("A maior idade é:{0}  ",maIdade);
    Console.WriteLine ("A soma das idades é:{0}  ",somaIdade);
   
  }
}