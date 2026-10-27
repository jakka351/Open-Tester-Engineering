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
//  Tester Present Specialist Automotive Solutions — T2 Analytical-Redundancy Sensor Cross-Check (Tier-2)
//
//  A lying sensor is invisible when read alone: a MAF that under-reports still
//  produces a smooth, plausible g/s trace.  But the engine's own physics tie
//  several sensors together, so a faulty one betrays itself by disagreeing with
//  the others.  This module runs those physical relationships as ANALYTICAL
//  REDUNDANCY: it PREDICTS one sensor from the rest and treats the RESIDUAL
//  (prediction − measurement) as the fault signal.
//
//  Redundancy pairs implemented (each runs only when its inputs are present):
//
//   1. SPEED-DENSITY vs MAF — the ideal-gas air-mass estimate must agree with
//      the measured MAF.  Air density rho = (MAP·1000)/(R·IAT_K) with R=287.05
//      J/kg·K; a 4-stroke fills its displacement every two crank revolutions, so
//      volumetric flow = (RPM/2)/60 · Vd · VE and predicted air mass flow is
//      rho·volFlow·1000 g/s.  A large residual means one of MAF/MAP/IAT is
//      inconsistent; the sign plus the fuel-trim direction points at the culprit.
//
//   2. COLD-SOAK TEMPERATURE AGREEMENT — right after a cold start the intake air
//      and coolant have equalised with ambient, so IAT ≈ ECT ≈ ambient.  A large
//      cold-start split means one temperature sensor is biased; the reading
//      furthest from ambient is the outlier.
//
//   3. IDLE THROTTLE PLAUSIBILITY — a steadily idling engine must show a nearly
//      closed throttle.  A high TPS while the engine idles at its target speed is
//      internally inconsistent with the low airflow it is actually producing.
//
//  Every finding carries the predicted-vs-measured residual as evidence, a
//  calibrated confidence, and the single most discriminating next test.  The
//  models rest on spec-seeded geometry (displacement, VE) and thresholds, so
//  results are ADVISORY until the calibration is validated on a real vehicle.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using TesterPresent.OBD2.Intelligence;

namespace TesterPresent.OBD2.Intelligence.Tier2
{
    /// <summary>
    /// T2 — Analytical-Redundancy Sensor Cross-Check.  Predicts one sensor from
    /// the physics relating it to the others and flags the residual, catching a
    /// sensor that lies convincingly on its own but cannot agree with its peers.
    /// Reads the snapshot + context only; emits zero or more ranked hypotheses.
    /// </summary>
    public sealed class AnalyticalRedundancyModule : DiagnosticModuleBase
    {
        // Universal gas constant for dry air, J/(kg·K).  rho = P/(R·T).
        private const double R_AIR = 287.05;
        private const double KELVIN = 273.15;

        // Speed-density validity window: only score samples where the engine is
        // actually running and metering a meaningful airflow, so cranking / DFCO
        // transients do not poison the residual.
        private const double SD_MIN_RPM = 400.0;      // below this: not a steady metering regime
        // The fixed-VE speed-density model only holds under load. At idle/light load the true
        // manifold-referenced VE is genuinely ~0.5-0.65 (residual-gas dilution), which the 0.85
        // model over-predicts, making a HEALTHY MAF read ~30% low → a false "dirty MAF" verdict.
        // Only judge MAF vs speed-density under load (MAP ≥ this).
        private const double SD_MIN_LOAD_KPA = 60.0;
        private const double SD_MIN_PRED_GS = 0.3;    // predicted airflow floor (g/s) before a ratio means anything
        private const int    SD_MIN_SAMPLES = 3;      // paired samples needed to trust the mean residual

        // Fuel-trim sign that corroborates a MAF-under-report reading (LTFT adding fuel).
        private const double LEAN_TRIM_PCT = 5.0;

        private DiagnosticRequirements _requirements;

        /// <inheritdoc/>
        public override string ModuleId => "T2";

        /// <inheritdoc/>
        public override string DisplayName => "Analytical-Redundancy Sensor Cross-Check";

        /// <inheritdoc/>
        public override DiagnosticTier Tier => DiagnosticTier.Tier2;

        /// <inheritdoc/>
        // RequiredSignals is intentionally empty: the module runs whatever
        // redundancy pairs it finds and returns empty when none are present.
        public override DiagnosticRequirements Requirements =>
            _requirements ?? (_requirements = new DiagnosticRequirements
            {
                RequiredSignals = new List<string>(),
                MinSamples = 5,
                MayRecommendActiveControl = false,
            });

