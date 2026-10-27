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
//  Tester Present Specialist Automotive Solutions — M3 U-Code Bus-Fault Localization (Tier-1)
//
//  A scan that returns "12 U-codes" invites the parts-cannon: replace twelve
//  modules.  Almost always wrong.  A lost-communication code (SAE J2012 family
//  'U') is set BY a module that noticed a peer go silent — it names the peer it
//  lost, not itself.  When several silent peers turn out to sit on the SAME
//  physical bus, the fault is not twelve dead modules; it is ONE shared segment:
//  a broken CAN pair, a missing/failed terminating resistor (the bus wants ~60 Ω
//  = two 120 Ω terminators in parallel), or a gateway that stopped forwarding.
//
//  This module builds the platform topology, resolves each U-code to the module
//  it implicates (the lost TARGET where identifiable, else the reporting module
//  as anchor), groups the implicated modules by bus, and inverts the pattern:
//
//    • ≥ 2 implicated modules on ONE bus   → shared-bus / wiring / terminator /
//      gateway fault on that segment — measure the bus, do NOT swap the modules
//    • exactly 1 implicated module         → isolated module/branch fault
//    • implicated modules spread over many → gateway / backbone / independent
//      buses with no dominant segment        faults — verify the gateway first
//
//  It emits an evidence chain (each contributing U-code as a Fail step, the
//  shared segment as Info), a confidence that grows with the number of
//  co-located modules, and the single most discriminating next test — never a
//  bare "replace the ECU" verdict.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using TesterPresent.OBD2.Intelligence;

namespace TesterPresent.OBD2.Intelligence.Tier1
{
    /// <summary>
    /// M3 — U-Code Bus-Fault Localization.  Inverts a cluster of network (family
    /// 'U') DTCs against the CAN topology to decide whether the faults point at a
    /// SHARED bus segment (wiring / terminator / gateway) rather than at each
    /// individual module.  Reads the snapshot + context only; emits at most one
    /// ranked localization hypothesis.
    /// </summary>
    public sealed class BusFaultLocalizationModule : DiagnosticModuleBase
    {
        // A thin topology can't support a confident bus-level conclusion.
        private const int THIN_TOPOLOGY_NODES = 3;

        private DiagnosticRequirements _requirements;

        /// <summary>One U-code and the module it implicates (target where resolved, else reporter).</summary>
        private struct Implication
        {
            public DiagnosticDtc Dtc;
            public ModuleNode Node;      // the implicated module (never null once recorded)
            public bool TargetResolved;  // true if Node is the lost TARGET; false if it is the reporting anchor
        }

        /// <inheritdoc/>
        public override string ModuleId => "M3";

        /// <inheritdoc/>
        public override string DisplayName => "U-Code Bus-Fault Localization";

        /// <inheritdoc/>
        public override DiagnosticTier Tier => DiagnosticTier.Tier1;

        /// <inheritdoc/>
        public override DiagnosticRequirements Requirements =>
            _requirements ?? (_requirements = new DiagnosticRequirements
            {
                NeedsTopology = true,
                NeedsDtcs = true,
                MayRecommendActiveControl = false,
            });

