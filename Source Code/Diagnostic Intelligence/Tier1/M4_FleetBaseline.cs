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
//  Tester Present Specialist Automotive Solutions — M4 Fleet-Baseline Parametric Comparison (Tier-1)
//
//  A single reading — "MAF 3.1 g/s at idle", "spark 14°", "LTFT +9%" — is hard to
//  judge in isolation: "normal" depends on the engine, the calibration, and WHERE
//  in the operating envelope the reading was taken.  The most honest yardstick is
//  the vehicle's own peers: the accumulated distribution of the SAME parameter, on
//  the SAME platform, in the SAME RPM×Load operating-point cell, gathered across
//  the fleet (IFleetStore, Welford-accumulated per cell).
//
//  This module locates the vehicle's dominant operating-point cell, then for each
//  parameter of interest that was captured, compares the current robust reading
//  against the fleet distribution for that cell.  A reading that sits ≥ ZHi (default
//  3σ) from the fleet mean is flagged as a statistical outlier, with an evidence
//  chain showing the reading against the fleet ±2σ band and the single most
//  discriminating next test — never a bare verdict.
//
//  It is READ-ONLY against the fleet store: it never records here.  Learning
//  (Record → Flush) is a separate host step so a suspect vehicle cannot poison its
//  own baseline.  Fleet baselines are empirical and the operating grid is
//  spec-seeded, so every result is advisory; cold-start (too little fleet data) is
//  reported explicitly rather than fabricated into a false outlier.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Globalization;
using TesterPresent.OBD2.Intelligence;

namespace TesterPresent.OBD2.Intelligence.Tier1
{
    /// <summary>
    /// M4 — Fleet-Baseline Parametric Comparison.  Compares the current vehicle's
    /// parameter readings against the accumulated fleet distribution for the same
    /// platform and operating-point cell, flagging statistical outliers.  Reads the
    /// snapshot + context only; emits zero or more ranked hypotheses.
    /// </summary>
    public sealed class FleetBaselineModule : DiagnosticModuleBase
    {
        // Grid geometry — MUST match M1's so the fleet cells align across modules.
        private const int GRID_NX = 6;
        private const int GRID_NY = 6;
        private const double RPM_MIN = 500.0;
        private const double RPM_MAX = 6500.0;
        private const double LOAD_MIN = 0.0;
        private const double LOAD_MAX = 100.0;

        // Default outlier z-threshold (overridable via cal key "M4.OutlierZ").
        private const double DEFAULT_OUTLIER_Z = 3.0;

        private DiagnosticRequirements _requirements;

        /// <inheritdoc/>
        public override string ModuleId => "M4";

        /// <inheritdoc/>
        public override string DisplayName => "Fleet-Baseline Parametric Comparison";

