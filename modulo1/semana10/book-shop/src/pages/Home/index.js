import React from "react";
import { useEffect, useState, useContext } from 'react';
import Book from '../../components/Book';
import Container from "../../components/Container";

function Home() {
    
    const [books, setBooks] = useState([]);
    
    useEffect(() => {
        async function handleGetBook() {
            const response = await fetch(`http://localhost:3333/books`);
            const data = await response.json();

            setBooks(data);
        };

        handleGetBook();
    }, []);

    return (
        <Container>
            <h1>Total Books: {books.length}</h1>

            <div className="book-card-container">
                {
                    books.map((book) => 
                    <Book
                        book={book}
                        key={book.id}
                        id={book.id}
                        title={book.title}
                        image={book.image}
                        price={book.price} />)
                }
            </div>
        </Container>
    );
};

export default Home;