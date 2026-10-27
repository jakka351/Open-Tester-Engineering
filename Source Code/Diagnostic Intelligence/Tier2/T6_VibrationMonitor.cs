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
//  Tester Present Specialist Automotive Solutions — T6 Knock-Sensor Order-Domain Vibration (Tier-2)
//
//  A knock sensor is an accelerometer bolted to the block.  If the ECU exposes its
//  voltage (or a knock-retard proxy) as a named vendor DID series, the vibration it
//  carries is not random — mechanical wear rings the block at frequencies LOCKED to
//  crank rotation, so the diagnosis lives in the ORDER domain (cycles per crank rev),
//  not the frequency domain.  Converting a raw Hz reading to an engine order removes
//  RPM from the picture and lets a fixed physical signature identify the culprit:
//
//    order = event_frequency / (RPM / 60)          [ crank rotation = RPM/60 Hz ]
//
//    • 0.5× order  — HALF crank speed.  The main/rod bearings, crank journals and the
//      combustion event on a 4-stroke all recur once per TWO revolutions (the cam and
//      the power stroke are half-speed events).  A bottom-end / main-bearing knock —
//      excess bearing clearance pounding once per firing cycle — rings at 0.5×.  This
//      is the serious one: oil-starved or spun bearings fail catastrophically.
//    • 1.0× order  — ONCE per crank rev.  Piston slap (piston rocking in a worn bore
//      as the crank passes TDC/BDC) and rod-small-end knock recur every revolution.
//    • 0.25× order — HALF cam speed (cam already runs at 0.5× crank).  Valve-train
//      events — a collapsed lifter, excess lash, a worn follower — recur once per two
//      cam revolutions ⇒ once per four crank revolutions ⇒ 0.25×.
//    • 2.0× order  — twice per rev.  Normal firing/combustion structure on many
//      engines; a dominant 2.0× is NOT a wear signature, so it is treated as healthy.
//
//    • DETONATION (not mechanical).  Abnormal combustion excites the sensor as a
//      BROADBAND burst that is NOT phase-locked to a single low order, and the ECU
//      responds by pulling timing (knock retard).  Elevated broadband knock content
//      with high sustained retard points at fuel/timing (low octane, over-advance,
//      lean, carbon hot-spots), not at a worn part.
//
//  The transform: with OBD-rate DID data the sample rate is coarse, so instead of a
//  full FFT we run a single-bin (Goertzel-style) correlation of the mean-removed
//  knock signal against each candidate order — mapping order→Hz with the MEAN RPM of
//  the capture and rejecting any order at or above Nyquist (fs/2) or with fewer than
//  two whole cycles in the window.  The strongest resolvable order names the suspect.
//
//  Tier-2 honesty: order-domain analysis from OBD-rate samples is INDICATIVE only —
//  true knock/detonation energy sits in the kHz and is aliased away here — and the
//  amplitude bands are spec-seeded, not validated against a characterised fault on
//  this platform.  Every result is emitted ADVISORY, pointing at a stethoscope /
//  accelerometer + oil-pressure confirmation as the discriminating physical test.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using TesterPresent.OBD2.Intelligence;

namespace TesterPresent.OBD2.Intelligence.Tier2
{
    /// <summary>
    /// T6 — Knock-Sensor Order-Domain Vibration.  Gated on the presence of a knock-like
    /// vendor DID series (name contains "knock" or "KR") plus RPM; transforms the knock
    /// signal to the crank-order domain and matches the dominant engine order against a
    /// fixed mechanical signature (0.5× bearing, 1.0× piston slap, 0.25× valve-train),
    /// or flags detonation when broadband content rides with high knock-retard.  Reads
    /// snapshot + context only; never touches hardware.
    /// </summary>
    public sealed class VibrationMonitorModule : DiagnosticModuleBase
    {
        // ── Candidate crank orders and the mechanical mechanism each one indicts. ──
        //    Definitional physics, not calibratable thresholds.
        private const double ORDER_VALVETRAIN = 0.25; // half cam speed  ⇒ valve-train
        private const double ORDER_BEARING    = 0.50; // half crank/firing ⇒ bottom-end / main bearings
        private const double ORDER_PISTON     = 1.00; // once per rev    ⇒ piston slap / rod
        private const double ORDER_COMBUSTION = 2.00; // twice per rev   ⇒ normal firing structure (healthy)
        private const double ORDER_TOL        = 0.15; // ± window that binds a measured order to a candidate

