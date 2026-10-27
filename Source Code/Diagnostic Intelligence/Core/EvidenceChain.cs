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
//  Tester Present Specialist Automotive Solutions — Evidence Chain (Primitive P3)
//
//  The core honesty primitive of the diagnostic intelligence layer.  Every
//  module builds an EvidenceChain as it reasons: an ordered list of steps, each
//  naming the signal it looked at, the value it observed, the range it expected,
//  and the verdict.  The chain renders to a human-readable walkthrough so a
//  technician can see WHY the module reached its hypothesis, not just WHAT it
//  concluded — and can disagree with any single step.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace TesterPresent.OBD2.Intelligence
{
    /// <summary>One reasoning step: what was observed, what was expected, the verdict.</summary>
    public sealed class EvidenceStep
    {
        public string Signal { get; set; }
        public string Observed { get; set; }
        public string Expected { get; set; }
        public EvidenceVerdict Verdict { get; set; }
        /// <summary>Free-text amplification — why this step matters, or a caveat.</summary>
        public string Detail { get; set; }
        public DateTime Utc { get; set; }

        public string VerdictGlyph
        {
            get
            {
                switch (Verdict)
                {
                    case EvidenceVerdict.Pass: return "PASS";
                    case EvidenceVerdict.Fail: return "FAIL";
                    case EvidenceVerdict.Inconclusive: return "----";
                    default: return "info";
                }
            }
        }
    }

    /// <summary>
    /// An ordered chain of evidence steps.  Fluent API — every Add returns the
    /// chain so a module can build it inline.  Thread-affine (build on one
    /// thread); not synchronised.
    /// </summary>
    public sealed class EvidenceChain
    {
        private readonly List<EvidenceStep> _steps = new List<EvidenceStep>();

        public IReadOnlyList<EvidenceStep> Steps => _steps;
        public int Count => _steps.Count;

        public int FailCount => _steps.Count(s => s.Verdict == EvidenceVerdict.Fail);
        public int PassCount => _steps.Count(s => s.Verdict == EvidenceVerdict.Pass);
        public int InconclusiveCount => _steps.Count(s => s.Verdict == EvidenceVerdict.Inconclusive);

        public EvidenceChain Add(string signal, string observed, string expected,
                                 EvidenceVerdict verdict, string detail = null)
        {
            _steps.Add(new EvidenceStep
            {
                Signal = signal ?? "",
                Observed = observed ?? "",
                Expected = expected ?? "",
                Verdict = verdict,
                Detail = detail,
                Utc = DateTime.UtcNow,
            });
            return this;
        }

        public EvidenceChain Pass(string signal, string observed, string expected, string detail = null)
            => Add(signal, observed, expected, EvidenceVerdict.Pass, detail);

        public EvidenceChain Fail(string signal, string observed, string expected, string detail = null)
            => Add(signal, observed, expected, EvidenceVerdict.Fail, detail);

        public EvidenceChain Inconclusive(string signal, string observed, string expected, string detail = null)
            => Add(signal, observed, expected, EvidenceVerdict.Inconclusive, detail);

        public EvidenceChain Info(string signal, string observed, string detail = null)
            => Add(signal, observed, "", EvidenceVerdict.Info, detail);

        /// <summary>Convenience for numeric observations with a tolerance band.</summary>
        public EvidenceChain Measure(string signal, double observed, double expectedLo, double expectedHi,
                                     string unit = "", string detail = null)
        {
            var verdict = (observed >= expectedLo && observed <= expectedHi)
                ? EvidenceVerdict.Pass : EvidenceVerdict.Fail;
            string u = string.IsNullOrEmpty(unit) ? "" : " " + unit;
            return Add(signal,
                       observed.ToString("0.###", CultureInfo.InvariantCulture) + u,
                       string.Format(CultureInfo.InvariantCulture, "{0:0.###}–{1:0.###}{2}", expectedLo, expectedHi, u),
                       verdict, detail);
        }

        /// <summary>Render the chain as an indented human-readable walkthrough.</summary>
        public string Render()
        {
            if (_steps.Count == 0) return "(no evidence recorded)";
            var sb = new StringBuilder();
            for (int i = 0; i < _steps.Count; i++)
            {
                var s = _steps[i];
                sb.Append('[').Append(s.VerdictGlyph).Append("]  ");
                sb.Append(s.Signal);
                if (!string.IsNullOrEmpty(s.Observed))
                {
                    sb.Append(" = ").Append(s.Observed);
                    if (!string.IsNullOrEmpty(s.Expected))
                        sb.Append("  (expected ").Append(s.Expected).Append(')');
                }
                if (!string.IsNullOrEmpty(s.Detail))
                    sb.Append("\n        ").Append(s.Detail);
                if (i < _steps.Count - 1) sb.Append('\n');
            }
            return sb.ToString();
        }

        public override string ToString() => Render();
    }
}
