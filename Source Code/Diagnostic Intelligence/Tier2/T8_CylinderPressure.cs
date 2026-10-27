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
//  Tester Present Specialist Automotive Solutions — T8 In-Cylinder Pressure from Crank Velocity (Tier-2, RESEARCH)
//
//  MOONSHOT / RESEARCH.  A firing cylinder does not push the crankshaft smoothly — each
//  combustion event dumps a torque impulse into the crank that briefly ACCELERATES it,
//  and the exhaust/compression strokes DECELERATE it.  The crankshaft is therefore a
//  natural torque transducer: its angular velocity ripple carries the per-cylinder
//  combustion torque, and (with a full thermodynamic + kinematic model of the slider-
//  crank) that torque can be inverted back to an in-cylinder PRESSURE trace.  This is a
//  real, published technique (torsional-vibration / crank-speed indicated-torque
//  estimation), and it is how a bench cell reconstructs an indicator diagram without a
//  pressure transducer in every hole.
//
//  THE HARD CONSTRAINT — data rate.  Reconstruction needs the crank velocity sampled at
//  crank-angle resolution: to resolve a firing event you need many samples per
//  revolution, i.e. an ULTRA-HIGH-RATE crank signal (order of hundreds of Hz to kHz).
//  OBD-II PID 0x0C (engine RPM) is delivered at a handful of Hz — it is a filtered mean
//  speed, the ripple has already been averaged out.  So this module does NOT pretend:
//  it FIRST gates on the effective sample rate of the crank/RPM series and, in the
//  overwhelmingly common OBD case, honestly reports that the analysis is unavailable and
//  says exactly what hardware would enable it (a vendor high-rate crank-position DID or a
//  CKP scope channel mapped to the RPM canonical name).
//
//  WHEN a high-rate source IS connected (EstimatedHz ≥ needed) the module runs a BASIC,
//  research-grade reconstruction STUB — not the full thermodynamic inversion:
//
//    ω(t)  = RPM · 2π/60                         [rad/s]   crank angular velocity
//    α(t)  = dω/dt                               [rad/s²]  crank angular acceleration
//    T(t)  ≈ I · α(t)                            [N·m]     indicated torque (I = lumped
//                                                          rotating inertia, spec-seeded)
//    θ(t)  = ∫ω dt                               [deg]     crank angle (trapezoidal)
//
//  On a 4-stroke each cylinder fires once per 720° (two revolutions), evenly phased, so
//  the 720° cycle splits into N equal firing sectors of 720/N°.  We integrate crank
//  angle, bin every sample into its firing sector, take the PEAK indicated torque within
//  each sector occurrence (the combustion push), and average those peaks per firing-order
//  position across all captured cycles.  A cylinder whose mean peak torque sits markedly
//  BELOW the group median is contributing weak combustion torque ⇒ low in-cylinder
//  pressure (weak compression, a burnt/leaking valve, worn rings, or a partial misfire).
//
//  Tier-2 honesty: this is RESEARCH-GRADE and UNVALIDATED.  The lumped inertia I is a
//  spec-seeded constant (real driveline inertia varies with clutch/flywheel/accessory
//  state), the torque scale is therefore only relative, and single crank-speed
//  reconstruction cannot separate a compression loss from an injection/ignition loss.
//  Every finding is emitted ADVISORY and points at the discriminating PHYSICAL test — a
//  compression / cylinder-leakdown check on the flagged hole.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using TesterPresent.OBD2.Intelligence;

namespace TesterPresent.OBD2.Intelligence.Tier2
{
    /// <summary>
    /// T8 — In-Cylinder Pressure from Crank Velocity (research).  Gates hard on the
    /// effective crank sample rate: below the needed high rate it emits a single honest
    /// Info result explaining that OBD-II PID rate cannot support reconstruction; at or
    /// above it, it runs a basic indicated-torque reconstruction stub (ω→α→T, angle-
    /// binned per firing sector) and flags a firing-order position whose mean peak torque
    /// is markedly below the group median as a low-cylinder-pressure suspect.  Reads
    /// snapshot + context only; never touches hardware and never throws.
    /// </summary>
    public sealed class CylinderPressureModule : DiagnosticModuleBase
    {
        // ── Definitional physics (not calibratable) ──────────────────────────────────────
        private const double DEG_PER_CYCLE   = 720.0; // 4-stroke: one full cycle = two crank revolutions
        private const int    MIN_SAMPLES     = 64;    // matches Requirements; below this the derivative is noise
        private const double MIN_CYCLES      = 2.0;   // need ≥ 2 whole engine cycles to average per-cylinder peaks
        private const int    MIN_PEAKS_PER_CYL = 2;   // and ≥ 2 firing events per cylinder before comparing
        private const double MIN_RPM         = 100.0; // below this nothing is rotating to reconstruct from

