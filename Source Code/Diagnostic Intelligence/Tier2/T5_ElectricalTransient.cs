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
//  Tester Present Specialist Automotive Solutions — T5 Electrical Transient Signature (Tier-2)
//
//  The battery/charging rail (PID 0x42 → CanonicalSignals.BatteryVoltage) tells a
//  story in three acts, and each act has a known-good signature that physics — not
//  guesswork — pins down:
//
//    • CRANK.  While the starter spins, it pulls hundreds of amps.  A healthy
//      battery sags but holds up: the terminal voltage under crank stays at or
//      above ~9.6 V (the SAE cold-crank floor).  If it collapses below that, the
//      battery cannot source the current — it is weak/sulphated, OR the starter is
//      drawing abnormally high current (shorted windings, tight engine), OR the
//      cables/grounds add series resistance that drops the delivered voltage.
//      Residual = CrankFloor − min(Vbatt during crank).
//
//    • RUN, undercharge.  Once the engine is running the alternator takes over and
//      should hold the rail in the charging band (~13.2–15.0 V, temperature- and
//      smart-charge-dependent).  A SUSTAINED level below the band means the rail is
//      running off the battery — the alternator is not sourcing charge (dead diode
//      pack, worn brushes, slipping/broken belt, open field, or the PCM smart-charge
//      command holding excitation low).  Modern smart-charge systems DELIBERATELY
//      vary charging voltage with load, temperature and SoC, so a momentary dip is
//      normal — only a sustained low is a fault.  We judge on the MEDIAN, which is
//      "most" of the run samples, not a single transient.
//
//    • RUN, overcharge.  Above the band the regulator has lost control: it is
//      pushing excitation too hard.  Overcharge boils electrolyte, cooks the
//      battery, and over-volts every module on the bus.  Cause is the voltage
//      regulator / alternator (internal reg) or a bad charge-control command.
//      Residual = median(Vbatt run) − RunMax.
//
//    • RIPPLE / diode.  A healthy rectifier turns the alternator's 3-phase AC into
//      clean DC; a failed diode leaks large AC ripple onto the DC rail.  We proxy
//      ripple by the stddev of the first difference of the run samples (repetitive
//      sample-to-sample swing).  HONESTY: true diode ripple is hundreds of Hz and is
//      aliased away at OBD PID rates — this catches only gross, slow instability, so
//      it is emitted advisory and pointed at a scope/DVOM-AC confirmation.
//
//  Regime is segmented by RPM when present (crank 100–500 rpm, run > 500 rpm, KOEO
//  < 100 rpm).  With no RPM, regime is inferred from voltage level about the split
//  point midway between the crank floor and the run floor — an honest fallback that
//  cannot tell a static key-on reading from a running one, so it is flagged.
//
//  Tier-2 honesty: the crank floor and run band are spec-seeded from published
//  charge-system specifications, not validated against a characterised fault on this
//  platform, so every result is ADVISORY until a validated calibration exists.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Globalization;
using TesterPresent.OBD2.Intelligence;

namespace TesterPresent.OBD2.Intelligence.Tier2
{
    /// <summary>
    /// T5 — Electrical Transient Signature.  Segments the battery-rail capture into
    /// crank / run regimes and matches each against its known-good charging-system
    /// signature, emitting one hypothesis per departure (weak-battery-under-crank,
    /// undercharge, overcharge, charging ripple) with its evidence chain, a
    /// residual-scaled confidence, and the single most discriminating next test.
    /// Reads snapshot + context only; never touches hardware.
    /// </summary>
    public sealed class ElectricalTransientModule : DiagnosticModuleBase
    {
        // ── Regime boundaries (rpm). Definitional, not calibratable thresholds. ──
        private const double CRANK_RPM_LO = 100.0;   // above this the starter is engaged
        private const double CRANK_RPM_HI = 500.0;   // below this the engine has not caught
        private const double RUN_RPM_MIN  = 500.0;   // above this the alternator should be charging

        private const int MIN_CRANK_SAMPLES = 2;     // a lone low sample is noise, not a crank window
        private const int MIN_RUN_SAMPLES   = 5;     // need a run window to judge a SUSTAINED level

        private DiagnosticRequirements _requirements;

