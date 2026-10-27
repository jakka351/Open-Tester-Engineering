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
//  CalChecksumDialog.cs — configure and apply firmware checksums.  Each row is a protected
//  region (algorithm + data span + where the checksum word is stored + endianness); the
//  dialog verifies every region against the live image and can correct them in place.  A
//  modified image MUST have valid checksums before it is flashed, so this is the gate that
//  turns a bench edit into a flash-ready file.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace TesterPresent.OBD2.Calibration
{
    public sealed class CalChecksumDialog : Form
    {
        private readonly CalBinary _bin;
        private readonly ChecksumProfile _profile;
        private readonly DataGridView _grid;

        private static readonly Color Bg = Color.FromArgb(18, 22, 30);
        private static readonly Color Bar = Color.FromArgb(24, 30, 42);
        private static readonly Color Txt = Color.FromArgb(220, 228, 240);

        public CalChecksumDialog(CalBinary bin, ChecksumProfile profile)
        {
            _bin = bin; _profile = profile;
            Text = "Checksum Configuration";
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(820, 360);
            BackColor = Bg;
            MinimizeBox = false; MaximizeBox = false; ShowInTaskbar = false;

            var info = new Label
            {
                Dock = DockStyle.Top, Height = 38, ForeColor = Color.FromArgb(160, 175, 200),
                Font = new Font("Segoe UI", 8.25f), Padding = new Padding(8, 6, 8, 0),
                Text = $"Image: {_bin.Length:N0} bytes.  Define one row per protected region.  All offsets/lengths are HEX.\n" +
                       "Data = the bytes covered; Store = where the checksum word lives; the data span may exclude the store word."
            };

            _grid = new DataGridView
            {
                Dock = DockStyle.Fill, BackgroundColor = Bg, BorderStyle = BorderStyle.None,
                AllowUserToAddRows = true, AllowUserToResizeRows = false, RowHeadersVisible = false,
                EnableHeadersVisualStyles = false, GridColor = Color.FromArgb(45, 52, 66),
                Font = new Font("Consolas", 8.75f), AllowUserToDeleteRows = true,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing,
                ColumnHeadersHeight = 26
            };
            _grid.ColumnHeadersDefaultCellStyle.BackColor = Bar;
            _grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(150, 200, 255);
            _grid.DefaultCellStyle.BackColor = Color.FromArgb(22, 27, 37);
            _grid.DefaultCellStyle.ForeColor = Txt;
            _grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(40, 60, 100);

            _grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Name", Name = "name", Width = 130 });
            var algo = new DataGridViewComboBoxColumn { HeaderText = "Algorithm", Name = "algo", Width = 110, FlatStyle = FlatStyle.Flat };
            algo.Items.AddRange(Enum.GetNames(typeof(ChecksumAlgo)));
            _grid.Columns.Add(algo);
            _grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Data start", Name = "ds", Width = 90 });
            _grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Data len", Name = "dl", Width = 90 });
            _grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Store off", Name = "so", Width = 90 });
            var end = new DataGridViewComboBoxColumn { HeaderText = "Endian", Name = "end", Width = 70, FlatStyle = FlatStyle.Flat };
            end.Items.AddRange("Little", "Big");
            _grid.Columns.Add(end);
            _grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Computed", Name = "comp", Width = 90, ReadOnly = true });
            _grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Stored", Name = "stor", Width = 90, ReadOnly = true });
            _grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Status", Name = "stat", Width = 70, ReadOnly = true });

            foreach (var r in _profile.Regions) AddRow(r);

            var bar = new Panel { Dock = DockStyle.Bottom, Height = 42, BackColor = Bar };
            int x = 8;
            Btn(bar, "Verify", ref x, Color.FromArgb(40, 55, 80), (s, e) => Verify());
            Btn(bar, "Correct All", ref x, Color.FromArgb(110, 70, 40), (s, e) => { CommitToProfile(); foreach (var r in _profile.Regions) CalChecksum.Correct(_bin.Data, r); Verify(); });
            Btn(bar, "Preset: CRC32 (file − last 4)", ref x, Color.FromArgb(40, 60, 100), (s, e) => Preset(), 200);
            var close = new Button { Text = "Close", DialogResult = DialogResult.OK, FlatStyle = FlatStyle.Flat, BackColor = Color.FromArgb(40, 55, 80), ForeColor = Color.White, Size = new Size(70, 26), Location = new Point(ClientSize.Width - 80, 8), Anchor = AnchorStyles.Right | AnchorStyles.Top };
            close.Click += (s, e) => CommitToProfile();
            bar.Controls.Add(close);

            Controls.Add(_grid);
            Controls.Add(bar);
            Controls.Add(info);
            Verify();
        }

        private void Btn(Panel host, string text, ref int x, Color back, EventHandler click, int w = 0)
        {
            int width = w > 0 ? w : 90;
            var b = new Button { Text = text, Location = new Point(x, 8), Size = new Size(width, 26), FlatStyle = FlatStyle.Flat, BackColor = back, ForeColor = Color.White, Font = new Font("Segoe UI", 8.25f) };
            b.Click += click; host.Controls.Add(b); x += width + 6;
        }

        private void AddRow(ChecksumRegion r)
        {
            int i = _grid.Rows.Add();
            var row = _grid.Rows[i];
            row.Cells["name"].Value = r.Name;
            row.Cells["algo"].Value = r.Algo.ToString();
            row.Cells["ds"].Value = r.DataStart.ToString("X");
            row.Cells["dl"].Value = r.DataLength.ToString("X");
            row.Cells["so"].Value = r.StoreOffset.ToString("X");
            row.Cells["end"].Value = r.Endian.ToString();
        }

        private void Preset()
        {
            var r = new ChecksumRegion
            {
                Name = "Whole file CRC32", Algo = ChecksumAlgo.Crc32, Endian = CalEndian.Little,
                DataStart = 0, DataLength = Math.Max(0, _bin.Length - 4), StoreOffset = Math.Max(0, _bin.Length - 4)
            };
            AddRow(r);
            Verify();
        }

        private void CommitToProfile()
        {
            _profile.Regions.Clear();
            foreach (DataGridViewRow row in _grid.Rows)
            {
                if (row.IsNewRow) continue;
                var r = ReadRow(row);
                if (r != null) _profile.Regions.Add(r);
            }
            _profile.Name = _profile.Regions.Count > 0 ? "Custom" : "(none)";
        }

        private ChecksumRegion ReadRow(DataGridViewRow row)
        {
            try
            {
                string nm = row.Cells["name"].Value?.ToString() ?? "Region";
                if (!Enum.TryParse(row.Cells["algo"].Value?.ToString() ?? "Crc32", out ChecksumAlgo algo)) algo = ChecksumAlgo.Crc32;
                long ds = Hex(row.Cells["ds"].Value), dl = Hex(row.Cells["dl"].Value), so = Hex(row.Cells["so"].Value);
                var end = (row.Cells["end"].Value?.ToString() ?? "Little") == "Big" ? CalEndian.Big : CalEndian.Little;
                if (dl <= 0) return null;
                return new ChecksumRegion { Name = nm, Algo = algo, DataStart = ds, DataLength = dl, StoreOffset = so, Endian = end };
            }
            catch { return null; }
        }

        private void Verify()
        {
            foreach (DataGridViewRow row in _grid.Rows)
            {
                if (row.IsNewRow) continue;
                var r = ReadRow(row);
                if (r == null) { row.Cells["stat"].Value = ""; continue; }
                var st = CalChecksum.Verify(_bin.Data, r);
                row.Cells["comp"].Value = st.Computed.ToString("X");
                row.Cells["stor"].Value = st.Stored.ToString("X");
                row.Cells["stat"].Value = st.Ok ? "OK" : "MISMATCH";
                row.Cells["stat"].Style.ForeColor = st.Ok ? Color.FromArgb(110, 210, 140) : Color.FromArgb(240, 120, 110);
            }
        }

        private static long Hex(object cell)
        {
            string s = (cell?.ToString() ?? "0").Trim();
            if (s.Length == 0) return 0;
            if (s.StartsWith("0x", StringComparison.OrdinalIgnoreCase)) s = s.Substring(2);
            return long.TryParse(s, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var v) ? v : 0;
        }
    }
}
