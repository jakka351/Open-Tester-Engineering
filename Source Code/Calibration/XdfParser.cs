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
//  XdfParser.cs — TunerPro XDF (XML definition) importer → unified CalProject.
//
//  Layout (per the XDF 1.6 schema): XDFFORMAT > XDFHEADER (flags, BASEOFFSET, DEFAULTS,
//  CATEGORY*) and then XDFTABLE / XDFCONSTANT / XDFFLAG entries.  A table carries three
//  XDFAXIS children (id="x","y","z"); the z axis's EMBEDDEDDATA gives the table's address,
//  element size, column and row counts, and its MATH gives the raw→physical equation.  The
//  x/y axes are either embedded (their own EMBEDDEDDATA address) or static (a LABEL list).
//
//  Data layout from EMBEDDEDDATA.mmedtypeflags: bit 0x01 = signed, 0x02 = LSB-first
//  (little-endian), 0x10000 = float; anything absent inherits the header DEFAULTS.  Every
//  decoded data type / sign / endianness is also surfaced as an editable table property so
//  an ambiguous definition can be corrected in one click rather than silently mis-read.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace TesterPresent.OBD2.Calibration
{
    public sealed class XdfParser
    {
        private bool   _defSigned;
        private bool   _defLsbFirst = true;
        private bool   _defFloat;
        private int    _defSizeBits = 8;
        private readonly Dictionary<int, string> _categories = new Dictionary<int, string>();

        public List<string> Warnings { get; } = new List<string>();

        public static CalProject Load(string path)
            => new XdfParser().Parse(File.ReadAllText(path), Path.GetFileNameWithoutExtension(path), path);

        public CalProject Parse(string xml, string name, string path = "")
        {
            XDocument doc;
            try { doc = XDocument.Parse(xml ?? ""); }
            catch (Exception ex) { throw new FormatException("Malformed XDF XML: " + ex.Message, ex); }
            var root = doc.Root;
            if (root == null || root.Name.LocalName != "XDFFORMAT")
                throw new FormatException("Not an XDF (missing XDFFORMAT root).");

            var proj = new CalProject { Name = name, Source = CalProject.SourceKind.XDF, SourcePath = path };

            var header = root.Element("XDFHEADER");
            if (header != null) ReadHeader(header, proj);

            foreach (var el in root.Elements())
            {
                // One malformed table must not abort the whole import — skip it and warn (mirrors
                // A2lParser's per-block try/catch).
                try
                {
                    switch (el.Name.LocalName)
                    {
                        case "XDFTABLE":    { var t = ReadTable(el);    if (t != null) proj.Tables.Add(t); break; }
                        case "XDFCONSTANT": { var t = ReadConstant(el); if (t != null) proj.Tables.Add(t); break; }
                        case "XDFFLAG":     { var t = ReadFlag(el);     if (t != null) proj.Tables.Add(t); break; }
                    }
                }
                catch (Exception ex) { Warnings.Add($"Skipped {el.Name.LocalName}: {ex.Message}"); }
            }
            proj.DefaultEndian = _defLsbFirst ? CalEndian.Little : CalEndian.Big;
            return proj;
        }

        private void ReadHeader(XElement header, CalProject proj)
        {
            var baseOff = header.Element("BASEOFFSET");
            if (baseOff != null)
            {
                proj.BaseAddress = ParseLong(Attr(baseOff, "offset", "0"));
                proj.SubtractBase = ParseLong(Attr(baseOff, "subtract", "0")) != 0;
            }
            var defaults = header.Element("DEFAULTS");
            if (defaults != null)
            {
                _defSizeBits = (int)ParseLong(Attr(defaults, "datasizeinbits", "8"));
                _defSigned   = ParseLong(Attr(defaults, "signed", "0")) != 0;
                _defLsbFirst = ParseLong(Attr(defaults, "lsbfirst", "1")) != 0;
                _defFloat    = ParseLong(Attr(defaults, "float", "0")) != 0;
            }
            var region = header.Element("REGION");
            if (region != null) proj.ExpectedImageSize = ParseLong(Attr(region, "size", "0"));

            foreach (var cat in header.Elements("CATEGORY"))
            {
                int idx = (int)ParseLong(Attr(cat, "index", "0"));
                _categories[idx] = Attr(cat, "name", "Category");
            }
        }

        private struct Embedded
        {
            public uint Address; public CalDataType Type; public CalEndian Endian;
            public int Cols; public int Rows; public bool HasData;
        }

        private Embedded ReadEmbedded(XElement axisOrTable)
        {
            var e = new Embedded { Type = CalDataTypeInfo.FromXdf(_defSizeBits, _defSigned, _defFloat),
                                   Endian = _defLsbFirst ? CalEndian.Little : CalEndian.Big, Cols = 1, Rows = 1 };
            var ed = axisOrTable.Element("EMBEDDEDDATA");
            if (ed == null) return e;
            e.HasData = true;
            e.Address = (uint)ParseLong(Attr(ed, "mmedaddress", "0"));
            int sizeBits = (int)ParseLong(Attr(ed, "mmedelementsizebits", _defSizeBits.ToString()));
            long flags = ParseLong(Attr(ed, "mmedtypeflags", "0"));
            // An mmedtypeflags attribute that is PRESENT — even when it is 0 — is an explicit
            // per-table override (0 = unsigned, big-endian, integer).  Only fall back to the
            // header DEFAULTS when the attribute is genuinely absent.  (Treating present-and-0
            // as "absent" silently byte-swaps / re-signs every table that zeroes its flags.)
            bool hasFlags = ed.Attribute("mmedtypeflags") != null;
            bool signed  = hasFlags ? (flags & 0x01) != 0 : _defSigned;
            bool isFloat = hasFlags ? (flags & 0x10000) != 0 : _defFloat;
            bool little  = hasFlags ? (flags & 0x02) != 0 : _defLsbFirst;
            e.Type = CalDataTypeInfo.FromXdf(sizeBits, signed, isFloat);
            e.Endian = little ? CalEndian.Little : CalEndian.Big;
            e.Cols = (int)ParseLong(Attr(ed, "mmedcolcount", "1"));
            e.Rows = (int)ParseLong(Attr(ed, "mmedrowcount", "1"));
            return e;
        }

        private CalConversion ReadMath(XElement axisOrTable, string units)
        {
            var math = axisOrTable.Element("MATH");
            string eq = math != null ? Attr(math, "equation", "X") : "X";
            if (string.IsNullOrWhiteSpace(eq) || eq.Trim().Equals("X", StringComparison.OrdinalIgnoreCase))
                return CalConversion.MakeIdentity(units ?? "");
            return CalConversion.MakeFormula(eq, units ?? "");
        }

        private CalTable ReadTable(XElement el)
        {
            string title = el.Element("title")?.Value ?? "Table";
            string desc  = el.Element("description")?.Value ?? "";

            // GroupBy+First (not ToDictionary) so a duplicate axis id doesn't throw ArgumentException.
            var axes = el.Elements("XDFAXIS")
                         .GroupBy(a => (Attr(a, "id", "z") ?? "z").ToLowerInvariant())
                         .ToDictionary(g => g.Key, g => g.First());
            if (!axes.TryGetValue("z", out var zAx)) return null;

            var z = ReadEmbedded(zAx);
            // Cap the embedded col/row counts: corrupt mmedcolcount/mmedrowcount would allocate
            // gigabytes downstream (OutOfMemory).
            int cols = Math.Min(Math.Max(1, z.Cols), 4096);
            int rows = Math.Min(Math.Max(1, z.Rows), 4096);
            string units = zAx.Element("units")?.Value ?? "";
            var conv = ReadMath(zAx, units);
            conv.Units = units;

            var tbl = new CalTable
            {
                Name = title, Title = title, Description = desc,
                Address = z.Address, DataType = z.Type, Endian = z.Endian,
                Columns = cols, Rows = rows, Conversion = conv, Units = units,
                DisplayFormat = conv.Format,
                Min = ParseDoubleSafe(zAx.Element("min")?.Value, double.NegativeInfinity),
                Max = ParseDoubleSafe(zAx.Element("max")?.Value, double.PositiveInfinity),
                Kind = rows > 1 ? CalTableKind.Map : (cols > 1 ? CalTableKind.Curve : CalTableKind.Scalar),
                // TunerPro stores 2-D table cells column-major (consecutive rows are
                // contiguous in the image). Flag it so CellOffset reads/writes XDF maps
                // in the same order TunerPro does — otherwise maps come out transposed
                // and customers' XDFs aren't cross-compatible. (No effect on 1-D tables.)
                ColumnMajor = true
            };

            if (axes.TryGetValue("x", out var xAx) && cols > 1) tbl.XAxis = ReadAxis(xAx, cols);
            if (axes.TryGetValue("y", out var yAx) && rows > 1) tbl.YAxis = ReadAxis(yAx, rows);

            ApplyCategories(el, tbl);
            tbl.Risk = CalRisk.Classify(tbl.Name, tbl.Title, tbl.Units);
            CalCategoriser.Assign(tbl);
            return tbl;
        }

        private CalAxis ReadAxis(XElement axEl, int count)
        {
            var emb = ReadEmbedded(axEl);
            string units = axEl.Element("units")?.Value ?? "";
            var conv = ReadMath(axEl, units);
            int idxCount = (int)ParseLong(axEl.Element("indexcount")?.Value ?? count.ToString());
            if (idxCount <= 0) idxCount = count;
            if (idxCount > 4096) idxCount = 4096;   // cap a corrupt indexcount → no OutOfMemory

            // Embedded axis: values live in the binary at mmedaddress.
            if (emb.HasData && emb.Address != 0)
                return new CalAxis
                {
                    Name = "Axis", Units = units, Count = idxCount, IsEmbedded = true,
                    Address = emb.Address, DataType = emb.Type, Endian = emb.Endian, Conversion = conv,
                    Min = ParseDoubleSafe(axEl.Element("min")?.Value, double.NegativeInfinity),
                    Max = ParseDoubleSafe(axEl.Element("max")?.Value, double.PositiveInfinity)
                };

            // Static axis: explicit LABEL values, else a plain index axis.
            var labels = axEl.Elements("LABEL")
                             .Select(l => ParseDoubleSafe(Attr(l, "value", null), double.NaN))
                             .ToArray();
            double[] vals = labels.Length == idxCount && labels.All(v => !double.IsNaN(v))
                ? labels
                : Enumerable.Range(0, idxCount).Select(i => (double)i).ToArray();
            return new CalAxis { Name = "Axis", Units = units, Count = idxCount, IsEmbedded = false,
                                 StaticValues = vals, Conversion = conv };
        }

        private CalTable ReadConstant(XElement el)
        {
            string title = el.Element("title")?.Value ?? "Constant";
            var emb = ReadEmbedded(el);
            string units = el.Element("units")?.Value ?? "";
            var conv = ReadMath(el, units);
            var tbl = new CalTable
            {
                Name = title, Title = title, Description = el.Element("description")?.Value ?? "",
                Kind = CalTableKind.Scalar, Address = emb.Address, DataType = emb.Type, Endian = emb.Endian,
                Columns = 1, Rows = 1, Conversion = conv, Units = units, DisplayFormat = conv.Format,
                Min = ParseDoubleSafe(el.Element("min")?.Value, double.NegativeInfinity),
                Max = ParseDoubleSafe(el.Element("max")?.Value, double.PositiveInfinity)
            };
            ApplyCategories(el, tbl);
            tbl.Risk = CalRisk.Classify(tbl.Name, tbl.Title, tbl.Units);
            CalCategoriser.Assign(tbl);
            return tbl;
        }

        private CalTable ReadFlag(XElement el)
        {
            string title = el.Element("title")?.Value ?? "Flag";
            var emb = ReadEmbedded(el);
            uint mask = (uint)ParseLong(Attr(el, "mask", el.Element("mask")?.Value ?? "1"));
            var tbl = new CalTable
            {
                Name = title, Title = title, Description = el.Element("description")?.Value ?? "",
                Kind = CalTableKind.Flag, Address = emb.Address, DataType = emb.Type, Endian = emb.Endian,
                Columns = 1, Rows = 1, BitMask = mask, Conversion = CalConversion.Identity
            };
            ApplyCategories(el, tbl);
            tbl.Risk = CalRisk.Classify(tbl.Name, tbl.Title);
            CalCategoriser.Assign(tbl);
            return tbl;
        }

        private void ApplyCategories(XElement el, CalTable tbl)
        {
            foreach (var cm in el.Elements("CATEGORYMEM").OrderBy(c => ParseLong(Attr(c, "index", "0"))))
            {
                int catRef = (int)ParseLong(Attr(cm, "category", "0")) - 1; // CATEGORYMEM is 1-based into CATEGORY
                if (_categories.TryGetValue(catRef, out var nm) && !string.IsNullOrWhiteSpace(nm))
                    tbl.Categories.Add(nm);
            }
        }

        // ── helpers ─────────────────────────────────────────────────────────────────
        private static string Attr(XElement e, string name, string dflt)
            => e?.Attribute(name)?.Value ?? dflt;

        private static long ParseLong(string s)
        {
            s = (s ?? "").Trim();
            if (s.Length == 0) return 0;
            // Parse hex as UNSIGNED so a full-width value (0xFFFFFFFF / 0xFFFFFFFFFFFFFFFF, common
            // for masks) doesn't overflow Int64 and throw — one bad attribute used to abort the
            // entire XDF import (no try/catch around the element loop).
            if (s.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
                return ulong.TryParse(s.Substring(2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var hx) ? (long)hx : 0;
            return long.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out var v) ? v
                 : (long)ParseDoubleSafe(s, 0);
        }
        private static double ParseDoubleSafe(string s, double dflt)
        {
            if (string.IsNullOrWhiteSpace(s)) return dflt;
            s = s.Trim();
            if (s.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
                return ulong.TryParse(s.Substring(2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var hx) ? hx : dflt;
            return double.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out var v) ? v : dflt;
        }
    }
}
