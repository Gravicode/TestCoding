using Soal04.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Soal04.Pages
{
    public partial class MahasiswaFrm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            LoadData();
        }

        void LoadData()
        {
            if(!IsPostBack)
            {
                using (MahasiswaService svc = new MahasiswaService())
                {
                    var datas = svc.GetAll();
                    Grid1.DataSource = datas;
                    Grid1.DataBind();
                }
            }
        }
    }
}