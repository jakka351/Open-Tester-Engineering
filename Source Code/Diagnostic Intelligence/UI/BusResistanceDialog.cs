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
//  Tester Present Specialist Automotive Solutions — Bus Resistance Entry (multimeter @ the DLC)
//
//  CAN termination is one of the few PHYSICAL facts a technician can measure in
//  seconds with nothing but a multimeter at the OBD-II (J1962) socket:
//
//      HS-CAN:  pin 6 (CAN-H)  <->  pin 14 (CAN-L)     — every OBD-II car
//      MS-CAN:  pin 3 (MS-H)   <->  pin 11 (MS-L)      — Ford pinout, where fitted
//
//  A healthy dual-terminated bus reads ~60 Ohm (two 120 Ohm terminators in
//  parallel); ~120 Ohm means one terminator or its branch is lost; near 0 is a
//  shorted pair; OL/open means no termination is visible at the DLC at all.  This
//  dialog shows the connector diagram, walks the key-OFF procedure, classifies the
//  reading live, and hands the measurement back to the Intelligence snapshot so M3
//  folds real physics into its shared-bus localization.
//
//  HONESTY RULE: an IN-RANGE (~60 Ohm) reading is recorded as evidence but does NOT
//  soften M3's verdict — correct DC termination cannot rule out a jammed/babbling
//  node or a powered-down segment.  Only an ABNORMAL reading moves confidence.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;

namespace TesterPresent.OBD2.Intelligence.UI
{
    /// <summary>Classifies a measured CAN-pair resistance against the expected termination.</summary>
    public static class BusResistance
    {
        /// <summary>Sentinel for an "OL" / over-limit (open) multimeter reading.</summary>
        public const double OPEN_OHMS = 1e6;

        /// <summary>
        /// Classify a measured CAN-H↔CAN-L resistance.  An in-range reading returns
        /// State=Unknown deliberately: termination-OK is real evidence (rendered as a PASS
        /// measure step) but must not soften a shared-bus verdict — a jammed or babbling
        /// bus reads a perfect ~60 Ohm.  Only abnormal readings return Degraded/Dead.
        /// </summary>
        public static Classification Classify(double ohms, int expectedTerminators = 2)
        {
            if (double.IsNaN(ohms) || ohms < 0)
                return new Classification(BusHealthState.Unknown, "unreadable measurement", null, false);

            // Nominal parallel resistance: 2 terminators -> 60, 1 -> 120.
            double nominal = expectedTerminators >= 2 ? 60.0 : (expectedTerminators == 1 ? 120.0 : 60.0);

            if (ohms >= OPEN_OHMS * 0.5)
                return new Classification(BusHealthState.Dead,
                    "OL (open) — no termination visible at the DLC: a broken backbone or both terminators lost",
                    "open backbone / lost termination", false);

            if (ohms < 20)
                return new Classification(BusHealthState.Dead,
                    Fmt(ohms) + " Ohm — CAN pair shorted (CAN-H to CAN-L, or a wire shorted to power/ground)",
                    "short across the CAN pair", false);

            // In-range (~nominal +/-25%): termination OK.  State=Unknown => evidence only, no softening.
            if (ohms >= nominal * 0.75 && ohms <= nominal * 1.25)
                return new Classification(BusHealthState.Unknown,
                    Fmt(ohms) + " Ohm — termination normal (~" + Fmt(nominal) + " Ohm); the DC path is good",
                    null, true);

            // ~2x nominal => one terminator/branch open (e.g. ~120 Ohm on a 60 Ohm bus).
            double single = nominal * 2.0;
            if (ohms >= single * 0.80 && ohms <= single * 1.30)
                return new Classification(BusHealthState.Degraded,
                    Fmt(ohms) + " Ohm — about " + Fmt(single) + " Ohm: one terminator or its branch is open",
                    "one terminator / branch lost", false);

            if (ohms < nominal * 0.75)
                return new Classification(BusHealthState.Degraded,
                    Fmt(ohms) + " Ohm — below the ~" + Fmt(nominal) + " Ohm nominal: a partial short or an extra parallel path",
                    "partial short / extra load", false);

            return new Classification(BusHealthState.Degraded,
                Fmt(ohms) + " Ohm — well off the ~" + Fmt(nominal) + " Ohm nominal: high resistance or missing termination",
                "high resistance / missing termination", false);
        }

        internal static string Fmt(double v)
            => v >= OPEN_OHMS * 0.5 ? "OL" : v.ToString(v >= 100 ? "0" : "0.#", CultureInfo.InvariantCulture);

