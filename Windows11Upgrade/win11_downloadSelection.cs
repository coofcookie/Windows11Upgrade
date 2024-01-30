using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;

namespace Windows11Upgrade {
    public partial class win11_downloadSelection : Form {
        private readonly Guid guid = Guid.NewGuid();
        private readonly List<Language> languages = new List<Language>();

        public win11_downloadSelection() {
            InitializeComponent();
            string urlLanguages;
            guid = Guid.NewGuid();
            urlLanguages =
                "https://www.microsoft.com/en-US/api/controls/contentinclude/html?pageId=a8f8f489-4c7f-463a-9ca6-5cff94d8d041&host=www.microsoft.com&segments=software-download,windows11&query=&action=getskuinformationbyproductedition";
            urlLanguages += "&sessionId=" + guid + "&productEditionId=2069&sdVersion=2";

            var webClient = new WebClient();
            var languagesHtml = webClient.DownloadString(urlLanguages);
            var pattern = "(?s)<select id=\"product-languages\">(.*)?</select>";
            var langagesFiltered = Regex.Match(languagesHtml, pattern).Groups[1].Value;
            langagesFiltered.Replace("selected value", "value");
            langagesFiltered = "<options>" + langagesFiltered + "</options>";
            var languagesXml = new XmlDocument();
            languagesXml.LoadXml(langagesFiltered);
            foreach (XmlNode language in languagesXml.GetElementsByTagName("option")) {
                var attribute = language.Attributes.GetNamedItem("value");
                if (attribute == null || string.IsNullOrEmpty(attribute.Value)) {
                    continue;
                }

                languages.Add(JsonConvert.DeserializeObject<Language>(attribute.Value));
            }

            foreach (var item in languages) listLanguages.Items.Add(item.language);
        }

        private void languageList_SelectionChange(object sender, EventArgs e) {
            btnDownloadSystem.Enabled = true;
            btnDownloadSystem.Text = "Download " + languages[listLanguages.SelectedIndex].language + " Windows 11 ISO";
        }

        private void btnDownloadSystem_Click(object sender, EventArgs e) {
            btnDownloadSystem.Text = "Please wait...";
            btnDownloadSystem.Enabled = false;
            string urlDownload;
            urlDownload = "https://www.microsoft.com/" + "en-US" +
                          "/api/controls/contentinclude/html?pageId=a224afab-2097-4dfa-a2ba-463eb191a285&host=www.microsoft.com&segments=software-download,windows11&query=&action=GetProductDownloadLinksBySku";
            urlDownload += "&sessionId=" + guid;
            urlDownload += "&skuId=" + languages[listLanguages.SelectedIndex].id;
            urlDownload += "&language=" + languages[listLanguages.SelectedIndex].language;
            urlDownload += "&sdVersion=2";

            var webClient = new WebClient();
            var downloadHtml = webClient.DownloadString(urlDownload);
            var pattern = "(?s)(<input.*?></input>)";
            var downloadFiltered = Regex.Match(downloadHtml, pattern).Groups[1].Value;
            downloadFiltered = "<inputs>" + downloadFiltered + "</inputs>";
            downloadFiltered = downloadFiltered.Replace("IsoX64", "&quot;x64&quot;");
            downloadFiltered = downloadFiltered.Replace("class=product-download-hidden", "");
            downloadFiltered = downloadFiltered.Replace("type=hidden", "");
            downloadFiltered = downloadFiltered.Replace("&nbsp;", " ");
            var downloadXml = new XmlDocument();
            downloadXml.LoadXml(downloadFiltered);
            foreach (XmlNode downloadLink in downloadXml.GetElementsByTagName("input")) {
                var attribute = downloadLink.Attributes.GetNamedItem("value");
                if (attribute == null || string.IsNullOrEmpty(attribute.Value)) {
                    continue;
                }

                dynamic downloadJson = JsonConvert.DeserializeObject(attribute.Value);
                globals.downloadURL = downloadJson["Uri"];
                Hide();
                var downloadSystem = new win11_downloadSystem();
                downloadSystem.Show();
                break;
            }
        }

        private void exit(object sender, FormClosingEventArgs e) {
            Environment.Exit(0);
        }

        public class Language {
            public string language { get; set; }
            public string id { get; set; }
        }
    }
}