        private DiagnosticRequirements _requirements;

        /// <inheritdoc/>
        public override string ModuleId => "T8";

        /// <inheritdoc/>
        public override string DisplayName => "In-Cylinder Pressure from Crank Velocity (research)";

        /// <inheritdoc/>
        public override DiagnosticTier Tier => DiagnosticTier.Tier2;

        /// <inheritdoc/>
        /// <remarks>MinSampleRateHz is deliberately NOT set here — the base class would
        /// then silently skip the module on low-rate captures.  Instead the rate is
        /// checked inside AnalyzeCore so we can emit a clear, actionable message telling
        /// the technician what hardware would enable the analysis.</remarks>
        public override DiagnosticRequirements Requirements =>
            _requirements ?? (_requirements = new DiagnosticRequirements
            {
                RequiredSignals = new List<string> { CanonicalSignals.Rpm },
                MinSamples = MIN_SAMPLES,
            });

        /// <summary>
        /// Determine the effective crank sample rate; if it is below the needed high rate
        /// emit one honest Info result and stop, otherwise run the reconstruction stub and
        /// flag any firing-order position with a low mean peak indicated torque.
        /// </summary>
        protected override IReadOnlyList<DiagnosticResult> AnalyzeCore(
            DiagnosticSnapshot snapshot, DiagnosticContext context)
        {
            var results = new List<DiagnosticResult>();

            // The crank-velocity source: RPM (or an upstream vendor high-rate crank-velocity
            // DID mapped onto the RPM canonical name).  Required signal, so it exists here.
            SignalSeries crank = snapshot.Series(CanonicalSignals.Rpm);
            if (crank == null || !crank.HasData || crank.Count < MIN_SAMPLES) return results;

            bool usedUnvalidated = false;
            double neededHz = Cal(context, "T8.MinCrankHz", 500.0, ref usedUnvalidated);
            double hz = crank.EstimatedHz;

            // ── DATA-AVAILABILITY GATE (the expected common case) ───────────────────────
            // OBD-II PID 0x0C arrives at a few Hz — a filtered mean speed with the firing
            // ripple already averaged out.  Do NOT fabricate a reconstruction; say so.
            if (hz < neededHz)
            {
                results.Add(BuildRateUnavailable(hz, neededHz));
                return results;
            }

            // ── HIGH-RATE BRANCH: basic indicated-torque reconstruction stub ────────────
            double inertia = Cal(context, "T8.InertiaKgM2", 0.20, ref usedUnvalidated);      // lumped rotating inertia
            double weakFraction = Cal(context, "T8.WeakCylinderFraction", 0.65, ref usedUnvalidated); // peak-ratio flag threshold

            int cyls = snapshot.CylinderCount > 0 ? snapshot.CylinderCount : 4;
            if (cyls < 2 || cyls > 16) cyls = 4;                                             // defensive clamp

            double[] rpm = crank.Values().ToArray();
            double[] t = RelativeSeconds(crank);
            int n = rpm.Length;
            if (n < MIN_SAMPLES || t.Length != n) return results;

            // ω, θ (trapezoidal integral), α (backward difference), T = I·α.
            var omega = new double[n];
            var thetaDeg = new double[n];
            for (int i = 0; i < n; i++) omega[i] = rpm[i] * 2.0 * Math.PI / 60.0;

            double thetaRad = 0.0;
            double radToDeg = 180.0 / Math.PI;
            for (int i = 1; i < n; i++)
            {
                double dt = t[i] - t[i - 1];
                if (dt <= 0 || double.IsNaN(dt) || double.IsInfinity(dt)) dt = 0; // frozen/duplicate timestamp ⇒ no advance
                thetaRad += 0.5 * (omega[i] + omega[i - 1]) * dt;
                thetaDeg[i] = thetaRad * radToDeg;
            }

            double totalDeg = thetaDeg[n - 1];
            double cyclesObserved = totalDeg / DEG_PER_CYCLE;
            if (cyclesObserved < MIN_CYCLES) return results; // too little rotation to compare cylinders — stay silent

            // Per-firing-sector peak indicated torque, accumulated per firing-order position.
            // Sector s (0..cyls-1) fires once per 720°; combustion appears as the positive
            // torque peak within that sector's occupancy each cycle.
            double sectorWidth = DEG_PER_CYCLE / cyls;
            var acc = new WelfordAccumulator[cyls];

            int curSector = SectorOf(thetaDeg[0], sectorWidth, cyls);
            double runPeak = double.NegativeInfinity;
            for (int i = 1; i < n; i++)
            {
                double dt = t[i] - t[i - 1];
                double alpha = dt > 0 ? (omega[i] - omega[i - 1]) / dt : 0.0;
                double torque = inertia * alpha; // T ≈ I·α, indicated torque (relative units — I is spec-seeded)

                int sec = SectorOf(thetaDeg[i], sectorWidth, cyls);
                if (sec == curSector)
                {
                    if (torque > runPeak) runPeak = torque;
                }
                else
                {
                    // Close the run just ended: record its peak against the firing-order slot.
                    // Every run closed HERE is a COMPLETE sector traversal (we only get here on
                    // a sector boundary), so its peak is unbiased.
                    if (!double.IsNegativeInfinity(runPeak) && curSector >= 0 && curSector < cyls)
                        acc[curSector].Add(runPeak);
                    curSector = sec;
                    runPeak = torque;
                }
            }
            // Deliberately DO NOT record the final, still-open run: the capture ends
            // mid-sector, so that last sector's window misses part of its combustion arc
            // and its peak is biased LOW — recorded, it fabricates a false weak-cylinder
            // reading on exactly one firing position.  Dropping it costs at most one peak
            // for that cylinder; MIN_PEAKS_PER_CYL still guards every slot.

            // Every cylinder needs enough firing events to have a trustworthy mean peak.
            for (int k = 0; k < cyls; k++)
                if (acc[k].Count < MIN_PEAKS_PER_CYL) return results;

            var peakMean = new double[cyls];
            for (int k = 0; k < cyls; k++) peakMean[k] = acc[k].Mean;

            double median = SignalMath.Median(peakMean);
            // The combustion push is positive; if the median peak is not clearly positive
            // the reconstruction carries no discernible combustion structure ⇒ nothing to
            // claim (flat data, over-filtered source, or a genuinely smooth engine).
            if (median <= 1e-6) return results;

            int weakIdx = 0;
            for (int k = 1; k < cyls; k++) if (peakMean[k] < peakMean[weakIdx]) weakIdx = k;
            double ratio = peakMean[weakIdx] / median;

            if (ratio >= weakFraction) return results; // all cylinders contribute comparably ⇒ no finding

            results.Add(BuildWeakCylinder(weakIdx, cyls, peakMean, median, ratio, weakFraction,
                                          inertia, hz, neededHz, cyclesObserved, crank.Mean,
                                          context, usedUnvalidated));
            return results;
        }

