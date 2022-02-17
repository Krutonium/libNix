using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using CodeBeautify;


namespace libNix
{
    public class Nix
    {
        public List<string> search(string name, int count)
        {
            var results = doQuery(name, count);
            List<string> packages = new List<string>();
            foreach(var _hit in results.Hits.HitsHits)
            {
                if (_hit.Source.Type == TypeEnum.Package)
                {
                    packages.Add(_hit.Source.PackagePname);
                }
            }
            return packages;
        }

        public List<Option> getOptions(string package, int count)
        {
            var result = doQuery(package, count);
            List<Option> options = new List<Option>();
            foreach(var _hit in result.Hits.HitsHits)
            {
                if (_hit.Source.Type == TypeEnum.Option)
                {
                    string description = strip(_hit.Source.OptionDescription);
                    string example = strip(_hit.Source.OptionExample);
                    Option option = new Option
                    {
                        Name = _hit.Source.OptionName,
                        Description = description,
                        DefaultValue = _hit.Source.OptionDefault,
                        ExampleValue = example,
                        Type = _hit.Source.OptionType
                    };
                    options.Add(option);
                }
            }
            return options;
        }
        
        public class Option
        {
            // ReSharper disable segment UnusedAutoPropertyAccessor.Global
            public string Name { get; set; }
            public string Description { get; set; }
            public string DefaultValue { get; set; }
            public string ExampleValue { get; set; }
            public string Type { get; set; }
        }

        private string strip(string toStrip)
        {
            string stripped;
            stripped = toStrip.Replace("<rendered-docbook>", "");
            stripped = stripped.Replace("</rendered-docbook>", "");
            return stripped;
        }

        private Welcome3 doQuery(string query, int count)
        {
            WebClient client = new WebClient();
            client.Headers.Add("user-agent", "libNix");
            string url = "https://nixos-search-5886075189.us-east-1.bonsaisearch.net/latest-26-nixos-21.11/_search?q=" +
                         query + "&size=" + count + "&pretty=false";
            client.Headers.Add("Content-Type", "application/json");
            client.Headers.Add("Authorization", "Basic ejNaRko2eTJtUjpkczhDRXZBTFBmOXB1aTdYRw==");
            string result = client.DownloadString(url);
            var results = Welcome3.FromJson(result);
            return results;
        }
    }
}
