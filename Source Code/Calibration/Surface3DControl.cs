//........................................................................................................................................................................................................................
//..............................::........................................................................................................................................................................................
//...........................:+*****=:....................................................................................................................................................................................
//.......................:=+****=-+****+:.................................................................................................................................................................................
//....................:+*****-::=+-::+****+-..............................................................................................................................................................................
//.................-+****+:...=****+:...-+****=:..........................................................................................................................................................................
//..............-****+=.......-****+.......-+****+:.......................................................................................................................................................................
//..........:=****+-:...........=*:...........:=****+-....................................................................................................................................................................
//.......:*****+:...............-*................=*****=:................................................................................................................................................................
//....-+****=:..................-+...................-+****+:.............................................................................................................................................................
//...+***-:.::..................-*...................:..:+***:............................................................................................#@@@@+..........................................................
//...+**-:=====:................-*.................-====::***:...............#@@@@@@@@@@@@@@@@@@@@@@@@@@:.................................................%@@@@*..........................................................
//...+**-:=====-................-*................:=====-.***:...............#@@@@@@@@@@@@@@@@@@@@@@@@@@:.................................................%@@@@*..........................................................
//...***-..:-:.:---:............-*.............:-=-::--:.:***:...............*%@@@%%%@@@@@@@@@%@@@@@@@%%:.......:::...................:::::...............%@@@@*:.....:.........:::::........................::::.........
//...***:.........:-=-:.......-+***+:.......:-=-:........:***:..........................@@@@@=............:@@@@@@@@@@@@@@@@@#......#@@@@@@@@@@@@@@@@@-....%@@@@@@@@@@@@#....%@@@@@@@@@@@@@@@@%......+@@@@@@@@@@@@@@-......
//...+**-.............---:.-**+=--=+**+::-=-:.............***:..........................@@@@@=...........#@@@@@@@@@@@@@@@@@@@@-..-@@@@@@@@@@@@@@@@@@@@*...%@@@@@@@@@@@@%..=@@@@@@@@@@@@@@@@@@@@=..:@@@@@@@@@@@@@@@@-......
//...***-................:+****:...-+***=:................***:..........................@@@@@=..........-@@@@@@@@@@@@@@@@@@@@@#..%@@@@@@@@@@@@@@@@@@@@@:..%@@@@@@@@@@@@*..%@@@@@@@@@@@@@@@@@@@@@..=@@@@@@@@@@@@@@@@:......
//...***-................-*+..=*+=**:.:**.................***:..........................@@@@@=..........-@@@@@...........+@@@@#..%@@@@+...................%@@@@*..........%@@@@-..........-@@@@@..+@@@@#..................
//...***-................=*=...-***:..:**.................***:..........................@@@@@=..........-@@@@@###########%@@@@#..%@@@@%############*......%@@@@*..........@@@@@%##########%@@@@@..=@@@@#..................
//...***-................:**::**-.+*+:=*+.................***:..........................@@@@@=..........-@@@@@@@@@@@@@@@@@@@@@#..-@@@@@@@@@@@@@@@@@@@@:...%@@@@*..........@@@@@@@@@@@@@@@@@@@@@@..+@@@@#..................
//...***-..............:=*****-.....+****+-...............***:..........................@@@@@=..........-@@@@@@@@@@@@@@@@@@@@@#....%@@@@@@@@@@@@@@@@@@@...%@@@@*..........@@@@@@@@@@@@@@@@@@@@@@..=@@@@#..................
//...***-...........:+*+-...=********+....=**-............***:..........................@@@@@=..........-@@@@@-..................................:@@@@@:..%@@@@*..........@@@@@=..................=@@@@#..................
//...***-........-+*+:.........:-=::........:-**=:.......:***:..........................@@@@@=..........-@@@@@:..................#@@@@-..........:@@@@@:..%@@@@*..........@@@@@=..................+@@@@#..................
//...***-.=***+++=..............:-..............:+++***+::***:..........................@@@@@=..........:@@@@@@@@@@@@@@@@@@@@@#..#@@@@@@@@@@@@@@@@@@@@@:..%@@@@@@@@@@@@#..%@@@@@@@@@@@@@@@@@@@@@..=@@@@#..................
//...+**-:*****=................:-................:*****=:***:..........................@@@@@=...........:@@@@@@@@@@@@@@@@@@@@#..:%@@@@@@@@@@@@@@@@@@@:....#@@@@@@@@@@@%...%@@@@@@@@@@@@@@@@@@@@..=@@@@#..................
//...***-:=**++.................:-.................-***+.:***:..........................@@@@@-.............:%@@@@@@@@@@@@@@@@@*.....#@@@@@@@@@@@@@@@:........*@@@@@@@@@#.....%@@@@@@@@@@@@@@@@@%..=@@@@*..................
//...=****=:....................:-....................:=****+.............................................................................................................................................................
//.....:+****+-.................:=.................:+****+:...............................................................................................................................................................
//........:=****+-..............-=..............:+****+:..................................................................................................................................................................
//............-*****+:.........:==-..........-*****=......................................................................................................................................................................
//...............:+****+:.....-=====.....:=****+-.........................................................................................................................................................................
//...................=*****=:.:====-..:+****+:............................................................................................................................................................................
//......................-+****=:...-+****=:...............................................................................................................................................................................
//.........................:+********+-..........................................................................Tester Present Specialist Automotive Solutions...........................................................
//............................:=+++:......................................................................................................................................................................................
//...................................................... .................................................................................................................................................................
/*
 * Tester Engineering Suite Source Code
 * ------------------------------------------------------------
 * FILE PURPOSE
 * ------------------------------------------------------------
 * This file forms part of the proprietary Tester Engineering Suite
 * software developed by Tester Present Specialist Automotive Solutions.
 * ------------------------------------------------------------
 * COPYRIGHT & OWNERSHIP
 * ------------------------------------------------------------
 * Copyright (c) 2026 Jack Leighton
 * Tester Present Specialist Automotive Solutions
 *
 * This file and its contents are proprietary and confidential.
 * All intellectual property rights in the original code, architecture,
 * implementation, modifications, and associated documentation are
 * reserved by the copyright holder.
 * ------------------------------------------------------------
 * PROPRIETARY LICENSE
 * ------------------------------------------------------------
 * This software is licensed, not sold.
 *
 * No permission is granted to any person or entity to copy, reproduce,
 * modify, adapt, translate, publish, distribute, sublicense, disclose,
 * reverse engineer, decompile, or create derivative works from this
 * file, in whole or in part, except where expressly authorised in
 * writing by the copyright holder or permitted by applicable law.
 *
 * Access to, possession of, or use of this file does not grant any
 * ownership interest or intellectual property rights in the software.
 *
 * Use, installation, and distribution of this software are subject
 * to the applicable Tester Engineering Suite EULA.
 * ------------------------------------------------------------
 * CONFIDENTIALITY NOTICE
 * ------------------------------------------------------------
 * This file may contain commercially sensitive implementation details,
 * proprietary algorithms, internal interfaces, security mechanisms,
 * and trade secrets belonging to Tester Present Specialist
 * Automotive Solutions.
 *
 * Unauthorised access, disclosure, copying, or distribution is
 * prohibited to the extent permitted by applicable law.
 * ------------------------------------------------------------
 * PRODUCT IDENTIFICATION
 * ------------------------------------------------------------
 * Product:       Tester Engineering Suite (TES)
 * Developer:     Tester Present Specialist Automotive Solutions
 * Jurisdiction:  Australia
 * ------------------------------------------------------------
 */
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//  Tester Present Specialist Automotive Solutions — Calibration Workbench
//
//  Surface3DControl.cs — a live, rotatable 3-D surface plot of the selected map, rendered
//  in pure GDI+ (no external 3-D dependency).  Each cell becomes a shaded quad coloured by
//  height with the shared thermal palette and lit by a fixed directional light; quads are
//  drawn far-to-near (painter's algorithm) so the surface reads correctly from any angle.
//  Left-drag orbits, the wheel zooms, right-drag pans, and the view refreshes the instant a
//  value is edited in the grid — so you watch the surface deform as you tune.  This is the
//  feature TunerPro's flat, clunky 3-D never delivered.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace TesterPresent.OBD2.Calibration
{
    public sealed class Surface3DControl : Control
    {
        private CalProject _proj;
        private CalBinary  _bin;
        private CalTable   _tbl;
        private double[]   _x = { 0 }, _y = { 0 };
        private double[,]  _z = new double[1, 1];
        private double _zmin, _zmax;
        private int _rows = 1, _cols = 1;

        private double _az = 0.78, _el = 0.62, _zoom = 1.0;
        private double _heightScale = 0.55;
        private PointF _pan = PointF.Empty;
        private Point  _lastMouse;
        private bool   _orbit, _panning;
        private bool   _wire = true;

        private static readonly double[] Light = Norm(new[] { 0.40, -0.55, 0.73 });

        public bool ShowWireframe { get => _wire; set { _wire = value; Invalidate(); } }

        public Surface3DControl()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            BackColor = Color.FromArgb(14, 17, 24);
        }

        public void Bind(CalProject proj, CalBinary bin, CalTable tbl)
        {
            _proj = proj; _bin = bin; _tbl = tbl;
            Reload();
        }

        public void Reload()
        {
            if (_proj == null || _bin == null || _tbl == null) { _z = new double[1, 1]; _rows = _cols = 1; Invalidate(); return; }
            _cols = Math.Min(Math.Max(1, _tbl.Columns), 4096);   // cap corrupt dims (OOM in Enumerable.Range)
            _rows = Math.Min(Math.Max(1, _tbl.Rows), 4096);
            _x = _tbl.XAxis != null ? _bin.ReadAxis(_tbl.XAxis, _proj) : Enumerable.Range(0, _cols).Select(i => (double)i).ToArray();
            _y = _tbl.YAxis != null ? _bin.ReadAxis(_tbl.YAxis, _proj) : Enumerable.Range(0, _rows).Select(i => (double)i).ToArray();
            _z = _bin.ReadTablePhys(_tbl, _proj);
            // Keep _rows/_cols within the actual _z array so the paint loop's _z[zr,zc] can't go OOB
            // (ReadTablePhys caps its dims, so a declared metadata size can exceed the data array).
            if (_z != null) { _rows = Math.Min(_rows, _z.GetLength(0)); _cols = Math.Min(_cols, _z.GetLength(1)); }
            double mn = double.PositiveInfinity, mx = double.NegativeInfinity;
            foreach (var v in _z) { if (double.IsNaN(v) || double.IsInfinity(v)) continue; mn = Math.Min(mn, v); mx = Math.Max(mx, v); }
            if (double.IsInfinity(mn)) { mn = 0; mx = 1; }
            if (Math.Abs(mx - mn) < 1e-12) mx = mn + 1;
            _zmin = mn; _zmax = mx;
            Invalidate();
        }

        public void ResetView() { _az = 0.78; _el = 0.62; _zoom = 1.0; _pan = PointF.Empty; Invalidate(); }

        // ── 3-D projection ──────────────────────────────────────────────────────────
        private PointF Project(double gx, double gy, double gz, out double depth, PointF center, double scale)
        {
            // rotate the ground plane by azimuth, then tilt by elevation; height = gz (up)
            double ca = Math.Cos(_az), sa = Math.Sin(_az), ce = Math.Cos(_el), se = Math.Sin(_el);
            double x1 = gx * ca - gy * sa;
            double y1 = gx * sa + gy * ca;
            double sx = x1;
            double sy = y1 * se - gz * ce;       // higher gz → up (negative screen Y)
            depth = y1 * ce + gz * se;            // bigger = farther from camera
            return Safe(center.X + sx * scale + _pan.X, center.Y + sy * scale + _pan.Y);
        }

        // Keep projected coordinates finite and within GDI+'s drawable range so FillPolygon /
        // DrawPolygon can never throw OverflowException on a NaN / Infinity / extreme value.
        private static PointF Safe(double x, double y)
        {
            const double LIM = 1e6;
            if (double.IsNaN(x) || double.IsInfinity(x)) x = 0;
            if (double.IsNaN(y) || double.IsInfinity(y)) y = 0;
            return new PointF((float)Math.Max(-LIM, Math.Min(LIM, x)), (float)Math.Max(-LIM, Math.Min(LIM, y)));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            // A LinearGradientBrush over a zero/degenerate rectangle throws OutOfMemoryException.
            if (ClientRectangle.Width < 2 || ClientRectangle.Height < 2) return;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (var bg = new LinearGradientBrush(ClientRectangle, Color.FromArgb(18, 22, 32), Color.FromArgb(10, 12, 18), 90f))
                g.FillRectangle(bg, ClientRectangle);

            if (_z == null || _rows < 1 || _cols < 1 || (_rows == 1 && _cols == 1))
            {
                using (var ef = new Font("Segoe UI", 9f))
                    TextRenderer.DrawText(g, _tbl == null ? "Select a 2-D / curve table to view in 3-D"
                                                           : "Scalar / 1-cell table — no surface",
                        ef, ClientRectangle, Color.FromArgb(110, 122, 140),
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                DrawTitleOverlay(g);
                return;
            }

            var center = new PointF(Width / 2f, Height / 2f + Height * 0.10f);
            // auto-scale to fit
            double baseScale = Math.Min(Width, Height) * 0.62 * _zoom;

            int R = Math.Max(2, _rows), C = Math.Max(2, _cols);
            // when a curve (1 row) build a thin ribbon so it still renders as a surface
            bool ribbon = _rows == 1;
            int RR = ribbon ? 2 : R;

            var pts = new PointF[RR, C];
            var dep = new double[RR, C];
            for (int r = 0; r < RR; r++)
                for (int c = 0; c < C; c++)
                {
                    double gx = C > 1 ? (c / (double)(C - 1) - 0.5) : 0;
                    double gy = RR > 1 ? (r / (double)(RR - 1) - 0.5) : 0;
                    // clamp into the real array — the render grid (RR×C) is widened to a
                    // minimum of 2 so 1×N / N×1 tables still draw as a ribbon surface, but
                    // _z only has _rows×_cols cells.
                    int zr = ribbon ? 0 : Math.Min(r, _rows - 1);
                    int zc = Math.Min(c, _cols - 1);
                    double zval = _z[zr, zc];
                    double gz = ((zval - _zmin) / (_zmax - _zmin) - 0.5) * _heightScale;
                    // A NaN cell (or a flat _zmax==_zmin range) yields a non-finite height; drop it to
                    // the mid-plane so it draws as a flat patch instead of a NaN/Infinity coordinate.
                    if (double.IsNaN(gz) || double.IsInfinity(gz)) gz = 0.0;
                    pts[r, c] = Project(gx, gy, gz, out double d, center, baseScale);
                    dep[r, c] = d;
                }

            DrawFloor(g, center, baseScale);

            // build quads, sort far→near
            var quads = new System.Collections.Generic.List<(double depth, int r, int c)>((RR - 1) * (C - 1));
            for (int r = 0; r < RR - 1; r++)
                for (int c = 0; c < C - 1; c++)
                    quads.Add(((dep[r, c] + dep[r + 1, c] + dep[r, c + 1] + dep[r + 1, c + 1]) / 4.0, r, c));
            quads.Sort((a, b) => b.depth.CompareTo(a.depth));   // farthest first

            using (var wirePen = new Pen(Color.FromArgb(70, 235, 240, 255), 1f))
            {
                foreach (var q in quads)
                {
                    int r = q.r, c = q.c;
                    double zr = ribbon ? _z[0, Math.Min(c, _cols - 1)] : _z[Math.Min(r, _rows - 1), Math.Min(c, _cols - 1)];
                    double t = (zr - _zmin) / (_zmax - _zmin);
                    Color baseCol = CalHeatmap.Color01(Math.Max(0, Math.Min(1, t)));

                    // surface normal (model space) for directional shading
                    double shade = QuadShade(ribbon, r, c, C, RR);
                    Color fill = CalHeatmap.Shade(baseCol, shade);

                    var poly = new[] { pts[r, c], pts[r, c + 1], pts[r + 1, c + 1], pts[r + 1, c] };
                    using (var b = new SolidBrush(Color.FromArgb(235, fill)))
                        g.FillPolygon(b, poly);
                    if (_wire) g.DrawPolygon(wirePen, poly);
                }
            }

            DrawColorBar(g);
            DrawTitleOverlay(g);
            DrawAxisHint(g);
        }

        private double QuadShade(bool ribbon, int r, int c, int C, int RR)
        {
            // approximate the cell normal from neighbouring heights in normalised space
            double hxScale = C > 1 ? 1.0 / (C - 1) : 1, hyScale = RR > 1 ? 1.0 / (RR - 1) : 1;
            double zL = ZAt(ribbon, r, Math.Max(0, c - 1));
            double zR = ZAt(ribbon, r, Math.Min(C - 1, c + 1));
            double zU = ZAt(ribbon, Math.Max(0, r - 1), c);
            double zD = ZAt(ribbon, Math.Min(RR - 1, r + 1), c);
            double dzdx = (zR - zL) / (2 * hxScale) * _heightScale / Math.Max(1e-9, (_zmax - _zmin));
            double dzdy = (zD - zU) / (2 * hyScale) * _heightScale / Math.Max(1e-9, (_zmax - _zmin));
            double[] n = Norm(new[] { -dzdx, -dzdy, 1.0 });
            double dot = n[0] * Light[0] + n[1] * Light[1] + n[2] * Light[2];
            double shade = 0.62 + 0.48 * Math.Max(0, dot);
            // A NaN cell (zL/zR/zU/zD == NaN) propagates through to a NaN shade — fall back to a
            // neutral, unshaded factor so the surface still renders instead of throwing.
            return double.IsNaN(shade) ? 1.0 : shade;
        }

        private double ZAt(bool ribbon, int r, int c)
        {
            int rr = ribbon ? 0 : Math.Max(0, Math.Min(_rows - 1, r));
            int cc = Math.Max(0, Math.Min(_cols - 1, c));
            return _z[rr, cc];
        }

        private void DrawFloor(Graphics g, PointF center, double scale)
        {
            using (var pen = new Pen(Color.FromArgb(40, 120, 150, 200), 1f))
            {
                int n = 6;
                for (int i = 0; i <= n; i++)
                {
                    double a = i / (double)n - 0.5;
                    var p1 = Project(a, -0.5, -_heightScale / 2, out _, center, scale);
                    var p2 = Project(a, 0.5, -_heightScale / 2, out _, center, scale);
                    var p3 = Project(-0.5, a, -_heightScale / 2, out _, center, scale);
                    var p4 = Project(0.5, a, -_heightScale / 2, out _, center, scale);
                    g.DrawLine(pen, p1, p2);
                    g.DrawLine(pen, p3, p4);
                }
            }
        }

        private void DrawColorBar(Graphics g)
        {
            int bx = Width - 26, by = 40, bw = 12, bh = Math.Min(180, Height - 90);
            for (int i = 0; i < bh; i++)
            {
                double t = 1.0 - i / (double)bh;
                using (var p = new Pen(CalHeatmap.Color01(t)))
                    g.DrawLine(p, bx, by + i, bx + bw, by + i);
            }
            using (var pen = new Pen(Color.FromArgb(80, 90, 110)))
                g.DrawRectangle(pen, bx, by, bw, bh);
            string u = string.IsNullOrEmpty(_tbl?.Units) ? "" : " " + _tbl.Units;
            using (var f = new Font("Consolas", 7.5f))   // was leaked on every surface repaint
            {
                TextRenderer.DrawText(g, _zmax.ToString("0.##", CultureInfo.InvariantCulture) + u, f,
                    new Point(bx - 60, by - 2), Color.FromArgb(200, 210, 225));
                TextRenderer.DrawText(g, _zmin.ToString("0.##", CultureInfo.InvariantCulture) + u, f,
                    new Point(bx - 60, by + bh - 10), Color.FromArgb(200, 210, 225));
            }
        }

        private void DrawTitleOverlay(Graphics g)
        {
            if (_tbl == null) return;
            using (var f = new Font("Segoe UI", 8.5f, FontStyle.Bold))
                TextRenderer.DrawText(g, _tbl.Title, f, new Point(10, 8), Color.FromArgb(150, 200, 255));
            using (var f = new Font("Consolas", 7.5f))
                TextRenderer.DrawText(g, $"{_cols}×{_rows}  @0x{_tbl.Address:X}  {_tbl.DataType}", f,
                    new Point(10, 24), Color.FromArgb(120, 135, 160));
        }

        private void DrawAxisHint(Graphics g)
        {
            using (var f = new Font("Segoe UI", 7.5f))
                TextRenderer.DrawText(g, "drag = orbit   wheel = zoom   right-drag = pan", f,
                    new Rectangle(0, Height - 18, Width, 16), Color.FromArgb(90, 100, 120),
                    TextFormatFlags.HorizontalCenter);
        }

        // ── interaction ─────────────────────────────────────────────────────────────
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            _lastMouse = e.Location;
            if (e.Button == MouseButtons.Left) _orbit = true;
            else if (e.Button == MouseButtons.Right) _panning = true;
            Focus();
        }
        protected override void OnMouseUp(MouseEventArgs e) { base.OnMouseUp(e); _orbit = _panning = false; }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            int dx = e.X - _lastMouse.X, dy = e.Y - _lastMouse.Y;
            if (_orbit)
            {
                _az += dx * 0.012;
                _el += dy * 0.010;
                _el = Math.Max(0.05, Math.Min(1.45, _el));
                Invalidate();
            }
            else if (_panning) { _pan = new PointF(_pan.X + dx, _pan.Y + dy); Invalidate(); }
            _lastMouse = e.Location;
        }
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);
            _zoom *= e.Delta > 0 ? 1.1 : 0.9;
            _zoom = Math.Max(0.25, Math.Min(6.0, _zoom));
            Invalidate();
        }
        protected override void OnMouseDoubleClick(MouseEventArgs e) { base.OnMouseDoubleClick(e); ResetView(); }

        private static double[] Norm(double[] v)
        {
            double m = Math.Sqrt(v[0] * v[0] + v[1] * v[1] + v[2] * v[2]);
            if (m < 1e-12) return new[] { 0.0, 0.0, 1.0 };
            return new[] { v[0] / m, v[1] / m, v[2] / m };
        }
    }
}
