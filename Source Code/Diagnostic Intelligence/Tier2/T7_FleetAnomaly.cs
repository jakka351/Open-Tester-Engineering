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
//  Tester Present Specialist Automotive Solutions — T7 Fleet Manifold Anomaly Detection (Tier-2)
//
//  Tier-1 M4 asks "is THIS parameter an outlier vs the fleet?" one signal at a
//  time.  T7 asks the harder, multivariate question: "is this vehicle's whole
//  multi-signal SIGNATURE an outlier vs the fleet for the same platform and the
//  same operating point?"  A vehicle can look normal on every single parameter
//  yet be jointly abnormal — or a modest deviation on two correlated signals can
//  matter more than a large deviation on one.
//
//  PHYSICAL / STATISTICAL MODEL — Mahalanobis-lite anomaly score:
//    For each candidate signal s that has adequate fleet population in the
//    vehicle's operating cell, compute the standardised residual
//        z_s = (x_s − μ_fleet,s) / σ_fleet,s                     (dimensionless)
//    where (μ,σ) are the Welford-accumulated fleet distribution for that
//    (platform, signal, cell).  Treating the standardised signals as
//    approximately independent (diagonal covariance — hence "lite"), the joint
//    distance of the vehicle's signature from the fleet centroid is
//        D = sqrt( Σ_s z_s² )                                     (a χ-like norm)
//    Under the healthy-fleet null hypothesis each z_s ~ N(0,1), so D is the
//    radius in standardised space; a large D means the vehicle sits far from the
//    fleet cloud on the combined axes.  D > threshold ⇒ multivariate anomaly.
//
//  SCALE-GATED and READ-ONLY.  This is only meaningful once the fleet store holds
//  a genuine population, so it demands a HIGHER per-signal fleet count than M4
//  (population-level, default 20) and needs at least TWO qualifying signals to
//  form a multivariate score at all.  Below that it degrades gracefully to an
//  explicit "insufficient fleet population" result — it never fabricates an
//  anomaly from thin data.  It NEVER writes to the fleet store (a suspect vehicle
//  must not pollute the very baseline it is being judged against).
//
//  Fleet baselines are empirical and the operating grid is spec-seeded, so every
//  result is ADVISORY until validated against known-good populations on this
//  platform.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using TesterPresent.OBD2.Intelligence;

namespace TesterPresent.OBD2.Intelligence.Tier2
{
    /// <summary>
    /// T7 — Fleet Manifold Anomaly Detection.  Unsupervised multivariate outlier
    /// detection: combines the per-signal standardised residuals of this vehicle
    /// (vs the fleet distribution for the same platform + operating-point cell)
    /// into a Mahalanobis-lite anomaly score and flags a joint anomaly when the
    /// score exceeds threshold.  Reads snapshot + context only; never writes to
    /// the fleet store; degrades to an explicit "insufficient population" result
    /// when fewer than two signals have adequate fleet data.
    /// </summary>
    public sealed class FleetAnomalyModule : DiagnosticModuleBase
    {
        // Grid geometry — MUST match M1/M4 so the fleet cells align across modules.
        private const int GRID_NX = 6;
        private const int GRID_NY = 6;
        private const double RPM_MIN = 500.0;
        private const double RPM_MAX = 6500.0;
        private const double LOAD_MIN = 0.0;
        private const double LOAD_MAX = 100.0;

        // Population-level minimum fleet count per signal (overridable via "T7.MinFleetCount").
        // Higher than M4's per-cell minimum: T7 makes a population-level judgement.
        private const double DEFAULT_MIN_FLEET_COUNT = 20.0;

        // Combined anomaly-score threshold (overridable via "T7.AnomalyScore").
        // Under the healthy-fleet null each z ~ N(0,1); D = sqrt(Σz²). For two
        // signals a D of 4.0 corresponds to a joint deviation well outside normal
        // spread (e.g. z≈2.8 on each of two axes, or z≈4 on one and ~0 on another).
        private const double DEFAULT_ANOMALY_SCORE = 4.0;

