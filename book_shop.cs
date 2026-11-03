public class book {
    public string Name;
    public int Count;
    public string Genre;
    public int Price;
    public bool Availability;

    public book(string name, int count, string genre, int price) {
        Name = name;
        Count = count;
        Genre = genre;
        Price = price;
        Availability = true;
    }
}