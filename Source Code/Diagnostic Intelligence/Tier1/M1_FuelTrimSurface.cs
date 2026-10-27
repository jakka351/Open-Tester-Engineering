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
//  Tester Present Specialist Automotive Solutions — M1 Fuel-Trim Surface Analysis (Tier-1)
//
//  A single fuel-trim number (e.g. "LTFT +12%") is diagnostically blind: it
//  cannot tell a vacuum leak from a weak fuel pump from a MAF that reads high.
//  All three push LTFT positive.  What separates them is WHERE in the RPM×Load
//  operating envelope the trim lives:
//
//    • Uniform across the whole surface  → global metering / fuel-pressure bias
//    • Concentrated at idle / low load   → vacuum (unmetered-air) leak, because a
//      fixed leak is a large fraction of a small idle airflow but negligible at
//      high airflow
//    • Concentrated at high load         → fuel-delivery shortfall under demand
//    • Split between banks               → single-bank (injector / O2 / leak) fault
//
//  This module bins total fuel trim (STFT+LTFT) across a 6×6 RPM×Load grid and
//  classifies the SPATIAL pattern, emitting a ranked hypothesis with an evidence
//  chain and the single most discriminating next test — never a bare verdict.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using TesterPresent.OBD2.Intelligence;

namespace TesterPresent.OBD2.Intelligence.Tier1
{
    /// <summary>
    /// M1 — Fuel-Trim Surface Analysis.  Inverts a captured fuel-trim capture
    /// into a spatial fault classification over the RPM×Load operating envelope.
    /// Reads the snapshot + context only; emits zero or more ranked hypotheses.
    /// </summary>
    public sealed class FuelTrimSurfaceModule : DiagnosticModuleBase
    {
        // Grid geometry: 6×6 over 500–6500 RPM × 0–100 % load.
        private const int GRID_NX = 6;
        private const int GRID_NY = 6;
        private const double RPM_MIN = 500.0;
        private const double RPM_MAX = 6500.0;
        private const double LOAD_MIN = 0.0;
        private const double LOAD_MAX = 100.0;

        // Load-band split points (percent) used to separate the operating surface.
        private const double LOW_LOAD_MAX = 30.0;    // cells with load center below this are "low load / idle"
        private const double HIGH_LOAD_MIN = 60.0;   // cells with load center above this are "high load / demand"

        // Uniform-drift spatial-spread ceiling: a genuinely global bias has a flat
        // surface, so the stddev of cell means stays small (percentage points).
        private const double UNIFORM_SPREAD_MAX = 5.0;

        // Data-sufficiency gate (from the brief): the trim SURFACE cannot be classified
        // from a single point.  Require a real minimum of populated cells spanning a
        // meaningful load range before emitting ANY spatial classification; below this
        // the surface is reported as insufficient, never guessed.  (The brief suggests
        // ≥ 6 populated cells spanning ≥ 2× airflow; load% is the airflow proxy here.)
        private const int MIN_SURFACE_CELLS = 6;
        private const double MIN_LOAD_SPAN_RATIO = 2.0;

        private DiagnosticRequirements _requirements;

        /// <inheritdoc/>
        public override string ModuleId => "M1";

        /// <inheritdoc/>
        public override string DisplayName => "Fuel-Trim Surface Analysis";

        /// <inheritdoc/>
        public override DiagnosticTier Tier => DiagnosticTier.Tier1;

        /// <inheritdoc/>
        public override DiagnosticRequirements Requirements =>
            _requirements ?? (_requirements = new DiagnosticRequirements
            {
                RequiredSignals = new List<string>
                {
                    CanonicalSignals.Rpm,
                    CanonicalSignals.EngineLoad,
                    CanonicalSignals.LtftB1,
                },
                MinSamples = 15,
                MayRecommendActiveControl = false,
            });