        // Minimum number of qualifying signals to form a multivariate signature.
        private const int MIN_QUALIFYING_SIGNALS = 2;

        private DiagnosticRequirements _requirements;

        /// <inheritdoc/>
        public override string ModuleId => "T7";

        /// <inheritdoc/>
        public override string DisplayName => "Fleet Manifold Anomaly Detection";

        /// <inheritdoc/>
        public override DiagnosticTier Tier => DiagnosticTier.Tier2;

        /// <inheritdoc/>
        public override DiagnosticRequirements Requirements =>
            _requirements ?? (_requirements = new DiagnosticRequirements
            {
                NeedsFleetStore = true,
                RequiredSignals = new List<string>
                {
                    CanonicalSignals.Rpm,
                    CanonicalSignals.EngineLoad,
                },
                MinSamples = 10,
                MayRecommendActiveControl = false,
            });

        /// <summary>
        /// Locate the vehicle's dominant RPM×Load cell, standardise each candidate
        /// signal against the fleet distribution for that cell, and combine the
        /// residuals into a Mahalanobis-lite anomaly score.  Emit a single
        /// insufficient-population result when fewer than two signals qualify;
        /// otherwise emit a multivariate-anomaly hypothesis when the combined
        /// score exceeds threshold.
        /// </summary>
        protected override IReadOnlyList<DiagnosticResult> AnalyzeCore(
            DiagnosticSnapshot snapshot, DiagnosticContext context)
        {
            var results = new List<DiagnosticResult>();
            bool usedUnvalidated = false;

            // ── Calibration (spec-seeded until validated) ─────────────────────
            int minFleetCount = (int)Math.Round(
                Cal(context, "T7.MinFleetCount", DEFAULT_MIN_FLEET_COUNT, ref usedUnvalidated));
            if (minFleetCount < 1) minFleetCount = 1;
            double scoreThreshold = Cal(context, "T7.AnomalyScore", DEFAULT_ANOMALY_SCORE, ref usedUnvalidated);
            if (scoreThreshold < 1.0) scoreThreshold = 1.0;

            IFleetStore fleet = context != null ? context.Fleet : null;
            if (fleet == null) return results; // base guards this; defensive here.

            SignalSeries rpm = snapshot.Series(CanonicalSignals.Rpm);
            SignalSeries load = snapshot.Series(CanonicalSignals.EngineLoad);
            if (rpm == null || !rpm.HasData || load == null || !load.HasData) return results;

            // ── Dominant operating-point cell: median RPM × median Load ───────
            var grid = new OperatingPointGrid(GRID_NX, GRID_NY, RPM_MIN, RPM_MAX, LOAD_MIN, LOAD_MAX,
                                              CanonicalSignals.Rpm, CanonicalSignals.EngineLoad);
            double medRpm = SignalMath.Median(rpm.Values());
            double medLoad = SignalMath.Median(load.Values());
            var (cx, cy) = grid.CellOf(medRpm, medLoad);
            string cellDesc =
                $"cell [{cx},{cy}] ≈ {grid.XCenter(cx):0} rpm / {grid.YCenter(cy):0}% load";
            string platform = string.IsNullOrEmpty(snapshot.Platform) ? "Generic" : snapshot.Platform;

            // ── Candidate signals — standardise each present one vs its fleet cell ──
            var candidates = BuildCandidates(snapshot);
            var qualifying = new List<SignalResidual>();
            int candidatesPresent = candidates.Count;
            int thinFleet = 0;

            foreach (var c in candidates)
            {
                FleetStat fs = fleet.Query(platform, c.SignalName, cx, cy);
                if (!fs.HasEnoughData(minFleetCount))
                {
                    thinFleet++;
                    continue; // population too thin — do NOT contribute a fabricated residual.
                }
                if (fs.StdDev < 1e-9)
                    continue; // zero-spread fleet cell: z undefined; skip rather than divide-by-zero.

                double current = SignalMath.Median(c.Series.Values());
                double z = SignalMath.ZScore(current, fs.Mean, fs.StdDev);
                qualifying.Add(new SignalResidual
                {
                    Label = c.Label,
                    Unit = c.Unit,
                    Suspects = c.Suspects,
                    Current = current,
                    Z = z,
                    Fleet = fs,
                });
            }

            // ── SCALE GATE: need ≥2 qualifying signals for a multivariate signature ──
            if (qualifying.Count < MIN_QUALIFYING_SIGNALS)
            {
                results.Add(BuildInsufficientPopulation(
                    minFleetCount, qualifying.Count, candidatesPresent, cellDesc, platform));
                return results;
            }

            // ── Mahalanobis-lite: D = sqrt(Σ z²) over qualifying, independent axes ──
            double sumSq = 0.0;
            foreach (var q in qualifying) sumSq += q.Z * q.Z;
            double score = Math.Sqrt(sumSq);

            // The threshold MUST scale with the number of axes (χ degrees of freedom):
            // under the healthy-fleet null D²~χ²(k), so E[D]≈√k and D grows with k even for
            // a healthy vehicle.  A FIXED threshold would flag more false positives the more
            // signals qualify.  The constant is tuned for the k=2 baseline (see the comment
            // on DEFAULT_ANOMALY_SCORE), so scale it by √(k/2) to hold the false-positive
            // rate roughly constant as k rises.
            double effThreshold = scoreThreshold * Math.Sqrt(qualifying.Count / (double)MIN_QUALIFYING_SIGNALS);

            if (score <= effThreshold)
                return results; // signature is within the fleet cloud — no finding.

            results.Add(BuildAnomaly(qualifying, score, effThreshold, cellDesc, platform));

            // Tier-2 rests on spec-seeded geometry + empirical fleet baselines: always advisory.
            string advisoryReason =
                "fleet baselines are empirical and the platform operating grid is spec-seeded, "
                + "not validated on this platform; anomaly threshold is unvalidated";
            if (rpm.Count < 20)
                advisoryReason += $"; thin capture ({rpm.Count} RPM samples)";
            if (thinFleet > 0)
                advisoryReason += $"; {thinFleet} candidate signal(s) had insufficient fleet population "
                                  + "and were excluded from the signature";
            foreach (var r in results) { r.Advisory = true; r.AdvisoryReason = advisoryReason; }

            return results;
        }

