using System;

namespace ChainOfResponsability.Domain
{
    public class SecretariaAssinador : Assinador
    {
        private static Random rand = new Random();
        public override void Assinar(Documento documento)
        {
            bool verify = rand.NextDouble() >= 0.5;

            if (verify == true)
            {
                HandleSignature(documento);
            }
            else
            {
                Console.WriteLine($"Aguardando assinatura da secretaria academica - Documento  {documento.Id} - {documento.Name}");
            }
        }

        private void HandleSignature(Documento documento)
        {
            Console.WriteLine($"O Secretaria assinou o documento {documento.Id} - {documento.Name} e guardou o registro adequadamente");
        }
    }
}