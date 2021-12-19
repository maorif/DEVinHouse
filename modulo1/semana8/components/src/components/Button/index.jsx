import propTypes from 'prop-types';

const Button = ({title, backgroundColor}) => {

    return <button style={{backgroundColor: backgroundColor}}>{title}</button>;
};

Button.propTypes = {
    title: propTypes.string.isRequired,
    backgroundColor: propTypes.string.isRequired
};

export default Button;