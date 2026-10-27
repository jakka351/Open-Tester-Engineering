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
//  Tester Present Specialist Automotive Solutions — M2 Crank Angular-Velocity Analysis (Tier-1)
//
//  Inverts the raw RPM signal (Mode-01 PID 0x0C) into a compression / misfire
//  hypothesis by measuring the crank-speed ripple.  Two regimes:
//
//    • CRANKING  — while the starter turns the engine (~100-800 RPM) each
//      cylinder's compression stroke loads the crank and momentarily slows it.
//      A healthy engine cranks at a near-constant speed (low coefficient of
//      variation).  A weak cylinder (burnt valve, worn rings, blown head
//      gasket) drops the compression load for that stroke, so the crank speeds
//      up unevenly and the CoV of cranking RPM rises.  This automates by number
//      what RelativeCompressionDialog does by hand.
//
//    • IDLE      — a running engine at idle should hold RPM very tightly.  A
//      misfire, vacuum leak or mechanical roughness widens the idle-RPM CoV.
//
//  HONESTY: OBD PID 0x0C is captured at ~5-25 Hz.  That is enough to see a
//  GROSS compression imbalance but NOT enough to localise the offending
//  cylinder — that needs a CKP scope or a high-rate vendor DID.  Every result
//  is advisory: the thresholds are spec-seeded, not yet validated on-platform.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using TesterPresent.OBD2.Intelligence;

namespace TesterPresent.OBD2.Intelligence.Tier1
{
    /// <summary>
    /// Tier-1 signal-inversion module: infers uneven compression or idle
    /// instability from the coefficient of variation of the RPM signal.  Pure —
    /// reads the snapshot only, never touches hardware, never throws.
    /// </summary>
    public sealed class CrankAngularVelocityModule : DiagnosticModuleBase
    {
        private DiagnosticRequirements _requirements;

        /// <inheritdoc/>
        public override string ModuleId => "M2";

        /// <inheritdoc/>
        public override string DisplayName => "Crank Angular-Velocity Analysis";

        /// <inheritdoc/>
        public override DiagnosticTier Tier => DiagnosticTier.Tier1;

        /// <inheritdoc/>
        public override DiagnosticRequirements Requirements =>
            _requirements ?? (_requirements = new DiagnosticRequirements
            {
                RequiredSignals = new List<string> { CanonicalSignals.Rpm },
                MinSamples = 20,
            });

        /// <summary>Sample rate below which PID 0x0C only resolves gross imbalance.</summary>
        private const double GrossOnlyHzFloor = 10.0;

        /// <inheritdoc/>
        protected override IReadOnlyList<DiagnosticResult> AnalyzeCore(
            DiagnosticSnapshot snapshot, DiagnosticContext context)
        {
            var results = new List<DiagnosticResult>();

            SignalSeries rpm;
            if (snapshot == null || !snapshot.TryGetSeries(CanonicalSignals.Rpm, out rpm) || rpm == null || !rpm.HasData)
                return results;

            var values = rpm.Values();
            if (values == null || values.Count < 2)
                return results;

            // ── Calibration reads (track whether any resolved value was unvalidated) ──
            bool usedUnvalidated = false;
            var cal = context?.Calibration;

            double ReadCal(string key, double fallback)
            {
                if (cal == null) { usedUnvalidated = true; return fallback; }
                double v = cal.Value(key, fallback, out bool validated);
                if (!validated) usedUnvalidated = true;
                return v;
            }

            double crankCoVFailPct = ReadCal("M2.CrankCoVFailPct", 18.0);
            double idleCoVWarnPct = ReadCal("M2.IdleCoVWarnPct", 5.0);
            double minCrankRpm = ReadCal("M2.MinCrankRpm", 100.0);
            double maxCrankRpm = ReadCal("M2.MaxCrankRpm", 800.0);
            double idleRpm = ReadCal("Engine.IdleRpm", 750.0);

            // A NullCalibration / uncalibrated platform is always advisory too.
            if (context == null || cal == null || !context.IsCalibrated)
                usedUnvalidated = true;

            double median = SignalMath.Median(values);
            double estHz = rpm.EstimatedHz;
            bool grossOnly = estHz > 0 && estHz < GrossOnlyHzFloor;

            // ── Regime classification ────────────────────────────────────────
            //  The default crank band [100,800] overlaps the idle window
            //  (750±300), so a running idle would otherwise be swallowed as
            //  "cranking, healthy".  Disambiguate physically: cranking is the
            //  low-speed regime BELOW the idle window; a median inside the idle
            //  window with the engine running is idle.
            double idleLo = idleRpm - 300.0;
            double idleHi = idleRpm + 300.0;

            bool inCrankBand = median >= minCrankRpm && median <= maxCrankRpm;
            bool cranking = inCrankBand && median < idleLo;
            bool idling = !cranking && median >= idleLo && median <= idleHi && median > 400.0;

            if (cranking)
            {
                var result = AnalyzeCranking(values, median, estHz, grossOnly, usedUnvalidated,
                                             crankCoVFailPct, minCrankRpm, maxCrankRpm, idleLo);
                if (result != null) results.Add(result);
            }
            else if (idling)
            {
                var result = AnalyzeIdle(values, median, estHz, grossOnly, usedUnvalidated,
                                         idleCoVWarnPct, idleLo, idleHi);
                if (result != null) results.Add(result);
            }
            // Otherwise: RPM is not in a diagnosable regime (part-throttle,
            // transient, over-rev) — nothing to say.

            return results;
        }

