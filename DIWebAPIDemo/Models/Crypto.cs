namespace DIWebAPIDemo.Models
{

    public interface ICrypto
    {
        public string Name { get; set; }

        public string Desc { get; set; }


    }
    public class Crypto : ICrypto
    {
        public string Name { get; set; }
        public string Desc { get; set; }
    }
}