        /// <inheritdoc/>
        public override string ModuleId => "T5";

        /// <inheritdoc/>
        public override string DisplayName => "Electrical Transient Signature";

        /// <inheritdoc/>
        public override DiagnosticTier Tier => DiagnosticTier.Tier2;

        /// <inheritdoc/>
        public override DiagnosticRequirements Requirements =>
            _requirements ?? (_requirements = new DiagnosticRequirements
            {
                RequiredSignals = new List<string> { CanonicalSignals.BatteryVoltage },
                MinSamples = 10,
            });

        /// <summary>
        /// Segment the battery rail by regime and test each regime against its
        /// spec-seeded signature.  Emits zero results for a healthy charging system.
        /// </summary>
        protected override IReadOnlyList<DiagnosticResult> AnalyzeCore(
            DiagnosticSnapshot snapshot, DiagnosticContext context)
        {
            var results = new List<DiagnosticResult>();
            bool usedUnvalidated = false;

            // ── Spec-seeded charge-system thresholds (unvalidated until characterised) ──
            double crankMinV  = Cal(context, "T5.CrankVoltageMinV", 9.6,  ref usedUnvalidated); // SAE crank floor (V)
            double runMinV    = Cal(context, "T5.RunVoltageMinV",   13.2, ref usedUnvalidated); // charging-band floor (V)
            double runMaxV    = Cal(context, "T5.RunVoltageMaxV",   15.0, ref usedUnvalidated); // charging-band ceiling (V)
            double rippleMaxV = Cal(context, "T5.RippleStdMaxV",    0.25, ref usedUnvalidated); // run first-diff stddev ceiling (V)

            SignalSeries vbatt = snapshot.Series(CanonicalSignals.BatteryVoltage);
            SignalSeries rpm   = snapshot.Series(CanonicalSignals.Rpm);
            bool hasRpm = rpm != null && rpm.HasData;

            // ── Advisory posture: Tier-2 geometry is spec-seeded unless validated. ──
            bool advisory = usedUnvalidated
                            || context == null
                            || context.Calibration == null
                            || !context.Calibration.IsValidated;
            string advisoryReason = advisory
                ? $"charge-system thresholds (crank floor {Fmt(crankMinV)} V, run band {Fmt(runMinV)}–{Fmt(runMaxV)} V) are "
                  + "spec-seeded from published charging specs, not validated against a characterised fault on this platform"
                : null;
            if (!hasRpm)
            {
                advisory = true;
                string inf = "engine regime was inferred from voltage level (no RPM captured) — a static key-on reading "
                             + "can masquerade as a running sample, so run-band verdicts are weaker without RPM";
                advisoryReason = advisoryReason == null ? inf : advisoryReason + "; " + inf;
            }

            // ── Segment the rail into crank / run windows ──
            Regime reg = SplitRegimes(vbatt, rpm, hasRpm, crankMinV, runMinV);
            string regimeSource = hasRpm ? "RPM-gated (crank 100–500 rpm, run > 500 rpm)"
                                         : "voltage-inferred (no RPM in capture)";
            double windowSec = CaptureWindowSeconds(vbatt);

            // ── CRANK: minimum terminal voltage under starter load ──
            if (reg.CrankCount >= MIN_CRANK_SAMPLES && reg.CrankMin < crankMinV)
            {
                results.Add(BuildWeakBattery(reg, crankMinV, regimeSource, windowSec, advisory, advisoryReason));
            }

            // ── RUN: undercharge / overcharge (mutually exclusive) on the median ──
            if (reg.RunCount >= MIN_RUN_SAMPLES)
            {
                // Undercharge requires RPM to confirm the engine is actually RUNNING: a
                // healthy engine-OFF battery rests at ~12.4–12.7 V, which sits below the
                // charging-band floor and, in the voltage-inferred (no-RPM) fallback, would
                // be mislabelled "undercharging" — a false alarm on a good battery. Without
                // RPM we cannot tell a resting battery from a running-undercharge, so we do
                // not assert it. (Overcharge is safe to keep: a resting battery physically
                // cannot read above the run ceiling, so >ceiling implies the alternator is
                // running and over-exciting.)
                // Smart-charge / regulated systems (modern Ford/GM) DELIBERATELY hold a reduced,
                // SUSTAINED float rail (~12.7–13.0 V) at high state-of-charge / light load — normal,
                // not a fault. Voltage alone can't separate that from a weak alternator, so only
                // assert undercharge when the rail sits below battery RESTING voltage (the charging
                // system is genuinely failing to maintain the battery — unambiguous). The band
                // between resting and runMinV is the smart-charge-float zone; suppress, don't cry
                // wolf. A validated calibration may push the floor lower, never above resting.
                const double NotChargingFloorV = 12.5;
                double underFloor = Math.Min(runMinV, NotChargingFloorV);
                if (hasRpm && reg.RunMedian < underFloor)
                    results.Add(BuildUndercharge(reg, runMinV, runMaxV, regimeSource, windowSec, advisory, advisoryReason));
                else if (reg.RunMedian > runMaxV)
                    results.Add(BuildOvercharge(reg, runMinV, runMaxV, regimeSource, windowSec, advisory, advisoryReason));

                // ── RIPPLE: gross repetitive instability on the DC rail ──
                if (reg.RunRippleStd > rippleMaxV)
                    results.Add(BuildRipple(reg, rippleMaxV, vbatt, regimeSource, advisoryReason));
            }

            return results;
        }