        /// <summary>
        /// Bin total fuel trim across the RPM×Load surface and classify the spatial
        /// pattern into one or more fault hypotheses.
        /// </summary>
        protected override IReadOnlyList<DiagnosticResult> AnalyzeCore(
            DiagnosticSnapshot snapshot, DiagnosticContext context)
        {
            var results = new List<DiagnosticResult>();
            bool usedUnvalidated = false;

            // ── Calibration thresholds (spec-seeded until validated) ──────────
            double normalPct     = Cal(context, "M1.NormalTrimPct",       5.0,  ref usedUnvalidated);
            double suspiciousPct = Cal(context, "M1.SuspiciousTrimPct",  10.0,  ref usedUnvalidated);
            double codePct       = Cal(context, "M1.CodeSettingTrimPct", 25.0,  ref usedUnvalidated);
            double bankAsymPct   = Cal(context, "M1.BankAsymmetryPct",    8.0,  ref usedUnvalidated);
            int    minCell       = (int)Math.Round(Cal(context, "M1.MinCellSamples", 5.0, ref usedUnvalidated));
            if (minCell < 1) minCell = 1;

            // ── Build the bank-1 (and optional bank-2) trim surfaces ──────────
            SignalSeries rpm  = snapshot.Series(CanonicalSignals.Rpm);
            SignalSeries load = snapshot.Series(CanonicalSignals.EngineLoad);
            SignalSeries ltft1 = snapshot.Series(CanonicalSignals.LtftB1);
            if (rpm == null || load == null || ltft1 == null) return results; // guarded, base checks too

            SignalSeries stft1 = snapshot.Series(CanonicalSignals.StftB1);
            SignalSeries ltft2 = snapshot.Series(CanonicalSignals.LtftB2);
            SignalSeries stft2 = snapshot.Series(CanonicalSignals.StftB2);

            var gridB1 = BuildTrimGrid(rpm, load, ltft1, stft1);
            var statB1 = Summarize(gridB1, minCell);

            bool hasB2 = ltft2 != null && ltft2.HasData;
            OperatingPointGrid gridB2 = hasB2 ? BuildTrimGrid(rpm, load, ltft2, stft2) : null;
            SurfaceStats statB2 = hasB2 ? Summarize(gridB2, minCell) : default;

            // Need at least one qualifying cell to say anything.
            if (statB1.OccupiedCells == 0) return results;

            // Thin-data honesty: few occupied cells, or low sample rate on RPM.
            bool thinData = statB1.OccupiedCells < 3;
            double rpmHz = rpm.EstimatedHz;
            if (rpmHz > 0 && rpmHz < 2.0) thinData = true;

            bool advisory = usedUnvalidated
                            || context == null
                            || context.Calibration == null
                            || !context.Calibration.IsValidated;
            string advisoryReason =
                advisory
                    ? "thresholds are spec-seeded, not validated on this platform"
                    : null;
            if (thinData)
            {
                advisory = true;
                string thin = $"thin data ({statB1.OccupiedCells} occupied cell(s)"
                              + (rpmHz > 0 ? $", {rpmHz:0.#} Hz RPM" : "") + ")";
                advisoryReason = advisoryReason == null ? thin : advisoryReason + "; " + thin;
            }

            // ── DATA-SUFFICIENCY GATE (from the brief) ───────────────────────────
            //  A trim SURFACE cannot be classified from one point or a single load band:
            //  a one-cell surface has zero spatial spread and would trivially satisfy the
            //  UNIFORM gate, and a one-band surface would fabricate a load-dependence it
            //  never measured.  Require a real minimum of populated cells spanning a
            //  meaningful load (airflow) range before ANY spatial verdict.  When a
            //  suspicious trim IS present but coverage is insufficient, report that
            //  loudly (insufficient evidence) instead of guessing; when nothing is
            //  suspicious, stay silent (a healthy idle needs no nag).
            bool sufficient = statB1.OccupiedCells >= MIN_SURFACE_CELLS
                              && statB1.LoadSpanRatio >= MIN_LOAD_SPAN_RATIO;
            if (!sufficient)
            {
                bool anySuspicious =
                    Math.Abs(statB1.OverallMean) >= suspiciousPct
                    || (!double.IsNaN(statB1.LowLoadTrim) && Math.Abs(statB1.LowLoadTrim) >= suspiciousPct)
                    || (!double.IsNaN(statB1.HighLoadTrim) && Math.Abs(statB1.HighLoadTrim) >= suspiciousPct);
                if (anySuspicious)
                    results.Add(BuildInsufficientSurface(statB1, suspiciousPct, advisoryReason));
                return results;
            }

            // Coverage factor (0..1): more populated cells → firmer spatial picture.
            double coverageFactor = SignalMath.Clamp(statB1.OccupiedCells / 12.0, 0.0, 1.0);

            // ── (a) UNIFORM DRIFT ─────────────────────────────────────────────
            if (Math.Abs(statB1.OverallMean) >= suspiciousPct && statB1.Spread < UNIFORM_SPREAD_MAX)
            {
                results.Add(BuildUniform(statB1, normalPct, suspiciousPct, codePct,
                                         coverageFactor, advisory, advisoryReason));
            }

            // ── (b) LOW-LOAD-DOMINANT LEAN (vacuum / intake leak) ─────────────
            //  Both load regions MUST be populated: the vacuum-leak signature is that
            //  the correction COLLAPSES from low to high load.  A NaN high-load region
            //  means the high-load part of the surface was never sampled, so the decay
            //  was not measured — absence of the opposite region is insufficient data,
            //  not evidence of a flat opposite region.
            if (!double.IsNaN(statB1.LowLoadTrim)
                && statB1.LowLoadTrim >= suspiciousPct
                && !double.IsNaN(statB1.HighLoadTrim) && statB1.HighLoadTrim < normalPct)
            {
                results.Add(BuildVacuumLeak(statB1, normalPct, suspiciousPct, codePct,
                                            coverageFactor, advisory, advisoryReason));
            }

            // ── (c) HIGH-LOAD-DOMINANT LEAN (fuel-delivery shortfall) ─────────
            //  Symmetric with gate (b): a delivery shortfall is lean UNDER LOAD but
            //  fine at idle, so the low-load region must be within the NORMAL band.
            //  (Testing only LowLoadTrim < HighLoadTrim would co-fire on a global
            //  metering/pressure bias with a mild upward gradient — where idle is
            //  itself lean — and misdiagnose it as a fuel-delivery fault.)
            //  Mirror of gate (b): both regions must be populated so a delivery shortfall
            //  (lean under load, fine at idle) is asserted from a measured low-load region,
            //  never from an unsampled one.
            if (!double.IsNaN(statB1.HighLoadTrim)
                && statB1.HighLoadTrim >= suspiciousPct
                && !double.IsNaN(statB1.LowLoadTrim) && statB1.LowLoadTrim < normalPct)
            {
                results.Add(BuildFuelShortfall(statB1, normalPct, suspiciousPct, codePct,
                                               coverageFactor, advisory, advisoryReason));
            }

            // ── (d) BANK ASYMMETRY (only if a bank-2 surface exists) ──────────
            if (hasB2 && statB2.OccupiedCells > 0)
            {
                double diff = statB1.OverallMean - statB2.OverallMean;
                if (Math.Abs(diff) >= bankAsymPct)
                {
                    results.Add(BuildBankAsymmetry(statB1, statB2, bankAsymPct, suspiciousPct, codePct,
                                                   coverageFactor, advisory, advisoryReason));
                }
            }

            return results;
        }

