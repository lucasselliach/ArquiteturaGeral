namespace Arquitetura.SOLID.DIP.Violacao
{
    public static class CpfServices
    {
        public static bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}