        private const int    MIN_SAMPLES      = 32;   // below this the single-bin correlation is unreliable
        private const double MIN_CYCLES       = 2.0;  // need ≥ 2 whole cycles of an order in the window to trust its bin
        private const double NYQUIST_MARGIN   = 0.95; // stay below fs/2 by this factor

        private DiagnosticRequirements _requirements;

        /// <inheritdoc/>
        public override string ModuleId => "T6";

        /// <inheritdoc/>
        public override string DisplayName => "Knock-Sensor Order-Domain Vibration";

        /// <inheritdoc/>
        public override DiagnosticTier Tier => DiagnosticTier.Tier2;

        /// <inheritdoc/>
        public override DiagnosticRequirements Requirements =>
            _requirements ?? (_requirements = new DiagnosticRequirements
            {
                // Knock is a rarely-exposed vendor DID with no canonical name, so the
                // presence gate is applied inside AnalyzeCore, not via RequiredSignals.
                RequiredSignals = new List<string>(),
                MinSamples = MIN_SAMPLES,
            });

        /// <summary>
        /// Locate a knock-like series, transform it to the crank-order domain via mean
        /// RPM, and emit a mechanical (by order) and/or a detonation hypothesis when the
        /// order structure departs from healthy.  Returns empty when no knock series is
        /// present (the common OBD case) or when the vibration is unremarkable.
        /// </summary>
        protected override IReadOnlyList<DiagnosticResult> AnalyzeCore(
            DiagnosticSnapshot snapshot, DiagnosticContext context)
        {
            var results = new List<DiagnosticResult>();

            // ── Separate the two knock channels up front ──
            //  • VIBRATION: raw knock-sensor voltage/amplitude (order-analysable).
            //  • RETARD:    knock-retard in DEGREES (Ford "KR") — a control OUTPUT, not an
            //               accelerometer signal, so it must never be order-analysed.
            SignalSeries knock = FindKnockSeries(snapshot);      // excludes retard channels
            SignalSeries retard = FindAnyRetardSeries(snapshot); // degrees channel, if any
            bool haveVibration = knock != null && knock.HasData && knock.Count >= MIN_SAMPLES;

            // Nothing knock-related at all → empty (the common OBD case).
            if (!haveVibration && retard == null) return results;

            // ── Spec-seeded amplitude / detonation bands (unvalidated until characterised) ──
            bool usedUnvalidated = false;
            double dominanceThr = Cal(context, "T6.OrderDominanceFraction", 0.50, ref usedUnvalidated); // share of order-band energy
            double retardHighDeg = Cal(context, "T6.KnockRetardHighDeg",     6.0,  ref usedUnvalidated); // sustained retard ⇒ detonation
            double meanRetard = retard != null && retard.HasData ? Math.Abs(retard.Mean) : double.NaN;

            // ── RETARD-ONLY: no accelerometer voltage, but a knock-retard channel exists
            //  (e.g. Ford exposes only KR degrees).  Mechanical order analysis is impossible,
            //  but a sustained high retard is still a real detonation signal — emit it rather
            //  than dropping the reading. ──
            if (!haveVibration)
            {
                if (!double.IsNaN(meanRetard) && meanRetard >= retardHighDeg)
                    results.Add(BuildDetonationFromRetard(meanRetard, retardHighDeg,
                        BuildRetardOnlyAdvisory(context, usedUnvalidated)));
                return results;
            }

            // ── GATE: RPM is mandatory for the order transform — order = frequency / (RPM/60). ──
            SignalSeries rpm = snapshot.Series(CanonicalSignals.Rpm);
            double meanRpm = rpm != null && rpm.HasData ? rpm.Mean : 0.0;
            if (rpm == null || !rpm.HasData || meanRpm < 100.0)
            {
                // Can't order-lock (stationary / KOEO / no RPM), but a high retard is still
                // a detonation read.
                if (!double.IsNaN(meanRetard) && meanRetard >= retardHighDeg)
                    results.Add(BuildDetonationFromRetard(meanRetard, retardHighDeg,
                        BuildRetardOnlyAdvisory(context, usedUnvalidated)));
                return results;
            }

            // ── Transform to the order domain: single-bin correlation per candidate order ──
            double[] x = knock.Values().Select(v => v).ToArray();
            double[] t = RelativeSeconds(knock);
            double fs = knock.EstimatedHz;
            double windowSec = t.Length > 0 ? t[t.Length - 1] : 0;
            if (fs <= 0 || windowSec <= 0) return results;   // no usable time base ⇒ cannot map order→Hz

            double crankHz = meanRpm / 60.0;                 // crank rotation frequency
            double nyquist = fs / 2.0;
            double meanX = SignalMath.Mean(x);
            double acStd = SignalMath.StdDev(x.ToList());    // AC content (about the mean)

            var orders = new[] { ORDER_VALVETRAIN, ORDER_BEARING, ORDER_PISTON, ORDER_COMBUSTION };
            var comps = new List<OrderComponent>();
            foreach (double ord in orders)
            {
                double f = ord * crankHz;                    // order → Hz
                if (f >= nyquist * NYQUIST_MARGIN) continue; // aliased / unresolvable at this sample rate
                if (f * windowSec < MIN_CYCLES) continue;    // too few whole cycles in the window to trust the bin
                double amp = OrderAmplitude(x, t, meanX, f);
                comps.Add(new OrderComponent { Order = ord, FreqHz = f, Amplitude = amp });
            }

            // (knock-retard proxy `meanRetard` was resolved up front, alongside the
            //  vibration channel, so a KR degrees series is never order-analysed here.)

            // Nothing resolvable in-band (RPM too high for the sample rate) — say so, advisory-info.
            if (comps.Count == 0)
                return results;

            // ── Pick the strongest resolvable order and its share of the order-band energy ──
            double bandEnergy = comps.Sum(c => c.Amplitude * c.Amplitude);
            if (bandEnergy < 1e-12 || acStd < 1e-9)
                return results;   // flat / no vibration content ⇒ healthy, nothing to report

            OrderComponent dom = comps.OrderByDescending(c => c.Amplitude).First();
            double domFraction = (dom.Amplitude * dom.Amplitude) / bandEnergy;   // 0..1 how single-order the vibration is
            double domRelative = dom.Amplitude / (acStd * Math.Sqrt(2.0));        // ≈1.0 when the AC swing is a pure tone at this order

            // ── Advisory posture (Tier-2 order analysis is inherently indicative on OBD data) ──
            bool marginalRate = fs < 4.0 * dom.FreqHz;   // < ~4 samples per cycle of the dominant order
            string advisoryReason = BuildAdvisoryReason(context, usedUnvalidated, fs, dom.FreqHz, marginalRate);

            // ── Mechanical signature: a low mechanical order clearly dominates the band ──
            bool mechanicalOrder = Near(dom.Order, ORDER_BEARING) || Near(dom.Order, ORDER_PISTON) || Near(dom.Order, ORDER_VALVETRAIN);
            if (mechanicalOrder && domFraction >= dominanceThr)
            {
                results.Add(BuildMechanical(dom, domFraction, domRelative, dominanceThr, meanRpm, fs,
                                            windowSec, comps, meanRetard, advisoryReason));
            }

            // ── Detonation signature: high sustained knock-retard (elevated broadband, not a worn part) ──
            if (!double.IsNaN(meanRetard) && meanRetard >= retardHighDeg)
            {
                results.Add(BuildDetonation(meanRetard, retardHighDeg, dom, domFraction, meanRpm,
                                            windowSec, mechanicalOrder, advisoryReason));
            }

            return results;
        }

