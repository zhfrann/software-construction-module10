namespace modul10_103022330008.Models;

public class Movie
{
    public String Title { get; set; }
    public String Director { get; set; }
    public List<String> Stars { get; set; }
    public String Description { get; set; }

    public Movie() {}

    public Movie(String title, String director, List<String> stars, String description)
    {
        Title = title;
        Director = director;
        Stars = stars;
        Description = description;
    }
}
