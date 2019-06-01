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
    public partial class FilmEkle : Form
    {
        public FilmEkle()
        {
            InitializeComponent();
        }

        public string id;
        public GraphQLHttpClient client;
        Form1 form1;

        private async void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                GraphQLRequest request = new GraphQLRequest();
                request.Query = GraphQLQueries.ADD_MOVIE;
                string name = textBox1.Text.Trim();
                int year = Convert.ToInt32(numericUpDown1.Value);
                int imdb = Convert.ToInt32(numericUpDown2.Value);
                string subject = textBox2.Text.Trim();
                request.Variables = new { name = name, year = year, imdb = imdb, subject = subject, directorId = id };
                var result = await client.SendMutationAsync(request);
                if (result.Errors != null)
                {
                    MessageBox.Show(result.Errors[0].Message);
                }
                else
                {
                    Movie movie = JsonConvert.DeserializeObject<Movie>(result.Data.addMovie.ToString());
                    string movieId = movie.id;
                    int count = form1.listView1.Items.Count;
                    form1.listView1.Items.Add(movieId);
                    form1.listView1.Items[count].SubItems.Add(name);
                    form1.listView1.Items[count].SubItems.Add(year.ToString());
                    form1.listView1.Items[count].SubItems.Add(imdb.ToString());
                    form1.listView1.Items[count].SubItems.Add(subject);
                    this.Hide();
                }
             }
        }

        private void FilmEkle_Load(object sender, EventArgs e)
        {
            form1 = (Form1)Application.OpenForms["Form1"];
        }
    }
}