        /// <summary>
        /// Localize the active U-codes: resolve each to an implicated module, group
        /// by bus, and classify the cluster as a shared-bus, isolated, or
        /// multi-bus/backbone fault.
        /// </summary>
        protected override IReadOnlyList<DiagnosticResult> AnalyzeCore(
            DiagnosticSnapshot snapshot, DiagnosticContext context)
        {
            var results = new List<DiagnosticResult>();
            bool usedUnvalidated = false;

            // ── Confidence anchors (spec-seeded until validated on a platform) ──
            int    minCoLocated = (int)Math.Round(Cal(context, "M3.MinCoLocated",  2.0,  ref usedUnvalidated));
            double conf2        = Cal(context, "M3.SharedBusConf2",   0.55, ref usedUnvalidated);
            double conf3        = Cal(context, "M3.SharedBusConf3",   0.70, ref usedUnvalidated);
            double conf4        = Cal(context, "M3.SharedBusConf4",   0.85, ref usedUnvalidated);
            double confIsolated = Cal(context, "M3.IsolatedConf",     0.50, ref usedUnvalidated);
            double confMultiBus = Cal(context, "M3.MultiBusConf",     0.38, ref usedUnvalidated);
            if (minCoLocated < 2) minCoLocated = 2;

            // ── Collect the network (U-family) DTCs ────────────────────────────
            var uCodes = (snapshot.NetworkDtcs ?? Enumerable.Empty<DiagnosticDtc>())
                         .Where(d => d != null && d.IsNetworkCode)
                         .ToList();
            if (uCodes.Count == 0) return results; // nothing to localize

            var topology = PlatformTopology.FromSnapshot(snapshot);

            // ── Resolve each U-code to the module it implicates ────────────────
            var implications = new List<Implication>();
            int unlocalizable = 0;
            foreach (var dtc in uCodes)
            {
                ModuleNode reporter = dtc.ModuleTxId != 0 ? topology.NodeByTx(dtc.ModuleTxId) : null;
                ModuleNode target = ResolveTargetNode(dtc, topology, reporter);
                ModuleNode implicated = target ?? reporter; // target preferred; reporter is the anchor fallback
                if (implicated == null) { unlocalizable++; continue; }
                implications.Add(new Implication
                {
                    Dtc = dtc,
                    Node = implicated,
                    TargetResolved = target != null,
                });
            }

            if (implications.Count == 0) return results; // couldn't tie any U-code to a known node

            // Distinct implicated modules (a module named by several U-codes counts once).
            var distinct = implications
                .GroupBy(i => i.Node.TxId)
                .Select(g => g.First().Node)
                .ToList();

            // Honesty flags: unvalidated anchors, thin topology, or Unknown-bus nodes.
            bool anyUnknownBus = distinct.Any(n => n.Bus == VehicleBus.Unknown);
            bool thinTopology = topology.ModuleCount < THIN_TOPOLOGY_NODES;
            bool advisory = usedUnvalidated
                            || context == null
                            || context.Calibration == null
                            || !context.Calibration.IsValidated
                            || thinTopology
                            || anyUnknownBus;
            string advisoryReason = BuildAdvisoryReason(usedUnvalidated, thinTopology, anyUnknownBus,
                                                         topology.ModuleCount, context);

            // A shared-bus conclusion may only rest on modules that actually WENT SILENT
            // (the resolved lost TARGETS), never on the reporting modules that named them:
            // a reporter is alive by definition (we just read its code), so grouping
            // reporters by bus and calling their bus faulted localizes to the WRONG side of
            // the break.  Co-location is therefore measured over the proven-silent set only.
            var silentTx = new HashSet<uint>(implications.Where(i => i.TargetResolved).Select(i => i.Node.TxId));
            var silentDistinct = distinct.Where(n => silentTx.Contains(n.TxId)).ToList();

            var busGroups = silentDistinct
                .Where(n => n.Bus != VehicleBus.Unknown)
                .GroupBy(n => n.Bus)
                .Select(g => new { Bus = g.Key, Count = g.Count() })
                .OrderByDescending(x => x.Count)
                .ToList();

            int dominantCount = busGroups.Count > 0 ? busGroups[0].Count : 0;
            VehicleBus dominantBus = busGroups.Count > 0 ? busGroups[0].Bus : VehicleBus.Unknown;

            // ── Classify ───────────────────────────────────────────────────────
            if (distinct.Count == 1)
            {
                // Exactly one module implicated (single U-code, or all U-codes name one peer).
                results.Add(BuildIsolated(distinct[0], implications, confIsolated,
                                          advisory, advisoryReason));
            }
            else if (dominantCount >= minCoLocated)
            {
                // Two or more SILENT modules co-located on one bus ⇒ shared segment.
                results.Add(BuildSharedBus(dominantBus, dominantCount, silentDistinct, implications, topology,
                                           conf2, conf3, conf4, unlocalizable,
                                           advisory, advisoryReason, snapshot.BusHealthFor(dominantBus)));
            }
            else
            {
                // Several modules implicated but no bus carries ≥2 proven-silent peers —
                // either the losses scatter across buses, or the targets couldn't be mapped
                // and we only have (alive) reporters.  Either way we cannot pin a single
                // segment: verify the gateway/backbone, don't condemn a leaf.
                results.Add(BuildMultiBus(distinct, implications, topology,
                                          confMultiBus, advisory, advisoryReason));
            }

            return results;
        }

