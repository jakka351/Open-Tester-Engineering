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
//  Tester Present Specialist Automotive Solutions — M7 Bidirectional-Control Confirmation (Tier-1 composer)
//
//  M7 is a COMPOSING module: it does not invert raw signals itself.  It reads the
//  hypotheses that earlier modules (ideally M6, else the highest-confidence Tier-1
//  result) already produced and turns the leading one into a DECLARATIVE,
//  safety-gated ConfirmationScript — the single most discriminating active/observe
//  test that would confirm or refute that hypothesis.
//
//  It NEVER executes anything.  Every step is data: a UDS service id, an optional
//  request payload (a documented, platform-specific PLACEHOLDER — never an invented
//  dangerous routine id), and an ExpectedObservation.  The host runs the script
//  through the existing UDSManager + RcmSafetyGuard.  No step is ever built against
//  the Restraints Control Module / airbag: only observe-only or engine-side
//  active-control tests are catalogued.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using TesterPresent.OBD2.Intelligence;

namespace TesterPresent.OBD2.Intelligence.Tier1
{
    /// <summary>
    /// Turns the leading prior hypothesis into a safety-gated confirmation script
    /// (UDS 0x2F IOControl / 0x31 RoutineControl / 0x22 read).  Guidance only —
    /// Severity is Info/Low and the module never touches hardware.
    /// </summary>
    public sealed class BidirectionalConfirmModule : DiagnosticModuleBase
    {
        /// <summary>Fault families this module knows how to build a confirmation for.</summary>
        private enum FaultCategory
        {
            Unknown,
            VacuumLeak,
            WeakCylinder,
            FuelDelivery,
            MafError,
            BusFault,
        }

        private readonly DiagnosticRequirements _requirements = new DiagnosticRequirements
        {
            // No captured signals are required: M7 reasons over PriorResults only.
            RequiredSignals = new List<string>(),
            MayRecommendActiveControl = true,
        };

        /// <inheritdoc/>
        public override string ModuleId => "M7";
        /// <inheritdoc/>
        public override string DisplayName => "Bidirectional-Control Confirmation";
        /// <inheritdoc/>
        public override DiagnosticTier Tier => DiagnosticTier.Tier1;
        /// <inheritdoc/>
        public override DiagnosticRequirements Requirements => _requirements;

