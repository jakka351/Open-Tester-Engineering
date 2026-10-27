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
//  Tester Present Specialist Automotive Solutions — T4 Frequency-Response via Commanded Dither (Tier-2)
//
//  A steady mean value hides dynamics.  Two engines can idle at exactly the same
//  average RPM yet behave completely differently: one holds a flat 700 rpm, the
//  other HUNTS — swinging ±120 rpm at a couple of hertz because its idle loop is
//  fighting a sticky actuator.  The dynamic signature (dominant OSCILLATION
//  frequency + how fast it DAMPS) is the fingerprint of actuator/sensor/control
//  health, and it is invisible to any range check on the mean.
//
//  The complete method commands a small SINUSOIDAL DITHER onto an actuator host-
//  side (0x2F IOControl) and measures the response amplitude and phase to recover
//  the plant's gain/phase (a one-point Bode estimate).  This module stays PURE: it
//  (a) analyses whatever oscillation is ALREADY present in the captured signals to
//  estimate the dominant frequency, its amplitude and its damping, and (b) hands
//  back a ConfirmationScript describing the active dither test the host should run
//  to confirm.  No hardware is touched here.
//
//  MODEL — a lightweight, dependency-free spectral estimate (no FFT library):
//
//    1. DETREND — subtract the signal mean so the oscillation sits about zero.
//
//    2. DOMINANT FREQUENCY — two independent estimators, reconciled:
//       • ZERO-CROSSING count (with amplitude hysteresis so sensor noise near the
//         mean does not manufacture crossings).  N half-cycles between the first
//         and last hysteresis crossing over their time span give a CONTINUOUS
//         frequency f = (crossings−1) / (2·Δt) — it is not quantised to a bin, so
//         it resolves an off-grid rate like a lazy 0.3 Hz O2 switch.
//       • A CORRELATION BANK — Goertzel-style projection onto sin/cos at a few
//         candidate rates {0.5, 1, 2, 5, 10} Hz, restricted to BELOW Nyquist
//         (= fs/2) so an unresolvable rate is never claimed.  For a real sinusoid
//         at f the projected amplitude A = √(a²+b²) with a,b = (2/N)Σ x·cos/sin.
//       The zero-crossing rate is added to the candidate set and the frequency
//       whose projection captures the MOST variance wins; its A is the amplitude.
//       COHERENCE = (A²/2)/variance ∈ [0,1] measures how sinusoidal (vs broadband
//       noise) the motion is — the selector only trusts a coherent oscillation.
//
//    3. DAMPING — log-decrement over successive positive peaks of the detrended
//       signal.  If peak amplitudes decay geometrically the per-period decrement
//       δ = mean ln(Pk/Pk+1) gives the damping ratio ζ = δ/√(4π²+δ²).  If the
//       peaks do NOT shrink the oscillation is SUSTAINED (ζ≈0) — a limit cycle,
//       the signature of a control loop that keeps fighting itself.
//
//  INTERPRET — a coherent oscillation is a fault only where the signal SHOULD be
//  steady, or (for a sensor that is MEANT to switch) where its rate has gone slow:
//    • RPM / TPS / MAP / LTFT should sit flat once settled.  A sustained (low-
//      damping) oscillation above the healthy amplitude band is a control-loop or
//      actuator-dynamics fault — idle hunting, throttle chatter, a fuel loop that
//      oscillates.  Low damping ⇒ a sluggish/sticky actuator or over-aggressive
//      control gain.
//    • O2 (upstream) is SUPPOSED to switch — healthy closed loop toggles it near
//      ~1 Hz at idle.  A SLOW switch (< ~0.5 Hz) with real amplitude is a LAZY
//      (aged) sensor whose transport/response time has stretched.
//
//  Tier-2 honesty: the healthy amplitude bands and the O2 switch-rate floor are
//  SPEC-SEEDED, not validated on this platform, so every result is ADVISORY and
//  names the active dither test as the confirming step.  OBD-II's low PID rate is
//  the hard limit here — the Nyquist frequency fs/2 caps what can be resolved, so
//  the advisory always states the sample rate and its Nyquist ceiling.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using TesterPresent.OBD2.Intelligence;