        // ── Hypothesis builders ───────────────────────────────────────────────

        /// <summary>Two or more implicated modules share a bus ⇒ one segment fault, not N module faults.</summary>
        private DiagnosticResult BuildSharedBus(VehicleBus bus, int coLocated, List<ModuleNode> distinct,
            List<Implication> implications, PlatformTopology topology,
            double conf2, double conf3, double conf4, int unlocalizable,
            bool advisory, string advisoryReason, BusHealth busHealth)
        {
            string busName = BusLabel(bus);
            bool gatewayOnBus = topology.AnyGatewayOn(bus);
            var busMembers = distinct.Where(n => n.Bus == bus).ToList();
            int expectedTerm = busHealth != null ? busHealth.ExpectedTerminators : 2;
            double expectedOhms = expectedTerm >= 2 ? 60.0 : (expectedTerm == 1 ? 120.0 : 0.0);

            var r = NewResult($"Shared-bus communication fault on {busName}");
            r.Severity = DiagnosticSeverity.High;
            r.Confidence = SharedBusConfidence(coLocated, conf2, conf3, conf4);

            // Physical-layer corroboration: a measured bus-health verdict firms up or softens
            // the shared-segment conclusion. A dead/degraded bus with silent modules is a
            // strong shared-fault; a bus measured HEALTHY points back at the modules.
            if (busHealth != null && busHealth.State != BusHealthState.Unknown)
            {
                if (busHealth.State == BusHealthState.Dead)
                    r.Confidence = SignalMath.Clamp(r.Confidence + 0.15, 0.0, 0.97);
                else if (busHealth.State == BusHealthState.Degraded)
                    r.Confidence = SignalMath.Clamp(r.Confidence + 0.08, 0.0, 0.95);
                else if (busHealth.State == BusHealthState.Healthy)
                {
                    r.Confidence = SignalMath.Clamp(r.Confidence - 0.20, 0.10, 1.0);
                    r.Severity = DiagnosticSeverity.Medium;
                }
            }

            string members = string.Join(", ", busMembers.Select(n => n.Name));
            r.Hypothesis =
                $"{coLocated} modules that went silent ({members}) all sit on {busName}. A cluster of "
                + $"lost-communication codes localized to ONE bus points at a shared cause — a broken/"
                + $"shorted CAN pair, a missing or failed terminating resistor, or a gateway that stopped "
                + $"forwarding — NOT {coLocated} independently dead modules. "
                + (gatewayOnBus
                    ? "A gateway sits on this segment and is the prime suspect for the loss of forwarding."
                    : "Replacing the individual modules will not fix a wiring/terminator fault.");

            r.SuspectComponents = new List<string>
            {
                $"{busName} bus wiring / connector (open or short)",
                "Terminating resistor (120 Ω) — one missing drops the ~60 Ω pair reading",
            };
            if (gatewayOnBus)
                r.SuspectComponents.Insert(0, "Gateway module (stopped forwarding to this segment)");

            r.NextTest =
                $"Measure {busName} bus integrity: key off, ~60 Ω across CAN-H/CAN-L at the DLC (two 120 Ω "
                + "terminators in parallel). ~120 Ω = one terminator/branch lost; open or near-0 Ω = "
                + $"break or short. Inspect the {busName} harness and the gateway. Do NOT replace the "
                + "individual modules until the bus reads good.";

            // Evidence: coverage, each contributing U-code as a Fail, the shared segment as Info.
            r.Evidence.Info("Topology", $"{topology.ModuleCount} module(s) scanned",
                            $"{distinct.Count} distinct module(s) implicated by {implications.Count} U-code(s).");

            foreach (var im in implications.Where(i => i.Node.Bus == bus))
                r.Evidence.Fail(im.Dtc.Code ?? "U????",
                                DescribeImplication(im),
                                "module present & communicating",
                                DtcDetail(im.Dtc));

            r.Evidence.Info("Shared segment", busName,
                            $"{coLocated} of {distinct.Count} implicated module(s) co-located on {busName} "
                            + "— the common factor across these codes.");

            // Physical-layer evidence: expected terminator resistance, plus a measured
            // verdict if a bus-health check supplied one.
            if (expectedTerm > 0)
            {
                if (busHealth != null && busHealth.MeasuredResistanceOhms.HasValue)
                    r.Evidence.Measure($"{busName} termination", busHealth.MeasuredResistanceOhms.Value,
                                       expectedOhms * 0.85, expectedOhms * 1.15, "Ω",
                                       $"Expected ~{expectedOhms:0} Ω ({expectedTerm} × 120 Ω terminator(s) in parallel).");
                else
                    r.Evidence.Info($"{busName} expected termination", $"~{expectedOhms:0} Ω ({expectedTerm} terminators)",
                                    "The healthy dual-terminated reading — measure it at the DLC to confirm the segment.");
            }
            if (busHealth != null && busHealth.State != BusHealthState.Unknown)
            {
                var verdict = busHealth.State == BusHealthState.Healthy ? EvidenceVerdict.Pass
                            : busHealth.State == BusHealthState.Dead ? EvidenceVerdict.Fail
                            : EvidenceVerdict.Inconclusive;
                r.Evidence.Add($"{busName} health", busHealth.State.ToString(),
                               busHealth.State == BusHealthState.Healthy ? "degraded / dead ⇒ shared fault" : "healthy",
                               verdict,
                               (busHealth.Verdict ?? "")
                               + (string.IsNullOrEmpty(busHealth.ProbableFaultMode) ? "" : "  (" + busHealth.ProbableFaultMode + ")")
                               + (busHealth.State == BusHealthState.Healthy
                                   ? "  A healthy bus with silent modules points back at the modules, not the segment."
                                   : "  A degraded/dead segment corroborates the shared-bus fault."));
            }

            if (gatewayOnBus)
                r.Evidence.Info("Gateway", $"present on {busName}",
                                "A gateway on the affected segment is a prime suspect for lost forwarding.");
            if (unlocalizable > 0)
                r.Evidence.Inconclusive("Unmapped U-codes", $"{unlocalizable} code(s)", "mapped to a scanned node",
                                        "These U-codes named a module not present in the topology scan.");

            ApplyAdvisory(r, advisory, advisoryReason);
            return r;
        }

