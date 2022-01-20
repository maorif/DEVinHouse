import React from "react";
import { useContext } from "react";
import { CartContext } from "../../contexts/Cart";
import { MdDelete } from "react-icons/md";

import  Container  from '../../components/Container';
import { Table, THeader, TBody, CartPhoto, Row, RowItem } from './styles';


function Cart () {

    const {cart, removeItem} = useContext(CartContext);
    
    const total = cart.reduce((a, b) => a + b.price, 0).toFixed(2);
    console.log(total);
    return (
        <Container>
            <h2>Total: 
              {new Intl.NumberFormat(
                              'pt-BR',
                              { style: 'currency', currency: 'BRL' }
                            ).format(total)
              }
            </h2>
            <Table>
                <THeader>
                  <tr key={'thead'}>
                    <th key={'id'}>id</th>
                    <th key={'name'}>Nome</th>
                    <th key={'price'}>Preço</th>
                    <th key={'delete'}>Deletar</th>
                  </tr>
                </THeader>
                <TBody>
                    {cart.map(book =>
                        <Row>
                          <RowItem>
                            <CartPhoto
                              src={book.image}
                              alt="book image"
                            />
                          </RowItem>
                          <RowItem>{book.title}</RowItem>
                          <RowItem>{
                            new Intl.NumberFormat(
                              'pt-BR',
                              { style: 'currency', currency: 'BRL' }
                            ).format(book.price)
                          }
                          </RowItem>
                          <RowItem>
                            <MdDelete
                              size={30}
                              color="navy"
                              onClick={() => removeItem(book.idBook)}
                            />
                          </RowItem>
                        </Row>
                    )}
                </TBody>
            </Table>
        </Container>

        
    );
};

export default Cart;