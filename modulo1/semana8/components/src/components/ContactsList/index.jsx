import propTypes from 'prop-types';

const ContactCard = ({photo, name, description}) => {

    return (
        <div className="contact-card">
            <div className="contact-image-container">
                <img src={require(`../../assets/contacts-photos/${photo}.png`)} alt={photo}></img>
            </div>
            <div className="contact-info-container">
                <h3>{name}</h3>
                <p>{description}</p>
            </div>
        </div>
    );
};

ContactCard.propTypes = {
    photo: propTypes.string.isRequired,
    name:  propTypes.string.isRequired,
    description: propTypes.string.isRequired
};

export default ContactCard;