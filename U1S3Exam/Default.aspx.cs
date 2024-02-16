using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace U1S3Exam
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Creo di una lista di prodotti
                List<Product> products = new List<Product>
                {
                    new Product { Name = "Call Of Duty Modern Warfare III", Image = "https://www.callofduty.com/content/dam/atvi/callofduty/cod-touchui/blog/hero/mwiii/MWIII-REVEAL-FULL-TOUT.jpg", Price = 10.99m },
                    new Product { Name = "Fortnite", Image = "https://wallpapers.com/images/featured/fortnite-pictures-b5kfcchwazwiz3cs.jpg", Price = 20.49m },
                    new Product { Name = "The Division", Image = "https://c4.wallpaperflare.com/wallpaper/132/773/143/tom-clancy-s-the-division-tom-clancy-video-games-wallpaper-preview.jpg", Price = 15.00m },
                    new Product { Name = "Assassin's Creed Valhalla", Image = "https://www.enkey.it/wp-content/uploads/2020/05/Assassin%E2%80%99s-Creed-Valhalla.jpg", Price = 40.00m },
                    new Product { Name = "Watch Dogs 2", Image = "https://gaming-cdn.com/images/products/1365/orig/watch-dogs-2-pc-gioco-ubisoft-connect-europe-cover.jpg?v=1701258317", Price = 20.49m },
                    new Product { Name = "Dead Space", Image = "https://i.ytimg.com/vi/71sEFJBxE2Y/maxresdefault.jpg", Price = 5.99m },
                    new Product { Name = "Apex Legends", Image = "https://www.nvidia.com/content/dam/en-zz/Solutions/GeForce/campaigns/frames-win-games/apex/geforce-frames-win-games-apex-legends-og-image-1200x630.jpg", Price = 20.49m },
                    new Product { Name = "The Finals", Image = "https://www.kotaworld.it/images/2023/03/10/The-Finals_-destruction-is-insane.jpg", Price = 20.00m },
                    new Product { Name = "The Darkside Detective", Image = "https://steambase.io/cdn-cgi/image/format=auto,width=450,height=210/https://cdn.akamai.steamstatic.com/steam/apps/795420/header.jpg", Price = 30.00m },
                    new Product { Name = "The Curse Of Monkey Island", Image = "https://cdn.shortpixel.ai/client/q_glossy,ret_img,w_711,h_400/https://www.gamesoul.it/wp-content/uploads/2018/03/the-curse-of-monkey-island-su-steam-GameSoul-711x400.jpg", Price = 15.99m },

                };

                // Assegno la lista di prodotti come DataSource del Repeater ed eseguo il databinding 
                Repeater1.DataSource = products;
                Repeater1.DataBind();
            }
        }

        // Creo una classe Product con le proprietà che posso riutilizzare in altre pagine 
        public class Product
        {
            public string Name { get; set; }
            public string Image { get; set; }
            public decimal Price { get; set; }
            
            public string Description { get; set; }
        }


        protected void btnDettagli_Click1(object sender, EventArgs e)
        {
            // Ottengo bottone e nome prodotto e reindirizzo alla pagina Dettaglio.aspx passando il nome del prodotto come parametro 
            Button btnDettagli = (Button)sender;
            string nomeProdotto = btnDettagli.CommandArgument; // CommandArgument contiene il nome del prodotto 
            Response.Redirect("Dettaglio.aspx?nomeProdotto=" + nomeProdotto); 

        }
    }


}
