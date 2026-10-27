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
//  Tester Present Specialist Automotive Solutions — T3 RLS/Kalman Parameter Estimation (Tier-2, Prognostic)
//
//  Tier-1 asks "is this signal in range right now?".  Tier-2 prognostics asks a
//  harder question: "is a physical parameter of this engine slowly DRIFTING away
//  from where it should be?".  A worn, carboned or restricted engine still meters
//  a smooth, in-range airflow — nothing trips a limit — yet its VOLUMETRIC
//  EFFICIENCY (VE), the fraction of its swept displacement it actually inhales
//  per cycle, sags.  This module estimates VE from the vehicle's own sensors and
//  compares it to the platform baseline to catch that slow degradation.
//
//  MODEL — invert the speed-density (ideal-gas) air-mass relation for VE:
//
//    Air density from the ideal gas law:
//        rho   = (MAP_kPa · 1000) / (R_air · T_K)          [kg/m^3]
//        R_air = 287.05 J/(kg·K),  T_K = IAT_C + 273.15
//
//    A 4-stroke engine draws its full displacement Vd once every TWO crank
//    revolutions, so the IDEAL (VE=100%) volumetric intake flow is:
//        volFlow_ideal = (RPM / 2) / 60 · Vd_m3            [m^3/s]
//
//    The mass the engine WOULD inhale at VE=1 is rho·volFlow_ideal.  Divide the
//    MEASURED air mass (MAF) by that ideal to recover the actual VE:
//        VE_est = (MAF_g_s / 1000) / (rho · volFlow_ideal)   [dimensionless]
//
//    Each valid VE_est is fed into a scalar recursive-least-squares tracker
//    (regressor φ = 1, measurement y = VE_est) whose converged θ is a smoothed,
//    outlier-resistant VE estimate; the robust median is carried alongside as a
//    cross-check.  Samples below 400 rpm, or with non-physical rho / volFlow, are
//    dropped so cranking, idle-dashpot and DFCO transients never poison the fit —
//    VE is only meaningful under load in steady cruise.
//
//  DECISION:
//    baseline VE (cal "Engine.VolumetricEff", def 0.85).  If the estimate falls
//    below baseline·(1 − alarmPct/100) (alarmPct = cal "T3.VeDriftAlarmPct", def
//    8) the engine is breathing measurably worse than spec ⇒ VE degradation
//    (valve/intake carbon, cam-timing drift, restricted intake/exhaust, worn
//    rings).  A fleet store, when present, adds a z-score of the estimate against
//    the platform VE distribution at the same operating cell as corroboration.
//    An IMPLAUSIBLE estimate (>1.3 or <0.3) is treated as a MAF/MAP/IAT model
//    disagreement (deferred to T2 sensor cross-check), never as degradation.
//
//  ADVISORY: the model rests on spec-seeded displacement/VE geometry, and a
//  single-session estimate is a snapshot, not a trend — a true prognosis needs
//  multi-session history.  Results are therefore ADVISORY unless a validated
//  platform calibration is loaded, and additionally advisory on a slow capture.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using TesterPresent.OBD2.Intelligence;

namespace TesterPresent.OBD2.Intelligence.Tier2
{
    /// <summary>
    /// T3 — RLS/Kalman parameter estimation (prognostics).  Estimates volumetric
    /// efficiency from MAF and the speed-density relation, tracks it with a scalar
    /// RLS filter, and flags a shortfall against the platform baseline as slow
    /// breathing degradation.  Reads the snapshot + context only; emits at most
    /// one hypothesis, or an empty list when VE sits at or above baseline.
    /// </summary>
    public sealed class ParameterEstimationModule : DiagnosticModuleBase
    {
        // Ideal-gas constant for dry air, J/(kg·K); rho = P/(R·T).
        private const double R_AIR = 287.05;
        private const double KELVIN = 273.15;