        /// <summary>
        /// Evaluate each redundancy relationship whose inputs are present and emit
        /// a hypothesis for every physically-significant sensor disagreement.
        /// </summary>
        protected override IReadOnlyList<DiagnosticResult> AnalyzeCore(
            DiagnosticSnapshot snapshot, DiagnosticContext context)
        {
            var results = new List<DiagnosticResult>();
            bool usedUnvalidated = false;

            // ── Calibration constants (spec-seeded until validated) ───────────
            double dispCc        = Cal(context, "Engine.DisplacementCc", 2000.0, ref usedUnvalidated);
            double ve            = Cal(context, "Engine.VolumetricEff",  0.85,   ref usedUnvalidated);
            double mafTolPct     = Cal(context, "T2.MafModelTolPct",     20.0,   ref usedUnvalidated);
            double mapTolKpa     = Cal(context, "T2.MapModelTolKpa",     10.0,   ref usedUnvalidated);
            double coldDeltaC    = Cal(context, "T2.IatEctColdDeltaC",   8.0,    ref usedUnvalidated);
            double coldRuntimeS  = Cal(context, "T2.ColdStartRuntimeS",  5.0,    ref usedUnvalidated);
            double idleRpm       = Cal(context, "Engine.IdleRpm",        800.0,  ref usedUnvalidated);
            double tpsIdleMaxPct = Cal(context, "T2.TpsIdleMaxPct",      10.0,   ref usedUnvalidated);

            double vdLitres = dispCc / 1000.0;

            // A Tier-2 model rests on spec-seeded geometry/thresholds — advisory
            // unless a validated platform calibration is loaded.
            bool advisory = usedUnvalidated
                            || context == null
                            || context.Calibration == null
                            || !context.Calibration.IsValidated;
            string advisoryBase = advisory
                ? "physical-model geometry (displacement/VE) and thresholds are spec-seeded, not validated on this platform"
                : null;

            bool anyPair = false;

            // ── Pair 1: speed-density vs MAF ──────────────────────────────────
            // This cross-check compares a MEASURED MAF against the ideal-gas
            // speed-density prediction, so it needs a real MAF AND a MAP.  Honour
            // the declared air-metering configuration: a speed-density engine has
            // no MAF to compare, so the whole "MAF reads X% low" verdict would be
            // garbage and MUST be suppressed on a MAF-less engine (a bogus non-zero
            // MAF PID can still hold data, so gate on HasMaf, not signal presence).
            if (snapshot.HasMaf && snapshot.HasMap
                && HasData(snapshot, CanonicalSignals.Map) && HasData(snapshot, CanonicalSignals.IntakeAirTemp)
                && HasData(snapshot, CanonicalSignals.Rpm) && HasData(snapshot, CanonicalSignals.Maf))
            {
                anyPair = true;
                var r = AnalyzeSpeedDensity(snapshot, vdLitres, ve, mafTolPct, mapTolKpa,
                                            advisory, advisoryBase);
                if (r != null) results.Add(r);
            }
            else if (!snapshot.HasMaf && snapshot.HasMap)
            {
                // Speed-density engine (MAP, no MAF): explain WHY the MAF
                // cross-check is absent rather than silently dropping it.
                anyPair = true;
                results.Add(BuildSpeedDensityNotApplicable());
            }

            // ── Pair 2: cold-soak temperature agreement ───────────────────────
            if (HasData(snapshot, CanonicalSignals.IntakeAirTemp) && HasData(snapshot, CanonicalSignals.Coolant)
                && HasData(snapshot, CanonicalSignals.EngineRunTime))
            {
                anyPair = true;
                var r = AnalyzeColdSoakTemps(snapshot, coldDeltaC, coldRuntimeS, advisory, advisoryBase);
                if (r != null) results.Add(r);
            }

            // ── Pair 3: idle throttle plausibility ────────────────────────────
            if (HasData(snapshot, CanonicalSignals.Rpm) && HasData(snapshot, CanonicalSignals.ThrottlePos))
            {
                anyPair = true;
                var r = AnalyzeIdleThrottle(snapshot, idleRpm, tpsIdleMaxPct, advisory, advisoryBase);
                if (r != null) results.Add(r);
            }

            // Honest empty return when no redundancy relationship is observable.
            if (!anyPair) return Array.Empty<DiagnosticResult>();

            return results;
        }

