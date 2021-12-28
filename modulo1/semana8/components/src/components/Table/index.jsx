import propTypes from 'prop-types';

const Table = ({
    title,
    description,
    columns,
    data
}) => {

    const thead = columns.map((column, index) => <th key={'head'+index}>{column}</th>);
    
    const tbody = data
        .map((obj, index) => <tr key={'row'+index}>{columns.map((column, index) => <td key={'data'+index}>{obj[column]}</td>)}</tr>);

    return (
        <div className='table-container'>
            <h1 className='table-title'>{title}</h1>

            <p className='table-description'>{description}</p>
        
            <table>

                <thead><tr>{thead}</tr></thead>

                <tbody>{tbody}</tbody>

            </table>
        </div>
    );
};

Table.propTypes = {
    title: propTypes.string.isRequired,
    description: propTypes.string.isRequired,
    columns: propTypes.array.isRequired,
    data: propTypes.array.isRequired
};

export default Table;