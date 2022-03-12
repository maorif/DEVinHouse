#nullable disable

namespace Ex7
{
    public class Exame
    {
        public string name { get; set; }
        public double grade { get; set; }

        public Exame(string name, double grade) {
            this.name = name;
            this.grade = grade;
        }
    }

    public class ListaExame
    {
        public List<Exame> exameList;

        public void AddGradeToList(Exame exame){

            if(exameList is null){
                exameList = new List<Exame>();
            }

            exameList.Add(exame);
        }

        public void GetHighestGrade(){

            var highestGrade = exameList.Max(exame => exame.grade);
            var highestGradeName = exameList.Find(exame => exame.grade == highestGrade).name;
            Console.WriteLine($"Maior nota: {highestGrade}\nAluno: {highestGradeName}");            
        }

        public void GetLowestGrade(){

            var lowestGrade = exameList.Min(exame => exame.grade);
            var lowestGradeName = exameList.Find(exame => exame.grade == lowestGrade).name;
            Console.WriteLine($"Menor nota: {lowestGrade}\nAluno: {lowestGradeName}");            
        }

        public void GetAverageGrade(){

            var averageGrade = exameList.Average(exame => exame.grade);
            Console.WriteLine($"Média da turma: {averageGrade}");
        }

        public void GetNumOfFails(){

            var numOfFails = exameList.Where(exame => exame.grade < 7.0).Count();
            
            Console.WriteLine($"Um total de {numOfFails} alunos reprovaram");
        }
    }
}