namespace TesterPresent.OBD2.Intelligence.Tier2
{
    /// <summary>
    /// T4 — Frequency-Response via Commanded Dither.  Estimates the dominant
    /// oscillation frequency, amplitude and damping of the most oscillatory
    /// captured signal among {RPM, TPS, MAP, LTFT B1, O2 B1S1}, interprets a
    /// coherent oscillation as a control-loop / actuator-dynamics fault (or a slow
    /// O2 switch as a lazy sensor), and recommends the host-side sinusoidal-dither
    /// frequency-response test as the confirming action.  Pure: reads the snapshot
    /// + context only, emits at most one hypothesis, empty when nothing oscillates.
    /// </summary>
    public sealed class FrequencyResponseModule : DiagnosticModuleBase
    {
        // Candidate probe frequencies for the correlation bank (Hz). Only those
        // strictly below Nyquist (fs/2) are ever tested — above it a rate cannot be
        // resolved and claiming one would be aliasing noise into a false diagnosis.
        private static readonly double[] BANK_FREQS_HZ = { 0.5, 1.0, 2.0, 5.0, 10.0 };

        // A signal must show at least this fraction of its variance in a single
        // sinusoid before we treat it as a genuine oscillation rather than noise.
        private const double COHERENCE_FLOOR = 0.15;

        // Zero-crossing hysteresis as a fraction of the detrended std-dev: a
        // crossing only registers once the signal swings past ±(this·σ), so noise
        // jitter around the mean cannot fabricate crossings.
        private const double HYSTERESIS_FRAC = 0.30;

        // Peak-detection floor (fraction of σ) for the log-decrement damping fit.
        private const double PEAK_FLOOR_FRAC = 0.30;

        // Minimum samples the internal spectral estimate needs (mirrors Requirements).
        private const int MIN_ANALYSIS_SAMPLES = 32;

        // A "slow" O2 switch can only be trusted when the capture out-samples a HEALTHY
        // (~1 Hz) switch: below this rate the Nyquist limit can alias a fast switch down to
        // a slow-looking one, so a lazy-sensor call in that regime is not supportable.
        private const double O2_MIN_RESOLVE_FS = 4.0;

        private DiagnosticRequirements _requirements;

        /// <inheritdoc/>
        public override string ModuleId => "T4";

        /// <inheritdoc/>
        public override string DisplayName => "Frequency-Response via Commanded Dither";

        /// <inheritdoc/>
        public override DiagnosticTier Tier => DiagnosticTier.Tier2;

        /// <inheritdoc/>
        public override DiagnosticRequirements Requirements =>
            _requirements ?? (_requirements = new DiagnosticRequirements
            {
                // No hard required signal — the module picks whichever of its
                // candidate signals is present and most oscillatory.
                RequiredSignals = new List<string>(),
                MinSamples = MIN_ANALYSIS_SAMPLES,
                MayRecommendActiveControl = true,   // the confirming dither commands the ECU
            });

        /// <summary>
        /// Analyse each present candidate signal for a coherent oscillation, rank by
        /// how oscillatory it is, and emit the first ranked candidate whose motion
        /// meets its fault criterion (sustained out-of-band oscillation for a signal
        /// that should be steady; a slow switch for the O2 sensor).
        /// </summary>
        protected override IReadOnlyList<DiagnosticResult> AnalyzeCore(
            DiagnosticSnapshot snapshot, DiagnosticContext context)
        {
            bool usedUnvalidated = false;

            // ── Spec-seeded interpretation constants (unvalidated until characterised) ──
            double o2MinSwitchHz = Cal(context, "T4.O2MinSwitchHz",   0.5,  ref usedUnvalidated); // lazy-O2 rate floor
            double dampSustained = Cal(context, "T4.DampingSustainedZeta", 0.15, ref usedUnvalidated); // ζ below ⇒ persistent

            // The candidate menu: which signals we know how to read dynamically, the
            // healthy amplitude band for each, and whether it is meant to be steady
            // or is a switching sensor.  Bands are spec-seeded (advisory).
            var specs = new List<CandidateSpec>
            {
                new CandidateSpec(CanonicalSignals.Rpm,  "engine idle speed",      "rpm",
                    Cal(context, "T4.RpmOscBandRpm",  50.0, ref usedUnvalidated), OscKind.SteadyExpected,  DiagnosticSeverity.Medium),
                new CandidateSpec(CanonicalSignals.ThrottlePos, "throttle position","%",
                    Cal(context, "T4.TpsOscBandPct",   3.0, ref usedUnvalidated), OscKind.SteadyExpected,  DiagnosticSeverity.Low),
                new CandidateSpec(CanonicalSignals.Map,  "manifold pressure",      "kPa",
                    Cal(context, "T4.MapOscBandKpa",   5.0, ref usedUnvalidated), OscKind.SteadyExpected,  DiagnosticSeverity.Low),
                new CandidateSpec(CanonicalSignals.LtftB1, "long-term fuel trim",  "%",
                    Cal(context, "T4.LtftOscBandPct",  5.0, ref usedUnvalidated), OscKind.SteadyExpected,  DiagnosticSeverity.Medium),
                new CandidateSpec(CanonicalSignals.O2B1S1, "upstream O2 sensor",   "V",
                    Cal(context, "T4.O2OscBandVolt",   0.1, ref usedUnvalidated), OscKind.SwitchingExpected, DiagnosticSeverity.Medium),
            };

            // ── Analyse every present candidate and keep the coherent oscillators ──
            var ranked = new List<Ranked>();
            foreach (var spec in specs)
            {
                SignalSeries s = snapshot.Series(spec.Signal);
                if (s == null || !s.HasData || s.Count < MIN_ANALYSIS_SAMPLES) continue;

                Oscillation osc = AnalyzeOscillation(s);
                if (!osc.Valid || osc.Coherence < COHERENCE_FLOOR) continue;

                // Rank by coherence weighted by how far the amplitude runs over the
                // healthy band — the most flagrant oscillator floats to the top.
                double bandRatio = spec.AmplitudeBand > 1e-9
                    ? SignalMath.Clamp(osc.Amplitude / spec.AmplitudeBand, 0.0, 3.0)
                    : 1.0;
                double score = osc.Coherence * (0.5 + bandRatio);
                ranked.Add(new Ranked { Spec = spec, Osc = osc, Score = score });
            }

            if (ranked.Count == 0) return Array.Empty<DiagnosticResult>();
            ranked.Sort((a, b) => b.Score.CompareTo(a.Score));

            // Advisory posture: Tier-2 bands are spec-seeded unless a validated
            // platform calibration is loaded.
            bool advisory = usedUnvalidated
                            || context == null
                            || context.Calibration == null
                            || !context.Calibration.IsValidated;
            string advisoryBase = advisory
                ? "the healthy oscillation bands and the O2 switch-rate floor are spec-seeded, not validated on this platform"
                : null;

            // ── Emit the first ranked candidate that constitutes a fault ──
            foreach (var cand in ranked)
            {
                DiagnosticResult r = Evaluate(cand.Spec, cand.Osc, o2MinSwitchHz, dampSustained,
                                              advisory, advisoryBase);
                if (r != null) return new List<DiagnosticResult> { r };
            }

            return Array.Empty<DiagnosticResult>();
        }

