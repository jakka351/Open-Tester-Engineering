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
//  Tester Present Specialist Automotive Solutions — Diagnostic Engine (module runner)
//
//  Holds the registered intelligence modules, resolves the platform calibration
//  for the connected vehicle, builds the shared DiagnosticContext (calibration +
//  fleet/fixed-by stores + log sink + active-control gate), and runs every
//  applicable module over a snapshot.  Modules that cannot run are skipped with a
//  recorded reason rather than producing garbage.  Results are aggregated and
//  ranked severity-then-confidence.
//
//  The engine is the single integration point between the pure modules and the
//  rest of TES: the host captures data via OBDonUDSManager / UDSManager / the
//  topology scan, packs it into a DiagnosticSnapshot, and calls Run().
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;

namespace TesterPresent.OBD2.Intelligence
{
    /// <summary>The aggregated outcome of one engine run over a snapshot.</summary>
    public sealed class DiagnosticRunResult
    {
        public DateTime RanUtc { get; set; } = DateTime.UtcNow;
        public PlatformCalibration Calibration { get; set; }
        /// <summary>All hypotheses, ranked most-severe / most-confident first.</summary>
        public List<DiagnosticResult> Results { get; set; } = new List<DiagnosticResult>();
        /// <summary>Modules that did not run, with a human reason.</summary>
        public List<SkippedModule> Skipped { get; set; } = new List<SkippedModule>();

        /// <summary>The full ranked fault frontier from M6 (every live hypothesis, lossless).
        /// Null when M6 didn't run / had nothing to compose. The Investigation Tree seeds its
        /// hypothesis nodes from this.</summary>
        public IReadOnlyList<RankedFault> RankedFaults { get; set; }

        public bool AnyFindings => Results != null && Results.Count > 0;
        public int FindingCount => Results?.Count ?? 0;

        /// <summary>Highest-confidence finding, or null.</summary>
        public DiagnosticResult Top => (Results != null && Results.Count > 0) ? Results[0] : null;

        /// <summary>Whether every finding is advisory (uncalibrated / thin data).</summary>
        public bool AllAdvisory => Results != null && Results.Count > 0 && Results.All(r => r.Advisory);
    }

    public sealed class SkippedModule
    {
        public string ModuleId { get; set; }
        public string DisplayName { get; set; }
        public string Reason { get; set; }
    }

    /// <summary>
    /// Runs a set of IDiagnosticModule over snapshots.  Register modules once,
    /// then call Run() per capture.  Thread-affine per call; safe to reuse across
    /// calls.  Never throws out of Run — a misbehaving module is caught inside
    /// DiagnosticModuleBase and yields no results.
    /// </summary>
    public sealed class DiagnosticEngine
    {
        private readonly List<IDiagnosticModule> _modules = new List<IDiagnosticModule>();

        public IFleetStore Fleet { get; set; }
        public IFixedByStore FixedBy { get; set; }
        public Action<string> Log { get; set; }
        /// <summary>Host-set: whether the operator authorised active-control tests this session.</summary>
        public bool AllowActiveControl { get; set; }

        public IReadOnlyList<IDiagnosticModule> Modules => _modules;

        public DiagnosticEngine Register(IDiagnosticModule module)
        {
            if (module != null && !_modules.Any(m => m.ModuleId == module.ModuleId))
                _modules.Add(module);
            return this;
        }

        public DiagnosticEngine RegisterRange(IEnumerable<IDiagnosticModule> modules)
        {
            if (modules != null) foreach (var m in modules) Register(m);
            return this;
        }

        /// <summary>Register every built-in Tier-1 and Tier-2 module. Safe to call once.</summary>
        public DiagnosticEngine RegisterBuiltIns()
        {
            RegisterRange(ModuleCatalog.CreateAll());
            return this;
        }

        /// <summary>Run all applicable modules over a snapshot and aggregate the results.</summary>
        public DiagnosticRunResult Run(DiagnosticSnapshot snapshot)
        {
            IntelligenceBootstrap.EnsureRegistered();

            var run = new DiagnosticRunResult { RanUtc = DateTime.UtcNow };
            if (snapshot == null) return run;

            var calibration = CalibrationRegistry.Resolve(snapshot.Oem, snapshot.Vin);
            run.Calibration = calibration;

            var ctx = new DiagnosticContext
            {
                Calibration = calibration,
                Fleet = Fleet,
                FixedBy = FixedBy,
                LogSink = Log,
                AllowActiveControl = AllowActiveControl,
            };
            // Composing modules (M6 Bayesian, M7 confirmation) read earlier
            // hypotheses through ctx.PriorResults.  run.Results is a live list;
            // as each module appends, later modules see the accumulated set.
            // Register composing modules LAST so their inputs are populated.
            ctx.PriorResults = run.Results;

            foreach (var module in _modules)
            {
                try
                {
                    string unmet = module.Requirements != null
                        ? module.Requirements.UnmetReason(snapshot, ctx)
                        : null;
                    if (unmet != null)
                    {
                        run.Skipped.Add(new SkippedModule
                        {
                            ModuleId = module.ModuleId,
                            DisplayName = module.DisplayName,
                            Reason = unmet,
                        });
                        continue;
                    }

                    var results = module.Analyze(snapshot, ctx);
                    if (results != null && results.Count > 0)
                        run.Results.AddRange(results.Where(r => r != null));
                    else
                        run.Skipped.Add(new SkippedModule
                        {
                            ModuleId = module.ModuleId,
                            DisplayName = module.DisplayName,
                            Reason = "ran, no finding",
                        });
                }
                catch (Exception ex)
                {
                    ctx.Log($"[engine] module {module.ModuleId} threw: {ex.Message}");
                    run.Skipped.Add(new SkippedModule
                    {
                        ModuleId = module.ModuleId,
                        DisplayName = module.DisplayName,
                        Reason = "error: " + ex.Message,
                    });
                }
            }

            // Rank: severity desc, then confidence desc, then non-advisory first.
            run.Results = run.Results
                .OrderByDescending(r => (int)r.Severity)
                .ThenByDescending(r => r.Confidence)
                .ThenBy(r => r.Advisory ? 1 : 0)
                .ToList();

            // Hoist M6's lossless ranked frontier onto the run result for the Investigation Tree.
            foreach (var r in run.Results)
                if (r.RankedFaults != null) { run.RankedFaults = r.RankedFaults; break; }

            return run;
        }
    }
}
