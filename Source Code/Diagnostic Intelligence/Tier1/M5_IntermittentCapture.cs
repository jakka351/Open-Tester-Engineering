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
//  Tester Present Specialist Automotive Solutions — M5 Intermittent Event Capture (Tier-1)
//
//  A summary statistic hides the very faults a technician chases hardest: the
//  sensor that drops out for one sample, the spike that flickers and reverts,
//  the PID that freezes on a cached value.  Mean/StdDev smear all three into
//  "roughly fine".  M5 post-analyses a finished capture and INVERTS each glitch
//  back into a ranked fault hypothesis with its pre-event context — the moment
//  it happened and the values on either side — plus the single discriminating
//  next test (a live wiggle-test while monitoring).
//
//  Three event families, each with correct physics/statistics:
//
//    • DROPOUT   — a short run (1..k samples) that falls to near-zero and then
//                  RECOVERS to a clearly non-zero baseline on both sides.  The
//                  two-sided recovery requirement is what separates an
//                  intermittent open/short (spike-to-zero-and-back) from a
//                  legitimate sustained zero (engine off ⇒ RPM/VSS = 0, which
//                  never recovers within a few samples).
//
//    • SPIKE     — a single-sample step whose jump exceeds max(σ·robustStd,
//                  physically-implausible-delta) AND immediately reverts to the
//                  pre-spike level.  robustStd is a MAD estimate of the
//                  first-difference so the spike itself does not inflate the
//                  threshold that is supposed to catch it.
//
//    • FLATLINE  — a >=N-sample window with ~zero range on a signal that SHOULD
//                  move (RPM/MAF/O2/TPS/Load), witnessed by ANOTHER should-vary
//                  signal genuinely varying at the same time.  The witness is
//                  what stops a legitimately-steady idle from reading as "stuck".
//
//  HONESTY: at OBD PID rates a one-sample event is near the Nyquist floor — a
//  low sample rate is flagged because a glitch may be aliasing.  Thresholds are
//  spec-seeded, so every result is advisory until characterised on-platform.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using TesterPresent.OBD2.Intelligence;

namespace TesterPresent.OBD2.Intelligence.Tier1
{
    /// <summary>
    /// Tier-1 signal-inversion module: characterises intermittent glitches
    /// (dropouts, transient spikes, stuck/flatlined signals) that a summary stat
    /// hides, and reports each with its pre-event context and the most
    /// discriminating next test.  Pure — reads the snapshot only, never touches
    /// hardware, never throws.
    /// </summary>
    public sealed class IntermittentCaptureModule : DiagnosticModuleBase
    {
        private DiagnosticRequirements _requirements;

        /// <summary>Minimum samples on a series before it is worth analysing.</summary>
        private const int MinSeriesSamples = 30;

        /// <summary>Signals that are expected to move while the vehicle is active;
        /// only these can be judged "stuck", and one of them varying is the
        /// witness that proves the vehicle was active during a flatline.</summary>
        private static readonly HashSet<string> ShouldVary = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            CanonicalSignals.Rpm, CanonicalSignals.Maf, CanonicalSignals.O2B1S1, CanonicalSignals.O2B2S1,
            CanonicalSignals.ThrottlePos, CanonicalSignals.EngineLoad, CanonicalSignals.AbsoluteLoad,
        };

