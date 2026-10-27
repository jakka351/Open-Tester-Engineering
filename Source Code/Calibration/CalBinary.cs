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
//  CalBinary.cs — the firmware image and the typed read/write engine.
//
//  Holds the bytes, a pristine ORIGINAL snapshot (for change-highlighting / revert /
//  checksum baselining) and decodes/encodes table + axis cells through their CalDataType,
//  endianness and CalConversion.  Every value the operator sees comes from here; every
//  edit goes back through here, clamped to the storage type's representable range so a
//  bad edit can never write out-of-range bytes.  Layout is contiguous row-major
//  (z[r,c] at base + (r·Cols + c)·elemSize) which is the convention emitted by A2L
//  FNC_VALUES (ROW_DIR) and TunerPro EMBEDDEDDATA with a single-element major stride.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;

namespace TesterPresent.OBD2.Calibration
{
    public sealed class CalBinary
    {
        public byte[] Data     { get; private set; }
        public byte[] Original { get; private set; }
        public string FilePath { get; set; } = "";
        public bool   Dirty    { get; private set; }

        public int Length => Data?.Length ?? 0;

        public CalBinary(byte[] data, string path = "")
        {
            Data     = data ?? Array.Empty<byte>();
            Original = (byte[])Data.Clone();
            FilePath = path ?? "";
        }

        public void MarkSaved()
        {
            Original = (byte[])Data.Clone();
            Dirty = false;
        }

        public void RevertAll()
        {
            Data = (byte[])Original.Clone();
            Dirty = false;
        }

        /// <summary>
        /// Replace the working bytes with an undo snapshot (a previously-captured copy of Data).
        /// Leaves Original untouched and recomputes Dirty, so undoing all the way back to the
        /// original image clears the "modified" state exactly like RevertAll would.
        /// </summary>
        public void LoadSnapshot(byte[] snapshot)
        {
            if (snapshot == null) return;
            Data = (byte[])snapshot.Clone();
            Dirty = !MatchesOriginal();
        }

        private bool MatchesOriginal()
        {
            if (Original == null || Data == null || Original.Length != Data.Length) return false;
            for (int i = 0; i < Data.Length; i++)
                if (Data[i] != Original[i]) return false;
            return true;
        }

        // ── raw storage range (for clamp + numeric-inverse bracketing) ──────────────
        public static void RawRange(CalDataType t, out double min, out double max)
        {
            switch (t)
            {
                case CalDataType.U8:  min = 0;            max = 255;            break;
                case CalDataType.S8:  min = -128;         max = 127;            break;
                case CalDataType.U16: min = 0;            max = 65535;          break;
                case CalDataType.S16: min = -32768;       max = 32767;          break;
                case CalDataType.U32: min = 0;            max = 4294967295;     break;
                case CalDataType.S32: min = -2147483648;  max = 2147483647;     break;
                case CalDataType.U64: min = 0;            max = 1.8446744073709552E19; break;
                case CalDataType.S64: min = -9.2233720368547758E18; max = 9.2233720368547758E18; break;
                case CalDataType.F32: min = -3.4e38;      max = 3.4e38;         break;
                case CalDataType.F64: min = double.MinValue; max = double.MaxValue; break;
                default:              min = 0;            max = 255;            break;
            }
        }

        public bool InBounds(long offset, int size)
            => offset >= 0 && size > 0 && offset + size <= Data.Length;

        // ── typed raw read ──────────────────────────────────────────────────────────
        public double ReadRaw(long off, CalDataType t, CalEndian e)
        {
            int size = CalDataTypeInfo.SizeBytes(t);
            if (!InBounds(off, size)) return 0;
            var buf = new byte[size];
            Array.Copy(Data, off, buf, 0, size);
            if (e == CalEndian.Big) Array.Reverse(buf);   // normalise to little-endian for BitConverter

            switch (t)
            {
                case CalDataType.U8:  return buf[0];
                case CalDataType.S8:  return (sbyte)buf[0];
                case CalDataType.U16: return BitConverter.ToUInt16(buf, 0);
                case CalDataType.S16: return BitConverter.ToInt16(buf, 0);
                case CalDataType.U32: return BitConverter.ToUInt32(buf, 0);
                case CalDataType.S32: return BitConverter.ToInt32(buf, 0);
                case CalDataType.U64: return BitConverter.ToUInt64(buf, 0);
                case CalDataType.S64: return BitConverter.ToInt64(buf, 0);
                case CalDataType.F32: return BitConverter.ToSingle(buf, 0);
                case CalDataType.F64: return BitConverter.ToDouble(buf, 0);
                default: return buf[0];
            }
        }