        // ── CRANK signature: weak battery / high starter draw ─────────────────────

        /// <summary>
        /// Residual = CrankFloor − min(Vbatt under crank).  A healthy battery holds
        /// ≥ crank floor while the starter loads it; a collapse below means the
        /// battery cannot source the current, the starter draws too much, or the
        /// cables/grounds drop the delivered voltage.
        /// </summary>
        private DiagnosticResult BuildWeakBattery(Regime reg, double crankMinV, string regimeSource,
                                                  double windowSec, bool advisory, string advisoryReason)
        {
            double residual = crankMinV - reg.CrankMin;   // volts below the floor

            var r = NewResult("Weak battery or high starter draw (crank voltage collapse)");
            r.Hypothesis =
                $"Under crank the terminal voltage fell to {Fmt(reg.CrankMin)} V — {Fmt(residual)} V below the "
                + $"{Fmt(crankMinV)} V floor a healthy battery holds against starter load. The battery cannot source the "
                + "cranking current (sulphated / low state-of-charge / failing cell), or the starter is drawing abnormally "
                + "high current (shorted windings, mechanical drag), or corroded cables/grounds are dropping the delivered "
                + "voltage. A weak crank rail is the classic slow-/no-crank precursor.";
            r.Severity = DiagnosticSeverity.High;
            r.Confidence = ConfidenceFor(residual, 1.5);
            r.SuspectComponents = new List<string>
            {
                "Battery (sulphated / low SoC / failing cell)",
                "Starter motor (high current draw, shorted windings)",
                "Battery cables / grounds (corroded, high series resistance)",
            };
            r.NextTest =
                "Load-test the battery and measure starter current draw; a healthy battery holds ≥ 9.6 V under crank. If the "
                + "battery passes a load test, do a voltage-drop test across the positive cable and ground straps while "
                + "cranking to catch resistive connections before condemning the starter.";
            r.NextTestScript = BuildCrankObserveScript(reg.CrankMin, crankMinV);

            r.Evidence
                .Info("Crank regime", $"{reg.CrankCount} samples, {regimeSource}",
                      "Battery-rail samples captured while the starter was engaged — where battery health is loaded and visible.")
                .Info("Capture window", $"{Fmt(windowSec)} s of battery-rail data", null)
                .Measure("Crank minimum Vbatt", reg.CrankMin, crankMinV, 15.0, "V",
                         $"Minimum under crank is below the {Fmt(crankMinV)} V floor ⇒ the rail collapses under starter load.");

            ApplyAdvisory(r, advisory, advisoryReason);
            return r;
        }

        // ── RUN signature: undercharge ────────────────────────────────────────────