        // ── Pair 1: speed-density vs MAF ──────────────────────────────────────

        /// <summary>
        /// Compare measured MAF against the ideal-gas speed-density estimate,
        /// sample by sample, and classify a persistent residual.  The sign of the
        /// residual plus the fuel-trim direction discriminates a MAF that reads
        /// low (dirty/failing MAF) from one that reads high (MAP over-report or an
        /// unmetered-air leak downstream of the MAF).
        /// </summary>
        private DiagnosticResult AnalyzeSpeedDensity(
            DiagnosticSnapshot snap, double vdLitres, double ve,
            double mafTolPct, double mapTolKpa, bool advisory, string advisoryBase)
        {
            IReadOnlyList<double> mapV = snap.Series(CanonicalSignals.Map).Values();
            IReadOnlyList<double> iatV = snap.Series(CanonicalSignals.IntakeAirTemp).Values();
            IReadOnlyList<double> rpmV = snap.Series(CanonicalSignals.Rpm).Values();
            IReadOnlyList<double> mafV = snap.Series(CanonicalSignals.Maf).Values();

            int n = Math.Min(Math.Min(mapV.Count, iatV.Count), Math.Min(rpmV.Count, mafV.Count));
            double vdM3 = vdLitres / 1000.0; // litres → m^3

            var resAcc = new WelfordAccumulator();   // residual percentage
            var predAcc = new WelfordAccumulator();  // predicted MAF g/s
            var measAcc = new WelfordAccumulator();  // measured MAF g/s
            var mapAcc = new WelfordAccumulator();   // measured MAP kPa
            var mapImpliedAcc = new WelfordAccumulator(); // MAP implied by measured MAF

            for (int i = 0; i < n; i++)
            {
                double mapKpa = mapV[i];
                double iatK = iatV[i] + KELVIN;
                double rpm = rpmV[i];
                double mafMeas = mafV[i];

                // NaN/Inf guard: a single bad sample would slip past the sign/range checks
                // below (NaN < 400 is false), poison the Welford means, and fabricate an
                // air-metering fault with a NaN confidence. Drop non-finite samples outright.
                if (double.IsNaN(mapKpa) || double.IsInfinity(mapKpa)
                    || double.IsNaN(iatK) || double.IsInfinity(iatK)
                    || double.IsNaN(rpm) || double.IsInfinity(rpm)
                    || double.IsNaN(mafMeas) || double.IsInfinity(mafMeas)) continue;

                if (rpm < SD_MIN_RPM || mapKpa < SD_MIN_LOAD_KPA || iatK <= 0) continue;  // load gate: fixed-VE model invalid at idle

                // Ideal-gas air density and 4-stroke volumetric flow.
                double rho = (mapKpa * 1000.0) / (R_AIR * iatK);          // kg/m^3
                double volFlow = (rpm / 2.0) / 60.0 * vdM3 * ve;          // m^3/s (intake stroke every 2 revs)
                double mafPred = rho * volFlow * 1000.0;                  // g/s
                if (mafPred < SD_MIN_PRED_GS) continue;

                double residualPct = (mafMeas - mafPred) / mafPred * 100.0;

                // Invert the model for a kPa-domain cross-check: the MAP that WOULD
                // produce the measured MAF, holding IAT/RPM/VE fixed.
                double flowFactor = (volFlow * 1000.0) * (1000.0 / (R_AIR * iatK)); // mafPred per kPa of MAP
                double mapImplied = flowFactor > 1e-9 ? mafMeas / flowFactor : mapKpa;

                resAcc.Add(residualPct);
                predAcc.Add(mafPred);
                measAcc.Add(mafMeas);
                mapAcc.Add(mapKpa);
                mapImpliedAcc.Add(mapImplied);
            }

            if (resAcc.Count < SD_MIN_SAMPLES) return null;

            double meanRes = resAcc.Mean;
            if (Math.Abs(meanRes) <= mafTolPct) return null; // sensors agree — nothing to report

            double meanPred = predAcc.Mean;
            double meanMeas = measAcc.Mean;
            double meanMap = mapAcc.Mean;
            double mapResidualKpa = meanMap - mapImpliedAcc.Mean; // measured − MAF-implied

            bool mafReadsLow = meanRes < 0;
            double meanLtft = MeanLtft(snap, out bool haveTrims);
            bool leanTrims = haveTrims && meanLtft >= LEAN_TRIM_PCT;

            // Sample-rate honesty: a sparse capture weakens the residual.
            double hz = snap.Series(CanonicalSignals.Maf).EstimatedHz;
            bool slowRate = hz > 0 && hz < 1.0;

            var r = NewResult("Air-metering inconsistency (MAF vs speed-density)");
            r.Severity = DiagnosticSeverity.Medium;
            r.Confidence = ResidualConfidence(Math.Abs(meanRes), mafTolPct, resAcc.Count, slowRate);

            if (mafReadsLow)
            {
                r.Hypothesis =
                    $"Measured MAF averages {Fmt(meanMeas)} g/s but the ideal-gas speed-density model predicts "
                    + $"{Fmt(meanPred)} g/s from MAP/IAT/RPM — the MAF reads about {Fmt(Math.Abs(meanRes))}% LOW. "
                    + (leanTrims
                        ? $"Long-term fuel trim is lean (+{Fmt(meanLtft)}%), which corroborates a MAF that "
                          + "under-reports airflow: the ECU meters too little fuel, then trims lean to recover. "
                        : "")
                    + "The most likely cause is a dirty or failing MAF sensor (or, less commonly, a MAP/IAT "
                    + "that reads high and inflates the prediction).";
                r.SuspectComponents = new List<string>
                {
                    "MAF sensor (contaminated / drifting low)", "MAP sensor (reads high)", "IAT sensor (reads high)",
                    "Intake tract restriction upstream of MAF",
                };
                r.NextTest =
                    "Hold a steady mid-load cruise (~2500 rpm) and compare live MAF g/s to the speed-density "
                    + "calc; then clean or substitute a known-good MAF. If the residual and any lean trims "
                    + "collapse, the MAF was under-reporting — if they persist, cross-check MAP against baro at "
                    + "key-on (should read ambient) to expose a MAP over-report.";
            }
            else
            {
                r.Hypothesis =
                    $"Measured MAF averages {Fmt(meanMeas)} g/s but the speed-density model predicts only "
                    + $"{Fmt(meanPred)} g/s — the MAF reads about {Fmt(meanRes)}% HIGH relative to MAP/IAT/RPM. "
                    + "That points at a MAP sensor reading low (deflating the prediction) or unmetered air "
                    + "entering downstream of the MAF, rather than the MAF itself.";
                r.SuspectComponents = new List<string>
                {
                    "MAP sensor (reads low)", "Post-MAF induction leak (unmetered air)",
                    "MAF sensor (reads high)", "Vacuum reference to MAP",
                };
                r.NextTest =
                    "Check MAP against barometric pressure at key-on/engine-off — a low reading isolates the MAP "
                    + "sensor; if MAP is correct, smoke-test the induction between the MAF and the throttle for a "
                    + "post-MAF leak that adds unmetered air the MAF never counted.";
            }

            r.Evidence
                .Info("Speed-density inputs",
                      $"MAP {Fmt(meanMap)} kPa, IAT {Fmt(snap.Latest(CanonicalSignals.IntakeAirTemp))} °C, "
                      + $"RPM {Fmt(snap.Latest(CanonicalSignals.Rpm))}, Vd {Fmt(vdLitres)} L, VE {Fmt(ve)}",
                      $"Averaged over {resAcc.Count} valid samples (RPM ≥ {SD_MIN_RPM:0}).")
                .Measure("Measured vs predicted MAF", meanMeas, meanPred * (1 - mafTolPct / 100.0),
                         meanPred * (1 + mafTolPct / 100.0), "g/s",
                         $"Predicted {Fmt(meanPred)} g/s from rho·(RPM/2/60)·Vd·VE; measured must sit within "
                         + $"±{Fmt(mafTolPct)}% of it.")
                .Measure("MAF residual", meanRes, -mafTolPct, mafTolPct, "%",
                         $"(measured − predicted)/predicted. {(mafReadsLow ? "Negative ⇒ MAF under-reports." : "Positive ⇒ MAF over-reports / MAP low / post-MAF leak.")}")
                .Add("MAP cross-check",
                     $"measured {Fmt(meanMap)} kPa vs MAF-implied {Fmt(meanMap - mapResidualKpa)} kPa (Δ {Fmt(mapResidualKpa)} kPa)",
                     $"within ±{Fmt(mapTolKpa)} kPa",
                     Math.Abs(mapResidualKpa) <= mapTolKpa ? EvidenceVerdict.Pass : EvidenceVerdict.Fail,
                     "The MAP that would reproduce the measured MAF — a large gap says MAP and MAF disagree about the same air.");

            if (haveTrims)
                r.Evidence.Info("Long-term fuel trim", $"{Fmt(meanLtft)} %",
                                leanTrims ? "Lean bias corroborates a low-reading MAF." : "Trim is not clearly lean; weight the airflow residual more than the trim.");

            string reason = advisoryBase;
            if (slowRate)
                reason = (reason == null ? "" : reason + "; ") + $"MAF captured at {hz:0.#} Hz (below 1 Hz) — residual averaged over few, possibly non-steady samples";
            ApplyAdvisory(r, advisory || slowRate, reason);
            return r;
        }

