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
//  Tester Present Specialist Automotive Solutions — Diagnostic Result & Module Contract
//
//  The output contract (DiagnosticResult) and the interface every intelligence
//  module implements (IDiagnosticModule).  A result is never a bare verdict: it
//  carries the evidence chain that produced it, a calibrated confidence, the
//  suspect components, and — critically — the single most discriminating next
//  test to run.  Active-control confirmation is expressed declaratively as a
//  ConfirmationScript so the module stays pure (no J2534); the host executes it
//  through the existing UDSManager + RcmSafetyGuard.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;

namespace TesterPresent.OBD2.Intelligence
{
    /// <summary>One step of a declarative active-control confirmation sequence.
    /// The host runs it via UDSManager; the module never touches hardware.</summary>
    public sealed class ConfirmationStep
    {
        public string Description { get; set; }
        /// <summary>UDS service to invoke (0x2F IOControl, 0x31 RoutineControl, 0x22 Read…). 0 = observe-only.</summary>
        public byte ServiceId { get; set; }
        /// <summary>Raw request payload if the step commands the ECU; null for observe-only steps.</summary>
        public byte[] Payload { get; set; }
        /// <summary>What the technician / host should watch for to confirm the hypothesis.</summary>
        public string ExpectedObservation { get; set; }
        /// <summary>True if this step actively commands the ECU (needs the safety gate).</summary>
        public bool IsActiveControl { get; set; }
        /// <summary>
        /// True if this active-control step is only safe against an engine / powertrain
        /// module (e.g. injector-cut, idle dither).  The host runner MUST refuse to send
        /// it when the live transport is pointed at a non-powertrain module — the module
        /// itself carries no address, so this is how a "engine PCM only" invariant is
        /// enforced end-to-end rather than left to a comment.
        /// </summary>
        public bool RequiresPowertrainTarget { get; set; }
    }

    /// <summary>A named, safety-gated confirmation sequence recommended as the next test.</summary>
    public sealed class ConfirmationScript
    {
        public string Name { get; set; }
        public string Rationale { get; set; }
        public List<ConfirmationStep> Steps { get; set; } = new List<ConfirmationStep>();
        /// <summary>True if ANY step commands the ECU — the host must gate on operator confirmation.</summary>
        public bool RequiresActiveControl => Steps != null && Steps.Any(s => s.IsActiveControl);
    }

    /// <summary>
    /// A single fault hypothesis produced by a module.  Confidence is 0–1.  When
    /// Advisory is true, the result rests on at least one [RequiresValidation]
    /// constant or insufficient data and must be presented as advisory-only.
    /// </summary>
    public sealed class DiagnosticResult
    {
        public string ModuleId { get; set; }        // "M1", "T3"
        public string Title { get; set; }
        /// <summary>The fault hypothesis in plain language.</summary>
        public string Hypothesis { get; set; }
        public double Confidence { get; set; }        // 0.0 – 1.0
        public DiagnosticSeverity Severity { get; set; } = DiagnosticSeverity.Info;
        public EvidenceChain Evidence { get; set; } = new EvidenceChain();
        /// <summary>The single most discriminating next test, in plain language.</summary>
        public string NextTest { get; set; }
        /// <summary>Optional executable confirmation sequence for the recommended next test.</summary>
        public ConfirmationScript NextTestScript { get; set; }
        public List<string> SuspectComponents { get; set; } = new List<string>();
        /// <summary>Advisory-only: rests on unvalidated calibration or thin data.</summary>
        public bool Advisory { get; set; }
        public string AdvisoryReason { get; set; }
        /// <summary>M6 ONLY: the full ranked fault frontier behind this result (lossless — every
        /// live hypothesis, not just the top two that become DiagnosticResults). Null on every
        /// other module. The Investigation Tree consumes this to seed its hypothesis frontier.</summary>
        public IReadOnlyList<RankedFault> RankedFaults { get; set; }
        public DateTime ProducedUtc { get; set; } = DateTime.UtcNow;

        /// <summary>Confidence as a 0–100 percentage, clamped.</summary>
        public int ConfidencePercent => (int)Math.Round(SignalMath.Clamp(Confidence, 0, 1) * 100);

        public string ConfidenceBand
        {
            get
            {
                double c = Confidence;
                if (c >= 0.80) return "high";
                if (c >= 0.55) return "moderate";
                if (c >= 0.30) return "low";
                return "weak";
            }
        }

