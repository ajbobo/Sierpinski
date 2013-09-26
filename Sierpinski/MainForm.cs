using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Sierpinski
{
	public partial class frmMain : Form
	{
		private List<Point> _vertices;
		private List<Point> _dots;
		private Random _rnd;

		public frmMain()
		{
			InitializeComponent();

			_vertices = new List<Point>();
			_dots = new List<Point>();
			_rnd = new Random();
		}

		private Point GetMidPoint(Point pnt1, Point pnt2)
		{
			int newx = (pnt1.X + pnt2.X) / 2;
			int newy = (pnt1.Y + pnt2.Y) / 2;
			return new Point(newx, newy);
		}

		private Point GetShapeCenter()
		{
			if (_vertices.Count == 0)
				return new Point(0, 0);

			int minX, maxX, minY, maxY;
			minX = maxX = _vertices[0].X;
			minY = maxY = _vertices[0].Y;

			foreach (Point pnt in _vertices)
			{
				if (pnt.X < minX)
					minX = pnt.X;
				if (pnt.X > maxX)
					maxX = pnt.X;
				if (pnt.Y < minY)
					minY = pnt.Y;
				if (pnt.Y > maxY)
					maxY = pnt.Y;
			}

			return new Point((minX + maxX) / 2,(minY + maxY) / 2);
		}

		private void btnClearVertices_Click(object sender, EventArgs e)
		{
			_vertices.Clear();
			_dots.Clear();

			pnlDisplay.Invalidate();
		}

		private void btnClearDots_Click(object sender, EventArgs e)
		{
			_dots.Clear();

			pnlDisplay.Invalidate();
		}

		private void btnDraw_Click(object sender, EventArgs e)
		{
			if (_vertices.Count == 0)
				return;

			// Get rid of old dots
			_dots.Clear();

			// Determine the first point to work from - this one isn't drawn
			Point lastpoint = GetShapeCenter();

			// Calculate new dots
			uint dotcnt = uint.Parse(txtDotCount.Text);
			for (uint x = 0; x < dotcnt; x++)
			{
				Point vertex = _vertices[_rnd.Next(_vertices.Count)];
				Point newdot = GetMidPoint(vertex, lastpoint);
				_dots.Add(newdot);
				lastpoint = newdot;
			}

			pnlDisplay.Invalidate();
		}

		private void pnlDisplay_MouseClick(object sender, MouseEventArgs e)
		{
			// Add the point where the user clicked to the vertex list
			Point selpoint = e.Location;
			_vertices.Add(selpoint);

			pnlDisplay.Invalidate();
		}

		private void pnlDisplay_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;

			// Draw the vertices
			foreach (Point pnt in _vertices)
			{
				g.FillEllipse(Brushes.Green, pnt.X - 2, pnt.Y - 2, 5, 5);
			}

			// Draw the dots
			foreach (Point pnt in _dots)
			{
				g.DrawEllipse(Pens.Black, pnt.X, pnt.Y, 1, 1);
			}
		}
	}
}
