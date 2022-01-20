import React from "react";
import { useContext } from "react";
import { CartContext } from "../../contexts/Cart";
import { Link } from 'react-router-dom';
import { HeaderCartInfo, HeaderNav, HeaderTitle } from './styles'

function Header() {

    const {cart} = useContext(CartContext);

    let i = 0;
    cart.map(() => (i++));
    
    return (

        <HeaderNav>
            
            <HeaderTitle>Book Shop</HeaderTitle>
            
            <Link style={{textDecoration: "none"}} to={"/cart"}><HeaderCartInfo>{`${i} livros no carrinho`}</HeaderCartInfo></Link>

        </HeaderNav>
    );
};

export default Header;