        // ── Hypothesis builders ───────────────────────────────────────────────

        /// <summary>Build the multivariate fleet-anomaly hypothesis from the qualifying residuals.</summary>
        private DiagnosticResult BuildAnomaly(List<SignalResidual> qualifying, double score,
                                              double threshold, string cellDesc, string platform)
        {
            // Rank by |z| — the largest-deviation signals are the top contributors.
            var ranked = qualifying.OrderByDescending(q => Math.Abs(q.Z)).ToList();
            var topNames = ranked.Select(q => q.Label).ToList();
            string signalList = JoinList(topNames);

            var r = NewResult("Multivariate fleet anomaly");
            r.Hypothesis =
                $"This vehicle's multi-signal signature at {cellDesc} is a joint outlier versus the "
                + $"'{platform}' fleet: combined anomaly score {Fmt(score)}σ across {qualifying.Count} "
                + $"signals ({signalList}) exceeds the {Fmt(threshold)}σ threshold. No single parameter "
                + "need be individually alarming — it is the COMBINATION that departs from same-platform, "
                + "same-operating-point peers, which points at a real fault rather than normal spread.";
            r.Severity = DiagnosticSeverity.Medium;
            r.Confidence = ConfidenceFromScore(score, threshold);
            r.SuspectComponents = ranked
                .SelectMany(q => q.Suspects ?? Array.Empty<string>())
                .Distinct()
                .ToList();
            r.NextTest =
                $"This vehicle deviates from the fleet on {signalList}; investigate those parameters — "
                + $"start with the largest deviation ({ranked[0].Label}, "
                + $"{Fmt(Math.Abs(ranked[0].Z))}σ {(ranked[0].Z >= 0 ? "above" : "below")} fleet mean).";

            r.Evidence.Info("Combined anomaly score",
                $"{Fmt(score)}σ  (threshold {Fmt(threshold)}σ)",
                $"Mahalanobis-lite joint distance D = sqrt(Σz²) over {qualifying.Count} standardised "
                + "signals, assuming independent axes.");
            foreach (var q in ranked)
            {
                double lo = q.Fleet.Mean - 2.0 * q.Fleet.StdDev;
                double hi = q.Fleet.Mean + 2.0 * q.Fleet.StdDev;
                string dir = q.Z >= 0 ? "above" : "below";
                r.Evidence.Measure($"{q.Label} vs fleet", q.Current, lo, hi, q.Unit.Trim(),
                    $"{Fmt(Math.Abs(q.Z))}σ {dir} fleet mean {Fmt(q.Fleet.Mean)}±{Fmt(q.Fleet.StdDev)}"
                    + $"{q.Unit} (n={q.Fleet.Count}); contributes {Fmt(q.Z * q.Z)} to Σz².");
            }
            r.Evidence.Info("Operating point", cellDesc,
                "RPM×Load cell used to match the fleet distribution — like-for-like comparison.");

            return r;
        }

