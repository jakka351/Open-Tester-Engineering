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
//  Tester Present Specialist Automotive Solutions — Investigation Orchestrator (E1: the tree-wire keystone)
//
//  DiagnosticSession is the Investigation Tree; on its own it is a brain in a jar —
//  before this, only the self-test ever drove it.  This is the PRODUCTION driver
//  that connects the engine world (DiagnosticSnapshot + DiagnosticRunResult) to the
//  tree world (observations + competing hypotheses), and gives the UI/MCP one place
//  to run the loop: CONNECT → ingest → propose → record outcome → converge.
//
//  It is host-side and holds no I/O.  It owns exactly one live session, dedups the
//  observations it writes (so re-scans don't pile up duplicate DTC nodes), and fires
//  Changed so a workbench can re-render.  All belief math stays in DiagnosticSession
//  and M6 — this only TRANSLATES and SEQUENCES; it never re-ranks.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;

namespace TesterPresent.OBD2.Intelligence.Session
{
    /// <summary>
    /// Production driver for the Investigation Tree. One live <see cref="DiagnosticSession"/>,
    /// fed engine runs and test outcomes; projects the frontier + trodden map for the UI/MCP.
    /// </summary>
    public sealed class InvestigationOrchestrator
    {
        /// <summary>The live session, or null between investigations.</summary>
        public DiagnosticSession Session { get; private set; }
        public bool IsActive => Session != null;

        /// <summary>Raised after any mutation (start/ingest/outcome/converge) so a workbench re-renders.</summary>
        public event Action Changed;

        /// <summary>Repair-history store (E3). When attached, a confirmed fix writes back here —
        /// the ONLY producer of the history that M6 blends into its priors.</summary>
        private IFixedByStore _fixedBy;
        public void AttachFixedByStore(IFixedByStore store) => _fixedBy = store;

        /// <summary>Persistence (E2). When attached, every mutation auto-saves and IngestRun
        /// auto-resumes a paused investigation by VIN.</summary>
        private SessionStore _sessionStore;
        public void AttachSessionStore(SessionStore store) => _sessionStore = store;

        // Dedup bookkeeping — the session graph itself does not dedup observations, so we do.
        private bool _vinObserved;
        private readonly HashSet<string> _seenDtcKeys = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        private readonly List<Guid> _dtcObservationIds = new List<Guid>();

        // ── Lifecycle ───────────────────────────────────────────────────────────

        /// <summary>Begin a fresh investigation at CONNECT — the root of the tree.</summary>
        public DiagnosticSession StartSession(string vin, string platform = null, int modelYear = 0)
        {
            Session = DiagnosticSession.Start(vin, platform, modelYear);
            ResetDedup();
            RaiseChanged();
            return Session;
        }

        /// <summary>Tear down the live investigation (e.g. on disconnect / new vehicle).</summary>
        public void EndSession()
        {
            Session = null;
            ResetDedup();
            RaiseChanged();
        }

        /// <summary>Adopt a session built elsewhere — the resume path for E2 (persistence).
        /// Rebuilds the dedup state from the loaded graph so a re-ingest stays idempotent.</summary>
        public void Adopt(DiagnosticSession session)
        {
            Session = session;
            ResetDedup();
            if (session != null)
            {
                _vinObserved = session.Nodes.Any(n => n.Kind == NodeKind.Observation && n.Source == "vin");
                foreach (var n in session.Nodes.Where(n => n.Kind == NodeKind.Observation && n.Source == "dtc"))
                {
                    _seenDtcKeys.Add(n.Title);        // Title is the dedup key we write below
                    _dtcObservationIds.Add(n.Id);
                }
            }
            RaiseChanged();
        }

        // ── Growth: fold an engine run into the tree ────────────────────────────

