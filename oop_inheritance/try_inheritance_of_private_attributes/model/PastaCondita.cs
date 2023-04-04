public class PastaCondita : Pasta
{
    private string condimento;

    public PastaCondita(string shape, double quantity, string condimento) : base(shape, quantity)
    {
        this.condimento = condimento;
    }

    public string getCondimento()
    {
        return this.condimento;
    }
}