        // ── Fault interpretation ──────────────────────────────────────────────────

        /// <summary>
        /// Decide whether a candidate's oscillation is a fault and, if so, build the
        /// hypothesis + evidence + confirming dither script.  Returns null when the
        /// motion is within healthy bounds (e.g. an O2 switching normally at ~1 Hz).
        /// </summary>
        private DiagnosticResult Evaluate(CandidateSpec spec, Oscillation osc, double o2MinSwitchHz,
                                          double dampSustained, bool advisory, string advisoryBase)
        {
            bool persistent = osc.Sustained || osc.Zeta < dampSustained;

            if (spec.Kind == OscKind.SwitchingExpected)
            {
                // O2 is MEANT to switch; the fault is a switch that has gone SLOW.
                // A normal-rate switch (≥ floor) is healthy — stay silent.
                if (osc.Freq >= o2MinSwitchHz) return null;
                if (osc.Amplitude < spec.AmplitudeBand) return null; // barely switching ⇒ a different fault (dead sensor), out of scope
                // Aliasing guard: a "slow" reading is only trustworthy if the capture
                // out-samples a healthy ~1 Hz switch. In the un-resolvable regime a fast
                // switch aliases to a slow one, so report nothing rather than a lazy-sensor
                // fault the sample rate cannot support.
                if (osc.Fs < O2_MIN_RESOLVE_FS) return null;
                return BuildO2Result(spec, osc, o2MinSwitchHz, advisory, advisoryBase);
            }

            // Steady-expected signal: a fault needs a real out-of-band amplitude AND
            // for the oscillation to persist (sustained or low-damping) — a quickly-
            // damped transient after a disturbance is normal recovery, not a fault.
            if (osc.Amplitude <= spec.AmplitudeBand) return null;
            if (!persistent) return null;
            return BuildSteadyResult(spec, osc, dampSustained, advisory, advisoryBase);
        }

