using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
                            if (details.Length == 2)
                            {
                                string productName = details[0];
                                decimal productPrice;

                                // Controllo se il prezzo è valido 
                                if (decimal.TryParse(details[1], out productPrice))
                                {
                                    // Visualizza nome e prezzo
                                    pnlCartContent.Controls.Add(new LiteralControl($"{productName} - €{productPrice}"));

                                    pnlCartContent.Controls.Add(new LiteralControl("<br />"));

                                    total += productPrice;
                                }
                                else
                                {
                                    // Gestisco il prezzo non valido
                                    pnlCartContent.Controls.Add(new LiteralControl($"Errore: prezzo non valido per {productName}<br />"));
                                }
                            }

                        }
                    }

                    // Mostro il totale da pagare o un messaggio se il carrello è vuoto 
                    pnlCartContent.Controls.Add(new LiteralControl($"<br />Totale: €{total}"));
                }
                else
                {
                    pnlCartContent.Controls.Add(new LiteralControl("Il carrello è vuoto"));
                }

            }
        }


        //metodo per svuotare il carrello
        protected void btnClearCart_Click(object sender, EventArgs e)
        {
        
            if (Request.Cookies["Cart"] != null)
            {
                Response.Cookies["Cart"].Expires = DateTime.Now.AddDays(-1);

                Response.Redirect(Request.RawUrl);
            }
        }
    }
}