        /// <summary>Exactly one module implicated ⇒ that module's branch, not the bus backbone.</summary>
        private DiagnosticResult BuildIsolated(ModuleNode node, List<Implication> implications,
            double confidence, bool advisory, string advisoryReason)
        {
            string where = node.Bus != VehicleBus.Unknown ? $" on {BusLabel(node.Bus)}" : "";
            var r = NewResult($"Isolated module/branch fault ({node.Name})");
            r.Severity = DiagnosticSeverity.Medium;
            r.Confidence = SignalMath.Clamp(confidence, 0.0, 1.0);
            r.Hypothesis =
                $"Only one module — {node.Name}{where} — is implicated by the network codes. A single "
                + "silent module points at that module's own power, ground, or branch wiring/connector "
                + "rather than at the bus backbone, which is likely healthy (its peers are still talking).";
            r.SuspectComponents = new List<string>
            {
                $"{node.Name} power supply / ground",
                $"{node.Name} branch wiring / connector (stub off the backbone)",
                $"{node.Name} module (internal fault) — confirm only after wiring is cleared",
            };
            r.NextTest =
                $"Check {node.Name}'s battery/ignition feed and ground, and its branch wiring/connector to "
                + "the bus. Back-probe for power and a clean ground; wiggle-test the connector. The bus "
                + "backbone is likely healthy — verify it still reads ~60 Ω before condemning the module.";

            r.Evidence.Info("Topology", $"1 distinct module implicated",
                            $"{implications.Count} U-code(s) all resolve to {node.Name}.");
            foreach (var im in implications)
                r.Evidence.Fail(im.Dtc.Code ?? "U????", DescribeImplication(im),
                                "module present & communicating", DtcDetail(im.Dtc));
            r.Evidence.Info("Backbone", "not implicated",
                            "No second module on the same segment lost comms — the shared bus is presumed intact.");

            ApplyAdvisory(r, advisory, advisoryReason);
            return r;
        }

