using Arquitetura.SOLID.DIP.Solucao.Interfaces;

namespace Arquitetura.SOLID.DIP.Solucao
{
    public class CpfServices : ICPFServices
    {
        public bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}