        /// <inheritdoc/>
        public override DiagnosticTier Tier => DiagnosticTier.Tier1;

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
        /// Locate the dominant RPM×Load cell, then compare each captured parameter
        /// of interest against the fleet distribution for that cell, flagging any
        /// reading ≥ the outlier z-threshold from the fleet mean.
        /// </summary>
        protected override IReadOnlyList<DiagnosticResult> AnalyzeCore(
            DiagnosticSnapshot snapshot, DiagnosticContext context)
        {
            var results = new List<DiagnosticResult>();
            bool usedUnvalidated = false;

            // ── Calibration thresholds (spec-seeded until validated) ──────────
            double zHi = Cal(context, "M4.OutlierZ", DEFAULT_OUTLIER_Z, ref usedUnvalidated);
            if (zHi < 1.0) zHi = 1.0;
            int minFleetCount = (int)Math.Round(Cal(context, "M1.MinCellSamples", 5.0, ref usedUnvalidated));
            if (minFleetCount < 1) minFleetCount = 1;

            IFleetStore fleet = context != null ? context.Fleet : null;
            if (fleet == null) return results; // base guards this, defensive here.

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

            // ── Assemble the parameters of interest that were actually captured ──
            var compares = new List<Comparison>();
            AddIfPresent(compares, snapshot, CanonicalSignals.LtftB1, "LTFT bank 1", "%",
                "Investigate fueling for this operating point (see M1 fuel-trim surface analysis).",
                "Intake/vacuum leak", "Fuel delivery (pump/filter/injectors)", "MAF/MAP metering", "Fuel pressure");
            AddIfPresent(compares, snapshot, CanonicalSignals.LtftB2, "LTFT bank 2", "%",
                "Investigate bank-2 fueling for this operating point (see M1 fuel-trim surface analysis).",
                "Bank-2 injector(s)", "Bank-2 O2 sensor", "Bank-2 intake/exhaust leak");
            AddIfPresent(compares, snapshot, CanonicalSignals.Maf, "MAF", " g/s",
                "Compare measured MAF against calculated airflow (RPM×VE×displacement) at this operating point.",
                "MAF sensor", "Intake restriction / leak upstream of MAF", "Air filter");
            AddIfPresent(compares, snapshot, CanonicalSignals.TimingAdvance, "Spark advance", "°",
                "Check for knock-driven spark retard or a cam/crank correlation issue at this load.",
                "Knock sensor activity", "Fuel octane / quality", "Cam/crank timing", "Carbon / hot spots");
            AddIfPresent(compares, snapshot, CanonicalSignals.Coolant, "Coolant temperature", "°C",
                "Verify the thermostat and the ECT sensor against a reference temperature.",
                "Thermostat", "ECT sensor", "Cooling system (flow/level)");

            // MapOrLoad: prefer MAP when captured, else fall back to engine load.
            bool hasMap = snapshot.Has(CanonicalSignals.Map);
            string mlName = hasMap ? CanonicalSignals.Map : CanonicalSignals.EngineLoad;
            string mlLabel = hasMap ? "MAP" : "Engine load";
            string mlUnit = hasMap ? " kPa" : "%";
            AddIfPresent(compares, snapshot, mlName, mlLabel, mlUnit,
                hasMap
                    ? "Compare manifold pressure against expected for this throttle/RPM, and cross-check the BARO reference."
                    : "Compare calculated load against MAF/MAP-derived airflow for this operating point.",
                hasMap ? new[] { "MAP sensor", "Intake manifold leak", "Throttle body" }
                       : new[] { "Load calculation inputs (MAF/MAP)", "Throttle body", "Intake restriction" });

            // ── Compare each captured parameter against the fleet cell ────────
            int compared = 0;
            int coldStart = 0;
            var coldNames = new List<string>();

            foreach (var c in compares)
            {
                compared++;
                FleetStat fs = fleet.Query(platform, c.SignalName, cx, cy);
                if (fs.Count < minFleetCount)
                {
                    coldStart++;
                    coldNames.Add(c.Label);
                    continue; // insufficient fleet data — do NOT fabricate an outlier.
                }

                double current = SignalMath.Median(c.Series.Values());
                // Floor the fleet spread before the z-test. Quantised, tightly-clustered signals
                // (coolant pinned ~90°C) yield a near-zero fleet stddev, turning a trivial 1°C
                // deviation into a "49-sigma outlier". A minimum spread of ~1% of the mean keeps a
                // sub-percent deviation from ever reading as extreme — and, being non-zero, also
                // fixes the exact-zero-stddev degenerate case where a REAL deviation was silently
                // missed (ZScore returned 0). A genuinely wide fleet keeps its real, larger stddev.
                double effSigma = Math.Max(fs.StdDev, 0.01 * Math.Abs(fs.Mean) + 1e-6);
                double z = SignalMath.ZScore(current, fs.Mean, effSigma);
                if (Math.Abs(z) >= zHi)
                    results.Add(BuildOutlier(c, current, z, fs, cellDesc, platform, zHi));
            }

            // ── Advisory reason (fleet baselines are empirical; grid is spec-seeded) ──
            string advisoryReason =
                "fleet baselines are empirical and the platform operating grid is spec-seeded, "
                + "not validated on this platform";
            if (rpm.Count < 20)
                advisoryReason += $"; thin capture ({rpm.Count} RPM samples)";
            if (coldStart > 0 && coldStart < compared)
                advisoryReason += $"; {coldStart} of {compared} parameters had insufficient fleet data "
                                  + "(cold-start) and were not compared";
            StampAdvisory(results, advisoryReason);

            // ── Cold-start: every captured parameter lacked usable fleet data ──
            if (results.Count == 0 && compared > 0 && coldStart == compared)
            {
                results.Add(BuildColdStart(compared, minFleetCount, cellDesc, platform,
                                           advisoryReason));
            }

            return results;
        }

        // ── Hypothesis builders ───────────────────────────────────────────────