        /// <inheritdoc/>
        protected override IReadOnlyList<DiagnosticResult> AnalyzeCore(DiagnosticSnapshot snapshot, DiagnosticContext context)
        {
            var empty = Array.Empty<DiagnosticResult>();
            if (context == null || context.PriorResults == null || context.PriorResults.Count == 0)
                return empty; // nothing to confirm

            var parent = SelectParent(context.PriorResults);
            if (parent == null) return empty;

            var category = Classify(parent);
            if (category == FaultCategory.Unknown)
            {
                context.Log($"[{ModuleId}] no confirmation catalogued for '{parent.Title}'");
                return empty;
            }

            // ── Advisory honesty: read any threshold via calibration and track validation. ──
            bool usedUnvalidated = false;
            var cal = context.Calibration;
            double idleUpRpm = ReadCal(cal, "M7.IdleUpRpmDelta", 400.0, ref usedUnvalidated);
            double minRpmDrop = ReadCal(cal, "M7.CylinderCutRpmDrop", 100.0, ref usedUnvalidated);

            int cylinders = snapshot != null && snapshot.CylinderCount > 0 ? snapshot.CylinderCount : 4;

            ConfirmationScript script;
            switch (category)
            {
                case FaultCategory.VacuumLeak:   script = BuildIdleUpTrimScript(idleUpRpm); break;
                case FaultCategory.WeakCylinder: script = BuildInjectorCutScript(cylinders, minRpmDrop); break;
                case FaultCategory.FuelDelivery: script = BuildFuelPressureUnderLoadScript(); break;
                case FaultCategory.MafError:     script = BuildMafVsCalculatedScript(); break;
                case FaultCategory.BusFault:     script = BuildBusChecklistScript(); break;
                default:                         return empty;
            }
            if (script == null || script.Steps.Count == 0) return empty;

            int activeSteps = script.Steps.Count(s => s.IsActiveControl);
            bool needsArming = script.RequiresActiveControl;

            var result = NewResult($"Confirm: {parent.Title}");
            result.Hypothesis =
                $"The leading hypothesis is \"{parent.Title}\" ({parent.ConfidencePercent}% {parent.ConfidenceBand}). " +
                $"The single most discriminating next test is the '{script.Name}' sequence — " +
                (needsArming
                    ? $"{activeSteps} of {script.Steps.Count} steps command the ECU and require operator authorisation."
                    : $"all {script.Steps.Count} steps are observe-only and can run without arming.");
            result.Confidence = SignalMath.Clamp(parent.Confidence, 0, 1); // inherit the parent's confidence
            result.Severity = needsArming ? DiagnosticSeverity.Low : DiagnosticSeverity.Info; // guidance, not a fault
            result.NextTestScript = script;
            result.NextTest =
                $"Run '{script.Name}' ({script.Steps.Count} steps, {activeSteps} active) to confirm or refute: {parent.Title}.";

            // Carry the parent's suspects forward — these are what the script is testing.
            result.SuspectComponents = (parent.SuspectComponents != null && parent.SuspectComponents.Count > 0)
                ? new List<string>(parent.SuspectComponents)
                : new List<string> { "See parent hypothesis" };

            // ── Evidence chain: show WHY this script, not just WHAT to run. ──
            result.Evidence
                .Info("Leading hypothesis", parent.Title,
                      $"Source module {(string.IsNullOrEmpty(parent.ModuleId) ? "?" : parent.ModuleId)}, " +
                      $"confidence {parent.ConfidencePercent}%.")
                .Info("Mapped fault family", category.ToString(),
                      "Selected the confirmation script whose expected response separates this fault from its look-alikes.")
                .Info("Confirmation script", script.Name, script.Rationale);
            foreach (var step in script.Steps)
            {
                string svc = step.ServiceId == 0 ? "observe" : $"0x{step.ServiceId:X2}";
                result.Evidence.Info(
                    (step.IsActiveControl ? "ACTIVE " : "observe ") + svc,
                    step.Description,
                    step.ExpectedObservation);
            }

            // ── Advisory logic ──
            //  A script that commands the ECU (needsArming) is emitted with spec-seeded
            //  PLACEHOLDER routine/DID ids (0x0000) that the module's own contract says
            //  MUST be verified before arming.  That placeholder-verification advisory is
            //  INDEPENDENT of whether the operator has authorised active control or the
            //  platform is calibrated — dropping it just because AllowActiveControl is true
            //  would present unvalidated command bytes as trustworthy (the honesty rule).
            bool calMissing = cal == null || !context.IsCalibrated;
            var advisoryReasons = new List<string>();
            if (needsArming)
                advisoryReasons.Add(
                    "this sequence commands the ECU with spec-seeded PLACEHOLDER DID/routine ids (0x0000) that MUST be " +
                    "verified against the platform's service data before arming — idle only, park/neutral"
                    + (context.AllowActiveControl ? "" : "; active-control is not yet authorised for this session"));
            if (usedUnvalidated || calMissing)
                advisoryReasons.Add(
                    "confirmation thresholds are spec-seeded, not validated on this platform");
            if (advisoryReasons.Count > 0)
            {
                result.Advisory = true;
                result.AdvisoryReason = string.Join("; ", advisoryReasons);
            }

            return new List<DiagnosticResult> { result };
        }

        // ─────────────────────────────────────────────────────────────────────
        //  Parent selection + classification
        // ─────────────────────────────────────────────────────────────────────

        /// <summary>Prefer the highest-confidence M6 result; else the highest-confidence prior overall.
        /// Never selects an M7 result (it would confirm itself).</summary>
        private DiagnosticResult SelectParent(IReadOnlyList<DiagnosticResult> priors)
        {
            DiagnosticResult bestM6 = null, bestAny = null;
            foreach (var r in priors)
            {
                if (r == null) continue;
                if (string.Equals(r.ModuleId, ModuleId, StringComparison.OrdinalIgnoreCase)) continue;
                if (bestAny == null || r.Confidence > bestAny.Confidence) bestAny = r;
                if (string.Equals(r.ModuleId, "M6", StringComparison.OrdinalIgnoreCase))
                    if (bestM6 == null || r.Confidence > bestM6.Confidence) bestM6 = r;
            }
            return bestM6 ?? bestAny;
        }

