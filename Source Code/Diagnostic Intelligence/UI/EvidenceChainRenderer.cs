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
//  Tester Present Specialist Automotive Solutions — Evidence Chain Renderer (UI primitive)
//
//  A custom-drawn WinForms control that renders an EvidenceChain (Primitive P3)
//  as a vertical timeline.  Each reasoning step is a coloured status dot on a
//  left rail — green PASS, red FAIL, amber INCONCLUSIVE, blue info — followed by
//  'Signal = Observed (expected Expected)' and an optional wrapped detail line.
//
//  Reusable across every module result panel so a technician always sees the
//  same honest walkthrough of WHY a module reached its hypothesis.  Theme comes
//  from the shared AdvDiagTheme (internal static, same assembly) so the control
//  matches the rest of the Advanced Diagnostics chrome.  Never throws from paint;
//  a null chain renders a quiet 'No evidence' placeholder.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TesterPresent.OBD2.Intelligence.UI
{
    /// <summary>
    /// Renders an <see cref="EvidenceChain"/> as a vertical PASS/FAIL/INCONCLUSIVE/info
    /// timeline.  Plain custom-drawn <see cref="Control"/> — no Designer file, double
    /// buffered.  Host code sets <see cref="Chain"/> and (optionally) <see cref="HeaderText"/>,
    /// then sizes the control using <see cref="PreferredHeight"/>.
    /// </summary>
    public sealed class EvidenceChainRenderer : Control
    {
        // ── Layout constants (tightened for a denser, cleaner timeline) ─────
        private const int PadLeft     = 10;   // left margin before the rail
        private const int PadRight    = 10;   // right margin
        private const int PadTop      = 6;    // top margin
        private const int PadBottom   = 6;    // bottom margin
        private const int RailX       = 18;   // x of the vertical rail / dot centres
        private const int DotRadius    = 5;   // status dot radius
        private const int TextX       = 38;   // x where step text begins
        private const int RowHeight   = 32;   // base height of a step row (no detail)
        private const int DetailExtra = 15;   // extra height added when a step has a detail line
        private const int HeaderHeight = 22;  // caption band height when HeaderText is set

        private EvidenceChain _chain;
        private string _headerText;

        /// <summary>Creates an empty renderer.  Assign <see cref="Chain"/> to populate it.</summary>
        public EvidenceChainRenderer()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer
                   | ControlStyles.AllPaintingInWmPaint
                   | ControlStyles.UserPaint
                   | ControlStyles.ResizeRedraw, true);
            DoubleBuffered = true;
            BackColor = DiTheme.BG_PANEL;
            ForeColor = DiTheme.FG_PRIMARY;
            Font = DiTheme.UiFont;
        }

        /// <summary>
        /// The evidence chain to render.  Setting it invalidates the control and
        /// recomputes the preferred height for host layout.  May be null.
        /// </summary>
        public EvidenceChain Chain
        {
            get => _chain;
            set
            {
                _chain = value;
                // A larger/smaller chain changes the height a host wants to give us.
                if (AutoSize) { try { Height = PreferredHeight; } catch { } }
                Invalidate();
            }
        }

        /// <summary>Optional caption drawn bold above the chain.  Null/empty hides the band.</summary>
        public string HeaderText
        {
            get => _headerText;
            set { _headerText = value; Invalidate(); }
        }

        /// <summary>
        /// Height (px) this control wants given the current chain — header band +
        /// per-step rows (taller when a step carries a detail line) + padding.
        /// Hosts use this to lay the control out in a stacked results panel.
        /// </summary>
        public int PreferredHeight
        {
            get
            {
                int h = PadTop + PadBottom;
                if (!string.IsNullOrEmpty(_headerText)) h += HeaderHeight;
                if (_chain == null || _chain.Count == 0)
                {
                    h += RowHeight; // room for the placeholder line
                    return h;
                }
                foreach (var step in _chain.Steps)
                {
                    h += RowHeight;
                    if (step != null && !string.IsNullOrEmpty(step.Detail)) h += DetailExtra;
                }
                return h;
            }
        }

        /// <inheritdoc/>
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            try
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                // Background.
                using (var bg = new SolidBrush(DiTheme.BG_PANEL))
                    g.FillRectangle(bg, ClientRectangle);

                int y = PadTop;
                int contentRight = Width - PadRight;

                // Optional header caption.
                if (!string.IsNullOrEmpty(_headerText))
                {
                    using (var hb = new SolidBrush(DiTheme.FG_PRIMARY))
                        g.DrawString(_headerText, DiTheme.UiBold, hb, new PointF(PadLeft, y + 3));
                    using (var p = new Pen(DiTheme.GRID_LINE, 1))
                        g.DrawLine(p, PadLeft, y + HeaderHeight - 4, contentRight, y + HeaderHeight - 4);
                    y += HeaderHeight;
                }

                // Empty / null chain → quiet placeholder, no rail.
                if (_chain == null || _chain.Count == 0)
                {
                    using (var db = new SolidBrush(DiTheme.FG_DIM))
                        g.DrawString("No evidence", DiTheme.UiFont, db, new PointF(TextX, y + 10));
                    return;
                }

                // Measure the rail extent so it connects the first and last dots.
                int firstDotY = y + RowHeight / 2;
                int lastDotY = firstDotY;
                int probeY = y;
                foreach (var step in _chain.Steps)
                {
                    lastDotY = probeY + RowHeight / 2;
                    probeY += RowHeight;
                    if (step != null && !string.IsNullOrEmpty(step.Detail)) probeY += DetailExtra;
                }

                // Left rail line connecting the dots.
                using (var rail = new Pen(DiTheme.GRID_LINE, 2))
                    g.DrawLine(rail, RailX, firstDotY, RailX, lastDotY);

                // Draw each step.
                var steps = _chain.Steps;
                for (int i = 0; i < steps.Count; i++)
                {
                    var step = steps[i];
                    if (step == null) { y += RowHeight; continue; }

                    bool hasDetail = !string.IsNullOrEmpty(step.Detail);
                    int rowH = RowHeight + (hasDetail ? DetailExtra : 0);
                    int dotY = y + RowHeight / 2;

                    DrawStatusDot(g, RailX, dotY, step.Verdict);

                    // Primary line: "Signal = Observed (expected Expected)".
                    string primary = BuildPrimaryLine(step);
                    Color primaryColor = VerdictColor(step.Verdict);
                    using (var pb = new SolidBrush(primaryColor))
                        g.DrawString(primary, DiTheme.UiFont, pb,
                            new RectangleF(TextX, y + 4, Math.Max(10, contentRight - TextX - 44), 18));

                    // Verdict glyph tag on the right edge (PASS/FAIL/----/info).
                    string glyph = step.VerdictGlyph;
                    if (!string.IsNullOrEmpty(glyph))
                    {
                        SizeF gs = g.MeasureString(glyph, DiTheme.UiSmall);
                        float gx = contentRight - gs.Width;
                        if (gx > TextX + 40)
                        {
                            using (var gb = new SolidBrush(primaryColor))
                                g.DrawString(glyph, DiTheme.UiSmall, gb, new PointF(gx, y + 5));
                        }
                    }

                    // Optional wrapped detail line.
                    if (hasDetail)
                    {
                        using (var db = new SolidBrush(DiTheme.FG_SECOND))
                        using (var sf = new StringFormat { Trimming = StringTrimming.EllipsisWord })
                            g.DrawString(step.Detail, DiTheme.UiSmall, db,
                                new RectangleF(TextX, y + RowHeight - 6,
                                               Math.Max(10, contentRight - TextX), DetailExtra + 4), sf);
                    }

                    y += rowH;
                }
            }
            catch (Exception ex)
            {
                // Never let a paint failure crash the host dialog.
                System.Diagnostics.Debug.WriteLine("[EvidenceChainRenderer.OnPaint] " + ex.Message);
            }
        }

        /// <summary>Builds the 'Signal = Observed (expected Expected)' primary text for a step.</summary>
        private static string BuildPrimaryLine(EvidenceStep step)
        {
            string sig = step.Signal ?? "";
            string obs = step.Observed ?? "";
            string exp = step.Expected ?? "";
            if (obs.Length == 0) return sig;
            string line = sig + " = " + obs;
            if (exp.Length > 0) line += " (expected " + exp + ")";
            return line;
        }

        /// <summary>Maps a verdict to its theme accent colour.</summary>
        private static Color VerdictColor(EvidenceVerdict verdict)
        {
            switch (verdict)
            {
                case EvidenceVerdict.Pass:         return DiTheme.ACCENT_GRN;
                case EvidenceVerdict.Fail:         return DiTheme.ACCENT_RED;
                case EvidenceVerdict.Inconclusive: return DiTheme.ACCENT_AMB;
                default:                           return DiTheme.ACCENT_BLUE; // Info
            }
        }

        /// <summary>Draws a filled status dot with a thin border at (cx, cy).</summary>
        private static void DrawStatusDot(Graphics g, int cx, int cy, EvidenceVerdict verdict)
        {
            var r = new Rectangle(cx - DotRadius, cy - DotRadius, DotRadius * 2, DotRadius * 2);
            Color fill = VerdictColor(verdict);
            using (var b = new SolidBrush(fill)) g.FillEllipse(b, r);
            using (var p = new Pen(Color.FromArgb(60, 0, 0, 0), 1)) g.DrawEllipse(p, r);
        }

        /// <inheritdoc/>
        protected override void Dispose(bool disposing)
        {
            // Fonts/colours belong to AdvDiagTheme; nothing owned here to release.
            base.Dispose(disposing);
        }
    }
}
