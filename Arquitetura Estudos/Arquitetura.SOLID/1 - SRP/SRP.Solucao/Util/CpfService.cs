namespace Arquitetura.SOLID.SRP.Solucao.Util
{
    public static class CpfService
    {
        public static bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}