        // ── Hypothesis builders ───────────────────────────────────────────────

        private DiagnosticResult BuildUniform(SurfaceStats s, double normalPct, double suspiciousPct,
            double codePct, double coverage, bool advisory, string advisoryReason)
        {
            bool lean = s.OverallMean >= 0;
            string dir = lean ? "lean" : "rich";
            double mag = Math.Abs(s.OverallMean);

            var r = NewResult("Global fuel-trim bias — metering or fuel-pressure error");
            r.Hypothesis =
                $"Fuel trim is {dir} by {Fmt(s.OverallMean)}% and roughly UNIFORM across the RPM/load "
                + $"surface (spatial spread {Fmt(s.Spread)}%). A flat offset points at a global cause — "
                + (lean
                    ? "a MAF/MAP reading high (or low fuel pressure) makes the whole map lean"
                    : "a MAF/MAP reading low (or high fuel pressure / leaking injector) makes the whole map rich")
                + " — rather than a localized leak.";
            r.Severity = SeverityFor(mag, suspiciousPct, codePct);
            r.Confidence = ConfidenceFor(mag, codePct, coverage);
            r.SuspectComponents = new List<string>
            {
                "MAF sensor", "MAP sensor", "Fuel pressure regulator", "Base fuel pressure",
            };
            r.NextTest =
                "Compare measured MAF g/s against the calculated value at a known load, and check fuel "
                + "pressure against spec — a global metering error shows as a MAF/calc mismatch; a pressure "
                + "bias shows as an out-of-spec rail pressure.";

            r.Evidence
                .Info("Surface coverage", $"{s.OccupiedCells} of {GRID_NX * GRID_NY} cells populated",
                      "Enough of the RPM/load envelope was sampled to judge the pattern.")
                .Measure("Overall fuel trim", s.OverallMean, -suspiciousPct, suspiciousPct, "%",
                         $"Mean of occupied-cell trims; {dir} beyond the ±{Fmt(suspiciousPct)}% healthy band.")
                .Measure("Spatial spread", s.Spread, 0.0, UNIFORM_SPREAD_MAX, "%",
                         "Low spread ⇒ the trim offset is uniform, not concentrated in one load region.")
                .Pass("Load-region uniformity",
                      $"low {Fmt(s.LowLoadTrim)}% vs high {Fmt(s.HighLoadTrim)}%", "similar",
                      "Idle and high-load trims track each other — inconsistent with a vacuum leak.");

            ApplyAdvisory(r, advisory, advisoryReason);
            return r;
        }

