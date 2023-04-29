namespace e_portfolio.Models
{
    public class Marque
    {
        public int Id { get; set; }
        public string Designation { get; set; }
        public ICollection<Produit> Produits { get; set; }
    }
}