        public override string ToString() =>
            $"[{ModuleId}] {Hypothesis} ({ConfidencePercent}% {ConfidenceBand}{(Advisory ? ", advisory" : "")})";
    }

    /// <summary>
    /// Declares what inputs a module needs so the host can decide whether it can
    /// run given the current capture, and skip (with a clear reason) rather than
    /// produce garbage from missing data.
    /// </summary>
    public sealed class DiagnosticRequirements
    {
        /// <summary>Canonical signal names this module cannot run without.</summary>
        public List<string> RequiredSignals { get; set; } = new List<string>();
        /// <summary>Minimum sample rate (Hz) on the required signals; 0 = any.</summary>
        public double MinSampleRateHz { get; set; }
        /// <summary>Minimum samples required on the primary signal; 0 = any.</summary>
        public int MinSamples { get; set; }
        public bool NeedsTopology { get; set; }
        public bool NeedsDtcs { get; set; }
        public bool NeedsFleetStore { get; set; }
        public bool NeedsFixedByStore { get; set; }
        /// <summary>True if the module's recommended next test commands the ECU.</summary>
        public bool MayRecommendActiveControl { get; set; }

        /// <summary>Check a snapshot against these requirements; returns the first
        /// unmet requirement as a human reason, or null if all are met.</summary>
        public string UnmetReason(DiagnosticSnapshot snap, DiagnosticContext ctx)
        {
            if (snap == null) return "no snapshot";
            if (NeedsTopology && (snap.Modules == null || snap.Modules.Count == 0)) return "no topology scan available";
            if (NeedsDtcs && (snap.Dtcs == null || snap.Dtcs.Count == 0)) return "no DTCs captured";
            if (NeedsFleetStore && (ctx == null || ctx.Fleet == null)) return "fleet store not available";
            if (NeedsFixedByStore && (ctx == null || ctx.FixedBy == null)) return "fixed-by store not available";
            if (RequiredSignals != null && RequiredSignals.Count > 0)
            {
                foreach (var name in RequiredSignals)
                {
                    SignalSeries s;
                    if (!snap.TryGetSeries(name, out s) || !s.HasData)
                        return $"missing required signal '{name}'";
                    if (MinSamples > 0 && s.Count < MinSamples)
                        return $"signal '{name}' has {s.Count} samples, needs {MinSamples}";
                    if (MinSampleRateHz > 0 && s.EstimatedHz > 0 && s.EstimatedHz < MinSampleRateHz)
                        return $"signal '{name}' at {s.EstimatedHz:0.#} Hz, needs {MinSampleRateHz:0.#} Hz";
                }
            }
            else if (MinSamples > 0)
            {
                // A module that self-selects its signal (empty RequiredSignals — T2/T4/T6)
                // still declared a MinSamples floor.  Enforce it against the richest
                // captured signal so the declared config is not silently dead: at least
                // one signal must carry enough samples for the module to have anything
                // to analyse.
                int best = 0;
                if (snap.Signals != null)
                    foreach (var kv in snap.Signals)
                        if (kv.Value != null && kv.Value.Count > best) best = kv.Value.Count;
                if (best < MinSamples)
                    return $"no captured signal has {MinSamples} samples (richest has {best})";
            }
            return null;
        }
    }

    /// <summary>
    /// Ambient services handed to a module at Analyze time: the resolved
    /// platform calibration, the fleet + fixed-by stores (may be null), a log
    /// sink, and the active-control gate.  Modules read from it; they do not
    /// mutate the snapshot.
    /// </summary>
    public sealed class DiagnosticContext
    {
        public PlatformCalibration Calibration { get; set; }
        public IFleetStore Fleet { get; set; }
        public IFixedByStore FixedBy { get; set; }
        public Action<string> LogSink { get; set; }
        /// <summary>Host-set: whether the operator has authorised active-control tests this session.</summary>
        public bool AllowActiveControl { get; set; }
        /// <summary>Results produced by modules that already ran this pass.  The engine
        /// populates this incrementally so a composing module (M6 Bayesian, M7
        /// confirmation) can reason over earlier modules' hypotheses.  Never null.</summary>
        public IReadOnlyList<DiagnosticResult> PriorResults { get; set; } = Array.Empty<DiagnosticResult>();

        public void Log(string msg) { try { LogSink?.Invoke(msg); } catch { } }