        /// <summary>Hypothesis for a signal that should be flat but is oscillating
        /// (idle hunting, throttle chatter, an oscillating fuel loop).</summary>
        private DiagnosticResult BuildSteadyResult(CandidateSpec spec, Oscillation osc, double dampSustained,
                                                   bool advisory, string advisoryBase)
        {
            string dampWord = osc.Sustained ? "SUSTAINED (limit cycle, ζ≈0)"
                                            : $"lightly damped (ζ≈{Fmt(osc.Zeta)})";

            var r = NewResult($"Frequency response — {spec.Label} oscillating ({Fmt(osc.Freq)} Hz)");
            r.Hypothesis =
                $"The {spec.Label} should sit flat once settled but is oscillating at {Fmt(osc.Freq)} Hz with an "
                + $"amplitude of ±{Fmt(osc.Amplitude)} {spec.Unit} — {dampWord}. A coherent, {(osc.Sustained ? "non-decaying" : "under-damped")} "
                + "oscillation in a signal that should be steady is the fingerprint of a control loop fighting its own "
                + $"actuator: the loop over- and under-corrects around target ({(spec.Signal == CanonicalSignals.Rpm ? "idle HUNTING" : "instability")}). "
                + "Low damping points at a sluggish/sticky actuator or over-aggressive control gain rather than a static offset.";
            r.Severity = spec.Severity;
            r.Confidence = ConfidenceSteady(osc, spec.AmplitudeBand);
            r.SuspectComponents = SteadySuspects(spec);
            r.NextTest =
                "Run the commanded-dither frequency-response test (see confirmation script) to measure actuator gain/phase — "
                + "command a small sinusoidal dither onto the actuator and watch whether the plant tracks it cleanly or "
                + "resonates/lags, which separates a sticky actuator from an over-tuned control loop.";
            r.NextTestScript = BuildDitherScript(spec, osc);

            double band = spec.AmplitudeBand;
            r.Evidence
                .Info("Frequency-response model", $"a settled {spec.Label} should show no coherent oscillation (amplitude < {Fmt(band)} {spec.Unit})",
                      "Tier-2 dynamic set-point: the signal is expected to hold flat, so any coherent tone is a residual.")
                .Info("Sample rate / Nyquist", $"{Fmt(osc.Fs)} Hz capture ⇒ Nyquist {Fmt(osc.Nyquist)} Hz",
                      "Only oscillations below Nyquist can be resolved; a low OBD PID rate is the hard limit on this estimate.")
                .Info("Dominant frequency", $"{Fmt(osc.Freq)} Hz (via {osc.FreqMethod}; {osc.Crossings} hysteresis zero-crossings)",
                      "Estimated from zero-crossing timing reconciled with a sin/cos correlation bank.")
                .Measure("Oscillation amplitude", osc.Amplitude, 0.0, band, spec.Unit,
                         $"Amplitude exceeds the ±{Fmt(band)} {spec.Unit} healthy band ⇒ a real oscillation, not sensor noise.")
                .Info("Spectral coherence", $"{Fmt(osc.Coherence * 100)} % of variance in the dominant tone",
                      "High coherence means the motion is a clean oscillation, not broadband noise — trustworthy to characterise.")
                .Add("Damping", osc.Sustained ? "sustained (ζ≈0)" : $"ζ≈{Fmt(osc.Zeta)}", $"decays quickly (ζ ≥ {Fmt(dampSustained)})",
                     EvidenceVerdict.Fail,
                     osc.Sustained ? "Peaks are not decaying — a self-sustaining limit cycle, the hallmark of an unstable control loop."
                                   : "Peaks decay only slowly — an under-damped loop that rings after every disturbance.");

            ApplyAdvisory(r, advisory, advisoryBase, osc, needsActive: true);
            return r;
        }

        /// <summary>Hypothesis for an O2 sensor switching too slowly (lazy / aged).</summary>
        private DiagnosticResult BuildO2Result(CandidateSpec spec, Oscillation osc, double o2MinSwitchHz,
                                               bool advisory, string advisoryBase)
        {
            var r = NewResult($"Frequency response — lazy upstream O2 switch ({Fmt(osc.Freq)} Hz)");
            r.Hypothesis =
                $"The upstream O2 sensor is switching at only {Fmt(osc.Freq)} Hz (amplitude ±{Fmt(osc.Amplitude)} V). A healthy "
                + $"closed loop toggles it near ~1 Hz at idle; below ~{Fmt(o2MinSwitchHz)} Hz the sensor's transport/response "
                + "time has stretched — a LAZY (aged/contaminated) O2 sensor. A slow sensor blunts closed-loop fuel control "
                + "and can drag catalyst efficiency and emissions, even while the mean voltage still looks plausible.";
            r.Severity = spec.Severity;
            r.Confidence = ConfidenceO2(osc.Freq, o2MinSwitchHz);
            r.SuspectComponents = new List<string>
            {
                "Upstream O2 (HEGO) sensor — aged / silicone- or lead-contaminated / slow",
                "Sensor heater circuit (cold sensor responds slowly)",
                "Exhaust leak upstream of the sensor diluting the switch",
            };
            r.NextTest =
                "Run the commanded-dither frequency-response test (see confirmation script): force a small commanded "
                + "rich/lean fuel dither and time the sensor's response — a lazy sensor lags the command, a healthy one "
                + "tracks it. Cross-check heater resistance and compare switch rate against a downstream/known-good sensor.";
            r.NextTestScript = BuildDitherScript(spec, osc);

            r.Evidence
                .Info("Frequency-response model", $"a healthy upstream O2 switches near ~1 Hz; lazy below {Fmt(o2MinSwitchHz)} Hz",
                      "The sensor is EXPECTED to oscillate — here the fault is a switch rate that has gone slow, not the presence of motion.")
                .Info("Sample rate / Nyquist", $"{Fmt(osc.Fs)} Hz capture ⇒ Nyquist {Fmt(osc.Nyquist)} Hz",
                      "The capture must out-sample the switch to time it; a low OBD rate can itself alias a fast switch to a slow one — confirm with the active test.")
                .Measure("O2 switch frequency", osc.Freq, o2MinSwitchHz, 5.0, "Hz",
                         $"Switch rate is below the ~{Fmt(o2MinSwitchHz)} Hz floor ⇒ the sensor is responding sluggishly.")
                .Info("Switch amplitude", $"±{Fmt(osc.Amplitude)} V", "The sensor is still swinging (so it is not dead) — just slow.")
                .Info("Spectral coherence", $"{Fmt(osc.Coherence * 100)} % of variance in the switch tone",
                      "Confirms a clean periodic switch rather than noise, so the low frequency is a real rate, not an artefact.");

            ApplyAdvisory(r, advisory, advisoryBase, osc, needsActive: true);
            return r;
        }

