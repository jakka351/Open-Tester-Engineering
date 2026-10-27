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
//  Tester Present Specialist Automotive Solutions — T1 Observer-Bank Residual Generation (Tier-2)
//
//  A single sensor reading is diagnostically blind; a MODEL running alongside the
//  sensor is not.  This module hosts a small bank of state observers — each a
//  simplified physical model of ONE subsystem — running in parallel with the
//  measured signals.  Each observer forms a RESIDUAL (model prediction − measured
//  value) that is designed to stay quiet for a healthy vehicle and to jump only
//  for its own fault class.  That structuring (STRUCTURED RESIDUALS) is what turns
//  a bank of observers into a fault-isolation tool: a pure idle-control fault
//  trips the idle observer but leaves the air-path observer quiet, and so on.
//
//  Observers implemented (each runs only if its inputs are present):
//
//    • AIR-PATH observer — throttle/MAP consistency at idle.
//      Physics: at a closed throttle (idle) a naturally-aspirated engine pulls
//      strong manifold vacuum, so MAP sits LOW (~30–40 kPa absolute, well below
//      barometric ~100 kPa).  If MAP stays HIGH with the throttle closed, the
//      manifold is not being evacuated — unmetered air is entering (big vacuum
//      leak), the throttle plate is stuck/coked open, or the MAP sensor reads
//      high.  Residual = MAP_idle_measured − MAP_idle_expected.
//
//    • IDLE-SPEED observer — commanded vs achieved idle RPM.
//      Physics: with the throttle closed and the vehicle stopped, the idle
//      controller should hold RPM near the calibrated target.  Residual =
//      idle_RPM_measured − idle_RPM_expected.  Sign isolates the class: HIGH idle
//      ⇒ unmetered air / throttle not seating (vacuum leak, dirty throttle);
//      LOW idle / hunting ⇒ idle-air actuator sticking, added load, or a weak
//      idle-control loop.
//
//    • FUEL-PATH observer — long-term fuel trim as a fueling residual.
//      Physics: closed-loop trim should hover near 0 %.  A large sustained |LTFT|
//      is the fuel-path residual; this observer only RAISES the flag so the bank
//      is complete — spatial localisation of the fueling fault is M1's job.
//
//  Tier-2 honesty: the observers rest on spec-seeded geometry (expected idle MAP,
//  target idle RPM, residual bands).  Until those constants are validated against
//  a characterised fault on this platform every result is ADVISORY, and OBD-II's
//  ~1–5 Hz PID rate limits observer fidelity — noted in the advisory reason.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Globalization;
using TesterPresent.OBD2.Intelligence;

namespace TesterPresent.OBD2.Intelligence.Tier2
{
    /// <summary>
    /// T1 — Observer-Bank Residual Generation.  Runs a small bank of simplified
    /// subsystem observers alongside the captured signals and emits, per observer,
    /// at most one structured-residual hypothesis with its evidence chain, the
    /// residual magnitude as confidence, and the single most discriminating next
    /// test.  Reads snapshot + context only; never touches hardware.
    /// </summary>
    public sealed class ObserverResidualModule : DiagnosticModuleBase
    {
        // Minimum idle-condition samples before the idle/air-path observers will speak.
        private const int MIN_IDLE_SAMPLES = 5;

        private DiagnosticRequirements _requirements;

        /// <inheritdoc/>
        public override string ModuleId => "T1";

        /// <inheritdoc/>
        public override string DisplayName => "Observer-Bank Residual Generation";

        /// <inheritdoc/>
        public override DiagnosticTier Tier => DiagnosticTier.Tier2;

        /// <inheritdoc/>
        public override DiagnosticRequirements Requirements =>
            _requirements ?? (_requirements = new DiagnosticRequirements
            {
                RequiredSignals = new List<string> { CanonicalSignals.Rpm },
                MinSamples = 15,
                MayRecommendActiveControl = true,   // idle-speed confirmation may command the ECU
            });