        /// <summary>Implicated modules scatter across buses with no dominant segment ⇒ gateway/backbone.</summary>
        private DiagnosticResult BuildMultiBus(List<ModuleNode> distinct, List<Implication> implications,
            PlatformTopology topology, double confidence, bool advisory, string advisoryReason)
        {
            var busList = distinct.Select(n => n.Bus).Where(b => b != VehicleBus.Unknown).Distinct().ToList();
            bool anyGateway = busList.Any(b => topology.AnyGatewayOn(b))
                              || distinct.Any(n => n.IsGateway);
            string busNames = busList.Count > 0
                ? string.Join(", ", busList.Select(BusLabel))
                : "unknown bus(es)";

            var r = NewResult("Multiple independent comm faults or a gateway/backbone fault");
            r.Severity = DiagnosticSeverity.Medium;
            r.Confidence = SignalMath.Clamp(confidence, 0.0, 1.0);
            r.Hypothesis =
                $"{distinct.Count} modules are implicated but they span multiple buses ({busNames}) with no "
                + "single dominant segment. That is either several unrelated branch faults or — more likely "
                + "when a gateway is involved — a gateway/backbone fault that breaks forwarding between "
                + "segments. Condemning any one leaf module first would be premature.";
            r.SuspectComponents = new List<string>
            {
                "Gateway module (cross-bus forwarding)",
                "Backbone power / ground distribution",
                "Multiple independent module branches (rule out the shared cause first)",
            };
            r.NextTest =
                "Verify the gateway and the backbone power/ground before condemning any leaf module: confirm "
                + "the gateway is powered and communicating, then check each affected bus reads ~60 Ω. A "
                + "gateway or shared-supply fault explains cross-bus losses that N separate repairs would not.";

            r.Evidence.Info("Topology", $"{distinct.Count} distinct module(s) across {busList.Count} bus(es)",
                            $"{implications.Count} U-code(s); no single bus carries the majority.");
            foreach (var im in implications)
                r.Evidence.Fail(im.Dtc.Code ?? "U????", DescribeImplication(im),
                                "module present & communicating", DtcDetail(im.Dtc));
            if (anyGateway)
                r.Evidence.Info("Gateway", "implicated / present",
                                "A gateway participates in these paths — a prime suspect for cross-bus loss.");

            ApplyAdvisory(r, advisory, advisoryReason);
            return r;
        }

        // ── Resolution + formatting helpers ───────────────────────────────────

        /// <summary>
        /// Resolve the module a lost-communication U-code names as its silent TARGET.
        /// Prefers a name match against the scanned topology (from the DTC's decoded
        /// description or a J2012 code→module keyword map); returns null if the
        /// target can't be tied to a scanned node (caller falls back to the reporter).
        /// The reporter itself is never returned — a module does not lose comms with itself.
        /// </summary>
        private static ModuleNode ResolveTargetNode(DiagnosticDtc dtc, PlatformTopology topology, ModuleNode reporter)
        {
            if (topology == null || topology.Nodes == null || topology.Nodes.Count == 0) return null;

            string desc = (dtc.Description ?? "").ToUpperInvariant();
            string[] codeKeywords = KeywordsForCode(dtc.Code);

            // ── Pass 1: the decoded description explicitly names a module ──
            //  Authoritative, so it is checked across ALL nodes (not defeated by
            //  iteration order) and matched at a WORD BOUNDARY so a shorter module
            //  name isn't matched inside a longer one.
            if (desc.Length > 0)
            {
                foreach (var node in topology.Nodes)
                {
                    if (node == null || string.IsNullOrEmpty(node.Name)) continue;
                    if (reporter != null && node.TxId == reporter.TxId) continue; // not self
                    if (ContainsWord(desc, node.Name.ToUpperInvariant())) return node;
                }
            }

            // ── Pass 2: the J2012 code maps to a keyword that names a module ──
            //  Matched at a WORD START within the node name so acronym substrings
            //  don't collide: keyword "BCM" must NOT resolve to "EBCM" (a different
            //  module on a different bus) — that flips a cross-bus/gateway fault into
            //  a false "shared-bus" verdict.  A word-start (prefix) match still lets
            //  keyword "BRAKE" match a node named "BRAKES".
            if (codeKeywords != null)
            {
                foreach (var node in topology.Nodes)
                {
                    if (node == null || string.IsNullOrEmpty(node.Name)) continue;
                    if (reporter != null && node.TxId == reporter.TxId) continue; // not self
                    string nameU = node.Name.ToUpperInvariant();
                    foreach (var kw in codeKeywords)
                    {
                        if (string.IsNullOrEmpty(kw)) continue;
                        if (ContainsAtWordStart(nameU, kw)) return node;
                    }
                }
            }
            return null;
        }