        private static List<string> SteadySuspects(CandidateSpec spec)
        {
            if (spec.Signal == CanonicalSignals.Rpm)
                return new List<string>
                {
                    "Idle-air control valve / electronic throttle (sticking, hunting)",
                    "Idle control loop (over-aggressive gain, unstable)",
                    "Vacuum leak modulating with the loop, or a fouling injector cycling fuel",
                };
            if (spec.Signal == CanonicalSignals.ThrottlePos)
                return new List<string>
                {
                    "Electronic throttle body (dirty bore, worn motor/return spring)",
                    "Throttle position control loop (unstable gain)",
                    "APP/TPS sensor noise feeding the loop",
                };
            if (spec.Signal == CanonicalSignals.Map)
                return new List<string>
                {
                    "Idle-air / throttle instability driving manifold pressure",
                    "Vacuum leak or PCV modulating manifold pressure",
                    "MAP sensor / reference line resonance",
                };
            // LTFT
            return new List<string>
            {
                "Closed-loop fuel control oscillating (loop gain / O2 dynamics)",
                "Intermittent vacuum leak or injector the loop chases",
                "Fuel-pressure regulator hunting",
            };
        }

        // ── Confirmation script (active sinusoidal dither) ────────────────────────

        /// <summary>
        /// The recommended next test as a declarative, safety-gated sequence: read a
        /// baseline, command a small SINUSOIDAL DITHER onto the actuator via 0x2F
        /// IOControl, observe the plant's response, then hand control back to the
        /// ECU.  The host runs it through UDSManager + the active-control gate; the
        /// module never touches hardware.  The IOControl DID is platform-specific
        /// and MUST be resolved from the platform's IOControl map before running.
        /// </summary>
        private static ConfirmationScript BuildDitherScript(CandidateSpec spec, Oscillation osc)
        {
            return new ConfirmationScript
            {
                Name = $"Commanded-dither frequency response ({spec.Label})",
                Rationale =
                    $"The {spec.Label} shows a coherent {Fmt(osc.Freq)} Hz oscillation (±{Fmt(osc.Amplitude)} {spec.Unit}). "
                    + "Command a known sinusoidal dither and measure the response amplitude/phase to recover actuator "
                    + "gain and lag, separating a sticky/lazy actuator from an over-tuned control loop.",
                Steps =
                {
                    new ConfirmationStep
                    {
                        Description = $"Read the {spec.Label} DID (0x22) as the pre-dither baseline.",
                        ServiceId = 0x22,
                        Payload = null,   // DID is platform-specific; host resolves it from the platform PID/DID map
                        ExpectedObservation = $"Baseline {spec.Label} settled near its mean before any command is applied.",
                        IsActiveControl = false,
                    },
                    new ConfirmationStep
                    {
                        // 0x2F IOControl, shortTermAdjustment (0x03). Payload is a PLACEHOLDER:
                        // [DID_hi, DID_lo, controlOption(0x03=shortTermAdjustment), state...] — the
                        // actual DID and the sinusoid encoding are platform-specific and must be
                        // filled from the platform IOControl map. Commands the ECU ⇒ safety-gated.
                        Description = "Command a small sinusoidal dither onto the actuator via 0x2F IOControl "
                                      + "(sweep ~0.5–5 Hz, amplitude a few % of range). Payload below is a placeholder "
                                      + "— the DID and sinusoid encoding are platform-specific.",
                        ServiceId = 0x2F,
                        // bug-audit: ConfirmationRunner treats Payload[0] as the SID (it derives the SID
                        // from Payload[0] for the RCM safety guard and sends Payload verbatim). The 0x2F
                        // service byte MUST lead the payload — omitting it made the guard see SID 0x00
                        // (not dangerous → RCM block bypassed) and sent a malformed service-0x00 frame.
                        Payload = new byte[] { 0x2F, 0x00, 0x00, 0x03, 0x00 }, // [2F, DID_hi, DID_lo, shortTermAdjustment, state] — PLACEHOLDER DID
                        ExpectedObservation = "A healthy plant tracks the dither cleanly (gain ≈ commanded, small phase lag). "
                                              + "A sticky/lazy actuator lags or clips it; an over-tuned loop resonates and overshoots.",
                        IsActiveControl = true,
                        RequiresPowertrainTarget = true, // dithers an engine actuator (throttle/EGR/idle) — powertrain only
                    },
                    new ConfirmationStep
                    {
                        Description = $"While dithering, log the {spec.Label} (0x22) and compare its amplitude/phase to the command.",
                        ServiceId = 0x22,
                        Payload = null,
                        ExpectedObservation = "Response amplitude ÷ command amplitude = plant gain; time shift = phase lag. "
                                              + "Compare against the platform's known-good gain/phase.",
                        IsActiveControl = false,
                    },
                    new ConfirmationStep
                    {
                        // 0x2F sub-function returnControlToEcu (0x00) — always hand the actuator back.
                        Description = "Return control of the actuator to the ECU (0x2F returnControlToEcu).",
                        ServiceId = 0x2F,
                        // bug-audit: lead with the 0x2F SID (see note on the dither step above).
                        Payload = new byte[] { 0x2F, 0x00, 0x00, 0x00 }, // [2F, DID_hi, DID_lo, returnControlToEcu] — PLACEHOLDER DID
                        ExpectedObservation = "Actuator returns to normal ECU control; the signal settles back to baseline.",
                        IsActiveControl = true,
                        RequiresPowertrainTarget = true, // returns an engine actuator to ECU control — powertrain only
                    },
                },
            };
        }