        private DiagnosticResult BuildVacuumLeak(SurfaceStats s, double normalPct, double suspiciousPct,
            double codePct, double coverage, bool advisory, string advisoryReason)
        {
            double mag = s.LowLoadTrim;
            var r = NewResult("Vacuum / intake-air leak (low-load-dominant lean)");
            r.Hypothesis =
                $"Fuel trim is lean by {Fmt(s.LowLoadTrim)}% at idle / low load but normal "
                + $"({Fmt(s.HighLoadTrim)}%) under load. That is the classic unmetered-air signature: a "
                + "fixed intake leak is a large fraction of the small airflow at idle and negligible at high "
                + "airflow, so the correction collapses as load rises.";
            r.Severity = SeverityFor(mag, suspiciousPct, codePct);
            // A clean load-dependent shape is itself strong evidence — nudge confidence up.
            r.Confidence = SignalMath.Clamp(ConfidenceFor(mag, codePct, coverage) + 0.05, 0.0, 0.85);
            r.SuspectComponents = new List<string>
            {
                "Intake manifold gasket", "Vacuum hose", "PCV valve/hose", "Brake booster / booster hose",
            };
            r.NextTest =
                "Smoke-test the intake tract at idle; inspect the PCV system, brake-booster hose, and "
                + "intake-manifold gaskets. A visible smoke leak or an idle-trim drop when the suspect hose "
                + "is pinched confirms it.";

            r.Evidence
                .Info("Surface coverage", $"{s.OccupiedCells} of {GRID_NX * GRID_NY} cells populated",
                      "Both low-load and high-load regions were sampled, so the load dependence is real.")
                .Measure("Low-load trim", s.LowLoadTrim, -suspiciousPct, suspiciousPct, "%",
                         $"Idle/low-load correction is lean beyond the ±{Fmt(suspiciousPct)}% band.")
                .Measure("High-load trim", s.HighLoadTrim, -normalPct, normalPct, "%",
                         $"High-load correction stays inside the ±{Fmt(normalPct)}% normal band.")
                .Fail("Load-dependent lean",
                      $"Δ {Fmt(s.LowLoadTrim - s.HighLoadTrim)}%", "≈ 0%",
                      "Lean at idle, normal under load — the unmetered-air fingerprint.");

            ApplyAdvisory(r, advisory, advisoryReason);
            return r;
        }