        // A flat O2 while the engine runs closed-loop is genuinely stuck regardless of the
        // operating point (O2 MUST oscillate). But RPM/TPS/Load/MAF legitimately hold CONSTANT at a
        // steady operating point (dead-steady idle) — they are only "stuck" if the operating point
        // moved and they failed to follow. So the two classes take different flatline witnesses.
        private static readonly HashSet<string> AlwaysOscillate = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            CanonicalSignals.O2B1S1, CanonicalSignals.O2B2S1,
        };
        private static readonly HashSet<string> OperatingPoint = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            CanonicalSignals.Rpm, CanonicalSignals.Maf, CanonicalSignals.ThrottlePos,
            CanonicalSignals.EngineLoad, CanonicalSignals.AbsoluteLoad,
        };

        /// <inheritdoc/>
        public override string ModuleId => "M5";

        /// <inheritdoc/>
        public override string DisplayName => "Intermittent Event Capture";

        /// <inheritdoc/>
        public override DiagnosticTier Tier => DiagnosticTier.Tier1;

        /// <inheritdoc/>
        public override DiagnosticRequirements Requirements =>
            _requirements ?? (_requirements = new DiagnosticRequirements
            {
                // No specific signal is required; the module self-selects any
                // series with enough samples.  MinSamples stays 0 so the host
                // never skips us for want of one named signal.
                RequiredSignals = new List<string>(),
                MinSamples = 0,
                MinSampleRateHz = 0,
            });

        // ── one internal event record ────────────────────────────────────────
        private enum EventKind { Dropout, Spike, Flatline }

        /// <summary>A single detected intermittent event with the context needed
        /// to render it as a hypothesis and to rank it against the others.</summary>
        private sealed class GlitchEvent
        {
            public EventKind Kind;
            public string Signal;
            public string Unit;
            public DateTime Utc;
            public double PreValue;   // baseline just before the event
            public double AtValue;    // value AT the event (min in a dropout, the spike peak, the stuck level)
            public double PostValue;  // baseline just after the event
            public double Magnitude;  // clarity in [0,1] — ranks events across kinds
            public double Confidence; // final calibrated confidence
            public int SampleCount;   // samples in the parent series
            public double EstHz;      // parent series sample rate
            public bool LowRate;
            // kind-specific detail
            public int RunLen;        // dropout / flatline length in samples
            public double DepthFrac;  // dropout depth as a fraction of baseline
            public double Jump;       // spike step magnitude (signed)
            public double Threshold;  // spike detection threshold used
            public double SigmaMult;  // the (calibratable) robust-sigma multiplier used for the spike gate
        }

        /// <inheritdoc/>
        protected override IReadOnlyList<DiagnosticResult> AnalyzeCore(
            DiagnosticSnapshot snapshot, DiagnosticContext context)
        {
            var results = new List<DiagnosticResult>();
            if (snapshot == null || snapshot.Signals == null || snapshot.Signals.Count == 0)
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

            double dropoutFrac    = ReadCal("M5.DropoutFrac", 0.15);        // "near-zero" = <= frac * baseline
            double recoverFrac    = ReadCal("M5.DropoutRecoverFrac", 0.50); // both sides must reach >= frac * baseline
            int    maxDropoutRun  = (int)ReadCal("M5.MaxDropoutRunSamples", 5);
            double minBaselineEps = ReadCal("M5.MinBaselineEps", 1e-3);     // below this a signal is "genuinely near zero"
            double spikeSigma     = ReadCal("M5.SpikeSigma", 6.0);
            int    flatMinSamples = (int)ReadCal("M5.FlatMinSamples", 20);
            double activityCoV    = ReadCal("M5.ActivityCoV", 0.02);        // a witness signal must vary by >= this CoV
            double lowRateFloorHz = ReadCal("M5.LowRateFloorHz", 5.0);
            int    maxEvents      = (int)ReadCal("M5.MaxEvents", 5);

            if (maxDropoutRun < 1) maxDropoutRun = 1;
            if (flatMinSamples < 2) flatMinSamples = 2;
            if (maxEvents < 1) maxEvents = 1;

            // A NullCalibration / uncalibrated platform is always advisory.
            if (context == null || cal == null || !context.IsCalibrated)
                usedUnvalidated = true;

            var events = new List<GlitchEvent>();

            foreach (var kv in snapshot.Signals)
            {
                var series = kv.Value;
                if (series == null || series.Count < MinSeriesSamples) continue;

                var values = series.Values();
                var samples = series.Samples;
                if (values == null || samples == null || values.Count < MinSeriesSamples) continue;

                bool lowRate = series.EstimatedHz > 0 && series.EstimatedHz < lowRateFloorHz;

                // Dropout indices are consumed so the same near-zero blip is not
                // ALSO reported as a downward-then-up spike.
                var consumed = new HashSet<int>();

                DetectDropouts(series, values, samples, dropoutFrac, recoverFrac,
                               maxDropoutRun, minBaselineEps, lowRate, events, consumed);

                DetectSpikes(series, values, samples, spikeSigma, lowRate, events, consumed);

                // Flatline witness (see AlwaysOscillate/OperatingPoint): an O2 is stuck if flat
                // while the engine runs; an operating-point signal is stuck only if ANOTHER
                // operating-point signal actually swept (proving the operating point moved) — O2's
                // perpetual closed-loop oscillation is NOT evidence the operating point moved, so it
                // must not license a "stuck TPS/RPM/Load" verdict on a legitimately-steady idle.
                if (ShouldVary.Contains(series.Name)
                    && FlatlineWitnessMet(snapshot, series.Name, activityCoV))
                    DetectFlatline(series, values, samples, flatMinSamples, lowRate, events);
            }

            if (events.Count == 0)
                return results;

            // ── Rank by clarity, cap the flood, emit ─────────────────────────
            events.Sort((a, b) => b.Magnitude.CompareTo(a.Magnitude));
            int emit = Math.Min(maxEvents, events.Count);
            int suppressed = events.Count - emit;

            for (int i = 0; i < emit; i++)
            {
                var result = BuildResult(events[i], usedUnvalidated);
                // Record the truncation once, on the top-ranked result, so a
                // technician knows the report is not exhaustive.
                if (i == 0 && suppressed > 0)
                    result.Evidence.Info("Events suppressed",
                        suppressed.ToString(CultureInfo.InvariantCulture),
                        $"{suppressed} lower-magnitude intermittent event(s) were detected but not " +
                        $"reported to avoid a noise flood; the {emit} clearest are shown.");
                results.Add(result);
            }

            return results;
        }

        // ── Detectors ────────────────────────────────────────────────────────

        /// <summary>
        /// A dropout is a short run (1..k samples) at near-zero, bounded on BOTH
        /// sides by a clearly non-zero baseline.  Two-sided recovery is the guard
        /// that keeps a legitimate sustained zero (engine off) from being flagged.
        /// </summary>
        private static void DetectDropouts(
            SignalSeries series, IReadOnlyList<double> values, IReadOnlyList<TimedValue> samples,
            double dropoutFrac, double recoverFrac, int maxDropoutRun, double minBaselineEps,
            bool lowRate, List<GlitchEvent> events, HashSet<int> consumed)
        {
            double baseline = SignalMath.Median(values);
            // Only meaningful for a signal whose normal level is clearly above
            // zero; a signal that legitimately sits at/near zero is skipped.
            if (baseline <= minBaselineEps) return;

            double dropThresh = baseline * dropoutFrac;
            double recoverThresh = baseline * recoverFrac;
            int n = values.Count;

            int i = 1; // start at 1 so a preceding baseline sample exists
            while (i < n)
            {
                // Run must START from a baseline sample dropping into near-zero.
                if (values[i] <= dropThresh && values[i - 1] >= recoverThresh)
                {
                    int j = i;
                    while (j + 1 < n && values[j + 1] <= dropThresh) j++;
                    int runLen = j - i + 1;
                    int post = j + 1;

                    if (runLen <= maxDropoutRun && post < n && values[post] >= recoverThresh)
                    {
                        // Deepest point of the run characterises the dropout.
                        int minIdx = i; double minVal = values[i];
                        for (int k = i; k <= j; k++) if (values[k] < minVal) { minVal = values[k]; minIdx = k; }

                        double depthFrac = SignalMath.Clamp((baseline - minVal) / baseline, 0.0, 1.0);

                        // Clarity: a full, clean fall to zero with a short run is
                        // the clearest; shallow or long runs are less certain.
                        double runPenalty = 1.0 - (double)(runLen - 1) / Math.Max(1, maxDropoutRun);
                        double magnitude = SignalMath.Clamp(depthFrac * (0.6 + 0.4 * runPenalty), 0.0, 1.0);

                        events.Add(new GlitchEvent
                        {
                            Kind = EventKind.Dropout,
                            Signal = series.Name,
                            Unit = series.Unit,
                            Utc = samples[minIdx].Utc,
                            PreValue = values[i - 1],
                            AtValue = minVal,
                            PostValue = values[post],
                            RunLen = runLen,
                            DepthFrac = depthFrac,
                            SampleCount = n,
                            EstHz = series.EstimatedHz,
                            LowRate = lowRate,
                            Magnitude = magnitude,
                            Confidence = SignalMath.Clamp(0.50 + 0.35 * depthFrac - (lowRate ? 0.15 : 0.0), 0.0, 0.92),
                        });

                        for (int k = i; k <= j; k++) consumed.Add(k);
                    }

                    i = j + 1; // resume after the run either way
                }
                else i++;
            }
        }

        /// <summary>
        /// A transient spike is a single-sample step whose jump exceeds
        /// max(σ·robustStd, implausibleDelta) and which immediately reverts to the
        /// pre-spike level.  robustStd is a MAD estimate of the first-difference,
        /// so the spike does not inflate the very threshold meant to catch it.
        /// </summary>
        private static void DetectSpikes(
            SignalSeries series, IReadOnlyList<double> values, IReadOnlyList<TimedValue> samples,
            double spikeSigma, bool lowRate, List<GlitchEvent> events, HashSet<int> consumed)
        {
            int n = values.Count;
            if (n < 3) return;

            // First differences and a robust (MAD-based) scale of them.
            var diffs = new double[n - 1];
            for (int k = 0; k < n - 1; k++) diffs[k] = values[k + 1] - values[k];
            double medDiff = SignalMath.Median(diffs);
            var absDev = new double[diffs.Length];
            for (int k = 0; k < diffs.Length; k++) absDev[k] = Math.Abs(diffs[k] - medDiff);
            double robustStd = 1.4826 * SignalMath.Median(absDev);

            double physFloor = ImplausibleDelta(series, values);
            double thr = Math.Max(spikeSigma * robustStd, physFloor);
            if (thr <= 0) return; // nothing to compare against ⇒ no defensible spike

            for (int k = 1; k < n - 1; k++)
            {
                if (consumed.Contains(k)) continue;

                double a = values[k - 1], b = values[k], c = values[k + 1];
                double jump = b - a;      // into the spike
                double revert = c - b;    // back out of the spike

                if (Math.Abs(jump) <= thr) continue;             // step too small
                if (Math.Sign(revert) == Math.Sign(jump)) continue; // must reverse, not continue
                if (Math.Abs(revert) <= thr) continue;           // reversal must be comparably large
                if (Math.Abs(a - c) > 0.5 * Math.Abs(jump)) continue; // must return near the pre-spike level

                double ratio = Math.Abs(jump) / thr;                 // how many thresholds over
                double revertError = Math.Abs(a - c) / Math.Abs(jump); // 0 = perfect return
                double magnitude = SignalMath.Clamp((1.0 - 1.0 / ratio) * (1.0 - revertError), 0.0, 1.0);

                events.Add(new GlitchEvent
                {
                    Kind = EventKind.Spike,
                    Signal = series.Name,
                    Unit = series.Unit,
                    Utc = samples[k].Utc,
                    PreValue = a,
                    AtValue = b,
                    PostValue = c,
                    Jump = jump,
                    Threshold = thr,
                    SigmaMult = spikeSigma,
                    SampleCount = n,
                    EstHz = series.EstimatedHz,
                    LowRate = lowRate,
                    Magnitude = magnitude,
                    Confidence = SignalMath.Clamp(0.30 + 0.35 * magnitude - (lowRate ? 0.10 : 0.0), 0.0, 0.80),
                });
            }
        }

        /// <summary>
        /// A flatline is the longest run whose range stays within a tiny epsilon
        /// for >= N samples on a should-vary signal.  Only reached when a witness
        /// signal proves the vehicle was active, so a steady idle is not misread.
        /// </summary>
        private static void DetectFlatline(
            SignalSeries series, IReadOnlyList<double> values, IReadOnlyList<TimedValue> samples,
            int flatMinSamples, bool lowRate, List<GlitchEvent> events)
        {
            int n = values.Count;
            double eps = StuckEpsilon(series, values);

            int bestStart = -1, bestLen = 0;
            int s = 0; double rmin = values[0], rmax = values[0];
            for (int i = 1; i < n; i++)
            {
                double nmin = Math.Min(rmin, values[i]);
                double nmax = Math.Max(rmax, values[i]);
                if (nmax - nmin <= eps) { rmin = nmin; rmax = nmax; }
                else
                {
                    int len = i - s;
                    if (len > bestLen) { bestLen = len; bestStart = s; }
                    s = i; rmin = rmax = values[i];
                }
            }
            int tail = n - s;
            if (tail > bestLen) { bestLen = tail; bestStart = s; }

            if (bestLen < flatMinSamples || bestStart < 0) return;

            // "Stuck" vs "never exercised" is decided by the ACTIVITY WITNESS (a
            // separate should-vary signal moving), checked before this detector is
            // called — NOT by this signal's own range.  A signal pinned across the
            // whole capture while the vehicle is active is exactly the stuck case.
            int endIdx = bestStart + bestLen - 1;
            double level = values[bestStart];

            // Legitimate-zero guard: a run pinned at ~0 is an OFF / STOPPED state
            // (engine off → RPM/MAF/VSS read 0, foot off throttle → TPS ~0), NOT a
            // stuck sensor.  A stuck sensor pins at a plausible NON-zero value; a
            // spike-to-zero-and-back is the dropout detector's job.  Without this
            // guard an engine-off zero tail is falsely reported as "stuck sensor" —
            // exactly the false positive this module promises never to produce.
            if (Math.Abs(level) <= eps) return;

            double lenOver = SignalMath.Clamp((double)(bestLen - flatMinSamples) / flatMinSamples, 0.0, 1.0);
            double magnitude = SignalMath.Clamp(0.55 + 0.35 * lenOver, 0.0, 1.0);

            events.Add(new GlitchEvent
            {
                Kind = EventKind.Flatline,
                Signal = series.Name,
                Unit = series.Unit,
                Utc = samples[bestStart].Utc,
                PreValue = level,
                AtValue = level,
                PostValue = values[endIdx],
                RunLen = bestLen,
                SampleCount = n,
                EstHz = series.EstimatedHz,
                LowRate = lowRate,
                Magnitude = magnitude,
                Confidence = SignalMath.Clamp(0.50 + 0.30 * lenOver - (lowRate ? 0.10 : 0.0), 0.0, 0.85),
            });
        }

        // ── Result construction ──────────────────────────────────────────────

        private DiagnosticResult BuildResult(GlitchEvent e, bool usedUnvalidated)
        {
            string sig = e.Signal;
            string unit = string.IsNullOrEmpty(e.Unit) ? "" : " " + e.Unit;
            string ts = e.Utc == DateTime.MinValue
                ? "(no timestamp)"
                : e.Utc.ToString("HH:mm:ss.fff", CultureInfo.InvariantCulture) + " UTC";

            DiagnosticResult result;

            switch (e.Kind)
            {
                case EventKind.Dropout:
                    result = NewResult($"Signal Dropout — {sig}");
                    result.Hypothesis =
                        $"Signal dropout on {sig}: the reading collapsed to near-zero for " +
                        $"{e.RunLen} sample(s) and then recovered to its prior level. This " +
                        "spike-to-zero-and-back is the signature of an intermittent open circuit " +
                        "or a momentary loss of sensor supply/ground/signal — not a real value.";
                    result.Severity = DiagnosticSeverity.Medium;
                    result.Evidence
                        .Info("Event time", ts, $"Deepest point of a {e.RunLen}-sample dropout on {sig}.")
                        .Fail($"{sig} (at event)", Fmt(e.AtValue) + unit, Fmt(e.PreValue) + unit,
                              $"Fell {e.DepthFrac * 100.0:0}% below the surrounding baseline, then recovered.")
                        .Info($"{sig} (pre / post)",
                              $"{Fmt(e.PreValue)}{unit}  →  {Fmt(e.PostValue)}{unit}",
                              "Clearly non-zero on both sides — the zero was transient, not a real off-state.");
                    break;

                case EventKind.Spike:
                    result = NewResult($"Transient Spike — {sig}");
                    result.Hypothesis =
                        $"Transient spike on {sig}: a single sample jumped {Fmt(Math.Abs(e.Jump))}{unit} " +
                        "and immediately reverted. A one-sample step that reverses is electrical noise " +
                        "on the sensor circuit (bad connection, unshielded routing, or a marginal " +
                        "ground) rather than a real physical change.";
                    result.Severity = DiagnosticSeverity.Low;
                    result.Evidence
                        .Info("Event time", ts, $"Single-sample spike on {sig}.")
                        .Fail($"{sig} step", Fmt(Math.Abs(e.Jump)) + unit + " jump",
                              $"<= {Fmt(e.Threshold)}{unit}",
                              $"Exceeds the max({Fmt(e.SigmaMult)}·robust-σ, implausible-delta) gate for a per-sample change.")
                        .Info($"{sig} (pre / at / post)",
                              $"{Fmt(e.PreValue)}{unit}  →  {Fmt(e.AtValue)}{unit}  →  {Fmt(e.PostValue)}{unit}",
                              "Reverts to the pre-spike level — a physical process would not snap back in one sample.");
                    break;

                default: // Flatline
                    result = NewResult($"Stuck / Flatlined Signal — {sig}");
                    result.Hypothesis =
                        $"Stuck/flatlined {sig}: the value held constant at {Fmt(e.AtValue)}{unit} for " +
                        $"{e.RunLen} samples while other signals moved. A should-vary signal that freezes " +
                        "points to a stuck sensor, a cached/last-known-good PID, or a failed sensor element.";
                    result.Severity = DiagnosticSeverity.Medium;
                    result.Evidence
                        .Info("Event time", ts, $"Start of a {e.RunLen}-sample flat run on {sig}.")
                        .Fail($"{sig} variance", "~0 over " + e.RunLen.ToString(CultureInfo.InvariantCulture) + " samples",
                              "should vary while active",
                              $"Held at {Fmt(e.AtValue)}{unit} with no movement even though the vehicle was active.")
                        .Info("Activity witness", "another should-vary signal moved",
                              "Confirms the vehicle was operating, so a frozen reading is anomalous rather than idle.");
                    break;
            }

            AddSampleRateEvidence(result, e);

            result.Confidence = e.Confidence;
            result.NextTest =
                $"Wiggle-test the {sig} sensor connector and harness while monitoring; the fault is " +
                "intermittent so a static reading may look fine.";
            result.SuspectComponents = new List<string>
            {
                $"{sig} sensor connector (intermittent open / poor contact)",
                $"{sig} signal / supply / ground wiring in the harness",
                $"{sig} sensor element",
            };

            ApplyAdvisory(result, e, usedUnvalidated);
            return result;
        }

        /// <summary>Records the sample-rate honesty step: a one-sample glitch at a
        /// low rate may be aliasing rather than a true transient.</summary>
        private static void AddSampleRateEvidence(DiagnosticResult result, GlitchEvent e)
        {
            if (e.EstHz > 0)
            {
                if (e.LowRate)
                    result.Evidence.Inconclusive("Sample rate",
                        string.Format(CultureInfo.InvariantCulture, "{0:0.#} Hz", e.EstHz),
                        "Low capture rate — a single-sample event is near the Nyquist floor and may be " +
                        "aliasing; re-capture at a higher rate to confirm the glitch is real.");
                else
                    result.Evidence.Info("Sample rate",
                        string.Format(CultureInfo.InvariantCulture, "{0:0.#} Hz", e.EstHz),
                        "Adequate to resolve a single-sample transient.");
            }
        }

        /// <summary>Sets advisory + reason: spec-seeded thresholds, low rate, or
        /// a thin series all make an intermittent finding advisory-only.</summary>
        private static void ApplyAdvisory(DiagnosticResult result, GlitchEvent e, bool usedUnvalidated)
        {
            var reasons = new List<string>();
            if (usedUnvalidated)
                reasons.Add("thresholds are spec-seeded, not validated on this platform");
            if (e.LowRate)
                reasons.Add(string.Format(CultureInfo.InvariantCulture,
                    "capture at {0:0.#} Hz — a one-sample event may be aliasing", e.EstHz));
            if (e.SampleCount < 60)
                reasons.Add($"only {e.SampleCount} samples on {e.Signal} — thin context around the event");

            result.Advisory = usedUnvalidated || e.LowRate || e.SampleCount < 60;
            if (result.Advisory)
                result.AdvisoryReason = reasons.Count > 0
                    ? string.Join("; ", reasons)
                    : "intermittent finding — confirm live before condemning a part";
        }

        // ── Helpers ──────────────────────────────────────────────────────────

        /// <summary>True if any should-vary signal (with enough samples) genuinely
        /// moves — the witness that the vehicle was active during the capture.
        /// Uses a ROBUST (MAD-based) coefficient of variation so a single spike on
        /// an otherwise-steady signal does not masquerade as activity — otherwise a
        /// steady idle with one glitch would falsely license a "stuck" verdict.</summary>
        /// <summary>The correct flatline witness for a signal, distinguishing signals that MUST
        /// oscillate (O2) from operating-point signals that legitimately hold constant at a steady
        /// operating point.</summary>
        private static bool FlatlineWitnessMet(DiagnosticSnapshot snapshot, string name, double activityCoV)
        {
            // O2 must oscillate whenever the engine is in closed loop → flat = stuck if running.
            if (AlwaysOscillate.Contains(name))
            {
                var rpm = snapshot.Series(CanonicalSignals.Rpm);
                return rpm != null && rpm.Count >= 10 && SignalMath.Median(rpm.Values()) >= 400.0;
            }
            // Operating-point signal: witnessed ONLY by another operating-point signal genuinely
            // sweeping (NOT by O2, which oscillates even at a dead-steady idle). If nothing else in
            // the operating point moved, a flat signal is an expected steady state, not a fault.
            foreach (var kv in snapshot.Signals)
            {
                var s = kv.Value;
                if (s == null || s.Count < 10 || !OperatingPoint.Contains(s.Name)) continue;
                if (string.Equals(s.Name, name, StringComparison.OrdinalIgnoreCase)) continue;
                if (RobustCoV(s.Values()) >= activityCoV) return true;
            }
            return false;
        }

        private static bool SnapshotHasActivity(DiagnosticSnapshot snapshot, double activityCoV, string excludeName = null)
        {
            foreach (var kv in snapshot.Signals)
            {
                var s = kv.Value;
                if (s == null || s.Count < 10 || !ShouldVary.Contains(s.Name)) continue;
                if (excludeName != null && string.Equals(s.Name, excludeName, StringComparison.OrdinalIgnoreCase)) continue;
                if (RobustCoV(s.Values()) >= activityCoV) return true;
            }
            return false;
        }

        /// <summary>Median-absolute-deviation coefficient of variation:
        /// MAD(x) / |median(x)|.  Robust to a handful of spikes/dropouts, so it
        /// reflects genuine sustained variation rather than outliers.</summary>
        private static double RobustCoV(IReadOnlyList<double> xs)
        {
            if (xs == null || xs.Count < 2) return 0.0;
            double med = SignalMath.Median(xs);
            if (Math.Abs(med) < 1e-9) return 0.0;
            var absDev = new double[xs.Count];
            for (int i = 0; i < xs.Count; i++) absDev[i] = Math.Abs(xs[i] - med);
            double mad = SignalMath.Median(absDev);
            return mad / Math.Abs(med);
        }

        /// <summary>Per-sample change large enough to be physically implausible for
        /// a signal. Calibration-overridable; falls back to a data-driven fraction
        /// of the signal's observed range for unknown signals.</summary>
        private static double ImplausibleDelta(SignalSeries series, IReadOnlyList<double> values)
        {
            switch (series.Name.ToUpperInvariant())
            {
                case "RPM": return 2500.0;    // RPM cannot slew 2500/sample at OBD rates
                case "MAF": return 40.0;      // g/s
                case "TPS": return 30.0;      // %
                case "MAP": return 60.0;      // kPa
                case "ENGINELOAD":
                case "ABSOLUTELOAD": return 50.0; // %
                case "VSS": return 40.0;      // km/h
                case "O2_B1S1":
                case "O2_B2S1": return 0.8;   // V
                default:
                    double range = series.Max - series.Min;
                    return range > 0 ? 0.40 * range : 0.0;
            }
        }

        /// <summary>Range within which a should-vary signal counts as flat. Small,
        /// signal-scaled; a truly moving signal never stays inside it for 20+
        /// consecutive samples.</summary>
        private static double StuckEpsilon(SignalSeries series, IReadOnlyList<double> values)
        {
            switch (series.Name.ToUpperInvariant())
            {
                case "RPM": return 5.0;
                case "MAF": return 0.2;
                case "TPS": return 0.5;
                case "ENGINELOAD":
                case "ABSOLUTELOAD": return 0.5;
                case "O2_B1S1":
                case "O2_B2S1": return 0.02;
                default:
                    double mag = Math.Abs(SignalMath.Median(values));
                    return Math.Max(1e-6, 0.005 * mag);
            }
        }

        private static string Fmt(double v) => v.ToString("0.###", CultureInfo.InvariantCulture);
    }
}
