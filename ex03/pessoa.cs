using System;

namespace ex03
{
  public class Elevador 
  {
    public int AndarAtual {get; set;} 

    public int TotalAndares {get; set;}

    public int Capacidade {get; set;}

     public int PessoasPresentes {get; set;}

     public void Inicializa (int capacidade, int andadres)
     {
       this.Capacidade=capacidade;
       this.TotalAndares=andadres;
       this.AndarAtual=0;
       this.PessoasPresentes=0;
     }

     public void Entra()
     {
        if(this.PessoasPresentes < this.Capacidade){
          this.PessoasPresentes++;
          Console.WriteLine ("O elevador tem " + this.PessoasPresentes + "pessoas. Restam " +  (this.Capacidade-this.PessoasPresentes) + "lugares." );
        }else {
          Console.WriteLine ("Elevador Cheio");
        }
     }

     public void Sai()
      {
       if (this.PessoasPresentes > 0)
        {
          this.PessoasPresentes--;
          Console.WriteLine($"Elevador com {this.PessoasPresentes}. Restam ainda {(this.Capacidade - this.PessoasPresentes)} vagas."
          );	                                                                                                                                                                                                                                                                          
        }
      }

    public void Sobe()
    {
      if (this.AndarAtual<this.TotalAndares)
      {
        this.AndarAtual++;
        Console.WriteLine($"O andar atual do elevado é:{this.AndarAtual} .");
      }
      else {
        Console.WriteLine("O elevador se encontra no último andar.");
      }
    }
     public void Desce()
    {
      if (this.AndarAtual>0){
        this.AndarAtual--;
        Console.WriteLine($"O andar atual do elevado é:{this.AndarAtual} .");

      }
      else {
        Console.WriteLine("O elevador já se encontra no térreo.");
      }
    }

  }
}