        /// <summary>
        /// Residual = RunFloor − median(Vbatt run).  Judged on the MEDIAN so a
        /// momentary smart-charge dip does not trip it — only a sustained level
        /// below the charging band, i.e. the alternator is not sourcing charge.
        /// </summary>
        private DiagnosticResult BuildUndercharge(Regime reg, double runMinV, double runMaxV, string regimeSource,
                                                  double windowSec, bool advisory, string advisoryReason)
        {
            double residual = runMinV - reg.RunMedian;

            var r = NewResult("Undercharging — charging rail below the band while running");
            r.Hypothesis =
                $"While running the battery rail sits at a median {Fmt(reg.RunMedian)} V — {Fmt(residual)} V below the "
                + $"{Fmt(runMinV)} V charging-band floor, and {Pct(reg.RunFracBelowMin)} of run samples are under it, so it "
                + "is SUSTAINED rather than a transient. The alternator is not sourcing enough charge: a failed diode pack, "
                + "worn brushes, slipping/broken drive belt, open field, or a PCM smart-charge command holding excitation low. "
                + "Left alone the battery discharges to a no-start. (Smart-charge systems vary voltage on purpose — a brief "
                + "low is normal; this is the median, not a dip.)";
            r.Severity = DiagnosticSeverity.Medium;
            r.Confidence = ConfidenceFor(residual, 1.0);
            r.SuspectComponents = new List<string>
            {
                "Alternator (diode pack / brushes / field winding)",
                "Drive belt (slipping / broken / wrong tension)",
                "Charging wiring (voltage-sense / B+ / ground drop)",
                "PCM smart-charge command (excitation held low)",
            };
            r.NextTest =
                "Check alternator output, belt, and the charging-control (smart charge) command; verify at 2000 rpm with loads "
                + "on. A good alternator lifts the rail into the band under load — if it stays low, back-probe the voltage-sense "
                + "and field circuits before condemning the unit.";
            r.NextTestScript = BuildChargingObserveScript(reg.RunMedian, runMinV, runMaxV, low: true);

            r.Evidence
                .Info("Run regime", $"{reg.RunCount} samples, {regimeSource}",
                      "Battery-rail samples with the engine running — where the alternator, not the battery, owns the rail.")
                .Info("Capture window", $"{Fmt(windowSec)} s of battery-rail data", null)
                .Measure("Running Vbatt (median)", reg.RunMedian, runMinV, runMaxV, "V",
                         $"Median run voltage is below the {Fmt(runMinV)}–{Fmt(runMaxV)} V charging band.")
                .Add("Sustained-low fraction", Pct(reg.RunFracBelowMin), "transient only (< 50%)",
                     reg.RunFracBelowMin >= 0.5 ? EvidenceVerdict.Fail : EvidenceVerdict.Inconclusive,
                     "Share of run samples under the band floor — confirms a sustained low, not a smart-charge dip.");

            ApplyAdvisory(r, advisory, advisoryReason);
            return r;
        }

        // ── RUN signature: overcharge ─────────────────────────────────────────────

        /// <summary>
        /// Residual = median(Vbatt run) − RunCeiling.  The regulator has lost
        /// control and is over-exciting the field; overcharge boils electrolyte and
        /// over-volts every module on the bus.
        /// </summary>
        private DiagnosticResult BuildOvercharge(Regime reg, double runMinV, double runMaxV, string regimeSource,
                                                 double windowSec, bool advisory, string advisoryReason)
        {
            double residual = reg.RunMedian - runMaxV;

            var r = NewResult("Overcharging — charging rail above the band while running");
            r.Hypothesis =
                $"While running the battery rail holds a median {Fmt(reg.RunMedian)} V — {Fmt(residual)} V above the "
                + $"{Fmt(runMaxV)} V charging-band ceiling. The voltage regulator has lost control and is over-exciting the "
                + "alternator field. Overcharge boils the battery electrolyte, shortens its life, and over-volts every module "
                + "on the bus — an active-damage condition, not just an efficiency loss.";
            r.Severity = DiagnosticSeverity.High;
            r.Confidence = ConfidenceFor(residual, 0.8);
            r.SuspectComponents = new List<string>
            {
                "Voltage regulator (internal to alternator, stuck high)",
                "Alternator (field / regulator fault)",
                "Charge-control command / voltage-sense reference (reads low, drives up)",
            };
            r.NextTest =
                "Check voltage regulator / alternator; overcharge boils electrolyte and damages modules. Confirm the rail with "
                + "a DVOM at the battery and, if it exceeds the ceiling, replace the regulator/alternator — do not leave the "
                + "vehicle running on an over-volting charge system.";
            r.NextTestScript = BuildChargingObserveScript(reg.RunMedian, runMinV, runMaxV, low: false);

            r.Evidence
                .Info("Run regime", $"{reg.RunCount} samples, {regimeSource}",
                      "Battery-rail samples with the engine running — the regulator owns the rail here.")
                .Info("Capture window", $"{Fmt(windowSec)} s of battery-rail data", null)
                .Measure("Running Vbatt (median)", reg.RunMedian, runMinV, runMaxV, "V",
                         $"Median run voltage is above the {Fmt(runMinV)}–{Fmt(runMaxV)} V charging band ⇒ regulator over-exciting.");

            ApplyAdvisory(r, advisory, advisoryReason);
            return r;
        }