        /// <summary>
        /// Build the single informational result when fewer than two signals have
        /// adequate fleet population — the scale gate that keeps T7 honest.
        /// </summary>
        private DiagnosticResult BuildInsufficientPopulation(int minFleetCount, int qualifyingCount,
                                                             int candidatesPresent, string cellDesc,
                                                             string platform)
        {
            var r = NewResult("Fleet anomaly detection unavailable — insufficient fleet population");
            r.Hypothesis =
                $"Fleet anomaly detection unavailable — insufficient fleet population for this "
                + $"platform/operating point (needs ≥{minFleetCount} vehicles' data across "
                + $"≥2 signals). Continue recording to build the manifold.";
            r.Severity = DiagnosticSeverity.Info;
            r.Confidence = 0.10;
            r.SuspectComponents = new List<string>(); // data-availability result, no suspect.
            r.NextTest =
                $"Continue capturing data on known-good '{platform}' vehicles at {cellDesc} to accumulate "
                + $"≥{minFleetCount} fleet observations on at least two signals, then re-run. No "
                + "multivariate anomaly can be asserted from a thin population.";

            r.Evidence
                .Info("Fleet coverage",
                    $"{qualifyingCount} of {candidatesPresent} captured candidate signals reached "
                    + $"≥{minFleetCount} fleet observations at {cellDesc}",
                    $"A multivariate signature needs ≥2 populated signals for platform '{platform}'.")
                .Inconclusive("Multivariate anomaly test", "not run",
                    $"≥2 signals with ≥{minFleetCount} fleet samples",
                    "Gated rather than fabricating a joint anomaly from thin population data.");

            r.Advisory = true;
            r.AdvisoryReason =
                "fleet baselines are empirical and the platform operating grid is spec-seeded; "
                + $"scale gate: fewer than 2 signals reached the {minFleetCount}-vehicle population "
                + "floor for this platform/operating point";
            return r;
        }

        // ── Candidate assembly ────────────────────────────────────────────────