        private static bool IsWordChar(char c) => char.IsLetterOrDigit(c);

        /// <summary>True if <paramref name="needle"/> occurs in <paramref name="haystack"/>
        /// as a whole word (both edges at a non-alphanumeric boundary).</summary>
        private static bool ContainsWord(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle)) return false;
            int idx = 0;
            while ((idx = haystack.IndexOf(needle, idx, StringComparison.Ordinal)) >= 0)
            {
                bool leftOk = idx == 0 || !IsWordChar(haystack[idx - 1]);
                int end = idx + needle.Length;
                bool rightOk = end >= haystack.Length || !IsWordChar(haystack[end]);
                if (leftOk && rightOk) return true;
                idx += 1;
            }
            return false;
        }

        /// <summary>True if <paramref name="needle"/> occurs in <paramref name="haystack"/>
        /// at the START of a word (left edge at a boundary) — a prefix match that
        /// distinguishes "BCM" (matches a node literally named "BCM") from a mid-word
        /// substring hit inside "EBCM".</summary>
        private static bool ContainsAtWordStart(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle)) return false;
            int idx = 0;
            while ((idx = haystack.IndexOf(needle, idx, StringComparison.Ordinal)) >= 0)
            {
                if (idx == 0 || !IsWordChar(haystack[idx - 1])) return true;
                idx += 1;
            }
            return false;
        }

        /// <summary>
        /// SAE J2012 lost-communication U-code → target-module name keywords.  Covers
        /// the common "Lost Communication With …" codes so a target can be tied to a
        /// scanned node even when the DTC carries no decoded description.
        /// </summary>
        private static string[] KeywordsForCode(string code)
        {
            if (string.IsNullOrEmpty(code)) return null;
            switch (code.Trim().ToUpperInvariant())
            {
                case "U0100": return new[] { "PCM", "ECM", "ENGINE" };
                case "U0101": return new[] { "TCM", "TRANS", "TCU" };
                case "U0102": return new[] { "TRANSFER" };
                case "U0103": return new[] { "SHIFT" };
                case "U0104": return new[] { "CRUISE" };
                case "U0107": return new[] { "THROTTLE", "TAC" };
                case "U0109": return new[] { "FUEL PUMP", "FPCM" };
                case "U0114": return new[] { "4WD", "AWD", "CLUTCH" };
                case "U0121": return new[] { "ABS", "BRAKE", "EBCM" };
                case "U0122": return new[] { "VDC", "ESP", "STABILITY", "DYNAMIC" };
                case "U0126": return new[] { "STEERING ANGLE", "SAS" };
                case "U0128": return new[] { "PARK BRAKE", "EPB" };
                case "U0129": return new[] { "BRAKE" };
                case "U0131": return new[] { "POWER STEERING", "EPS", "PSCM" };
                case "U0140": return new[] { "BCM", "BODY" };
                case "U0146": return new[] { "GATEWAY", "GWM", "GW" };
                case "U0151": return new[] { "RCM", "SRS", "AIRBAG", "RESTRAINT", "OCS" };
                case "U0155": return new[] { "IPC", "CLUSTER", "INSTRUMENT" };
                case "U0159": return new[] { "PARK ASSIST", "PAM" };
                case "U0164": return new[] { "HVAC", "CLIMATE" }; // dropped bare "AC" — a 2-char token prefix-matches unrelated modules (ACM, ACC, ABS-adjacent names)
                case "U0184": return new[] { "RADIO", "AUDIO", "APIM", "SYNC" };
                case "U0195": return new[] { "TELEMATIC", "TCU", "ONSTAR" };
                case "U0197": return new[] { "PHONE" };
                case "U0293": return new[] { "HYBRID", "HPCM" };
                default:      return null;
            }
        }

        /// <summary>Human-readable "reported by X, target Y on BUS" for an implication evidence line.</summary>
        private static string DescribeImplication(Implication im)
        {
            string bus = im.Node.Bus != VehicleBus.Unknown ? " on " + BusLabel(im.Node.Bus) : "";
            uint reporterTx = im.Dtc.ModuleTxId;
            string reporter = !string.IsNullOrEmpty(im.Dtc.ModuleName)
                ? im.Dtc.ModuleName
                : (reporterTx != 0 ? $"0x{reporterTx:X3}" : "unknown module");
            if (im.TargetResolved)
                return $"reported by {reporter}, lost target {im.Node.Name}{bus}";
            return $"reported by {im.Node.Name}{bus} (target unresolved — anchored on reporter)";
        }

        /// <summary>The DTC description (or a note that none was decoded), as an evidence detail.</summary>
        private static string DtcDetail(DiagnosticDtc dtc)
        {
            if (!string.IsNullOrEmpty(dtc.Description)) return dtc.Description;
            return dtc.Confirmed ? "confirmed lost-communication code" : "pending lost-communication code";
        }

        /// <summary>Shared-bus confidence ladder: 2→conf2, 3→conf3, 4+→conf4.</summary>
        private static double SharedBusConfidence(int coLocated, double conf2, double conf3, double conf4)
        {
            double c;
            if (coLocated >= 4) c = conf4;
            else if (coLocated == 3) c = conf3;
            else c = conf2; // coLocated == 2
            return SignalMath.Clamp(c, 0.0, 1.0);
        }

        /// <summary>Compose the advisory reason from whichever honesty triggers fired.</summary>
        private static string BuildAdvisoryReason(bool usedUnvalidated, bool thinTopology, bool anyUnknownBus,
            int moduleCount, DiagnosticContext ctx)
        {
            var parts = new List<string>();
            if (usedUnvalidated || ctx == null || ctx.Calibration == null || !ctx.Calibration.IsValidated)
                parts.Add("confidence anchors are spec-seeded, not validated on this platform");
            if (thinTopology)
                parts.Add($"thin topology ({moduleCount} module(s) scanned) — bus grouping is uncertain");
            if (anyUnknownBus)
                parts.Add("one or more implicated modules have an unknown bus — localization may be incomplete");
            return parts.Count > 0 ? string.Join("; ", parts) : null;
        }

        /// <summary>Short human label for a physical bus.</summary>
        private static string BusLabel(VehicleBus bus)
        {
            switch (bus)
            {
                case VehicleBus.HsCan:   return "HS-CAN";
                case VehicleBus.MsCan:   return "MS-CAN";
                case VehicleBus.SwCan:   return "SW-CAN";
                case VehicleBus.Lin:     return "LIN";
                case VehicleBus.FlexRay: return "FlexRay";
                case VehicleBus.KLine:   return "K-Line";
                case VehicleBus.DoIP:    return "DoIP";
                default:                 return "unknown bus";
            }
        }

        /// <summary>Read a calibration constant with a fallback, tracking whether it was validated.</summary>
        private static double Cal(DiagnosticContext ctx, string key, double fallback, ref bool usedUnvalidated)
        {
            if (ctx == null || ctx.Calibration == null) { usedUnvalidated = true; return fallback; }
            bool validated;
            double v = ctx.Calibration.Value(key, fallback, out validated);
            if (!validated) usedUnvalidated = true;
            return v;
        }

        /// <summary>Stamp the advisory flag + reason onto a result.</summary>
        private static void ApplyAdvisory(DiagnosticResult r, bool advisory, string reason)
        {
            if (!advisory) return;
            r.Advisory = true;
            r.AdvisoryReason = reason ?? "result rests on unvalidated anchors or thin topology";
        }
    }
}