        private DiagnosticResult BuildFuelShortfall(SurfaceStats s, double normalPct, double suspiciousPct,
            double codePct, double coverage, bool advisory, string advisoryReason)
        {
            double mag = s.HighLoadTrim;
            var r = NewResult("Fuel-delivery shortfall under demand (high-load-dominant lean)");
            r.Hypothesis =
                $"Fuel trim is lean by {Fmt(s.HighLoadTrim)}% at high load while lower "
                + $"({Fmt(s.LowLoadTrim)}%) at idle. The correction grows with fuel demand — consistent with "
                + "a delivery system that keeps up at idle but cannot supply enough fuel volume/pressure "
                + "when airflow is high.";
            r.Severity = SeverityFor(mag, suspiciousPct, codePct);
            r.Confidence = ConfidenceFor(mag, codePct, coverage);
            r.SuspectComponents = new List<string>
            {
                "Fuel pump", "Fuel filter", "Injectors (flow)", "Fuel pressure regulator",
            };
            r.NextTest =
                "Measure fuel pressure and volume under load (or during a high-load pull); inspect the pump, "
                + "filter, and injector flow. A pressure/volume drop that appears only under demand confirms "
                + "a delivery shortfall.";

            r.Evidence
                .Info("Surface coverage", $"{s.OccupiedCells} of {GRID_NX * GRID_NY} cells populated",
                      "The high-load region carried enough samples to trust the correction there.")
                .Measure("High-load trim", s.HighLoadTrim, -suspiciousPct, suspiciousPct, "%",
                         $"High-load correction is lean beyond the ±{Fmt(suspiciousPct)}% band.")
                .Info("Low-load trim", $"{Fmt(s.LowLoadTrim)}%",
                      "Idle correction is smaller — the deficit scales with demand, not a fixed leak.")
                .Fail("Demand-dependent lean",
                      $"Δ {Fmt(s.HighLoadTrim - s.LowLoadTrim)}%", "≈ 0%",
                      "Trim climbs with load — the fuel-delivery fingerprint.");

            ApplyAdvisory(r, advisory, advisoryReason);
            return r;
        }

        private DiagnosticResult BuildBankAsymmetry(SurfaceStats s1, SurfaceStats s2, double bankAsymPct,
            double suspiciousPct, double codePct, double coverage, bool advisory, string advisoryReason)
        {
            double diff = s1.OverallMean - s2.OverallMean;
            double mag = Math.Abs(diff);
            // Leaner bank = the one whose correction is more positive (adding fuel).
            int leanerBank = s1.OverallMean >= s2.OverallMean ? 1 : 2;

            var r = NewResult($"Single-bank fuel fault (bank {leanerBank})");
            r.Hypothesis =
                $"Bank {leanerBank} runs {Fmt(mag)}% leaner than the opposite bank "
                + $"(B1 {Fmt(s1.OverallMean)}% vs B2 {Fmt(s2.OverallMean)}%). A per-bank divergence this "
                + "large is not a global metering or pressure problem — it isolates to hardware that only "
                + $"affects bank {leanerBank}.";
            r.Severity = SeverityFor(mag, bankAsymPct, codePct);
            r.Confidence = ConfidenceFor(mag, codePct, coverage);
            r.SuspectComponents = new List<string>
            {
                $"Bank {leanerBank} injector(s)", $"Bank {leanerBank} O2 sensor",
                $"Bank {leanerBank} intake/exhaust leak",
            };
            r.NextTest =
                $"Localize to bank {leanerBank}: compare that bank's O2/AFR against the other, check its "
                + "injector balance and its manifold/exhaust for a bank-specific leak. Swapping a suspect "
                + "sensor across banks and seeing the imbalance follow confirms the sensor.";

            r.Evidence
                .Info("Bank-1 surface mean", $"{Fmt(s1.OverallMean)}% ({s1.OccupiedCells} cells)", null)
                .Info("Bank-2 surface mean", $"{Fmt(s2.OverallMean)}% ({s2.OccupiedCells} cells)", null)
                .Measure("Inter-bank trim delta", mag, 0.0, bankAsymPct, "%",
                         $"Bank spread exceeds the ±{Fmt(bankAsymPct)}% symmetry limit ⇒ one-bank fault.");

            ApplyAdvisory(r, advisory, advisoryReason);
            return r;
        }

        // ── Grid construction & statistics ────────────────────────────────────

