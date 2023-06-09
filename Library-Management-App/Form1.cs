using System.Net;
using System.Drawing;
using System.Windows.Forms;
using HtmlAgilityPack;
using System;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace Library_Management_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_getImage_Click(object sender, EventArgs e)
        {

            string searchText = "yazý";
            string searchUrl = $"https://www.google.com/search?q={Uri.EscapeDataString(searchText)}&tbm=isch";

            WebClient webClient = new WebClient();
            string html = webClient.DownloadString(searchUrl);

            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(html);

            HtmlNode imageNode = document.DocumentNode.SelectSingleNode("//div[@id='search']//img");
            if (imageNode != null)
            {
                string imageUrl = imageNode.GetAttributeValue("src", "");
                lbl_url.Text = imageUrl;
            }
            else
            {
                lbl_url.Text = "Görüntü Bulunamadý";
            }
        }
    }
}