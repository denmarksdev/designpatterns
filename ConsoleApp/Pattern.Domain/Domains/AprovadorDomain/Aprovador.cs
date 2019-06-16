namespace Pattern.Domain.Domains.AprovadorDomain
{
    public abstract class Aprovador  
    {
        protected Aprovador sucessor;

        public void SetSucessor(Aprovador sucessor)
        {
            this.sucessor = sucessor;
        }

        public abstract void ProcessarRequisicao(Compra compra);
    }
}
