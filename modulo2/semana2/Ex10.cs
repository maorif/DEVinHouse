#nullable disable

public class Ex10 {

    public void TestGrades(double[] grades) {

        Console.WriteLine(grades.Length + "\n");
        var maxGrade = grades.Max();
        var minGrade = grades.Min();
        var averageGrade = Math.Round(grades.Average(), 2);

        Console.Write($"A maior nota foi {maxGrade} \n" +
                        $"A menor nota foi {minGrade} \n" +
                        $"A média das notas foi {averageGrade} \n");
    }
};