
import './App.css';
import Button from './components/Button';
import ContactCard from './components/ContactsList';
import Post from './components/Post';

function App() {
  return (
    <>
      <main>
        <div>
          <Button
            title='Button'
            backgroundColor='blue'>
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

        <Post
          accountInfo={{name: 'Appa', photo: 'appa.png'}}
          description={'Learning to fly :) Lorem, ipsum dolor sit amet consectetur adipisicing elit. Laborum, ut quam maiores recusandae similique sit harum tempora. Ipsam numquam labore nemo cupiditate blanditiis qui vero, cum soluta distinctio eum ratione!'}
          image='learning-to-fly.gif'>
          </Post>
      </main>
    </>
  );
}

export default App;