        // ── Spectral estimate ─────────────────────────────────────────────────────

        /// <summary>
        /// Estimate the dominant oscillation of a series: detrend by the mean, find
        /// the dominant frequency by reconciling a hysteresis zero-crossing rate with
        /// a below-Nyquist correlation bank, recover the amplitude by projection at
        /// that frequency, and estimate damping by log-decrement over peaks.  Uses
        /// real timestamps so OBD jitter does not bias the frequency.
        /// </summary>
        private static Oscillation AnalyzeOscillation(SignalSeries s)
        {
            var samples = s.Samples;
            int n = samples.Count;
            if (n < MIN_ANALYSIS_SAMPLES) return Oscillation.Invalid;

            // Time base relative to the first sample (seconds).
            var t = new double[n];
            var x = new double[n];
            DateTime t0 = samples[0].Utc;
            for (int i = 0; i < n; i++) { t[i] = (samples[i].Utc - t0).TotalSeconds; x[i] = samples[i].Value; }

            double duration = t[n - 1];
            if (duration <= 1e-6) return Oscillation.Invalid;
            double fs = (n - 1) / duration;
            double nyquist = fs / 2.0;

            // Detrend (subtract mean) and measure variance.
            double mean = 0; for (int i = 0; i < n; i++) mean += x[i]; mean /= n;
            var d = new double[n];
            double variance = 0;
            for (int i = 0; i < n; i++) { d[i] = x[i] - mean; variance += d[i] * d[i]; }
            variance /= n;
            if (variance < 1e-12) return Oscillation.Invalid;   // dead-flat signal, no oscillation
            double sigma = Math.Sqrt(variance);

            // Zero-crossing frequency with amplitude hysteresis (noise rejection).
            double h = HYSTERESIS_FRAC * sigma;
            int state = 0;                 // -1 below -h, +1 above +h, 0 undecided
            int crossings = 0;
            double firstCrossT = double.NaN, lastCrossT = double.NaN;
            for (int i = 0; i < n; i++)
            {
                if (d[i] > h)
                {
                    if (state == -1) { crossings++; if (double.IsNaN(firstCrossT)) firstCrossT = t[i]; lastCrossT = t[i]; }
                    state = 1;
                }
                else if (d[i] < -h)
                {
                    if (state == 1) { crossings++; if (double.IsNaN(firstCrossT)) firstCrossT = t[i]; lastCrossT = t[i]; }
                    state = -1;
                }
            }
            double fZero = double.NaN;
            if (crossings >= 2 && lastCrossT > firstCrossT)
                fZero = (crossings - 1) / (2.0 * (lastCrossT - firstCrossT)); // half-cycles ⇒ frequency

            // Build the candidate frequency set: the zero-crossing rate (if in range)
            // plus each bank frequency below Nyquist. Pick the one whose sin/cos
            // projection captures the most variance.
            var testFreqs = new List<double>();
            if (!double.IsNaN(fZero) && fZero > 0 && fZero < nyquist) testFreqs.Add(fZero);
            foreach (double f in BANK_FREQS_HZ) if (f < nyquist) testFreqs.Add(f);
            if (testFreqs.Count == 0) return Oscillation.Invalid;  // nothing resolvable below Nyquist

            double bestFreq = 0, bestAmp = 0;
            bool bestFromZero = false;
            foreach (double f in testFreqs)
            {
                // Least-squares single-tone fit: d ≈ A·cos(wt) + B·sin(wt).  Solving the
                // 2×2 normal equations is UNBIASED for the non-uniform, non-integer-cycle
                // OBD sampling here — unlike the fixed 2/N DFT scaling, which is only
                // unbiased for uniform sampling over whole cycles and otherwise skews the
                // amplitude that gates the fault.
                double sc = 0, ss = 0, scc = 0, sss = 0, scs = 0;
                double w = 2.0 * Math.PI * f;
                for (int i = 0; i < n; i++)
                {
                    double cosw = Math.Cos(w * t[i]);
                    double sinw = Math.Sin(w * t[i]);
                    sc += d[i] * cosw; ss += d[i] * sinw;
                    scc += cosw * cosw; sss += sinw * sinw; scs += cosw * sinw;
                }
                double det = scc * sss - scs * scs;
                double amp;
                if (Math.Abs(det) > 1e-9)
                {
                    double A = (sc * sss - ss * scs) / det;
                    double B = (ss * scc - sc * scs) / det;
                    amp = Math.Sqrt(A * A + B * B);
                }
                else
                {
                    // Degenerate design (e.g. too few distinct phases) — fall back to 2/N.
                    double a = 2.0 / n * sc, b = 2.0 / n * ss;
                    amp = Math.Sqrt(a * a + b * b);
                }
                if (amp > bestAmp)
                {
                    bestAmp = amp; bestFreq = f;
                    bestFromZero = (!double.IsNaN(fZero) && Math.Abs(f - fZero) < 1e-9);
                }
            }

            double coherence = SignalMath.Clamp((bestAmp * bestAmp / 2.0) / variance, 0.0, 1.0);

            // Damping via log-decrement over positive peaks of the detrended signal.
            double peakFloor = PEAK_FLOOR_FRAC * sigma;
            var peaks = new List<double>();
            for (int i = 1; i < n - 1; i++)
                if (d[i] > peakFloor && d[i] >= d[i - 1] && d[i] > d[i + 1]) peaks.Add(d[i]);

            // We can only ASSERT a sustained limit cycle with enough peaks to measure
            // decay. With fewer than 3 peaks the oscillation is too short-lived to be a
            // persistent fault, so default to "damped / insufficient evidence" (zeta
            // high, NOT sustained) rather than fail-toward-fault — a genuine limit
            // cycle over the window produces many peaks. Defaulting sustained=true here
            // false-fired an "idle hunting / sustained limit cycle" on healthy damped
            // transients (a throttle-blip recovery yields only 1–2 peaks).
            bool sustained = false;
            double zeta = 1.0;   // treat as well-damped until proven a limit cycle
            if (peaks.Count >= 3)
            {
                double sumLn = 0; int cnt = 0;
                for (int k = 0; k < peaks.Count - 1; k++)
                    if (peaks[k] > 0 && peaks[k + 1] > 0) { sumLn += Math.Log(peaks[k] / peaks[k + 1]); cnt++; }
                double deltaPerPeriod = cnt > 0 ? sumLn / cnt : 0;   // mean log-decrement per period
                if (deltaPerPeriod > 0.05)                          // net, consistent decay ⇒ damped
                {
                    zeta = deltaPerPeriod / Math.Sqrt(4.0 * Math.PI * Math.PI + deltaPerPeriod * deltaPerPeriod);
                    sustained = false;
                }
                else                                                // ≥3 peaks, no consistent decay ⇒ genuine limit cycle
                {
                    zeta = 0;
                    sustained = true;
                }
            }

            return new Oscillation
            {
                Valid = true,
                N = n,
                Fs = fs,
                Nyquist = nyquist,
                Freq = bestFreq,
                Amplitude = bestAmp,
                Coherence = coherence,
                Zeta = zeta,
                Sustained = sustained,
                Crossings = crossings,
                FreqMethod = bestFromZero ? "zero-crossing" : "correlation bank",
            };
        }

