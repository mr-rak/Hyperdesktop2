using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Runtime.InteropServices;

public static class Screen_Capture
{		
	[StructLayout(LayoutKind.Sequential)]
	struct CURSORINFO { public Int32 cbSize; public Int32 flags; public IntPtr hCursor; public POINTAPI ptScreenPos; }

	[StructLayout(LayoutKind.Sequential)]
	struct POINTAPI { public int x; public int y; }

	[DllImport("user32.dll")]
	static extern bool GetCursorInfo(out CURSORINFO pci);

	[DllImport("user32.dll", SetLastError = true)]
	static extern bool DrawIconEx(IntPtr hdc, int xLeft, int yTop, IntPtr hIcon, int cxWidth, int cyHeight, int istepIfAniCur, IntPtr hbrFlickerFreeDraw, int diFlags);
				
	[DllImport("user32.dll")]  
	static extern IntPtr GetForegroundWindow();
	
	[DllImport("user32.dll")]
	static extern bool GetWindowRect(IntPtr hwnd, ref RECT rectangle);

    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int Left;        // x position of upper-left corner
        public int Top;         // y position of upper-left corner
        public int Right;       // x position of lower-right corner
        public int Bottom;      // y position of lower-right corner
        public RECT(int l, int t, int r, int b)
        {
            Left = l;
            Top = t;
            Right = r;
            Bottom = b;
        }
    }

    public static Bitmap region(RECT area, bool cursor = true, PixelFormat pixel_format = PixelFormat.Format32bppRgb)
	{
		Bitmap bmp;

		try { bmp = new Bitmap(area.Right - area.Left, area.Bottom - area.Top, pixel_format); }
		catch { bmp = new Bitmap(100, 100, pixel_format); }
		
		Graphics g = Graphics.FromImage(bmp);
		g.CopyFromScreen(area.Left, area.Top, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
		
		if (cursor)
		{
			CURSORINFO cursor_info;
			cursor_info.cbSize = Marshal.SizeOf(typeof (CURSORINFO));

			if (GetCursorInfo(out cursor_info))
				if (cursor_info.flags == (Int32)0x0001)
				{
					var hdc = g.GetHdc();
					DrawIconEx(hdc, cursor_info.ptScreenPos.x - area.Left, cursor_info.ptScreenPos.y - area.Top, cursor_info.hCursor, 0, 0, 0, IntPtr.Zero, (Int32)0x0003);
					g.ReleaseHdc();
				}
		}
		
		g.Dispose();
		return bmp;
	}
	
	public static Bitmap screen(bool cursor = true, PixelFormat pixel_format = PixelFormat.Format32bppRgb)
	{
        Screen screen = Screen.FromPoint(Cursor.Position);
        RECT rect = new RECT(screen.Bounds.Left, screen.Bounds.Top, screen.Bounds.Right, screen.Bounds.Bottom);
		return region(rect, cursor, pixel_format);
	}
	
	public static Bitmap window(bool cursor = true, PixelFormat pixel_format = PixelFormat.Format32bppRgb)
	{
		var rect = new RECT();
		GetWindowRect(GetForegroundWindow(), ref rect);
		return region(rect, cursor, pixel_format);
	}
}