        /// <summary>Cranking regime: high CoV ⇒ uneven compression across cylinders.</summary>
        private DiagnosticResult AnalyzeCranking(
            IReadOnlyList<double> values, double median, double estHz, bool grossOnly,
            bool usedUnvalidated, double failPct, double minCrankRpm, double maxCrankRpm, double idleLo)
        {
            // Only the samples inside the crank band describe the cranking event —
            // and the band must stop BELOW idle.  The default max (800) overlaps the
            // idle window, so without the idleLo cap a healthy start-up ramp
            // (crank → catch → rise toward idle) folds into the CoV and false-fires
            // "uneven compression".  Mirror how AnalyzeIdle bounds to its own regime.
            double crankHi = Math.Min(maxCrankRpm, idleLo);
            var crank = values.Where(v => v >= minCrankRpm && v < crankHi).ToList();
            if (crank.Count < 2)
                return null;

            // Measure the per-stroke RIPPLE, not the raw CoV.  A healthy start-up that
            // ramps monotonically within the crank band (130 → 445 rpm as the engine
            // catches) has a large raw CoV but is not compression imbalance — the
            // variation is a trend, not stroke-to-stroke.  Remove a linear trend first
            // so only genuine per-stroke ripple (which a weak cylinder produces) counts.
            double cov = DetrendedCoV(crank);
            double covPct = cov * 100.0;

            if (covPct <= failPct)
                return null; // even cranking (after de-trending) — no compression fault indicated

            double lo = crank.Min();
            double hi = crank.Max();

            var result = NewResult("Uneven Cranking Compression");
            result.Hypothesis = "Uneven compression — one or more weak cylinders. The crank speed " +
                                "varies more than a healthy engine during cranking, which is the " +
                                "signature of a cylinder losing compression on its stroke.";
            result.Severity = DiagnosticSeverity.High;

            result.Evidence
                .Measure("Cranking RPM CoV", covPct, 0.0, failPct, "%",
                         "Coefficient of variation of cranking RPM. Above the threshold means the " +
                         "crank decelerates unevenly between compression strokes.")
                .Info("Cranking samples", crank.Count.ToString(CultureInfo.InvariantCulture),
                      $"of {values.Count} total RPM samples; median {median:0} RPM.")
                .Info("Cranking RPM range",
                      string.Format(CultureInfo.InvariantCulture, "{0:0}–{1:0} RPM", lo, hi));

            AddResolutionEvidence(result, estHz, grossOnly);
            AddConfoundEvidence(result);

            // Confidence: base 0.35, scaled by how far the CoV overshoots the threshold,
            // then attenuated for a thin cranking window (a handful of strokes is a weak
            // statistic — the estimate should not read confident on 4 samples).
            double overage = (covPct - failPct) / failPct;
            double sampleFactor = SignalMath.Clamp(crank.Count / 30.0, 0.45, 1.0);
            result.Confidence = SignalMath.Clamp((0.35 + Math.Min(0.5, overage * 0.5)) * sampleFactor, 0.0, 1.0);

            result.NextTest = "Perform a relative-compression or cylinder leak-down test to " +
                              "identify the weak cylinder(s).";
            result.SuspectComponents = new List<string>
            {
                "Burnt / leaking exhaust or intake valve",
                "Worn piston rings / cylinder bore",
                "Blown head gasket",
                "Bent valve",
            };

            ApplyAdvisory(result, usedUnvalidated, grossOnly, crank.Count);
            return result;
        }

