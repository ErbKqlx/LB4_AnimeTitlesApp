using LB4_AnimeTitlesApp.Models;
using Microsoft.EntityFrameworkCore;

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
            this.dataGridViewTypes.DataSource = this.db.AnimeTypes.Local.OrderBy(o=>o.TypeOfAnime).ToList();
            dataGridViewTypes.Columns["Id"].Visible = false;
            dataGridViewTypes.Columns["AnimeTitles"].Visible = false;

            dataGridViewTypes.Columns["TypeOfAnime"].HeaderText = "“ип";
        }
    }
}