        // Steady-state validity window for a meaningful VE estimate.
        private const double MIN_RPM = 400.0;      // below this: cranking / idle-dashpot / DFCO, not steady metering
        // The fixed-baseline VE model only holds under load. At idle/light cruise the manifold-
        // referenced VE is genuinely depressed (~0.5-0.65 from residual-gas dilution at low MAP),
        // which the 0.85 baseline would misread as "breathing loss" on a HEALTHY engine. Only admit
        // moderate-load samples (MAP ≥ this) so a low VE means degradation, not just low load.
        private const double MIN_LOAD_KPA = 60.0;
        private const int    MIN_VALID_SAMPLES = 8; // valid steady samples needed before the estimate is trusted

        // Physically-possible VE envelope.  A normally-aspirated engine lives
        // roughly in 0.30–1.05 VE; forced induction can exceed 1.0 but a VE above
        // 1.3 or below 0.3 from this model means the sensors, not the engine,
        // disagree — hand that to T2 rather than claim degradation.
        private const double VE_IMPLAUSIBLE_HI = 1.30;
        private const double VE_IMPLAUSIBLE_LO = 0.30;

        // Capture-rate floor below which a within-session estimate is extra-thin.
        private const double MIN_STEADY_RATE_HZ = 1.0;

        private DiagnosticRequirements _requirements;

        /// <inheritdoc/>
        public override string ModuleId => "T3";

        /// <inheritdoc/>
        public override string DisplayName => "RLS/Kalman Parameter Estimation (Prognostics)";

        /// <inheritdoc/>
        public override DiagnosticTier Tier => DiagnosticTier.Tier2;

        /// <inheritdoc/>
        public override DiagnosticRequirements Requirements =>
            _requirements ?? (_requirements = new DiagnosticRequirements
            {
                RequiredSignals = new List<string>
                {
                    CanonicalSignals.Rpm,
                    CanonicalSignals.Maf,
                    CanonicalSignals.Map,
                    CanonicalSignals.IntakeAirTemp,
                },
                MinSamples = 20,
                NeedsFleetStore = false,        // fleet is corroborative, not required
                MayRecommendActiveControl = false,
            });

