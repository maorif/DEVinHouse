import React from "react";
import  { useEffect, useState } from 'react';
import { useParams } from 'react-router-dom';

import Container from "../../components/Container";

function Details() {

    const params = useParams();
    const [bookDetails, setBookDetails] = useState([]);

    console.log(params);

    useEffect(() => {
        async function handleGetBookDetails() {
            const response = await fetch(`http://localhost:3333/books?id=${params.id}`);
            
            const data = await response.json();

            setBookDetails(data);
            console.log(data)
        };

        handleGetBookDetails();
        
    }, [params.id]);

    console.log(bookDetails);

    return (
        <Container>
            {
                bookDetails.map((book) => (
                    <div className="details-container" key={book.id}>
                        <img src={book.image}/>
                        <div>
                            <h2>{book.title}</h2>
                            <p>{book.description}</p>
                        </div>
                    </div>
                ))
            }
        </Container>           
    );
};

export default Details;