        /// <summary>
        /// Speed-density engine (MAP, no MAF): the MAF-vs-speed-density redundancy
        /// pair is physically inapplicable — there is no measured MAF to compare.
        /// Emit a single low-severity Info note so the technician sees WHY the check
        /// is absent instead of it silently vanishing.
        /// </summary>
        private DiagnosticResult BuildSpeedDensityNotApplicable()
        {
            var r = NewResult("Air-metering redundancy not applicable (speed-density engine)");
            r.Severity = DiagnosticSeverity.Info;
            r.Confidence = 0.0;
            r.Hypothesis =
                "Speed-density metering — no MAF sensor to cross-check; air-metering redundancy via MAF "
                + "is not applicable to this engine.";
            r.NextTest =
                "None for air metering. The cold-soak temperature-agreement and idle-throttle checks still apply.";
            r.Evidence.Info("Air-metering configuration", "speed-density (MAP, no MAF)",
                            "No measured MAF exists on this engine, so the MAF-vs-speed-density pair cannot run.");
            r.Advisory = true;
            r.AdvisoryReason = "Informational: this engine has no MAF, so the MAF cross-check is not applicable.";
            return r;
        }

        // ── Pair 2: cold-soak temperature agreement ───────────────────────────

        /// <summary>
        /// After a cold soak the intake air and coolant have equalised with
        /// ambient, so IAT ≈ ECT ≈ ambient.  Only evaluated within the first few
        /// seconds of runtime; a large split there means one temperature sensor is
        /// biased, and the reading furthest from ambient (when known) is the outlier.
        /// </summary>
        private DiagnosticResult AnalyzeColdSoakTemps(
            DiagnosticSnapshot snap, double coldDeltaC, double coldRuntimeS,
            bool advisory, string advisoryBase)
        {
            double runtime = snap.Latest(CanonicalSignals.EngineRunTime);
            if (double.IsNaN(runtime) || runtime > coldRuntimeS) return null; // not a cold-start window

            double iat = snap.Latest(CanonicalSignals.IntakeAirTemp);
            double ect = snap.Latest(CanonicalSignals.Coolant);
            if (double.IsNaN(iat) || double.IsNaN(ect)) return null;

            double delta = iat - ect;
            if (Math.Abs(delta) <= coldDeltaC) return null; // agree within cold-soak tolerance

            // Use ambient to identify the outlier when available.
            double amb = snap.Latest(CanonicalSignals.AmbientAirTemp);
            bool haveAmb = !double.IsNaN(amb);
            string outlier;
            List<string> suspects;
            if (haveAmb)
            {
                bool iatFarther = Math.Abs(iat - amb) >= Math.Abs(ect - amb);
                outlier = iatFarther ? "IAT" : "ECT";
                suspects = iatFarther
                    ? new List<string> { "IAT sensor (biased at cold start)", "IAT wiring / connector" }
                    : new List<string> { "ECT sensor (biased at cold start)", "ECT wiring / connector" };
            }
            else
            {
                outlier = "IAT or ECT";
                suspects = new List<string>
                {
                    "IAT sensor", "ECT sensor", "IAT/ECT wiring or connector",
                };
            }

            var r = NewResult("Cold-start temperature sensor disagreement");
            r.Severity = DiagnosticSeverity.Medium;
            // Pass the EXCEEDANCE over the tolerance, not the raw split — DeltaConfidence
            // expects "amount past threshold" (cf. the idle-throttle call). Passing the full
            // delta inflated confidence for a split barely over the band.
            r.Confidence = DeltaConfidence(Math.Abs(delta) - coldDeltaC, coldDeltaC);
            r.Hypothesis =
                $"At {Fmt(runtime)} s of runtime (cold start) IAT reads {Fmt(iat)} °C and ECT reads {Fmt(ect)} °C — "
                + $"a {Fmt(Math.Abs(delta))} °C split. After a cold soak both should sit within a few degrees of "
                + $"ambient{(haveAmb ? $" ({Fmt(amb)} °C)" : "")}, so one sensor is biased"
                + (haveAmb ? $"; {outlier} is furthest from ambient and is the likely outlier." : ".");
            r.SuspectComponents = suspects;
            r.NextTest =
                "Cold-soak the vehicle overnight; IAT, ECT and ambient should read within a few °C — the outlier "
                + "is the faulty sensor.";

            r.Evidence
                .Info("Runtime window", $"{Fmt(runtime)} s (≤ {Fmt(coldRuntimeS)} s)",
                      "Early enough that intake air and coolant have not yet diverged from a warming engine.")
                .Measure("IAT − ECT split", Math.Abs(delta), 0.0, coldDeltaC, "°C",
                         "At a genuine cold start the two must agree within the cold-soak tolerance.");
            if (haveAmb)
                r.Evidence
                    .Info("IAT vs ambient", $"{Fmt(iat)} °C vs {Fmt(amb)} °C (Δ {Fmt(iat - amb)})", null)
                    .Info("ECT vs ambient", $"{Fmt(ect)} °C vs {Fmt(amb)} °C (Δ {Fmt(ect - amb)})",
                          $"{outlier} is the outlier against ambient.");

            ApplyAdvisory(r, advisory, advisoryBase);
            return r;
        }