        /// <summary>
        /// Estimate VE across the steady-state samples in the capture and, if it
        /// has drifted below the platform baseline, emit a degradation hypothesis;
        /// if the estimate is non-physical, emit a model-inconsistency advisory
        /// instead; otherwise return empty.
        /// </summary>
        protected override IReadOnlyList<DiagnosticResult> AnalyzeCore(
            DiagnosticSnapshot snapshot, DiagnosticContext context)
        {
            // Speed-density guard: T3 recovers VE by INVERTING the speed-density
            // relation with a MEASURED MAF.  Requirements lists MAF, but a bogus
            // non-zero MAF PID on a speed-density car can still satisfy that gate —
            // honour the declared air-metering config here.  With no real MAF the
            // inversion has no measured air mass to invert, so VE is not estimable:
            // return empty rather than a garbage VE verdict.
            if (snapshot == null || !snapshot.HasMaf)
            {
                context?.Log("[T3] VE estimation skipped: no measured MAF (speed-density / TMAP engine) — the speed-density inversion requires a real MAF.");
                return Array.Empty<DiagnosticResult>();
            }

            bool usedUnvalidated = false;

            // ── Calibration constants (spec-seeded until validated) ───────────
            double dispCc   = Cal(context, "Engine.DisplacementCc", 2000.0, ref usedUnvalidated);
            double baseline = Cal(context, "Engine.VolumetricEff",  0.85,   ref usedUnvalidated);
            double alarmPct = Cal(context, "T3.VeDriftAlarmPct",    8.0,    ref usedUnvalidated);

            double vdM3 = (dispCc / 1000.0) / 1000.0;   // cc → litre → m^3
            if (vdM3 <= 0 || baseline <= 0) return Array.Empty<DiagnosticResult>();

            // ── Sample-aligned VE inversion over the steady-state window ──────
            IReadOnlyList<double> rpmV = snapshot.Series(CanonicalSignals.Rpm).Values();
            IReadOnlyList<double> mafV = snapshot.Series(CanonicalSignals.Maf).Values();
            IReadOnlyList<double> mapV = snapshot.Series(CanonicalSignals.Map).Values();
            IReadOnlyList<double> iatV = snapshot.Series(CanonicalSignals.IntakeAirTemp).Values();

            int n = Math.Min(Math.Min(rpmV.Count, mafV.Count), Math.Min(mapV.Count, iatV.Count));

            // φ = 1 constant regressor: RLS converges to a covariance-weighted mean
            // of VE_est.  Forgetting factor near 1 — VE drifts slowly, so weight the
            // whole steady window rather than chasing the last sample.
            var rls = new ScalarRls(initialTheta: 0.0, initialCovariance: 1e4, forgettingFactor: 0.995);
            var veList = new List<double>();        // for the robust median cross-check
            var rpmAcc = new WelfordAccumulator();  // mean operating point (for the fleet cell)
            var mapAcc = new WelfordAccumulator();

            for (int i = 0; i < n; i++)
            {
                double rpm = rpmV[i];
                double mafGs = mafV[i];
                double mapKpa = mapV[i];
                double iatK = iatV[i] + KELVIN;

                if (rpm < MIN_RPM || mapKpa < MIN_LOAD_KPA || iatK <= 0 || mafGs <= 0) continue;  // load gate: VE model invalid at idle/light load
                if (double.IsNaN(mafGs) || double.IsNaN(mapKpa) || double.IsNaN(rpm)) continue;   // dead-PID NaN must not poison the fit

                double rho = (mapKpa * 1000.0) / (R_AIR * iatK);   // kg/m^3
                double volFlowIdeal = (rpm / 2.0) / 60.0 * vdM3;   // m^3/s (one displacement per 2 revs)
                if (rho <= 0 || volFlowIdeal <= 0) continue;

                double veEst = (mafGs / 1000.0) / (rho * volFlowIdeal);
                if (double.IsNaN(veEst) || double.IsInfinity(veEst) || veEst <= 0) continue;

                rls.Update(1.0, veEst);
                veList.Add(veEst);
                rpmAcc.Add(rpm);
                mapAcc.Add(mapKpa);
            }

            // Not enough steady, valid metering to trust an estimate — stay silent.
            if (veList.Count < MIN_VALID_SAMPLES) return Array.Empty<DiagnosticResult>();

            double veRls    = rls.Theta;
            double veMedian = SignalMath.Median(veList);
            // Headline estimate: the RLS θ, but fall back to the robust median if
            // the fit landed outside the physical envelope (a few wild transients
            // can drag a mean; the median resists them).
            double veEstimate = (veRls >= VE_IMPLAUSIBLE_LO && veRls <= VE_IMPLAUSIBLE_HI) ? veRls : veMedian;
            double estSpreadPct = veMedian > 1e-6 ? Math.Abs(veRls - veMedian) / veMedian * 100.0 : 0.0;

            double alarmLow = baseline * (1.0 - alarmPct / 100.0);

            // Sample-rate honesty for the within-session estimate.
            double hz = snapshot.Series(CanonicalSignals.Maf).EstimatedHz;
            bool slowRate = hz > 0 && hz < MIN_STEADY_RATE_HZ;

            // A Tier-2 prognostic rests on spec-seeded geometry AND a single-session
            // snapshot — always advisory unless a validated calibration is loaded.
            bool calValidated = context != null && context.Calibration != null && context.Calibration.IsValidated;
            bool advisory = usedUnvalidated || !calValidated || true; // within-session estimate is inherently advisory

            // ── Case A: implausible estimate ⇒ model/sensor inconsistency ─────
            if (veEstimate > VE_IMPLAUSIBLE_HI || veEstimate < VE_IMPLAUSIBLE_LO)
                return One(BuildModelInconsistency(
                    snapshot, veEstimate, veMedian, veList.Count, baseline,
                    rpmAcc.Mean, mapAcc.Mean, dispCc, hz, slowRate));

            // ── Case B: VE below the drift alarm ⇒ breathing degradation ──────
            if (veEstimate < alarmLow)
                return One(BuildDegradation(
                    snapshot, context, veEstimate, veMedian, estSpreadPct, veList.Count,
                    baseline, alarmPct, alarmLow, rpmAcc, mapAcc, dispCc, hz, slowRate, advisory));

            // ── Case C: VE at or above baseline tolerance ⇒ nothing to report ─
            return Array.Empty<DiagnosticResult>();
        }

        // ── Case B builder: volumetric-efficiency degradation ─────────────────

