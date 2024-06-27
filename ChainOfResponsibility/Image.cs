public class Image
{
    public string Name { get; set; }
    public string Extension { get; set; }
    public Image(string name, string extension)
    {
        Name = name;
        Extension = extension;
    }
}