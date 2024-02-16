using System;
using System.Web;

namespace U1S3Exam
{
    public partial class Carrello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {   

                // Ottengo il cookie del carrello 
                HttpCookie cartCookie = Request.Cookies["Cart"];
                if (cartCookie != null)
                {
                    decimal total = 0; 
                    string cartContent = cartCookie.Value;

                    // Se il contenuto non è vuoto, mostro i prodotti nel carrello 
                    if (!string.IsNullOrEmpty(cartContent))
                    {
                        string[] products = cartContent.Split('|');

                        foreach (string productDetails in products)
                        {
                            string[] details = productDetails.Split('-');
                            if (details.Length == 2) // Se il formato è corretto
                            {
                                string productName = details[0];
                                decimal productPrice;
                                if (decimal.TryParse(details[1], out productPrice)) // Prova a convertire il prezzo in decimale
                                {
                                    lblCartContent.Text += $"{productName} - €{productPrice}"; // Visualizza nome e prezzo
                                    lblCartContent.Text += "<br />";

                                    total += productPrice; //totale ordine
                                }
                                else
                                {
                                    // Gestisco il prezzo non valido
                                    lblCartContent.Text += $"Errore: prezzo non valido per {productName}<br />";
                                }
                            }
                            
                        }
                    }

                    // Mostro il totale da pagare
                    lblCartContent.Text += $"<br />Totale: €{total}";
                }
                else
                {
                    lblCartContent.Text = "Il carrello è vuoto";
                }
            
            }
        }
        protected void btnClearCart_Click(object sender, EventArgs e)
        {
            // Rimuovo il cookie del carrello
            if (Request.Cookies["Cart"] != null)
            {
                Response.Cookies["Cart"].Expires = DateTime.Now.AddDays(-1);
                // Aggiorno la pagina col carrello vuoto 
                Response.Redirect(Request.RawUrl);
            }
        }
    }
}