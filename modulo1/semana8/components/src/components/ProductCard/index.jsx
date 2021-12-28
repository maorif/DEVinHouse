import propTypes from 'prop-types';

const ProductCard = ({photo, name, price}) => {

    return (
        <div className='product-card'>
            <div className='product-card-image-container'>
                <img src={require(`../../assets/products-photos/${photo}`)}></img>
            </div>
            <div className='product-card-name-container'>
                <p>{name}</p>
            </div>
            <div className='product-card-price-container'>
                <p>R$ {price}</p>
            </div>
        </div>
    );
};

ProductCard.propTypes = {
    photo: propTypes.string.isRequired,
    name: propTypes.string.isRequired,
    price: propTypes.string.isRequired
};

export default ProductCard;