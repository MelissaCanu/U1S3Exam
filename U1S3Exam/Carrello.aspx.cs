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
                                    // card bootstrap creata per ogni prodotto nel carrello 
                                    Panel cardPanel = new Panel();
                                    cardPanel.CssClass = "card custom-card border border-white shadow";

                                    Panel cardBodyPanel = new Panel();
                                    cardBodyPanel.CssClass = "card-body";

                                    Label nameLabel = new Label();
                                    nameLabel.Text = productName;
                                    nameLabel.CssClass = "card-title";

                                    Label priceLabel = new Label();
                                    priceLabel.Text = $"€{productPrice}";

                                    //con controls.add aggiungo i controlli al pannello 
                                    cardBodyPanel.Controls.Add(nameLabel); 
                                    cardBodyPanel.Controls.Add(new LiteralControl("<br />"));
                                    cardBodyPanel.Controls.Add(priceLabel);

                                    cardPanel.Controls.Add(cardBodyPanel);
                                    pnlCartContent.Controls.Add(cardPanel);
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
                    if (total > 0)
                    {
                        Panel totalPanel = new Panel();
                        totalPanel.CssClass = "card custom-card";

                        Panel totalBodyPanel = new Panel();
                        totalBodyPanel.CssClass = "card-body";

                        Label totalLabel = new Label();
                        totalLabel.Text = $"Totale: €{total}";
                        totalLabel.CssClass = "totale";

                        totalBodyPanel.Controls.Add(totalLabel);
                        totalPanel.Controls.Add(totalBodyPanel);
                        pnlCartContent.Controls.Add(totalPanel);
                    }
                    else
                    {
                        pnlCartContent.Controls.Add(new LiteralControl("Il carrello è vuoto"));
                    }
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