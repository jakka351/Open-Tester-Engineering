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
//  Tester Present Specialist Automotive Solutions — Diagnostic Intelligence Self-Test
//
//  Synthetic-fault harness for the diagnostic-intelligence layer.  Following the
//  repo convention (no unit-test framework; known-answer self-tests live in-code,
//  cf. tps_self_test), this builds DiagnosticSnapshots with KNOWN injected faults
//  and asserts that the right module fires — and, crucially, that a HEALTHY
//  snapshot produces no false positives.
//
//  Per CLAUDE.md, passing this harness is a SMOKE TEST, not a passing grade: the
//  emulator/synthetic layer answers cleanly with no immune system.  Real-vehicle
//  validation against a characterised fault is still required before any module
//  is considered production-validated.
//
//  Call DiagnosticIntelligenceSelfTest.Run() — returns a report; wire it to a
//  dev-menu item or run it ad hoc.  It uses in-memory stub stores so it never
//  touches the on-disk fleet/fixed-by files.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TesterPresent.OBD2.Intelligence
{
    /// <summary>One synthetic-fault case and its expected outcome.</summary>
    public sealed class SelfTestCase
    {
        public string Name;
        public bool Passed;
        public string Detail;
    }

    /// <summary>Aggregate result of a self-test run.</summary>
    public sealed class SelfTestReport
    {
        public List<SelfTestCase> Cases { get; } = new List<SelfTestCase>();
        public int Passed => Cases.Count(c => c.Passed);
        public int Total => Cases.Count;
        public bool AllPassed => Cases.All(c => c.Passed);

        public string Render()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Diagnostic Intelligence self-test: {Passed}/{Total} passed");
            sb.AppendLine(new string('-', 60));
            foreach (var c in Cases)
                sb.AppendLine($"[{(c.Passed ? "PASS" : "FAIL")}] {c.Name}{(string.IsNullOrEmpty(c.Detail) ? "" : "  — " + c.Detail)}");
            return sb.ToString();
        }
    }

    public static class DiagnosticIntelligenceSelfTest
    {
        private static DateTime T0 = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static SelfTestReport Run()
        {
            IntelligenceBootstrap.EnsureRegistered();
            var report = new SelfTestReport();

            // ── Healthy baseline must produce NO fuel/crank findings (no false positives) ──
            {
                var engine = NewEngine(out _, out _);
                var snap = HealthyIdle();
                var run = engine.Run(snap);
                bool anyFuelOrCrank = run.Results.Any(r => r.ModuleId == "M1" || r.ModuleId == "M2");
                Add(report, "Healthy idle → no M1/M2 false positive", !anyFuelOrCrank,
                    anyFuelOrCrank ? "false positive: " + string.Join(",", run.Results.Select(r => r.ModuleId)) : "clean");
            }

            // ── M1: vacuum-leak signature (lean at idle, normal under load) ──
            {
                var engine = NewEngine(out _, out _);
                var run = engine.Run(VacuumLeakSurface());
                var m1 = run.Results.FirstOrDefault(r => r.ModuleId == "M1");
                string t1 = ((m1?.Title ?? "") + " " + (m1?.Hypothesis ?? "")).ToLowerInvariant();
                bool ok = m1 != null && (t1.Contains("vacuum") || t1.Contains("intake") || t1.Contains("unmetered") || t1.Contains("leak"));
                Add(report, "M1 vacuum-leak surface fires", ok, m1?.Hypothesis ?? "M1 silent");
            }

            // ── M1: uniform lean drift (MAF/fuel bias) ──
            {
                var engine = NewEngine(out _, out _);
                var run = engine.Run(UniformLeanSurface());
                var m1 = run.Results.FirstOrDefault(r => r.ModuleId == "M1");
                string h1 = ((m1?.Title ?? "") + " " + (m1?.Hypothesis ?? "")).ToLowerInvariant();
                bool ok = m1 != null && (h1.Contains("uniform") || h1.Contains("global") || h1.Contains("metering") || h1.Contains("bias"));
                Add(report, "M1 uniform-drift fires with the right class", ok, m1?.Hypothesis ?? "M1 silent");
            }

            // ── M2: uneven-compression cranking ripple ──
            {
                var engine = NewEngine(out _, out _);
                var run = engine.Run(UnevenCompressionCrank());
                var m2 = run.Results.FirstOrDefault(r => r.ModuleId == "M2");
                bool ok = m2 != null && (m2.Hypothesis ?? "").ToLowerInvariant().Contains("compression");
                Add(report, "M2 uneven-compression fires", ok, m2?.Hypothesis ?? "M2 silent");
            }

            // ── M3: shared-bus U-code cluster ──
            {
                var engine = NewEngine(out _, out _);
                var run = engine.Run(SharedBusFault());
                var m3 = run.Results.FirstOrDefault(r => r.ModuleId == "M3");
                bool ok = m3 != null && (m3.Hypothesis ?? "").ToLowerInvariant().Contains("bus");
                Add(report, "M3 shared-bus fault localizes", ok, m3?.Hypothesis ?? "M3 silent");
            }

            // ── M5: intermittent dropout ──
            {
                var engine = NewEngine(out _, out _);
                var run = engine.Run(MafDropout());
                var m5 = run.Results.FirstOrDefault(r => r.ModuleId == "M5");
                bool ok5 = m5 != null && ((m5.Title ?? "") + " " + (m5.Hypothesis ?? "")).ToLowerInvariant().Contains("dropout");
                Add(report, "M5 intermittent dropout fires with the right class", ok5, m5?.Hypothesis ?? "M5 silent");
            }

            // ── M4: fleet outlier (stub store primed) ──
            {
                var engine = NewEngine(out var fleet, out _);
                // Prime the fleet: healthy LTFT ~2% at the idle cell.
                var grid = new OperatingPointGrid(6, 6, 500, 6500, 0, 100);
                var (cx, cy) = grid.CellOf(750, 25);
                for (int i = 0; i < 40; i++) fleet.Record("Generic", CanonicalSignals.LtftB1, cx, cy, 2 + (i % 5) - 2);
                var run = engine.Run(FleetOutlier());
                var m4any = run.Results.FirstOrDefault(r => r.ModuleId == "M4");
                string h4 = (m4any?.Hypothesis ?? "").ToLowerInvariant();
                bool ok = m4any != null && (h4.Contains("outlier") || h4.Contains("anomaly") || h4.Contains("fleet"))
                          && m4any.Severity != DiagnosticSeverity.Info; // a real outlier, not the cold-start info
                Add(report, "M4 fleet outlier fires (primed store)", ok, m4any?.Hypothesis ?? "M4 silent");
            }

            // ── M6: Bayesian composition ranks a top hypothesis ──
            {
                var engine = NewEngine(out _, out _);
                var run = engine.Run(VacuumLeakSurface(withLeanDtc: true));
                var m6 = run.Results.FirstOrDefault(r => r.ModuleId == "M6");
                bool ok6 = m6 != null && (m6.Hypothesis ?? "").ToLowerInvariant().Contains("posterior")
                           && m6.Evidence != null && m6.Evidence.Steps.Any(st => (st.Signal ?? "").ToLowerInvariant().Contains("entropy"));
                Add(report, "M6 Bayesian composes a ranked hypothesis with entropy", ok6, m6?.Hypothesis ?? "M6 silent");
            }

            // ── T2: analytical redundancy (MAF vs speed-density) ──
            {
                var engine = NewEngine(out _, out _);
                var run = engine.Run(MafUnderReport());
                var t2 = run.Results.FirstOrDefault(r => r.ModuleId == "T2");
                string h2 = ((t2?.Title ?? "") + " " + (t2?.Hypothesis ?? "")).ToLowerInvariant();
                bool ok2 = t2 != null && (h2.Contains("maf") || h2.Contains("metering") || h2.Contains("air-metering"));
                Add(report, "T2 air-metering inconsistency fires with the right class", ok2, t2?.Hypothesis ?? "T2 silent");
            }

            // ── T5: weak battery under crank ──
            {
                var engine = NewEngine(out _, out _);
                var run = engine.Run(WeakBatteryCrank());
                var t5 = run.Results.FirstOrDefault(r => r.ModuleId == "T5");
                string h5 = ((t5?.Title ?? "") + " " + (t5?.Hypothesis ?? "")).ToLowerInvariant();
                bool ok5b = t5 != null && (h5.Contains("battery") || h5.Contains("crank"));
                Add(report, "T5 weak-battery fires with the right class", ok5b, t5?.Hypothesis ?? "T5 silent");
            }

            // ── T8: honest gate — OBD-rate RPM cannot reconstruct pressure ──
            //  Uses ≥64 RPM samples so T8 actually REACHES the sample-rate gate (HealthyIdle's
            //  60 samples fell short of MIN_SAMPLES and the module returned before the gate,
            //  so the old assertion never exercised what it claimed).
            {
                var engine = NewEngine(out _, out _);
                var run = engine.Run(ObdRateCrankStream());
                var t8 = run.Results.FirstOrDefault(r => r.ModuleId == "T8");
                bool ok = t8 != null && t8.Advisory && t8.Severity == DiagnosticSeverity.Info
                          && (t8.Hypothesis ?? "").ToLowerInvariant().Contains("rate");
                Add(report, "T8 reaches the sample-rate gate and reports unavailable (not a fabricated cylinder fault)",
                    ok, t8?.Hypothesis ?? "T8 silent");
            }

            // ── Capture profiles catalog is populated ──
            Add(report, "Capture profiles catalog populated",
                UI.CaptureProfileCatalog.All.Count >= 4 && UI.CaptureProfileCatalog.Default != null,
                UI.CaptureProfileCatalog.All.Count + " profiles");

            // ── SAFETY: confirmation runner HARD-BLOCKS active control at a restraints module ──
            // (txId 0x737 = RCM; never reaches SendRequest, so a null transport is safe to test with.)
            {
                var uds = new TesterPresent.OBD2.UDS.UDSManager(null, 0x737, 0x73F);
                var runner = new UI.ConfirmationRunner(uds);
                var script = ActiveStepScript(0x2F, new byte[] { 0x2F, 0x00, 0x01, 0x03 });
                bool sendAttempted = false;
                var res = runner.Run(script, armed: true, req => { sendAttempted = true; return true; }, null);
                bool blocked = res.Count == 1 && res[0].Outcome == UI.StepOutcome.BlockedRestraints && !sendAttempted;
                Add(report, "Confirmation HARD-BLOCKS RCM active control", blocked,
                    res.Count > 0 ? res[0].Outcome.ToString() : "no result");
            }

            // ══ REGRESSION guards for the confirmed adversarial-review defects ══

            // M1 gate (c): a global lean bias with a mild upward gradient must NOT
            // also emit a "fuel-delivery shortfall" (idle is itself lean here).
            {
                var engine = NewEngine(out _, out _);
                var run = engine.Run(UniformLeanGradient());
                bool shortfall = run.Results.Any(r => r.ModuleId == "M1" &&
                    ((r.Title ?? "") + (r.Hypothesis ?? "")).ToLowerInvariant().Contains("shortfall"));
                bool uniform = run.Results.Any(r => r.ModuleId == "M1");
                Add(report, "M1 global lean bias does NOT false-fire fuel-delivery shortfall", uniform && !shortfall,
                    shortfall ? "spurious shortfall emitted" : "uniform only");
            }

            // M2: a healthy start-up (even cranking + catch ramp toward idle) must NOT
            // fire uneven-compression — the ramp must not inflate the cranking CoV.
            {
                var engine = NewEngine(out _, out _);
                var run = engine.Run(HealthyCrankCatch());
                bool comp = run.Results.Any(r => r.ModuleId == "M2" &&
                    ((r.Title ?? "") + (r.Hypothesis ?? "")).ToLowerInvariant().Contains("compression"));
                Add(report, "M2 healthy crank+catch ramp does NOT false-fire compression", !comp,
                    comp ? "spurious compression fault" : "clean");
            }

            // M3: an acronym-substring collision (EBCM vs BCM on different buses) must
            // NOT be mis-called a shared-bus fault.
            {
                var engine = NewEngine(out _, out _);
                var run = engine.Run(CrossBusNotShared());
                var m3 = run.Results.FirstOrDefault(r => r.ModuleId == "M3");
                bool sharedBus = m3 != null && (m3.Title ?? "").ToLowerInvariant().Contains("shared-bus");
                Add(report, "M3 cross-bus (EBCM/BCM) is NOT mis-called shared-bus", m3 != null && !sharedBus,
                    m3?.Title ?? "M3 silent");
            }

            // M5: an engine-off RPM=0 tail must NOT be flagged as a stuck sensor.
            {
                var engine = NewEngine(out _, out _);
                var run = engine.Run(EngineOffZeroTail());
                bool stuck = run.Results.Any(r => r.ModuleId == "M5" &&
                    ((r.Title ?? "") + (r.Hypothesis ?? "")).ToLowerInvariant().Contains("stuck"));
                Add(report, "M5 engine-off zero tail is NOT flagged stuck", !stuck,
                    stuck ? "spurious stuck-sensor" : "clean");
            }

            // T4: a healthy damped transient (few peaks) must NOT be called a sustained limit cycle.
            {
                var engine = NewEngine(out _, out _);
                var run = engine.Run(DampedTransient());
                bool sustained = run.Results.Any(r => r.ModuleId == "T4" &&
                    ((r.Title ?? "") + (r.Hypothesis ?? "")).ToLowerInvariant().Contains("sustain"));
                Add(report, "T4 damped transient is NOT called a sustained limit cycle", !sustained,
                    sustained ? "spurious sustained-oscillation" : "clean");
            }

            // Air metering: a SPEED-DENSITY engine (MAP, no MAF) must NOT receive a
            // MAF verdict from T2/T3 — there is no MAF to be wrong.
            {
                var engine = NewEngine(out _, out _);
                var run = engine.Run(SpeedDensityNoMaf());
                bool mafVerdict = run.Results.Any(r => (r.ModuleId == "T2" || r.ModuleId == "T3") &&
                    (int)r.Severity >= (int)DiagnosticSeverity.Medium &&
                    ((r.Hypothesis ?? "") + (r.Title ?? "")).ToLowerInvariant().Contains("maf"));
                Add(report, "Speed-density engine gets no bogus MAF verdict (T2/T3)", !mafVerdict,
                    mafVerdict ? "MAF verdict leaked on a MAF-less engine" : "suppressed");
            }

            // ── SAFETY: confirmation runner skips active steps when NOT armed ──
            {
                var uds = new TesterPresent.OBD2.UDS.UDSManager(null, 0x7E0, 0x7E8); // PCM, not RCM
                var runner = new UI.ConfirmationRunner(uds);
                var script = ActiveStepScript(0x2F, new byte[] { 0x2F, 0x00 });
                bool confirmCalled = false;
                var res = runner.Run(script, armed: false, req => { confirmCalled = true; return true; }, null);
                bool skipped = res.Count == 1 && res[0].Outcome == UI.StepOutcome.SkippedNotArmed && !confirmCalled;
                Add(report, "Confirmation skips active step when not armed", skipped,
                    res.Count > 0 ? res[0].Outcome.ToString() : "no result");
            }

            // ══ REGRESSION guards for the full-layer audit fixes (2026-07) ══

            // SAFETY: an engine/powertrain-only active step (injector cut) must be HARD-BLOCKED
            // when the live transport is a non-powertrain module (ABS 0x760), never sent.
            {
                var uds = new TesterPresent.OBD2.UDS.UDSManager(null, 0x760, 0x768); // ABS, not powertrain
                var runner = new UI.ConfirmationRunner(uds);
                var script = new ConfirmationScript
                {
                    Name = "engine-only",
                    Steps = new List<ConfirmationStep>
                    {
                        new ConfirmationStep { Description = "injector cut", ServiceId = 0x31,
                            Payload = new byte[] { 0x31, 0x01, 0x00, 0x00, 0x01 },
                            IsActiveControl = true, RequiresPowertrainTarget = true, ExpectedObservation = "n/a" }
                    }
                };
                bool sendAttempted = false;
                var res = runner.Run(script, armed: true, req => { sendAttempted = true; return true; }, null);
                bool blocked = res.Count == 1 && res[0].Outcome == UI.StepOutcome.BlockedWrongTarget && !sendAttempted;
                Add(report, "Confirmation HARD-BLOCKS an engine-only active step at a non-powertrain target", blocked,
                    res.Count > 0 ? res[0].Outcome.ToString() : "no result");
            }

            // M1: a single suspicious operating point must report INSUFFICIENT surface
            // coverage (Info), never a confident uniform-bias verdict from one cell.
            {
                var engine = NewEngine(out _, out _);
                var s = Base();
                for (int i = 0; i < 40; i++)
                {
                    s.AddSignal(CanonicalSignals.Rpm, 750, T0.AddSeconds(i * 0.05));
                    s.AddSignal(CanonicalSignals.EngineLoad, 25, T0.AddSeconds(i * 0.05));
                    s.AddSignal(CanonicalSignals.StftB1, 3, T0.AddSeconds(i * 0.05));
                    s.AddSignal(CanonicalSignals.LtftB1, 27, T0.AddSeconds(i * 0.05)); // very lean, but ONE cell
                }
                var run = engine.Run(s);
                var m1 = run.Results.FirstOrDefault(r => r.ModuleId == "M1");
                bool ok = m1 != null && m1.Severity == DiagnosticSeverity.Info
                          && ((m1.Title ?? "") + (m1.Hypothesis ?? "")).ToLowerInvariant().Contains("under-sampled");
                Add(report, "M1 single suspicious cell reports insufficient (not a confident uniform verdict)", ok,
                    m1?.Title ?? "M1 silent");
            }

            // T6: a Ford "KR" (knock retard, degrees) channel must NOT be order-analysed as
            // vibration (no spurious mechanical-knock hypothesis); a sustained high retard
            // must instead surface as detonation.
            {
                var engine = NewEngine(out _, out _);
                var s = Base();
                Fill(s, CanonicalSignals.Rpm, i => 2500 + (i % 8), 64, 10);
                Fill(s, "KR", i => 9.0 + (i % 3) * 0.5, 64, 10); // knock retard degrees, sustained ~9–10°
                var run = engine.Run(s);
                bool mechanical = run.Results.Any(r => r.ModuleId == "T6" &&
                    ((r.Title ?? "") + (r.Hypothesis ?? "")).ToLowerInvariant().Contains("order-domain knock"));
                bool detonation = run.Results.Any(r => r.ModuleId == "T6" &&
                    (r.Title ?? "").ToLowerInvariant().Contains("detonation"));
                Add(report, "T6 KR degrees is not order-analysed as vibration; surfaces as detonation", !mechanical && detonation,
                    mechanical ? "spurious mechanical knock from a degrees channel" : (detonation ? "detonation" : "T6 silent"));
            }

            // T5: a resting battery with NO RPM captured (~12.5 V) must NOT be called
            // undercharging — the engine-off case that the voltage-inferred fallback
            // previously mislabelled.
            {
                var engine = NewEngine(out _, out _);
                var s = Base();
                Fill(s, CanonicalSignals.BatteryVoltage, i => 12.5 + ((i % 3) - 1) * 0.02, 40, 5);
                var run = engine.Run(s);
                bool undercharge = run.Results.Any(r => r.ModuleId == "T5" &&
                    ((r.Title ?? "") + (r.Hypothesis ?? "")).ToLowerInvariant().Contains("undercharg"));
                Add(report, "T5 resting battery with no RPM is NOT called undercharging", !undercharge,
                    undercharge ? "false undercharge on an engine-off battery" : "clean");
            }

            // ══ DATA-WIREUP guards (Phases A/B/C: real DBs feed DIAGINTEL) ══

            // Phase A: the CAN-Topographer bridge maps TopoNodes → real modules (bus,
            // gateway) + DTCs with real descriptions (not the raw code echoed back).
            {
                var s = Base();
                s.Oem = OEMManufacturer.Generic;
                var nodes = new List<TesterPresent.OBD2.Controls.NetworkTopologyPanel.TopoNode>
                {
                    new TesterPresent.OBD2.Controls.NetworkTopologyPanel.TopoNode
                    {
                        TxId = 0x7E0, RxId = 0x7E8, Name = "PCM",
                        Network = TesterPresent.OBD2.Controls.NetworkTopologyPanel.CanBus.HighSpeed,
                        DTCCount = 1, DTCDisplayCodes = new List<string> { "P0301" }, DTCStatusBytes = new List<byte> { 0x08 },
                    },
                    new TesterPresent.OBD2.Controls.NetworkTopologyPanel.TopoNode
                    {
                        TxId = 0x726, RxId = 0x72E, Name = "BCM", IsBridge = true,
                        Network = TesterPresent.OBD2.Controls.NetworkTopologyPanel.CanBus.MidSpeed,
                    },
                };
                UI.TopologyBridge.Apply(s, nodes);
                bool busOk = s.Modules.Count == 2
                             && s.Modules.Any(m => m.TxId == 0x7E0 && m.Bus == VehicleBus.HsCan)
                             && s.Modules.Any(m => m.TxId == 0x726 && m.Bus == VehicleBus.MsCan && m.IsGateway);
                bool dtcOk = s.Dtcs.Count == 1
                             && !string.IsNullOrEmpty(s.Dtcs[0].Description)
                             && !string.Equals(s.Dtcs[0].Description.Trim(), "P0301", StringComparison.OrdinalIgnoreCase);
                Add(report, "TopologyBridge maps TopoNodes → real bus/gateway + described DTCs", busOk && dtcOk,
                    busOk ? (dtcOk ? "modules+DTC described" : "DTC not described: " + (s.Dtcs.Count > 0 ? s.Dtcs[0].Description : "none"))
                          : "module/bus mapping wrong");
            }

            // Phase C: a measured DEAD bus raises M3's shared-bus confidence; a HEALTHY bus
            // softens it (points back at the modules).
            {
                var mBase = NewEngine(out _, out _).Run(SharedBusFault()).Results.FirstOrDefault(r => r.ModuleId == "M3");

                var sDead = SharedBusFault();
                sDead.AddBusHealth(new BusHealth { Bus = VehicleBus.HsCan, State = BusHealthState.Dead, Verdict = "bus dead" });
                var mDead = NewEngine(out _, out _).Run(sDead).Results.FirstOrDefault(r => r.ModuleId == "M3");

                var sHealthy = SharedBusFault();
                sHealthy.AddBusHealth(new BusHealth { Bus = VehicleBus.HsCan, State = BusHealthState.Healthy, Verdict = "bus healthy" });
                var mHealthy = NewEngine(out _, out _).Run(sHealthy).Results.FirstOrDefault(r => r.ModuleId == "M3");

                bool ok = mBase != null && mDead != null && mHealthy != null
                          && mDead.Confidence > mBase.Confidence
                          && mHealthy.Severity == DiagnosticSeverity.Medium;
                Add(report, "M3 consumes bus-health: dead raises confidence, healthy softens severity", ok,
                    mBase != null ? $"base {mBase.Confidence:0.00} / dead {mDead?.Confidence:0.00} / healthy sev {mHealthy?.Severity}" : "M3 silent");
            }

            // Phase B: a validated calibration override promotes that key out of advisory,
            // while un-overridden base keys stay spec-seeded (advisory).
            {
                var baseCal = new FordFgCalibration();
                var overrides = new Dictionary<string, CalibrationValue>(StringComparer.OrdinalIgnoreCase)
                {
                    { "M1.SuspiciousTrimPct", new CalibrationValue(11.0, true, "bench-validated") },
                };
                var db = new DbBackedPlatformCalibration(baseCal, overrides);
                double vOverride = db.Value("M1.SuspiciousTrimPct", 99.0, out bool validatedOverride);
                db.Value("M1.NormalTrimPct", 99.0, out bool validatedBase);
                bool ok = Math.Abs(vOverride - 11.0) < 1e-9 && validatedOverride && !validatedBase;
                Add(report, "DB-backed calibration promotes a validated override, keeps base keys advisory", ok,
                    $"override validated={validatedOverride}, base validated={validatedBase}");
            }

            // Bus-resistance classifier: ~60Ω is in-range (evidence only, State=Unknown so it
            // does NOT soften M3 — a jammed bus reads a perfect 60Ω); ~120Ω = one terminator
            // lost (Degraded); ~0 = short (Dead); OL = open (Dead).
            {
                var c60 = UI.BusResistance.Classify(60, 2);
                var c120 = UI.BusResistance.Classify(120, 2);
                var c5 = UI.BusResistance.Classify(5, 2);
                var cOL = UI.BusResistance.Classify(UI.BusResistance.OPEN_OHMS, 2);
                bool ok = c60.InRange && c60.State == BusHealthState.Unknown
                          && c120.State == BusHealthState.Degraded && !c120.InRange
                          && c5.State == BusHealthState.Dead
                          && cOL.State == BusHealthState.Dead;
                Add(report, "Bus-resistance classifier: 60Ω in-range (no soften), 120Ω degraded, 0/OL dead", ok,
                    $"60={c60.State}/inRange={c60.InRange}, 120={c120.State}, 5={c5.State}, OL={cOL.State}");
            }

            // ══ BANDING HONESTY — a share-leader must ALSO hold even-odds of ABSOLUTE belief ══
            // NormShare strips the doubt out: a lone hypothesis at posterior 0.45 has share 1.0.
            // The band must NOT crown it "leading" while 55% of belief is still unexplained.
            {
                var lone = FaultBanding.BandShares(new[] { 1.0 }, 0.449);
                Add(report, "Banding: a lone hypothesis under even odds is 'contending', not 'leading'",
                    lone[0] == FaultBand.Contending, FaultBanding.Label(lone[0]));

                var loneStrong = FaultBanding.BandShares(new[] { 1.0 }, 0.85);
                Add(report, "Banding: a lone hypothesis over even odds genuinely 'leads'",
                    loneStrong[0] == FaultBand.Leading, FaultBanding.Label(loneStrong[0]));

                var gapWeak = FaultBanding.BandShares(new[] { 0.75, 0.25 }, 0.45);
                Add(report, "Banding: share-leader with weak absolute belief is capped at 'contending'",
                    gapWeak[0] == FaultBand.Contending, FaultBanding.Label(gapWeak[0]));

                var gapStrong = FaultBanding.BandShares(new[] { 0.75, 0.25 }, 0.72);
                Add(report, "Banding: share-leader with strong absolute belief genuinely 'leads'",
                    gapStrong[0] == FaultBand.Leading, FaultBanding.Label(gapStrong[0]));

                var noGate = FaultBanding.BandShares(new[] { 1.0 }, double.NaN);
                Add(report, "Banding: NaN absolute posterior skips the gate (pure relative banding preserved)",
                    noGate[0] == FaultBand.Leading, FaultBanding.Label(noGate[0]));
            }

            // ══ CORRELATED-EVIDENCE COLLAPSE — same DTC echoed by N modules is ONE witness ══
            // Live repro (2026-07-12): P0100 reported by PCM AND RSRV04 counted as two
            // independent likelihoods, inflating the posterior with zero new information.
            {
                var m6 = new Tier1.BayesianHypothesisModule();
                Func<int, DiagnosticSnapshot> echoSnap = n =>
                {
                    var s = Base();
                    string[] mods = { "PCM", "TCM", "ABS" };
                    for (int k = 0; k < n; k++)
                        s.AddDtc(new DiagnosticDtc { Code = "P0171", StatusByte = 0x08, ModuleName = mods[k], Description = "System too lean (bank 1)" });
                    return s;
                };
                Func<DiagnosticSnapshot, double> mafPost = s =>
                {
                    var r = m6.Analyze(s, null).FirstOrDefault(x => x.RankedFaults != null);
                    return r?.RankedFaults.FirstOrDefault(f => f.FaultKey == "MafError")?.Posterior ?? -1;
                };

                double p1 = mafPost(echoSnap(1));
                double p3 = mafPost(echoSnap(3));
                Add(report, "M6 collapse: P0171 echoed by 3 modules scores the SAME as one witness",
                    p1 > 0 && Math.Abs(p1 - p3) < 1e-9, $"1x={p1:0.###} vs 3x={p3:0.###}");

                var three = m6.Analyze(echoSnap(3), null).FirstOrDefault(x => x.RankedFaults != null);
                var mafRf = three?.RankedFaults.FirstOrDefault(f => f.FaultKey == "MafError");
                bool annotated = mafRf != null && mafRf.Contributions.Count == 1
                                 && mafRf.Contributions[0].Source.Contains("counted once")
                                 && mafRf.Contributions[0].Source.Contains("TCM");
                Add(report, "M6 collapse: one surviving witness, annotated with the echoing modules",
                    annotated, mafRf?.Contributions.FirstOrDefault()?.Source ?? "no MafError contribution");

                // Strongest status must win the surviving slot: present + confirmed → confirmed kept.
                var mixed = Base();
                mixed.AddDtc(new DiagnosticDtc { Code = "P0171", StatusByte = 0x00, ModuleName = "TCM", Description = "lean (stored)" });
                mixed.AddDtc(new DiagnosticDtc { Code = "P0171", StatusByte = 0x08, ModuleName = "PCM", Description = "lean (confirmed)" });
                var mixedRf = m6.Analyze(mixed, null).FirstOrDefault(x => x.RankedFaults != null)
                               ?.RankedFaults.FirstOrDefault(f => f.FaultKey == "MafError");
                bool strongestWins = mixedRf != null && mixedRf.Contributions.Count == 1
                                     && mixedRf.Contributions[0].Source.Contains("confirmed")
                                     && Math.Abs(mixedRf.Contributions[0].Likelihood - 0.85) < 1e-9;
                Add(report, "M6 collapse: strongest status (confirmed) survives a mixed-status echo",
                    strongestWins, mixedRf?.Contributions.FirstOrDefault()?.Source ?? "no MafError contribution");

                // DISTINCT codes are genuinely independent and must still stack.
                var s2 = echoSnap(1);
                s2.AddDtc(new DiagnosticDtc { Code = "P0100", StatusByte = 0x08, ModuleName = "PCM", Description = "MAF circuit" });
                double pBoth = mafPost(s2);
                Add(report, "M6 collapse: DISTINCT codes (P0171 + P0100) still stack as independent evidence",
                    pBoth > p1 + 1e-9, $"P0171 only={p1:0.###} vs +P0100={pBoth:0.###}");
            }

            // ══ FIX ARM (E4) — fault → procedure ontology + matcher + SAFETY gate ══
            {
                var procs = new List<Data.ProcRecord>
                {
                    new Data.ProcRecord { Name = "Throttle Body Relearn", Archetype = "ADAPTATION", IsExecutable = true },
                    new Data.ProcRecord { Name = "Reset Adaptation Values", Archetype = "RESET", IsExecutable = true },
                    new Data.ProcRecord { Name = "Airbag Deployment Loop Test", Archetype = "ACTUATOR_TEST", IsExecutable = true }, // MUST be blocked
                    new Data.ProcRecord { Name = "SRS Pretensioner Actuator", Archetype = "ACTUATOR_TEST", IsExecutable = true },   // MUST be blocked
                    new Data.ProcRecord { Name = "Read DTCs", Archetype = "DTC_READ", IsExecutable = true },                        // no VacuumLeak match
                    new Data.ProcRecord { Name = "Relative Compression Test", Archetype = "ROUTINE", IsExecutable = true },
                    new Data.ProcRecord { Name = "Cylinder Balance Test", Archetype = "ACTUATOR_TEST", IsExecutable = true },
                };

                var vac = Fix.ProcedureMatcher.Match("VacuumLeak", procs, 6);
                bool vacGood = vac.Any(c => c.ProcedureName == "Throttle Body Relearn")
                               && vac.Any(c => c.ProcedureName == "Reset Adaptation Values")
                               && !vac.Any(c => c.ProcedureName == "Read DTCs")
                               && !vac.Any(c => c.ProcedureName == "Relative Compression Test");
                Add(report, "Fix-arm: VacuumLeak → throttle-relearn + adaptation-reset (not DTC-read, not compression)",
                    vacGood, string.Join(", ", vac.Select(c => c.ProcedureName)));

                var weak = Fix.ProcedureMatcher.Match("WeakCylinder", procs, 6);
                bool weakGood = weak.Any(c => c.ProcedureName == "Relative Compression Test")
                                && weak.Any(c => c.ProcedureName == "Cylinder Balance Test");
                Add(report, "Fix-arm: WeakCylinder → relative-compression + cylinder-balance",
                    weakGood, string.Join(", ", weak.Select(c => c.ProcedureName)));

                // SAFETY: no restraints/airbag procedure may EVER be surfaced, for any fault.
                bool noSafety = true;
                foreach (var fk in Fix.FaultProcedureOntology.KnownFaultKeys)
                    if (Fix.ProcedureMatcher.Match(fk, procs, 20).Any(c =>
                        c.ProcedureName.IndexOf("Airbag", StringComparison.OrdinalIgnoreCase) >= 0
                        || c.ProcedureName.IndexOf("SRS", StringComparison.OrdinalIgnoreCase) >= 0
                        || c.ProcedureName.IndexOf("Pretensioner", StringComparison.OrdinalIgnoreCase) >= 0))
                        noSafety = false;
                Add(report, "Fix-arm: a restraints/airbag procedure is NEVER proposed as a fix (hard gate)", noSafety,
                    noSafety ? "blocked for all faults" : "LEAKED a safety procedure");

                // An unmapped fault surfaces nothing (honest — we don't guess a fix we haven't vetted).
                var unknown = Fix.ProcedureMatcher.Match("GremlinInTheDashboard", procs, 6);
                Add(report, "Fix-arm: an unmapped fault key returns no candidates (no guessing)", unknown.Count == 0,
                    unknown.Count + " candidates");

                // Ranking: the higher-affinity + executable candidate leads.
                bool ranked = vac.Count > 0 && vac[0].Affinity >= (vac.Count > 1 ? vac[vac.Count - 1].Affinity : 0);
                Add(report, "Fix-arm: candidates are affinity-ranked (leader ≥ tail)", ranked,
                    vac.Count > 0 ? $"top={vac[0].ProcedureName} ({vac[0].Affinity:0.00})" : "none");
            }

            // ══ E3 + E4 — the fix loop closes: propose fix → worked → best-supported → WRITE-BACK ══
            {
                var mem = new MemFixedByStore();
                var orch = new Session.InvestigationOrchestrator();
                orch.AttachFixedByStore(mem);
                orch.StartSession("6FPAAAJG5CW100004", "FordFG", 2012);
                orch.IngestRun(BuildLeanSnap("FordFG"), LeanFrontierRun());

                var vacHyp = orch.Frontier().FirstOrDefault(n => n.FaultKey == "VacuumLeak");
                var fixId = orch.AddFix(vacHyp.Id, "Throttle Body Relearn", "Throttle Body Relearn");
                bool fixNodeMade = orch.Session.Node(fixId)?.Kind == Session.NodeKind.Fix
                                   && orch.Session.Edges.Any(e => e.Kind == Session.EdgeKind.Fixes && e.ToId == fixId);
                Add(report, "E4: AddFix creates a Fix node linked to the hypothesis (Fixes edge)", fixNodeMade,
                    fixNodeMade ? "Fix node + Fixes edge" : "no fix node");

                orch.RecordFixOutcome(fixId, worked: true);
                bool best = orch.Session.Node(vacHyp.Id)?.Status == Session.NodeStatus.BestSupported;
                Add(report, "E4: a worked fix tips the hypothesis to BEST-SUPPORTED (repair is ground truth)", best,
                    orch.Session.Node(vacHyp.Id)?.Status.ToString());

                var recorded = mem.Query("FordFG", "VacuumLeak");
                bool wroteBack = recorded.Count == 1 && recorded[0].SuccessCount == 1 && recorded[0].Count == 1;
                Add(report, "E3: the confirmed fix WROTE BACK to repair history (platform+fault keyed)", wroteBack,
                    wroteBack ? $"{recorded[0].FixAction}: {recorded[0].SuccessCount}/{recorded[0].Count}" : "not recorded");
            }

            // ══ E3 KEYSTONE — repair history actually STEERS M6's prior (the starved brain eats) ══
            {
                var cold = NewEngineFixedBy(new MemFixedByStore());
                var vacCold = cold.Run(BuildLeanSnap("FordFG")).RankedFaults?.FirstOrDefault(f => f.FaultKey == "VacuumLeak");

                var warm = new MemFixedByStore();
                for (int i = 0; i < 3; i++) warm.Record("FordFG", "VacuumLeak", "Throttle Body Relearn", true);
                var vacWarm = NewEngineFixedBy(warm).Run(BuildLeanSnap("FordFG")).RankedFaults?.FirstOrDefault(f => f.FaultKey == "VacuumLeak");

                bool learned = vacCold != null && vacWarm != null && !vacCold.PriorFromHistory && vacWarm.PriorFromHistory;
                Add(report, "E3 KEYSTONE: 3 recorded repairs flip M6's VacuumLeak prior to history-derived", learned,
                    $"cold.fromHistory={vacCold?.PriorFromHistory}, warm.fromHistory={vacWarm?.PriorFromHistory}");
            }

            // ══ E2 — session PERSISTENCE: a paused investigation round-trips + auto-resumes by VIN ══
            {
                string tmpDir = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "TesSess_" + Guid.NewGuid().ToString("N"));
                try
                {
                    var store = new Session.SessionStore(tmpDir);
                    string vin = "6FPAAAJG5CW100777";

                    var orch = new Session.InvestigationOrchestrator();
                    orch.AttachSessionStore(store);
                    var snap = BuildLeanSnap("FordFG"); snap.Vin = vin;
                    orch.IngestRun(snap, LeanFrontierRun());
                    var vac = orch.Frontier().First(n => n.FaultKey == "VacuumLeak");
                    var fixId = orch.AddFix(vac.Id, "Throttle Body Relearn", "Throttle Body Relearn");
                    orch.RecordFixOutcome(fixId, worked: true);   // auto-saves via RaiseChanged
                    int nodesBefore = orch.Session.Nodes.Count;
                    int edgesBefore = orch.Session.Edges.Count;

                    // Reload through a FRESH store instance — proves the round-trip is on disk.
                    var reloaded = new Session.SessionStore(tmpDir).Load(vin);
                    bool structOk = reloaded != null
                        && reloaded.Nodes.Count == nodesBefore && reloaded.Edges.Count == edgesBefore
                        && reloaded.Vin == vin && reloaded.Platform == "FordFG";
                    Add(report, "E2: the investigation graph round-trips through disk (nodes + edges + identity)", structOk,
                        reloaded == null ? "load returned null" : $"{reloaded.Nodes.Count} nodes / {reloaded.Edges.Count} edges");

                    var rvac = reloaded?.Nodes.FirstOrDefault(n => n.FaultKey == "VacuumLeak" && n.Kind == Session.NodeKind.Hypothesis);
                    bool beliefOk = rvac != null && rvac.Status == Session.NodeStatus.BestSupported && rvac.ConfirmedOnVehicle;
                    Add(report, "E2: belief state survives the save (VacuumLeak best-supported + confirmed-on-vehicle)", beliefOk,
                        rvac != null ? $"{rvac.Status}, confirmed={rvac.ConfirmedOnVehicle}, delta={rvac.AccumulatedDelta:0.0}" : "no VacuumLeak");

                    var rfix = reloaded?.Nodes.FirstOrDefault(n => n.Kind == Session.NodeKind.Fix);
                    bool fixOk = rfix != null && rfix.FixAction == "Throttle Body Relearn";
                    Add(report, "E2: the Fix node + its fix action persist", fixOk, rfix?.FixAction ?? "no fix node");

                    // Auto-resume: fresh orchestrator + same store, re-ingest the SAME VIN → the paused tree returns.
                    var orch2 = new Session.InvestigationOrchestrator();
                    orch2.AttachSessionStore(store);
                    orch2.IngestRun(snap, LeanFrontierRun());   // Session==null ⇒ auto-resume by VIN, then refresh
                    bool resumed = orch2.Session != null
                        && orch2.Session.Nodes.Count(n => n.Kind == Session.NodeKind.Observation)
                           == orch.Session.Nodes.Count(n => n.Kind == Session.NodeKind.Observation)   // no duplicate observations
                        && orch2.Session.Node(vac.Id)?.Status == Session.NodeStatus.BestSupported;      // same node id + verdict kept
                    Add(report, "E2: reconnect + capture AUTO-RESUMES the paused job by VIN (no duplicates, verdict kept)", resumed,
                        resumed ? "resumed in place" : "did not resume cleanly");

                    var listed = new Session.SessionStore(tmpDir).List();
                    bool listedOk = listed.Any(s => s.Vin == vin && s.BestSupported.Length > 0);
                    Add(report, "E2: List() surfaces the paused job for a resume picker", listedOk,
                        listed.Count > 0 ? $"{listed.Count} saved, best='{listed[0].BestSupported}'" : "none listed");
                }
                finally { try { System.IO.Directory.Delete(tmpDir, true); } catch { } }
            }

            // ══ AUDIT FIXES (2026-07-12) — safety gate · residual honesty · volatile revival ══
            {
                // Fix-arm SAFETY: a restraint-MODULE procedure is NEVER surfaced, even when its name
                // matches a fault keyword (the old gate only blocked English full words, so "RCM Self
                // Test" slipped through SensorDropout's "SELF TEST" keyword).
                var procs = new List<Data.ProcRecord>
                {
                    new Data.ProcRecord { Name = "RCM Self Test",         Archetype = "ACTUATOR_TEST" }, // Ford restraints
                    new Data.ProcRecord { Name = "OCS Sensor Test",       Archetype = "ACTUATOR_TEST" }, // occupant classification
                    new Data.ProcRecord { Name = "SDM Actuator Test",     Archetype = "ACTUATOR_TEST" }, // GM airbag
                    new Data.ProcRecord { Name = "Airbag Deployment Loop", Archetype = "ACTUATOR_TEST" }, // full-word
                    new Data.ProcRecord { Name = "MAF Sensor Test",       Archetype = "ACTUATOR_TEST" }, // legit — should surface
                };
                var cands = Fix.ProcedureMatcher.Match("SensorDropout", procs, 8);
                bool noRestraint = cands.All(c =>
                {
                    var u = (c.ProcedureName ?? "").ToUpperInvariant();
                    return !u.Contains("RCM") && !u.Contains("OCS") && !u.Contains("SDM") && !u.Contains("AIRBAG");
                });
                bool keptLegit = cands.Any(c => (c.ProcedureName ?? "").Contains("MAF"));
                Add(report, "Fix-arm SAFETY: restraint-module procedures (RCM/OCS/SDM/Airbag) are NEVER surfaced as a fix",
                    noRestraint, string.Join(", ", cands.Select(c => c.ProcedureName)));
                Add(report, "Fix-arm: a legitimate non-restraint self-test still surfaces", keptLegit,
                    string.Join(", ", cands.Select(c => c.ProcedureName)));

                // Hardened tokenizer (regression fix 2026-07-12): glued acronyms + non-ASCII separators
                // are caught; ACM (Audio Control Module) is no longer false-blocked.
                Add(report, "Fix-arm SAFETY: glued 'RCMSelfTest' is caught (camelCase split)",
                    Fix.ProcedureMatcher.IsSafetyProcedure("RCMSelfTest"), "glued acronym");
                Add(report, "Fix-arm SAFETY: non-ASCII-separated 'RCM–Reset' (en-dash) is caught",
                    Fix.ProcedureMatcher.IsSafetyProcedure("RCM–Reset"), "en-dash separator");
                Add(report, "Fix-arm SAFETY: descriptive 'Passenger Airbag Disable' still caught",
                    Fix.ProcedureMatcher.IsSafetyProcedure("Passenger Airbag Disable"), "descriptive word");
                Add(report, "Fix-arm: 'ACM Reset' (Audio Control Module) is NOT false-blocked",
                    !Fix.ProcedureMatcher.IsSafetyProcedure("ACM Reset"), "audio module not blocked");

                // Core-module FALSE-POSITIVE suppression (audit round 2): a legitimately-steady idle
                // must not be condemned. TPS/RPM/Load hold flat (foot off pedal), O2 oscillates in
                // closed loop, MAP is low (idle), MAF healthy — the exact healthy state that used to
                // trip M5 "stuck", T2 "dirty MAF", and T3 "worn rings".
                {
                    var eng2 = NewEngine(out _, out _);
                    var s2 = Base();
                    Fill(s2, CanonicalSignals.Rpm, i => 800);
                    Fill(s2, CanonicalSignals.ThrottlePos, i => 14);
                    Fill(s2, CanonicalSignals.EngineLoad, i => 25);
                    Fill(s2, CanonicalSignals.IntakeAirTemp, i => 30);
                    Fill(s2, CanonicalSignals.Map, i => 35);
                    Fill(s2, CanonicalSignals.Maf, i => 3.0);
                    Fill(s2, CanonicalSignals.O2B1S1, i => (i % 6) < 3 ? 0.85 : 0.10); // healthy closed-loop swing
                    var r2 = eng2.Run(s2);
                    bool m5Stuck = r2.Results.Any(r => r.ModuleId == "M5"
                        && ((r.Title ?? "") + (r.Hypothesis ?? "")).ToLowerInvariant().Contains("stuck"));
                    Add(report, "M5: a legitimately-flat idle TPS/RPM is NOT condemned as 'stuck' (operating point steady)",
                        !m5Stuck, m5Stuck ? "FALSE stuck verdict" : "no false stuck");
                    bool mafFp = r2.Results.Any(r => (r.ModuleId == "T2" || r.ModuleId == "T3")
                        && ((r.Hypothesis ?? "") + (r.Title ?? "")).ToLowerInvariant().Contains("maf"));
                    Add(report, "T2/T3: a healthy MAF at idle is NOT flagged low (load-gate rejects the idle regime)",
                        !mafFp, mafFp ? "FALSE MAF verdict at idle" : "no false MAF verdict");
                    bool veFp = r2.Results.Any(r => r.ModuleId == "T3"
                        && ((r.Hypothesis ?? "")).ToLowerInvariant().Contains("breathing"));
                    Add(report, "T3: no fabricated 'breathing loss / worn rings' on a healthy idling engine",
                        !veFp, veFp ? "FALSE VE-degradation verdict" : "no false VE verdict");
                }

                // Residual HONESTY: an unranked DTC (a lone U-code M6 spawned no hypothesis for) is
                // flagged unexplained; the one the hypothesis was raised from is not.
                DiagnosticRunResult OneFaultRun(string key, string label, double lo, string dtcCode)
                {
                    var rf = new RankedFault { FaultKey = key, Label = label, LogOdds = lo };
                    if (dtcCode != null)
                        rf.Contributions = new List<FaultContribution>
                            { new FaultContribution { Source = $"DTC {dtcCode} (confirmed)", Likelihood = 0.85, Detail = "x" } };
                    var run = new DiagnosticRunResult { RankedFaults = new List<RankedFault> { rf } };
                    run.Results.Add(new DiagnosticResult { ModuleId = "M6", RankedFaults = run.RankedFaults });
                    return run;
                }
                var rsnap = Base(); rsnap.Platform = "FordFG"; rsnap.Vin = "RESIDUAL0000000001";
                rsnap.AddDtc(new DiagnosticDtc { Code = "P0171", StatusByte = 0x08, ModuleName = "PCM", Description = "lean" });
                rsnap.AddDtc(new DiagnosticDtc { Code = "U0101", StatusByte = 0x08, ModuleName = "PCM", Description = "lost comm TCM" });
                var rorch = new Session.InvestigationOrchestrator();
                rorch.IngestRun(rsnap, OneFaultRun("VacuumLeak", "vacuum leak", 1.5, "P0171"));  // only P0171 raises a hypothesis
                var residual = rorch.TriageResidual();
                bool u0101Flagged = residual.Any(n => (n.Title ?? "").Contains("U0101"));
                bool p0171Explained = !residual.Any(n => (n.Title ?? "").Contains("P0171"));
                Add(report, "Residual honesty: the unranked DTC (U0101) is flagged unexplained; the explained one (P0171) is not",
                    u0101Flagged && p0171Explained, $"residual=[{string.Join(", ", residual.Select(n => (n.Title ?? "").Split(' ')[0]))}]");

                // Volatile REVIVAL: a clean pass suspends a volatile fault; a later reproducing pass revives it to Live.
                var vsess = Session.DiagnosticSession.Start("REVIVE000000000001", "FordFG", 2012);
                vsess.SpawnHypotheses(OneFaultRun("BusFault", "CAN bus fault", 1.0, null));
                var bus = vsess.Nodes.First(n => n.FaultKey == "BusFault");
                vsess.ApplyOutcome(Guid.NewGuid(), null, "BusFault", 2.0, EvidenceVerdict.Pass, true, false, "quiet bus — not reproduced");
                bool suspended = vsess.Node(bus.Id).Status == Session.NodeStatus.Suspended;
                vsess.ApplyOutcome(Guid.NewGuid(), "BusFault", null, 2.0, EvidenceVerdict.Pass, true, true, "harness wiggle reproduced it");
                bool revived = vsess.Node(bus.Id).Status == Session.NodeStatus.Live;
                Add(report, "Volatile revival: a reproducing test brings a Suspended intermittent back to Live (can converge)",
                    suspended && revived, suspended ? (revived ? "suspended→revived" : "stuck suspended") : "never suspended");
            }

            // ══ INVESTIGATION TREE — Slice-1: the lean-triad walk, connect → best-supported ══
            // Controlled M6 frontier (vacuum leak best-supported by the evidence) so this proves
            // the TREE's mechanics AND that the RIGHT fault wins — module firing is covered above.
            {
                var run = LeanFrontierRun();
                var sess = Session.DiagnosticSession.Start("6FPAAAJG5CW100001", "FordFG", 2012);
                sess.AppendObservation("VIN -> Ford FG Falcon (Barra I6, 2012)", source: "vin");
                var dtcObs = sess.AppendObservation("DTC P0171 - system too lean (bank 1), confirmed", source: "dtc");
                sess.SpawnHypotheses(run, new[] { dtcObs });

                var f0 = sess.Frontier();
                bool leadsVac = f0.Count == 3 && f0[0].FaultKey == "VacuumLeak";
                Add(report, "Tree: the RIGHT fault (vacuum leak) leads the frontier; no FF: pollution", leadsVac,
                    string.Join(" > ", f0.Select(n => n.FaultKey)));

                var p1 = sess.ProposeNextTest();
                Add(report, "Tree: proposes the discriminating test (trim under load)",
                    p1 != null && (p1.DiscriminatingText ?? "").ToLowerInvariant().Contains("load"), p1?.Title);

                // Trim NORMALISES under load -> supports the leak, refutes metering (not independent yet).
                sess.ApplyOutcome(p1.TestNodeId, "VacuumLeak", "MafError", 2.0, EvidenceVerdict.Pass, true, false,
                    "trim normalised under load - a vacuum leak, not metering");
                bool mafRuledKept = sess.RuledOut().Any(n => n.FaultKey == "MafError");
                bool vacStillLeads = sess.Frontier().FirstOrDefault()?.FaultKey == "VacuumLeak";
                Add(report, "Tree: the failed test rules out MAF (kept on the map) and the leak still leads",
                    mafRuledKept && vacStillLeads,
                    mafRuledKept ? (vacStillLeads ? "MAF ruled-out, leak leads" : "leak lost the lead") : "MAF not ruled");

                Add(report, "Tree: does NOT converge without an independent confirming test", sess.TryConverge() == null,
                    sess.TryConverge() == null ? "held Live (honest)" : "converged too early");

                // Independent confirm: the smoke test finds the leak on the vehicle.
                var p2 = sess.ProposeNextTest();
                sess.ApplyOutcome(p2.TestNodeId, "VacuumLeak", null, 2.0, EvidenceVerdict.Pass, true, true,
                    "smoke test - visible leak at the intake");
                var best = sess.TryConverge();
                bool converged = best != null && best.FaultKey == "VacuumLeak"
                                 && best.Status == Session.NodeStatus.BestSupported;
                Add(report, "Tree: converges to the vacuum leak as BEST-SUPPORTED after an independent on-vehicle confirm",
                    converged, best != null ? best.Title + " -> " + best.Status : "no convergence");

                string terminal = sess.BestSupportedSummary();
                bool honest = terminal.IndexOf("best-supported", StringComparison.OrdinalIgnoreCase) >= 0
                              && terminal.IndexOf("vacuum", StringComparison.OrdinalIgnoreCase) >= 0
                              && terminal.IndexOf("confirmed root cause", StringComparison.OrdinalIgnoreCase) < 0;
                Add(report, "Tree: terminal names the vacuum leak, honestly ('best-supported', not 'confirmed')", honest, terminal);
            }

            // ══ E1 — the ORCHESTRATOR drives the whole loop in production (not just the raw session) ══
            // Same lean triad, but routed through InvestigationOrchestrator: connect → ingest a run
            // (VIN + DTC observations + hypotheses) → propose → record outcome → converge.
            {
                var snap = Base();
                snap.Oem = OEMManufacturer.Generic; snap.Platform = "FordFG"; snap.ModelYear = 2012;
                snap.Vin = "6FPAAAJG5CW100003";
                snap.AddDtc(new DiagnosticDtc { Code = "P0171", StatusByte = 0x08, ModuleName = "PCM", Description = "System too lean (bank 1)" });

                var orch = new Session.InvestigationOrchestrator();
                orch.StartSession(snap.Vin, snap.Platform, snap.ModelYear);
                orch.IngestRun(snap, LeanFrontierRun());

                var f0 = orch.Frontier();
                bool wired = f0.Count == 3 && f0[0].FaultKey == "VacuumLeak"
                    && orch.Session.Nodes.Any(n => n.Source == "vin")
                    && orch.Session.Nodes.Any(n => n.Source == "dtc");
                Add(report, "E1: orchestrator ingests a run → VIN+DTC observations + the right frontier", wired,
                    string.Join(" > ", f0.Select(n => n.FaultKey)));

                var p1 = orch.ProposeNextTest();
                Add(report, "E1: orchestrator proposes the discriminating test (trim under load)",
                    p1 != null && (p1.DiscriminatingText ?? "").ToLowerInvariant().Contains("load"), p1?.Title);

                // Trim normalises under load → points TOWARD the leader (vacuum leak), rules the MAF out.
                // Ran on the vehicle but not yet independent, so it must NOT converge.
                orch.RecordOutcome(p1, Session.InvestigationOrchestrator.Pointing.TowardLeading, 2.0,
                                   ranOnVehicle: true, independent: false, summary: "trim normalised under load");
                bool held = orch.RuledOut().Any(n => n.FaultKey == "MafError")
                            && orch.Frontier().FirstOrDefault()?.FaultKey == "VacuumLeak"
                            && orch.TryConverge() == null;
                Add(report, "E1: failed test rules out MAF (kept on map), leak still leads, no premature convergence", held,
                    held ? "MAF ruled-out, leak leads, held Live" : "loop mis-stepped");

                // Independent on-vehicle confirm → converge to BestSupported.
                var p2 = orch.ProposeNextTest();
                orch.RecordOutcome(p2, Session.InvestigationOrchestrator.Pointing.TowardLeading, 2.0,
                                   ranOnVehicle: true, independent: true, summary: "smoke test — visible leak at the intake");
                var best = orch.TryConverge();
                bool converged = best != null && best.FaultKey == "VacuumLeak"
                                 && best.Status == Session.NodeStatus.BestSupported;
                Add(report, "E1: converges to the vacuum leak as BEST-SUPPORTED after an independent on-vehicle confirm",
                    converged, best != null ? best.Title + " -> " + best.Status : "no convergence");

                // Re-ingest the same scan: idempotent — no duplicate observations, tree state preserved.
                int obsBefore = orch.Session.Nodes.Count(n => n.Kind == Session.NodeKind.Observation);
                orch.IngestRun(snap, LeanFrontierRun());
                int obsAfter = orch.Session.Nodes.Count(n => n.Kind == Session.NodeKind.Observation);
                bool idempotent = obsBefore == obsAfter
                    && orch.Session.Node(best.Id)?.Status == Session.NodeStatus.BestSupported;
                Add(report, "E1: re-ingesting the same scan is idempotent (no dup observations, verdict preserved)",
                    idempotent, $"obs {obsBefore}->{obsAfter}");
            }

            // Integration: a REAL engine run yields a populated, FF-filtered frontier (no pseudo-hypotheses).
            {
                var engine = NewEngine(out _, out _);
                var run = engine.Run(VacuumLeakSurface(withLeanDtc: true));
                var sess = Session.DiagnosticSession.Start("6FPAAAJG5CW100002", "FordFG", 2012);
                sess.SpawnHypotheses(run);
                var f = sess.Frontier();
                bool noPollution = f.Count > 0
                    && !f.Any(n => n.FaultKey.StartsWith("FF:", StringComparison.OrdinalIgnoreCase))
                    && f.Any(n => n.FaultKey == "VacuumLeak");
                Add(report, "Tree (real run): frontier is real faults only (FF: filtered) + includes the vacuum leak",
                    noPollution, string.Join(" > ", f.Select(n => n.FaultKey)));
            }

            // ══ VOLATILITY GUARD — a bus/lost-comms fault can't be refuted on one clean pass ══
            {
                var engine = NewEngine(out _, out _);
                var run = engine.Run(SharedBusFault());
                var sess = Session.DiagnosticSession.Start("WBADUMMY0000TEST1", "Generic", 2015);
                sess.SpawnHypotheses(run);
                var bus = sess.Frontier().FirstOrDefault(n =>
                    !string.IsNullOrEmpty(n.FaultKey) && n.FaultKey.IndexOf("Bus", StringComparison.OrdinalIgnoreCase) >= 0);
                Add(report, "Tree: bus/lost-comms hypothesis flagged volatile", bus != null && bus.Volatile,
                    bus?.FaultKey ?? "no bus hypothesis");

                if (bus != null)
                {
                    var t = sess.ProposeNextTest();
                    sess.ApplyOutcome(t.TestNodeId, favouredFaultKey: null, refutedFaultKey: bus.FaultKey,
                        strength: 2.0, verdict: EvidenceVerdict.Inconclusive, ranOnVehicle: true, independent: false,
                        summary: "bus looked healthy this probe");
                    bool suspended = bus.Status == Session.NodeStatus.Suspended
                                     && sess.Suspended().Any(n => n.Id == bus.Id)
                                     && !sess.RuledOut().Any(n => n.Id == bus.Id);
                    Add(report, "Tree: a volatile fault SUSPENDS on one clean pass (not refuted)", suspended,
                        bus.Status.ToString());
                }
            }

            // ── DtcFaultModel: every DTC (any system/subsystem/OEM) inverts into physical faults ──
            // Before this, M6 mapped ~20 hardcoded engine codes and returned NOTHING for the rest.
            // These are exactly the codes the old mapper ignored — each must now yield a non-empty,
            // physically-grounded fault set (a DTC is an observation; these are the faults behind it).
            {
                var coverageCases = new (string code, string desc, string mustMention)[]
                {
                    ("P0122", "Throttle Position Sensor A Circuit Low Input", "short"),   // circuit-low sensor
                    ("P0113", "Intake Air Temperature Circuit High Input",   "open"),    // circuit-high sensor
                    ("P0405", "EGR Position Sensor A Circuit Low",            "connector"),
                    ("P0455", "Evaporative Emission System Leak Detected (large leak)", "flow"),
                    ("P0016", "Crankshaft/Camshaft Position Correlation Bank 1", "correlation"),
                    ("P0740", "Torque Converter Clutch Circuit / Open",       "open"),    // transmission subsystem
                    ("P0741", "Torque Converter Clutch Solenoid Performance or Stuck Off", "stuck"),
                    ("C0035", "Left Front Wheel Speed Sensor Circuit",        "connector"), // chassis
                    ("B1318", "Battery Voltage Low",                          "out of range"), // body — a VALUE fault, not a wiring short
                    ("U0100", "Lost Communication With ECM/PCM",             "communication"), // network
                    ("P1000", "OBD-II Monitor Testing Not Complete",         null),      // manufacturer / generic tail
                    ("P0700", "Transmission Control System (MIL Request)",    null),
                };
                int nonEmpty = 0, mentionOk = 0, mentionTot = 0;
                var failures = new List<string>();
                foreach (var (code, desc, must) in coverageCases)
                {
                    var faults = DtcFaultModel.Expand(code, desc);
                    if (faults.Count > 0) nonEmpty++; else failures.Add(code + " empty");
                    // every fault must carry a label, a next-test, and at least one suspect
                    bool wellFormed = faults.All(f => !string.IsNullOrWhiteSpace(f.Label)
                                                   && !string.IsNullOrWhiteSpace(f.NextTest)
                                                   && f.Suspects != null && f.Suspects.Length > 0
                                                   && f.Prior > 0 && f.Prior < 1);
                    if (!wellFormed) failures.Add(code + " malformed");
                    if (must != null)
                    {
                        mentionTot++;
                        bool mentions = faults.Any(f => (f.Meaning + " " + f.Label).ToLowerInvariant().Contains(must));
                        if (mentions) mentionOk++; else failures.Add($"{code} missing '{must}'");
                    }
                }
                Add(report, "DtcFaultModel: every representative code (P/C/B/U, all subsystems) yields faults",
                    nonEmpty == coverageCases.Length && failures.Count == 0,
                    failures.Count == 0 ? $"{coverageCases.Length} codes, all non-empty + well-formed" : string.Join("; ", failures));
                Add(report, "DtcFaultModel: expected failure mode present per grammar",
                    mentionOk == mentionTot, $"{mentionOk}/{mentionTot} grammar cues matched");

                // Registry round-trips so M6.FaultLabel / ExpertPrior resolve the generated keys.
                var sample = DtcFaultModel.Expand("P0301", "Cylinder 1 Misfire Detected").FirstOrDefault();
                bool registryOk = sample != null
                                  && DtcFaultModel.TryGetLabel(sample.Key, out var lbl) && !string.IsNullOrEmpty(lbl)
                                  && DtcFaultModel.TryGetPrior(sample.Key, out var pr) && pr > 0
                                  && DtcFaultModel.GetSuspects(sample.Key).Length > 0;
                Add(report, "DtcFaultModel: generated keys resolve back (label/prior/suspects) for M6",
                    registryOk, sample?.Key ?? "no sample");

                // A blank code contributes nothing (no invented faults from noise).
                Add(report, "DtcFaultModel: blank/short code invents nothing",
                    DtcFaultModel.Expand("", "").Count == 0 && DtcFaultModel.Expand("P", "").Count == 0, "guarded");
            }

            // ══ 2026-07-18 ADVERSARIAL-AUDIT FIXES (#1–#7) — each was a confirmed live defect ══
            {
                // #5 Rationality/threshold codes are NOT wiring faults: P0420 must yield the
                // system-out-of-spec pair (drift/mech), never a connector/short hypothesis.
                var cat = DtcFaultModel.Expand("P0420", "Catalyst System Efficiency Below Threshold Bank 1");
                bool catOk = cat.Count > 0
                             && !cat.Any(f => f.Key.StartsWith("Connector@", StringComparison.OrdinalIgnoreCase)
                                           || f.Key.StartsWith("ShortGnd@", StringComparison.OrdinalIgnoreCase))
                             && cat.Any(f => f.Key.StartsWith("SensorDrift@", StringComparison.OrdinalIgnoreCase)
                                          || f.Key.StartsWith("MechRange@", StringComparison.OrdinalIgnoreCase));
                Add(report, "Audit#5: P0420 efficiency-below-threshold → system out of spec, not a connector",
                    catOk, string.Join(", ", cat.Select(f => f.Key)));
                var batt = DtcFaultModel.Expand("B1318", "Battery Voltage Low");
                Add(report, "Audit#5: 'Battery Voltage Low' is a value fault — no short-to-ground hypothesis",
                    batt.Count > 0 && !batt.Any(f => f.Key.StartsWith("ShortGnd@", StringComparison.OrdinalIgnoreCase)),
                    string.Join(", ", batt.Select(f => f.Key)));

                // #6 Grammar words inside COMPONENT names must not raise spurious modes: a MAF
                // *circuit* code gets no flow-restriction fault; "stuck open" is mechanical, not
                // an open circuit.  #4: intermittent grammar marks the faults volatile.
                var maf = DtcFaultModel.Expand("P1101", "Mass Air Flow Sensor Circuit Intermittent");
                bool mafOk = maf.Count > 0 && !maf.Any(f => f.Key.StartsWith("FlowLeak@", StringComparison.OrdinalIgnoreCase));
                Add(report, "Audit#6: MAF circuit code raises no spurious flow-restriction fault (name ≠ grammar)",
                    mafOk, string.Join(", ", maf.Select(f => f.Key)));
                Add(report, "Audit#4: intermittent-grammar faults are volatile (per-instance flag)",
                    maf.Count > 0 && maf.All(f => f.Volatile), maf.Count > 0 ? maf[0].Key : "no faults");
                // Cross-vehicle NON-contamination: a plain (non-intermittent) code hitting the SAME
                // component key after an intermittent one must NOT inherit volatility. Volatility is
                // per-scan on the returned instance, never latched into the process-global registry.
                var mafPlain = DtcFaultModel.Expand("P0100", "Mass Air Flow Sensor Circuit");
                Add(report, "Audit#4: a later PLAIN code on the same component is NOT contaminated volatile",
                    mafPlain.Count > 0 && mafPlain.All(f => !f.Volatile),
                    mafPlain.Count > 0 ? $"{mafPlain[0].Key} vol={mafPlain[0].Volatile}" : "no faults");
                var runner = DtcFaultModel.Expand("P2004", "Intake Manifold Runner Control Stuck Open Bank 1");
                bool runnerOk = runner.Any(f => f.Key.StartsWith("ActStuck@", StringComparison.OrdinalIgnoreCase))
                                && !runner.Any(f => f.Key.StartsWith("Open@", StringComparison.OrdinalIgnoreCase));
                Add(report, "Audit#6: 'Stuck Open' is a stuck actuator, NOT an open circuit",
                    runnerOk, string.Join(", ", runner.Select(f => f.Key)));

                // #7 Trailing qualifiers no longer defeat component extraction: the grammar is
                // stripped from labels, and Bank-1/Bank-2 sensors keep DISTINCT fault keys.
                var o2b1 = DtcFaultModel.Expand("P0131", "O2 Sensor Circuit Low Voltage Bank 1 Sensor 1");
                var o2b2 = DtcFaultModel.Expand("P0151", "O2 Sensor Circuit Low Voltage Bank 2 Sensor 1");
                bool o2Split = o2b1.Count > 0 && o2b2.Count > 0
                               && o2b1.All(f => !f.Label.ToLowerInvariant().Contains("circuit low"))
                               && !o2b1.Select(f => f.Key).Intersect(o2b2.Select(f => f.Key), StringComparer.OrdinalIgnoreCase).Any();
                Add(report, "Audit#7: grammar stripped from labels; Bank1 vs Bank2 sensors keep distinct keys",
                    o2Split, $"B1=[{string.Join(",", o2b1.Select(f => f.Key))}] B2=[{string.Join(",", o2b2.Select(f => f.Key))}]");
                Add(report, "Audit#4: a plain (non-intermittent) circuit code is NOT volatile",
                    o2b1.Count > 0 && o2b1.All(f => !f.Volatile),
                    o2b1.Count > 0 ? o2b1[0].Key : "no faults");

                // #1 An incidental stored code's connector hypothesis must NOT outrank the canonical
                // drivability fault the tech is actually chasing (was: flat 0.85 likelihood made
                // "corroded connector" the #1 fault on every scan with any extra circuit code).
                var m6 = new Tier1.BayesianHypothesisModule();
                var lean = Base();
                lean.AddDtc(new DiagnosticDtc { Code = "P0171", StatusByte = 0x08, ModuleName = "PCM", Description = "System Too Lean Bank 1" });
                lean.AddDtc(new DiagnosticDtc { Code = "C0035", StatusByte = 0x00, ModuleName = "ABS", Description = "Left Front Wheel Speed Sensor Circuit" });
                var frontier = m6.Analyze(lean, null).FirstOrDefault(r => r.RankedFaults != null)?.RankedFaults;
                bool canonicalLeads = frontier != null && frontier.Count > 0 && frontier[0].FaultKey == "VacuumLeak";
                Add(report, "Audit#1: canonical fault (vacuum leak) outranks the incidental code's connector hypothesis",
                    canonicalLeads, frontier == null ? "no frontier" : string.Join(" > ", frontier.Take(4).Select(f => f.FaultKey)));

                // #3 Three codes naming ONE component (P0121/22/23 = one TPS) are ONE physical
                // witness: the shared connector hypothesis collapses to a single contribution and
                // stays far from certainty, with the swallowed code named in the annotation.
                var tps = Base();
                tps.AddDtc(new DiagnosticDtc { Code = "P0121", StatusByte = 0x08, ModuleName = "PCM", Description = "Throttle Position Sensor A Range/Performance" });
                tps.AddDtc(new DiagnosticDtc { Code = "P0122", StatusByte = 0x08, ModuleName = "PCM", Description = "Throttle Position Sensor A Circuit Low" });
                tps.AddDtc(new DiagnosticDtc { Code = "P0123", StatusByte = 0x08, ModuleName = "PCM", Description = "Throttle Position Sensor A Circuit High" });
                var tpsFrontier = m6.Analyze(tps, null).FirstOrDefault(r => r.RankedFaults != null)?.RankedFaults;
                var tpsHr = tpsFrontier?.FirstOrDefault(f => f.FaultKey.StartsWith("Connector@", StringComparison.OrdinalIgnoreCase));
                bool collapsed = tpsHr != null && tpsHr.Contributions.Count == 1
                                 && tpsHr.Posterior < 0.60
                                 && tpsHr.Contributions[0].Source.Contains("counted once")
                                 && tpsHr.Contributions[0].Source.Contains("P0123");
                Add(report, "Audit#3: P0121/22/23 on one TPS collapse to ONE connector witness (not 98% certainty)",
                    collapsed, tpsHr == null ? "no connector hypothesis"
                             : $"contribs={tpsHr.Contributions.Count} posterior={tpsHr.Posterior:0.###} src={tpsHr.Contributions[0].Source}");

                // #2 Flood-proof banding: on a big diluted frontier the leader can still band
                // "Leading" via the ABSOLUTE posterior gap; without a real gap it stays Contending.
                var flatShares = Enumerable.Repeat(1.0 / 15, 15).ToList();
                var ahead = FaultBanding.BandShares(flatShares, 0.92, 0.70);
                var tied  = FaultBanding.BandShares(flatShares, 0.72, 0.70);
                Add(report, "Audit#2: diluted frontier — decisive absolute gap bands Leading; near-tie stays Contending",
                    ahead[0] == FaultBand.Leading && tied[0] == FaultBand.Contending,
                    $"ahead={FaultBanding.Label(ahead[0])} tied={FaultBanding.Label(tied[0])}");

                // #2 Frontier cap: a many-code car reports the suppressed structural tail honestly
                // and the ranked frontier stays bounded (canonical faults are never capped).
                var flood = Base();
                string[] comps = { "Alpha Sensor", "Bravo Sensor", "Charlie Sensor", "Delta Sensor", "Echo Sensor", "Foxtrot Sensor" };
                for (int i = 0; i < comps.Length; i++)
                    flood.AddDtc(new DiagnosticDtc { Code = $"P09{i + 10}", StatusByte = 0x08, ModuleName = "PCM", Description = comps[i] + " Circuit Low" });
                var floodTop = m6.Analyze(flood, null).FirstOrDefault(r => r.RankedFaults != null);
                int structCount = floodTop?.RankedFaults.Count(f => f.FaultKey.Contains("@")) ?? -1;
                bool capNoted = floodTop != null && floodTop.Evidence.Steps.Any(s => (s.Signal ?? "").Contains("Frontier cap"));
                Add(report, "Audit#2: structural frontier capped at 8 with the suppression reported in evidence",
                    structCount >= 1 && structCount <= 8 && capNoted,
                    $"structural={structCount} capNoted={capNoted}");
            }

            return report;
        }

        // ── engine + stub stores ────────────────────────────────────────────
        private static DiagnosticEngine NewEngine(out StubFleetStore fleet, out StubFixedByStore fixedBy)
        {
            fleet = new StubFleetStore();
            fixedBy = new StubFixedByStore();
            return new DiagnosticEngine { Fleet = fleet, FixedBy = fixedBy }.RegisterBuiltIns();
        }

        private static void Add(SelfTestReport report, string name, bool passed, string detail)
            => report.Cases.Add(new SelfTestCase { Name = name, Passed = passed, Detail = detail });

        // ── synthetic snapshot builders (KNOWN ground truth) ────────────────

        private static DiagnosticSnapshot Base(int cyls = 4)
            => new DiagnosticSnapshot { CapturedUtc = T0, Oem = OEMManufacturer.Generic, Platform = "Generic", CylinderCount = cyls };

        private static void Fill(DiagnosticSnapshot s, string name, Func<int, double> f, int n = 60, double hz = 20)
        {
            double dt = 1.0 / hz;
            for (int i = 0; i < n; i++) s.AddSignal(name, f(i), T0.AddSeconds(i * dt));
        }

        /// <summary>Warm idle, healthy trims — must not trip fuel/crank modules.</summary>
        private static DiagnosticSnapshot HealthyIdle()
        {
            var s = Base();
            Fill(s, CanonicalSignals.Rpm, i => 700 + (i % 3) - 1);
            Fill(s, CanonicalSignals.EngineLoad, i => 22 + (i % 2));
            Fill(s, CanonicalSignals.StftB1, i => 1 + ((i % 4) - 2) * 0.5);
            Fill(s, CanonicalSignals.LtftB1, i => 2);
            Fill(s, CanonicalSignals.Map, i => 33);
            Fill(s, CanonicalSignals.Maf, i => 3.2);
            Fill(s, CanonicalSignals.IntakeAirTemp, i => 25);
            Fill(s, CanonicalSignals.BatteryVoltage, i => 14.2);
            return s;
        }

        /// <summary>Lean at idle/low load, normal under load = vacuum leak.  Spread across a
        /// real surface (3 low-load RPM cells + 3 high-load RPM cells = 6 populated cells over
        /// a ≥2× load span) so M1's data-sufficiency gate is met and it classifies the pattern
        /// rather than reporting insufficient coverage.</summary>
        private static DiagnosticSnapshot VacuumLeakSurface(bool withLeanDtc = false)
        {
            var s = Base();
            double[] lowRpm  = { 700, 1800, 2800 }; // three distinct RPM cells, low load, lean
            double[] highRpm = { 3200, 4200, 5200 }; // three distinct RPM cells, high load, normal
            int i = 0;
            for (int pass = 0; pass < 30; pass++)
            {
                foreach (var rpm in lowRpm)
                {
                    s.AddSignal(CanonicalSignals.Rpm, rpm, T0.AddSeconds(i * 0.05));
                    s.AddSignal(CanonicalSignals.EngineLoad, 20, T0.AddSeconds(i * 0.05));
                    s.AddSignal(CanonicalSignals.StftB1, 3, T0.AddSeconds(i * 0.05));
                    s.AddSignal(CanonicalSignals.LtftB1, 20, T0.AddSeconds(i * 0.05)); // strongly lean at low load
                    i++;
                }
                foreach (var rpm in highRpm)
                {
                    s.AddSignal(CanonicalSignals.Rpm, rpm, T0.AddSeconds(i * 0.05));
                    s.AddSignal(CanonicalSignals.EngineLoad, 72, T0.AddSeconds(i * 0.05));
                    s.AddSignal(CanonicalSignals.StftB1, 1, T0.AddSeconds(i * 0.05));
                    s.AddSignal(CanonicalSignals.LtftB1, 1, T0.AddSeconds(i * 0.05)); // normal under load
                    i++;
                }
            }
            if (withLeanDtc) s.AddDtc(new DiagnosticDtc { Code = "P0171", StatusByte = 0x08, Description = "System too lean (bank 1)" });
            return s;
        }

        /// <summary>Uniform lean across all cells = MAF/fuel bias.</summary>
        private static DiagnosticSnapshot UniformLeanSurface()
        {
            var s = Base();
            for (int i = 0; i < 120; i++)
            {
                double rpm = 800 + (i % 6) * 800;
                double load = 15 + (i % 6) * 14;
                s.AddSignal(CanonicalSignals.Rpm, rpm, T0.AddSeconds(i * 0.05));
                s.AddSignal(CanonicalSignals.EngineLoad, load, T0.AddSeconds(i * 0.05));
                s.AddSignal(CanonicalSignals.StftB1, 4, T0.AddSeconds(i * 0.05));
                s.AddSignal(CanonicalSignals.LtftB1, 13, T0.AddSeconds(i * 0.05)); // lean everywhere
            }
            return s;
        }

        /// <summary>Cranking RPM with ~20% coefficient of variation = uneven compression.</summary>
        private static DiagnosticSnapshot UnevenCompressionCrank()
        {
            var s = Base(6);
            // Deep, clearly-uneven cranking ripple → CoV well above the ~18% gate
            // (mean ~155, swings ±35 → CoV ≈ 23%). Unambiguous weak-cylinder case.
            double[] pattern = { 190, 120, 195, 115, 188, 122, 192, 118 };
            for (int i = 0; i < 48; i++)
                s.AddSignal(CanonicalSignals.Rpm, pattern[i % pattern.Length], T0.AddSeconds(i / 15.0));
            return s;
        }

        /// <summary>Two modules on the same HS-CAN both lost-comm = shared-bus fault.</summary>
        private static DiagnosticSnapshot SharedBusFault()
        {
            var s = Base();
            s.AddModule(new ModuleNode { TxId = 0x7E0, Name = "PCM", Bus = VehicleBus.HsCan, Present = true });
            s.AddModule(new ModuleNode { TxId = 0x760, Name = "ABS", Bus = VehicleBus.HsCan, Present = true });
            s.AddModule(new ModuleNode { TxId = 0x720, Name = "IPC", Bus = VehicleBus.MsCan, Present = true, IsGateway = true });
            s.AddDtc(new DiagnosticDtc { Code = "U0100", StatusByte = 0x08, ModuleTxId = 0x720, Description = "Lost comm with PCM" });
            s.AddDtc(new DiagnosticDtc { Code = "U0121", StatusByte = 0x08, ModuleTxId = 0x720, Description = "Lost comm with ABS" });
            return s;
        }

        /// <summary>MAF steady then a single spike to zero and back = intermittent dropout.</summary>
        private static DiagnosticSnapshot MafDropout()
        {
            var s = Base();
            for (int i = 0; i < 60; i++)
            {
                double v = (i == 30) ? 0.0 : 5.0 + ((i % 3) - 1) * 0.05;
                s.AddSignal(CanonicalSignals.Maf, v, T0.AddSeconds(i * 0.05));
            }
            return s;
        }

        /// <summary>Idle with LTFT far above the primed fleet mean = fleet outlier.</summary>
        private static DiagnosticSnapshot FleetOutlier()
        {
            var s = Base();
            Fill(s, CanonicalSignals.Rpm, i => 750);
            Fill(s, CanonicalSignals.EngineLoad, i => 25);
            Fill(s, CanonicalSignals.LtftB1, i => 18); // fleet mean ~2 ± 3 => z ~ 5
            return s;
        }

        /// <summary>MAF reads ~40% below the speed-density prediction = air-metering inconsistency.</summary>
        private static DiagnosticSnapshot MafUnderReport()
        {
            var s = Base();
            // UNDER LOAD (where speed-density is valid): RPM 2500, MAP 80 kPa, IAT 25C, Vd 2.0L,
            // VE 0.85 → predicted MAF ~33 g/s; measured 20 g/s = ~40% low = a genuinely dirty MAF.
            // (Idle MAP would make a HEALTHY MAF look low — the load gate now rejects that regime.)
            Fill(s, CanonicalSignals.Rpm, i => 2500);
            Fill(s, CanonicalSignals.Map, i => 80);
            Fill(s, CanonicalSignals.IntakeAirTemp, i => 25);
            Fill(s, CanonicalSignals.Maf, i => 20.0);   // ~40% below the speed-density prediction
            Fill(s, CanonicalSignals.EngineLoad, i => 60);
            Fill(s, CanonicalSignals.LtftB1, i => 15);  // lean corroborates MAF under-report
            return s;
        }

        /// <summary>Flat idle RPM at OBD PID rate with ≥64 samples — enough for T8 to REACH
        /// its sample-rate gate (MIN_SAMPLES=64), but far below the ~500 Hz crank
        /// reconstruction needs, so T8 must report "unavailable at this data rate".</summary>
        private static DiagnosticSnapshot ObdRateCrankStream()
        {
            var s = Base();
            Fill(s, CanonicalSignals.Rpm, i => 800 + (i % 5) - 2, 80, 10);
            return s;
        }

        /// <summary>Cranking battery voltage sagging below the floor = weak battery/starter.</summary>
        private static DiagnosticSnapshot WeakBatteryCrank()
        {
            var s = Base();
            for (int i = 0; i < 40; i++)
            {
                double rpm = 250;                    // cranking
                double v = 8.9 + (i % 3) * 0.1;      // below the 9.6V floor
                s.AddSignal(CanonicalSignals.Rpm, rpm, T0.AddSeconds(i * 0.05));
                s.AddSignal(CanonicalSignals.BatteryVoltage, v, T0.AddSeconds(i * 0.05));
            }
            return s;
        }

        // ── regression snapshots for the confirmed review defects ──

        /// <summary>Global lean bias (~12%) roughly uniform with a mild upward gradient:
        /// low-load ~11%, high-load ~13%. Idle is itself lean, so it must NOT read as a
        /// fuel-delivery shortfall.</summary>
        private static DiagnosticSnapshot UniformLeanGradient()
        {
            var s = Base();
            double[] lowRpm  = { 800, 1800, 2800 };  // low-load band, ~11% total
            double[] highRpm = { 3200, 4200, 5200 }; // high-load band, ~13% total
            int i = 0;
            for (int pass = 0; pass < 30; pass++)
            {
                foreach (var rpm in lowRpm)
                {
                    s.AddSignal(CanonicalSignals.Rpm, rpm, T0.AddSeconds(i * 0.05));
                    s.AddSignal(CanonicalSignals.EngineLoad, 22, T0.AddSeconds(i * 0.05));
                    s.AddSignal(CanonicalSignals.StftB1, 1, T0.AddSeconds(i * 0.05));
                    s.AddSignal(CanonicalSignals.LtftB1, 10, T0.AddSeconds(i * 0.05)); // total 11
                    i++;
                }
                foreach (var rpm in highRpm)
                {
                    s.AddSignal(CanonicalSignals.Rpm, rpm, T0.AddSeconds(i * 0.05));
                    s.AddSignal(CanonicalSignals.EngineLoad, 70, T0.AddSeconds(i * 0.05));
                    s.AddSignal(CanonicalSignals.StftB1, 1, T0.AddSeconds(i * 0.05));
                    s.AddSignal(CanonicalSignals.LtftB1, 12, T0.AddSeconds(i * 0.05)); // total 13
                    i++;
                }
            }
            return s;
        }

        /// <summary>Healthy start: 18 even cranking samples (~250 RPM) then a normal
        /// catch-ramp toward idle (470→800). The ramp is above idleLo(450) and must be
        /// excluded from the cranking CoV.</summary>
        private static DiagnosticSnapshot HealthyCrankCatch()
        {
            var s = Base(6);
            double[] crank = { 250, 245, 255, 248, 252, 247, 253, 249, 251, 246, 254, 250, 248, 252, 249, 251, 247, 253 };
            for (int i = 0; i < crank.Length; i++) s.AddSignal(CanonicalSignals.Rpm, crank[i], T0.AddSeconds(i / 15.0));
            double[] ramp = { 470, 540, 610, 680, 750, 800, 470, 540, 610, 680, 750, 800 };
            for (int i = 0; i < ramp.Length; i++) s.AddSignal(CanonicalSignals.Rpm, ramp[i], T0.AddSeconds((crank.Length + i) / 15.0));
            return s;
        }

        /// <summary>EBCM (HS-CAN) added before BCM (MS-CAN); U0140 targets BCM, U0100
        /// targets PCM (HS-CAN). Correct resolution spans two buses → gateway/backbone,
        /// NOT a shared HS-CAN fault (which the EBCM/BCM substring collision produced).</summary>
        private static DiagnosticSnapshot CrossBusNotShared()
        {
            var s = Base();
            s.AddModule(new ModuleNode { TxId = 0x760, Name = "EBCM", Bus = VehicleBus.HsCan, Present = true });
            s.AddModule(new ModuleNode { TxId = 0x726, Name = "BCM", Bus = VehicleBus.MsCan, Present = true });
            s.AddModule(new ModuleNode { TxId = 0x7E0, Name = "PCM", Bus = VehicleBus.HsCan, Present = true });
            s.AddModule(new ModuleNode { TxId = 0x716, Name = "Gateway", Bus = VehicleBus.MsCan, Present = true, IsGateway = true });
            s.AddDtc(new DiagnosticDtc { Code = "U0140", StatusByte = 0x08, ModuleTxId = 0x716, Description = "Lost communication with BCM" });
            s.AddDtc(new DiagnosticDtc { Code = "U0100", StatusByte = 0x08, ModuleTxId = 0x716, Description = "Lost communication with PCM" });
            return s;
        }

        /// <summary>RPM running (800→3000) then engine shut off (0 tail) — the zero run is a
        /// legitimate off-state, not a stuck sensor.</summary>
        private static DiagnosticSnapshot EngineOffZeroTail()
        {
            var s = Base();
            for (int i = 0; i <= 40; i++) s.AddSignal(CanonicalSignals.Rpm, 800 + i * 55, T0.AddSeconds(i * 0.1));
            for (int i = 41; i <= 70; i++) s.AddSignal(CanonicalSignals.Rpm, 0, T0.AddSeconds(i * 0.1));
            return s;
        }

        /// <summary>A healthy damped RPM ring after a throttle blip (decays out over the
        /// window, few peaks) — must not be called a sustained limit cycle.</summary>
        private static DiagnosticSnapshot DampedTransient()
        {
            var s = Base();
            const double fs = 10.0;
            for (int i = 0; i < 40; i++)
            {
                double t = i / fs;
                double v = 800 + 120 * Math.Exp(-0.9 * t) * Math.Sin(2 * Math.PI * 0.5 * t);
                s.AddSignal(CanonicalSignals.Rpm, v, T0.AddSeconds(t));
            }
            return s;
        }

        /// <summary>Speed-density engine (MAP present, NO MAF) running slightly lean.
        /// T2/T3 must not fabricate a MAF fault; T2 should instead note speed-density.</summary>
        private static DiagnosticSnapshot SpeedDensityNoMaf()
        {
            var s = Base();
            s.AirMetering = AirMeteringKind.SpeedDensityMap;
            Fill(s, CanonicalSignals.Rpm, i => 820);
            Fill(s, CanonicalSignals.Map, i => 36);
            Fill(s, CanonicalSignals.IntakeAirTemp, i => 26);
            Fill(s, CanonicalSignals.EngineLoad, i => 26);
            Fill(s, CanonicalSignals.LtftB1, i => 14);
            // NO MAF signal added — this engine meters air by speed-density.
            return s;
        }

        /// <summary>A one-step ConfirmationScript whose only step is active-control — for safety-gate tests.</summary>
        private static ConfirmationScript ActiveStepScript(byte sid, byte[] payload)
        {
            return new ConfirmationScript
            {
                Name = "safety-test",
                Steps = new List<ConfirmationStep>
                {
                    new ConfirmationStep { Description = "active command", ServiceId = sid, Payload = payload, IsActiveControl = true, ExpectedObservation = "n/a" }
                }
            };
        }

        /// <summary>A controlled M6 frontier for the Investigation-Tree walk: the P0171 lean
        /// triad with a vacuum leak clearly best-supported by the evidence, MAF error
        /// contending, fuel-delivery trailing. Tests the TREE's mechanics against a
        /// known-correct frontier — real module firing is covered by the other cases.</summary>
        private static DiagnosticRunResult LeanFrontierRun()
        {
            var faults = new List<RankedFault>
            {
                new RankedFault { FaultKey = "VacuumLeak",   Label = "vacuum / intake-air leak", LogOdds = 1.6 },
                new RankedFault { FaultKey = "MafError",     Label = "MAF metering error",        LogOdds = 0.3 },
                new RankedFault { FaultKey = "FuelDelivery", Label = "fuel-delivery shortfall",   LogOdds = 0.0 },
            };
            Func<double, double> sig = x => 1.0 / (1.0 + Math.Exp(-x));
            double sum = faults.Sum(f => sig(f.LogOdds));
            for (int i = 0; i < faults.Count; i++)
            {
                faults[i].Posterior = sig(faults[i].LogOdds);
                faults[i].NormShare = faults[i].Posterior / sum;
                faults[i].Rank = i + 1;
            }
            FaultBanding.Assign(faults);

            var m6 = new DiagnosticResult
            {
                ModuleId = "M6",
                Title = "Most-likely fault: vacuum / intake-air leak",
                Hypothesis = "Bayesian ranking places vacuum / intake-air leak first from the lean code.",
                NextTest = "Watch fuel trim as airflow rises to high load: a vacuum leak's correction "
                         + "NORMALISES under load; a MAF metering error's does NOT.",
                RankedFaults = faults,
            };
            var run = new DiagnosticRunResult();
            run.Results.Add(m6);
            run.RankedFaults = faults;
            return run;
        }

        // ── in-memory stub stores ───────────────────────────────────────────
        private sealed class StubFleetStore : IFleetStore
        {
            private readonly Dictionary<string, WelfordAccumulator> _c = new Dictionary<string, WelfordAccumulator>();
            private static string K(string p, string s, int x, int y) => $"{p}|{s}|{x}|{y}";
            public void Record(string platform, string signal, int cellX, int cellY, double value)
            {
                string k = K(platform, signal, cellX, cellY);
                _c.TryGetValue(k, out var a); a.Add(value); _c[k] = a;
            }
            public FleetStat Query(string platform, string signal, int cellX, int cellY)
            {
                if (_c.TryGetValue(K(platform, signal, cellX, cellY), out var a))
                    return new FleetStat { Count = a.Count, Mean = a.Mean, StdDev = a.StdDev, Min = a.Min, Max = a.Max };
                return new FleetStat { Count = 0 };
            }
            public long TotalObservations(string platform, string signal)
                => _c.Where(kv => kv.Key.StartsWith(platform + "|" + signal + "|", StringComparison.Ordinal)).Sum(kv => kv.Value.Count);
            public void Flush() { }
        }

        private sealed class StubFixedByStore : IFixedByStore
        {
            public void Record(string platform, string symptomKey, string fixAction, bool success) { }
            public IReadOnlyList<FixOutcome> Query(string platform, string symptomKey) => Array.Empty<FixOutcome>();
            public void Flush() { }
        }

        /// <summary>Functional in-memory repair-history store for the E3 round-trip + keystone tests.</summary>
        private sealed class MemFixedByStore : IFixedByStore
        {
            private readonly Dictionary<string, Dictionary<string, int[]>> _cells =
                new Dictionary<string, Dictionary<string, int[]>>(StringComparer.OrdinalIgnoreCase);
            private static string K(string p, string s) => (p ?? "") + "|" + (s ?? "");
            public void Record(string platform, string symptomKey, string fixAction, bool success)
            {
                if (string.IsNullOrWhiteSpace(fixAction)) return;
                string k = K(platform, symptomKey);
                if (!_cells.TryGetValue(k, out var cell)) { cell = new Dictionary<string, int[]>(StringComparer.OrdinalIgnoreCase); _cells[k] = cell; }
                if (!cell.TryGetValue(fixAction.Trim(), out var t)) { t = new int[2]; cell[fixAction.Trim()] = t; }
                t[0]++; if (success) t[1]++;
            }
            public IReadOnlyList<FixOutcome> Query(string platform, string symptomKey)
            {
                if (!_cells.TryGetValue(K(platform, symptomKey), out var cell)) return Array.Empty<FixOutcome>();
                return cell.Select(kv => new FixOutcome { FixAction = kv.Key, Count = kv.Value[0], SuccessCount = kv.Value[1] }).ToList();
            }
            public void Flush() { }
        }

        private static DiagnosticEngine NewEngineFixedBy(IFixedByStore fixedBy)
            => new DiagnosticEngine { Fleet = new StubFleetStore(), FixedBy = fixedBy }.RegisterBuiltIns();

        /// <summary>Minimal FordFG snapshot with a P0171 — M6 composes VacuumLeak/MafError/FuelDelivery from it.</summary>
        private static DiagnosticSnapshot BuildLeanSnap(string platform)
        {
            var s = new DiagnosticSnapshot { CapturedUtc = T0, Oem = OEMManufacturer.Generic, Platform = platform, CylinderCount = 6 };
            s.AddDtc(new DiagnosticDtc { Code = "P0171", StatusByte = 0x08, Description = "System too lean (bank 1)" });
            return s;
        }
    }
}
