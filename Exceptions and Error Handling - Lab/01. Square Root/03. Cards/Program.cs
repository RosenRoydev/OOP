using System.Security.Cryptography.X509Certificates;

public class StartUp
{
    static void Main(string[] args)
    {
        //A S, 10 D, K H, 2 C
        string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
        List <Card> cards = new List <Card> ();

        for (int i = 0; i < input.Length; i++)
        {
            try
            {
                string[] cardInfo = input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string face = GetFace(cardInfo[0]);
                CardSuit suit = GetSuit(cardInfo[1]);
                Card card = new Card (face, suit);
                cards.Add (card);

            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }  

        }
        Console.WriteLine($"{string.Join(" ",cards)}");

    }

    private static CardSuit GetSuit(string v)
    {
        switch (v)
        {
            case "S": 
                return CardSuit.Spades;
            case "D":
                return CardSuit.Diamonds;
            case "H":
            return CardSuit.Hearts;
            case "C":
                return CardSuit.Clubs;
            default:
                throw new ArgumentException("Invalid card!");
        }
    }

    private static string GetFace(string face)
    {
        switch (face)
        {
            case"2": face = "2";
                return "2";
            case "3":
                face = "3";
                return "3";
            case "4":
                face = "4";
                return "4";
            case "5":
                return "5";
                
            case "6":
                face = "6";
                return "6";
            case "7":
                face = "7";
                return "7";
            case "8":
                face = "8";
                return "8";
            case "9":
                face = "9";
                return "9";
            case "10":
                face = "10";
                return "10";
            case "J":
                face = "J";
                return "J";
            case "Q":
                face = "Q";
                return "Q";
            case "K":
                face = "K";
                return "K";
            case "A":
                face = "A";
                return "A";
            default:
                throw new ArgumentException("Invalid card!");
                
        };
    }
}


public class Card
{
  
    
    public Card(string cardFace, CardSuit cardSuit)
    {
        CardFace = cardFace;
        CardSuit = cardSuit;
    }
    public string CardFace { get;  set; }
    public CardSuit CardSuit { get; set; }

    public override string ToString()
    {
        char viewSuit = '\u2660';

        switch (this.CardSuit)
        {
            case CardSuit.Spades:
                viewSuit = '\u2660';
                break;
            case CardSuit.Diamonds:
                viewSuit = '\u2666';
                break;
            case CardSuit.Hearts:
                viewSuit = '\u2665';
                break;
            case CardSuit.Clubs:
                viewSuit = '\u2663';
                break;
            default:
                break;
        }

        return $"[{CardFace}{viewSuit}]";
    }



}
public enum CardSuit
{
    Clubs = 0,
    Diamonds = 1,
    Hearts = 2,
    Spades = 3,


}