        /// <summary>
        /// Build the VE-degradation hypothesis: the engine is inhaling measurably
        /// less than its baseline displacement fraction, tying together carbon,
        /// cam-timing drift, intake/exhaust restriction and worn rings.  Adds a
        /// fleet z-score at the operating cell when a fleet store is present.
        /// </summary>
        private DiagnosticResult BuildDegradation(
            DiagnosticSnapshot snap, DiagnosticContext ctx,
            double ve, double veMedian, double estSpreadPct, int samples,
            double baseline, double alarmPct, double alarmLow,
            WelfordAccumulator rpmAcc, WelfordAccumulator mapAcc,
            double dispCc, double hz, bool slowRate, bool advisory)
        {
            double shortfallPct = (baseline - ve) / baseline * 100.0;

            var r = NewResult("Volumetric-efficiency degradation (breathing loss)");
            r.Severity = DiagnosticSeverity.Medium;

            // Fleet corroboration: compare the estimate to the platform's VE
            // distribution at this RPM×MAP operating cell.
            double fleetZ = double.NaN;
            long fleetCount = 0;
            double fleetMean = double.NaN, fleetStd = double.NaN;
            if (ctx != null && ctx.Fleet != null)
            {
                var grid = new OperatingPointGrid(16, 16, 0, 8000, 0, 300, "RPM", "MAP");
                var (cx, cy) = grid.CellOf(rpmAcc.Mean, mapAcc.Mean);
                FleetStat fs = ctx.Fleet.Query(snap.Platform ?? "Generic", FLEET_VE_SIGNAL, cx, cy);
                fleetCount = fs.Count;
                if (fs.HasEnoughData(FLEET_MIN_COUNT) && fs.StdDev > 1e-9)
                {
                    fleetMean = fs.Mean;
                    fleetStd = fs.StdDev;
                    fleetZ = SignalMath.ZScore(ve, fs.Mean, fs.StdDev);
                }
            }

            r.Confidence = DegradationConfidence(ve, alarmLow, baseline, samples, slowRate, estSpreadPct, fleetZ);

            bool fleetCorroborates = !double.IsNaN(fleetZ) && fleetZ <= -1.5;
            r.Hypothesis =
                $"Estimated volumetric efficiency is {Pct(ve)} against a {Pct(baseline)} baseline — the engine is "
                + $"breathing about {Fmt(shortfallPct)}% below spec (alarm at {Fmt(alarmPct)}% drift, i.e. {Pct(alarmLow)}). "
                + "VE is recovered by inverting the speed-density air-mass relation from measured MAF, MAP, IAT and RPM, "
                + "so a genuine shortfall means less air per cycle than the displacement should admit. "
                + "Typical causes are intake/valve carbon, cam-timing drift (stretched chain / VVT), a restricted "
                + "intake or exhaust, or worn rings/valves losing sealing."
                + (fleetCorroborates
                    ? $" Fleet data corroborates: this estimate sits {Fmt(Math.Abs(fleetZ))}σ below the platform mean at the same operating point."
                    : "");

            r.SuspectComponents = new List<string>
            {
                "Intake / valve carbon build-up",
                "Cam timing drift (stretched timing chain / VVT phaser)",
                "Restricted intake or exhaust (air filter, clogged catalyst / DPF)",
                "Worn rings or valves (loss of cylinder sealing)",
            };

            r.NextTest =
                "Confirm with an intake/exhaust restriction check (pre-cat backpressure, air-filter/intake inspection) "
                + "and a cam-timing / valve inspection, then re-measure VE at the SAME load points after cleaning or "
                + "correction — a VE that recovers isolates a reversible restriction/carbon cause from mechanical wear.";

            r.Evidence
                .Measure("Estimated VE", ve, alarmLow, baseline, "",
                         $"RLS θ over {samples} steady samples; below baseline·(1−{Fmt(alarmPct)}%) ⇒ degradation.")
                .Info("Baseline VE",
                      $"{Pct(baseline)} (alarm below {Pct(alarmLow)})",
                      ctx != null && ctx.IsCalibrated
                          ? "From validated platform calibration."
                          : "Spec-seeded baseline (Engine.VolumetricEff) — not yet validated on this platform.")
                .Info("Steady-state window",
                      $"{samples} valid samples at RPM {Fmt(rpmAcc.Mean)} (≥ {MIN_RPM:0}), MAP {Fmt(mapAcc.Mean)} kPa",
                      $"Displacement {Fmt(dispCc)} cc; cranking/idle/DFCO samples excluded so the estimate reflects loaded breathing.")
                .Info("RLS θ vs median cross-check",
                      $"θ {Pct(ve)} vs median {Pct(veMedian)} (Δ {Fmt(estSpreadPct)}%)",
                      estSpreadPct > 10.0
                          ? "θ and the robust median diverge — the steady window is noisy; treat the estimate as coarse."
                          : "θ and the robust median agree — the estimate is stable across the window.");

            if (fleetCount > 0)
                r.Evidence.Add("Fleet VE at operating cell",
                    double.IsNaN(fleetZ)
                        ? $"n={fleetCount} (below {FLEET_MIN_COUNT}-sample threshold)"
                        : $"z {Fmt(fleetZ)}σ vs μ {Pct(fleetMean)} ± {Fmt(fleetStd * 100.0)}pp (n={fleetCount})",
                    "within ±1.5σ of platform mean",
                    double.IsNaN(fleetZ) ? EvidenceVerdict.Inconclusive
                        : (fleetZ <= -1.5 ? EvidenceVerdict.Fail : EvidenceVerdict.Pass),
                    "Peer-fleet distribution of VE at this RPM×MAP cell — a strong negative z corroborates real degradation over a spec-baseline artefact.");

            string reason =
                "VE degradation rests on a spec-seeded baseline/displacement and a SINGLE-SESSION estimate — a true "
                + "prognosis needs multi-session VE history to separate drift from a one-off operating condition";
            if (slowRate)
                reason += $"; MAF captured at {Fmt(hz)} Hz (below {MIN_STEADY_RATE_HZ:0} Hz), so the estimate averages few, possibly non-steady samples";
            ApplyAdvisory(r, advisory || slowRate, reason);
            return r;
        }

