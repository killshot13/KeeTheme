using System.Drawing;
using System.Windows.Forms;

namespace KeeTheme.Theme
{
	internal class DefaultTheme : EmptyTheme
	{
		public DefaultTheme()
		{
			Other.ControlNormalColor = SystemColors.Window;
			Other.ControlDisabledColor = SystemColors.Control;
			Button.FlatStyle = FlatStyle.Standard;
			TreeView.BorderStyle = BorderStyle.Fixed3D;
			RichTextBox.BorderStyle = BorderStyle.Fixed3D;
			ListView.BorderStyle = BorderStyle.Fixed3D;
			ToolStripRenderer = ToolStripManager.Renderer;
		}
	}
}