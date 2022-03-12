#nullable disable

using Ex3;
using Ex4;
using Ex5;
using Ex6;
using Ex7;
using Ex8;
using Ex9;
using Ex10;

//Ex 3
var retangulo = new Retangulo();
retangulo.AskSides();

// Ex 4
var askUser = new WhoIsOlder().AskUser;
askUser();

// Ex 5
var calculadora = new Calculadora();
calculadora.Calculator();

// Ex 6
var produto1 = new Item("bola", 15.50);
var produto2 = new Item("Caneca", 10.90);

var pedido = new Pedido();
pedido.AddToList(produto1);
pedido.AddToList(produto2);

Console.WriteLine($"Número de items: {pedido.NumItens()}");
Console.WriteLine($"Valor total: {pedido.TotalValue()}");

// Ex 7
var exame1 = new Exame("João", 9.0);
var exame2 = new Exame("Maria", 9.5);
var exame3 = new Exame("Pedro", 5.4);
var exame4 = new Exame("Luiza", 6.7);
var exame5 = new Exame("John", 7.2);

var exameList = new ListaExame();
exameList.AddGradeToList(exame1);
exameList.AddGradeToList(exame2);
exameList.AddGradeToList(exame3);
exameList.AddGradeToList(exame4);
exameList.AddGradeToList(exame5);

exameList.GetHighestGrade();
exameList.GetLowestGrade();
exameList.GetAverageGrade();
exameList.GetNumOfFails();

// Ex 8
var listaAlunos = new ListaAluno();

var aluno1 = new Aluno("João", 9, listaAlunos);
var aluno2 = new Aluno("Ana", 3, listaAlunos);
var aluno3 = new Aluno("Jorge", 3, listaAlunos);
var aluno4 = new Aluno("Maria", 7, listaAlunos);
var aluno5 = new Aluno("Pedro", 9, listaAlunos);
var aluno6 = new Aluno("Luiza", 9, listaAlunos);
var aluno7 = new Aluno("Laura", 3, listaAlunos);
var aluno8 = new Aluno("Johson", 7, listaAlunos);
var aluno9 = new Aluno("Maori", 3, listaAlunos);
var aluno10 = new Aluno("Kiki", 7, listaAlunos);
 
listaAlunos.studentsList.ForEach(aluno => Console.WriteLine($"aluno: {aluno.name} - sala: {aluno.classNumber}"));
Console.WriteLine("-----------");

var sortedList = listaAlunos.selectionSort(listaAlunos.studentsList);
sortedList.ForEach(aluno => Console.WriteLine($"aluno: {aluno.name} - sala: {aluno.classNumber}"));

// Ex 9
var animalList = new AnimalList();
var animal1 = new Animal("Simon", SpecieEnum.Dog, animalList);
var animal2 = new Animal("Amarelo", SpecieEnum.Cat, animalList);
var animal3 = new Animal("Lessy", SpecieEnum.Dog, animalList);
var animal4 = new Animal("Catatau", SpecieEnum.Cat, animalList);
var animal5 = new Animal("Nemo", SpecieEnum.Fish, animalList);

bool try1 = animal1.CheckSpecie(SpecieEnum.Cat);
Console.WriteLine($"{animal1.name} is a {SpecieEnum.Cat}? {try1}");
bool try2 = animal1.CheckSpecie(SpecieEnum.Dog);
Console.WriteLine($"{animal1.name} is a {SpecieEnum.Dog}? {try2}");

int numDogs = animalList.CheckNumOfDogs();
Console.WriteLine($"There is {numDogs} dogs in the list");

// Ex 10
var product1 = new Product("TV", 5299.00);
Console.WriteLine($"{product1.name}: R${product1.value}\nDiscount: {product1.ReturnDiscount()}%");
var product2 = new Product("Notebook", 6799.90, 0.05);
Console.WriteLine($"{product2.name}: R${product2.value}\nDiscount: {product2.ReturnDiscount()}%");

var checkProduct = new CheckProduct().PriceWithDiscount;

checkProduct(product1);
checkProduct(product2);