        // ── Mechanical-wear result (named by dominant crank order) ─────────────────────

        /// <summary>
        /// A single low crank order carries the majority of the vibration band energy ⇒
        /// a mechanical knock phase-locked to rotation.  The order names the suspect:
        /// 0.5× bearings (serious), 1.0× piston slap / rod, 0.25× valve-train.
        /// </summary>
        private DiagnosticResult BuildMechanical(OrderComponent dom, double domFraction, double domRelative,
                                                 double dominanceThr, double meanRpm, double fs, double windowSec,
                                                 List<OrderComponent> comps, double meanRetard, string advisoryReason)
        {
            string mechanism; DiagnosticSeverity severity; List<string> suspects; string orderLabel;
            if (Near(dom.Order, ORDER_BEARING))
            {
                orderLabel = "0.5× (half crank / firing order)";
                mechanism = "bottom-end / main- or rod-bearing knock — excess bearing clearance pounding once per firing cycle. "
                            + "This is the serious mode: an oil-starved or spun bearing fails catastrophically and quickly.";
                severity = DiagnosticSeverity.High;
                suspects = new List<string>
                {
                    "Main / rod bearings (excess clearance, spun or oil-starved)",
                    "Crankshaft journals (wear / out-of-round)",
                    "Oil pressure / supply (low pressure starving the bearings)",
                };
            }
            else if (Near(dom.Order, ORDER_PISTON))
            {
                orderLabel = "1.0× (once per crank revolution)";
                mechanism = "piston slap or rod small-end knock — a piston rocking in a worn bore as the crank passes TDC/BDC, "
                            + "recurring every revolution. Often loudest cold and easing as the piston expands to fit the bore.";
                severity = DiagnosticSeverity.Medium;
                suspects = new List<string>
                {
                    "Piston(s) / cylinder bore (piston slap, worn skirt or bore taper)",
                    "Wrist pin / rod small-end bushing",
                    "Connecting rod (rod knock — escalate to High if it grows with load)",
                };
            }
            else // valve-train, 0.25×
            {
                orderLabel = "0.25× (half cam speed)";
                mechanism = "valve-train knock — a collapsed hydraulic lifter, excess valve lash, or a worn cam follower, "
                            + "recurring once per two cam revolutions (a quarter of crank speed).";
                severity = DiagnosticSeverity.Medium;
                suspects = new List<string>
                {
                    "Hydraulic lifter / lash adjuster (collapsed, bled down)",
                    "Valve lash / rocker (excess clearance)",
                    "Cam lobe / follower (wear); timing chain tensioner (slack)",
                };
            }

            var r = NewResult($"Order-domain knock at {orderLabel} — {SuspectHeadline(dom.Order)}");
            r.Hypothesis =
                $"The knock-sensor vibration is dominated by the {orderLabel} engine order: it carries {Pct(domFraction)} of the "
                + $"resolved order-band energy and accounts for {Pct(SignalMath.Clamp(domRelative, 0, 1))} of the AC swing "
                + $"(≈{Fmt(dom.FreqHz)} Hz at a mean {Fmt0(meanRpm)} rpm). A vibration phase-locked to this order points at "
                + $"{mechanism} Order-domain from OBD-rate data is indicative, not confirmatory.";
            r.Severity = severity;
            r.Confidence = ConfidenceFor(domFraction, dominanceThr, domRelative);
            r.SuspectComponents = suspects;
            r.NextTest =
                "Confirm with a mechanic's stethoscope / accelerometer at the suspect location and an oil-pressure check; "
                + "order-domain from OBD-rate data is indicative only. Pinpoint the source (main-cap area vs bore vs valve cover), "
                + "verify hot oil pressure against spec, and drop a cylinder to see whether the knock quietens (bearing/piston) "
                + "or is unchanged (valve-train).";
            r.NextTestScript = BuildStethoscopeScript(dom.Order, meanRpm);

            r.Evidence
                .Info("Knock series", $"{comps.Count} candidate orders resolved below Nyquist",
                      $"Transformed to the crank-order domain using mean {Fmt0(meanRpm)} rpm (crank {Fmt(meanRpm / 60.0)} Hz).")
                .Info("Sample rate", $"knock ≈ {Fmt(fs)} Hz over {Fmt(windowSec)} s",
                      "OBD PID rate — far below true knock energy (kHz), which is aliased away; only rotation-locked order structure survives.")
                .Add("Dominant order", $"{Ord(dom.Order)}× ({Fmt(dom.FreqHz)} Hz)", "0.25× / 0.5× / 1.0× carry mechanical wear signatures",
                     EvidenceVerdict.Info, "The strongest resolvable engine order — the mechanism it indicts is fixed by physics.")
                .Measure("Order dominance", domFraction, dominanceThr, 1.0, "",
                         $"Share of the resolved order-band energy at {Ord(dom.Order)}×; above {Pct(dominanceThr)} ⇒ a single mechanical order dominates.")
                .Info("Order-band amplitudes",
                      string.Join(", ", comps.OrderBy(c => c.Order).Select(c => $"{Ord(c.Order)}×={c.Amplitude.ToString("0.###", CultureInfo.InvariantCulture)}")),
                      "Single-bin correlation amplitude per candidate order (arbitrary DID units).");

            if (!double.IsNaN(meanRetard))
                r.Evidence.Info("Knock retard", $"{Fmt(meanRetard)}° mean",
                                "Low retard alongside a dominant low order supports mechanical (not detonation) origin.");

            r.Advisory = true;
            r.AdvisoryReason = advisoryReason;
            return r;
        }

        // ── Detonation result (fuel / timing, not a worn part) ─────────────────────────

        /// <summary>
        /// High sustained knock-retard with broadband (non-single-order) sensor content is
        /// abnormal combustion, not mechanical wear — the ECU is pulling timing to survive
        /// it.  Cause is fuel/timing: low octane, over-advance, lean, or carbon hot-spots.
        /// </summary>
        private DiagnosticResult BuildDetonation(double meanRetard, double retardHighDeg, OrderComponent dom,
                                                 double domFraction, double meanRpm, double windowSec,
                                                 bool mechanicalOrder, string advisoryReason)
        {
            var r = NewResult("Detonation / abnormal combustion (fuel-timing, not mechanical)");
            r.Hypothesis =
                $"Knock retard is running a sustained mean {Fmt(meanRetard)}° — past the {Fmt(retardHighDeg)}° detonation band — "
                + $"while the sensor content is {(mechanicalOrder ? "only partly" : "not")} concentrated in a single low order "
                + $"({Pct(domFraction)} at {Ord(dom.Order)}×). That is abnormal combustion the ECU is fighting by pulling timing, "
                + "not a worn part: the likely cause is low-octane fuel, over-advanced ignition, a lean mixture, excess intake-air "
                + "temperature, or carbon hot-spots pre-igniting the charge. Left under load, detonation holes pistons and lands.";
            r.Severity = DiagnosticSeverity.Medium;
            r.Confidence = ConfidenceFor(SignalMath.Clamp(meanRetard / (retardHighDeg * 2.0), 0, 1), 0.5, 1.0);
            r.SuspectComponents = new List<string>
            {
                "Fuel octane (too low for the calibration)",
                "Ignition timing (over-advanced / knock-sensor circuit not retarding correctly)",
                "Lean mixture (vacuum leak, fuel delivery) / high intake-air temperature",
                "Carbon deposits (hot-spot pre-ignition) / EGR fault",
            };
            r.NextTest =
                "Confirm with a mechanic's stethoscope / accelerometer at the suspect location and an oil-pressure check; "
                + "order-domain from OBD-rate data is indicative only. For detonation specifically, log knock-retard versus load "
                + "on a road load, try a known high-octane fill, and verify ignition timing and intake-air temperature — if "
                + "retard follows load and clears on better fuel, it is combustion, not a mechanical knock.";

            r.Evidence
                .Measure("Knock retard (mean)", meanRetard, 0.0, retardHighDeg, "°",
                         $"Sustained retard above {Fmt(retardHighDeg)}° ⇒ the ECU is actively pulling timing to suppress knock.")
                .Add("Order concentration", $"{Pct(domFraction)} at {Ord(dom.Order)}×", "broadband (no single low order dominates)",
                     mechanicalOrder ? EvidenceVerdict.Inconclusive : EvidenceVerdict.Fail,
                     "Detonation excites the sensor broadband rather than phase-locking to one mechanical order.")
                .Info("Operating point", $"mean {Fmt0(meanRpm)} rpm over {Fmt(windowSec)} s", null);

            r.Advisory = true;
            r.AdvisoryReason = advisoryReason;
            return r;
        }

        /// <summary>
        /// Detonation inferred from the knock-retard (degrees) channel alone — used when a
        /// vehicle exposes only KR and no accelerometer voltage, so mechanical order analysis
        /// cannot run.  A sustained high retard is still a real abnormal-combustion signal.
        /// </summary>
        private DiagnosticResult BuildDetonationFromRetard(double meanRetard, double retardHighDeg, string advisoryReason)
        {
            var r = NewResult("Detonation / abnormal combustion (knock-retard, no vibration channel)");
            r.Hypothesis =
                $"Knock retard is running a sustained mean {Fmt(meanRetard)}° — past the {Fmt(retardHighDeg)}° detonation band. "
                + "The ECU is actively pulling timing to survive abnormal combustion. This vehicle exposes only a knock-retard "
                + "(degrees) channel and no knock-sensor voltage, so the mechanical order structure cannot be checked — but the "
                + "sustained retard itself is the signal: likely low-octane fuel, over-advanced ignition, a lean mixture, high "
                + "intake-air temperature, or carbon hot-spots pre-igniting the charge.";
            r.Severity = DiagnosticSeverity.Medium;
            r.Confidence = ConfidenceFor(SignalMath.Clamp(meanRetard / (retardHighDeg * 2.0), 0, 1), 0.5, 1.0);
            r.SuspectComponents = new List<string>
            {
                "Fuel octane (too low for the calibration)",
                "Ignition timing (over-advanced / knock-sensor circuit not retarding correctly)",
                "Lean mixture (vacuum leak, fuel delivery) / high intake-air temperature",
                "Carbon deposits (hot-spot pre-ignition) / EGR fault",
            };
            r.NextTest =
                "Log knock-retard versus load on a road load and try a known high-octane fill; verify ignition timing and "
                + "intake-air temperature. If retard follows load and clears on better fuel, it is combustion, not a mechanical knock.";
            r.Evidence
                .Measure("Knock retard (mean)", meanRetard, 0.0, retardHighDeg, "°",
                         $"Sustained retard above {Fmt(retardHighDeg)}° ⇒ the ECU is actively pulling timing to suppress knock.")
                .Inconclusive("Mechanical order structure", "not available", "knock-sensor voltage channel",
                         "Only a knock-retard (degrees) channel is exposed — no accelerometer voltage to order-analyse for a mechanical knock.");
            r.Advisory = true;
            r.AdvisoryReason = advisoryReason;
            return r;
        }

        /// <summary>Advisory reason for a retard-only detonation read (no vibration channel).</summary>
        private static string BuildRetardOnlyAdvisory(DiagnosticContext context, bool usedUnvalidated)
        {
            string reason =
                "detonation inferred from the knock-retard (degrees) channel alone — no knock-sensor voltage was exposed, so "
                + "mechanical order analysis could not run; the retard band is spec-seeded, not validated on this platform";
            if (usedUnvalidated || context == null || context.Calibration == null || !context.Calibration.IsValidated)
                reason += " (no validated calibration present)";
            return reason;
        }

        // ── Series discovery ───────────────────────────────────────────────────────────

        /// <summary>
        /// Scan the snapshot's signal keys (case-insensitive) for a knock-like vendor DID —
        /// a name containing "knock" or "KR".  Prefer a raw-voltage / amplitude signal
        /// (excludes an obvious retard/count channel) and, among candidates, the one with
        /// the most AC content, since that is the vibration channel.  Null if none.
        /// </summary>
        private static SignalSeries FindKnockSeries(DiagnosticSnapshot snap)
        {
            if (snap == null) return null;
            SignalSeries best = null;
            double bestStd = -1;
            foreach (var kv in snap.Signals)
            {
                if (!IsKnockName(kv.Key)) continue;
                var s = kv.Value;
                if (s == null || !s.HasData) continue;
                if (IsRetardName(kv.Key)) continue;          // a retard (degrees) channel is NOT the vibration signal — never order-analyse it
                if (s.StdDev > bestStd) { bestStd = s.StdDev; best = s; }
            }
            // No fallback to retard channels: a knock-retard (degrees) series is a control
            // output, not an accelerometer voltage.  If the only knock-related series is a
            // retard channel, there is no vibration channel — the caller runs the retard-only
            // detonation path instead of order-analysing degrees as if they were vibration.
            return best;
        }

        /// <summary>Find any knock-retard (degrees) channel with data — used to corroborate
        /// detonation, and (when no vibration channel exists) to drive a retard-only
        /// detonation check.  Null if none.</summary>
        private static SignalSeries FindAnyRetardSeries(DiagnosticSnapshot snap)
        {
            if (snap == null) return null;
            foreach (var kv in snap.Signals)
            {
                if (!IsKnockName(kv.Key)) continue;
                if (IsRetardName(kv.Key) && kv.Value != null && kv.Value.HasData) return kv.Value;
            }
            return null;
        }

        /// <summary>True for a knock-RELATED series name: the raw knock-sensor voltage
        /// ("Knock…", "KNK…") or the Ford knock-retard family ("KR", "KR1", "KNKRTD").</summary>
        private static bool IsKnockName(string name)
        {
            if (string.IsNullOrEmpty(name)) return false;
            string u = name.ToUpperInvariant().Trim();
            return u.IndexOf("KNOCK", StringComparison.Ordinal) >= 0
                   || u.IndexOf("KNK", StringComparison.Ordinal) >= 0
                   || u == "KR"
                   || (u.Length >= 2 && u[0] == 'K' && u[1] == 'R'
                       && (u.Length == 2 || char.IsDigit(u[2]) || u[2] == '_'));
        }

        /// <summary>True if a knock-related channel measures knock RETARD (degrees of timing
        /// pulled), NOT accelerometer vibration.  Ford "KR"/"KR1"/"KNKRTD" and any "…retard"
        /// name are degree channels: order-analysing them as vibration fabricates a spurious
        /// mechanical-knock hypothesis, so they are steered to the detonation (retard) path.</summary>
        private static bool IsRetardName(string name)
        {
            if (string.IsNullOrEmpty(name)) return false;
            string u = name.ToUpperInvariant().Trim();
            if (u.IndexOf("RETARD", StringComparison.Ordinal) >= 0) return true;
            if (u.IndexOf("KNKR", StringComparison.Ordinal) >= 0) return true;     // KNKRTD / KNKRET
            if (u.IndexOf("KNOCKRET", StringComparison.Ordinal) >= 0) return true; // KnockRetard
            if (u == "KR") return true;
            if (u.Length >= 2 && u[0] == 'K' && u[1] == 'R'
                && (u.Length == 2 || char.IsDigit(u[2]))) return true;             // KR / KR1 / KR2 (degrees)
            return false;
        }

        // ── Order-domain math ──────────────────────────────────────────────────────────

        /// <summary>
        /// Single-bin (Goertzel-style) DFT amplitude of a mean-removed series at frequency
        /// <paramref name="freqHz"/>, using the sample timestamps so it is robust to jitter.
        /// A = 2/N · |Σ (xᵢ−μ)·e^{−j2πf tᵢ}| — the amplitude of the sinusoid at that order.
        /// </summary>
        private static double OrderAmplitude(double[] x, double[] t, double meanX, double freqHz)
        {
            double re = 0, im = 0;
            int n = x.Length;
            for (int i = 0; i < n; i++)
            {
                double ph = 2.0 * Math.PI * freqHz * t[i];
                double d = x[i] - meanX;
                re += d * Math.Cos(ph);
                im += d * Math.Sin(ph);
            }
            re *= 2.0 / n;
            im *= 2.0 / n;
            return Math.Sqrt(re * re + im * im);
        }

        /// <summary>Sample timestamps in seconds relative to the first sample.</summary>
        private static double[] RelativeSeconds(SignalSeries s)
        {
            var samples = s.Samples;
            var t = new double[samples.Count];
            if (samples.Count == 0) return t;
            DateTime t0 = samples[0].Utc;
            for (int i = 0; i < samples.Count; i++)
                t[i] = (samples[i].Utc - t0).TotalSeconds;
            return t;
        }

        private static bool Near(double order, double target) => Math.Abs(order - target) <= ORDER_TOL;

        private static string SuspectHeadline(double order)
        {
            if (Near(order, ORDER_BEARING)) return "main/rod-bearing knock (serious)";
            if (Near(order, ORDER_PISTON))  return "piston slap / rod knock";
            if (Near(order, ORDER_VALVETRAIN)) return "valve-train knock";
            return "engine-order vibration";
        }

        // ── Confirmation script ────────────────────────────────────────────────────────

        /// <summary>Observe-only stethoscope / accelerometer localisation test — the
        /// technician performs the physical probe; the host never commands the ECU.</summary>
        private static ConfirmationScript BuildStethoscopeScript(double order, double meanRpm)
        {
            string where = Near(order, ORDER_BEARING) ? "the main-bearing caps / lower block and oil-pressure port"
                         : Near(order, ORDER_PISTON)  ? "the cylinder-bore area (mid-block)"
                         : "the valve cover / cam-tunnel area";
            return new ConfirmationScript
            {
                Name = "Stethoscope / accelerometer localisation + oil-pressure check",
                Rationale = $"A {Ord(order)}× order dominates the knock-sensor vibration at ~{Fmt0(meanRpm)} rpm. Localise the "
                            + "physical source and verify oil pressure to separate a bearing/piston knock from valve-train noise.",
                Steps =
                {
                    new ConfirmationStep
                    {
                        Description = $"Probe {where} with a stethoscope / accelerometer while the engine idles and is lightly loaded.",
                        ServiceId = 0x00,
                        Payload = null,
                        ExpectedObservation = "The knock is loudest at the indicated location and tracks engine speed (order-locked), "
                                              + "not exhaust or accessory-belt noise.",
                        IsActiveControl = false,
                    },
                    new ConfirmationStep
                    {
                        Description = "Measure hot oil pressure against spec and, if practical, drop the suspect cylinder.",
                        ServiceId = 0x00,
                        Payload = null,
                        ExpectedObservation = "Low oil pressure supports bearing knock; the knock quietening on cylinder drop points at "
                                              + "that piston/bearing; unchanged noise points at the valve-train.",
                        IsActiveControl = false,
                    },
                },
            };
        }

        // ── Small helpers ────────────────────────────────────────────────────────────────

        /// <summary>Read a calibration constant, folding an unvalidated read into the advisory flag.</summary>
        private static double Cal(DiagnosticContext ctx, string key, double fallback, ref bool usedUnvalidated)
        {
            if (ctx == null || ctx.Calibration == null) { usedUnvalidated = true; return fallback; }
            bool validated;
            double v = ctx.Calibration.Value(key, fallback, out validated);
            if (!validated) usedUnvalidated = true;
            return v;
        }

        /// <summary>Confidence in [0, 0.75]: 0.4 at the dominance edge, rising with how far
        /// past it the order sits and how tonal the swing is, then capped — Tier-2 order
        /// analysis on OBD-rate data stays advisory.</summary>
        private static double ConfidenceFor(double domFraction, double threshold, double domRelative)
        {
            double over = threshold >= 1.0 ? 0 : SignalMath.Clamp((domFraction - threshold) / (1.0 - threshold), 0.0, 1.0);
            double tonal = SignalMath.Clamp(domRelative, 0.0, 1.0);
            double c = 0.40 + 0.25 * over + 0.10 * tonal;
            return SignalMath.Clamp(c, 0.0, 0.75);
        }

        /// <summary>Assemble the advisory reason: order analysis is indicative on OBD-rate
        /// data, the amplitude bands are spec-seeded, and the rate may be marginal.</summary>
        private static string BuildAdvisoryReason(DiagnosticContext context, bool usedUnvalidated,
                                                  double fs, double domFreqHz, bool marginalRate)
        {
            string reason =
                "order-domain analysis from OBD-rate knock samples is INDICATIVE only — true knock/detonation energy is in the "
                + "kHz and is aliased away, so this resolves rotation-locked structure, not the knock itself; the amplitude and "
                + "detonation bands are spec-seeded, not validated against a characterised fault on this platform";
            if (usedUnvalidated || context == null || context.Calibration == null || !context.Calibration.IsValidated)
                reason += " (no validated calibration present)";
            if (marginalRate)
                reason += $"; sample rate ≈ {Fmt(fs)} Hz gives under ~4 samples per cycle of the dominant {Fmt(domFreqHz)} Hz order — "
                          + "the amplitude estimate is coarse";
            return reason;
        }

        /// <summary>Culture-invariant format for an engine-order value ("0.5", "1", "2"),
        /// so the "×" order strings match the invariant-formatted amplitudes in the same
        /// evidence line (a current-culture "0,5" in an IT locale would read inconsistently).</summary>
        private static string Ord(double v) => v.ToString("0.##", CultureInfo.InvariantCulture);

        private static string Fmt(double v)
            => double.IsNaN(v) ? "n/a" : v.ToString("0.0#", CultureInfo.InvariantCulture);

        private static string Fmt0(double v)
            => double.IsNaN(v) ? "n/a" : v.ToString("0", CultureInfo.InvariantCulture);

        private static string Pct(double frac)
            => (SignalMath.Clamp(frac, 0, 1) * 100).ToString("0", CultureInfo.InvariantCulture) + "%";

        /// <summary>One resolved crank-order component: its order, its Hz at mean RPM, and
        /// the single-bin correlation amplitude in the knock signal's (arbitrary) units.</summary>
        private struct OrderComponent
        {
            public double Order;
            public double FreqHz;
            public double Amplitude;
        }
    }
}