        // ── RUN signature: charging ripple / diode ────────────────────────────────

        /// <summary>
        /// Proxy for AC ripple on the DC rail: stddev of the first difference of the
        /// run samples.  A failed rectifier diode leaks large ripple.  Always
        /// advisory — real diode ripple is hundreds of Hz and aliased at OBD rates,
        /// so this only flags gross, slow repetitive instability for a scope to
        /// confirm.
        /// </summary>
        private DiagnosticResult BuildRipple(Regime reg, double rippleMaxV, SignalSeries vbatt,
                                             string regimeSource, string baseAdvisoryReason)
        {
            double residual = reg.RunRippleStd - rippleMaxV;
            double vHz = vbatt != null ? vbatt.EstimatedHz : 0;

            var r = NewResult("Charging ripple / diode fault (advisory)");
            r.Hypothesis =
                $"The running rail swings sample-to-sample with a first-difference stddev of {Fmt(reg.RunRippleStd)} V, past the "
                + $"{Fmt(rippleMaxV)} V ceiling — a repetitive AC ripple riding the DC rail. The most likely cause is a failed "
                + "alternator rectifier diode (or a loose charging connection) leaking the alternator's 3-phase AC onto the "
                + "battery. NOTE: true diode ripple is hundreds of Hz and is aliased away at OBD PID rates, so this is a gross "
                + "instability flag only — confirm with an oscilloscope or a DVOM on AC volts.";
            r.Severity = DiagnosticSeverity.Low;
            r.Confidence = Math.Min(0.6, ConfidenceFor(residual, rippleMaxV));
            r.SuspectComponents = new List<string>
            {
                "Alternator rectifier diode(s) (open / shorted)",
                "Loose or corroded charging connection (B+ / ground)",
            };
            r.NextTest =
                "Measure the charging rail on AC volts with a DVOM (or scope it) at the battery while charging under load — a "
                + "healthy rectifier holds AC ripple to a few tens of millivolts; > ~0.1 V AC or a periodic dropout pattern "
                + "confirms a failed diode.";

            r.Evidence
                .Info("Run regime", $"{reg.RunCount} samples, {regimeSource}", null)
                .Info("Sample rate", $"Vbatt ≈ {Fmt(vHz)} Hz",
                      "OBD PID rate — far below the diode-ripple frequency, so only gross instability is observable here.")
                .Measure("Run first-difference stddev", reg.RunRippleStd, 0.0, rippleMaxV, "V",
                         "Sample-to-sample swing of the running rail — a proxy for AC ripple on the DC bus.");

            // Ripple is inherently advisory (OBD-rate limited), independent of calibration state.
            r.Advisory = true;
            r.AdvisoryReason =
                "ripple is proxied from the first difference of low-rate OBD samples, which cannot resolve true diode-ripple "
                + "frequency — treat as a gross-instability flag, confirm with a scope/DVOM-AC"
                + (baseAdvisoryReason != null ? "; " + baseAdvisoryReason : "");
            return r;
        }

        // ── Regime segmentation ───────────────────────────────────────────────────