        // ── Case A builder: model / sensor inconsistency ──────────────────────

        /// <summary>
        /// An estimate outside the physical VE envelope is not degradation — it is
        /// the speed-density model and the MAF disagreeing, which means a MAF, MAP
        /// or IAT bias.  Emit an informational advisory and defer the sensor
        /// isolation to T2 (analytical redundancy) rather than blame the engine.
        /// </summary>
        private DiagnosticResult BuildModelInconsistency(
            DiagnosticSnapshot snap, double ve, double veMedian, int samples,
            double baseline, double meanRpm, double meanMap, double dispCc,
            double hz, bool slowRate)
        {
            bool tooHigh = ve > VE_IMPLAUSIBLE_HI;

            var r = NewResult("VE estimate implausible — MAF/MAP/IAT model disagreement");
            r.Severity = DiagnosticSeverity.Low;
            r.Confidence = 0.35;   // deliberately low: this is a "don't trust the number" flag, not a fault call
            r.Hypothesis =
                $"The speed-density VE estimate came out at {Pct(ve)} — "
                + (tooHigh
                    ? $"above the {Pct(VE_IMPLAUSIBLE_HI)} physical ceiling for this model. Measured MAF is far HIGHER than "
                      + "MAP/IAT/RPM predict, which points at a MAF reading high, a MAP reading low, or unmetered air, "
                      + "not the engine breathing better than its displacement allows."
                    : $"below the {Pct(VE_IMPLAUSIBLE_LO)} physical floor. Measured MAF is far LOWER than MAP/IAT/RPM predict, "
                      + "pointing at a MAF reading low or a MAP/IAT reading high.")
                + " This is a sensor/model inconsistency, so VE cannot be estimated — no degradation is claimed. "
                + "Isolate the biased sensor with T2 (analytical-redundancy cross-check) before trusting any VE prognosis.";
            r.SuspectComponents = new List<string>
            {
                tooHigh ? "MAF sensor (reads high)" : "MAF sensor (reads low / contaminated)",
                tooHigh ? "MAP sensor (reads low)"  : "MAP sensor (reads high)",
                "IAT sensor (biased)",
                tooHigh ? "Unmetered air downstream of the MAF" : "Intake restriction upstream of the MAF",
            };
            r.NextTest =
                "Run the T2 analytical-redundancy sensor cross-check: compare MAF against the speed-density prediction and "
                + "MAP against barometric pressure at key-on. Correct the biased sensor, then re-run T3 — VE is only "
                + "meaningful once MAF/MAP/IAT agree.";

            r.Evidence
                .Info("VE estimate", $"{Pct(ve)} (median {Pct(veMedian)})",
                      $"Outside the plausible {Pct(VE_IMPLAUSIBLE_LO)}–{Pct(VE_IMPLAUSIBLE_HI)} envelope over {samples} samples.")
                .Info("Operating point", $"RPM {Fmt(meanRpm)}, MAP {Fmt(meanMap)} kPa, Vd {Fmt(dispCc)} cc",
                      "Inputs to the inverted speed-density relation.")
                .Add("Physical plausibility", $"{Pct(ve)}",
                     $"{Pct(VE_IMPLAUSIBLE_LO)}–{Pct(VE_IMPLAUSIBLE_HI)}",
                     EvidenceVerdict.Fail,
                     "A VE outside this band cannot be a real engine — the MAF and speed-density model disagree.");

            r.Advisory = true;
            r.AdvisoryReason =
                "MAF and the speed-density model disagree by more than a real engine can, so VE is not estimable this "
                + "session; deferred to T2 for sensor isolation"
                + (slowRate ? $" (MAF also captured at only {Fmt(hz)} Hz)" : "") + ".";
            return r;
        }