        // ── Confidence ────────────────────────────────────────────────────────────

        /// <summary>Confidence for a steady-signal oscillation: rises with how far the
        /// amplitude runs over band and with spectral coherence; capped (Tier-2 stays
        /// advisory pending the active dither test).</summary>
        private static double ConfidenceSteady(Oscillation osc, double band)
        {
            double over = band > 1e-9 ? SignalMath.Clamp((osc.Amplitude - band) / band, 0.0, 1.0) : 0.5;
            double coh = SignalMath.Clamp(osc.Coherence, 0.0, 1.0);
            double c = 0.35 + 0.20 * over + 0.15 * coh;
            if (osc.Sustained) c += 0.05;   // a sustained limit cycle is a stronger tell than a decaying ring
            return SignalMath.Clamp(c, 0.0, 0.70);
        }

        /// <summary>Confidence for a lazy-O2 finding: rises as the switch rate falls
        /// further below the floor; capped for Tier-2 advisory.</summary>
        private static double ConfidenceO2(double freq, double floorHz)
        {
            double over = floorHz > 1e-9 ? SignalMath.Clamp((floorHz - freq) / floorHz, 0.0, 1.0) : 0.5;
            return SignalMath.Clamp(0.35 + 0.30 * over, 0.0, 0.70);
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

        /// <summary>Stamp the advisory flag + reason, always noting the Nyquist/rate
        /// limit and that an active dither test is needed to confirm.</summary>
        private static void ApplyAdvisory(DiagnosticResult r, bool advisory, string advisoryBase,
                                          Oscillation osc, bool needsActive)
        {
            var parts = new List<string>();
            if (advisory && advisoryBase != null) parts.Add(advisoryBase);
            // OBD-II PID rate is the hard resolution limit — always state it.
            parts.Add($"frequency resolution is bounded by the {Fmt(osc.Fs)} Hz capture rate (Nyquist {Fmt(osc.Nyquist)} Hz)");
            if (needsActive) parts.Add("this is a passive estimate — run the commanded-dither frequency-response test to confirm actuator gain/phase");

            r.Advisory = true;
            r.AdvisoryReason = string.Join("; ", parts);
        }

        /// <summary>Format a possibly-NaN value compactly and culture-invariantly.</summary>
        private static string Fmt(double v)
        {
            if (double.IsNaN(v) || double.IsInfinity(v)) return "n/a";
            return v.ToString("0.##", CultureInfo.InvariantCulture);
        }

        // ── Local model types ─────────────────────────────────────────────────────

        /// <summary>Whether a candidate signal is meant to be steady, or is a sensor
        /// that is meant to switch (so the fault is a SLOW switch, not any motion).</summary>
        private enum OscKind { SteadyExpected, SwitchingExpected }

        /// <summary>One analysable candidate signal + its healthy band and posture.</summary>
        private sealed class CandidateSpec
        {
            public readonly string Signal;
            public readonly string Label;
            public readonly string Unit;
            public readonly double AmplitudeBand;   // healthy oscillation amplitude band (signal units)
            public readonly OscKind Kind;
            public readonly DiagnosticSeverity Severity;

            public CandidateSpec(string signal, string label, string unit, double band,
                                 OscKind kind, DiagnosticSeverity severity)
            {
                Signal = signal; Label = label; Unit = unit;
                AmplitudeBand = band; Kind = kind; Severity = severity;
            }
        }

        /// <summary>A candidate ranked by how oscillatory it is.</summary>
        private struct Ranked
        {
            public CandidateSpec Spec;
            public Oscillation Osc;
            public double Score;
        }

        /// <summary>The result of the lightweight spectral estimate for one signal.</summary>
        private struct Oscillation
        {
            public bool Valid;
            public int N;
            public double Fs;          // sample rate (Hz)
            public double Nyquist;     // fs/2 (Hz)
            public double Freq;        // dominant oscillation frequency (Hz)
            public double Amplitude;   // sinusoid amplitude at Freq (signal units)
            public double Coherence;   // fraction of variance in the dominant tone [0,1]
            public double Zeta;        // damping ratio from log-decrement (0 = sustained)
            public bool Sustained;     // true if peaks are not decaying (limit cycle)
            public int Crossings;      // hysteresis zero-crossings counted
            public string FreqMethod;  // which estimator won the dominant frequency

            public static readonly Oscillation Invalid = new Oscillation { Valid = false };
        }
    }
}
