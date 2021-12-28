import propTypes from 'prop-types';

const Post = ({accountInfo, description, image}) => {

    return (
        <div className='post'>
            <div className='post-top'>

                <div className='post-info'>

                    <div className='post-account-photo-container'>
                        <img src={require(`../../assets/contacts-photos/${accountInfo.photo}`)}></img>
                    </div>

                    <div className='post-account-name-time-container'>
                        <h3>{accountInfo.name}</h3>
                        <span>15 min</span>
                    </div>

                </div>

                <div>
                    <span><b>...</b></span>
                </div>

            </div>
            
            <div className='post-description-container'>
                <p>{description}</p>
            </div>
            <div className='post-image-container'>
                <img src={require(`../../assets/posts-images/${image}`)}></img>
            </div>
            <div className='post-bottom'>
                <div className='post-bottom-info'>
                    <div className='post-comments-container'>
                        <p>{'<3'}</p>
                        <p>Comments</p>
                    </div>
                    <div>
                        <p><a href='#'>share</a></p>
                    </div>
                </div>
                <div>
                    <p>{'Like by Mordecai & 21 others'}</p>
                </div>
            </div>
        </div>
    );
};

export default Post;