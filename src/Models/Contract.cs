namespace src.Models;

public class Contract
{
    public int Id { get; set; }
    public int PersonId { get; set; }
    public DateTime CriationDate { get; set; }
    public string TokenId { get; set; }
    public double Value { get; set; }
    public bool Payment { get; set; }

    public Contract()
    {
        CriationDate = DateTime.Now;
        Value = 0;
        TokenId = "00000";
        Payment = false;
    }

    public Contract(double value, string tokenId)
    {
        CriationDate = DateTime.Now;
        Value = value;
        TokenId = tokenId;
        Payment = false;
    }
}