        // ── Result: rate unavailable (the honest common case) ────────────────────────────

        /// <summary>
        /// The crank series is at OBD PID rate, far below what crank-speed reconstruction
        /// needs.  Emit one Info result that states the gap and names the hardware that
        /// would enable the analysis — no fault is claimed.
        /// </summary>
        private DiagnosticResult BuildRateUnavailable(double hz, double neededHz)
        {
            var r = NewResult("Cylinder-pressure reconstruction unavailable at this data rate");
            r.Hypothesis =
                $"In-cylinder pressure reconstruction requires ≥{Fmt0(neededHz)} Hz crank data; the current capture is "
                + $"{Fmt(hz)} Hz (OBD-II PID rate). Connect a high-rate vendor crank-position DID or a CKP scope to enable "
                + "this analysis. The OBD engine-speed PID is a filtered mean speed — the per-firing angular-velocity ripple "
                + "that carries combustion torque has already been averaged out, so no reconstruction is attempted.";
            r.Severity = DiagnosticSeverity.Info;
            r.Confidence = 0.0; // not a fault hypothesis — a capability gate
            r.SuspectComponents = new List<string>();
            r.NextTest =
                $"Provide a crank angular-velocity signal sampled at ≥{Fmt0(neededHz)} Hz — a vendor high-rate crank-position "
                + "DID or a scope on the CKP sensor mapped to the RPM channel — then re-run this module.";
            r.Evidence
                .Add("Crank sample rate", $"{Fmt(hz)} Hz", $"≥ {Fmt0(neededHz)} Hz", EvidenceVerdict.Fail,
                     $"Below {Fmt0(neededHz)} Hz the firing ripple is not resolvable; OBD PID 0x0C delivers only a few Hz.")
                .Info("Source", "OBD-II RPM PID (0x0C)",
                      "A filtered mean engine speed, not crank-angle-resolved velocity — reconstruction is not possible from it.");
            r.Advisory = true;
            r.AdvisoryReason =
                $"analysis gated off: crank data at {Fmt(hz)} Hz is below the {Fmt0(neededHz)} Hz needed for crank-speed "
                + "pressure reconstruction — no reconstruction was performed";
            return r;
        }