        /// <summary>Map a prior result to a fault family by keyword-matching its title,
        /// hypothesis and suspects.  Order is significant: the most specific families
        /// are tested first so a fuel-trim result does not shadow a bus fault.</summary>
        private FaultCategory Classify(DiagnosticResult r)
        {
            string t = ((r.Title ?? "") + " | " + (r.Hypothesis ?? "") + " | " +
                        (r.SuspectComponents != null ? string.Join(" ", r.SuspectComponents) : ""))
                       .ToLowerInvariant();

            // "bus" as a whole word only — as a substring it lives inside "com-BUS-tion",
            // which would hijack a weak-cylinder / detonation hypothesis into a bus-fault
            // confirmation (a 60Ω-terminator checklist instead of an injector-cut test).
            if (ContainsWord(t, "bus") || Any(t, "gateway", "communication", "comm fault", "network fault", "branch", "u0"))
                return FaultCategory.BusFault;
            if (Any(t, "misfire", "cylinder", "compression", "idle instability", "roughness", "weak cyl", "dead cyl"))
                return FaultCategory.WeakCylinder;
            if (Any(t, "vacuum", "intake-air leak", "intake air leak", "unmetered air", "low-load-dominant"))
                return FaultCategory.VacuumLeak;
            if (Any(t, "maf", "mass air", "mass airflow", "calculated airflow", "air-mass"))
                return FaultCategory.MafError;
            if (Any(t, "fuel-delivery", "fuel delivery", "fuel pressure", "fuel-pressure", "fuel rail",
                       "shortfall", "high-load-dominant", "metering", "fuel trim", "fuel-trim", "lean"))
                return FaultCategory.FuelDelivery;

            return FaultCategory.Unknown;
        }

        private static bool Any(string haystack, params string[] needles)
        {
            for (int i = 0; i < needles.Length; i++)
                if (haystack.IndexOf(needles[i], StringComparison.Ordinal) >= 0) return true;
            return false;
        }

