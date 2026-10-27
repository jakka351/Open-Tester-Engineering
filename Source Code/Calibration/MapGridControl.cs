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
//  MapGridControl.cs — the colour-coded, directly-editable table grid.  A DataGridView with
//  per-cell thermal shading (so a map's shape reads at a glance), X-axis values in the
//  column headers and Y-axis values in the row headers, live change-highlighting against
//  the original image, and a full set of professional multi-cell operations: set, add,
//  scale-by-percent, multiply, horizontal / vertical / block interpolation, smoothing, and
//  TSV copy / paste.  Every edit is funnelled straight back into the binary through
//  CalBinary so the bytes and the view never drift apart.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TesterPresent.OBD2.Calibration
{
    public sealed class MapGridControl : DataGridView
    {
        private CalProject _proj;
        private CalBinary  _bin;
        private CalTable   _tbl;
        private double[]   _xAxis = { 0 };
        private double[]   _yAxis = { 0 };
        private double[,]  _phys  = new double[1, 1];
        private int _rows = 1, _cols = 1;
        private double _dataMin, _dataMax;
        private CalBinary _cmp;          // optional second image for side-by-side compare
        private double[,] _cmpPhys;      // its physical values for the bound table

        public event Action ValuesChanged;
        /// <summary>Raised once, immediately BEFORE a mutating operation writes to the binary,
        /// so a listener (the editor's undo stack) can snapshot the pre-edit image.</summary>
        public event Action BeforeEdit;
        private void RaiseBeforeEdit() => BeforeEdit?.Invoke();
        public CalTable Table => _tbl;

        /// <summary>Overlay a second image so cells whose value differs are flagged.</summary>
        public void SetCompare(CalBinary other)
        {
            _cmp = other;
            _cmpPhys = (other != null && _tbl != null && _proj != null) ? other.ReadTablePhys(_tbl, _proj) : null;
            Invalidate();
        }

        /// <summary>How many cells differ from the compare image (0 if none set).</summary>
        public int DiffCount()
        {
            if (_cmpPhys == null || _phys == null) return 0;
            int n = 0, rr = Math.Min(_rows, _cmpPhys.GetLength(0)), cc = Math.Min(_cols, _cmpPhys.GetLength(1));
            for (int r = 0; r < rr; r++)
                for (int c = 0; c < cc; c++)
                    if (Math.Abs(_phys[r, c] - _cmpPhys[r, c]) > 1e-9) n++;
            return n;
        }

        public MapGridControl()
        {
            DoubleBuffered = true;
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            AllowUserToResizeRows = false;
            RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            RowHeadersWidth = 66;
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ColumnHeadersHeight = 26;
            SelectionMode = DataGridViewSelectionMode.CellSelect;
            MultiSelect = true;
            EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            BorderStyle = BorderStyle.None;
            CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            BackgroundColor = Color.FromArgb(18, 22, 30);
            GridColor = Color.FromArgb(40, 46, 58);
            EnableHeadersVisualStyles = false;
            ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 32, 44);
            ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(150, 200, 255);
            ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 8.25f, FontStyle.Bold);
            ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 32, 44);
            RowHeadersDefaultCellStyle.ForeColor = Color.FromArgb(150, 200, 255);
            RowHeadersDefaultCellStyle.Font = new Font("Consolas", 8.25f, FontStyle.Bold);
            RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DefaultCellStyle.Font = new Font("Consolas", 8.75f);
            DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255);
            DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            CellPainting += OnCellPainting;
            CellEndEdit  += OnCellEndEdit;
            KeyDown      += OnKeyDown;
        }

        // ── binding ─────────────────────────────────────────────────────────────────
        public void Bind(CalProject proj, CalBinary bin, CalTable tbl)
        {
            _proj = proj; _bin = bin; _tbl = tbl;
            if (proj == null || bin == null || tbl == null) { Clear(); return; }

            _cols = Math.Max(1, tbl.Columns);
            _rows = Math.Max(1, tbl.Rows);
            _xAxis = tbl.XAxis != null ? bin.ReadAxis(tbl.XAxis, proj) : Enumerable.Range(0, _cols).Select(i => (double)i).ToArray();
            _yAxis = tbl.YAxis != null ? bin.ReadAxis(tbl.YAxis, proj) : Enumerable.Range(0, _rows).Select(i => (double)i).ToArray();
            _phys = bin.ReadTablePhys(tbl, proj);
            // The declared table size (tbl.Rows×Columns) can exceed what the binary actually provides;
            // never present a grid cell that _phys doesn't have, or every _phys[r,c] read (painting,
            // stats, CSV export) would throw IndexOutOfRange.
            if (_phys != null) { _rows = Math.Min(_rows, _phys.GetLength(0)); _cols = Math.Min(_cols, _phys.GetLength(1)); }
            _cmpPhys = _cmp != null ? _cmp.ReadTablePhys(tbl, proj) : null;
            ComputeDataRange();
            Rebuild();
        }

        public void Reload()
        {
            if (_proj == null || _bin == null || _tbl == null) return;
            _phys = _bin.ReadTablePhys(_tbl, _proj);
            if (_phys != null) { _rows = Math.Min(_rows, _phys.GetLength(0)); _cols = Math.Min(_cols, _phys.GetLength(1)); }
            if (_tbl.XAxis != null) _xAxis = _bin.ReadAxis(_tbl.XAxis, _proj);
            if (_tbl.YAxis != null) _yAxis = _bin.ReadAxis(_tbl.YAxis, _proj);
            ComputeDataRange();
            // A re-read can shrink the table; if the grid now has more rows/columns than _phys, a stale
            // cell's edit or paint would index _phys out of bounds — rebuild it to match the data.
            if (_phys != null && (Columns.Count > _phys.GetLength(1) || Rows.Count > _phys.GetLength(0) + 1))
                Rebuild();
            else
                RefreshAllCells();
        }

        private void Clear()
        {
            SuspendLayout();
            Rows.Clear(); Columns.Clear();
            ResumeLayout();
        }

        private void ComputeDataRange()
        {
            // Percentile-clipped range so a few sentinel / padding cells don't wash the whole
            // map into one colour; falls back to true min/max when clipping isn't meaningful.
            if (_phys == null || !CalHeatmap.RobustRange(_phys.Cast<double>(), out _dataMin, out _dataMax))
            {
                _dataMin = 0; _dataMax = 1;
            }
        }

        private void Rebuild()
        {
            SuspendLayout();
            Rows.Clear(); Columns.Clear();

            for (int c = 0; c < _cols; c++)
            {
                var col = new DataGridViewTextBoxColumn
                {
                    HeaderText = FmtAxis(_xAxis, c),
                    SortMode = DataGridViewColumnSortMode.NotSortable,
                    Width = 60, MinimumWidth = 38, Resizable = DataGridViewTriState.True
                };
                Columns.Add(col);
            }
            Rows.Add(_rows);
            for (int r = 0; r < _rows; r++)
            {
                Rows[r].HeaderCell.Value = _rows > 1 ? FmtAxis(_yAxis, r) : "";
                for (int c = 0; c < _cols; c++)
                    Rows[r].Cells[c].Value = CellText(r, c);
            }
            RowHeadersVisible = _rows > 1 || (_tbl?.YAxis != null);

            // A lone scalar / flag (1×1) gets a comfortable, obviously-editable cell instead of a
            // 60×22 speck lost in the panel; its single column header carries no axis meaning so
            // it is hidden.  Curves / maps keep their axis headers.
            bool oneCell = _rows == 1 && _cols == 1;
            ColumnHeadersVisible = !oneCell;
            if (oneCell)
            {
                Columns[0].Width = 150;
                Rows[0].Height = 46;
            }
            ResumeLayout();
        }

        private string FmtAxis(double[] axis, int i)
            => i < axis.Length ? axis[i].ToString("0.##", CultureInfo.InvariantCulture) : i.ToString();

        private string CellText(int r, int c)
        {
            double v = _phys[r, c];
            return _tbl.Conversion.IsVerbal ? _tbl.Conversion.FormatValue(v)
                                            : v.ToString(_tbl.DisplayFormat ?? "0.###", CultureInfo.InvariantCulture);
        }

        // ── heatmap + change-marker painting ────────────────────────────────────────
        private void OnCellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;     // headers paint normally
            if (_bin == null || _proj == null || _tbl == null) return;
            if (e.RowIndex >= _rows || e.ColumnIndex >= _cols) return;

            double v = _phys[e.RowIndex, e.ColumnIndex];
            Color bg = CalHeatmap.ColorFor(v, _dataMin, _dataMax);
            bool selected = (e.State & DataGridViewElementStates.Selected) != 0;
            bool changed = _bin.CellChanged(_tbl, _proj, e.RowIndex, e.ColumnIndex);

            using (var b = new SolidBrush(bg))
                e.Graphics.FillRectangle(b, e.CellBounds);

            // change overlay — subtle white wash so edited cells stand out against the heat
            if (changed)
                using (var b = new SolidBrush(Color.FromArgb(70, 255, 255, 255)))
                    e.Graphics.FillRectangle(b, e.CellBounds);

            // selection — bright inset border
            if (selected)
                using (var p = new Pen(Color.White, 2))
                    e.Graphics.DrawRectangle(p, e.CellBounds.X + 1, e.CellBounds.Y + 1, e.CellBounds.Width - 2, e.CellBounds.Height - 2);

            var text = e.FormattedValue?.ToString() ?? "";
            TextRenderer.DrawText(e.Graphics, text, DefaultCellStyle.Font, e.CellBounds,
                CalHeatmap.TextOn(bg), TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

            if (changed)
                e.Graphics.FillPolygon(Brushes.OrangeRed, new[]
                {
                    new Point(e.CellBounds.Right - 8, e.CellBounds.Top),
                    new Point(e.CellBounds.Right,     e.CellBounds.Top),
                    new Point(e.CellBounds.Right,     e.CellBounds.Top + 8),
                });

            // compare-diff overlay — bottom-left cyan triangle when this cell differs from the
            // second image (distinct from the orange top-right "edited vs original" marker)
            if (_cmpPhys != null && e.RowIndex < _cmpPhys.GetLength(0) && e.ColumnIndex < _cmpPhys.GetLength(1)
                && Math.Abs(v - _cmpPhys[e.RowIndex, e.ColumnIndex]) > 1e-9)
            {
                using (var p = new Pen(Color.FromArgb(120, 90, 230, 255), 2))
                    e.Graphics.DrawRectangle(p, e.CellBounds.X + 1, e.CellBounds.Y + 1, e.CellBounds.Width - 3, e.CellBounds.Height - 3);
                e.Graphics.FillPolygon(Brushes.DeepSkyBlue, new[]
                {
                    new Point(e.CellBounds.Left,     e.CellBounds.Bottom),
                    new Point(e.CellBounds.Left,     e.CellBounds.Bottom - 8),
                    new Point(e.CellBounds.Left + 8, e.CellBounds.Bottom),
                });
            }

            e.Handled = true;
        }

        // ── editing ─────────────────────────────────────────────────────────────────
        private void OnCellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (_tbl == null || _bin == null || _proj == null) return;
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            string txt = Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? "";
            if (TryParseInput(txt, out double phys))
                CommitCell(e.RowIndex, e.ColumnIndex, phys);
            else
                Rows[e.RowIndex].Cells[e.ColumnIndex].Value = CellText(e.RowIndex, e.ColumnIndex); // revert
        }

        private bool TryParseInput(string txt, out double phys)
        {
            txt = (txt ?? "").Trim();
            if (double.TryParse(txt, NumberStyles.Any, CultureInfo.InvariantCulture, out phys)) return true;
            if (_tbl.Conversion.IsVerbal)
            {
                foreach (var kv in _tbl.Conversion.Labels)
                    if (string.Equals(kv.Value, txt, StringComparison.OrdinalIgnoreCase)) { phys = kv.Key; return true; }
            }
            phys = 0; return false;
        }

        private void CommitCell(int r, int c, double phys)
        {
            RaiseBeforeEdit();
            _bin.WriteCellPhys(_tbl, _proj, r, c, phys);
            _phys[r, c] = _bin.ReadCellPhys(_tbl, _proj, r, c);   // read-back so view == bytes exactly
            Rows[r].Cells[c].Value = CellText(r, c);
        }

        private void RefreshAllCells()
        {
            for (int r = 0; r < _rows; r++)
                for (int c = 0; c < _cols; c++)
                    Rows[r].Cells[c].Value = CellText(r, c);
            Invalidate();
        }

        private void Refresh(IEnumerable<(int r, int c)> cells)
        {
            foreach (var (r, c) in cells)
            {
                _phys[r, c] = _bin.ReadCellPhys(_tbl, _proj, r, c);
                Rows[r].Cells[c].Value = CellText(r, c);
            }
            ComputeDataRange();
            Invalidate();
            ValuesChanged?.Invoke();
        }

        private List<(int r, int c)> Selected()
        {
            // A cell must be in range of BOTH the grid (_rows/_cols, from the table metadata) AND the
            // physical-values array (_phys, from the actual binary read).  Those can diverge when a
            // declared table size exceeds what ReadTablePhys produced (short/malformed binary), and a
            // stale selection from a bigger table would otherwise index _phys out of bounds.
            var list = new List<(int, int)>();
            int rmax = Math.Min(_rows, _phys?.GetLength(0) ?? 0);
            int cmax = Math.Min(_cols, _phys?.GetLength(1) ?? 0);
            foreach (DataGridViewCell cell in SelectedCells)
                if (cell.RowIndex >= 0 && cell.ColumnIndex >= 0 && cell.RowIndex < rmax && cell.ColumnIndex < cmax)
                    list.Add((cell.RowIndex, cell.ColumnIndex));
            if (list.Count == 0 && CurrentCell != null
                && CurrentCell.RowIndex >= 0 && CurrentCell.RowIndex < rmax
                && CurrentCell.ColumnIndex >= 0 && CurrentCell.ColumnIndex < cmax)
                list.Add((CurrentCell.RowIndex, CurrentCell.ColumnIndex));
            return list;
        }

        // ── professional multi-cell operations ──────────────────────────────────────
        public void SetSelection(double v)        => Apply(_ => v);
        public void AddSelection(double d)        => Apply(cur => cur + d);
        public void MultiplySelection(double f)   => Apply(cur => cur * f);
        public void ScaleSelectionPct(double pct) => Apply(cur => cur * (1.0 + pct / 100.0));

        private void Apply(Func<double, double> op)
        {
            var sel = Selected();
            if (sel.Count > 0) RaiseBeforeEdit();
            foreach (var (r, c) in sel)
                _bin.WriteCellPhys(_tbl, _proj, r, c, op(_phys[r, c]));
            RefreshSel(sel);
        }

        public void InterpolateHorizontal()
        {
            var sel = Selected();
            if (sel.Count > 0) RaiseBeforeEdit();
            foreach (var grp in sel.GroupBy(s => s.r))
            {
                var cols = grp.Select(s => s.c).OrderBy(c => c).ToList();
                if (cols.Count < 3) continue;
                int r = grp.Key, c0 = cols.First(), c1 = cols.Last();
                double v0 = _phys[r, c0], v1 = _phys[r, c1];
                for (int c = c0 + 1; c < c1; c++)
                    if (cols.Contains(c))
                        _bin.WriteCellPhys(_tbl, _proj, r, c, v0 + (v1 - v0) * (c - c0) / (double)(c1 - c0));
            }
            RefreshSel(sel);
        }

        public void InterpolateVertical()
        {
            var sel = Selected();
            if (sel.Count > 0) RaiseBeforeEdit();
            foreach (var grp in sel.GroupBy(s => s.c))
            {
                var rows = grp.Select(s => s.r).OrderBy(r => r).ToList();
                if (rows.Count < 3) continue;
                int c = grp.Key, r0 = rows.First(), r1 = rows.Last();
                double v0 = _phys[r0, c], v1 = _phys[r1, c];
                for (int r = r0 + 1; r < r1; r++)
                    if (rows.Contains(r))
                        _bin.WriteCellPhys(_tbl, _proj, r, c, v0 + (v1 - v0) * (r - r0) / (double)(r1 - r0));
            }
            RefreshSel(sel);
        }

        /// <summary>Bilinear interpolation across the bounding box of the selection (the four corners drive it).</summary>
        public void InterpolateBlock()
        {
            var sel = Selected();
            if (sel.Count < 4) { InterpolateHorizontal(); return; }
            int r0 = sel.Min(s => s.r), r1 = sel.Max(s => s.r);
            int c0 = sel.Min(s => s.c), c1 = sel.Max(s => s.c);
            if (r1 == r0 || c1 == c0) { InterpolateHorizontal(); InterpolateVertical(); return; }
            RaiseBeforeEdit();
            double q11 = _phys[r0, c0], q12 = _phys[r0, c1], q21 = _phys[r1, c0], q22 = _phys[r1, c1];
            for (int r = r0; r <= r1; r++)
                for (int c = c0; c <= c1; c++)
                {
                    double fr = (r - r0) / (double)(r1 - r0), fc = (c - c0) / (double)(c1 - c0);
                    double top = q11 + (q12 - q11) * fc, bot = q21 + (q22 - q21) * fc;
                    _bin.WriteCellPhys(_tbl, _proj, r, c, top + (bot - top) * fr);
                }
            RefreshSel(sel);
        }

        /// <summary>3×3 (or 3-tap) neighbourhood average over the selection — knocks the spikes off a map.</summary>
        public void SmoothSelection()
        {
            var sel = Selected();
            if (sel.Count > 0) RaiseBeforeEdit();
            var set = new HashSet<(int, int)>(sel);
            var updates = new List<(int r, int c, double v)>();
            foreach (var (r, c) in sel)
            {
                double sum = 0; int n = 0;
                for (int dr = -1; dr <= 1; dr++)
                    for (int dc = -1; dc <= 1; dc++)
                    {
                        int rr = r + dr, cc = c + dc;
                        if (rr < 0 || cc < 0 || rr >= _rows || cc >= _cols) continue;
                        double w = (dr == 0 && dc == 0) ? 2.0 : 1.0;   // centre-weighted
                        sum += _phys[rr, cc] * w; n += (int)w;
                    }
                if (n > 0) updates.Add((r, c, sum / n));
            }
            foreach (var u in updates) _bin.WriteCellPhys(_tbl, _proj, u.r, u.c, u.v);
            RefreshSel(sel);
        }

        public void CopySelection()
        {
            var sel = Selected();
            if (sel.Count == 0) return;
            int r0 = sel.Min(s => s.r), r1 = sel.Max(s => s.r);
            int c0 = sel.Min(s => s.c), c1 = sel.Max(s => s.c);
            var sb = new StringBuilder();
            for (int r = r0; r <= r1; r++)
            {
                for (int c = c0; c <= c1; c++)
                {
                    if (c > c0) sb.Append('\t');
                    sb.Append(_phys[r, c].ToString("0.######", CultureInfo.InvariantCulture));
                }
                sb.Append("\r\n");
            }
            try { Clipboard.SetText(sb.ToString()); } catch { }
        }

        public void PasteSelection()
        {
            string text;
            try { text = Clipboard.GetText(); } catch { return; }
            if (string.IsNullOrEmpty(text) || CurrentCell == null) return;
            RaiseBeforeEdit();
            int baseR = CurrentCell.RowIndex, baseC = CurrentCell.ColumnIndex;
            var lines = text.Replace("\r\n", "\n").Replace('\r', '\n').Split('\n');
            var touched = new List<(int, int)>();
            for (int i = 0; i < lines.Length; i++)
            {
                if (string.IsNullOrEmpty(lines[i])) continue;
                var parts = lines[i].Split('\t');
                for (int j = 0; j < parts.Length; j++)
                {
                    int r = baseR + i, c = baseC + j;
                    // CurrentCell can be -1 (row/column-header focus) → baseR/baseC -1; without the
                    // lower bound a (-1,c) would be recorded in `touched` and crash Refresh's _phys[-1,c].
                    if (r < 0 || c < 0 || r >= _rows || c >= _cols) continue;
                    if (double.TryParse(parts[j].Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out double v))
                    { _bin.WriteCellPhys(_tbl, _proj, r, c, v); touched.Add((r, c)); }
                }
            }
            RefreshSel(touched);
        }

        private void RefreshSel(List<(int r, int c)> sel) => Refresh(sel);

        public (int count, double min, double max, double avg) SelectionStats()
        {
            var sel = Selected();
            if (sel.Count == 0 || _phys == null) return (0, 0, 0, 0);
            double mn = double.PositiveInfinity, mx = double.NegativeInfinity, sum = 0; int n = 0;
            foreach (var (r, c) in sel)
            {
                double v = _phys[r, c];
                if (double.IsNaN(v) || double.IsInfinity(v)) continue;   // skip no-data cells, like AllStats()
                mn = Math.Min(mn, v); mx = Math.Max(mx, v); sum += v; n++;
            }
            return n == 0 ? (0, 0, 0, 0) : (n, mn, mx, sum / n);
        }

        /// <summary>min / max / average over every (finite) cell in the table.</summary>
        public (int count, double min, double max, double avg) AllStats()
        {
            if (_phys == null) return (0, 0, 0, 0);
            int n = 0; double mn = double.PositiveInfinity, mx = double.NegativeInfinity, sum = 0;
            foreach (var v in _phys)
            {
                if (double.IsNaN(v) || double.IsInfinity(v)) continue;
                n++; if (v < mn) mn = v; if (v > mx) mx = v; sum += v;
            }
            return n == 0 ? (0, 0, 0, 0) : (n, mn, mx, sum / n);
        }

        /// <summary>Comma-separated dump of the bound table (X axis header row, Y axis first column).</summary>
        public string ToCsv()
        {
            if (_phys == null) return "";
            var sb = new StringBuilder();
            sb.Append("Y\\X");
            for (int c = 0; c < _cols; c++) sb.Append(',').Append(FmtAxis(_xAxis, c));
            sb.AppendLine();
            for (int r = 0; r < _rows; r++)
            {
                sb.Append(_rows > 1 ? FmtAxis(_yAxis, r) : "value");
                for (int c = 0; c < _cols; c++) sb.Append(',').Append(_phys[r, c].ToString("0.######", CultureInfo.InvariantCulture));
                sb.AppendLine();
            }
            return sb.ToString();
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C) { CopySelection(); e.Handled = true; }
            else if (e.Control && e.KeyCode == Keys.V) { PasteSelection(); e.Handled = true; }
            else if (!IsCurrentCellInEditMode && (e.KeyCode == Keys.Oemplus || e.KeyCode == Keys.Add))   { AddSelection(+StepFor()); e.Handled = true; }
            else if (!IsCurrentCellInEditMode && (e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract)) { AddSelection(-StepFor()); e.Handled = true; }
        }

        // A sensible nudge step: one display-format least-significant digit, default 1.
        private double StepFor()
        {
            string fmt = _tbl?.DisplayFormat ?? "0.###";
            int dot = fmt.IndexOf('.');
            int decimals = dot >= 0 ? fmt.Length - dot - 1 : 0;
            return decimals <= 0 ? 1.0 : Math.Pow(10, -Math.Min(decimals, 3));
        }
    }
}
