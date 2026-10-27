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
//  ExpressionEvaluator.cs — a small, fast recursive-descent evaluator for TunerPro XDF
//  MATH equations (and any "physical = f(X)" scaling string).
//
//  Supports: + - * / % ^ , parentheses, unary minus, the variable X (case-insensitive),
//  numeric literals (incl. 0x hex and scientific notation), and the functions
//  abs round trunc floor ceil sqrt exp ln log log10 sin cos tan min max pow.
//
//  Equations are parsed once into a tiny AST and then evaluated per cell, so painting a
//  256-cell map is cheap.  The evaluator is also used to detect whether an equation is
//  affine in X (the overwhelmingly common case) so CalConversion can invert it exactly.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Globalization;

namespace TesterPresent.OBD2.Calibration
{
    public sealed class ExpressionEvaluator
    {
        private readonly string _src;
        private readonly Node _root;
        public string Source => _src;
        public bool   IsValid { get; }
        public string Error   { get; private set; }

        private ExpressionEvaluator(string src, Node root, bool valid)
        {
            _src = src; _root = root; IsValid = valid;
        }

        public static ExpressionEvaluator Parse(string equation)
        {
            try
            {
                var p = new Parser(equation ?? "X");
                var root = p.ParseExpression();
                p.ExpectEnd();
                return new ExpressionEvaluator(equation ?? "X", root, true);
            }
            catch (Exception ex)
            {
                return new ExpressionEvaluator(equation ?? "X", new ConstNode(double.NaN), false)
                    { Error = ex.Message };
            }
        }

        public double Eval(double x) => _root.Eval(x);

        /// <summary>
        /// If the equation is affine in X (f(X) = slope·X + intercept), return true and the
        /// coefficients.  Detected by sampling three points and confirming linearity, which
        /// is exact for any polynomial of degree ≤1 and the only family TunerPro/A2L linear
        /// scalings ever use.
        /// </summary>
        public bool TryGetAffine(out double slope, out double intercept)
        {
            slope = 0; intercept = 0;
            if (!IsValid) return false;
            double f0 = _root.Eval(0), f1 = _root.Eval(1);
            if (double.IsNaN(f0) || double.IsNaN(f1)) return false;
            double s = f1 - f0;
            // Confirm the SAME slope holds at several probes — including non-integers and a large
            // value — so step / periodic / wrapping functions (round, floor, X%256, sin…) that merely
            // line up on {0,1,2} are NOT mistaken for linear and then inverted wrongly on write-back.
            double[] xs = { -3.5, 0.5, 2.25, 7.0, 31.7, 300.0, 1000.0 };
            foreach (double x in xs)
            {
                double fx = _root.Eval(x);
                if (double.IsNaN(fx)) return false;
                double expect = f0 + s * x;
                if (Math.Abs(fx - expect) > 1e-6 * (1 + Math.Abs(expect))) return false; // not affine
            }
            slope = s; intercept = f0;
            return true;
        }

        // ── AST ──────────────────────────────────────────────────────────────────
        private abstract class Node { public abstract double Eval(double x); }

        private sealed class ConstNode : Node
        {
            private readonly double _v; public ConstNode(double v) { _v = v; }
            public override double Eval(double x) => _v;
        }
        private sealed class VarNode : Node
        {
            public override double Eval(double x) => x;
        }
        private sealed class UnaryNode : Node
        {
            private readonly Node _a; private readonly char _op;
            public UnaryNode(char op, Node a) { _op = op; _a = a; }
            public override double Eval(double x) => _op == '-' ? -_a.Eval(x) : _a.Eval(x);
        }
        private sealed class BinNode : Node
        {
            private readonly Node _a, _b; private readonly char _op;
            public BinNode(char op, Node a, Node b) { _op = op; _a = a; _b = b; }
            public override double Eval(double x)
            {
                double a = _a.Eval(x), b = _b.Eval(x);
                switch (_op)
                {
                    case '+': return a + b;
                    case '-': return a - b;
                    case '*': return a * b;
                    case '/': return b == 0 ? double.NaN : a / b;
                    case '%': return b == 0 ? double.NaN : a % b;
                    case '^': return Math.Pow(a, b);
                    default:  return double.NaN;
                }
            }
        }
        private sealed class FuncNode : Node
        {
            private readonly string _name; private readonly List<Node> _args;
            public FuncNode(string name, List<Node> args) { _name = name; _args = args; }
            public override double Eval(double x)
            {
                double A(int i) => i < _args.Count ? _args[i].Eval(x) : double.NaN;
                switch (_name)
                {
                    case "abs":   return Math.Abs(A(0));
                    case "round": return Math.Round(A(0), MidpointRounding.AwayFromZero);
                    case "trunc": return Math.Truncate(A(0));
                    case "floor": return Math.Floor(A(0));
                    case "ceil":  return Math.Ceiling(A(0));
                    case "sqrt":  return Math.Sqrt(A(0));
                    case "exp":   return Math.Exp(A(0));
                    case "ln":    return Math.Log(A(0));
                    case "log":   return Math.Log(A(0));
                    case "log10": return Math.Log10(A(0));
                    case "sin":   return Math.Sin(A(0));
                    case "cos":   return Math.Cos(A(0));
                    case "tan":   return Math.Tan(A(0));
                    case "min":   return Math.Min(A(0), A(1));
                    case "max":   return Math.Max(A(0), A(1));
                    case "pow":   return Math.Pow(A(0), A(1));
                    default:      return double.NaN;
                }
            }
        }

