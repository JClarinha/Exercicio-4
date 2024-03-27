using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

public class Turma{

    public Estudante[] turma_1 {get;set;} = new Estudante[5];

    public Turma () {}


    public Turma (Estudante[] turma_1) {
        this.turma_1 = turma_1;

    }


    public void Display () {
        for (int i = 0; i < turma_1.Length; i++)
        {
            System.Console.WriteLine(turma_1[i].nome); 
        }
    }






}