        // ── typed raw write (round + clamp to storage range) ───────────────────────
        public bool WriteRaw(long off, CalDataType t, CalEndian e, double rawValue)
        {
            int size = CalDataTypeInfo.SizeBytes(t);
            if (!InBounds(off, size)) return false;
            if (double.IsNaN(rawValue)) return false;   // a NaN (e.g. divide-by-zero scaling) must never become a written byte

            RawRange(t, out double lo, out double hi);
            if (!CalDataTypeInfo.IsFloat(t))
            {
                rawValue = Math.Round(rawValue, MidpointRounding.AwayFromZero);
                if (rawValue < lo) rawValue = lo;
                if (rawValue > hi) rawValue = hi;
            }

            byte[] buf;
            switch (t)
            {
                case CalDataType.U8:  buf = new[] { (byte)(uint)rawValue }; break;
                case CalDataType.S8:  buf = new[] { (byte)(sbyte)rawValue }; break;
                case CalDataType.U16: buf = BitConverter.GetBytes((ushort)(uint)rawValue); break;
                case CalDataType.S16: buf = BitConverter.GetBytes((short)(int)rawValue); break;
                case CalDataType.U32: buf = BitConverter.GetBytes((uint)rawValue); break;
                case CalDataType.S32: buf = BitConverter.GetBytes((int)rawValue); break;
                case CalDataType.U64: buf = BitConverter.GetBytes((ulong)rawValue); break;
                case CalDataType.S64: buf = BitConverter.GetBytes((long)rawValue); break;
                case CalDataType.F32: buf = BitConverter.GetBytes((float)rawValue); break;
                case CalDataType.F64: buf = BitConverter.GetBytes(rawValue); break;
                default: buf = new[] { (byte)(uint)rawValue }; break;
            }
            if (e == CalEndian.Big) Array.Reverse(buf);
            Array.Copy(buf, 0, Data, off, size);
            Dirty = true;
            return true;
        }

        // ── table-level helpers ─────────────────────────────────────────────────────
        public long CellOffset(CalTable tbl, CalProject proj, int row, int col)
        {
            long baseOff = proj.ToFileOffset(tbl.Address);
            int elem = CalDataTypeInfo.SizeBytes(tbl.DataType);
            // Row-major (A2L / default): consecutive columns are contiguous in the image.
            // Column-major (TunerPro XDF): consecutive rows are contiguous. The per-table
            // flag keeps each definition format reading/writing in its native order.
            int idx = tbl.ColumnMajor
                ? col * Math.Max(1, tbl.Rows) + row
                : row * Math.Max(1, tbl.Columns) + col;
            return baseOff + (long)idx * elem;
        }

        /// <summary>Read every z-cell of a table as physical values, row-major.</summary>
        public double[,] ReadTablePhys(CalTable tbl, CalProject proj)
        {
            // Cap the declared size: corrupt A2L/XDF metadata can claim an absurd row/col count that
            // would allocate gigabytes (OutOfMemoryException). Real tables are at most a few hundred
            // per axis; 4096 is a generous ceiling that keeps the worst case bounded.
            int rows = Math.Min(Math.Max(1, tbl.Rows), 4096);
            int cols = Math.Min(Math.Max(1, tbl.Columns), 4096);
            var grid = new double[rows, cols];
            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                    grid[r, c] = ReadCellPhys(tbl, proj, r, c);
            return grid;
        }

        public double ReadCellPhys(CalTable tbl, CalProject proj, int row, int col)
        {
            long off = CellOffset(tbl, proj, row, col);
            // Bit-masked field (A2L BIT_MASK / TunerPro XDFFLAG): extract just the masked bits,
            // shifted down to LSB, so the displayed value is the field — not the whole storage word.
            if (tbl.BitMask != 0 && !CalDataTypeInfo.IsFloat(tbl.DataType))
            {
                int size = CalDataTypeInfo.SizeBytes(tbl.DataType);
                if (!InBounds(off, size)) return 0;
                ulong bits = ReadRawUInt(off, size, tbl.Endian);
                ulong field = (bits & tbl.BitMask) >> TrailingZeros(tbl.BitMask);
                return tbl.Conversion.RawToPhys(field);
            }
            return tbl.Conversion.RawToPhys(ReadRaw(off, tbl.DataType, tbl.Endian));
        }

