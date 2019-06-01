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
    public partial class YonetmenEkle : Form
    {
        public YonetmenEkle()
        {
            InitializeComponent();
        }

        GraphQLHttpClient client;
        Form1 form1;

        private void YonetmenEkle_Load(object sender, EventArgs e)
        {
            form1 = (Form1)Application.OpenForms["Form1"];
            client = form1.client;
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != null)
            {
                GraphQLRequest request = new GraphQLRequest();
                request.Query = GraphQLQueries.ADD_DIRECTOR;
                string name = textBox1.Text.Trim();
                int birth = Convert.ToInt32(numericUpDown1.Value);
                request.Variables = new { name = name, birth = birth };
                var result = await client.SendMutationAsync(request);
                if (result.Errors != null)
                {
                    MessageBox.Show(result.Errors[0].Message);
                }
                else
                {
                    Director director = JsonConvert.DeserializeObject<Director>(result.Data.addDirector.ToString());
                    string id = director.id;
                    int count = form1.listView2.Items.Count;
                    form1.listView2.Items.Add(id);
                    form1.listView2.Items[count].SubItems.Add(name);
                    form1.listView2.Items[count].SubItems.Add(birth.ToString());
                    this.Hide();
                }
            }
        }
    }
}
