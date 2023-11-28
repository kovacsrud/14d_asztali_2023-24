using System.Text;
using System.Text.Json;

namespace MauiApihivas
{
    public partial class MainPage : ContentPage
    {
        HttpClient client;
        JsonSerializerOptions serializerOptions;
        string baseUrl = "https://jsonplaceholder.typicode.com";

        public MainPage()
        {
            InitializeComponent();
            client = new HttpClient();
            serializerOptions = new JsonSerializerOptions {
                WriteIndented = true
            };
        }

        private async void buttonAllPost_Clicked(object sender, EventArgs e)
        {
            var url = $"{baseUrl}/posts";
            var response= await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                using (var responseStream=await response.Content.ReadAsStreamAsync())
                {
                    var data = await JsonSerializer.DeserializeAsync<List<Post>>(responseStream, serializerOptions);
                    collectionPosts.ItemsSource = data;

                }

            } else
            {
                collectionPosts.EmptyView = "No data";
            }

            
        }

        private async void buttonOnePost_Clicked(object sender, EventArgs e)
        {
            var url = $"{baseUrl}/posts/1";
            var response=await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                using (var responseStream=await response.Content.ReadAsStreamAsync())
                {
                    var data = await JsonSerializer.DeserializeAsync<Post>(responseStream, serializerOptions);

                    var item=new List<Post> { data };
                    
                    collectionPosts.ItemsSource = item;
                }
            } else
            {
                collectionPosts.EmptyView = "No data";
            }
        }

        private async void buttonNewPost_Clicked(object sender, EventArgs e)
        {
            var url = $"{baseUrl}/posts";
            var post = new Post { id = 101, userId = 1, title = "New post", body = "Ez egy új post" };
            string json=JsonSerializer.Serialize(post,serializerOptions);
            StringContent content = new StringContent(json,Encoding.UTF8,"application/json");

            var response = await client.PostAsync(url, content);
            if (response.IsSuccessStatusCode)
            {
                DisplayAlert("Új adat beillesztése", response.StatusCode.ToString(), "Ok");
            } else
            {
                DisplayAlert("Új adat beillesztése", response.StatusCode.ToString(), "Ok");
            }

        }

        private async void buttonPatchPost_Clicked(object sender, EventArgs e)
        {
            var url = $"{baseUrl}/posts/1";
            var post = new Post { id = 1, userId = 1, title = "Módosított post", body = "Ez egy módosított post" };
            string json = JsonSerializer.Serialize(post, serializerOptions);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PatchAsync(url, content);
            if (response.IsSuccessStatusCode)
            {
                DisplayAlert("Adat módosítása", response.StatusCode.ToString(), "Ok");
            }
            else
            {
                DisplayAlert("Adat módosítása", response.StatusCode.ToString(), "Ok");
            }
        }

        private async void buttonDeletePost_Clicked(object sender, EventArgs e)
        {
            var url = $"{baseUrl}/posts/1";
            var response=await client.DeleteAsync(url);
            if (response.IsSuccessStatusCode)
            {
                DisplayAlert("Adat törlése", response.StatusCode.ToString(), "Ok");
            } else
            {
                DisplayAlert("Adat törlése", response.StatusCode.ToString(), "Ok");
            }

        }
    }
}