        /// <summary>
        /// Run every observer whose inputs are present and collect one structured
        /// residual per subsystem that has crossed its band.
        /// </summary>
        protected override IReadOnlyList<DiagnosticResult> AnalyzeCore(
            DiagnosticSnapshot snapshot, DiagnosticContext context)
        {
            var results = new List<DiagnosticResult>();
            bool usedUnvalidated = false;

            // ── Spec-seeded observer constants (unvalidated until characterised) ──
            double tpsMax      = Cal(context, "Idle.TpsMaxPct",        5.0,   ref usedUnvalidated); // closed-throttle ceiling (%)
            double vssMax      = Cal(context, "Idle.VssMaxKph",        3.0,   ref usedUnvalidated); // "stopped" ceiling (km/h)
            double runMinRpm   = Cal(context, "Engine.RunMinRpm",      300.0, ref usedUnvalidated); // engine-running floor
            double idleRpm     = Cal(context, "Engine.IdleRpm",        700.0, ref usedUnvalidated); // target idle RPM
            double rpmBand     = Cal(context, "Idle.RpmResidualRpm",   150.0, ref usedUnvalidated); // idle residual band
            double idleMapKpa  = Cal(context, "AirPath.IdleMapKpa",    35.0,  ref usedUnvalidated); // expected idle MAP (NA)
            double mapBand     = Cal(context, "AirPath.MapResidualKpa",15.0,  ref usedUnvalidated); // MAP residual band
            double trimBand    = Cal(context, "FuelPath.TrimResidualPct", 10.0, ref usedUnvalidated); // LTFT residual band

            // Advisory posture: Tier-2 model geometry is spec-seeded unless the
            // resolved calibration is validated for this platform.
            bool advisory = usedUnvalidated
                            || context == null
                            || context.Calibration == null
                            || !context.Calibration.IsValidated;
            string advisoryReason = advisory
                ? "observer model is simplified and its geometry (idle MAP, target RPM, residual bands) is spec-seeded, not validated on this platform"
                : null;

            // Low OBD PID rate materially limits observer fidelity — say so.
            SignalSeries rpm = snapshot.Series(CanonicalSignals.Rpm);
            double rpmHz = rpm != null ? rpm.EstimatedHz : 0;
            if (rpmHz > 0 && rpmHz < 4.0)
            {
                advisory = true;
                string rate = $"required sample rate not met — RPM at {rpmHz:0.#} Hz (observers assume ≥ 4 Hz for fidelity)";
                advisoryReason = advisoryReason == null ? rate : advisoryReason + "; " + rate;
            }

            // ── Establish the idle operating point once, shared by two observers ──
            IdlePoint idle = ExtractIdlePoint(snapshot, tpsMax, vssMax, runMinRpm);

            // Metering-agnostic: every observer below keys off RPM, MAP, TPS/VSS or
            // LTFT — none treats a measured MAF as truth — so the air-metering config
            // (MAF vs speed-density) gates none of them. No HasMaf guard is needed
            // here, unlike T2/T3 which invert MAF; the air-path/idle/fuel observers
            // run on a speed-density engine unchanged.

            // ── Observer 1: IDLE-SPEED ────────────────────────────────────────────
            if (idle.Established)
            {
                var r = RunIdleSpeedObserver(idle, idleRpm, rpmBand, advisory, advisoryReason);
                if (r != null) results.Add(r);
            }

            // ── Observer 2: AIR-PATH (MAP at closed throttle) ─────────────────────
            if (idle.Established && idle.HasMap)
            {
                var r = RunAirPathObserver(idle, idleMapKpa, mapBand, advisory, advisoryReason);
                if (r != null) results.Add(r);
            }

            // ── Observer 3: FUEL-PATH (LTFT residual) ─────────────────────────────
            SignalSeries ltft1 = snapshot.Series(CanonicalSignals.LtftB1);
            if (ltft1 != null && ltft1.HasData)
            {
                var r = RunFuelPathObserver(ltft1, trimBand, advisory, advisoryReason);
                if (r != null) results.Add(r);
            }

            return results;
        }

        // ── Observer 1: idle-speed residual ───────────────────────────────────────

