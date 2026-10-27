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
//  Tester Present Specialist Automotive Solutions — Finding Card
//
//  A scannable, custom-drawn row for one diagnostic finding: a severity colour
//  stripe down the left edge, the module id chip, the hypothesis title, a
//  confidence bar, and an ADVISORY badge when the result rests on unvalidated
//  calibration or thin data.  State reads at a glance — the whole point of an
//  information-dense workbench a mechanic operates rather than reads.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TesterPresent.OBD2.Intelligence.UI
{
    /// <summary>Custom-drawn selectable card for a single <see cref="DiagnosticResult"/>.</summary>
    public sealed class FindingCard : Control
    {
        private bool _selected;

        public DiagnosticResult Result { get; }

        public bool Selected
        {
            get => _selected;
            set { if (_selected != value) { _selected = value; Invalidate(); } }
        }

        public FindingCard(DiagnosticResult result)
        {
            Result = result;
            Height = 68;
            Margin = new Padding(0, 0, 0, 6);
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var rc = ClientRectangle;

            Color sev = SeverityColor(Result?.Severity ?? DiagnosticSeverity.Info);

            // Card background + selection highlight.
            using (var bg = new SolidBrush(_selected ? Lighten(DiTheme.BG_PANEL2, -6) : DiTheme.BG_PANEL2))
                g.FillRectangle(bg, rc);
            using (var border = new Pen(_selected ? sev : DiTheme.BORDER, _selected ? 2f : 1f))
                g.DrawRectangle(border, rc.X, rc.Y, rc.Width - 1, rc.Height - 1);

            // Severity stripe.
            using (var stripe = new SolidBrush(sev))
                g.FillRectangle(stripe, rc.X + 1, rc.Y + 1, 5, rc.Height - 2);

            int x = rc.X + 14;
            int top = rc.Y + 8;

            // Module chip. NOTE: AdvDiagTheme fonts are SHARED static instances —
            // never wrap them in `using` or they get disposed for every other dialog.
            string mod = Result?.ModuleId ?? "?";
            var chipFont = DiTheme.MonoBold;
            using (var chipBrush = new SolidBrush(sev))
            {
                var sz = g.MeasureString(mod, chipFont);
                var chipRect = new RectangleF(x, top, sz.Width + 12, 18);
                using (var path = Rounded(chipRect, 4))
                using (var faint = new SolidBrush(Color.FromArgb(28, sev)))
                    g.FillPath(faint, path);
                g.DrawString(mod, chipFont, chipBrush, x + 6, top + 1);
                x += (int)chipRect.Width + 10;
            }

            // Confidence % (right-aligned) + band.
            string conf = (Result?.ConfidencePercent ?? 0) + "%";
            var confFont = DiTheme.UiBold;
            {
                var csz = g.MeasureString(conf, confFont);
                using (var cb = new SolidBrush(sev))
                    g.DrawString(conf, confFont, cb, rc.Right - csz.Width - 12, top);
            }

            // Title (hypothesis) — single line, ellipsized.  Its width stops short
            // of the reserved right column (confidence % above, ADVISORY below) so
            // the two never overlap.
            const int rightCol = 96;
            string title = Result?.Hypothesis ?? Result?.Title ?? "";
            var titleFont = DiTheme.UiFont;
            using (var tb = new SolidBrush(DiTheme.FG_PRIMARY))
            {
                var titleRect = new RectangleF(rc.X + 14, top + 22, Math.Max(20, rc.Width - 28 - rightCol), 20);
                using (var sf = new StringFormat { Trimming = StringTrimming.EllipsisCharacter, FormatFlags = StringFormatFlags.NoWrap, LineAlignment = StringAlignment.Center })
                    g.DrawString(title, titleFont, tb, titleRect, sf);
            }

            // Confidence bar along the bottom.
            int barY = rc.Bottom - 12;
            int barX = rc.X + 14;
            int barW = rc.Width - 28;
            using (var track = new SolidBrush(DiTheme.GRID_LINE))
                g.FillRectangle(track, barX, barY, barW, 4);
            double c = Math.Max(0, Math.Min(1, Result?.Confidence ?? 0));
            using (var fill = new SolidBrush(sev))
                g.FillRectangle(fill, barX, barY, (int)(barW * c), 4);

            // Advisory badge (top-right, under the confidence).
            if (Result != null && Result.Advisory)
            {
                var badgeFont = DiTheme.Tag;
                using (var bb = new SolidBrush(DiTheme.ACCENT_AMB))
                {
                    string txt = "ADVISORY";
                    var bsz = g.MeasureString(txt, badgeFont);
                    g.DrawString(txt, badgeFont, bb, rc.Right - bsz.Width - 12, top + 20);
                }
            }
        }

        private static GraphicsPath Rounded(RectangleF r, float radius)
        {
            var path = new GraphicsPath();
            float d = radius * 2;
            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        internal static Color SeverityColor(DiagnosticSeverity sev)
        {
            switch (sev)
            {
                case DiagnosticSeverity.Critical:
                case DiagnosticSeverity.High: return DiTheme.ACCENT_RED;
                case DiagnosticSeverity.Medium: return DiTheme.ACCENT_AMB;
                case DiagnosticSeverity.Low: return DiTheme.ACCENT_BLUE;
                default: return DiTheme.FG_DIM;
            }
        }

        private static Color Lighten(Color c, int delta)
        {
            int R = Math.Max(0, Math.Min(255, c.R + delta));
            int G = Math.Max(0, Math.Min(255, c.G + delta));
            int B = Math.Max(0, Math.Min(255, c.B + delta));
            return Color.FromArgb(c.A, R, G, B);
        }
    }
}