        /// <summary>
        /// The candidate signals for the fleet signature — those present in the
        /// capture that carry a meaningful fleet distribution.  Each carries the
        /// unit and the suspect components to name if it drives the anomaly.
        /// </summary>
        private static List<Candidate> BuildCandidates(DiagnosticSnapshot snap)
        {
            var list = new List<Candidate>();
            AddIfPresent(list, snap, CanonicalSignals.LtftB1, "LTFT bank 1", "%",
                "Intake/vacuum leak", "Fuel delivery (pump/filter/injectors)", "MAF/MAP metering", "Fuel pressure");
            AddIfPresent(list, snap, CanonicalSignals.Maf, "MAF", " g/s",
                "MAF sensor", "Intake restriction / leak upstream of MAF", "Air filter");
            AddIfPresent(list, snap, CanonicalSignals.TimingAdvance, "Spark advance", "°",
                "Knock sensor activity", "Fuel octane / quality", "Cam/crank timing", "Carbon / hot spots");
            AddIfPresent(list, snap, CanonicalSignals.Coolant, "Coolant temperature", "°C",
                "Thermostat", "ECT sensor", "Cooling system (flow/level)");
            AddIfPresent(list, snap, CanonicalSignals.Map, "MAP", " kPa",
                "MAP sensor", "Intake manifold leak", "Throttle body");
            return list;
        }

        /// <summary>Append a candidate for a canonical signal only if it was captured with data.</summary>
        private static void AddIfPresent(List<Candidate> list, DiagnosticSnapshot snap, string signalName,
                                         string label, string unit, params string[] suspects)
        {
            SignalSeries s = snap.Series(signalName);
            if (s == null || !s.HasData) return;
            list.Add(new Candidate
            {
                SignalName = signalName,
                Series = s,
                Label = label,
                Unit = unit,
                Suspects = suspects ?? Array.Empty<string>(),
            });
        }

        // ── Small helpers ─────────────────────────────────────────────────────

        /// <summary>Read a calibration constant, folding an unvalidated read into the advisory flag.</summary>
        private static double Cal(DiagnosticContext ctx, string key, double fallback, ref bool usedUnvalidated)
        {
            if (ctx == null || ctx.Calibration == null) { usedUnvalidated = true; return fallback; }
            bool validated;
            double v = ctx.Calibration.Value(key, fallback, out validated);
            if (!validated) usedUnvalidated = true;
            return v;
        }

        /// <summary>
        /// Confidence from the combined anomaly score, anchored at the threshold
        /// (moderate ≈ 0.55) and rising with distance, capped at 0.80 because the
        /// baseline is empirical and the threshold spec-seeded.  Linear:
        /// score = threshold ⇒ 0.55, score = threshold+4 ⇒ 0.80.
        /// </summary>
        private static double ConfidenceFromScore(double score, double threshold)
        {
            double c = 0.55 + 0.0625 * (score - threshold); // +4σ over threshold ⇒ +0.25
            return SignalMath.Clamp(c, 0.55, 0.80);
        }

        /// <summary>Join a name list as "A, B and C" for readable prose.</summary>
        private static string JoinList(IReadOnlyList<string> names)
        {
            if (names == null || names.Count == 0) return "(none)";
            if (names.Count == 1) return names[0];
            if (names.Count == 2) return names[0] + " and " + names[1];
            return string.Join(", ", names.Take(names.Count - 1)) + " and " + names[names.Count - 1];
        }

        /// <summary>Format a possibly-NaN value compactly and culture-invariantly.</summary>
        private static string Fmt(double v)
        {
            if (double.IsNaN(v)) return "n/a";
            return v.ToString("0.##", CultureInfo.InvariantCulture);
        }

        /// <summary>A candidate signal available to form the fleet signature.</summary>
        private sealed class Candidate
        {
            public string SignalName;
            public SignalSeries Series;
            public string Label;
            public string Unit;
            public IReadOnlyList<string> Suspects;
        }

        /// <summary>A candidate's standardised residual against its fleet cell.</summary>
        private sealed class SignalResidual
        {
            public string Label;
            public string Unit;
            public IReadOnlyList<string> Suspects;
            public double Current;
            public double Z;
            public FleetStat Fleet;
        }
    }
}