        /// <summary>Convenience: is the resolved calibration validated for this platform?</summary>
        public bool IsCalibrated => Calibration != null && Calibration.IsValidated;
    }

    /// <summary>
    /// Every Tier-1 and Tier-2 module implements this.  Analyze is pure: given a
    /// snapshot and context it returns zero or more hypotheses.  It must never
    /// throw — a module that cannot run returns an empty list (the host logs the
    /// UnmetReason).  It must never call J2534 / UDS directly.
    /// </summary>
    public interface IDiagnosticModule
    {
        string ModuleId { get; }            // "M1", "T3"
        string DisplayName { get; }
        DiagnosticTier Tier { get; }
        DiagnosticRequirements Requirements { get; }
        IReadOnlyList<DiagnosticResult> Analyze(DiagnosticSnapshot snapshot, DiagnosticContext context);
    }

    /// <summary>Convenience base: implements the boilerplate and the safe-guard
    /// pattern (check requirements, catch exceptions) so concrete modules focus
    /// on the reasoning.  Override <see cref="AnalyzeCore"/>.</summary>
    public abstract class DiagnosticModuleBase : IDiagnosticModule
    {
        public abstract string ModuleId { get; }
        public abstract string DisplayName { get; }
        public abstract DiagnosticTier Tier { get; }
        public abstract DiagnosticRequirements Requirements { get; }

        public IReadOnlyList<DiagnosticResult> Analyze(DiagnosticSnapshot snapshot, DiagnosticContext context)
        {
            var ctx = context ?? new DiagnosticContext();
            try
            {
                string unmet = Requirements != null ? Requirements.UnmetReason(snapshot, ctx) : null;
                if (unmet != null)
                {
                    ctx.Log($"[{ModuleId}] skipped: {unmet}");
                    return Array.Empty<DiagnosticResult>();
                }
                var results = AnalyzeCore(snapshot, ctx) ?? Array.Empty<DiagnosticResult>();
                foreach (var r in results) { if (r != null) r.ModuleId = ModuleId; }
                return results;
            }
            catch (Exception ex)
            {
                ctx.Log($"[{ModuleId}] analyze error: {ex.Message}");
                return Array.Empty<DiagnosticResult>();
            }
        }

        protected abstract IReadOnlyList<DiagnosticResult> AnalyzeCore(DiagnosticSnapshot snapshot, DiagnosticContext context);

        /// <summary>Helper for concrete modules: build a result stamped with this module's id.</summary>
        protected DiagnosticResult NewResult(string title) =>
            new DiagnosticResult { ModuleId = ModuleId, Title = title };
    }

    // ── Store interfaces (concrete JSON-backed implementations are primitives P5/P6) ──

    /// <summary>Summary statistics of a fleet parameter cell.</summary>
    public struct FleetStat
    {
        public long Count;
        public double Mean;
        public double StdDev;
        public double Min;
        public double Max;
        public bool HasEnoughData(int min) => Count >= min;
    }

    /// <summary>
    /// Persistent per-platform parameter distributions, accumulated across
    /// sessions with Welford's algorithm and keyed by (platform, signal, cell).
    /// M4 (fleet baseline) and T3/T7 read from it.
    /// </summary>
    public interface IFleetStore
    {
        /// <summary>Record one observation into the running distribution for a cell.</summary>
        void Record(string platform, string signal, int cellX, int cellY, double value);
        /// <summary>Query the distribution for a cell; HasData=false via Count==0 if unseen.</summary>
        FleetStat Query(string platform, string signal, int cellX, int cellY);
        /// <summary>Total observations recorded for a platform+signal across all cells.</summary>
        long TotalObservations(string platform, string signal);
        /// <summary>Flush any buffered writes to disk.</summary>
        void Flush();
    }

    /// <summary>A recorded repair outcome for a symptom, feeding M6's priors.</summary>
    public sealed class FixOutcome
    {
        public string FixAction { get; set; }
        public int Count { get; set; }
        public int SuccessCount { get; set; }
        public double SuccessRate => Count > 0 ? (double)SuccessCount / Count : 0;
    }

    /// <summary>
    /// Persistent record of what fix resolved each symptom, per platform.  Feeds
    /// Bayesian priors into M6.  Keyed by (platform, symptomKey).
    /// </summary>
    public interface IFixedByStore
    {
        void Record(string platform, string symptomKey, string fixAction, bool success);
        IReadOnlyList<FixOutcome> Query(string platform, string symptomKey);
        void Flush();
    }
}