        // ── Result: weak-cylinder finding (high-rate branch) ─────────────────────────────

        /// <summary>
        /// A firing-order position whose mean peak indicated torque sits markedly below the
        /// group median contributes weak combustion torque ⇒ low in-cylinder pressure.
        /// Research-grade and advisory: single crank-speed reconstruction cannot separate a
        /// compression loss from an injection/ignition loss, so the physical compression /
        /// leak-down test is the discriminator.
        /// </summary>
        private DiagnosticResult BuildWeakCylinder(int weakIdx, int cyls, double[] peakMean, double median,
                                                   double ratio, double weakFraction, double inertia, double hz,
                                                   double neededHz, double cyclesObserved, double meanRpm,
                                                   DiagnosticContext context, bool usedUnvalidated)
        {
            int cylLabel = weakIdx + 1; // firing-order position (physical cylinder mapping is unknown without cam phase)
            double deficitPct = (1.0 - ratio) * 100.0;

            var r = NewResult($"Reconstructed low cylinder-pressure contribution on cyl {cylLabel}");
            r.Hypothesis =
                $"Crank-speed reconstruction over {Fmt(cyclesObserved)} engine cycles shows firing-order position {cylLabel} "
                + $"contributing a mean peak indicated torque {Fmt0(deficitPct)}% below the group median "
                + $"({Sci(peakMean[weakIdx])} vs {Sci(median)} relative units). A cylinder producing markedly less combustion "
                + "torque than its peers points at low in-cylinder pressure — weak compression (burnt/leaking valve, worn rings, "
                + "head-gasket breach) or a partial misfire (fuel/ignition). Single crank-speed reconstruction cannot separate "
                + "those causes; it localises the weak hole. Research-grade method — treat as indicative, not confirmatory.";
            r.Severity = DiagnosticSeverity.High;
            r.Confidence = ConfidenceFor(ratio, weakFraction);
            r.SuspectComponents = new List<string>
            {
                $"Cylinder {cylLabel} compression (burnt / leaking valve, worn or broken rings, head-gasket breach)",
                $"Cylinder {cylLabel} fuel delivery (clogged / dead injector — a partial misfire mimics low pressure here)",
                $"Cylinder {cylLabel} ignition (weak coil / fouled plug — same torque signature as low compression)",
            };
            r.NextTest =
                $"Confirm with a physical compression / leak-down test on cylinder {cylLabel}. Low compression and audible "
                + "cylinder leakage confirm a mechanical pressure loss; normal compression points the finger at fuel or "
                + "ignition on that hole instead.";
            r.NextTestScript = BuildCompressionScript(cylLabel);

            // Per-cylinder peak table for the technician to sanity-check the localisation.
            string table = string.Join(", ",
                Enumerable.Range(0, cyls).Select(k => $"#{k + 1}={Sci(peakMean[k])}"));

            r.Evidence
                .Info("Reconstruction", $"{Fmt(cyclesObserved)} engine cycles at {Fmt(hz)} Hz",
                      $"Crank velocity ≥ needed {Fmt0(neededHz)} Hz — ω→α→T (I={Fmt(inertia)} kg·m²) binned into {cyls} firing sectors of {Fmt0(DEG_PER_CYCLE / cyls)}°.")
                .Info("Per-cylinder mean peak torque", table,
                      "Mean of the positive torque peak in each firing sector (relative units — the inertia scale is spec-seeded).")
                .Add("Weakest position", $"cyl {cylLabel} = {Sci(peakMean[weakIdx])}",
                     $"≥ {Pct(weakFraction)} of median {Sci(median)}", EvidenceVerdict.Fail,
                     $"Sits at {Pct(ratio)} of the group median — below the {Pct(weakFraction)} weak-cylinder threshold.")
                .Info("Operating point", $"mean {Fmt0(meanRpm)} rpm, {cyls} cylinders",
                      "Firing-order position, not physical cylinder number — cam-phase reference is needed to map the two.");

            r.Advisory = true;
            r.AdvisoryReason = BuildAdvisoryReason(context, usedUnvalidated);
            return r;
        }

        // ── Confirmation script ──────────────────────────────────────────────────────────

