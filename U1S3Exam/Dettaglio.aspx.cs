using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static U1S3Exam.Default;

namespace U1S3Exam
{
    public partial class Dettaglio : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string nomeProdotto = Request.QueryString["nomeProdotto"];

            List<Default.Product> products = new List<Default.Product>
            {

                    new Product { Name = "Call Of Duty Modern Warfare III", Image = "https://www.playstationzone.it/wp-content/uploads/2023/08/Call-Of-Duty-Modern-Warfare-3.jpg", Price = 10.99m, Description = "Acquista un'edizione qualsiasi e ottieni:\r\n\r\n- Disponibile in Call of Duty®: Modern Warfare® III, Call of Duty®: Modern Warfare® II e Call of Duty®: Warzone™:\r\n-- Pacchetto Operatore Soap*\r\n-- Skin Operatore Ghost Zombi*\r\n\r\nADATTATI O MUORI NELLA LOTTA ALLA MINACCIA DEFINITIVA\r\n\r\nNel seguito diretto di Call of Duty®: Modern Warfare® II, il capitano Price e la Task Force 141 affrontano la minaccia definitiva. Vladimir Makarov, criminale di guerra ultranazionalista, sta estendendo il suo potere nel mondo, costringendo la Task Force 141 a lottare come mai prima d'ora.\r\n" },
                    new Product { Name = "Fortnite", Image = "https://wallpapers.com/images/featured/fortnite-pictures-b5kfcchwazwiz3cs.jpg", Price = 20.49m, Description = "Combatti fino alla fine nelle modalità Battaglia reale e Zero costruzioni, esplora e sopravvivi in LEGO Fortnite, taglia il traguardo con Rocket Racing o suona in concerto con Fortnite Festival. Gioca migliaia di isole create dai giocatori insieme ai tuoi amici, con giochi deathrun, strategici, corse, sopravvivenza zombi e altro! Unisciti alla comunità dei creatori e crea la tua isola con Unreal Editor per Fortnite (UEFN) o con gli strumenti della modalità Creativa. \r\n" },
                    new Product { Name = "The Division", Image = "https://c4.wallpaperflare.com/wallpaper/132/773/143/tom-clancy-s-the-division-tom-clancy-video-games-wallpaper-preview.jpg", Price = 15.00m, Description = "Nella giornata del Black Friday, una devastante epidemia colpisce la città di New York e in breve tempo tutti i servizi di base vengono progressivamente a mancare. Nel giro di pochissimi giorni, la carenza di cibo e acqua fa piombare la metropoli nel caos. Per risolvere l’emergenza, viene attivata un’unità segreta chiamata Divisione. Pur conducendo una vita in apparenza normale, i suoi agenti speciali sono altamente addestrati per salvare la società, operando in maniera completamente autonoma." },
                    new Product { Name = "Assassin's Creed Valhalla", Image = "https://www.enkey.it/wp-content/uploads/2020/05/Assassin%E2%80%99s-Creed-Valhalla.jpg", Price = 40.00m, Description = "Sei Eivor e il tuo destino è diventare una leggenda tra i vichinghi.\r\n\r\n- Guida razzie leggendarie contro le truppe e le fortezze sassoni.\r\n- Scopri il viscerale stile di combattimento dei vichinghi impugnando due devastanti armi alla volta.\r\n- Mettiti alla prova affrontando la più ampia gamma di nemici mai vista in Assassin's Creed.\r\n- Determina l'evoluzione del tuo personaggio e del tuo insediamento con le tue scelte.\r\n- Esplora un mondo aperto medievale, spingiti dalle brutali coste della Norvegia fino agli incantevoli regni d'Inghilterra." },
                    new Product { Name = "Watch Dogs 2", Image = "https://gaming-cdn.com/images/products/1365/orig/watch-dogs-2-pc-gioco-ubisoft-connect-europe-cover.jpg?v=1701258317", Price = 20.49m, Description = "Gioca nei panni di Marcus Holloway, un brillante hacker che vive dove è nata la rivoluzione tecnologica, nella baia di San Francisco.\r\nUnisciti a Dedsec, un famigerato gruppo di hacker, per compiere l'impresa più grande della storia: hackerare e annientare il ctOS 2.0, un sistema operativo invasivo usato da menti criminali per controllare e manipolare i cittadini su larga scala." },
                    new Product { Name = "Dead Space", Image = "https://i.ytimg.com/vi/71sEFJBxE2Y/maxresdefault.jpg", Price = 5.99m, Description = "Il classico survival horror fantascientifico Dead Space™ torna, completamente ricostruito da zero, per offrire un'esperienza più profonda e coinvolgente. Questo remake offre un realismo visivo sbalorditivo, un audio atmosferico pieno di suspense e miglioramenti al gameplay restando fedele all'emozionante visione del gioco originale." },
                    new Product { Name = "Apex Legends", Image = "https://wallpapers.com/images/hd/apex-legends-hd-game-cover-70x25aizh3azzhwf.jpg", Price = 20.49m, Description = "Domina la competizione in Apex Legends, uno sparatutto gratuito* in stile battle royale in cui personaggi leggendari dotati di potenti abilità si sfidano per fama e ricchezza ai margini della Frontiera.\r\n\r\nPadroneggia un elenco in continua espansione di leggende diverse, un gioco di squadra intenso e tattico e audaci innovazioni che rivoluzionano l'esperienza del genere battle royale, il tutto all'interno di un mondo selvaggio dove tutto è permesso. La nuova evoluzione degli sparatutto ti dà il benvenuto." },
                    new Product { Name = "The Finals", Image = "https://www.kotaworld.it/images/2023/03/10/The-Finals_-destruction-is-insane.jpg", Price = 20.00m, Description = "Telespettatori, la notizia è arrivata: THE FINALS accetta concorrenti... cioè VOI! Esatto, presto il mondo potrebbe guardarvi fare a pezzi le nostre nuove arene dinamiche e conquistare la gloria!\r\n\r\nCome sapete, THE FINALS è il più grande gioco televisivo free-to-play per combattenti al mondo! I concorrenti si collegano al mondo virtuale e fanno squadra in tornei sempre più impegnativi. Combattono in arene impeccabili basate su luoghi reali, che possono alterare, sfruttare o distruggere." },
                    new Product { Name = "The Darkside Detective", Image = "https://sm.ign.com/ign_it/screenshot/default/blob_f5ds.jpg", Price = 30.00m, Description = "Dove strisciano i cultisti, dove dimorano i demoni, dove occulta... l'occulto? Ehm... È proprio lì che troverai il detective Francis McQueen, l'investigatore capo del penosamente sottofinanziato dipartimento Darkside. Quando l'oscurità varca la soglia di Twin Lakes City (ma anche quando si limita a bighellonare di fronte ai negozi o a nascondersi in loschi vicoletti) lui è lì, pronto a indagare su casi in cui nessun altro metterebbe il naso." },
                    new Product { Name = "The Curse Of Monkey Island", Image = "https://cdn.shortpixel.ai/client/q_glossy,ret_img,w_711,h_400/https://www.gamesoul.it/wp-content/uploads/2018/03/the-curse-of-monkey-island-su-steam-GameSoul-711x400.jpg", Price = 15.99m, Description = " L’aspirante pirata Guybrush Threepwood è fuggito dal parco a tema in cui è stato imprigionato dal suo acerrimo nemico, il pirata zombie LeChuck nella seconda parte e ora è perso in mare. Presto, tuttavia, si dirige a Plunder Island dove trova LeChuck e la sua ragazza Elaine. LeChuck cerca sempre di rubare Elaine da Guybush. LeChuck lo cattura e qui è dove inizia il gioco. Questo sequel non è solo una corretta continuazione dell’episodio precedente, ma spiega con successo cosa è successo nel bizzarro finale di Monkey Island 2.. Anche i personaggi non deludono. Non ci sono (tanti) vecchi conoscenti e il gioco introduce uno dei personaggi più divertenti dell’intera serie: il cranio parlante Murray. Anche i personaggi più dimenticabili sono divertenti grazie al superbo doppiaggio che contribuisce  a mio parere (molto) a creare un’ottima atmosfera." },
            };
            // Cerco il prodotto con il nome corrispondente tramite la funzione Find della lista di prodotti 
            Default.Product product = products.Find(p => p.Name == nomeProdotto);

            // Mostro i dettagli del prodotto
            imgProduct.ImageUrl = product.Image;
            lblProductName.InnerText = product.Name;
            lblProductPrice.InnerText = product.Price.ToString("C");
            lblProductDescription.InnerText = product.Description;

        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            // Ottengo il nome del prodotto dalla query string
            string nomeProdotto = Request.QueryString["nomeProdotto"];

            // Creo un nuovo cookie per memorizzare il prodotto nel carrello
            HttpCookie cartCookie = Request.Cookies["Cart"];
            if (cartCookie == null)
            {
                cartCookie = new HttpCookie("Cart");
            }

            //aggiungo nome e prezzo al carrello
            cartCookie.Value += $"{nomeProdotto}-";
            cartCookie.Value += $"{lblProductPrice.InnerText.Replace("€", "")}|";
            cartCookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(cartCookie);

            // Reindirizzo alla pagina Carrello.aspx
            Response.Redirect("Carrello.aspx");

        }
    }
}