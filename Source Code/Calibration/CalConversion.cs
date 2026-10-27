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
//  CalConversion.cs — raw <-> physical scaling.  This is the correctness-critical core:
//  display reads RawToPhys, every edit writes PhysToRaw, and getting either wrong silently
//  corrupts a map.  Every conversion family is inverted ANALYTICALLY where the maths allow
//  it (Identity, Linear, the linear-rational RAT_FUNC case, affine formulas) and falls back
//  to a bracketed bisection only for genuinely non-linear formulas.
//
//  ASAM RAT_FUNC convention (COEFFS a b c d e f) defines INTERNAL as a function of PHYSICAL:
//        INT = (a·P² + b·P + c) / (d·P² + e·P + f)
//  so PhysToRaw (writing) just evaluates that rational directly — exact for any coefficients.
//  RawToPhys (display) inverts it; for the near-universal a=d=0 case the inverse is exact:
//        P = (f·X − c) / (b − e·X)        (X = internal/raw)
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace TesterPresent.OBD2.Calibration
{
    public enum CalConvKind { Identity, Linear, RatFunc, Formula, Verbal }

    public sealed class CalConversion
    {
        public CalConvKind Kind   { get; private set; } = CalConvKind.Identity;
        public string      Units  { get; set; } = "";
        public string      Format { get; set; } = "0.###";

        // Linear: phys = A·raw + B
        public double A { get; private set; } = 1.0;
        public double B { get; private set; } = 0.0;

        // RatFunc: COEFFS [a b c d e f]  (INT = rational(PHYS))
        public double[] Coeffs { get; private set; }

        // Formula (XDF MATH / A2L FORM): physical = f(raw)
        public ExpressionEvaluator Expr { get; private set; }
        private bool   _exprAffine;
        private double _exprSlope, _exprIntercept;

        // Verbal table (TAB_VERB / enum): raw value -> text label
        public Dictionary<long, string> Labels { get; private set; }

        public static readonly CalConversion Identity = new CalConversion { Kind = CalConvKind.Identity };

        public static CalConversion MakeIdentity(string units = "", string fmt = "0.###")
            => new CalConversion { Kind = CalConvKind.Identity, Units = units ?? "", Format = fmt };

        public bool IsVerbal => Kind == CalConvKind.Verbal && Labels != null && Labels.Count > 0;

        // ── Factories ──────────────────────────────────────────────────────────────
        public static CalConversion MakeLinear(double a, double b, string units = "", string fmt = "0.###")
            => new CalConversion { Kind = CalConvKind.Linear, A = a, B = b, Units = units, Format = fmt };

        public static CalConversion MakeRatFunc(double[] coeffs, string units = "", string fmt = "0.###")
        {
            if (coeffs == null || coeffs.Length < 6)
                return MakeLinear(1, 0, units, fmt);
            // Collapse the trivial identity rational (0 0 1 0 0 1 → INT = P) to Identity.
            if (coeffs[0] == 0 && coeffs[3] == 0 && coeffs[4] == 0 &&
                coeffs[1] == 1 && coeffs[2] == 0 && coeffs[5] == 1)
                return new CalConversion { Kind = CalConvKind.Identity, Units = units, Format = fmt };
            return new CalConversion { Kind = CalConvKind.RatFunc, Coeffs = coeffs, Units = units, Format = fmt };
        }

        public static CalConversion MakeFormula(string equation, string units = "", string fmt = "0.###")
        {
            var e = ExpressionEvaluator.Parse(equation);
            var c = new CalConversion { Kind = CalConvKind.Formula, Expr = e, Units = units, Format = fmt };
            c._exprAffine = e.TryGetAffine(out c._exprSlope, out c._exprIntercept);
            // An affine formula is just a linear conversion — normalise so PhysToRaw is exact.
            if (c._exprAffine && Math.Abs(c._exprSlope) > 1e-300)
                return new CalConversion { Kind = CalConvKind.Linear, A = c._exprSlope, B = c._exprIntercept, Units = units, Format = fmt };
            return c;
        }

        public static CalConversion MakeVerbal(Dictionary<long, string> labels, string units = "")
            => new CalConversion { Kind = CalConvKind.Verbal, Labels = labels ?? new Dictionary<long, string>(), Units = units };

        // ── raw -> physical (display) ───────────────────────────────────────────────
        public double RawToPhys(double raw)
        {
            switch (Kind)
            {
                case CalConvKind.Identity: return raw;
                case CalConvKind.Linear:   return A * raw + B;
                case CalConvKind.Verbal:   return raw;
                case CalConvKind.Formula:  return Expr != null && Expr.IsValid ? Expr.Eval(raw) : raw;
                case CalConvKind.RatFunc:
                {
                    if (Coeffs == null || Coeffs.Length < 6) return raw;
                    double a = Coeffs[0], b = Coeffs[1], c = Coeffs[2], d = Coeffs[3], e = Coeffs[4], f = Coeffs[5];
                    if (a == 0 && d == 0)
                    {
                        double den = b - e * raw;
                        return Math.Abs(den) < 1e-300 ? double.NaN : (f * raw - c) / den;
                    }
                    // General quadratic rational: invert numerically (rare path).
                    return InvertNumeric(raw, -1e12, 1e12);
                }
                default: return raw;
            }
        }

        // ── physical -> raw (write) ─────────────────────────────────────────────────
        // rawMin/rawMax are the storage type's representable range, used only to bracket the
        // numeric inverse for non-linear formulas.  Linear/rational inverses are analytic.
        public double PhysToRaw(double phys, double rawMin, double rawMax)
        {
            switch (Kind)
            {
                case CalConvKind.Identity: return phys;
                case CalConvKind.Linear:   return Math.Abs(A) < 1e-300 ? 0 : (phys - B) / A;
                case CalConvKind.Verbal:   return phys;
                case CalConvKind.RatFunc:
                {
                    // INT = (a·P² + b·P + c) / (d·P² + e·P + f) — exact.
                    if (Coeffs == null || Coeffs.Length < 6) return phys;
                    double a = Coeffs[0], b = Coeffs[1], c = Coeffs[2], d = Coeffs[3], e = Coeffs[4], f = Coeffs[5];
                    double num = a * phys * phys + b * phys + c;
                    double den = d * phys * phys + e * phys + f;
                    return Math.Abs(den) < 1e-300 ? 0 : num / den;
                }
                case CalConvKind.Formula:
                {
                    if (_exprAffine && Math.Abs(_exprSlope) > 1e-300)
                        return (phys - _exprIntercept) / _exprSlope;
                    return InvertNumericToRaw(phys, rawMin, rawMax);
                }
                default: return phys;
            }
        }

        /// <summary>Bisection inverse of RawToPhys over a raw bracket (for non-linear formulas).</summary>
        private double InvertNumericToRaw(double targetPhys, double lo, double hi)
        {
            double flo = RawToPhys(lo) - targetPhys;
            double fhi = RawToPhys(hi) - targetPhys;
            if (double.IsNaN(flo) || double.IsNaN(fhi)) return lo;
            if (flo == 0) return lo;
            if (fhi == 0) return hi;
            if (Math.Sign(flo) == Math.Sign(fhi))
            {
                // Not bracketed (non-monotonic / out of range) — pick the nearer endpoint.
                return Math.Abs(flo) <= Math.Abs(fhi) ? lo : hi;
            }
            for (int i = 0; i < 60; i++)
            {
                double mid = 0.5 * (lo + hi);
                double fm = RawToPhys(mid) - targetPhys;
                if (Math.Abs(fm) < 1e-9 || (hi - lo) < 1e-9) return mid;
                if (Math.Sign(fm) == Math.Sign(flo)) { lo = mid; flo = fm; }
                else { hi = mid; }
            }
            return 0.5 * (lo + hi);
        }

        private double InvertNumeric(double targetRaw, double lo, double hi)
        {
            // Invert the RAT_FUNC forward map g(P)=raw for P, by bisection on PhysToRaw.
            double flo = PhysToRaw(lo, 0, 0) - targetRaw;
            double fhi = PhysToRaw(hi, 0, 0) - targetRaw;
            if (Math.Sign(flo) == Math.Sign(fhi)) return Math.Abs(flo) <= Math.Abs(fhi) ? lo : hi;
            for (int i = 0; i < 80; i++)
            {
                double mid = 0.5 * (lo + hi);
                double fm = PhysToRaw(mid, 0, 0) - targetRaw;
                if (Math.Abs(fm) < 1e-9) return mid;
                if (Math.Sign(fm) == Math.Sign(flo)) { lo = mid; flo = fm; }
                else hi = mid;
            }
            return 0.5 * (lo + hi);
        }

        /// <summary>Render a physical value for display (enum label when verbal).</summary>
        public string FormatValue(double phys)
        {
            if (IsVerbal)
            {
                long key = (long)Math.Round(phys);
                if (Labels.TryGetValue(key, out var s)) return s;
                return key.ToString(CultureInfo.InvariantCulture);
            }
            try { return phys.ToString(Format ?? "0.###", CultureInfo.InvariantCulture); }
            catch { return phys.ToString("0.###", CultureInfo.InvariantCulture); }
        }

        /// <summary>Convert an A2L %-style C printf FORMAT ("%8.3f") into a .NET numeric format.</summary>
        public static string A2lFormatToNet(string a2lFormat)
        {
            if (string.IsNullOrWhiteSpace(a2lFormat)) return "0.###";
            // "%[width].[prec]f"  ->  show 'prec' decimals
            int dot = a2lFormat.IndexOf('.');
            if (dot >= 0 && dot + 1 < a2lFormat.Length)
            {
                var digits = new string(a2lFormat.Skip(dot + 1).TakeWhile(char.IsDigit).ToArray());
                if (int.TryParse(digits, out var prec))
                    return prec <= 0 ? "0" : "0." + new string('0', prec);
            }
            return "0.###";
        }
    }
}