        /// <summary>True if <paramref name="needle"/> occurs as a whole word (edges at a
        /// non-alphanumeric boundary) — so "bus" is not matched inside "combustion".</summary>
        private static bool ContainsWord(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle) || string.IsNullOrEmpty(haystack)) return false;
            int idx = 0;
            while ((idx = haystack.IndexOf(needle, idx, StringComparison.Ordinal)) >= 0)
            {
                bool leftOk = idx == 0 || !char.IsLetterOrDigit(haystack[idx - 1]);
                int end = idx + needle.Length;
                bool rightOk = end >= haystack.Length || !char.IsLetterOrDigit(haystack[end]);
                if (leftOk && rightOk) return true;
                idx += 1;
            }
            return false;
        }

        private static double ReadCal(PlatformCalibration cal, string key, double fallback, ref bool usedUnvalidated)
        {
            if (cal == null) { usedUnvalidated = true; return fallback; }
            double v = cal.Value(key, fallback, out bool validated);
            if (!validated) usedUnvalidated = true;
            return v;
        }

        // ─────────────────────────────────────────────────────────────────────
        //  Confirmation-script catalog
        //
        //  Every Payload below is a DECLARATIVE PLACEHOLDER.  The exact DID /
        //  routine id is platform-specific and MUST be verified against service
        //  data before the host arms the step.  No dangerous / RCM payload is ever
        //  emitted here.
        // ─────────────────────────────────────────────────────────────────────

        /// <summary>Vacuum leak / lean-at-idle: raise idle and watch LTFT collapse toward zero.</summary>
        private ConfirmationScript BuildIdleUpTrimScript(double idleUpRpm)
        {
            int rpm = (int)Math.Round(idleUpRpm);
            return new ConfirmationScript
            {
                Name = "Idle-up trim response",
                Rationale =
                    "A vacuum/unmetered-air leak is a fixed air mass: as commanded idle rises and manifold pressure " +
                    "climbs, the leak becomes a smaller fraction of total airflow, so the positive long-term fuel trim " +
                    "shrinks toward 0. A true fuel-metering fault (injector, pressure) scales with load and does not " +
                    "recover. This one manipulation separates the two.",
                Steps =
                {
                    new ConfirmationStep
                    {
                        Description = "Read LTFT bank 1 baseline at stable idle.",
                        ServiceId = 0x22,          // observe-only read; no ECU command
                        Payload = null,
                        IsActiveControl = false,
                        ExpectedObservation = "Record the baseline positive LTFT_B1 (the lean-driven correction) at idle.",
                    },
                    new ConfirmationStep
                    {
                        Description = $"Command idle up ~+{rpm} rpm via IOControl (or an idle-RPM routine).",
                        ServiceId = 0x2F,          // 0x2F IOControl — commands the ECU
                        // PLACEHOLDER: 0x2F IOControl, DID 0x0000, controlOption 0x03 (shortTermAdjustment),
                        // target idle delta encoded big-endian. Exact DID/routine is platform-specific — verify first.
                        Payload = new byte[] { 0x2F, 0x00, 0x00, 0x03, (byte)((rpm >> 8) & 0xFF), (byte)(rpm & 0xFF) },
                        IsActiveControl = true,
                        RequiresPowertrainTarget = true, // idle-up commands the engine PCM only
                        ExpectedObservation = $"Engine idle should rise by roughly {rpm} rpm and stabilise.",
                    },
                    new ConfirmationStep
                    {
                        Description = "Re-read LTFT bank 1 at the raised idle.",
                        ServiceId = 0x22,          // observe-only read
                        Payload = null,
                        IsActiveControl = false,
                        ExpectedObservation =
                            "A vacuum leak's positive LTFT shrinks toward 0 as manifold pressure rises; a fuel-metering " +
                            "fault does not.",
                    },
                },
            };
        }

        /// <summary>Weak/dead cylinder: cut each injector in turn and compare the RPM drop.</summary>
        private ConfirmationScript BuildInjectorCutScript(int cylinders, double minRpmDrop)
        {
            int drop = (int)Math.Round(minRpmDrop);
            var script = new ConfirmationScript
            {
                Name = "Cylinder-balance injector cut",
                Rationale =
                    "Cutting a healthy cylinder removes its contribution and drops idle RPM by a repeatable amount. A " +
                    "weak or dead cylinder was already contributing little, so cutting it drops RPM less than its mates. " +
                    "Ranking the per-cylinder drop isolates the offender. Injector cut targets the engine PCM only — " +
                    "never the Restraints Control Module.",
            };
            for (int cyl = 1; cyl <= cylinders; cyl++)
            {
                script.Steps.Add(new ConfirmationStep
                {
                    Description = $"Cut injector on cylinder {cyl} and hold, then release.",
                    ServiceId = 0x31,              // 0x31 RoutineControl start — commands the ECU (engine PCM)
                    // PLACEHOLDER: 0x31 startRoutine 0x01, injector-cut routine id 0x0000, cylinder index in the
                    // last byte. Exact routine id is platform-specific — verify against service data before arming.
                    Payload = new byte[] { 0x31, 0x01, 0x00, 0x00, (byte)cyl },
                    IsActiveControl = true,
                    RequiresPowertrainTarget = true, // injector cut targets the engine PCM only — never the RCM or any other module
                    ExpectedObservation =
                        $"A healthy cylinder drops idle by roughly ≥{drop} rpm; a weak/dead cylinder shows a smaller " +
                        "RPM drop than its mates when cut.",
                });
            }
            return script;
        }

        /// <summary>Fuel-delivery shortfall: observe rail pressure under demand (active load needs a dyno).</summary>
        private ConfirmationScript BuildFuelPressureUnderLoadScript()
        {
            return new ConfirmationScript
            {
                Name = "Fuel-pressure under load",
                Rationale =
                    "A delivery shortfall (pump, filter, regulator) holds pressure at idle but sags when demand rises. " +
                    "Loading the engine safely requires the vehicle on a dyno or a road test — no ECU command is issued " +
                    "here, so these steps are observe-only and safe to run as-is.",
                Steps =
                {
                    new ConfirmationStep
                    {
                        Description = "Read fuel-rail pressure and STFT/LTFT at idle (baseline).",
                        ServiceId = 0x22,
                        Payload = null,
                        IsActiveControl = false,
                        ExpectedObservation = "Rail pressure should sit at spec and fuel trims near their idle baseline.",
                    },
                    new ConfirmationStep
                    {
                        Description = "Repeat the read under high demand (dyno load or road WOT) — operator-driven, not commanded.",
                        ServiceId = 0x22,
                        Payload = null,
                        IsActiveControl = false,
                        ExpectedObservation =
                            "A delivery fault shows rail pressure sagging below spec and STFT swinging positive under " +
                            "load, while trims stay flat if delivery is adequate. NOTE: applying load requires " +
                            "throttle/dyno; do not command load via the ECU.",
                    },
                },
            };
        }

        /// <summary>MAF error: compare measured airflow against airflow calculated from MAP/RPM/IAT (speed-density).</summary>
        private ConfirmationScript BuildMafVsCalculatedScript()
        {
            return new ConfirmationScript
            {
                Name = "MAF vs calculated airflow",
                Rationale =
                    "A drifting MAF reads a plausible but wrong air mass. Cross-checking the measured MAF against the " +
                    "airflow calculated from MAP, RPM, IAT and displacement (speed-density) exposes the disagreement. " +
                    "Observe-only — no ECU command, safe to run without arming.",
                Steps =
                {
                    new ConfirmationStep
                    {
                        Description = "Read MAF (g/s) and MAP, RPM, IAT at several steady operating points.",
                        ServiceId = 0x22,
                        Payload = null,
                        IsActiveControl = false,
                        ExpectedObservation = "Capture matched MAF and speed-density inputs at idle, part-throttle and cruise.",
                    },
                    new ConfirmationStep
                    {
                        Description = "Compare measured MAF against the speed-density calculated airflow.",
                        ServiceId = 0x00,          // pure comparison — no bus traffic
                        Payload = null,
                        IsActiveControl = false,
                        ExpectedObservation =
                            "A healthy MAF tracks calculated airflow within tolerance across the range; a drifting/dirty " +
                            "MAF diverges (typically reads low at high flow).",
                    },
                },
            };
        }

        /// <summary>Bus fault: physical + gateway checklist. Observe-only — no active control, runs without arming.</summary>
        private ConfirmationScript BuildBusChecklistScript()
        {
            return new ConfirmationScript
            {
                Name = "60Ω terminator + gateway check",
                Rationale =
                    "A shared-bus comm fault is physical or topological, not a parameter. Measuring the terminator " +
                    "resistance and confirming the gateway still forwards to the affected segment localises it. All " +
                    "checks are observe-only — no ECU is commanded, so no arming is required.",
                Steps =
                {
                    new ConfirmationStep
                    {
                        Description = "Key off: measure CAN-H to CAN-L resistance at the DLC (expect ~60Ω = two 120Ω terminators).",
                        ServiceId = 0x00,          // bench meter measurement, not a bus command
                        Payload = null,
                        IsActiveControl = false,
                        ExpectedObservation =
                            "~60Ω = both terminators present. ~120Ω = one terminator/branch open. <50Ω or ~0 = shorted " +
                            "pair. Open/very high = backbone break.",
                    },
                    new ConfirmationStep
                    {
                        Description = "Key on: re-scan the segment and confirm the gateway still forwards frames to it.",
                        ServiceId = 0x00,
                        Payload = null,
                        IsActiveControl = false,
                        ExpectedObservation =
                            "If modules on the other side of the gateway respond but this segment stays dark, suspect the " +
                            "gateway's forwarding to this branch rather than the modules themselves.",
                    },
                },
            };
        }
    }
}
