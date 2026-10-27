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
//  XdfWriter.cs — unified CalProject → TunerPro XDF (XML).  The exact inverse of XdfParser:
//  every element and attribute the parser reads back is emitted here, so a project written
//  by the editor round-trips (write → re-parse → identical tables).  Powers the Calibration
//  Editor's XDF authoring commands (New XDF, edit / add / delete parameter, Save XDF).
//
//  Element/attribute names mirror XdfParser exactly:
//    XDFHEADER : flags, BASEOFFSET(offset, subtract), DEFAULTS(datasizeinbits, signed,
//                lsbfirst, float), REGION(size), CATEGORY(index, name)
//    XDFTABLE  : title, description, three XDFAXIS(id="x"/"y"/"z"); the z axis's EMBEDDEDDATA
//                (mmedaddress, mmedelementsizebits, mmedrowcount, mmedcolcount, mmedtypeflags)
//                carries the table address + dims, its MATH carries the raw→physical equation.
//    XDFCONSTANT / XDFFLAG : scalar / bit-flag, EMBEDDEDDATA directly on the element.
//
//  mmedtypeflags is rebuilt from the table's data type + endianness: bit 0x01 = signed,
//  0x02 = LSB-first (little-endian), 0x10000 = float.  We always emit it (the parser treats a
//  present flags attribute as an explicit per-table override, which is exactly what we want —
//  the editor knows the precise type).
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace TesterPresent.OBD2.Calibration
{
    public static class XdfWriter
    {
        public static void Save(CalProject proj, string path)
            => File.WriteAllText(path, ToXml(proj), new UTF8Encoding(false));

        public static string ToXml(CalProject proj)
        {
            if (proj == null) throw new ArgumentNullException(nameof(proj));

            // Distinct category names across all tables → a 0-based header index.  CATEGORYMEM
            // references are 1-based (parser does category - 1), matching TunerPro.
            var cats = new List<string>();
            foreach (var t in proj.Tables)
                foreach (var c in t.Categories)
                    if (!string.IsNullOrWhiteSpace(c) && !cats.Contains(c)) cats.Add(c);

            var root = new XElement("XDFFORMAT",
                new XAttribute("version", "1.60"),
                BuildHeader(proj, cats));

            uint uid = 0;
            foreach (var t in proj.Tables)
            {
                if (t == null) continue;
                XElement el;
                switch (t.Kind)
                {
                    case CalTableKind.Scalar: el = BuildConstant(t, uid++); break;
                    case CalTableKind.Flag:   el = BuildFlag(t, uid++);     break;
                    default:                  el = BuildTable(t, uid++);    break;
                }
                AddCategoryMems(el, t, cats);
                root.Add(el);
            }

            var doc = new XDocument(new XDeclaration("1.0", "UTF-8", null), root);
            var sb = new StringBuilder();
            var settings = new XmlWriterSettings
            {
                Indent = true, IndentChars = "   ",
                Encoding = new UTF8Encoding(false), OmitXmlDeclaration = false
            };
            // XmlWriter takes its declaration encoding from the underlying TextWriter; a plain
            // StringWriter is UTF-16, which would stamp encoding="utf-16" into a file Save() then
            // writes as UTF-8 bytes (a mismatch strict parsers reject).  Report UTF-8 instead.
            using (var sw = new Utf8StringWriter(sb))
            using (var w = XmlWriter.Create(sw, settings))
                doc.Save(w);
            return sb.ToString();
        }

        private sealed class Utf8StringWriter : StringWriter
        {
            public Utf8StringWriter(StringBuilder sb) : base(sb) { }
            public override Encoding Encoding => new UTF8Encoding(false);
        }

        // ── header ───────────────────────────────────────────────────────────────────
        private static XElement BuildHeader(CalProject proj, List<string> cats)
        {
            var h = new XElement("XDFHEADER",
                new XElement("flags", "0x1"),
                new XElement("description", proj.Name ?? ""),
                new XElement("BASEOFFSET",
                    new XAttribute("offset", Hex(proj.BaseAddress)),
                    new XAttribute("subtract", proj.SubtractBase ? "1" : "0")),
                new XElement("DEFAULTS",
                    new XAttribute("datasizeinbits", "8"),
                    new XAttribute("sigdigits", "2"),
                    new XAttribute("outputtype", "1"),
                    new XAttribute("signed", "0"),
                    new XAttribute("lsbfirst", proj.DefaultEndian == CalEndian.Little ? "1" : "0"),
                    new XAttribute("float", "0")));

            if (proj.ExpectedImageSize > 0)
                h.Add(new XElement("REGION",
                    new XAttribute("type", "0xFFFFFFFF"),
                    new XAttribute("startaddress", "0x0"),
                    new XAttribute("size", Hex(proj.ExpectedImageSize)),
                    new XAttribute("regionflags", "0x0"),
                    new XAttribute("name", "Binary File"),
                    new XAttribute("desc", "This region describes the bin file edited by this XDF")));

            for (int i = 0; i < cats.Count; i++)
                h.Add(new XElement("CATEGORY",
                    new XAttribute("index", Hex((long)i)),
                    new XAttribute("name", cats[i])));

            return h;
        }

        private static void AddCategoryMems(XElement el, CalTable t, List<string> cats)
        {
            int slot = 0;
            foreach (var c in t.Categories)
            {
                int idx = cats.IndexOf(c);
                if (idx < 0) continue;
                el.Add(new XElement("CATEGORYMEM",
                    new XAttribute("index", slot.ToString(CultureInfo.InvariantCulture)),
                    new XAttribute("category", (idx + 1).ToString(CultureInfo.InvariantCulture)))); // 1-based
                slot++;
            }
        }

        // ── table / constant / flag ──────────────────────────────────────────────────
        private static XElement BuildTable(CalTable t, uint uid)
        {
            var el = new XElement("XDFTABLE",
                new XAttribute("uniqueid", Hex(uid)),
                new XAttribute("flags", "0x0"),
                new XElement("title", t.Title ?? t.Name ?? "Table"));
            if (!string.IsNullOrEmpty(t.Description)) el.Add(new XElement("description", t.Description));

            // TunerPro tables always carry x, y and z axes (the parser keys them by id).  The z
            // axis owns the data layout; x/y describe the axis scales and are only re-read when
            // their dimension exceeds 1, but we always emit all three for a valid XDF.
            el.Add(BuildScaleAxis("x", t.XAxis, Math.Max(1, t.Columns)));
            el.Add(BuildScaleAxis("y", t.YAxis, Math.Max(1, t.Rows)));
            el.Add(BuildDataAxis(t));
            return el;
        }

        private static XElement BuildConstant(CalTable t, uint uid)
        {
            var el = new XElement("XDFCONSTANT",
                new XAttribute("uniqueid", Hex(uid)),
                new XAttribute("flags", "0x0"),
                new XElement("title", t.Title ?? t.Name ?? "Constant"));
            if (!string.IsNullOrEmpty(t.Description)) el.Add(new XElement("description", t.Description));
            el.Add(Embedded(t.Address, t.DataType, t.Endian));
            if (!string.IsNullOrEmpty(t.Units)) el.Add(new XElement("units", t.Units));
            AddMinMax(el, t.Min, t.Max);
            el.Add(BuildMath(t.Conversion));
            return el;
        }

        private static XElement BuildFlag(CalTable t, uint uid)
        {
            var el = new XElement("XDFFLAG",
                new XAttribute("uniqueid", Hex(uid)),
                new XAttribute("flags", "0x0"),
                new XElement("title", t.Title ?? t.Name ?? "Flag"));
            if (!string.IsNullOrEmpty(t.Description)) el.Add(new XElement("description", t.Description));
            el.Add(Embedded(t.Address, t.DataType, t.Endian));
            // Parser reads the mask from a "mask" attribute first, falling back to a <mask> child;
            // the <mask> child is the TunerPro-standard form.
            el.Add(new XElement("mask", Hex(t.BitMask)));
            return el;
        }

        // z axis: the data block itself (address + dims + type + scaling).
        private static XElement BuildDataAxis(CalTable t)
        {
            var z = new XElement("XDFAXIS", new XAttribute("id", "z"),
                new XElement("EMBEDDEDDATA",
                    new XAttribute("mmedaddress", Hex(t.Address)),
                    new XAttribute("mmedelementsizebits", Bits(t.DataType)),
                    new XAttribute("mmedrowcount", Math.Max(1, t.Rows).ToString(CultureInfo.InvariantCulture)),
                    new XAttribute("mmedcolcount", Math.Max(1, t.Columns).ToString(CultureInfo.InvariantCulture)),
                    new XAttribute("mmedtypeflags", Hex(TypeFlags(t.DataType, t.Endian)))));
            if (!string.IsNullOrEmpty(t.Units)) z.Add(new XElement("units", t.Units));
            AddMinMax(z, t.Min, t.Max);
            z.Add(BuildMath(t.Conversion));
            return z;
        }

        // x / y axis: either embedded (values in the bin) or static (explicit LABEL list).
        private static XElement BuildScaleAxis(string id, CalAxis ax, int count)
        {
            var x = new XElement("XDFAXIS", new XAttribute("id", id));
            int n = Math.Max(1, ax?.Count ?? count);

            if (ax != null && ax.IsEmbedded && ax.Address != 0)
            {
                x.Add(new XElement("EMBEDDEDDATA",
                    new XAttribute("mmedaddress", Hex(ax.Address)),
                    new XAttribute("mmedelementsizebits", Bits(ax.DataType)),
                    new XAttribute("mmedcolcount", n.ToString(CultureInfo.InvariantCulture)),
                    new XAttribute("mmedtypeflags", Hex(TypeFlags(ax.DataType, ax.Endian)))));
                x.Add(new XElement("indexcount", n.ToString(CultureInfo.InvariantCulture)));
                if (!string.IsNullOrEmpty(ax.Units)) x.Add(new XElement("units", ax.Units));
                AddMinMax(x, ax.Min, ax.Max);
                x.Add(BuildMath(ax.Conversion));
                return x;
            }

            // Static axis: address 0 so the parser takes the LABEL path; exactly n finite labels
            // so it accepts them (otherwise it falls back to a plain 0..n-1 index axis).
            x.Add(new XElement("EMBEDDEDDATA", new XAttribute("mmedaddress", "0x0")));
            x.Add(new XElement("indexcount", n.ToString(CultureInfo.InvariantCulture)));
            double[] vals = ax?.StaticValues;
            for (int i = 0; i < n; i++)
            {
                double v = (vals != null && i < vals.Length) ? vals[i] : i;
                x.Add(new XElement("LABEL",
                    new XAttribute("index", i.ToString(CultureInfo.InvariantCulture)),
                    new XAttribute("value", Num(v))));
            }
            if (ax != null && !string.IsNullOrEmpty(ax.Units)) x.Add(new XElement("units", ax.Units));
            x.Add(BuildMath(ax?.Conversion));
            return x;
        }

        private static XElement Embedded(uint address, CalDataType type, CalEndian endian)
            => new XElement("EMBEDDEDDATA",
                new XAttribute("mmedaddress", Hex(address)),
                new XAttribute("mmedelementsizebits", Bits(type)),
                new XAttribute("mmedtypeflags", Hex(TypeFlags(type, endian))));

        // ── scaling ──────────────────────────────────────────────────────────────────
        private static XElement BuildMath(CalConversion conv)
            => new XElement("MATH",
                new XAttribute("equation", EquationFor(conv)),
                new XElement("VAR", new XAttribute("id", "X")));

        // Reconstruct a phys = f(X) equation (X = raw) from the conversion.
        private static string EquationFor(CalConversion c)
        {
            if (c == null) return "X";
            switch (c.Kind)
            {
                case CalConvKind.Identity: return "X";
                case CalConvKind.Linear:   return LinearEq(c.A, c.B);
                case CalConvKind.Formula:  return !string.IsNullOrWhiteSpace(c.Expr?.Source) ? c.Expr.Source : "X";
                case CalConvKind.RatFunc:
                {
                    var k = c.Coeffs;
                    // Near-universal linear-rational case (a = d = 0): phys = (f·X − c) / (b − e·X).
                    if (k != null && k.Length >= 6 && k[0] == 0 && k[3] == 0)
                        return $"(({Num(k[5])}) * X - ({Num(k[2])})) / (({Num(k[1])}) - ({Num(k[4])}) * X)";
                    // General quadratic rational has no closed-form display inverse — identity is the
                    // safe fallback (the raw value still shows).
                    return "X";
                }
                default: return "X";
            }
        }

        private static string LinearEq(double a, double b)
        {
            bool aOne = Math.Abs(a - 1.0) < 1e-12;
            bool bZero = Math.Abs(b) < 1e-12;
            if (aOne && bZero) return "X";
            string core = aOne ? "X" : $"X * {Num(a)}";
            if (bZero) return core;
            return b < 0 ? $"{core} - {Num(-b)}" : $"{core} + {Num(b)}";
        }

        // ── helpers ──────────────────────────────────────────────────────────────────
        // mmedtypeflags: bit 0x01 = signed, 0x02 = LSB-first (little-endian), 0x10000 = float.
        private static uint TypeFlags(CalDataType t, CalEndian e)
        {
            uint f = 0;
            if (CalDataTypeInfo.IsSigned(t)) f |= 0x01;
            if (e == CalEndian.Little)       f |= 0x02;
            if (CalDataTypeInfo.IsFloat(t))  f |= 0x10000;
            return f;
        }

        private static string Bits(CalDataType t)
            => (CalDataTypeInfo.SizeBytes(t) * 8).ToString(CultureInfo.InvariantCulture);

        private static void AddMinMax(XElement host, double min, double max)
        {
            if (!double.IsInfinity(min) && !double.IsNaN(min)) host.Add(new XElement("min", Num(min)));
            if (!double.IsInfinity(max) && !double.IsNaN(max)) host.Add(new XElement("max", Num(max)));
        }

        private static string Num(double v)
            => (double.IsNaN(v) || double.IsInfinity(v)) ? "0" : v.ToString("R", CultureInfo.InvariantCulture);

        private static string Hex(long v) => "0x" + v.ToString("X", CultureInfo.InvariantCulture);
        private static string Hex(uint v) => "0x" + v.ToString("X", CultureInfo.InvariantCulture);
    }
}
