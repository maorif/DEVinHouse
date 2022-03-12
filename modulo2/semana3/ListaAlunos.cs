#nullable disable

namespace Ex8
{
    public class Aluno
    {
        public string name;
        public int classNumber;

        public Aluno(string name, int classNumber, ListaAluno listaAluno){
            this.name = name;
            this.classNumber = classNumber;
            listaAluno.AddToList(this);
        }
    }

    public class ListaAluno
    {
        public List<Aluno> studentsList;

        public void AddToList(Aluno aluno){
            
            if(studentsList is null){
                studentsList = new List<Aluno>();
            }

            studentsList.Add(aluno);
        }

        public List<Aluno> selectionSort(List<Aluno> vetor)
        {
	        int min, aux;

	        for (int i = 0; i < vetor.Count() - 1; i++)
	        {
	        	min = i;

	        	for (int j = i + 1; j < vetor.Count(); j++)
	        		if (vetor[j].classNumber < vetor[min].classNumber)
	        			min = j;

	        	if (min != i)
	        	{
	        		aux = vetor[min].classNumber;
	        		vetor[min].classNumber = vetor[i].classNumber;
	        		vetor[i].classNumber = aux;
	        	}
	        }

	        return vetor;
        }

    }
}