        // ── Pair 3: idle throttle plausibility ────────────────────────────────

        /// <summary>
        /// A steadily idling engine holds a nearly closed throttle.  A high TPS
        /// while RPM sits at the idle target is inconsistent with the low airflow
        /// the engine is actually producing — the throttle-position channel and
        /// the engine's operating point disagree.
        /// </summary>
        private DiagnosticResult AnalyzeIdleThrottle(
            DiagnosticSnapshot snap, double idleRpm, double tpsIdleMaxPct,
            bool advisory, string advisoryBase)
        {
            IReadOnlyList<double> rpmV = snap.Series(CanonicalSignals.Rpm).Values();
            IReadOnlyList<double> tpsV = snap.Series(CanonicalSignals.ThrottlePos).Values();
            SignalSeries loadS = snap.Series(CanonicalSignals.EngineLoad);
            IReadOnlyList<double> loadV = (loadS != null && loadS.HasData) ? loadS.Values() : null;

            double band = Math.Max(150.0, idleRpm * 0.25); // ± window around the idle target
            int n = Math.Min(rpmV.Count, tpsV.Count);

            var tpsAcc = new WelfordAccumulator();
            var loadAcc = new WelfordAccumulator();
            for (int i = 0; i < n; i++)
            {
                // NaN/Inf guard: a non-finite RPM slips past the idle-band test (|NaN|>band
                // is false) and a NaN TPS then poisons the mean, fabricating a throttle-
                // implausible fault. Drop non-finite samples.
                if (double.IsNaN(rpmV[i]) || double.IsInfinity(rpmV[i])
                    || double.IsNaN(tpsV[i]) || double.IsInfinity(tpsV[i])) continue;
                if (Math.Abs(rpmV[i] - idleRpm) > band) continue; // only genuine idle samples
                tpsAcc.Add(tpsV[i]);
                if (loadV != null && i < loadV.Count && !double.IsNaN(loadV[i]) && !double.IsInfinity(loadV[i]))
                    loadAcc.Add(loadV[i]);
            }

            if (tpsAcc.Count < SD_MIN_SAMPLES) return null;      // not enough time at idle to judge
            double meanTps = tpsAcc.Mean;
            if (meanTps <= tpsIdleMaxPct) return null;           // throttle is plausibly closed — nothing to report

            var r = NewResult("Throttle-position implausible at idle");
            r.Severity = DiagnosticSeverity.Medium;
            r.Confidence = DeltaConfidence(meanTps - tpsIdleMaxPct, tpsIdleMaxPct);
            r.Hypothesis =
                $"The engine idles near its {Fmt(idleRpm)} rpm target yet TPS averages {Fmt(meanTps)}% "
                + $"(expected below {Fmt(tpsIdleMaxPct)}% at idle)"
                + (loadAcc.Count > 0 ? $", while calculated load stays low at {Fmt(loadAcc.Mean)}%" : "")
                + ". A high throttle reading with idle airflow is internally inconsistent — the TPS channel "
                + "disagrees with the operating point the engine is actually at.";
            r.SuspectComponents = new List<string>
            {
                "Throttle position sensor / APP correlation", "Throttle body (carbon / stuck plate)",
                "TPS wiring or reference voltage",
            };
            r.NextTest =
                "At a warm idle, watch TPS while blipping and releasing the throttle — it must return to its "
                + "closed baseline (typically < 5%). A baseline stuck high isolates the TPS/throttle body from a "
                + "genuine airflow demand.";

            r.Evidence
                .Info("Idle detection", $"{tpsAcc.Count} samples within ±{Fmt(band)} rpm of {Fmt(idleRpm)} rpm",
                      "Confirms the engine was actually idling, not decelerating through the idle band.")
                .Measure("TPS at idle", meanTps, 0.0, tpsIdleMaxPct, "%",
                         "A closed throttle at idle should read near zero.");
            if (loadAcc.Count > 0)
                r.Evidence.Info("Calculated load at idle", $"{Fmt(loadAcc.Mean)} %",
                                "Low load confirms the engine really is at idle airflow, so the high TPS is the outlier.");

            ApplyAdvisory(r, advisory, advisoryBase);
            return r;
        }

