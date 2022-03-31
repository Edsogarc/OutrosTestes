using Exe06.Services;
namespace Exe06.Entities
{
    abstract class AbstractImposto : Iimposto
    {
        public abstract double CalculaImposto(double valor);
    }
}