        /// <summary>Write a physical value into one z-cell (converted, clamped to type range).</summary>
        public bool WriteCellPhys(CalTable tbl, CalProject proj, int row, int col, double phys)
        {
            if (!double.IsNaN(tbl.Min) && !double.IsInfinity(tbl.Min) && phys < tbl.Min) phys = tbl.Min;
            if (!double.IsNaN(tbl.Max) && !double.IsInfinity(tbl.Max) && phys > tbl.Max) phys = tbl.Max;
            long off = CellOffset(tbl, proj, row, col);
            RawRange(tbl.DataType, out double lo, out double hi);
            double raw = tbl.Conversion.PhysToRaw(phys, lo, hi);

            // Bit-masked field: read-modify-write so only the masked bits change and the other
            // flags/fields packed into the same storage word are preserved.
            if (tbl.BitMask != 0 && !CalDataTypeInfo.IsFloat(tbl.DataType))
            {
                int size = CalDataTypeInfo.SizeBytes(tbl.DataType);
                if (!InBounds(off, size) || double.IsNaN(raw)) return false;
                int shift = TrailingZeros(tbl.BitMask);
                ulong field = (ulong)Math.Max(0, Math.Round(raw, MidpointRounding.AwayFromZero));
                ulong cur = ReadRawUInt(off, size, tbl.Endian);
                ulong updated = (cur & ~(ulong)tbl.BitMask) | ((field << shift) & tbl.BitMask);
                WriteRawUInt(off, size, tbl.Endian, updated);
                Dirty = true;
                return true;
            }
            return WriteRaw(off, tbl.DataType, tbl.Endian, raw);
        }

        // ── raw little-endian-normalised integer access (for bit-masked fields) ─────────
        private ulong ReadRawUInt(long off, int size, CalEndian e)
        {
            if (off < 0 || size <= 0 || off > Data.Length - size) return 0;   // never copy past the image
            var buf = new byte[size];
            Array.Copy(Data, off, buf, 0, size);
            if (e == CalEndian.Big) Array.Reverse(buf);
            ulong v = 0;
            for (int i = 0; i < size && i < 8; i++) v |= (ulong)buf[i] << (8 * i);
            return v;
        }

        private void WriteRawUInt(long off, int size, CalEndian e, ulong v)
        {
            if (off < 0 || size <= 0 || off > Data.Length - size) return;   // never write past the image
            var buf = new byte[size];
            for (int i = 0; i < size && i < 8; i++) buf[i] = (byte)(v >> (8 * i));
            if (e == CalEndian.Big) Array.Reverse(buf);
            Array.Copy(buf, 0, Data, off, size);
        }

        private static int TrailingZeros(uint m)
        {
            if (m == 0) return 0;
            int n = 0; while ((m & 1) == 0) { m >>= 1; n++; }
            return n;
        }

        /// <summary>Read an axis (embedded → from image; static → its label list).</summary>
        public double[] ReadAxis(CalAxis ax, CalProject proj)
        {
            if (ax == null) return new double[1];
            int n = Math.Min(Math.Max(1, ax.Count), 4096);   // cap a corrupt axis count to avoid OutOfMemory
            var vals = new double[n];
            if (!ax.IsEmbedded)
            {
                for (int i = 0; i < n; i++)
                    vals[i] = ax.StaticValues != null && i < ax.StaticValues.Length ? ax.StaticValues[i] : i;
                return vals;
            }
            long baseOff = proj.ToFileOffset(ax.Address);
            int elem = CalDataTypeInfo.SizeBytes(ax.DataType);
            for (int i = 0; i < n; i++)
            {
                double raw = ReadRaw(baseOff + (long)i * elem, ax.DataType, ax.Endian);
                vals[i] = ax.Conversion.RawToPhys(raw);
            }
            return vals;
        }

        public bool WriteAxisCell(CalAxis ax, CalProject proj, int index, double phys)
        {
            if (ax == null || !ax.IsEmbedded) return false;
            long baseOff = proj.ToFileOffset(ax.Address);
            int elem = CalDataTypeInfo.SizeBytes(ax.DataType);
            RawRange(ax.DataType, out double lo, out double hi);
            double raw = ax.Conversion.PhysToRaw(phys, lo, hi);
            return WriteRaw(baseOff + (long)index * elem, ax.DataType, ax.Endian, raw);
        }

        /// <summary>True if any byte of this z-cell differs from the original image.</summary>
        public bool CellChanged(CalTable tbl, CalProject proj, int row, int col)
        {
            long off = CellOffset(tbl, proj, row, col);
            int size = CalDataTypeInfo.SizeBytes(tbl.DataType);
            // Original can be shorter than Data (re-loaded/replaced image), so bound it independently.
            if (!InBounds(off, size) || Original == null || off > Original.Length - size) return false;
            for (int i = 0; i < size; i++)
                if (Data[off + i] != Original[off + i]) return true;
            return false;
        }

        /// <summary>True if any byte within the table's z-block differs from the original.</summary>
        public bool TableChanged(CalTable tbl, CalProject proj)
        {
            long off = proj.ToFileOffset(tbl.Address);
            int size = tbl.ByteSize;
            if (!InBounds(off, size) || Original == null || off > Original.Length - size) return false;
            for (int i = 0; i < size; i++)
                if (Data[off + i] != Original[off + i]) return true;
            return false;
        }
    }
}