        // ── Helpers ───────────────────────────────────────────────────────────

        /// <summary>True if the named signal exists in the snapshot with samples.</summary>
        private static bool HasData(DiagnosticSnapshot snap, string name)
        {
            SignalSeries s;
            return snap != null && snap.TryGetSeries(name, out s) && s.HasData;
        }

        /// <summary>Mean long-term fuel trim across the available banks; haveTrims=false if none present.</summary>
        private static double MeanLtft(DiagnosticSnapshot snap, out bool haveTrims)
        {
            var vals = new List<double>();
            SignalSeries b1 = snap.Series(CanonicalSignals.LtftB1);
            SignalSeries b2 = snap.Series(CanonicalSignals.LtftB2);
            if (b1 != null && b1.HasData) vals.Add(b1.Mean);
            if (b2 != null && b2.HasData) vals.Add(b2.Mean);
            haveTrims = vals.Count > 0;
            return haveTrims ? vals.Average() : 0.0;
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
        /// Confidence in [0.4, 0.8] for a residual model: grows with how far the
        /// mean residual overshoots the tolerance and shrinks for thin/slow captures.
        /// </summary>
        private static double ResidualConfidence(double absResidual, double tol, long samples, bool slowRate)
        {
            double over = tol > 0 ? SignalMath.Clamp((absResidual - tol) / (2.0 * tol), 0.0, 1.0) : 0.0;
            double c = 0.40 + 0.40 * over;
            if (samples < 8) c -= 0.05;         // few paired samples
            if (slowRate) c -= 0.05;            // low capture rate
            return SignalMath.Clamp(c, 0.0, 0.80);
        }

        /// <summary>Confidence in [0.4, 0.8] from how far a delta exceeds its threshold.</summary>
        private static double DeltaConfidence(double over, double threshold)
        {
            double f = threshold > 0 ? SignalMath.Clamp(over / (2.0 * threshold), 0.0, 1.0) : 0.0;
            return SignalMath.Clamp(0.40 + 0.40 * f, 0.0, 0.80);
        }

        /// <summary>Stamp the advisory flag + reason onto a result.</summary>
        private static void ApplyAdvisory(DiagnosticResult r, bool advisory, string reason)
        {
            if (!advisory) return;
            r.Advisory = true;
            r.AdvisoryReason = string.IsNullOrEmpty(reason)
                ? "result rests on spec-seeded model parameters or thin data"
                : reason;
        }

        /// <summary>Format a possibly-NaN number compactly and culture-invariantly.</summary>
        private static string Fmt(double v)
        {
            if (double.IsNaN(v)) return "n/a";
            return v.ToString("0.#", CultureInfo.InvariantCulture);
        }
    }
}
