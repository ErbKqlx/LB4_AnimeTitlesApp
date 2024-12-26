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

        private void ButtonTypeUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewTypes.SelectedRows.Count == 0)
                return;

            int index = dataGridViewTypes.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewTypes[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            AnimeType animeType = db.AnimeTypes.Find(id);

            FormTypeAdd formTypeAdd = new();

            formTypeAdd.textBoxTypeName.Text = animeType.TypeOfAnime;

            DialogResult result = formTypeAdd.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            animeType.TypeOfAnime = formTypeAdd.textBoxTypeName.Text;

            db.SaveChanges();
            MessageBox.Show("Объект обновлен");
            this.dataGridViewTypes.DataSource = this.db.AnimeTypes.Local
                .OrderBy(o => o.TypeOfAnime).ToList();
        }
    }
}
