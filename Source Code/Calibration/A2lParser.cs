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
//  A2lParser.cs — ASAM MCD-2 MC (.a2l) importer → unified CalProject.
//
//  A2L is a keyword grammar of "/begin BLOCK ... /end BLOCK" sections with whitespace-
//  separated tokens, double-quoted strings, and C-style comments.  This is a proper
//  two-pass recursive-descent reader (not the fragile line-positional approach): pass 1
//  tokenises and collects every COMPU_METHOD / COMPU_VTAB / RECORD_LAYOUT / CHARACTERISTIC
//  / AXIS_PTS / MEMORY_SEGMENT / MOD_COMMON block; pass 2 resolves the name references and
//  builds CalTables with correct data types, conversions and axes.  Unknown blocks are
//  skipped to their matching /end so vendor extensions never break the parse.
//
//  Address mapping: A2L ECU_ADDRESS values are absolute.  The flash origin (smallest
//  MEMORY_SEGMENT address, or an inferred base) becomes CalProject.BaseAddress so the
//  binary engine can resolve addr → file offset.  The base is user-overridable in the UI.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace TesterPresent.OBD2.Calibration
{
    public sealed class A2lParser
    {
        // ── raw block records (pass 1) ──────────────────────────────────────────────
        private sealed class RawCompuMethod
        {
            public string Name, Type, Format = "", Unit = "", CompuTabRef, Formula;
            public double[] Coeffs;        // RAT_FUNC: 6
            public double[] CoeffsLinear;  // LINEAR: 2
        }
        private sealed class RawCompuTab
        {
            public string Name, Type;
            public Dictionary<long, string> Verbal = new Dictionary<long, string>();
            public List<(double inv, double outv)> Numeric = new List<(double, double)>();
        }
        private sealed class RawRecordLayout
        {
            public string Name;
            public string FncDataType;
            public string AxisXDataType, AxisYDataType;
        }
        private sealed class RawAxisDescr
        {
            public string Attribute, CompuMethod, AxisPtsRef;
            public int MaxAxisPoints;
            public double Lower, Upper;
            public double[] FixDist;   // offset, dist, n
            public double[] FixList;
        }
        private sealed class RawCharacteristic
        {
            public string Name, Long, Type, RecordLayout, CompuMethod;
            public uint Address;
            public double Lower, Upper;
            public string BitMask, Format;
            public int Number;             // VAL_BLK count
            public int[] MatrixDim;        // x,y,z
            public List<RawAxisDescr> Axes = new List<RawAxisDescr>();
        }
        private sealed class RawAxisPts
        {
            public string Name, Long, RecordLayout, CompuMethod;
            public uint Address;
            public int MaxAxisPoints;
            public double Lower, Upper;
        }
        private sealed class RawMemSeg { public string Name; public uint Address; public uint Size; }

        private readonly Dictionary<string, RawCompuMethod>  _cm  = new Dictionary<string, RawCompuMethod>();
        private readonly Dictionary<string, RawCompuTab>     _ct  = new Dictionary<string, RawCompuTab>();
        private readonly Dictionary<string, RawRecordLayout> _rl  = new Dictionary<string, RawRecordLayout>();
        private readonly Dictionary<string, RawAxisPts>      _ap  = new Dictionary<string, RawAxisPts>();
        private readonly List<RawCharacteristic>             _ch  = new List<RawCharacteristic>();
        private readonly List<RawMemSeg>                     _seg = new List<RawMemSeg>();
        private CalEndian _byteOrder = CalEndian.Little;

        public List<string> Warnings { get; } = new List<string>();

        public static CalProject Load(string path)
        {
            var p = new A2lParser();
            string text = DecodeBytes(File.ReadAllBytes(path));
            return p.Parse(text, Path.GetFileNameWithoutExtension(path), path);
        }

        public CalProject Parse(string text, string name, string path = "")
        {
            var toks = Tokenize(text);
            ScanBlocks(toks);
            return Build(name, path);
        }

        // ── tokenizer ───────────────────────────────────────────────────────────────
        private static List<string> Tokenize(string s)
        {
            var toks = new List<string>(1 << 16);
            int i = 0, n = s.Length;
            var sb = new StringBuilder();
            while (i < n)
            {
                char c = s[i];
                // comments
                if (c == '/' && i + 1 < n && s[i + 1] == '/')
                { while (i < n && s[i] != '\n') i++; continue; }
                if (c == '/' && i + 1 < n && s[i + 1] == '*')
                { i += 2; while (i + 1 < n && !(s[i] == '*' && s[i + 1] == '/')) i++; i += 2; continue; }
                // quoted string
                if (c == '"')
                {
                    i++; sb.Clear();
                    while (i < n && s[i] != '"')
                    {
                        if (s[i] == '\\' && i + 1 < n) { sb.Append(s[i + 1]); i += 2; }
                        else sb.Append(s[i++]);
                    }
                    i++; // closing quote
                    toks.Add("\0" + sb.ToString());   // \0 prefix marks a string literal
                    continue;
                }
                if (char.IsWhiteSpace(c)) { i++; continue; }
                // /begin and /end are their own tokens
                if (c == '/')
                {
                    int st = i; i++;
                    while (i < n && (char.IsLetter(s[i]))) i++;
                    toks.Add(s.Substring(st, i - st));
                    continue;
                }
                // bare token
                {
                    int st = i;
                    while (i < n && !char.IsWhiteSpace(s[i]) && s[i] != '"') i++;
                    toks.Add(s.Substring(st, i - st));
                }
            }
            return toks;
        }

        private static bool IsStr(string t) => t != null && t.Length > 0 && t[0] == '\0';
        private static string Str(string t) => IsStr(t) ? t.Substring(1) : t;

        // ── pass 1: collect blocks ──────────────────────────────────────────────────
        private int _p;
        private List<string> _t;

        private void ScanBlocks(List<string> toks)
        {
            _t = toks; _p = 0;
            while (_p < _t.Count)
            {
                string tok = _t[_p++];
                if (tok != "/begin") continue;
                string kw = _p < _t.Count ? _t[_p++] : "";
                try
                {
                    switch (kw)
                    {
                        // Container blocks: DESCEND into them — every CHARACTERISTIC / COMPU_METHOD
                        // lives inside  /begin PROJECT … /begin MODULE … .  Skipping PROJECT would
                        // skip the whole file (which is why no tables appeared).  Treat these as
                        // transparent: do nothing and let the loop find the nested /begin blocks.
                        case "PROJECT":
                        case "MODULE":
                            break;
                        case "COMPU_METHOD":   ParseCompuMethod(); break;
                        case "COMPU_VTAB":     ParseCompuTab(true); break;
                        case "COMPU_TAB":      ParseCompuTab(false); break;
                        case "RECORD_LAYOUT":  ParseRecordLayout(); break;
                        case "CHARACTERISTIC": ParseCharacteristic(); break;
                        case "AXIS_PTS":       ParseAxisPts(); break;
                        case "MEMORY_SEGMENT": ParseMemSeg(); break;
                        case "MOD_COMMON":     ParseModCommon(); break;
                        default:               SkipBlock(kw); break;
                    }
                }
                catch { /* one malformed block must not abort the whole parse — keep scanning */ }
            }
        }

        private void SkipBlock(string kw)
        {
            int depth = 1;
            while (_p < _t.Count && depth > 0)
            {
                string t = _t[_p++];
                if (t == "/begin") depth++;
                else if (t == "/end") { _p++; depth--; }   // consume the block name after /end
            }
        }

        // token cursor helpers (skip nothing; A2L is positional within a block)
        private string T() => _p < _t.Count ? _t[_p++] : "";
        private string PeekT() => _p < _t.Count ? _t[_p] : "";
        private bool AtBegin() => PeekT() == "/begin";
        private bool AtEnd() => PeekT() == "/end";

        private static double D(string t) => ParseNum(Str(t));
        private static uint   U(string t) => ParseUInt(Str(t));
        private static int    I(string t) => (int)ParseUInt(Str(t));

        private void EndBlock() { if (PeekT() == "/end") { _p++; if (_p < _t.Count) _p++; } }

        private void ParseCompuMethod()
        {
            var m = new RawCompuMethod { Name = Str(T()), Type = "" };
            m.Type = Str(T());
            // wait — ASAM order is: Name "Long" ConversionType "Format" "Unit"
            // The first token after Name is actually the LongIdentifier string.
            // Re-read correctly:
            // (we already consumed Name and one token as Type; fix by treating that as Long)
            string longId = m.Type;
            m.Type = Str(T());
            m.Format = Str(T());
            m.Unit = Str(T());
            while (!AtEnd() && _p < _t.Count)
            {
                string k = PeekT();
                if (k == "/begin") { _p++; SkipBlock(Str(T())); continue; }
                _p++;
                switch (k)
                {
                    case "COEFFS":
                        m.Coeffs = new double[6];
                        for (int j = 0; j < 6; j++) m.Coeffs[j] = D(T());
                        break;
                    case "COEFFS_LINEAR":
                        m.CoeffsLinear = new[] { D(T()), D(T()) };
                        break;
                    case "COMPU_TAB_REF":
                        m.CompuTabRef = Str(T());
                        break;
                    case "FORMULA":
                        // FORMULA "<expr>" [FORMULA_INV "<expr>"]  — may be a block or inline
                        m.Formula = Str(T());
                        break;
                    default: break; // ignore other optional params (REF_UNIT, etc.)
                }
            }
            EndBlock();
            if (!_cm.ContainsKey(m.Name)) _cm[m.Name] = m;
        }

        private void ParseCompuTab(bool verbal)
        {
            var t = new RawCompuTab { Name = Str(T()) };
            Str(T()); // long id
            t.Type = Str(T());
            int pairs = I(T());
            for (int j = 0; j < pairs && !AtEnd(); j++)
            {
                double inv = D(T());
                string outTok = T();
                if (verbal) t.Verbal[(long)Math.Round(inv)] = Str(outTok);
                else t.Numeric.Add((inv, D(outTok)));
            }
            // consume any trailing DEFAULT_VALUE etc.
            while (!AtEnd() && _p < _t.Count) { if (PeekT() == "/begin") { _p++; SkipBlock(Str(T())); } else _p++; }
            EndBlock();
            if (!_ct.ContainsKey(t.Name)) _ct[t.Name] = t;
        }

        private void ParseRecordLayout()
        {
            var r = new RawRecordLayout { Name = Str(T()) };
            while (!AtEnd() && _p < _t.Count)
            {
                string k = PeekT();
                if (k == "/begin") { _p++; SkipBlock(Str(T())); continue; }
                _p++;
                switch (k)
                {
                    case "FNC_VALUES":   I(T()); r.FncDataType = Str(T()); /* IndexMode AddrType */ SkipToKnownOrEnd(); break;
                    case "AXIS_PTS_X":   I(T()); r.AxisXDataType = Str(T()); SkipToKnownOrEnd(); break;
                    case "AXIS_PTS_Y":   I(T()); r.AxisYDataType = Str(T()); SkipToKnownOrEnd(); break;
                    default: break;
                }
            }
            EndBlock();
            if (!_rl.ContainsKey(r.Name)) _rl[r.Name] = r;
        }

        // After reading the meaningful fields of a record-layout sub-entry, swallow the
        // remaining tokens of that entry (index mode / addressing type words) up to the
        // next known keyword or /end.
        private void SkipToKnownOrEnd()
        {
            string[] known = { "FNC_VALUES", "AXIS_PTS_X", "AXIS_PTS_Y", "AXIS_PTS_Z",
                               "NO_AXIS_PTS_X", "NO_AXIS_PTS_Y", "SRC_ADDR_X", "SRC_ADDR_Y",
                               "RIP_ADDR_W", "ALIGNMENT_BYTE", "ALIGNMENT_WORD", "ALIGNMENT_LONG",
                               "ALIGNMENT_FLOAT32_IEEE", "ALIGNMENT_FLOAT64_IEEE" };
            while (!AtEnd() && _p < _t.Count)
            {
                string p = PeekT();
                if (p == "/begin" || p == "/end") return;
                if (known.Contains(p)) return;
                // stop if it looks like the next entry keyword (all-caps with underscore)
                if (p.Length > 3 && p == p.ToUpperInvariant() && p.Contains("_")) return;
                _p++;
            }
        }

        private void ParseCharacteristic()
        {
            var c = new RawCharacteristic();
            c.Name = Str(T());
            c.Long = Str(T());
            c.Type = Str(T());
            c.Address = U(T());
            c.RecordLayout = Str(T());
            D(T());                       // MaxDiff
            c.CompuMethod = Str(T());
            c.Lower = D(T());
            c.Upper = D(T());
            while (!AtEnd() && _p < _t.Count)
            {
                string k = PeekT();
                if (k == "/begin")
                {
                    _p++; string bk = Str(T());
                    if (bk == "AXIS_DESCR") c.Axes.Add(ParseAxisDescr());
                    else SkipBlock(bk);
                    continue;
                }
                _p++;
                switch (k)
                {
                    case "BIT_MASK":   c.BitMask = Str(T()); break;
                    case "FORMAT":     c.Format = Str(T()); break;
                    case "NUMBER":     c.Number = I(T()); break;
                    case "MATRIX_DIM": c.MatrixDim = ReadMatrixDim(); break;
                    default: break;
                }
            }
            EndBlock();
            _ch.Add(c);
        }

        private int[] ReadMatrixDim()
        {
            // MATRIX_DIM x y z  (older) or a bracketed list — read up to 3 integers
            var dims = new List<int>();
            while (dims.Count < 3 && _p < _t.Count)
            {
                string p = PeekT();
                if (p == "/begin" || p == "/end") break;
                if (long.TryParse(Str(p), out _)) { dims.Add(I(T())); }
                else break;
            }
            return dims.ToArray();
        }

        private RawAxisDescr ParseAxisDescr()
        {
            var a = new RawAxisDescr();
            a.Attribute = Str(T());
            Str(T());                     // InputQuantity (measurement name or NO_INPUT_QUANTITY)
            a.CompuMethod = Str(T());
            a.MaxAxisPoints = I(T());
            a.Lower = D(T());
            a.Upper = D(T());
            while (!AtEnd() && _p < _t.Count)
            {
                string k = PeekT();
                if (k == "/begin") { _p++; SkipBlock(Str(T())); continue; }
                _p++;
                switch (k)
                {
                    case "AXIS_PTS_REF": a.AxisPtsRef = Str(T()); break;
                    case "FIX_AXIS_PAR_DIST": a.FixDist = new[] { D(T()), D(T()), D(T()) }; break;
                    case "FIX_AXIS_PAR":
                        // ASAM FIX_AXIS_PAR is  Offset, Shift, N  with spacing 2^Shift (NOT linear
                        // Shift).  Fold it into the linear (offset, distance, n) form used by BuildAxis.
                        { double off = D(T()), shift = D(T()), nn = D(T()); a.FixDist = new[] { off, Math.Pow(2, shift), nn }; }
                        break;
                    case "FIX_AXIS_PAR_LIST":
                        var lst = new List<double>();
                        while (!AtEnd() && PeekT() != "/begin" && long.TryParse(Str(PeekT()), NumberStyles.Any, CultureInfo.InvariantCulture, out _) == false
                               ? double.TryParse(Str(PeekT()), NumberStyles.Any, CultureInfo.InvariantCulture, out _) : true)
                        {
                            if (AtEnd() || PeekT() == "/begin") break;
                            if (!double.TryParse(Str(PeekT()), NumberStyles.Any, CultureInfo.InvariantCulture, out var dv)) break;
                            lst.Add(dv); _p++;
                        }
                        a.FixList = lst.ToArray();
                        break;
                    default: break;
                }
            }
            EndBlock();
            return a;
        }

        private void ParseAxisPts()
        {
            var a = new RawAxisPts();
            a.Name = Str(T());
            a.Long = Str(T());
            a.Address = U(T());
            Str(T());                     // InputQuantity
            a.RecordLayout = Str(T());
            D(T());                       // MaxDiff
            a.CompuMethod = Str(T());
            a.MaxAxisPoints = I(T());
            a.Lower = D(T());
            a.Upper = D(T());
            while (!AtEnd() && _p < _t.Count) { if (PeekT() == "/begin") { _p++; SkipBlock(Str(T())); } else _p++; }
            EndBlock();
            if (!_ap.ContainsKey(a.Name)) _ap[a.Name] = a;
        }

        private void ParseMemSeg()
        {
            var s = new RawMemSeg { Name = Str(T()) };
            Str(T());                     // long id
            Str(T());                     // PrgType
            Str(T());                     // MemoryType
            Str(T());                     // Attribute
            s.Address = U(T());
            s.Size = U(T());
            while (!AtEnd() && _p < _t.Count) { if (PeekT() == "/begin") { _p++; SkipBlock(Str(T())); } else _p++; }
            EndBlock();
            _seg.Add(s);
        }

        private void ParseModCommon()
        {
            Str(T());                     // comment
            while (!AtEnd() && _p < _t.Count)
            {
                string k = PeekT();
                if (k == "/begin") { _p++; SkipBlock(Str(T())); continue; }
                _p++;
                if (k == "BYTE_ORDER")
                {
                    string ord = Str(T());
                    _byteOrder = ord.IndexOf("MSB_FIRST", StringComparison.OrdinalIgnoreCase) >= 0
                                 ? CalEndian.Big : CalEndian.Little;
                }
            }
            EndBlock();
        }

        // ── pass 2: resolve + build ─────────────────────────────────────────────────
        private CalProject Build(string name, string path)
        {
            var proj = new CalProject { Name = name, Source = CalProject.SourceKind.A2L, SourcePath = path,
                                        DefaultEndian = _byteOrder, SubtractBase = true };

            // Base address = flash origin (smallest non-zero MEMORY_SEGMENT), else inferred.
            if (_seg.Count > 0)
            {
                var origin = _seg.Where(s => s.Size > 0).OrderBy(s => s.Address).FirstOrDefault();
                if (origin != null) { proj.BaseAddress = origin.Address; proj.ExpectedImageSize = origin.Size; }
            }
            if (proj.BaseAddress == 0 && _ch.Count > 0)
            {
                uint minAddr = _ch.Min(c => c.Address);
                proj.BaseAddress = minAddr & ~0xFFFFu;   // round down to 64 KB boundary as a sane default
            }

            foreach (var c in _ch)
            {
                var tbl = BuildTable(c);
                if (tbl != null) proj.Tables.Add(tbl);
            }

            // Surface standalone AXIS_PTS as editable curves too (handy for shared axes).
            foreach (var ap in _ap.Values)
            {
                var ax = BuildAxisFromPts(ap);
                if (ax == null) continue;
                proj.Tables.Add(new CalTable
                {
                    Name = ap.Name, Title = string.IsNullOrEmpty(ap.Long) ? ap.Name : ap.Long,
                    Kind = CalTableKind.Axis, Address = ap.Address, DataType = ax.DataType, Endian = ax.Endian,
                    Columns = ax.Count, Rows = 1, Conversion = ax.Conversion, Units = ax.Units,
                    Min = ap.Lower, Max = ap.Upper, Categories = { "Axes" }
                });
            }

            return proj;
        }

        private CalConversion ResolveConversion(string compuMethodName)
        {
            if (string.IsNullOrEmpty(compuMethodName) || compuMethodName == "NO_COMPU_METHOD") return CalConversion.Identity;
            if (!_cm.TryGetValue(compuMethodName, out var m)) return CalConversion.Identity;
            string fmt = CalConversion.A2lFormatToNet(m.Format);
            switch ((m.Type ?? "").ToUpperInvariant())
            {
                case "IDENTICAL": { var cv = CalConversion.MakeLinear(1, 0, m.Unit, fmt); return cv; }
                case "LINEAR":    return CalConversion.MakeLinear(m.CoeffsLinear?[0] ?? 1, m.CoeffsLinear?[1] ?? 0, m.Unit, fmt);
                case "RAT_FUNC":  return CalConversion.MakeRatFunc(m.Coeffs, m.Unit, fmt);
                case "FORM":      return CalConversion.MakeFormula(m.Formula ?? "X", m.Unit, fmt);
                case "TAB_VERB":
                    if (m.CompuTabRef != null && _ct.TryGetValue(m.CompuTabRef, out var vt))
                        return CalConversion.MakeVerbal(vt.Verbal, m.Unit);
                    return CalConversion.Identity;
                case "TAB_INTP":
                case "TAB_NOINTP":
                    // numeric interpolation table — approximate as identity with unit (rare on cal maps)
                    return CalConversion.MakeLinear(1, 0, m.Unit, fmt);
                default: return CalConversion.MakeLinear(1, 0, m.Unit, fmt);
            }
        }

        private CalTable BuildTable(RawCharacteristic c)
        {
            CalDataType zType = CalDataType.U8;
            if (c.RecordLayout != null && _rl.TryGetValue(c.RecordLayout, out var rl) && rl.FncDataType != null)
                zType = CalDataTypeInfo.FromA2l(rl.FncDataType);

            var conv = ResolveConversion(c.CompuMethod);
            var tbl = new CalTable
            {
                Name = c.Name,
                Title = string.IsNullOrEmpty(c.Long) ? c.Name : c.Long,
                Description = c.Long,
                Address = c.Address,
                DataType = zType,
                Endian = _byteOrder,
                Conversion = conv,
                Units = conv.Units,
                DisplayFormat = conv.Format,
                Min = c.Lower, Max = c.Upper
            };
            if (!string.IsNullOrEmpty(c.BitMask)) tbl.BitMask = ParseUInt(c.BitMask);

            switch ((c.Type ?? "VALUE").ToUpperInvariant())
            {
                case "VALUE":
                    tbl.Kind = CalTableKind.Scalar; tbl.Columns = 1; tbl.Rows = 1; break;
                case "ASCII":
                    tbl.Kind = CalTableKind.Ascii; tbl.Columns = Math.Max(1, c.Number); tbl.Rows = 1; break;
                case "VAL_BLK":
                {
                    // MATRIX_DIM (when present) is authoritative for the shape.  NUMBER is the
                    // deprecated *total* element count and is only a 1-D fallback — using it as
                    // the column count alongside MATRIX_DIM's row count over-sizes the table and
                    // would read/write past the real block into neighbouring data.
                    bool hasMatrix = c.MatrixDim != null && c.MatrixDim.Length > 0 && c.MatrixDim[0] > 0;
                    int n    = hasMatrix ? c.MatrixDim[0] : (c.Number > 0 ? c.Number : 1);
                    int rows = hasMatrix && c.MatrixDim.Length > 1 && c.MatrixDim[1] > 1 ? c.MatrixDim[1] : 1;
                    tbl.Kind = rows > 1 ? CalTableKind.Map : CalTableKind.Array;
                    tbl.Columns = n; tbl.Rows = rows; break;
                }
                case "CURVE":
                    tbl.Kind = CalTableKind.Curve;
                    tbl.XAxis = c.Axes.Count > 0 ? BuildAxis(c.Axes[0]) : CalAxis.Index(1);
                    tbl.Columns = tbl.XAxis.Count; tbl.Rows = 1; break;
                case "MAP":
                    tbl.Kind = CalTableKind.Map;
                    tbl.XAxis = c.Axes.Count > 0 ? BuildAxis(c.Axes[0]) : CalAxis.Index(1);
                    tbl.YAxis = c.Axes.Count > 1 ? BuildAxis(c.Axes[1]) : CalAxis.Index(1);
                    tbl.Columns = tbl.XAxis.Count; tbl.Rows = tbl.YAxis.Count; break;
                default:
                    tbl.Kind = CalTableKind.Scalar; tbl.Columns = 1; tbl.Rows = 1; break;
            }

            tbl.Risk = CalRisk.Classify(tbl.Name, tbl.Title, tbl.Units);
            CalCategoriser.Assign(tbl);
            return tbl;
        }

        private CalAxis BuildAxis(RawAxisDescr ad)
        {
            var conv = ResolveConversion(ad.CompuMethod);
            // Shared axis via AXIS_PTS_REF (the common, well-supported case).
            if (!string.IsNullOrEmpty(ad.AxisPtsRef) && _ap.TryGetValue(ad.AxisPtsRef, out var ap))
            {
                var ax = BuildAxisFromPts(ap);
                if (ax != null) { ax.Min = ad.Lower; ax.Max = ad.Upper; if (ad.MaxAxisPoints > 0) ax.Count = ad.MaxAxisPoints; return ax; }
            }
            // Fixed axis (computed, not stored in image).
            if (ad.FixDist != null)
            {
                int n = (int)ad.FixDist[2];
                if (n <= 0) n = Math.Max(1, ad.MaxAxisPoints);
                if (n > 4096) n = 4096;   // cap a corrupt axis-point count → no OutOfMemory in Enumerable.Range
                var vals = Enumerable.Range(0, n).Select(i => ad.FixDist[0] + i * ad.FixDist[1]).ToArray();
                return new CalAxis { Name = "Axis", Units = conv.Units, Count = n, IsEmbedded = false,
                                     StaticValues = vals, Min = ad.Lower, Max = ad.Upper, Conversion = conv };
            }
            if (ad.FixList != null && ad.FixList.Length > 0)
                return new CalAxis { Name = "Axis", Units = conv.Units, Count = ad.FixList.Length, IsEmbedded = false,
                                     StaticValues = ad.FixList, Min = ad.Lower, Max = ad.Upper, Conversion = conv };
            // STD_AXIS embedded in the characteristic's own block isn't resolved here — fall back
            // to an index axis so the table still opens and edits correctly on its z-data.
            int idxN = Math.Min(Math.Max(1, ad.MaxAxisPoints), 4096);   // cap a corrupt point count
            return new CalAxis { Name = "Index", Units = conv.Units, Count = idxN,
                                 IsEmbedded = false, StaticValues = Enumerable.Range(0, idxN).Select(i => (double)i).ToArray(),
                                 Min = ad.Lower, Max = ad.Upper, Conversion = CalConversion.Identity };
        }

        private CalAxis BuildAxisFromPts(RawAxisPts ap)
        {
            if (ap == null) return null;
            CalDataType dt = CalDataType.U16;
            if (ap.RecordLayout != null && _rl.TryGetValue(ap.RecordLayout, out var rl) && rl.AxisXDataType != null)
                dt = CalDataTypeInfo.FromA2l(rl.AxisXDataType);
            var conv = ResolveConversion(ap.CompuMethod);
            return new CalAxis
            {
                Name = ap.Name, Units = conv.Units, Count = Math.Max(1, ap.MaxAxisPoints),
                IsEmbedded = true, Address = ap.Address, DataType = dt, Endian = _byteOrder,
                Conversion = conv, Min = ap.Lower, Max = ap.Upper
            };
        }

        // ── numeric + encoding helpers ──────────────────────────────────────────────
        private static double ParseNum(string s)
        {
            s = (s ?? "").Trim();
            // Non-throwing hex parse: Convert.ToInt64 throws FormatException on bad hex and
            // OverflowException on a full 64-bit value (e.g. 0xFFFFFFFFFFFFFFFF) — TryParse can't.
            if (s.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
                return ulong.TryParse(s.Substring(2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var hx) ? (double)hx : 0;
            return double.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out var v) ? v : 0;
        }
        private static uint ParseUInt(string s)
        {
            s = (s ?? "").Trim();
            if (s.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
                return ulong.TryParse(s.Substring(2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var hx) ? (uint)hx : 0u;
            if (uint.TryParse(s, out var v)) return v;
            return (uint)(long)ParseNum(s);
        }

        // A2L files arrive as UTF-8 (with or without BOM) or — for a lot of older European
        // tooling (BMW/Bosch especially) — Windows-1252 / Latin-1.  Reading a 1252 file as
        // UTF-8 turns every umlaut (Ü ä ö ß ° µ …) into U+FFFD '?', mangling the parameter
        // names shown in the tree.  So honour a BOM, otherwise try strict UTF-8 and fall back
        // to code page 1252 the instant an invalid byte appears.
        private static string DecodeBytes(byte[] raw)
        {
            if (raw == null || raw.Length == 0) return "";
            if (raw.Length >= 3 && raw[0] == 0xEF && raw[1] == 0xBB && raw[2] == 0xBF)
                return new UTF8Encoding(false).GetString(raw, 3, raw.Length - 3);
            if (raw.Length >= 2 && raw[0] == 0xFF && raw[1] == 0xFE)
                return Encoding.Unicode.GetString(raw, 2, raw.Length - 2);          // UTF-16 LE
            if (raw.Length >= 2 && raw[0] == 0xFE && raw[1] == 0xFF)
                return Encoding.BigEndianUnicode.GetString(raw, 2, raw.Length - 2); // UTF-16 BE
            try
            {
                return new UTF8Encoding(false, throwOnInvalidBytes: true).GetString(raw);
            }
            catch (DecoderFallbackException)
            {
                return Encoding.GetEncoding(1252).GetString(raw);                   // Windows Latin-1
            }
        }
    }
}