        /// <summary>
        /// Split the battery-rail series into crank and run windows.  With RPM
        /// present, gate by engine speed (crank 100–500 rpm, run &gt; 500 rpm, KOEO
        /// below).  Without RPM, classify by voltage about the split point midway
        /// between the crank floor and the run floor — an honest fallback flagged in
        /// the advisory.  Run samples are kept in capture order for the ripple metric.
        /// </summary>
        private static Regime SplitRegimes(SignalSeries vbatt, SignalSeries rpm, bool hasRpm,
                                           double crankMinV, double runMinV)
        {
            IReadOnlyList<double> v = vbatt.Values();
            var crank = new List<double>();
            var run = new List<double>();   // time-ordered
            // Ripple first-differences from run samples that were ADJACENT in the capture
            // only.  The run window drops crank/KOEO samples, so consecutive entries in
            // `run` can straddle a time gap; differencing across that gap inflates the
            // ripple proxy with a spurious step. Only diff genuinely-adjacent samples.
            var runDiffs = new List<double>();
            int lastRunI = -2;

            if (hasRpm)
            {
                IReadOnlyList<double> rv = rpm.Values();
                int n = Math.Min(v.Count, rv.Count);
                for (int i = 0; i < n; i++)
                {
                    double speed = rv[i];
                    if (speed >= CRANK_RPM_LO && speed <= CRANK_RPM_HI) crank.Add(v[i]);
                    else if (speed > RUN_RPM_MIN)
                    {
                        run.Add(v[i]);
                        if (i == lastRunI + 1) runDiffs.Add(v[i] - v[i - 1]);
                        lastRunI = i;
                    }
                    // speed < CRANK_RPM_LO ⇒ key-on engine-off / stalled — not a charging regime.
                }
            }
            else
            {
                double split = (crankMinV + runMinV) / 2.0;   // ~11.4 V: discharged/crank below, charging/run above
                for (int i = 0; i < v.Count; i++)
                {
                    if (v[i] < split) crank.Add(v[i]);
                    else
                    {
                        run.Add(v[i]);
                        if (i == lastRunI + 1) runDiffs.Add(v[i] - v[i - 1]);
                        lastRunI = i;
                    }
                }
            }

            var reg = new Regime { CrankCount = crank.Count, RunCount = run.Count };

            if (crank.Count > 0)
            {
                double min = crank[0];
                for (int i = 1; i < crank.Count; i++) if (crank[i] < min) min = crank[i];
                reg.CrankMin = min;
            }
            else reg.CrankMin = double.NaN;

            if (run.Count > 0)
            {
                reg.RunMedian = SignalMath.Median(run);
                int below = 0;
                for (int i = 0; i < run.Count; i++) if (run[i] < runMinV) below++;
                reg.RunFracBelowMin = (double)below / run.Count;
                reg.RunRippleStd = runDiffs.Count >= 2 ? SignalMath.StdDev(runDiffs) : 0.0;
            }
            else
            {
                reg.RunMedian = double.NaN;
                reg.RunFracBelowMin = 0;
                reg.RunRippleStd = 0;
            }

            return reg;
        }

        /// <summary>Wall-clock span of the battery-rail capture in seconds.</summary>
        private static double CaptureWindowSeconds(SignalSeries s)
        {
            if (s == null || s.Count < 2) return 0;
            var samples = s.Samples;
            return (samples[samples.Count - 1].Utc - samples[0].Utc).TotalSeconds;
        }

        // ── Observe-only confirmation scripts ─────────────────────────────────────

        /// <summary>Battery/starter crank observe-test.  Observe-only — the
        /// technician performs the physical load/voltage-drop test; the host reads
        /// the rail for reference. Never commands the ECU.</summary>
        private static ConfirmationScript BuildCrankObserveScript(double crankMin, double crankMinV)
        {
            return new ConfirmationScript
            {
                Name = "Crank rail load / voltage-drop test",
                Rationale = $"Crank minimum was {Fmt(crankMin)} V, below the {Fmt(crankMinV)} V floor. Load-test the battery "
                            + "and voltage-drop the cables while cranking to separate battery from starter from connections.",
                Steps =
                {
                    new ConfirmationStep
                    {
                        Description = "Observe the battery rail (PID 0x42) while cranking as a reference baseline.",
                        ServiceId = 0x00,
                        Payload = null,
                        ExpectedObservation = $"Rail should hold ≥ {Fmt(crankMinV)} V under crank on a healthy battery.",
                        IsActiveControl = false,
                    },
                    new ConfirmationStep
                    {
                        Description = "Carbon-pile load-test the battery, then voltage-drop the +/− cables while cranking.",
                        ServiceId = 0x00,
                        Payload = null,
                        ExpectedObservation = "Battery fails the load test ⇒ battery; > 0.2 V drop on a cable while cranking ⇒ "
                                              + "that connection; both good ⇒ suspect starter current draw.",
                        IsActiveControl = false,
                    },
                },
            };
        }

