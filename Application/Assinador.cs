namespace ChainOfResponsability.Domain
{
    public abstract class Assinador
    {
        protected Assinador _assinador;

        public void ProximoAssinador(Assinador assinador)
        {
            _assinador = assinador;
        }

        public abstract void Assinar(Documento documento);
    }
}