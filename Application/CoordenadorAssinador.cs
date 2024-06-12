using System;

namespace ChainOfResponsability.Domain
{
    public class CoordenadorAssinador : Assinador
    {
        private static Random rand = new Random();
        public override void Assinar(Documento documento)
        {
            bool verify = rand.NextDouble() >= 0.5;

            if (verify == true)
            {
                HandleSignature(documento);
                _assinador.Assinar(documento);
            }
            else
            {
                Console.WriteLine($"Aguarando a assinatura do coordenador - Documento  {documento.Id} - {documento.Name}");
            }
        }

        private void HandleSignature(Documento documento)
        {
            Console.WriteLine($"O coordenador assinou o documento  {documento.Id} - {documento.Name}");
        }
    }
}