using ExemploExplorando.models;

Pessoa p1 = new Pessoa();
Pessoa p2 = new Pessoa();

p1.Nome = "Alexandre";
p1.Sobrenome = "Pereira da Rocha";
p1.Idade = 33;
p1.Apresentar();

p2.Nome = "Aline";
p2.Sobrenome = "Rodrigues Rocha";
p2.Idade = 34;
p2.Apresentar();

Pessoa p3 = new Pessoa("Anny Karolinny", "Pereira da Rocha", 16);
p3.Apresentar();

Curso c1 = new Curso();

c1.Nome = "Java";
c1.Alunos = new List<Pessoa>();
c1.AdicionarAluno(p1);
c1.AdicionarAluno(p2);
c1.AdicionarAluno(p3);

c1.ListarAlunos();

Console.WriteLine(c1.Alunos.Count());
Console.WriteLine($"Quantidade de alunos matriculados no curso de {c1.Nome}: {c1.ObterQuantidadeDeAlunosMatriculados()}");