        /// <summary>Observe-only compression / leak-down test on the flagged cylinder — the
        /// technician performs the physical measurement; the host never commands the ECU.</summary>
        private static ConfirmationScript BuildCompressionScript(int cylLabel)
        {
            return new ConfirmationScript
            {
                Name = $"Compression / leak-down test — cylinder {cylLabel}",
                Rationale = $"Crank-speed reconstruction localised weak combustion torque to firing position {cylLabel}. A "
                            + "physical compression / leak-down test confirms whether the pressure loss is mechanical and, if "
                            + "so, where it leaks (valves, rings, or head gasket).",
                Steps =
                {
                    new ConfirmationStep
                    {
                        Description = $"Run a cranking compression test on cylinder {cylLabel} and compare it against the "
                                      + "other cylinders and the engine's spec.",
                        ServiceId = 0x00,
                        Payload = null,
                        ExpectedObservation = $"Cylinder {cylLabel} reads markedly below its peers / spec ⇒ confirmed low "
                                              + "in-cylinder pressure. If compression is normal, the deficit is fuel or ignition.",
                        IsActiveControl = false,
                    },
                    new ConfirmationStep
                    {
                        Description = $"Follow up with a leak-down test on cylinder {cylLabel}, listening at the intake, "
                                      + "exhaust, oil filler, and adjacent cylinder.",
                        ServiceId = 0x00,
                        Payload = null,
                        ExpectedObservation = "Air at the intake = intake valve; at the exhaust = exhaust valve; at the oil "
                                              + "filler = rings; bubbles in coolant / adjacent cylinder = head gasket.",
                        IsActiveControl = false,
                    },
                },
            };
        }

        // ── Small helpers ────────────────────────────────────────────────────────────────

        /// <summary>Firing sector (0..cyls-1) for a crank angle, folding the angle into a
        /// single 0..720° cycle and clamping defensively against float edge cases.</summary>
        private static int SectorOf(double angleDeg, double sectorWidth, int cyls)
        {
            if (sectorWidth <= 0) return 0;
            double m = angleDeg % DEG_PER_CYCLE;
            if (m < 0) m += DEG_PER_CYCLE; // negative angle (should not occur — ω≥0) folded positive
            int s = (int)(m / sectorWidth);
            if (s < 0) s = 0; else if (s >= cyls) s = cyls - 1;
            return s;
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

        /// <summary>Read a calibration constant, folding an unvalidated read into the advisory flag.</summary>
        private static double Cal(DiagnosticContext ctx, string key, double fallback, ref bool usedUnvalidated)
        {
            if (ctx == null || ctx.Calibration == null) { usedUnvalidated = true; return fallback; }
            bool validated;
            double v = ctx.Calibration.Value(key, fallback, out validated);
            if (!validated) usedUnvalidated = true;
            return v;
        }

        /// <summary>Confidence in [0.30, 0.65]: rises as the weak cylinder falls further below
        /// the flag threshold, then capped — a research-grade crank-speed reconstruction on a
        /// spec-seeded inertia stays advisory even when the deficit is stark.</summary>
        private static double ConfidenceFor(double ratio, double weakFraction)
        {
            double below = weakFraction > 1e-6
                ? SignalMath.Clamp((weakFraction - ratio) / weakFraction, 0.0, 1.0)
                : 0.0;
            double c = 0.30 + 0.35 * below;
            return SignalMath.Clamp(c, 0.0, 0.65);
        }

        /// <summary>Assemble the advisory reason: research method, spec-seeded inertia (torque
        /// scale is only relative), and single crank-speed reconstruction cannot separate a
        /// compression loss from a fuel/ignition loss.</summary>
        private static string BuildAdvisoryReason(DiagnosticContext context, bool usedUnvalidated)
        {
            string reason =
                "RESEARCH-GRADE crank-speed pressure reconstruction: the lumped rotating inertia is spec-seeded so the torque "
                + "scale is relative (peak comparison only, not absolute pressure), and a single crank-velocity trace cannot "
                + "separate a compression loss from a fuel/ignition loss on the flagged cylinder — the physical compression / "
                + "leak-down test is the discriminator";
            if (usedUnvalidated || context == null || context.Calibration == null || !context.Calibration.IsValidated)
                reason += " (no validated calibration present)";
            return reason;
        }

        private static string Fmt(double v)
            => double.IsNaN(v) ? "n/a" : v.ToString("0.0#", CultureInfo.InvariantCulture);

        private static string Fmt0(double v)
            => double.IsNaN(v) ? "n/a" : v.ToString("0", CultureInfo.InvariantCulture);

        private static string Sci(double v)
            => double.IsNaN(v) ? "n/a" : v.ToString("0.###", CultureInfo.InvariantCulture);

        private static string Pct(double frac)
            => (SignalMath.Clamp(frac, 0, 1) * 100).ToString("0", CultureInfo.InvariantCulture) + "%";
    }
}
