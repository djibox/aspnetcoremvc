namespace e_portfolio.Models
{
    public class Produit
    {
        public int Id { get; set; }
        public string NomProduit { get; set; }
        public int PrixUnitaire { get; set; }
        public int QuantiteStock { get; set; }
        public int MarqueId { get; set; }
        public Marque Marque { get; set; }
    }
}
