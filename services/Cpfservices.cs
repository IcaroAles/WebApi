public class CpfServices
{
    public CpfService(int seed)
    {
        this.rand = new Random(seed);
    }
    Random rand;
    
    public bool Validate(string cpf)
    {
        throw new NotImplementException();
    }

    public string Generate()
    {
        throw new NotImplementException();
    }

    private string getValidationDigits(string cpf9digits)
    {
        throw new NotImplementException();
    }
}