        /// <summary>The outcome of classifying a bus-resistance reading.</summary>
        public sealed class Classification
        {
            public BusHealthState State { get; }
            public string Verdict { get; }
            public string FaultMode { get; }
            /// <summary>True when the reading sits in the healthy band — recorded, but not confidence-moving.</summary>
            public bool InRange { get; }
            public Classification(BusHealthState state, string verdict, string faultMode, bool inRange)
            { State = state; Verdict = verdict; FaultMode = faultMode; InRange = inRange; }
        }
    }

    /// <summary>
    /// Technician-facing DLC resistance-measurement dialog: a J1962 connector diagram with
    /// the CAN pair highlighted, the key-OFF procedure, live classification, and a bus-health
    /// record handed back for M3.  Themed to the Diagnostic Intelligence carbon palette.
    /// </summary>
    public sealed class BusResistanceDialog : Form
    {
        /// <summary>One selectable bus and its J1962 pin pair.</summary>
        private sealed class BusPins
        {
            public VehicleBus Bus;
            public int PinH, PinL;
            public string Label;
            public BusPins(VehicleBus bus, int h, int l, string label) { Bus = bus; PinH = h; PinL = l; Label = label; }
        }

        private static readonly BusPins Hs = new BusPins(VehicleBus.HsCan, 6, 14, "HS-CAN (500 kbps) — every OBD-II vehicle");
        private static readonly BusPins Ms = new BusPins(VehicleBus.MsCan, 3, 11, "MS-CAN (125 kbps) — Ford pinout, where fitted");

        private BusPins _sel = Hs;
        private RadioButton _rbHs, _rbMs;
        private Panel _diagram;
        private NumericUpDown _nudOhms;
        private CheckBox _chkOpen;
        private Label _lblClass;
        private Button _btnApply, _btnCancel;

        /// <summary>The bus-health record(s) the technician confirmed (empty if cancelled).</summary>
        public List<BusHealth> Results { get; } = new List<BusHealth>();

        public BusResistanceDialog(bool showMsCan)
        {
            Text = "CAN Bus Resistance — DLC Measurement";
            ClientSize = new Size(760, 560);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false; MinimizeBox = false;
            DiTheme.ApplyChrome(this);
            BuildUi(showMsCan);
            Reclassify();
        }

