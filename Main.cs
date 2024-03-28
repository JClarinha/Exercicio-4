using System.Threading.Tasks.Dataflow;

Estudante _1 = new Estudante("Rita");
Estudante _2 = new Estudante("João");
Estudante _3 = new Estudante("Leonor");
Estudante _4 = new Estudante("Noah");
Estudante _5 = new Estudante("Maria");
Estudante[] elementos = {_1,_2,_3,_4,_5};

System.Console.WriteLine("Estudantes da Turma Z \n");

Turma a = new Turma(elementos);

a.Display();


foreach (var item in elementos)
{
    System.Console.WriteLine("O estudante " + item.nome + " esteve presente?");
    while (true)
    {
        string tf = System.Console.ReadLine();
        if (tf == "Sim" || tf == "sim" || tf == "SIM" || tf == "S" || tf == "s")
        {
            item.presença = true;
            break;
        }
        else if (tf == "Não" || tf == "Nao" || tf == "NÃO" || tf == "não" || tf == "NAO" || tf == "nao" || tf == "N" || tf == "n")
        {
            item.presença = false;
            break;
        }
        else
        {
            System.Console.WriteLine("Por favor insira um valor válido para a presença do aluno.");
        }
    
    }
   

}


Exame[] exames = [new Exame(_1),new Exame(_2),new Exame(_3),new Exame(_4),new Exame(_5)];


foreach (var item in exames)
{
    item.NotaExame();
}

foreach (var item in exames)
{
    while (item.notadoexame.notaexame != -1)
    {
        System.Console.WriteLine("O estudante " + item.estudante.nome + " obteve a classificação de " + item.notadoexame.notaexame + " Valores!\n");
        break;
    }

    if (item.notadoexame.notaexame == -1)
    {
        System.Console.WriteLine("Devido à falta de comparência do estudante " + item.estudante.nome + " ao exame, foi-lhe atribuido de forma automática a classificação de -1 valores \n");   

    }
}



