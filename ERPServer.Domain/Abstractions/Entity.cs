namespace ERPServer.Domain.Abstractions
{
    public abstract class Entity
    {
        //default entitylerin ekleneceği id alanı, abstract hali, bu sayede default entitylerde product, category vb. inherit alarak bunu kullanabiliriz id alanı için
        public Guid Id { get; set; }
        protected Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