        /// <summary>Build the outlier hypothesis for one parameter vs its fleet cell.</summary>
        private DiagnosticResult BuildOutlier(Comparison c, double current, double z, FleetStat fs,
                                              string cellDesc, string platform, double zHi)
        {
            double lo = fs.Mean - 2.0 * fs.StdDev;
            double hi = fs.Mean + 2.0 * fs.StdDev;
            string dir = z >= 0 ? "above" : "below";

            var r = NewResult($"{c.Label} is a fleet outlier at this operating point");
            r.Hypothesis =
                $"{c.Label} reads {Fmt(current)}{c.Unit} here, which is {Fmt(Math.Abs(z))}σ {dir} the "
                + $"fleet mean of {Fmt(fs.Mean)}±{Fmt(fs.StdDev)}{c.Unit} for '{platform}' in {cellDesc} "
                + $"(n={fs.Count}). A deviation this far from same-platform, same-operating-point peers is "
                + "unlikely to be normal spread — this parameter, not the others, is the anomaly.";
            r.Severity = DiagnosticSeverity.Medium;
            r.Confidence = ConfidenceFromZ(z);
            r.SuspectComponents = new List<string>(c.Suspects);
            r.NextTest = c.NextTest;

            r.Evidence
                .Measure($"{c.Label} vs fleet", current, lo, hi, c.Unit.Trim(),
                         $"Current robust reading against the fleet ±2σ band "
                         + $"[{Fmt(lo)}{c.Unit}, {Fmt(hi)}{c.Unit}].")
                .Info("Fleet baseline",
                      $"mean {Fmt(fs.Mean)} ± {Fmt(fs.StdDev)}{c.Unit}, n={fs.Count}",
                      "Accumulated across same-platform vehicles at this operating point.")
                .Info("Operating point", cellDesc,
                      "RPM×Load cell used to match the fleet distribution — like-for-like comparison.");

            return r;
        }

        /// <summary>Build the single informational result when no cell had usable fleet data.</summary>
        private DiagnosticResult BuildColdStart(int compared, int minFleetCount, string cellDesc,
                                                string platform, string advisoryReason)
        {
            var r = NewResult("Fleet baseline unavailable for this operating point");
            r.Hypothesis =
                "Insufficient fleet baseline for this platform/operating point — comparison unavailable; "
                + "readings recorded will build the baseline.";
            r.Severity = DiagnosticSeverity.Info;
            r.Confidence = 0.10;
            r.SuspectComponents = new List<string>(); // no suspect — this is a data-availability result.
            r.NextTest =
                "Continue capturing data on known-good vehicles of this platform to accumulate the fleet "
                + "baseline, then re-run the comparison. No outlier can be asserted from an empty distribution.";

            r.Evidence
                .Info("Fleet coverage",
                      $"{compared} of {compared} captured parameters had < {minFleetCount} fleet samples "
                      + $"at {cellDesc}",
                      $"No cell in the fleet store for '{platform}' has enough observations to compare against yet.")
                .Inconclusive("Outlier test", "not run", "≥ " + minFleetCount + " fleet samples",
                      "Comparison skipped rather than fabricating a verdict from thin data.");

            r.Advisory = true;
            r.AdvisoryReason =
                advisoryReason + $"; cold-start: fewer than {minFleetCount} fleet samples at this operating point";
            return r;
        }

        // ── Small helpers ─────────────────────────────────────────────────────

        /// <summary>Append a comparison for a canonical signal only if it was captured with data.</summary>
        private static void AddIfPresent(List<Comparison> list, DiagnosticSnapshot snap, string signalName,
                                         string label, string unit, string nextTest, params string[] suspects)
        {
            SignalSeries s = snap.Series(signalName);
            if (s == null || !s.HasData) return;
            list.Add(new Comparison
            {
                SignalName = signalName,
                Series = s,
                Label = label,
                Unit = unit,
                NextTest = nextTest,
                Suspects = suspects ?? Array.Empty<string>(),
            });
        }

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
        /// Confidence from |z|, anchored at the spec points 3σ ≈ 0.55 and 5σ ≈ 0.80,
        /// linearly interpolated and clamped to that band.  Farther-out readings are
        /// firmer outliers but confidence is capped because the baseline is empirical.
        /// </summary>
        private static double ConfidenceFromZ(double z)
        {
            double az = Math.Abs(z);
            double c = 0.55 + 0.125 * (az - 3.0); // 3 => 0.55, 5 => 0.80
            return SignalMath.Clamp(c, 0.55, 0.80);
        }

        /// <summary>Mark every result advisory with the shared reason (M4 is always advisory).</summary>
        private static void StampAdvisory(List<DiagnosticResult> results, string reason)
        {
            foreach (var r in results)
            {
                if (r == null) continue;
                r.Advisory = true;
                r.AdvisoryReason = reason;
            }
        }

        /// <summary>Format a possibly-NaN value compactly and culture-invariantly.</summary>
        private static string Fmt(double v)
        {
            if (double.IsNaN(v)) return "n/a";
            return v.ToString("0.##", CultureInfo.InvariantCulture);
        }

        /// <summary>One parameter to compare against its fleet cell.</summary>
        private sealed class Comparison
        {
            public string SignalName;
            public SignalSeries Series;
            public string Label;
            public string Unit;
            public string NextTest;
            public IReadOnlyList<string> Suspects;
        }
    }
}