        // ── Helpers ───────────────────────────────────────────────────────────

        /// <summary>Fleet-store signal key for the VE distribution.</summary>
        private const string FLEET_VE_SIGNAL = "VE";
        /// <summary>Minimum fleet samples in a cell before its z-score is trusted.</summary>
        private const int FLEET_MIN_COUNT = 30;

        /// <summary>Wrap a single result as a read-only list.</summary>
        private static IReadOnlyList<DiagnosticResult> One(DiagnosticResult r)
            => r == null ? Array.Empty<DiagnosticResult>() : new[] { r };

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
        /// Confidence in [0.4, 0.85] for the degradation call: grows with how far
        /// VE undershoots the alarm threshold, tempered by thin/slow/noisy captures
        /// and lifted when the fleet z-score independently corroborates.
        /// </summary>
        private static double DegradationConfidence(
            double ve, double alarmLow, double baseline, int samples,
            bool slowRate, double estSpreadPct, double fleetZ)
        {
            // Normalise the undershoot by the alarm margin (baseline − alarmLow).
            double margin = Math.Max(1e-6, baseline - alarmLow);
            double over = SignalMath.Clamp((alarmLow - ve) / (2.0 * margin), 0.0, 1.0);
            double c = 0.45 + 0.35 * over;
            if (samples < 15) c -= 0.05;                 // thin steady window
            if (slowRate) c -= 0.05;                     // low capture rate
            if (estSpreadPct > 10.0) c -= 0.05;          // θ and median disagree
            if (!double.IsNaN(fleetZ) && fleetZ <= -1.5) c += 0.10; // independent fleet corroboration
            return SignalMath.Clamp(c, 0.0, 0.85);
        }

        /// <summary>Stamp the advisory flag + reason onto a result.</summary>
        private static void ApplyAdvisory(DiagnosticResult r, bool advisory, string reason)
        {
            if (!advisory) return;
            r.Advisory = true;
            r.AdvisoryReason = string.IsNullOrEmpty(reason)
                ? "result rests on spec-seeded model parameters or a single-session estimate"
                : reason;
        }

        /// <summary>Format a dimensionless VE (or margin) as a percentage.</summary>
        private static string Pct(double ve)
        {
            if (double.IsNaN(ve)) return "n/a";
            return (ve * 100.0).ToString("0.#", CultureInfo.InvariantCulture) + "%";
        }

        /// <summary>Format a possibly-NaN number compactly and culture-invariantly.</summary>
        private static string Fmt(double v)
        {
            if (double.IsNaN(v)) return "n/a";
            return v.ToString("0.#", CultureInfo.InvariantCulture);
        }
    }
}
