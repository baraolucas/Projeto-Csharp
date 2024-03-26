/*//instanciar uma Universidade
Universidade objUniversidade = new Universidade();
objUniversidade.nome = "Up";
objUniversidade.localizacao = "Ecoville";
objUniversidade.anofundacao = 1990;

//Criar o curso ADS e adicionar na universidade
Curso objCurso = new Curso();
objCurso.nome = "ADS";
objUniversidade.AdicionarCurso(objCurso);

//criar o curso BSI e adicionar na universidade
objCurso = new Curso();
objCurso.nome = "BSI";
objUniversidade.AdicionarCurso(objCurso);

Console.WriteLine(objUniversidade.nome);
foreach(var curso in objUniversidade.cursos){
    Console.WriteLine(curso.nome);
}*/

Curso curso = new Curso();
Turma turma = new Turma();

//Atribuindo o estado do curso
curso.nome = "ADS";
curso.duracao = 2;

//Atribuindo o estado da turma
turma.ano_formacao = 2025;
turma.turno = "Noturno";


//Adicionar a tuma ao curso
curso.adicionarTurma(turma);

//Criar outra turma
turma = new Turma(); //Construir nova turma
turma.ano_formacao = 2026;
turma.turno = "Manhã";

//Adicionar a segunda turma ao curso
curso.adicionarTurma(turma);

//Imprimir as turmas que foram adicionadas ao curso
foreach(var t in curso.turmas){
    Console.WriteLine(t.turno);
}