        /// <summary>
        /// Residual = measured idle RPM − target idle RPM.  A residual beyond the
        /// band flags an idle-control fault; the SIGN structures the hypothesis
        /// (HIGH ⇒ unmetered air / throttle; LOW/hunting ⇒ IAC sticking / load).
        /// </summary>
        private DiagnosticResult RunIdleSpeedObserver(IdlePoint idle, double idleRpm, double rpmBand,
                                                      bool advisory, string advisoryReason)
        {
            double residual = idle.RpmMean - idleRpm;                 // rpm
            if (Math.Abs(residual) <= rpmBand) return null;            // observer quiet — healthy idle

            bool high = residual > 0;
            double mag = Math.Abs(residual);
            // Hunting: idle RPM should be nearly flat; a large scatter is an unstable loop.
            bool hunting = idle.RpmStdDev > (rpmBand * 0.5);

            var r = NewResult(high
                ? "Idle-speed observer — HIGH idle residual (unmetered air / throttle)"
                : "Idle-speed observer — LOW idle residual (idle-air control / load)");

            if (high)
            {
                r.Hypothesis =
                    $"The idle-speed observer predicts ~{Fmt(idleRpm)} rpm at closed throttle but the engine holds "
                    + $"{Fmt(idle.RpmMean)} rpm — a residual of +{Fmt(mag)} rpm. The controller cannot pull idle down "
                    + "to target, which means air is reaching the cylinders that the throttle is not admitting: a "
                    + "vacuum (unmetered-air) leak, a throttle plate stuck/coked open, or a base idle set high.";
                r.SuspectComponents = new List<string>
                {
                    "Vacuum leak (intake gasket / hose / PCV / brake booster)",
                    "Throttle body (carbon, stuck plate, base idle)",
                    "Idle-air control valve (stuck open)",
                };
                r.NextTest =
                    "Isolate the extra air: with the engine idling, pinch suspected vacuum lines one at a time — an "
                    + "idle drop when a line is pinched confirms a leak on that circuit. If pinching changes nothing, "
                    + "clean/inspect the throttle body and command idle-air back to base with the ECU.";
                r.NextTestScript = BuildIdleAirScript(idle.RpmMean, idleRpm);
            }
            else
            {
                string huntNote = hunting
                    ? $" Idle also scatters ±{Fmt(idle.RpmStdDev)} rpm, i.e. it is HUNTING — a hallmark of an idle-air actuator that sticks and over/under-corrects."
                    : "";
                r.Hypothesis =
                    $"The idle-speed observer predicts ~{Fmt(idleRpm)} rpm but the engine idles at {Fmt(idle.RpmMean)} rpm "
                    + $"— a residual of −{Fmt(mag)} rpm. Idle sits below target, so the controller is not admitting enough "
                    + "air (idle-air passage / actuator sticking) or an unexpected load is dragging RPM down." + huntNote;
                r.SuspectComponents = new List<string>
                {
                    "Idle-air control valve / electronic throttle (sticking, low airflow)",
                    "Added load (A/C, alternator, PS pump, dragging accessory)",
                    "Restricted idle-air passage (carbon)",
                };
                r.NextTest =
                    "Command the idle-air/electronic-throttle position up with the ECU and watch RPM respond — a lazy or "
                    + "no response points at the actuator/passage; if RPM recovers when accessories are shed, chase the "
                    + "parasitic load instead.";
                r.NextTestScript = BuildIdleAirScript(idle.RpmMean, idleRpm);
            }

            r.Severity = DiagnosticSeverity.Medium;
            r.Confidence = ConfidenceFor(mag, rpmBand);

            r.Evidence
                .Info("Idle observer model", $"target idle ≈ {Fmt(idleRpm)} rpm at closed throttle, vehicle stopped",
                      "Calibrated idle target the controller is expected to hold — the observer's set-point.")
                .Info("Idle operating point", $"{idle.SampleCount} closed-throttle / stopped samples",
                      "Samples with throttle closed and vehicle stationary — where idle control is authoritative.")
                .Measure("Idle RPM residual", idle.RpmMean, idleRpm - rpmBand, idleRpm + rpmBand, "rpm",
                         $"Measured idle is {(high ? "above" : "below")} the ±{Fmt(rpmBand)} rpm band around target ⇒ idle-control residual.")
                .Add("Idle RPM scatter", $"±{Fmt(idle.RpmStdDev)} rpm", $"< {Fmt(rpmBand * 0.5)} rpm",
                     hunting ? EvidenceVerdict.Fail : EvidenceVerdict.Pass,
                     hunting ? "Idle is unstable (hunting) — an over/under-correcting idle loop." : "Idle is stable — a steady offset, not a hunting loop.");

            ApplyAdvisory(r, advisory, advisoryReason);
            return r;
        }