        // ── Parser ───────────────────────────────────────────────────────────────
        private sealed class Parser
        {
            private readonly string _s; private int _i;
            public Parser(string s) { _s = s ?? ""; _i = 0; }

            private void Skip() { while (_i < _s.Length && char.IsWhiteSpace(_s[_i])) _i++; }
            private char Peek() { Skip(); return _i < _s.Length ? _s[_i] : '\0'; }
            private char Next() { Skip(); return _i < _s.Length ? _s[_i++] : '\0'; }

            public void ExpectEnd() { if (Peek() != '\0') throw new FormatException($"Unexpected '{Peek()}' at {_i}"); }

            // expression := term (('+'|'-') term)*
            public Node ParseExpression()
            {
                var n = ParseTerm();
                while (true)
                {
                    char c = Peek();
                    if (c == '+' || c == '-') { Next(); n = new BinNode(c, n, ParseTerm()); }
                    else return n;
                }
            }
            // term := unary (('*'|'/'|'%') unary)*
            private Node ParseTerm()
            {
                var n = ParseUnary();
                while (true)
                {
                    char c = Peek();
                    if (c == '*' || c == '/' || c == '%') { Next(); n = new BinNode(c, n, ParseUnary()); }
                    else return n;
                }
            }
            // unary := ('+'|'-') unary | power      (unary minus binds LOOSER than '^', so -X^2 = -(X^2))
            private Node ParseUnary()
            {
                char c = Peek();
                if (c == '+') { Next(); return ParseUnary(); }
                if (c == '-') { Next(); return new UnaryNode('-', ParseUnary()); }
                return ParsePower();
            }
            // power := primary ('^' unary)?         (right-associative; exponent may be signed, e.g. 2^-3)
            private Node ParsePower()
            {
                var n = ParsePrimary();
                if (Peek() == '^') { Next(); return new BinNode('^', n, ParseUnary()); }
                return n;
            }
            // primary := number | 'X' | func '(' args ')' | '(' expression ')'
            private Node ParsePrimary()
            {
                char c = Peek();
                if (c == '(')
                {
                    Next(); var e = ParseExpression();
                    if (Next() != ')') throw new FormatException("Expected ')'");
                    return e;
                }
                if (char.IsLetter(c) || c == '_')
                {
                    string id = ReadIdent();
                    if (id.Equals("X", StringComparison.OrdinalIgnoreCase)) return new VarNode();
                    if (id.Equals("pi", StringComparison.OrdinalIgnoreCase)) return new ConstNode(Math.PI);
                    if (id.Equals("e",  StringComparison.OrdinalIgnoreCase)) return new ConstNode(Math.E);
                    // function call
                    if (Peek() != '(') throw new FormatException($"Unknown identifier '{id}'");
                    Next();
                    var args = new List<Node>();
                    if (Peek() != ')')
                    {
                        args.Add(ParseExpression());
                        while (Peek() == ',') { Next(); args.Add(ParseExpression()); }
                    }
                    if (Next() != ')') throw new FormatException("Expected ')' after function args");
                    return new FuncNode(id.ToLowerInvariant(), args);
                }
                return new ConstNode(ReadNumber());
            }

            private string ReadIdent()
            {
                Skip(); int start = _i;
                while (_i < _s.Length && (char.IsLetterOrDigit(_s[_i]) || _s[_i] == '_')) _i++;
                return _s.Substring(start, _i - start);
            }
            private double ReadNumber()
            {
                Skip(); int start = _i;
                if (_i + 1 < _s.Length && _s[_i] == '0' && (_s[_i + 1] == 'x' || _s[_i + 1] == 'X'))
                {
                    _i += 2; int hs = _i;
                    while (_i < _s.Length && Uri.IsHexDigit(_s[_i])) _i++;
                    // ulong.TryParse, not Convert.ToInt64: the latter throws OverflowException on a
                    // full 64-bit literal and FormatException on an empty "0x". A bad hex throws here
                    // (same handled path as a bad decimal → the outer Parse marks the formula invalid).
                    string hex = _s.Substring(hs, _i - hs);
                    if (!ulong.TryParse(hex, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var hv))
                        throw new FormatException($"Bad hex '0x{hex}'");
                    return (double)hv;
                }
                while (_i < _s.Length && (char.IsDigit(_s[_i]) || _s[_i] == '.' ||
                       _s[_i] == 'e' || _s[_i] == 'E' ||
                       ((_s[_i] == '+' || _s[_i] == '-') && _i > start && (_s[_i - 1] == 'e' || _s[_i - 1] == 'E'))))
                    _i++;
                string num = _s.Substring(start, _i - start);
                if (!double.TryParse(num, NumberStyles.Float, CultureInfo.InvariantCulture, out var v))
                    throw new FormatException($"Bad number '{num}'");
                return v;
            }
        }
    }
}
