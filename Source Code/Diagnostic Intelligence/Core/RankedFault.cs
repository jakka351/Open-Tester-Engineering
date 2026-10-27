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
//  Tester Present Specialist Automotive Solutions — Ranked Fault (M6 frontier projection)
//
//  M6's Bayesian engine ranks a full candidate set internally, but only the top
//  (and sometimes the second) escape as DiagnosticResults.  The Investigation Tree
//  (Intelligence/Session/) needs the WHOLE ranked frontier — every live hypothesis
//  with its posterior — so this is a public, lossless projection of M6's private
//  Candidate list.  It is a PROJECTION, not a redesign: the Bayes math stays in M6.
//
//  Honesty rule (from the reasoning-tree design): the tech-facing surface binds to
//  the coarse BAND (leading / contending / trailing / trailing-far) and the rank,
//  NEVER a raw percentage — a naive-Bayes posterior is a score, not a truth.  The
//  raw Posterior/NormShare are carried for internal ranking + a drill-down only.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;

namespace TesterPresent.OBD2.Intelligence
{
    /// <summary>One piece of independent evidence bearing on a ranked fault (public projection of M6's Contribution).</summary>
    public sealed class FaultContribution
    {
        public string Source { get; set; }      // "M1: Vacuum…", "DTC P0171 (confirmed)"
        public double Likelihood { get; set; }   // evidence likelihood [0.05, 0.95]
        public string Detail { get; set; }       // human amplification
    }

    /// <summary>
    /// A fault hypothesis in M6's ranked frontier, with its Bayes posterior and the
    /// evidence that raised it.  The Investigation Tree upserts one Hypothesis node
    /// per RankedFault, keyed by <see cref="FaultKey"/>.
    /// </summary>
    public sealed class RankedFault
    {
        public string FaultKey { get; set; }
        public string Label { get; set; }
        public double Prior { get; set; }
        public bool PriorFromHistory { get; set; }
        public double LogOdds { get; set; }
        /// <summary>Raw Bayes posterior — INTERNAL ranking + drill-down only, never the tech-facing number.</summary>
        public double Posterior { get; set; }
        /// <summary>Normalised share across the frontier — internal.</summary>
        public double NormShare { get; set; }
        /// <summary>1-based rank in the frontier at the moment of projection.</summary>
        public int Rank { get; set; }
        /// <summary>The tech-facing coarse band — bind the UI to THIS, not a percentage.</summary>
        public FaultBand Band { get; set; }
        public IReadOnlyList<FaultContribution> Contributions { get; set; } = Array.Empty<FaultContribution>();
        public IReadOnlyList<string> Suspects { get; set; } = Array.Empty<string>();
        public bool Advisory { get; set; }
        /// <summary>This scan's originating DTC(s) carried intermittent/erratic grammar — the tree
        /// must SUSPEND (not refute) this hypothesis on a lone clean pass. Per-scan, not global.</summary>
        public bool Volatile { get; set; }
    }

    /// <summary>Coarse, honest confidence banding — the only ranking word a tech should see.</summary>
    public enum FaultBand
    {
        /// <summary>Clearly ahead of the field — the theory to chase first.</summary>
        Leading,
        /// <summary>In the running, close enough to the leader that a test is worth it.</summary>
        Contending,
        /// <summary>Behind, but not yet ruled out.</summary>
        Trailing,
        /// <summary>Negligible support — all but eliminated (but kept on the map).</summary>
        TrailingFar,
    }

    /// <summary>Assigns the coarse band to a ranked frontier (posterior-normalised shares).</summary>
    public static class FaultBanding
    {
        // Leader is "leading" only if it clears the runner-up by this share gap; else the
        // top two are both "contending" and a discriminating test is genuinely needed.
        private const double LEAD_GAP = 0.20;
        // On a LARGE frontier normalised shares dilute toward zero, so the share gap alone can
        // never crown a leader (15 candidates ⇒ every share ~0.07 and gap ~0 no matter how far
        // ahead the leader's belief is).  A leader that clears the runner-up by this much
        // ABSOLUTE posterior is also "leading" — banding must not stall on frontier size.
        private const double LEAD_ABS_GAP = 0.20;
        private const double CONTEND_SHARE = 0.20;
        private const double TRAIL_SHARE = 0.07;
        // A share-leader must ALSO hold at least even odds of ABSOLUTE belief to earn
        // "leading".  NormShare normalises the doubt away — a lone hypothesis at posterior
        // 0.45 has share 1.0 yet leaves 55% of belief unexplained.  Without this floor it
        // would be crowned "leading"; honesty demands "contending" (front-runner, but the
        // evidence hasn't cleared even odds — test it) until the belief actually tips.
        private const double LEAD_MIN_POSTERIOR = 0.50;

