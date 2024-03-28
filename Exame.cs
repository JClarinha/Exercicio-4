public class Exame {

    public Nota notadoexame {get;set;} = new Nota();
    public Estudante estudante {get;set;}

    public Exame (){}

    public Exame(Estudante estudante) {
        this.estudante = estudante;
    }

    public float NotaExame() {
       
            if (estudante.presença == true)
            {
                
                System.Console.WriteLine("Insira a nota do Exame do estudante " + estudante.nome);
                while (true)
                {
                   
                    string n1 = System.Console.ReadLine(); // If user imputs a negative number == It's not a Bug it's a feature! ;D
                    float n;
                
                    if (float.TryParse(n1, out n))
                    {

                        
                        notadoexame.notaexame = n;
                        return n;
                    }
                System.Console.WriteLine("Por favor insira uma nota válida para o estudante " + estudante.nome);
                    
                    
                }
                 
            }
        
            else
            {
                
                notadoexame.notaexame =-1;
                //System.Console.WriteLine("O aluno " + estudante.nome + "não compareceu à realização do exame e como tal obteve uma classificação de  " + notadoexame.notaexame + " valores!");
                return notadoexame.notaexame;
            }

        
    
    }

}