using System.Windows.Forms;

namespace Sierpinski
{
	public partial class BufferedPanel : UserControl
	{
		public BufferedPanel()
		{
			InitializeComponent();
			SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		}
	}
}