        /// <summary>
        /// Core banding: given normalised shares in DESCENDING order, return the band per
        /// position. Reused by both the M6 frontier projection and the Investigation Tree
        /// (which re-bands its own live hypothesis nodes after folding in test outcomes).
        /// </summary>
        public static FaultBand[] BandShares(IReadOnlyList<double> sharesDescending)
            => BandShares(sharesDescending, double.NaN);

        /// <summary>
        /// Core banding with an absolute-confidence gate on the leader.  When
        /// <paramref name="leaderAbsolutePosterior"/> is supplied (not NaN), the top position
        /// is capped at "contending" unless the leader also holds at least even odds of
        /// absolute belief — so a share-leader that still leaves most belief unexplained is
        /// never over-sold as "leading".  Pass NaN to skip the gate (pure relative banding).
        /// </summary>
        public static FaultBand[] BandShares(IReadOnlyList<double> sharesDescending, double leaderAbsolutePosterior)
            => BandShares(sharesDescending, leaderAbsolutePosterior, double.NaN);

        /// <summary>
        /// Full banding: shares plus the ABSOLUTE posteriors of the top two.  On a large frontier
        /// the normalised share gap dilutes toward zero, so a leader that clears the runner-up by
        /// <see cref="LEAD_ABS_GAP"/> absolute posterior also earns "leading" (still gated on
        /// holding at least even odds of absolute belief).  Pass NaN to skip either gate.
        /// </summary>
        public static FaultBand[] BandShares(IReadOnlyList<double> sharesDescending,
                                             double leaderAbsolutePosterior, double secondAbsolutePosterior)
        {
            int n = sharesDescending?.Count ?? 0;
            var bands = new FaultBand[n];
            if (n == 0) return bands;
            double leader = sharesDescending[0];
            double second = n > 1 ? sharesDescending[1] : 0.0;
            bool leaderHoldsBelief = double.IsNaN(leaderAbsolutePosterior)
                                     || leaderAbsolutePosterior >= LEAD_MIN_POSTERIOR;
            bool absGapPasses = !double.IsNaN(leaderAbsolutePosterior) && !double.IsNaN(secondAbsolutePosterior)
                                && leaderAbsolutePosterior - secondAbsolutePosterior >= LEAD_ABS_GAP;
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    bool sharePasses = (n == 1 || leader - second >= LEAD_GAP);
                    bands[i] = ((sharePasses || absGapPasses) && leaderHoldsBelief) ? FaultBand.Leading : FaultBand.Contending;
                }
                else if (sharesDescending[i] >= CONTEND_SHARE)
                    bands[i] = FaultBand.Contending;
                else if (sharesDescending[i] >= TRAIL_SHARE)
                    bands[i] = FaultBand.Trailing;
                else
                    bands[i] = FaultBand.TrailingFar;
            }
            return bands;
        }

        /// <summary>
        /// Sets <see cref="RankedFault.Band"/> across a rank-ordered list (index 0 = leader),
        /// using the normalised posterior shares already on each item.
        /// </summary>
        public static void Assign(IReadOnlyList<RankedFault> ranked)
        {
            if (ranked == null || ranked.Count == 0) return;
            // ranked is already posterior-descending, so ranked[0] is the leader — gate its
            // band on its ABSOLUTE posterior, not just its normalised (doubt-stripped) share.
            var bands = BandShares(ranked.Select(f => f.NormShare).ToList(), ranked[0].Posterior,
                                   ranked.Count > 1 ? ranked[1].Posterior : double.NaN);
            for (int i = 0; i < ranked.Count; i++) ranked[i].Band = bands[i];
        }

        /// <summary>Human label for a band (tech-facing).</summary>
        public static string Label(FaultBand b)
        {
            switch (b)
            {
                case FaultBand.Leading:     return "leading";
                case FaultBand.Contending:  return "contending";
                case FaultBand.Trailing:    return "trailing";
                default:                    return "all but ruled out";
            }
        }
    }
}