        /// <summary>
        /// Bin total fuel trim (STFT+LTFT, or LTFT alone if STFT absent) for one
        /// bank into an RPM×Load grid, aligning the series by sample index.
        /// </summary>
        private static OperatingPointGrid BuildTrimGrid(SignalSeries rpm, SignalSeries load,
                                                        SignalSeries ltft, SignalSeries stft)
        {
            var grid = new OperatingPointGrid(GRID_NX, GRID_NY, RPM_MIN, RPM_MAX, LOAD_MIN, LOAD_MAX,
                                              CanonicalSignals.Rpm, CanonicalSignals.EngineLoad);

            IReadOnlyList<double> rpmV = rpm.Values();
            IReadOnlyList<double> loadV = load.Values();
            IReadOnlyList<double> ltftV = ltft.Values();
            IReadOnlyList<double> stftV = (stft != null && stft.HasData) ? stft.Values() : null;

            int n = Math.Min(rpmV.Count, Math.Min(loadV.Count, ltftV.Count));
            for (int i = 0; i < n; i++)
            {
                double total = ltftV[i];
                if (stftV != null && i < stftV.Count) total += stftV[i];
                grid.Add(rpmV[i], loadV[i], total);
            }
            return grid;
        }

        /// <summary>
        /// Reduce a trim grid to the spatial statistics the classifier needs:
        /// occupied-cell count, mean-of-cell-means, spatial spread, and the mean
        /// trim in the low-load and high-load regions.
        /// </summary>
        private static SurfaceStats Summarize(OperatingPointGrid grid, int minCell)
        {
            var cellMeans = new List<double>();
            var lowMeans = new List<double>();
            var highMeans = new List<double>();
            double minLoad = double.NaN, maxLoad = double.NaN;

            foreach (var (cx, cy, acc) in grid.OccupiedCells(minCell))
            {
                cellMeans.Add(acc.Mean);
                double loadCenter = grid.YCenter(cy);
                if (double.IsNaN(minLoad) || loadCenter < minLoad) minLoad = loadCenter;
                if (double.IsNaN(maxLoad) || loadCenter > maxLoad) maxLoad = loadCenter;
                if (loadCenter < LOW_LOAD_MAX) lowMeans.Add(acc.Mean);
                else if (loadCenter > HIGH_LOAD_MIN) highMeans.Add(acc.Mean);
            }

            var s = new SurfaceStats
            {
                OccupiedCells = cellMeans.Count,
                OverallMean = cellMeans.Count > 0 ? cellMeans.Average() : 0.0,
                Spread = cellMeans.Count > 1 ? SignalMath.StdDev(cellMeans) : 0.0,
                LowLoadTrim = lowMeans.Count > 0 ? lowMeans.Average() : double.NaN,
                HighLoadTrim = highMeans.Count > 0 ? highMeans.Average() : double.NaN,
                MinLoadCenter = minLoad,
                MaxLoadCenter = maxLoad,
            };
            return s;
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

        /// <summary>Severity ladder: ≥ code-setting ⇒ High, ≥ suspicious ⇒ Medium, else Low.</summary>
        private static DiagnosticSeverity SeverityFor(double magnitude, double suspiciousPct, double codePct)
        {
            double m = Math.Abs(magnitude);
            if (m >= codePct) return DiagnosticSeverity.High;
            if (m >= suspiciousPct) return DiagnosticSeverity.Medium;
            return DiagnosticSeverity.Low;
        }

        /// <summary>
        /// Confidence in [0, 0.85].  Surface coverage is a MULTIPLICATIVE gate, not a
        /// small additive bonus: a thin (but just-sufficient) surface cannot reach high
        /// confidence no matter how large the trim, because a spatial classification is
        /// only as trustworthy as the surface it was read from.  Magnitude sets the
        /// ceiling; coverage scales the whole thing down.
        /// </summary>
        private static double ConfidenceFor(double magnitude, double codePct, double coverageFactor)
        {
            double magFactor = codePct > 0 ? SignalMath.Clamp(Math.Abs(magnitude) / codePct, 0.0, 1.0) : 0.0;
            double cov = SignalMath.Clamp(coverageFactor, 0.0, 1.0);
            double c = (0.25 + 0.60 * magFactor) * (0.50 + 0.50 * cov);
            return SignalMath.Clamp(c, 0.0, 0.85);
        }

        /// <summary>
        /// A suspicious trim was seen but the surface coverage is below the sufficiency
        /// gate (too few populated cells or too narrow a load span) to classify the
        /// spatial pattern.  Report that honestly — "insufficient evidence" surfaced
        /// loudly — instead of guessing a fault class from one point.
        /// </summary>
        private DiagnosticResult BuildInsufficientSurface(SurfaceStats s, double suspiciousPct, string advisoryReason)
        {
            var r = NewResult("Fuel trim is elevated but the surface is under-sampled");
            r.Hypothesis =
                $"Fuel trim is running around {Fmt(s.OverallMean)}% but only {s.OccupiedCells} operating-point cell(s) "
                + $"spanning a {Fmt(s.LoadSpanRatio)}× load range were populated — too little of the RPM/load envelope to "
                + "tell a uniform bias from a load-dependent leak from a fuel-delivery shortfall. The magnitude is real; "
                + "the spatial CLASSIFICATION is not yet supportable.";
            r.Severity = DiagnosticSeverity.Info;
            r.Confidence = 0.15;
            r.SuspectComponents = new List<string>();
            r.NextTest =
                $"Re-capture across a wider operating range (idle AND part-throttle AND a higher-load pull) so at least "
                + $"{MIN_SURFACE_CELLS} MAP/RPM cells spanning ≥{MIN_LOAD_SPAN_RATIO:0}× airflow are populated, then re-run "
                + "M1 — the trim-surface slope needs both low- and high-airflow points to separate the fault classes.";
            r.Evidence
                .Info("Surface coverage", $"{s.OccupiedCells} of {GRID_NX * GRID_NY} cells populated",
                      $"Below the {MIN_SURFACE_CELLS}-cell / ≥{MIN_LOAD_SPAN_RATIO:0}× load-span floor needed to trust a spatial pattern.")
                .Inconclusive("Load span", $"{Fmt(s.LoadSpanRatio)}× (low {Fmt(s.MinLoadCenter)}% → high {Fmt(s.MaxLoadCenter)}%)",
                              $"≥ {MIN_LOAD_SPAN_RATIO:0}×",
                              "Not enough spread along the load axis to measure the trim-vs-airflow slope.")
                .Info("Overall trim", $"{Fmt(s.OverallMean)}%",
                      $"Beyond the ±{Fmt(suspiciousPct)}% healthy band — worth chasing, but capture more of the envelope first.");
            r.Advisory = true;
            r.AdvisoryReason = advisoryReason == null
                ? "insufficient surface coverage to classify the trim pattern"
                : advisoryReason + "; insufficient surface coverage to classify the trim pattern";
            return r;
        }

        /// <summary>Stamp the advisory flag + reason onto a result.</summary>
        private static void ApplyAdvisory(DiagnosticResult r, bool advisory, string reason)
        {
            if (!advisory) return;
            r.Advisory = true;
            r.AdvisoryReason = reason ?? "result rests on unvalidated thresholds or thin data";
        }

        /// <summary>Format a possibly-NaN percentage compactly and culture-invariantly.</summary>
        private static string Fmt(double v)
        {
            if (double.IsNaN(v)) return "n/a";
            return v.ToString("0.#", CultureInfo.InvariantCulture);
        }

        /// <summary>The spatial statistics of one bank's trim surface.</summary>
        private struct SurfaceStats
        {
            public int OccupiedCells;
            public double OverallMean;   // mean of occupied-cell means
            public double Spread;        // stddev of occupied-cell means
            public double LowLoadTrim;   // mean trim where load center < LOW_LOAD_MAX; NaN if none
            public double HighLoadTrim;  // mean trim where load center > HIGH_LOAD_MIN; NaN if none
            public double MinLoadCenter; // lowest occupied-cell load center (%); NaN if none
            public double MaxLoadCenter; // highest occupied-cell load center (%); NaN if none

            /// <summary>Ratio of the widest-to-narrowest occupied load center — the
            /// airflow-span proxy the sufficiency gate needs.  1.0 (or NaN) when the
            /// surface is a single load band.</summary>
            public double LoadSpanRatio =>
                (!double.IsNaN(MinLoadCenter) && !double.IsNaN(MaxLoadCenter) && MinLoadCenter > 1e-6)
                    ? MaxLoadCenter / MinLoadCenter : 1.0;
        }
    }
}