        private void BuildUi(bool showMsCan)
        {
            var root = DiTheme.MakeRoot(64);
            root.Controls.Add(DiTheme.MakeBanner(
                "CAN Bus Resistance",
                "Measure termination at the OBD-II socket with a multimeter — key OFF",
                out _), 0, 0);

            var body = new TableLayoutPanel
            {
                Dock = DockStyle.Fill, ColumnCount = 2, RowCount = 2, BackColor = DiTheme.BG_DARK, Padding = new Padding(12),
            };
            body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55));
            body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45));
            body.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            body.RowStyles.Add(new RowStyle(SizeType.Absolute, 52));
            root.Controls.Add(body, 0, 1);

            // ── left: diagram ──
            _diagram = new Panel { Dock = DockStyle.Fill, BackColor = DiTheme.BG_PANEL, Margin = new Padding(0, 0, 8, 0) };
            _diagram.Paint += DrawConnector;
            body.Controls.Add(_diagram, 0, 0);

            // ── right: controls ──
            var right = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 5, BackColor = DiTheme.BG_PANEL, Padding = new Padding(10) };
            right.RowStyles.Add(new RowStyle(SizeType.Absolute, 58));  // bus radios
            right.RowStyles.Add(new RowStyle(SizeType.Absolute, 148)); // procedure
            right.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));  // ohms entry
            right.RowStyles.Add(new RowStyle(SizeType.Absolute, 28));  // OL check
            right.RowStyles.Add(new RowStyle(SizeType.Percent, 100));  // classification
            body.Controls.Add(right, 1, 0);

            // bus selector
            var busRow = new FlowLayoutPanel { Dock = DockStyle.Fill, FlowDirection = FlowDirection.TopDown, WrapContents = false, BackColor = DiTheme.BG_PANEL };
            _rbHs = new RadioButton { Text = "HS-CAN  (pins 6 / 14)", AutoSize = true, Checked = true, ForeColor = DiTheme.FG_PRIMARY, Font = DiTheme.UiBold };
            _rbMs = new RadioButton { Text = "MS-CAN  (pins 3 / 11)", AutoSize = true, ForeColor = DiTheme.FG_PRIMARY, Font = DiTheme.UiBold, Enabled = showMsCan };
            _rbHs.CheckedChanged += (s, e) => { if (_rbHs.Checked) { _sel = Hs; _diagram.Invalidate(); Reclassify(); } };
            _rbMs.CheckedChanged += (s, e) => { if (_rbMs.Checked) { _sel = Ms; _diagram.Invalidate(); Reclassify(); } };
            busRow.Controls.Add(_rbHs);
            busRow.Controls.Add(_rbMs);
            right.Controls.Add(busRow, 0, 0);

            var proc = new Label
            {
                Dock = DockStyle.Fill, BorderStyle = BorderStyle.FixedSingle, TextAlign = ContentAlignment.TopLeft,
                BackColor = DiTheme.BG_DETAIL, ForeColor = DiTheme.FG_SECOND, Font = DiTheme.UiSmall,
                Padding = new Padding(8, 6, 6, 6),
                Text =
                    "1.  Ignition OFF, key removed. Wait ~30 s for the modules to sleep.\n" +
                    "2.  Set the multimeter to Ohms (200 range).\n" +
                    "3.  Probe the two highlighted DLC pins (CAN-H and CAN-L).\n" +
                    "4.  Do NOT measure with the key on — you read bus impedance, not\n" +
                    "     the terminators, and risk false numbers.\n\n" +
                    "Expect ~60 Ohm (two 120 Ohm terminators in parallel).\n" +
                    "~120 Ohm = one terminator/branch lost.  ~0 = short.  OL = open.",
            };
            right.Controls.Add(proc, 0, 1);

            var entry = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 3, RowCount = 1, BackColor = DiTheme.BG_PANEL };
            entry.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96));
            entry.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110));
            entry.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            entry.Controls.Add(new Label { Text = "Reading (Ohm)", Dock = DockStyle.Fill, ForeColor = DiTheme.FG_SECOND, Font = DiTheme.UiFont, TextAlign = ContentAlignment.MiddleLeft }, 0, 0);
            _nudOhms = new NumericUpDown
            {
                Dock = DockStyle.Fill, Minimum = 0, Maximum = 100000, DecimalPlaces = 1, Increment = 1,
                Value = 60, BackColor = DiTheme.BG_INPUT, ForeColor = DiTheme.FG_PRIMARY, BorderStyle = BorderStyle.FixedSingle, Font = DiTheme.Mono,
            };
            _nudOhms.ValueChanged += (s, e) => Reclassify();
            entry.Controls.Add(_nudOhms, 1, 0);
            right.Controls.Add(entry, 0, 2);

            _chkOpen = new CheckBox { Text = "OL / open (no reading — infinite)", AutoSize = true, ForeColor = DiTheme.ACCENT_AMB };
            _chkOpen.CheckedChanged += (s, e) => { _nudOhms.Enabled = !_chkOpen.Checked; Reclassify(); };
            right.Controls.Add(_chkOpen, 0, 3);

            _lblClass = new Label
            {
                Dock = DockStyle.Fill, Font = DiTheme.UiBold, ForeColor = DiTheme.FG_PRIMARY,
                TextAlign = ContentAlignment.TopLeft, Padding = new Padding(2, 8, 2, 2),
            };
            right.Controls.Add(_lblClass, 0, 4);

            // ── buttons ──
            var btns = new FlowLayoutPanel { Dock = DockStyle.Fill, FlowDirection = FlowDirection.RightToLeft, BackColor = DiTheme.BG_DARK };
            _btnApply = new Button { Text = "Apply & re-analyze", AutoSize = true, Font = DiTheme.UiBold, FlatStyle = FlatStyle.Flat, BackColor = DiTheme.ACCENT_TEAL, ForeColor = Color.White, Padding = new Padding(10, 4, 10, 4) };
            _btnApply.Click += (s, e) => ApplyAndClose();
            _btnCancel = new Button { Text = "Cancel", AutoSize = true, FlatStyle = FlatStyle.Flat, Padding = new Padding(10, 4, 10, 4) };
            _btnCancel.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
            btns.Controls.Add(_btnApply);
            btns.Controls.Add(_btnCancel);
            body.Controls.Add(btns, 1, 1);

            Controls.Add(root);
            AcceptButton = _btnApply;
            CancelButton = _btnCancel;
        }

        private double CurrentOhms => _chkOpen.Checked ? BusResistance.OPEN_OHMS : (double)_nudOhms.Value;

        private void Reclassify()
        {
            var c = BusResistance.Classify(CurrentOhms, 2);
            _lblClass.Text = _sel.Label + "\n\n" + (c.Verdict ?? "");
            _lblClass.ForeColor =
                c.InRange ? DiTheme.ACCENT_GRN :
                c.State == BusHealthState.Dead ? DiTheme.ACCENT_RED :
                c.State == BusHealthState.Degraded ? DiTheme.ACCENT_AMB : DiTheme.FG_PRIMARY;
        }

        private void ApplyAndClose()
        {
            var c = BusResistance.Classify(CurrentOhms, 2);
            Results.Clear();
            Results.Add(new BusHealth
            {
                Bus = _sel.Bus,
                ExpectedTerminators = 2,
                MeasuredResistanceOhms = CurrentOhms,
                State = c.State,
                Verdict = c.Verdict,
                ProbableFaultMode = c.FaultMode,
            });
            DialogResult = DialogResult.OK;
            Close();
        }

        // ── J1962 (OBD-II) 16-pin connector diagram ─────────────────────────────
        private void DrawConnector(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var rc = _diagram.ClientRectangle;
            using (var bg = new SolidBrush(DiTheme.BG_PANEL)) g.FillRectangle(bg, rc);

            using (var title = new SolidBrush(DiTheme.FG_PRIMARY))
                g.DrawString("OBD-II (J1962) connector — vehicle socket", DiTheme.UiSmallBold, title, 14, 12);

            // Connector body: a rounded trapezoid (wider along the top, like the real socket).
            int left = 40, right = rc.Width - 40, top = 56;
            int bodyH = 150;
            var body = new[]
            {
                new Point(left + 14, top),
                new Point(right - 14, top),
                new Point(right, top + bodyH),
                new Point(left, top + bodyH),
            };
            using (var fill = new SolidBrush(DiTheme.BG_INPUT)) g.FillPolygon(fill, body);
            using (var pen = new Pen(DiTheme.BORDER, 1.5f)) g.DrawPolygon(pen, body);

            // 16 pins: top row 1-8 (left->right), bottom row 9-16.
            int cols = 8;
            int gx = (right - left - 40) / (cols - 1);
            int x0 = left + 20;
            int yTop = top + 46, yBot = top + 104, r = 11;

            for (int i = 0; i < 16; i++)
            {
                int col = i % 8;
                int pin = i + 1;
                int px = x0 + col * gx;
                int py = i < 8 ? yTop : yBot;
                DrawPin(g, px, py, r, pin);
            }

            // Legend + measurement caption for the selected bus.
            int cy = top + bodyH + 34;
            using (var hbrush = new SolidBrush(DiTheme.ACCENT_GRN))
                g.FillEllipse(hbrush, 44, cy, 12, 12);
            using (var lbrush = new SolidBrush(DiTheme.ACCENT_BLUE))
                g.FillEllipse(lbrush, 44, cy + 22, 12, 12);
            using (var tb = new SolidBrush(DiTheme.FG_SECOND))
            {
                g.DrawString($"CAN-H  =  pin {_sel.PinH}", DiTheme.UiFont, tb, 64, cy - 2);
                g.DrawString($"CAN-L  =  pin {_sel.PinL}", DiTheme.UiFont, tb, 64, cy + 20);
            }
            using (var cap = new SolidBrush(DiTheme.ACCENT_TEAL))
                g.DrawString($"Measure Ohm across pin {_sel.PinH} and pin {_sel.PinL} — key OFF.",
                             DiTheme.UiBold, cap, 44, cy + 52);
        }

        private void DrawPin(Graphics g, int cx, int cy, int r, int pin)
        {
            bool isH = pin == _sel.PinH, isL = pin == _sel.PinL;
            var rect = new Rectangle(cx - r, cy - r, r * 2, r * 2);

            if (isH || isL)
            {
                using (var ring = new Pen(isH ? DiTheme.ACCENT_GRN : DiTheme.ACCENT_BLUE, 3f))
                    g.DrawEllipse(ring, cx - r - 3, cy - r - 3, (r + 3) * 2, (r + 3) * 2);
            }

            using (var fill = new SolidBrush(isH ? DiTheme.ACCENT_GRN : isL ? DiTheme.ACCENT_BLUE : DiTheme.BG_PANEL2))
                g.FillEllipse(fill, rect);
            using (var pen = new Pen(DiTheme.BORDER, 1f))
                g.DrawEllipse(pen, rect);

            using (var tb = new SolidBrush(isH || isL ? Color.Black : DiTheme.FG_DIM))
            {
                var sz = g.MeasureString(pin.ToString(), DiTheme.MonoSmall);
                g.DrawString(pin.ToString(), DiTheme.MonoSmall, tb, cx - sz.Width / 2, cy - sz.Height / 2);
            }
        }
    }
}
