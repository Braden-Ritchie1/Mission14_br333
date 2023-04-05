import { useEffect, useState } from 'react';
import { Movie } from '../movies/movie';

//this file handles the movie list and offers the ability to add a single movie at the bottom of the list using state

function MovieList() {
  const [listOfMovies, setListOfMovies] = useState<Movie[]>([]);

  useEffect(() => {
    const fetchMovie = async () => {
      const rsp = await fetch('https://localhost:4000/movie');
      const temp = await rsp.json();
      setListOfMovies(temp);
    };

    fetchMovie();
  }, []);

  return (
    <>
      <div>
        <h1>Joel Hilton's Movie Collection</h1>
      </div>

      <div>
        <table className="table table-striped">
          <thead>
            <tr>
              <th>Title</th>
              <th>Category</th>
              <th>Year</th>
              <th>Director</th>
              <th>Rating</th>
              <th>Edited</th>
              <th>Lent To</th>
              <th>Notes</th>
            </tr>
          </thead>

          <tbody>
            {listOfMovies.map((m) => (
              <tr key={m.movieId}>
                <td>{m.title}</td>
                <td>{m.category}</td>
                <td>{m.year}</td>
                <td>{m.director}</td>
                <td>{m.rating}</td>
                <td>{m.edited}</td>
                <td>{m.lentTo}</td>
                <td>{m.notes}</td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </>
  );
}
export default MovieList;
