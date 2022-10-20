using cspOptometry.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cspOptometry.Views
{
  public partial class FrmMyopiaSetting : DevExpress.XtraEditors.XtraForm
  {
    private void buttonEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
    {
      using (FolderBrowserDialog sfd = new FolderBrowserDialog())
      {
        if (sfd.ShowDialog() == DialogResult.OK)
        {
          SettingUtils.MyopiaSaveDir = sfd.SelectedPath;
          SetDir();
        }
      }
    }

    private void SetDir()
    {
      txtMyopiaSaveDir.Text = SettingUtils.MyopiaSaveDir;
    }

    public FrmMyopiaSetting()
    {
      InitializeComponent();
      SetDir();
    }
  }
}
