public interface IMovieDatabase
{
    void Insert(MovieModel movie);
    void Delete(MovieModel movie);
    void Update(MovieModel movie);
    MovieModel Find(Guid id);
    IEnumerable<MovieModel> FindBy(string Title, int rating);




}





