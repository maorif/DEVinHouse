
import './App.css';
import Button from './components/Button';
import ContactCard from './components/ContactCard';
import Post from './components/Post';
import ProductCard from './components/ProductCard';
import Table from './components/Table';

function App() {
  return (
    <>
      <main>
        <div>
          <Button
            title='Button'
            backgroundColor='blue'>
            </Button>
            <Button
            title='Button 2'
            backgroundColor='orange'>
            </Button>
            <Button
            title='Button 3'
            backgroundColor='red'>
            </Button>
        </div>

        <div className='contact-list'>
          <ContactCard
            photo='redpanda'
            name='Red Panda'
            description='Cute red panda.'>
            </ContactCard>
          
          <ContactCard
            photo='mordecai'
            name='Mordecai'
            description='Mordecai from Regular Show.'>
            </ContactCard>
          
          <ContactCard
            photo='appa'
            name='Appa'
            description='A flying Bison.'>
            </ContactCard>
        </div>

        <div>
          <Post
            accountInfo={{name: 'Appa', photo: 'appa.png'}}
            description={'Learning to fly :) Lorem, ipsum dolor sit amet consectetur adipisicing elit. Laborum, ut quam maiores recusandae similique sit harum tempora. Ipsam numquam labore nemo cupiditate blanditiis qui vero, cum soluta distinctio eum ratione!'}
            image='learning-to-fly.gif'>
            </Post>
        </div>

        <div className='product-list'>
          <ProductCard
            photo='rice.jpg'
            name='Rice'
            price='5,00'>
            </ProductCard>
            <ProductCard
            photo='shovel.png'
            name='Shovel'
            price='50,00'>
            </ProductCard>
            <ProductCard
            photo='christmas-256px.png'
            name='Christmas gift'
            price='???'>
            </ProductCard>
        </div>

        <div>
          <Table
            title='Lista'
            description='uma lista de coisas'
            columns={['name', 'quantity', 'price']}
            data={[{
              name: 'coisa1',
              quantity: 200,
              price: 'R$ 25,00'
            },
            {
              name: 'coisa2',
              quantity: 57,
              price: 'R$ 39,00'
            },
            {
              name: 'coisa3',
              quantity: 113,
              price: 'R$ 2,00' 
            }]}>
          </Table>
        </div>
      </main>
    </>
  );
}

export default App;
