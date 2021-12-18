class Book {
    constructor(title, author, year){
        this.title = title;
        this.author = author;
        this.year = year;
        this.borrowed = false;
    }

    Borrow(){
        this.borrowed = true;
        return `${this.title} was borrowed`;
    }

    static sortByYear(books){
        return books.sort((a, b) => a.year - b.year);
    }
}

let dune = new Book('Dune', 'Frank', 1965);
let harryP = new Book('Harry Potter', 'J. K. Rolling', 1997);
let lostWorld = new Book('Lost World', 'A. Conan Doyle', 1912)

console.log(dune.Borrow());

let books = [harryP, dune, lostWorld];

Book.sortByYear(books);
console.log(books);