        // ── Observer 2: air-path residual ─────────────────────────────────────────

        /// <summary>
        /// Residual = MAP_idle_measured − MAP_idle_expected.  A large POSITIVE
        /// residual (MAP high with the throttle closed) means the manifold is not
        /// being evacuated ⇒ unmetered air, stuck throttle, or a high-reading MAP.
        /// </summary>
        private DiagnosticResult RunAirPathObserver(IdlePoint idle, double idleMapKpa, double mapBand,
                                                    bool advisory, string advisoryReason)
        {
            double residual = idle.MapMean - idleMapKpa;              // kPa
            // Only a HIGH-MAP-at-idle residual is diagnostic here; a lower-than-expected
            // idle MAP (stronger vacuum) is not an air-path fault, so stay quiet on it.
            if (residual <= mapBand) return null;

            double mag = residual;

            var r = NewResult("Air-path observer — MAP high at closed throttle (manifold not evacuated)");
            r.Hypothesis =
                $"At closed throttle the air-path observer expects strong manifold vacuum (MAP ≈ {Fmt(idleMapKpa)} kPa) "
                + $"but MAP sits at {Fmt(idle.MapMean)} kPa — a residual of +{Fmt(mag)} kPa toward barometric. The manifold "
                + "is not being pumped down, so air is bypassing the closed throttle (large vacuum leak or a throttle "
                + "plate stuck/coked open) or the MAP sensor is reading high.";
            r.Severity = DiagnosticSeverity.Medium;
            r.Confidence = ConfidenceFor(mag, mapBand);
            r.SuspectComponents = new List<string>
            {
                "Vacuum leak (intake gasket / hose / PCV / brake booster)",
                "Throttle body (stuck / coked plate)",
                "MAP sensor (reads high) or clogged MAP vacuum reference",
            };
            r.NextTest =
                "Discriminate leak from sensor: at key-on engine-off MAP should read ≈ barometric; at a true closed-throttle "
                + "idle it should fall to ~30–40 kPa. If it never falls, smoke-test the intake for a vacuum leak and inspect "
                + "the throttle plate. If MAP reads high KOEO as well, suspect the MAP sensor.";

            r.Evidence
                .Info("Air-path observer model", $"expected idle MAP ≈ {Fmt(idleMapKpa)} kPa (strong vacuum at closed throttle)",
                      "Naturally-aspirated manifold pressure at idle — the observer's prediction from throttle position.")
                .Info("Air-path operating point", $"{idle.SampleCount} closed-throttle / stopped samples", null)
                .Measure("MAP residual at idle", idle.MapMean, idleMapKpa - mapBand, idleMapKpa + mapBand, "kPa",
                         $"Idle MAP is above the +{Fmt(mapBand)} kPa band ⇒ the manifold is not evacuating as a closed throttle should.");

            ApplyAdvisory(r, advisory, advisoryReason);
            return r;
        }

        // ── Observer 3: fuel-path residual ────────────────────────────────────────

