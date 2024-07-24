Console.OutputEncoding = System.Text.Encoding.UTF8;
List<Card> cards = new();
string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
foreach (string inputItem in input)
{
    string[] tokens = inputItem.Split(" ");
    try
    {
        Card card = new(tokens[0], tokens[1]);
        cards.Add(card);
    }catch(ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
Console.WriteLine(string.Join(" ", cards));

public class Card
{
    private string face;
    private string suit;
    private readonly ICollection<string> faces;
    private readonly IReadOnlyDictionary<string, string> suits;

    public Card(string face, string suit)
    {
        faces = new HashSet<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        suits = new Dictionary<string, string>()
        {
            ["H"] = "♥",
            ["C"] = "♣",
            ["S"] = "♠",
            ["D"] = "♦"
        };
        Face = face;
        Suit = suit;
    }

    public string Face
    { 
        get => face;
        set
        {
            if (!faces.Contains(value)) throw new ArgumentException("Invalid card!");
            face = value;
        }
    }
    public string Suit
    {
        get => suit;
        set
        {
            if (!suits.ContainsKey(value)) throw new ArgumentException("Invalid card!");
            suit = suits[value];
        }
    }
    public override string ToString()
    {
        return $"[{Face}{Suit}]";
    }
}
