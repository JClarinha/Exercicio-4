public class Exame {

    public Nota notadoexame {get;set;} = new Nota();
    public Estudante estudante {get;set;}

    public Exame (){}

    public Exame(Estudante estudante) {
        this.notadoexame = notadoexame;
        this.estudante = estudante;
    }

    public int NotaExame() {

        if (estudante.presença == true)
        {
            notadoexame.notaexame = 20;
        }

        else{
            notadoexame.notaexame = -1;
        }
        return notadoexame.notaexame;








        System.Console.WriteLine(notadoexame.notaexame);
    }








}