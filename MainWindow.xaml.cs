using Microsoft.Win32;
// using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;

namespace DMF
{
    public partial class MainWindow : Window
    {
        public string authKey = "x-ms-blob-type";
        public string authValue = "BlockBlob";
        public string clientId = "8396c0c9-8aa6-48b4-9513-5f062d66f4b6";
        public string clientSecret = "S3g7Q~7LlDB3WZUceyJNeNcDWR_oZwjCZhrWz";
        public string fileContent = "";
        public string fileTitle = "";
        public string grantType = "client_credentials";
        public string resourceUrl = "https://management.azure.com/";
        public string sasUrl = "?sv=2020-08-04&ss=bfqt&srt=sco&sp=rwdlacupitfx&se=2062-12-31T05:00:00Z&st=2022-04-10T05:00:00Z&spr=https,http&sig=YnhMmBTb%2BiYAUuv5TWQyUqX4mfvHPsLAn8E90ps3BVE%3D";
        public string subscriptId = "7c3cdf04-4cf4-4531-baec-826c84722f9f";
        public string tenantId = "3e85c516-2459-4d8d-9d02-50f74400bfd2";

        /* ---------------------------------------------------------------------------------------------------------
           public string authToken = "";

           public class tokenApi
           {
               public string token_type { get; set; }
               public string expires_in { get; set; }
               public string ext_expires_in { get; set; }
               public string expires_on { get; set; }
               public string not_before { get; set; }
               public string resource { get; set; }
               public string access_token { get; set; }
           }

           public async Task getToken()
           {
               var dict1 = new Dictionary<string, string>();
                   dict1.Add("grant_type", grantType);
                   dict1.Add("client_id", clientId);
                   dict1.Add("client_secret", clientSecret);
                   dict1.Add("resource", resourceUrl);

               HttpClient client1 = new HttpClient();
               HttpRequestMessage req1 = new HttpRequestMessage();
               req1.Content = new FormUrlEncodedContent(dict1);
               req1.Method = HttpMethod.Post;
               req1.RequestUri = new Uri($"https://login.microsoftonline.com/{tenantId}/oauth2/token");

               HttpResponseMessage res1 = await client1.SendAsync(req1);
               var statC1 = (int)res1.StatusCode;
               var statT1 = res1.StatusCode;
               var txt1 = await res1.Content.ReadAsStringAsync();
               dynamic obj1 = JsonConvert.DeserializeObject<tokenApi>(txt1);
               authToken = obj1.access_token;
           }
        --------------------------------------------------------------------------------------------------------- */

        public MainWindow()
        {
            InitializeComponent();
        }

        public void postBrowse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofdP = new OpenFileDialog();
            ofdP.Multiselect = true;
            ofdP.Filter = "csv files(*.csv)|*.csv|json files(*.json)|*.json|txt files(*.txt)|*.txt|xlsx files(*.xlsx)|*.xlsx|xml files(*.xml)|*.xml";
            Nullable<bool> check = ofdP.ShowDialog();

            if(check == true)
            {
                postPath.Text = ofdP.FileName;
                fileTitle = Path.GetFileName(ofdP.FileName);
                fileContent = File.ReadAllText(postPath.Text);
            }
        }

        public async Task postFile()
        {
            var dict2 = new Dictionary<string, string>();
                        dict2.Add("", fileContent);

            HttpClient client2 = new HttpClient();
            HttpRequestMessage req2 = new HttpRequestMessage();
            req2.Content = new StringContent(fileContent);
            req2.Headers.Add("x-ms-blob-type", "BlockBlob");
            req2.Method = HttpMethod.Put;
            req2.RequestUri = new Uri($"https://insbrokercloudstoragedev.blob.core.windows.net/map-input/{fileTitle}{sasUrl}");

            HttpResponseMessage res2 = await client2.SendAsync(req2);
            var statC2 = (int)res2.StatusCode;
            var statT2 = res2.StatusCode;
            var txt2 = await res2.Content.ReadAsStringAsync();
            resultBox.Text = "{Status: " + statC2 + ", " + statT2 + "}\n" + txt2;
        }

        public async Task allApis()
        {
            // await getToken();
            await postFile();
        }

        public void postGo_Click(object sender, RoutedEventArgs e)
        {
            if (postPath.Text == "No selected file...")
            {
                MessageBox.Show("Please select a file.", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            else
            {
                allApis();
            }
        }
    }
}