        /// <summary>Charging-system observe-test at 2000 rpm with loads on.
        /// Observe-only — never commands the ECU.</summary>
        private static ConfirmationScript BuildChargingObserveScript(double runMedian, double runMinV, double runMaxV, bool low)
        {
            return new ConfirmationScript
            {
                Name = "Charging-system verification (2000 rpm, loads on)",
                Rationale = $"Run median was {Fmt(runMedian)} V, {(low ? "below" : "above")} the {Fmt(runMinV)}–{Fmt(runMaxV)} V "
                            + "band. Load the alternator at raised idle and watch whether the rail returns to the band.",
                Steps =
                {
                    new ConfirmationStep
                    {
                        Description = "Hold ~2000 rpm, switch on headlights/blower/rear-demist, observe the battery rail (PID 0x42).",
                        ServiceId = 0x00,
                        Payload = null,
                        ExpectedObservation = low
                            ? $"A good alternator lifts the rail into the {Fmt(runMinV)}–{Fmt(runMaxV)} V band under load; if it "
                              + "stays low, the alternator/belt/field or charge command is at fault."
                            : $"A good regulator holds the rail at/below {Fmt(runMaxV)} V; if it stays high, the regulator/alternator "
                              + "is over-exciting.",
                        IsActiveControl = false,
                    },
                },
            };
        }

        // ── Small helpers ─────────────────────────────────────────────────────────

        /// <summary>Read a calibration constant, folding an unvalidated read into the advisory flag.</summary>
        private static double Cal(DiagnosticContext ctx, string key, double fallback, ref bool usedUnvalidated)
        {
            if (ctx == null || ctx.Calibration == null) { usedUnvalidated = true; return fallback; }
            bool validated;
            double v = ctx.Calibration.Value(key, fallback, out validated);
            if (!validated) usedUnvalidated = true;
            return v;
        }

        /// <summary>Confidence in [0, 0.85]: 0.45 at the threshold edge, rising to
        /// 0.80 once the residual reaches <paramref name="scale"/> volts past it,
        /// then capped — Tier-2 stays advisory.</summary>
        private static double ConfidenceFor(double residualOver, double scale)
        {
            if (scale <= 0) return 0.4;
            double c = 0.45 + 0.35 * SignalMath.Clamp(residualOver / scale, 0.0, 1.0);
            return SignalMath.Clamp(c, 0.0, 0.85);
        }

        /// <summary>Stamp the advisory flag + reason onto a result.</summary>
        private static void ApplyAdvisory(DiagnosticResult r, bool advisory, string reason)
        {
            if (!advisory) return;
            r.Advisory = true;
            r.AdvisoryReason = reason ?? "result rests on unvalidated charge-system thresholds or thin data";
        }

        /// <summary>Format a possibly-NaN voltage compactly and culture-invariantly.</summary>
        private static string Fmt(double v)
        {
            if (double.IsNaN(v)) return "n/a";
            return v.ToString("0.0#", CultureInfo.InvariantCulture);
        }

        /// <summary>Format a 0..1 fraction as a whole percentage.</summary>
        private static string Pct(double frac)
            => (SignalMath.Clamp(frac, 0, 1) * 100).ToString("0", CultureInfo.InvariantCulture) + "%";

        /// <summary>Per-regime rollup of the battery-rail capture.</summary>
        private struct Regime
        {
            public int CrankCount;       // samples classified as crank
            public double CrankMin;      // minimum Vbatt under crank; NaN if none
            public int RunCount;         // samples classified as run
            public double RunMedian;     // median Vbatt while running; NaN if none
            public double RunFracBelowMin; // fraction of run samples below the band floor (sustained-low test)
            public double RunRippleStd;  // stddev of first difference of run samples (ripple proxy)
        }
    }
}