        /// <summary>
        /// Record new observations (VIN identity + each newly-seen DTC), then upsert M6's ranked
        /// frontier as competing hypothesis branches.  Idempotent across re-scans:
        /// <see cref="DiagnosticSession.SpawnHypotheses"/> refreshes snapshot-belief while preserving
        /// each branch's test-outcome deltas and status, so the failures stay on the map.
        /// Auto-starts a session from the snapshot identity if none is live.
        /// </summary>
        public void IngestRun(DiagnosticSnapshot snap, DiagnosticRunResult run)
        {
            if (run == null) return;
            if (Session == null)
            {
                // Auto-resume a paused job for this VIN, else start fresh — reconnect to the same
                // car, hit Capture, and the tree you left three days ago comes back on its own.
                var resumed = (_sessionStore != null && !string.IsNullOrEmpty(snap?.Vin)) ? _sessionStore.Load(snap.Vin) : null;
                if (resumed != null) Adopt(resumed);
                else StartSession(snap?.Vin, snap?.Platform, snap?.ModelYear ?? 0);
            }

            // Refresh identity from the snapshot once it's known. A session can start before the VIN
            // is read (platform="Generic"), then a later scan resolves it (e.g. "FordFG"); if we don't
            // update it, the E3 repair-history write-back keys on the stale platform and M6 — which keys
            // on the SNAPSHOT platform — never queries that cell. Only fill/upgrade, never blank out.
            if (snap != null)
            {
                if (!string.IsNullOrEmpty(snap.Platform) && snap.Platform != "Generic") Session.Platform = snap.Platform;
                else if (string.IsNullOrEmpty(Session.Platform)) Session.Platform = snap.Platform ?? "";
                if (string.IsNullOrEmpty(Session.Vin) && !string.IsNullOrEmpty(snap.Vin)) Session.Vin = snap.Vin;
                if (Session.ModelYear == 0 && snap.ModelYear > 0) Session.ModelYear = snap.ModelYear;
            }

            // VIN / identity observation — once per session.
            if (!_vinObserved && snap != null)
            {
                Session.AppendObservation(BuildVinTitle(snap), source: "vin");
                _vinObserved = true;
            }

            // One Observation per newly-seen DTC (dedup by the rendered title = code+desc+module+status).
            if (snap?.Dtcs != null)
            {
                foreach (var d in snap.Dtcs)
                {
                    if (d == null || string.IsNullOrEmpty(d.Code)) continue;
                    string title = BuildDtcTitle(d);
                    if (!_seenDtcKeys.Add(title)) continue;   // already recorded this exact DTC
                    var obsId = Session.AppendObservation(title, source: "dtc");
                    // Stamp the DTC code onto the observation (FaultKey is unused for observations)
                    // so SpawnHypotheses can link ONLY the hypotheses this DTC actually raised —
                    // the honesty fix that keeps unexplained DTCs visible in the residual.
                    var obs = Session.Node(obsId);
                    if (obs != null) obs.FaultKey = d.Code;
                    _dtcObservationIds.Add(obsId);
                }
            }

            // Seed / refresh the competing-hypothesis frontier from M6's ranked faults.
            // (Establishing edges from the DTC observations are added for NEW hypotheses only.)
            Session.SpawnHypotheses(run, _dtcObservationIds);
            RaiseChanged();
        }

        // ── The tech drives the loop ────────────────────────────────────────────

        /// <summary>The single most-discriminating next test (or null when nothing's left to split).</summary>
        public TestProposal ProposeNextTest() => Session?.ProposeNextTest();

        /// <summary>Which hypothesis a test result pointed toward — the tech-facing shape of an outcome.</summary>
        public enum Pointing { TowardLeading, TowardContender, Inconclusive }

        /// <summary>
        /// Fold a test result back into the tree, mapping "which way did it point" onto the
        /// session's favoured/refuted belief update.  Only an on-vehicle, independent PASS toward
        /// a hypothesis can ever confirm it (the BestSupported gate lives in DiagnosticSession).
        /// </summary>
        public Guid RecordOutcome(TestProposal proposal, Pointing pointing, double strength,
                                  bool ranOnVehicle, bool independent, string summary = null)
        {
            if (Session == null || proposal == null) return Guid.Empty;

            string favoured = null, refuted = null;
            EvidenceVerdict verdict;
            switch (pointing)
            {
                case Pointing.TowardLeading:
                    favoured = proposal.LeadingFaultKey; refuted = proposal.ContenderFaultKey;
                    verdict = EvidenceVerdict.Pass; break;
                case Pointing.TowardContender:
                    favoured = proposal.ContenderFaultKey; refuted = proposal.LeadingFaultKey;
                    verdict = EvidenceVerdict.Pass; break;
                default: // Inconclusive — recorded on the map, but no belief moves
                    verdict = EvidenceVerdict.Inconclusive; break;
            }

            var id = Session.ApplyOutcome(proposal.TestNodeId, favoured, refuted, strength, verdict,
                                          ranOnVehicle, independent, summary);
            RaiseChanged();
            return id;
        }

        /// <summary>Raw outcome for callers that already know the favoured/refuted keys (a tool that
        /// discriminates a specific pair, or a replayed outcome).</summary>
        public Guid RecordOutcomeRaw(Guid testNodeId, string favouredKey, string refutedKey, double strength,
                                     EvidenceVerdict verdict, bool ranOnVehicle, bool independent, string summary = null)
        {
            if (Session == null) return Guid.Empty;
            var id = Session.ApplyOutcome(testNodeId, favouredKey, refutedKey, strength, verdict,
                                          ranOnVehicle, independent, summary);
            RaiseChanged();
            return id;
        }

        // ── The fix arm (E4) + repair-history write-back (E3) ────────────────────

        /// <summary>Candidate fixes for a fault, from that OEM's real procedure library (advisory,
        /// owner-vetted, safety-gated). The UI surfaces these on a best-supported hypothesis.</summary>
        public IReadOnlyList<Fix.FixCandidate> ProposeFixes(string faultKey, OEMManufacturer oem, int max = 5)
        {
            // The same procedure ships under several source files (FUSV40en / FUSV70en / …), so a
            // raw match returns near-duplicate candidates with identical names. Over-fetch, then keep
            // the first occurrence of each distinct procedure name so the tech sees `max` REAL options.
            var raw = Fix.ProcedureMatcher.Match(faultKey, oem, max * 4);
            if (raw == null) return System.Array.Empty<Fix.FixCandidate>();
            var seen = new HashSet<string>(System.StringComparer.OrdinalIgnoreCase);
            var deduped = new List<Fix.FixCandidate>();
            foreach (var c in raw)
            {
                if (c == null || !seen.Add(c.ProcedureName ?? "")) continue;
                deduped.Add(c);
                if (deduped.Count >= max) break;
            }
            return deduped;
        }