        /// <summary>Idle regime: elevated CoV ⇒ misfire or mechanical roughness.</summary>
        private DiagnosticResult AnalyzeIdle(
            IReadOnlyList<double> values, double median, double estHz, bool grossOnly,
            bool usedUnvalidated, double warnPct, double idleLo, double idleHi)
        {
            // Idle ROUGHNESS is a tight hunt around the idle point (tens of RPM). A brief throttle
            // blip lands inside the wide ±300 idle window and inflates the raw CoV, faking
            // "instability" on a healthy engine. Restrict to samples NEAR the idle median so a
            // transient excursion can't masquerade as roughness; if a capture is all transient,
            // few samples survive and the module stays silent rather than crying wolf.
            const double IdleRoughnessBandRpm = 150.0;
            var idle = values.Where(v => v >= idleLo && v <= idleHi
                                         && Math.Abs(v - median) <= IdleRoughnessBandRpm).ToList();
            if (idle.Count < 5)
                return null;

            double cov = SignalMath.CoefficientOfVariation(idle);
            double covPct = cov * 100.0;

            if (covPct <= warnPct)
                return null; // steady idle — no roughness indicated

            double lo = idle.Min();
            double hi = idle.Max();

            var result = NewResult("Idle Instability");
            result.Hypothesis = "Idle instability — misfire or mechanical roughness. Idle RPM is " +
                                "hunting more than a healthy engine holds, consistent with an " +
                                "intermittent combustion or air-metering fault.";
            result.Severity = DiagnosticSeverity.Medium;

            result.Evidence
                .Measure("Idle RPM CoV", covPct, 0.0, warnPct, "%",
                         "Coefficient of variation of idle RPM. Above the threshold the idle is " +
                         "hunting rather than holding steady.")
                .Info("Idle samples", idle.Count.ToString(CultureInfo.InvariantCulture),
                      $"of {values.Count} total RPM samples; median {median:0} RPM.")
                .Info("Idle RPM range",
                      string.Format(CultureInfo.InvariantCulture, "{0:0}–{1:0} RPM", lo, hi));

            AddResolutionEvidence(result, estHz, grossOnly);
            AddConfoundEvidence(result);

            // Confidence: base 0.30, scaled toward 0.70 with the overshoot, attenuated
            // for a thin idle window.
            double overage = (covPct - warnPct) / warnPct;
            double sampleFactor = SignalMath.Clamp(idle.Count / 30.0, 0.45, 1.0);
            result.Confidence = SignalMath.Clamp((0.30 + Math.Min(0.4, overage * 0.4)) * sampleFactor, 0.0, 1.0);

            result.NextTest = "Watch Mode 06 misfire counters (MID 0xA1-0xA8) live; run a " +
                              "cylinder-balance injector-cut test.";
            result.SuspectComponents = new List<string>
            {
                "Misfire (ignition / injector / compression on one cylinder)",
                "Vacuum leak",
                "IAC valve / throttle-body fouling",
                "Injector fouling or imbalance",
            };

            ApplyAdvisory(result, usedUnvalidated, grossOnly, idle.Count);
            return result;
        }

