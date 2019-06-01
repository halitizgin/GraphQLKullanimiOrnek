using GraphQL.Client.Http;
using GraphQL.Common.Request;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphQLKullanımıo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public GraphQLHttpClient client;

        private async void ListMovies()
        {
            var result = await client.SendQueryAsync(GraphQLQueries.ALL_MOVIES);
            if (result.Errors != null)
            {
                MessageBox.Show(result.Errors[0].Message);
            }
            else
            {
                List<Movie> movies = JsonConvert.DeserializeObject<List<Movie>>(result.Data.allMovies.ToString());
                foreach (Movie movie in movies)
                {
                    int count = listView1.Items.Count;
                    listView1.Items.Add(movie.id);
                    listView1.Items[count].SubItems.Add(movie.name);
                    listView1.Items[count].SubItems.Add(movie.year.ToString());
                    listView1.Items[count].SubItems.Add(movie.imdb.ToString());
                    listView1.Items[count].SubItems.Add(movie.subject);
                }
            }
        }

        private async void ListDirectors()
        {
            var result = await client.SendQueryAsync(GraphQLQueries.ALL_DIRECTORS);
            if (result.Errors != null)
            {
                MessageBox.Show(result.Errors[0].Message);
            }
            else
            {
                List<Director> directors = JsonConvert.DeserializeObject<List<Director>>(result.Data.allDirectors.ToString());
                foreach (Director director in directors)
                {
                    int count = listView2.Items.Count;
                    listView2.Items.Add(director.id);
                    listView2.Items[count].SubItems.Add(director.name);
                    listView2.Items[count].SubItems.Add(director.birth.ToString());
                }
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            client = new GraphQLHttpClient("http://localhost:4000/graphql");
            ListMovies();
            ListDirectors();
        }

        private async void GetDirectorFromMovie(string id)
        {
            GraphQLRequest request = new GraphQLRequest();
            request.Query = GraphQLQueries.MOVIE;
            request.Variables = new { id = id };
            var result = await client.SendQueryAsync(request);
            Movie movie = JsonConvert.DeserializeObject<Movie>(result.Data.movie.ToString());
            Yönetmen yonetmen = new Yönetmen();
            yonetmen.directorID.Text = movie.director.id;
            yonetmen.directorName.Text = movie.director.name;
            yonetmen.directorBirth.Text = movie.director.birth.ToString();
            yonetmen.ShowDialog();
        }

        private void YönetmeniGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = listView1.SelectedItems[0].Text;
            GetDirectorFromMovie(id);
        }

        private async void GetMoviesFromDirector(string id)
        {
            GraphQLRequest request = new GraphQLRequest();
            request.Query = GraphQLQueries.DIRECTOR;
            request.Variables = new { id = id };
            var result = await client.SendQueryAsync(request);
            Director director = JsonConvert.DeserializeObject<Director>(result.Data.director.ToString());
            Filmler filmler = new Filmler();
            foreach (Movie movie in director.movies)
            {
                int count = filmler.listView1.Items.Count;
                filmler.listView1.Items.Add(movie.id);
                filmler.listView1.Items[count].SubItems.Add(movie.name);
                filmler.listView1.Items[count].SubItems.Add(movie.year.ToString());
                filmler.listView1.Items[count].SubItems.Add(movie.imdb.ToString());
                filmler.listView1.Items[count].SubItems.Add(movie.subject);
            }
            filmler.ShowDialog();
        }
        private void FilmleriGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = listView2.SelectedItems[0].Text;
            GetMoviesFromDirector(id);
        }
        private void FilmEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YonetmenEkle ekle = new YonetmenEkle();
            ekle.ShowDialog();
        }

        private void YönetmenEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                FilmEkle ekle = new FilmEkle();
                ekle.id = listView2.SelectedItems[0].Text;
                ekle.client = this.client;
                ekle.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen bir yönetmen seçiniz!");
            }
        }
    }
}