        /// <summary>Attach a proposed fix to a hypothesis node (creates a Fix node + Fixes edge).</summary>
        public Guid AddFix(Guid hypothesisId, string title, string fixAction)
        {
            if (Session == null) return Guid.Empty;
            var id = Session.AddFix(hypothesisId, title, fixAction);
            RaiseChanged();
            return id;
        }

        /// <summary>
        /// Record a fix outcome AND write it to repair history (E3 — the write-back that feeds M6's
        /// history priors). Keyed by (Session.Platform, hypothesis.FaultKey, fix.FixAction) so it
        /// lands in the SAME cell M6 queries with. A worked fix tips the hypothesis to best-supported.
        /// </summary>
        public void RecordFixOutcome(Guid fixNodeId, bool worked)
        {
            if (Session == null) return;
            var fixNode = Session.Node(fixNodeId);
            var hyp = Session.ApplyFixOutcome(fixNodeId, worked);

            // E3: feed the starved brain — the first and only producer of IFixedByStore history.
            if (_fixedBy != null && fixNode != null && hyp != null && !string.IsNullOrEmpty(fixNode.FixAction))
            {
                try { _fixedBy.Record(Session.Platform, hyp.FaultKey, fixNode.FixAction, worked); }
                catch { /* history is best-effort; a store fault never breaks the investigation */ }
            }
            RaiseChanged();
        }

        /// <summary>Promote the leader to BestSupported IF it clearly leads and has an independent
        /// on-vehicle confirm; null otherwise (the honest default). Never "confirmed root cause".</summary>
        public ReasoningNode TryConverge()
        {
            var best = Session?.TryConverge();
            if (best != null) RaiseChanged();
            return best;
        }

        /// <summary>The honest terminal statement for the tech.</summary>
        public string Summary() => Session?.BestSupportedSummary() ?? "No active investigation.";

        // ── Projections the UI / MCP read ───────────────────────────────────────
        public IReadOnlyList<ReasoningNode> Frontier() => Session?.Frontier() ?? _empty;
        public IReadOnlyList<ReasoningNode> RuledOut() => Session?.RuledOut() ?? _empty;
        public IReadOnlyList<ReasoningNode> Suspended() => Session?.Suspended() ?? _empty;
        public IReadOnlyList<ReasoningNode> TriageResidual() => Session?.TriageResidual() ?? _empty;

        private static readonly IReadOnlyList<ReasoningNode> _empty = new List<ReasoningNode>();

        // ── Helpers ─────────────────────────────────────────────────────────────

        private void ResetDedup()
        {
            _vinObserved = false;
            _seenDtcKeys.Clear();
            _dtcObservationIds.Clear();
        }

        private static string BuildVinTitle(DiagnosticSnapshot snap)
        {
            string id = string.Join(" · ", new[]
            {
                snap.Oem.ToString(),
                string.IsNullOrEmpty(snap.Platform) ? null : snap.Platform,
                snap.ModelYear > 0 ? snap.ModelYear.ToString() : null,
            }.Where(x => !string.IsNullOrEmpty(x)));
            return string.IsNullOrEmpty(snap.Vin) ? $"Vehicle → {id}" : $"VIN {snap.Vin} → {id}";
        }

        private static string BuildDtcTitle(DiagnosticDtc d)
        {
            string status = d.Confirmed ? "confirmed" : (d.Pending ? "pending" : "present");
            string mod = string.IsNullOrEmpty(d.ModuleName) ? "" : $" @ {d.ModuleName}";
            string desc = string.IsNullOrEmpty(d.Description) ? "" : $" — {d.Description}";
            return $"{d.Code}{desc}{mod} ({status})";
        }

        /// <summary>Force a save now (e.g. on app close / tab teardown).</summary>
        public void SaveNow()
        {
            if (_sessionStore != null && Session != null) try { _sessionStore.Save(Session); } catch { }
        }

        /// <summary>Resume a saved investigation by VIN (returns false if none exists).</summary>
        public bool TryResume(string vin)
        {
            var s = _sessionStore?.Load(vin);
            if (s == null) return false;
            Adopt(s);
            return true;
        }

        private void RaiseChanged()
        {
            // Auto-persist after every mutation (E2). The session JSON is small; jobs are
            // low-frequency, so a save-per-change is cheap and means no lost progress on a crash.
            if (_sessionStore != null && Session != null) try { _sessionStore.Save(Session); } catch { }
            try { Changed?.Invoke(); } catch { /* UI handler faults never break the engine */ }
        }
    }
}
