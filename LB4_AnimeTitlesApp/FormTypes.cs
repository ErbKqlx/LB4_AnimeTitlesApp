using LB4_AnimeTitlesApp.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace LB4_AnimeTitlesApp
{
    public partial class FormTypes : Form
    {
        private AnimeTitlesContext db;
        public FormTypes()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AnimeTitlesContext();
            this.db.AnimeTypes.Load();
            this.dataGridViewTypes.DataSource = this.db.AnimeTypes.Local
                .OrderBy(o => o.TypeOfAnime).ToList();
            dataGridViewTypes.Columns["Id"].Visible = false;
            dataGridViewTypes.Columns["AnimeTitles"].Visible = false;

            dataGridViewTypes.Columns["TypeOfAnime"].HeaderText = "Тип";
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }

        private void ButtonTypeAdd_Click(object sender, EventArgs e)
        {
            FormTypeAdd formTypeAdd = new();
            DialogResult result = formTypeAdd.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;


            AnimeType animeType = new AnimeType
            {
                TypeOfAnime = formTypeAdd.textBoxTypeName.Text
            };
            

            db.AnimeTypes.Add(animeType);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");

            this.dataGridViewTypes.DataSource = this.db.AnimeTypes.Local
                .OrderBy(o => o.TypeOfAnime).ToList();
        }
    }
}
