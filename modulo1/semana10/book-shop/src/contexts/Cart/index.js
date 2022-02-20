/* 
  COMO CRIAR UM CONTEXTO 
  1 - Importar createContext do react
  2 - atribui createContext para uma variável
    Ex: export const CartContext = createContext([]);
  3 - Criar o Provider
  4 - Importar o Provider no App.js
  5 - Consumir o contexto usando o useContex 
  ...
*/

import { createContext, useEffect, useState } from "react"; // 1 
import { v4 as uuidv4 } from 'uuid';

export const CartContext = createContext([]); // 2

export function CartProvider({ children }) {

  const [cart, setCart] = useState([]);

  console.log(cart);

  function handleAddCart(book){

    const newBook = {
      ...book,
      idBook: uuidv4()
    };
  
    setCart([...cart, newBook]);
    localStorage.setItem("cart", JSON.stringify([...cart, newBook]));
    alert('Book added to cart');
  };


  function handleRemoveFromCart(idBook) {
    
    const cartFiltered = cart.filter(item => {
      if (item.idBook === idBook) {
        return false // Remove item do carrinho
      } else {
        return true // permanece item no carrinho
      }
    });
    setCart(cartFiltered)
    localStorage.setItem("cart", JSON.stringify(cartFiltered));
    alert('Book removed from cart');
  };


  useEffect(() => {
    
    function handleGetItensLocalStorage() {
      const storedArray = JSON.parse(localStorage.getItem('cart'));
      setCart(storedArray || []);
    };

    handleGetItensLocalStorage();
  }, []);


  return (
    <CartContext.Provider

      value={{
        cart: cart,
        addItem: handleAddCart,
        removeItem: handleRemoveFromCart
      }}>
      {children}  

    </CartContext.Provider>
  );
  
}