        /// <summary>
        /// Records the sample-rate honesty steps: PID 0x0C is too slow to localise
        /// a cylinder, and at &lt;10 Hz it only resolves a gross imbalance.
        /// </summary>
        private static void AddResolutionEvidence(DiagnosticResult result, double estHz, bool grossOnly)
        {
            if (grossOnly)
            {
                result.Evidence.Info("Sample rate",
                    string.Format(CultureInfo.InvariantCulture, "{0:0.#} Hz", estHz),
                    "Below 10 Hz on PID 0x0C — only a GROSS compression imbalance is resolvable; " +
                    "a small single-cylinder weakness may be missed.");
            }

            result.Evidence.Inconclusive("Per-cylinder localisation", "not available", "cylinder identity",
                "OBD RPM (PID 0x0C) cannot identify WHICH cylinder is weak — that requires a CKP-scope " +
                "capture or a high-rate vendor DID synchronised to cylinder position.");
        }

        /// <summary>
        /// Records that the two physical confounds the brief marks mandatory for
        /// crank-speed misfire analysis — reluctor-wheel machining error (a fixed
        /// per-tooth bias) and torsional crank resonance (an RPM-locked artefact) —
        /// are NOT corrected at OBD PID rate: correcting them needs a high-rate,
        /// cylinder-synchronised crank signal (fuel-cut decel learn + order-domain
        /// filter).  Surfaced so a technician does not read the CoV as clean of them.
        /// </summary>
        private static void AddConfoundEvidence(DiagnosticResult result)
        {
            result.Evidence.Inconclusive("Reluctor / resonance confounds", "not corrected",
                "reluctor-error subtracted + order-domain filtered",
                "Reluctor-wheel machining error and torsional crank resonance both masquerade as ripple. " +
                "Correcting them needs a high-rate, cylinder-synchronised crank signal (learn the wheel error " +
                "on a fuel-cut decel; reject resonance in the angular/order domain) — impossible at OBD PID rate, " +
                "so a genuine imbalance and these artefacts cannot be fully separated here.");
        }

        /// <summary>Coefficient of variation of the RESIDUAL after removing a linear
        /// trend — the per-stroke ripple, with a monotonic start-up ramp taken out so
        /// it cannot inflate the statistic.  Falls back to the plain CoV for &lt; 3
        /// samples.</summary>
        private static double DetrendedCoV(IReadOnlyList<double> v)
        {
            int n = v == null ? 0 : v.Count;
            if (n < 3) return SignalMath.CoefficientOfVariation(v);
            var idx = new double[n];
            for (int i = 0; i < n; i++) idx[i] = i;
            double slope = SignalMath.Slope(idx, v);
            double mean = SignalMath.Mean(v);
            double xbar = (n - 1) / 2.0;
            double s2 = 0;
            for (int i = 0; i < n; i++)
            {
                double fit = mean + slope * (i - xbar);   // linear trend line through the mean
                double resid = v[i] - fit;
                s2 += resid * resid;
            }
            double residStd = Math.Sqrt(s2 / n);
            return Math.Abs(mean) < 1e-9 ? 0.0 : residStd / Math.Abs(mean);
        }

        /// <summary>
        /// Sets the advisory flag and reason.  A Tier-1 result is advisory whenever
        /// it rests on spec-seeded (unvalidated) thresholds, thin data, or a
        /// gross-only sample rate — this module's thresholds are always seeded, so
        /// the result is always advisory; the reason spells out the specific cause.
        /// </summary>
        private static void ApplyAdvisory(DiagnosticResult result, bool usedUnvalidated, bool grossOnly, int usableSamples)
        {
            var reasons = new List<string>();

            if (usedUnvalidated)
                reasons.Add("thresholds are spec-seeded, not validated on this platform");
            if (grossOnly)
                reasons.Add("PID 0x0C sample rate resolves gross imbalance only, not per-cylinder");
            if (usableSamples < 40)
                reasons.Add($"only {usableSamples} usable samples in the diagnostic window");
            reasons.Add("reluctor-wheel machining error and torsional crank resonance are NOT corrected at OBD rate "
                        + "and can mimic imbalance");

            // This module never emits a non-advisory result.
            result.Advisory = true;
            result.AdvisoryReason = reasons.Count > 0
                ? string.Join("; ", reasons)
                : "thresholds are spec-seeded, not validated on this platform";
        }
    }
}