        /// <summary>
        /// Residual = |mean LTFT|.  Closed-loop trim should hover near 0 %.  A
        /// large sustained residual raises the fuel-path flag so the observer bank
        /// is complete; spatial localisation of the fueling fault is deferred to M1.
        /// </summary>
        private DiagnosticResult RunFuelPathObserver(SignalSeries ltft1, double trimBand,
                                                     bool advisory, string advisoryReason)
        {
            double meanTrim = ltft1.Mean;
            double residual = Math.Abs(meanTrim);
            if (residual <= trimBand) return null;                    // observer quiet — trim near 0

            bool lean = meanTrim >= 0;
            var r = NewResult("Fuel-path observer — sustained fuel-trim residual");
            r.Hypothesis =
                $"The fuel-path observer expects long-term trim near 0 % but LTFT B1 holds {Fmt(meanTrim)} % "
                + $"({(lean ? "adding" : "removing")} fuel) — a sustained residual of {Fmt(residual)} %. The fueling loop "
                + "is compensating for a persistent metering or delivery error. This observer only RAISES the flag; the "
                + "spatial pattern that separates a leak from a pump from a MAF bias is M1's fuel-trim surface.";
            r.Severity = DiagnosticSeverity.Medium;
            r.Confidence = ConfidenceFor(residual, trimBand);
            r.SuspectComponents = new List<string>
            {
                lean ? "Unmetered air / low fuel pressure / MAF reads low (lean)" : "Over-fuelling / high fuel pressure / MAF reads high (rich)",
                "See M1 fuel-trim surface for localisation",
            };
            r.NextTest =
                "Run M1 (fuel-trim surface) to locate the trim in the RPM/load envelope — idle-dominant ⇒ vacuum leak, "
                + "high-load-dominant ⇒ fuel-delivery shortfall, uniform ⇒ global metering/pressure bias.";

            r.Evidence
                .Info("Fuel-path observer model", "expected LTFT ≈ 0 % in closed loop",
                      "A healthy fueling loop needs little long-term correction — the observer's set-point.")
                .Measure("LTFT residual", meanTrim, -trimBand, trimBand, "%",
                         $"Sustained trim is outside the ±{Fmt(trimBand)} % band ⇒ a real fueling residual, not noise.");

            ApplyAdvisory(r, advisory, advisoryReason);
            return r;
        }

        // ── Idle operating-point extraction ───────────────────────────────────────

        /// <summary>
        /// Scan the aligned RPM / TPS / VSS / MAP series index-by-index and average
        /// the samples that satisfy the closed-throttle, vehicle-stopped, engine-
        /// running idle condition.  Idle is where idle control and manifold vacuum
        /// are authoritative, so both the idle-speed and air-path observers key off
        /// this same operating point.  Requires TPS OR VSS to gate "idle" — with
        /// neither we cannot establish a closed-throttle stationary condition.
        /// </summary>
        private static IdlePoint ExtractIdlePoint(DiagnosticSnapshot snapshot,
                                                  double tpsMax, double vssMax, double runMinRpm)
        {
            SignalSeries rpm = snapshot.Series(CanonicalSignals.Rpm);
            SignalSeries tps = snapshot.Series(CanonicalSignals.ThrottlePos);
            SignalSeries vss = snapshot.Series(CanonicalSignals.VehicleSpeed);
            SignalSeries map = snapshot.Series(CanonicalSignals.Map);

            bool hasTps = tps != null && tps.HasData;
            bool hasVss = vss != null && vss.HasData;
            if (rpm == null || !rpm.HasData || (!hasTps && !hasVss))
                return default; // cannot establish an idle condition without a throttle/speed gate

            IReadOnlyList<double> rpmV = rpm.Values();
            IReadOnlyList<double> tpsV = hasTps ? tps.Values() : null;
            IReadOnlyList<double> vssV = hasVss ? vss.Values() : null;
            bool hasMap = map != null && map.HasData;
            IReadOnlyList<double> mapV = hasMap ? map.Values() : null;

            int n = rpmV.Count;
            if (hasTps) n = Math.Min(n, tpsV.Count);
            if (hasVss) n = Math.Min(n, vssV.Count);

            var rpmAcc = new WelfordAccumulator();
            var mapAcc = new WelfordAccumulator();
            int mapSamples = 0;

            for (int i = 0; i < n; i++)
            {
                double rpmI = rpmV[i];
                // A dead-PID NaN slips past the run gate (NaN < runMinRpm is false), poisons the
                // Welford mean, then |NaN| <= band is false at the observer and fabricates a
                // NaN-confidence fault. Filter non-finite samples up front (as T2/T3 do).
                if (double.IsNaN(rpmI) || double.IsInfinity(rpmI)) continue;
                if (rpmI < runMinRpm) continue;                       // engine must be running
                if (hasTps && tpsV[i] > tpsMax) continue;             // throttle must be closed
                if (hasVss && vssV[i] > vssMax) continue;             // vehicle must be stopped

                rpmAcc.Add(rpmI);
                if (hasMap && i < mapV.Count)
                {
                    double mapI = mapV[i];
                    if (!double.IsNaN(mapI) && !double.IsInfinity(mapI)) { mapAcc.Add(mapI); mapSamples++; }
                }
            }

            if (rpmAcc.Count < MIN_IDLE_SAMPLES) return default;

            return new IdlePoint
            {
                Established = true,
                SampleCount = (int)rpmAcc.Count,
                RpmMean = rpmAcc.Mean,
                // Sample (n-1) stddev: the population form biases the idle-scatter estimate
                // LOW on the small idle windows this runs on, which sits right at the
                // hunting threshold and would suppress a genuine hunt.
                RpmStdDev = rpmAcc.SampleStdDev,
                HasMap = mapSamples >= MIN_IDLE_SAMPLES,
                MapMean = mapSamples > 0 ? mapAcc.Mean : double.NaN,
            };
        }

