import React from "react";
import { useContext } from "react";
import { Link } from 'react-router-dom';
import { CartContext } from '../../contexts/Cart';

function Book({book, id, title, image, price}) {

    const {addItem} = useContext(CartContext);

    return(
        <div className="book-card">

            <img src={image} alt={`${title} image`} width='90%'/>
            
            <p>{title}</p>

            <p>{`R$ ${price.toFixed(2)}`}</p>

            <div className="button-book-card-container">

                <button onClick={() => {addItem(book)}}>Comprar</button>

                <Link to={`/details/${id}`}><button>Detalhes</button></Link>

            </div>
            

        </div>
    );
};

export default Book;