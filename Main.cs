using System.Threading.Tasks.Dataflow;

Estudante _1 = new Estudante("Rita" , false);
Estudante _2 = new Estudante("João" , true);
Estudante _3 = new Estudante("Leonor" , true);
Estudante _4 = new Estudante("Noah" , false);
Estudante _5 = new Estudante("Maria" , false);



Estudante[] elementos = {_1,_2,_3,_4,_5};

Turma a = new Turma(elementos);

a.Display();

Exame e1 = new Exame(_1);

System.Console.WriteLine(e1.NotaExame()); 






