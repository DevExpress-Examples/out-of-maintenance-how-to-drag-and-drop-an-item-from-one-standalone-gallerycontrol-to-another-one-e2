using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;

namespace WindowsFormsApplication19
{
	public partial class Form1 : Form
	{
        DragDropHelper helper;

		public Form1()
		{
			InitializeComponent();
            helper = new DragDropHelper(galleryControl1, galleryControl2);
            helper.EnableDragDrop();
		}

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            helper.DisableDragDrop();
        }
	}
}