        // ── Active-control confirmation script (idle observers) ───────────────────

        /// <summary>Declarative idle-air step-test; the host runs it via UDSManager
        /// behind the active-control safety gate. Observe-only build here — the
        /// technician performs the physical pinch/step and watches RPM.</summary>
        private static ConfirmationScript BuildIdleAirScript(double measuredIdle, double targetIdle)
        {
            return new ConfirmationScript
            {
                Name = "Idle-air / vacuum step test",
                Rationale = $"Idle residual is {Fmt(measuredIdle - targetIdle)} rpm from target ({Fmt(targetIdle)} rpm). "
                            + "Perturb the air path and watch whether RPM responds to localise the residual.",
                Steps =
                {
                    new ConfirmationStep
                    {
                        Description = "Read idle RPM (0x22 engine-speed DID) as the baseline.",
                        ServiceId = 0x22,
                        Payload = null,
                        ExpectedObservation = $"Baseline RPM ≈ {Fmt(measuredIdle)} rpm at closed throttle.",
                        IsActiveControl = false,
                    },
                    new ConfirmationStep
                    {
                        Description = "Pinch each suspect vacuum line in turn while watching RPM.",
                        ServiceId = 0x00,
                        Payload = null,
                        ExpectedObservation = "An idle DROP when a line is pinched confirms a vacuum leak on that circuit; "
                                              + "no change points at throttle-body/idle-air rather than a leak.",
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

        /// <summary>Confidence in [0, 0.85]: rises from 0.45 at the band edge to 0.80
        /// once the residual is twice the band, then caps (Tier-2 stays advisory).</summary>
        private static double ConfidenceFor(double residualMag, double band)
        {
            if (band <= 0) return 0.4;
            double over = (Math.Abs(residualMag) - band) / band;      // 0 at edge, 1 at 2×band
            double c = 0.45 + 0.35 * SignalMath.Clamp(over, 0.0, 1.0);
            return SignalMath.Clamp(c, 0.0, 0.85);
        }

        /// <summary>Stamp the advisory flag + reason onto a result.</summary>
        private static void ApplyAdvisory(DiagnosticResult r, bool advisory, string reason)
        {
            if (!advisory) return;
            r.Advisory = true;
            r.AdvisoryReason = reason ?? "result rests on unvalidated observer geometry or thin data";
        }

        /// <summary>Format a possibly-NaN value compactly and culture-invariantly.</summary>
        private static string Fmt(double v)
        {
            if (double.IsNaN(v)) return "n/a";
            return v.ToString("0.#", CultureInfo.InvariantCulture);
        }

        /// <summary>The shared idle operating point both idle observers key off.</summary>
        private struct IdlePoint
        {
            public bool Established;   // enough closed-throttle/stopped samples to judge idle
            public int SampleCount;    // idle-condition sample count
            public double RpmMean;     // mean RPM over idle-condition samples
            public double RpmStdDev;   // RPM scatter at idle (hunting detector)
            public bool HasMap;        // MAP available over the idle condition
            public double MapMean;     // mean MAP over idle-condition samples; NaN if none
        }
    }
}
