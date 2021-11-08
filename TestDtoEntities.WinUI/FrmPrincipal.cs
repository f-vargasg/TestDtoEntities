using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestDtoEntities.WinUI.WcfSrvTestDto;

namespace TestDtoEntities.WinUI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            InitMyComponents();

        }
        private void InitMyComponents()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = ConfigurationManager.AppSettings["formCaption"];
        }

        private void tlsStrExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tlsStrTest_Click(object sender, EventArgs e)
        {
            try
            {
                WcfSrvDtoClient client = new WcfSrvDtoClient();
                List<DetalleBloombergDTO> lst = new List<DetalleBloombergDTO>();
                var res = client.GetListDetalleBloomberg();

                foreach (var item in res)
                {
                   lst.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
