using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using HelloWorld.Functions;
using HtmlAgilityPack;


namespace HelloWorld.Scraping
{
    //TODO:意味は必ず１つとは限らないし、音声も複数ある可能性がある
    public abstract class ScrapingBase
    {
        public HtmlDocument doc { get; private set; }

        public async Task<ScrapingBase> DownloadhtmlAsync(string word)
        {
                var html = await API.DownloadHtmlAsync(GetDownloadURL(word), GetEncoding());
                doc = new HtmlDocument();
                doc.LoadHtml(html);
            
            return this;
        }

        public abstract string GetUrl();
        public abstract System.Text.Encoding GetEncoding();
        public abstract string GetDownloadURL(string word);
        public abstract string GetSoundSourceURL();
        public abstract string GetMeaning();

    }
}