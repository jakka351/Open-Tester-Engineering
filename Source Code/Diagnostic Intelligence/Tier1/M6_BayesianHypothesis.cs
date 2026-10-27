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
//  Tester Present Specialist Automotive Solutions — M6 Bayesian Hypothesis Engine (Tier-1, COMPOSING)
//
//  M1–M5 each invert ONE view of the capture (fuel-trim surface, crank velocity,
//  bus topology, fleet baseline, intermittents).  Each is a partial witness.  M6
//  is the juror: it collects every hypothesis those modules produced this pass,
//  folds in the raw DTCs, and combines them with a naive-Bayes log-odds update
//  against per-fault priors — historical fixed-by success rates where we have
//  them, a spec-seeded expert table where we don't.
//
//  A single lean code (P0171) is consistent with a vacuum leak, a MAF error, AND
//  a fuel-delivery shortfall.  What tips the ranking is the CONVERGENCE of
//  independent evidence: when M1's fuel-trim surface ALSO shows a low-load-
//  dominant lean, the vacuum-leak posterior pulls decisively ahead.  M6 makes
//  that convergence explicit, then recommends the single test that best SEPARATES
//  the top two survivors — never a bare verdict.
//
//  Register this module LAST: it reads context.PriorResults, so every other
//  module must have run first.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using TesterPresent.OBD2.Intelligence;

namespace TesterPresent.OBD2.Intelligence.Tier1
{
    /// <summary>
    /// M6 — Bayesian Hypothesis Engine.  Composes the hypotheses produced by
    /// M1–M5 (via <see cref="DiagnosticContext.PriorResults"/>) plus the captured
    /// DTCs into a Bayes-ranked fault list, and emits the top candidate(s) with a
    /// merged evidence chain and the single most discriminating next test.
    /// Reads the snapshot + context only; commands no hardware.
    /// </summary>
    public sealed class BayesianHypothesisModule : DiagnosticModuleBase
    {
        // ── Canonical fault taxonomy keys ─────────────────────────────────────
        private const string VacuumLeak   = "VacuumLeak";
        private const string Misfire      = "Misfire";
        private const string MafError     = "MafError";
        private const string FuelDelivery = "FuelDelivery";
        private const string BusFault     = "BusFault";
        private const string SensorDropout = "SensorDropout";
        private const string WeakCylinder = "WeakCylinder";
        private const string Overfuel     = "Overfuel";

        // Evidence likelihoods are clamped into this band so no single witness can
        // drive the log-odds to ±∞ (an over-confident module must not veto Bayes).
        private const double LIKELIHOOD_MIN = 0.05;
        private const double LIKELIHOOD_MAX = 0.95;

        // Posterior ceiling: even a pile of confirmed evidence leaves residual doubt.
        private const double CONFIDENCE_CEIL = 0.95;

        // A contribution at/above this likelihood is rendered as a FAIL (supports the
        // fault) rather than a neutral Info step.
        private const double STRONG_LIKELIHOOD = 0.60;

        // Emit the runner-up as its own result only when it stays plausible.
        private const double SECOND_EMIT_MIN = 0.35;

        // Structural (mode@component) candidates kept in the frontier per analysis.  Every DTC now
        // expands into 2-6 structural faults, so a multi-code car would otherwise flood the frontier
        // (dozens of hypothesis nodes, banding diluted to nothing, convergence unreachable).
        // Canonical faults are never capped; the cap is reported in the evidence chain, never silent.
        private const int MAX_STRUCTURAL_FRONTIER = 8;

        private DiagnosticRequirements _requirements;

        /// <inheritdoc/>
        public override string ModuleId => "M6";

        /// <inheritdoc/>
        public override string DisplayName => "Bayesian Hypothesis Engine";

        /// <inheritdoc/>
        public override DiagnosticTier Tier => DiagnosticTier.Tier1;

        /// <inheritdoc/>
        public override DiagnosticRequirements Requirements =>
            _requirements ?? (_requirements = new DiagnosticRequirements
            {
                // Works from PriorResults and/or DTCs — no hard signal/DTC gate.
                NeedsDtcs = false,
                MayRecommendActiveControl = false,
            });

        /// <summary>
        /// Gather candidate faults from prior hypotheses + DTCs, Bayes-rank them,
        /// and emit the top (and optional second) with a merged evidence chain and
        /// the most discriminating next test.
        /// </summary>
        protected override IReadOnlyList<DiagnosticResult> AnalyzeCore(
            DiagnosticSnapshot snapshot, DiagnosticContext context)
        {
            var results = new List<DiagnosticResult>();

            IReadOnlyList<DiagnosticResult> priors = context?.PriorResults ?? Array.Empty<DiagnosticResult>();
            IReadOnlyList<DiagnosticDtc> dtcs = snapshot?.Dtcs ?? (IReadOnlyList<DiagnosticDtc>)Array.Empty<DiagnosticDtc>();

            // Nothing to compose over.
            if (priors.Count == 0 && dtcs.Count == 0) return results;

            var candidates = new Dictionary<string, Candidate>(StringComparer.OrdinalIgnoreCase);
            bool anyContribAdvisory = false;

            // ── (1) Candidates from earlier modules' hypotheses ───────────────
            foreach (var pr in priors)
            {
                if (pr == null || pr.ModuleId == "M6") continue; // never recurse on our own output
                string key = MapHypothesisToFault(pr.Title, pr.Hypothesis, out string label);
                double like = SignalMath.Clamp(pr.Confidence, LIKELIHOOD_MIN, LIKELIHOOD_MAX);
                var c = GetOrAdd(candidates, key, label);
                c.Contributions.Add(new Contribution
                {
                    Source = $"{(string.IsNullOrEmpty(pr.ModuleId) ? "module" : pr.ModuleId)}: {Short(pr.Title)}",
                    Likelihood = like,
                    Detail = $"module hypothesis at {Pct(pr.Confidence)} confidence",
                });
                if (pr.SuspectComponents != null)
                    foreach (var s in pr.SuspectComponents) if (!string.IsNullOrWhiteSpace(s)) c.Suspects.Add(s);
                if (pr.Advisory) { c.AnyAdvisoryContrib = true; anyContribAdvisory = true; }
            }

            // ── (2) Candidates from raw DTCs ──────────────────────────────────
            string dominantSymptom = null;
            foreach (var d in dtcs)
            {
                if (d == null || string.IsNullOrEmpty(d.Code)) continue;
                double stateLike = d.Confirmed ? 0.85 : (d.Pending ? 0.65 : 0.55);
                string state = d.Confirmed ? "confirmed" : (d.Pending ? "pending" : "present");
                foreach (var (key, meaning, structWeight, vol) in DtcToFaults(d))
                {
                    // Structural faults weight the DTC-state evidence by the fault's own
                    // DtcLikelihood (a per-mode witness-strength discount, 0.45/0.55): a single
                    // circuit code is WEAK evidence for any one of the several faults that could
                    // emit it.  Using the flat state likelihood here made "corroded connector"
                    // (highest class prior) outrank every canonical drivability fault.
                    double like = structWeight.HasValue
                        ? Sigmoid(Logit(stateLike) * structWeight.Value)
                        : stateLike;
                    var c = GetOrAdd(candidates, key, FaultLabel(key));
                    if (vol) c.Volatile = true;   // per-scan intermittent grammar — latches for THIS analysis only
                    c.Contributions.Add(new Contribution
                    {
                        Source = $"DTC {d.Code} ({state})",
                        Likelihood = like,
                        Detail = meaning,
                        // The same code echoed by several modules is ONE witness, not N — and for a
                        // STRUCTURAL fault, several DIFFERENT codes naming the same component+mode
                        // (P0121/22/23 = one TPS) are also ONE physical witness, not three.
                        CorrelationKey = structWeight.HasValue
                            ? "DTCFAULT:" + key.ToUpperInvariant()
                            : "DTC:" + d.Code.ToUpperInvariant(),
                        Witness = !string.IsNullOrEmpty(d.ModuleName) ? d.ModuleName
                                : (d.ModuleTxId != 0 ? $"0x{d.ModuleTxId:X3}" : null),
                    });
                    // Carry the structural fault's suspect components onto the hypothesis (the tree reads c.Suspects).
                    foreach (var s in DtcFaultModel.GetSuspects(key)) if (!string.IsNullOrWhiteSpace(s)) c.Suspects.Add(s);
                    if (dominantSymptom == null && d.Confirmed) dominantSymptom = key;
                }
            }

            if (candidates.Count == 0) return results;

            // ── (2b) Correlated-evidence collapse ─────────────────────────────
            // Same-CorrelationKey contributions (the same DTC code from N modules) must
            // count ONCE in the log-odds fold, or each echo multiplies the likelihood
            // and inflates the posterior with no new information.
            foreach (var c in candidates.Values)
                CollapseCorrelatedContributions(c);

            // ── (3) Priors + Bayesian log-odds combination ────────────────────
            bool usedExpertPrior = false;
            string platform = snapshot?.Platform ?? "Generic";
            foreach (var c in candidates.Values)
            {
                c.Prior = ResolvePrior(c, context, platform, dominantSymptom, ref usedExpertPrior);
                double logodds = Logit(c.Prior);
                foreach (var contrib in c.Contributions)
                    logodds += Logit(SignalMath.Clamp(contrib.Likelihood, LIKELIHOOD_MIN, LIKELIHOOD_MAX));
                c.LogOdds = logodds;
                c.Posterior = Sigmoid(logodds);
            }

            // ── (4) Rank + normalise for display ──────────────────────────────
            var ranked = candidates.Values
                .OrderByDescending(c => c.Posterior)
                .ThenByDescending(c => c.Contributions.Count)
                .ToList();

            // Cap the structural tail BEFORE normalising: keep only the strongest structural
            // (mode@component) candidates; canonical faults always survive.  Without this, a
            // multi-code car floods the frontier and dilutes every share toward zero.
            int structuralSuppressed = 0, structuralKept = 0;
            var kept = new List<Candidate>(ranked.Count);
            foreach (var c in ranked)
            {
                bool structural = c.Key.IndexOf('@') >= 0;
                if (structural && structuralKept >= MAX_STRUCTURAL_FRONTIER) { structuralSuppressed++; continue; }
                if (structural) structuralKept++;
                kept.Add(c);
            }
            ranked = kept;

            double sum = ranked.Sum(c => c.Posterior);
            if (sum > 1e-9) foreach (var c in ranked) c.NormShare = c.Posterior / sum;

            // Shannon entropy (bits) of the normalised posterior shares — the actual
            // measure of how much diagnostic uncertainty remains over the fault set.
            // High H ⇒ the top candidates are close and a discriminating test buys a lot;
            // low H ⇒ the leader already dominates and the test just confirms it.  The
            // most-informative next test separates the two highest-share candidates,
            // because that adjacent pair carries most of this entropy — so choosing to
            // separate top-vs-second IS the maximum-information-gain move, not a guess.
            double entropy = 0.0;
            foreach (var c in ranked)
            {
                double p = c.NormShare;
                if (p > 1e-9) entropy -= p * Math.Log(p, 2.0);
            }

            Candidate top = ranked[0];
            Candidate second = ranked.Count > 1 ? ranked[1] : null;

            // ── (5) Advisory honesty ──────────────────────────────────────────
            bool thinEvidence = top.Contributions.Count < 2 && ranked.Count < 2;
            bool advisory = usedExpertPrior || anyContribAdvisory || thinEvidence
                            || context == null || context.Calibration == null
                            || !context.Calibration.IsValidated;
            string advisoryReason = BuildAdvisoryReason(usedExpertPrior, anyContribAdvisory, thinEvidence,
                                                        context != null && context.FixedBy != null);

            // ── (6) Emit top hypothesis with the discriminating next test ─────
            results.Add(BuildResult(top, ranked, second,
                                    discriminator: MostDiscriminatingTest(top, second),
                                    rank: 1, advisory: advisory, advisoryReason: advisoryReason,
                                    entropyBits: entropy));

            // Attach the LOSSLESS ranked frontier to the top result — the Investigation Tree
            // seeds one hypothesis node per RankedFault (not just the top two that become
            // DiagnosticResults). Projection only; the Bayes math above is untouched.
            results[0].RankedFaults = ProjectFrontier(ranked, advisory);

            // No silent truncation: say exactly how many structural candidates the cap dropped.
            if (structuralSuppressed > 0)
                results[0].Evidence.Info("Frontier cap",
                    $"{structuralSuppressed} weaker structural hypothesis(es) suppressed",
                    $"Only the {MAX_STRUCTURAL_FRONTIER} strongest wiring/component candidates are ranked per pass — "
                    + "fix or rule out the leaders and re-analyse to surface the rest.");

            // Emit the runner-up too when it remains a live possibility.
            if (second != null && second.Posterior >= SECOND_EMIT_MIN)
            {
                results.Add(BuildResult(second, ranked, top,
                                        discriminator: FaultDefaultNextTest(second.Key),
                                        rank: 2, advisory: advisory, advisoryReason: advisoryReason,
                                        entropyBits: entropy));
            }

            return results;
        }

        // ── Result construction ───────────────────────────────────────────────

        private DiagnosticResult BuildResult(Candidate c, List<Candidate> ranked, Candidate other,
                                             string discriminator, int rank, bool advisory, string advisoryReason,
                                             double entropyBits)
        {
            var r = NewResult(rank == 1
                ? $"Most-likely fault: {c.Label}"
                : $"Alternative fault: {c.Label}");

            string priorSrc = c.PriorFromHistory ? "fixed-by history" : "expert base rate";
            r.Hypothesis =
                $"Bayesian ranking places {c.Label} " + (rank == 1 ? "first" : $"second (behind {other?.Label ?? "the leading fault"})")
                + $" at {Pct(c.Posterior)} posterior, combining {c.Contributions.Count} independent evidence item(s) "
                + $"against a {Pct(c.Prior)} prior ({priorSrc})."
                + (other != null
                    ? $" The nearest competing fault is {other.Label} at {Pct(other.Posterior)} — the recommended test below is chosen to separate the two."
                    : "");

            r.Confidence = SignalMath.Clamp(c.Posterior, 0.0, CONFIDENCE_CEIL);
            r.Severity = SeverityFor(c.Key, c.Posterior);
            r.NextTest = discriminator;
            r.SuspectComponents = MergeSuspects(c);

            // ── Merged evidence chain ─────────────────────────────────────────
            r.Evidence.Info($"Prior — {c.Label}", Pct(c.Prior),
                            c.PriorFromHistory
                                ? "Weighted by this platform's fixed-by repair history."
                                : "Spec-seeded expert base rate (no repair history for this platform).");

            foreach (var contrib in c.Contributions.OrderByDescending(x => x.Likelihood))
            {
                bool strong = contrib.Likelihood >= STRONG_LIKELIHOOD;
                string obs = $"L={Pct(contrib.Likelihood)}";
                if (strong)
                    r.Evidence.Fail(contrib.Source, obs, "", contrib.Detail);
                else
                    r.Evidence.Info(contrib.Source, obs, contrib.Detail);
            }

            r.Evidence.Info($"Posterior — ranked #{rank} of {ranked.Count}",
                            $"{Pct(c.Posterior)} (normalised share {Pct(c.NormShare)})",
                            RankingSummary(ranked));

            r.Evidence.Info("Hypothesis-set entropy",
                            $"{entropyBits.ToString("0.00", CultureInfo.InvariantCulture)} bits over {ranked.Count} candidate(s)",
                            other != null
                                ? $"Remaining diagnostic uncertainty. The recommended test maximises information gain by "
                                  + $"separating the top two ({c.Label} vs {other.Label}) — the adjacent pair that carries most of this entropy."
                                : "The leader dominates the set (low residual entropy), so the recommended test simply confirms it.");

            if (advisory) { r.Advisory = true; r.AdvisoryReason = advisoryReason; }
            return r;
        }

        /// <summary>Union of the fault's default suspects and those cited by contributing modules.</summary>
        private static List<string> MergeSuspects(Candidate c)
        {
            var seen = new List<string>();
            var dedupe = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (var s in FaultDefaultSuspects(c.Key)) if (dedupe.Add(s)) seen.Add(s);
            foreach (var s in c.Suspects) if (dedupe.Add(s)) seen.Add(s);
            return seen;
        }

        private static string RankingSummary(List<Candidate> ranked)
        {
            var parts = ranked.Take(4).Select(c => $"{c.Label} {Pct(c.Posterior)}");
            return "Ranking: " + string.Join(" > ", parts);
        }

        // ── Fault mapping ─────────────────────────────────────────────────────

        /// <summary>
        /// Normalise a prior module's Title+Hypothesis text onto a canonical fault
        /// key.  Order matters: the most specific keyword wins first.  Unmatched
        /// text becomes a free-form candidate keyed by its (shortened) title.
        /// </summary>
        private static string MapHypothesisToFault(string title, string hypothesis, out string label)
        {
            string t = ((title ?? "") + " " + (hypothesis ?? "")).ToLowerInvariant();

            if (Contains(t, "vacuum", "intake-air leak", "intake air leak", "unmetered"))
                { label = FaultLabel(VacuumLeak); return VacuumLeak; }
            if (Contains(t, "misfire"))
                { label = FaultLabel(Misfire); return Misfire; }
            if (Contains(t, "compression", "weak cylinder", "uneven crank"))
                { label = FaultLabel(WeakCylinder); return WeakCylinder; }
            if (Contains(t, "over-fuel", "overfuel", " rich"))
                { label = FaultLabel(Overfuel); return Overfuel; }
            if (Contains(t, "maf", "mass air", "metering"))
                { label = FaultLabel(MafError); return MafError; }
            if (Contains(t, "fuel-delivery", "fuel delivery", "fuel pump", "fuel pressure", "shortfall"))
                { label = FaultLabel(FuelDelivery); return FuelDelivery; }
            // "bus" must match as a WHOLE WORD — as a bare substring it is contained in
            // "com-BUS-tion", so a weak-cylinder / detonation hypothesis would be misrouted
            // to a bus-fault. The multi-word network phrases are unambiguous substrings.
            if (ContainsWord(t, "bus") || Contains(t, "network", "communication", "comm fault", "gateway"))
                { label = FaultLabel(BusFault); return BusFault; }
            if (Contains(t, "dropout", "intermittent", "flatline", "stuck", "spike", "sensor"))
                { label = FaultLabel(SensorDropout); return SensorDropout; }

            // Free-form: keep the module's own wording so nothing is silently dropped.
            string ff = Short(string.IsNullOrWhiteSpace(title) ? hypothesis : title);
            label = ff;
            return "FF:" + ff.ToLowerInvariant();
        }

        /// <summary>Map a DTC to zero or more (faultKey, meaning, structuralWeight, volatile) contributions.
        /// structuralWeight is null for curated canonical faults (full DTC-state likelihood applies);
        /// for structural faults it carries the DtcFaultModel per-mode DtcLikelihood so the caller
        /// can discount the evidence instead of flattening every mode to the state likelihood.
        /// volatile carries the per-scan intermittent flag so the tree suspends (not refutes) it —
        /// derived from THIS code's grammar, never a process-global lookup (cross-vehicle-safe).</summary>
        private static IEnumerable<(string key, string meaning, double? structuralWeight, bool vol)> DtcToFaults(DiagnosticDtc d)
        {
            string code = (d.Code ?? "").ToUpperInvariant();
            var outp = new List<(string, string, double?, bool)>();

            // Network / communication codes.
            if (d.Family == 'U') { outp.Add((BusFault, "network code — module communication fault", null, false)); return outp; }

            // System-too-lean → three classic causes share the same symptom.
            if (code == "P0171" || code == "P0174")
            {
                outp.Add((VacuumLeak, "system too lean — unmetered air is one cause", null, false));
                outp.Add((MafError, "system too lean — a MAF reading LOW (under-reporting airflow) is one cause", null, false));
                outp.Add((FuelDelivery, "system too lean — fuel-delivery shortfall is one cause", null, false));
                return outp;
            }

            // System-too-rich.
            if (code == "P0172" || code == "P0175")
            {
                outp.Add((Overfuel, "system too rich — over-fuel condition", null, false));
                return outp;
            }

            // MAF circuit / range-performance.
            if (code == "P0101" || code == "P0102" || code == "P0103" || code == "P0100" || code == "P0104")
            {
                outp.Add((MafError, "mass-airflow sensor circuit/range fault", null, false));
                return outp;
            }

            // Misfire family: P0300 random, P0301..P030C cylinder-specific.
            if (code.Length == 5 && code.StartsWith("P030"))
            {
                outp.Add((Misfire, "misfire detected", null, false));
                outp.Add((WeakCylinder, "misfire can be mechanical (weak cylinder)", null, false));
                return outp;
            }
            if (code.Length == 5 && code.StartsWith("P031") && (code[4] == '0' || code[4] == '1' || code[4] == '2'))
            {
                outp.Add((Misfire, "misfire detected", null, false));
                outp.Add((WeakCylinder, "misfire can be mechanical (weak cylinder)", null, false));
                return outp;
            }

            // Structural fallback: a DTC is an OBSERVATION, not the fault. Extrapolate the full set of
            // physical faults that could EMIT this code — every system, subsystem and OEM — via
            // DtcFaultModel (SAE J2012 structure + description grammar + the named component). This is
            // what turns M6 from "a few engine codes" into coverage of every code in the database.
            foreach (var f in DtcFaultModel.Expand(d.Code, d.Description))
                outp.Add((f.Key, f.Meaning, f.DtcLikelihood, f.Volatile));
            return outp;
        }

        // ── Priors ────────────────────────────────────────────────────────────

        /// <summary>
        /// Resolve a fault's prior.  Fixed-by repair history (if present and thick
        /// enough) wins; otherwise the spec-seeded expert base rate — read through
        /// the calibration store so a validated platform can override it, and
        /// folded into the advisory flag when it is not validated.
        /// </summary>
        private double ResolvePrior(Candidate c, DiagnosticContext ctx, string platform,
                                    string dominantSymptom, ref bool usedExpertPrior)
        {
            double basePrior = ExpertPrior(c.Key);

            // Calibration override (validated platform) — otherwise flags advisory.
            if (ctx != null && ctx.Calibration != null)
            {
                bool validated;
                basePrior = ctx.Calibration.Value("M6.Prior." + c.Key, basePrior, out validated);
                if (!validated) usedExpertPrior = true;
            }
            else usedExpertPrior = true;
            basePrior = SignalMath.Clamp(basePrior, 0.01, 0.9);

            if (ctx != null && ctx.FixedBy != null)
            {
                var outcomes = SafeQuery(ctx.FixedBy, platform, c.Key);
                if ((outcomes == null || outcomes.Count == 0) && dominantSymptom != null)
                    outcomes = SafeQuery(ctx.FixedBy, platform, dominantSymptom);

                if (outcomes != null && outcomes.Count > 0)
                {
                    long tot = 0, succ = 0;
                    foreach (var o in outcomes) { if (o == null) continue; tot += o.Count; succ += o.SuccessCount; }
                    if (tot >= 3)
                    {
                        double hist = (double)succ / tot;
                        c.PriorFromHistory = true;
                        // Blend history with the base rate so a handful of repairs
                        // steers without overwhelming the base prior.
                        return SignalMath.Clamp(0.5 * basePrior + 0.5 * hist, 0.02, 0.9);
                    }
                }
            }
            return basePrior;
        }

        private static IReadOnlyList<FixOutcome> SafeQuery(IFixedByStore store, string platform, string symptomKey)
        {
            try { return store.Query(platform, symptomKey); }
            catch { return null; }
        }

        /// <summary>Spec-seeded expert base rates (sum &gt; 1 by design — these are marginals, not a partition).</summary>
        private static double ExpertPrior(string key)
        {
            switch (key)
            {
                case VacuumLeak:    return 0.20;
                case Misfire:       return 0.20;
                case MafError:      return 0.12;
                case FuelDelivery:  return 0.10;
                case BusFault:      return 0.10;
                case WeakCylinder:  return 0.10;
                case Overfuel:      return 0.10;
                case SensorDropout: return 0.08;
                default:
                    // Structural DTC-fault key (mode@component) — its coarse base rate from DtcFaultModel.
                    return DtcFaultModel.TryGetPrior(key, out var structPrior) ? structPrior : 0.08;
            }
        }

        // ── Discriminating next test ──────────────────────────────────────────

        /// <summary>
        /// Pick the single test that best separates the top two candidates.  Falls
        /// back to the top fault's own confirmation when there is no runner-up or
        /// no table entry for the pair.
        /// </summary>
        private static string MostDiscriminatingTest(Candidate top, Candidate second)
        {
            if (second == null) return FaultDefaultNextTest(top.Key);

            string pair = PairKey(top.Key, second.Key);
            switch (pair)
            {
                case "MafError|VacuumLeak":
                    return "Watch fuel trim as airflow rises to high load: a vacuum leak's correction NORMALISES "
                         + "under load (the fixed leak becomes a negligible fraction of airflow); a MAF metering "
                         + "error's correction does NOT — it persists or grows.";
                case "Misfire|WeakCylinder":
                    return "Run a cylinder-balance injector-cut test: a mechanically weak cylinder shows a SMALLER "
                         + "RPM drop when its injector is cut (it was contributing little already); an ignition "
                         + "misfire shows a normal RPM drop but keeps running rough. A relative-compression test "
                         + "confirms the mechanical case.";
                case "FuelDelivery|VacuumLeak":
                    return "Fuel-pressure/volume test under load: a delivery shortfall drops rail pressure as demand "
                         + "rises; a vacuum leak holds pressure and leans only at idle/low load.";
                case "FuelDelivery|MafError":
                    return "Compare measured MAF g/s against calculated airflow at high load while watching fuel "
                         + "pressure: a MAF error shows a metering mismatch with normal pressure; a delivery "
                         + "shortfall shows a pressure/volume drop under demand with plausible MAF.";
                case "BusFault|SensorDropout":
                    return "Back-probe the circuit while wiggle-testing the harness: a bus fault drops a whole "
                         + "module's comms at once (multiple DIDs stop, U-codes set together); a sensor dropout "
                         + "loses ONE signal while the module keeps responding.";
                case "FuelDelivery|Overfuel":
                case "Overfuel|VacuumLeak":
                    return "Fuel-pressure test with a leak-down check: an over-fuel condition shows high or "
                         + "slow-bleeding rail pressure (leaking injector); a delivery/lean fault shows low "
                         + "pressure, especially under load.";
                case "Misfire|VacuumLeak":
                    return "Correlate misfire counts against load and smoke-test the intake: a vacuum leak leans "
                         + "and misfires at idle only and clears under load; an ignition misfire persists across "
                         + "the load range.";
                case "MafError|Overfuel":
                    return "Compare MAF g/s vs calculated airflow and check fuel pressure: a MAF reading HIGH "
                         + "(over-reporting airflow) drives over-fuel; verify whether the metering error or the "
                         + "fuel side is primary.";
                default:
                    return FaultDefaultNextTest(top.Key)
                         + $" (This best confirms the leading fault; it also helps rule out {second.Label}.)";
            }
        }

        private static string FaultDefaultNextTest(string key)
        {
            switch (key)
            {
                case VacuumLeak:
                    return "Smoke-test the intake tract at idle and watch fuel trim collapse toward zero as airflow "
                         + "rises; inspect PCV, brake-booster hose, and intake-manifold gaskets.";
                case Misfire:
                    return "Read per-cylinder misfire counters, then swap the suspect coil/plug to another cylinder "
                         + "and see whether the misfire follows the part.";
                case MafError:
                    return "Compare measured MAF g/s against the calculated airflow at a known load; a persistent "
                         + "mismatch across the range indicts the MAF.";
                case FuelDelivery:
                    return "Measure fuel pressure and volume under load (or during a high-load pull); a pressure/"
                         + "volume drop that appears only under demand confirms a delivery shortfall.";
                case BusFault:
                    return "Back-probe the bus and confirm which modules drop off together while wiggle-testing the "
                         + "harness and connectors; isolate to a branch or the gateway.";
                case SensorDropout:
                    return "Graph the suspect signal while wiggle-testing its harness and connector; a momentary "
                         + "flatline or spike under flex confirms an intermittent connection.";
                case WeakCylinder:
                    return "Run a relative-compression or cylinder-balance test to find the low-contributing "
                         + "cylinder; follow with a compression/leak-down check.";
                case Overfuel:
                    return "Fuel-pressure test plus an injector leak-down check; confirm whether high rail pressure "
                         + "or a leaking injector is driving the rich condition.";
                default:
                    return "Confirm the leading hypothesis by re-testing its most-specific symptom under a "
                         + "controlled operating point before committing to a repair.";
            }
        }

        // ── Fault metadata ────────────────────────────────────────────────────

        private static string FaultLabel(string key)
        {
            switch (key)
            {
                case VacuumLeak:    return "vacuum / intake-air leak";
                case Misfire:       return "ignition misfire";
                case MafError:      return "mass-airflow metering error";
                case FuelDelivery:  return "fuel-delivery shortfall";
                case BusFault:      return "communication / bus fault";
                case SensorDropout: return "intermittent sensor dropout";
                case WeakCylinder:  return "weak cylinder (mechanical / compression)";
                case Overfuel:      return "rich / over-fuel condition";
                default:
                    if (DtcFaultModel.TryGetLabel(key, out var structLabel)) return structLabel;  // structural DTC-fault key
                    return key.StartsWith("FF:") ? key.Substring(3) : key;
            }
        }

        private static IEnumerable<string> FaultDefaultSuspects(string key)
        {
            switch (key)
            {
                case VacuumLeak:    return new[] { "Intake manifold gasket", "Vacuum hose", "PCV valve/hose", "Brake booster hose" };
                case Misfire:       return new[] { "Spark plugs", "Ignition coils", "Plug wires/boots" };
                case MafError:      return new[] { "MAF sensor", "Intake ducting / post-MAF leak", "Air filter restriction" };
                case FuelDelivery:  return new[] { "Fuel pump", "Fuel filter", "Injector flow", "Fuel pressure regulator" };
                case BusFault:      return new[] { "Bus wiring / terminals", "Connector corrosion", "Gateway module", "Affected ECU" };
                case SensorDropout: return new[] { "Sensor element", "Sensor wiring/connector", "Ground / reference" };
                case WeakCylinder:  return new[] { "Cylinder compression (valves/rings)", "Head gasket", "Injector flow" };
                case Overfuel:      return new[] { "Leaking injector", "High fuel pressure", "MAF reading high (over-reporting airflow)", "Contaminated O2 sensor" };
                default:            return DtcFaultModel.GetSuspects(key);   // structural DTC-fault suspects

            }
        }

        /// <summary>Base severity by fault class, escalated one notch for a strong posterior, softened for a weak one.</summary>
        private static DiagnosticSeverity SeverityFor(string key, double posterior)
        {
            DiagnosticSeverity baseSev;
            switch (key)
            {
                case BusFault:      baseSev = DiagnosticSeverity.High; break;
                case Misfire:
                case FuelDelivery:
                case WeakCylinder:
                case VacuumLeak:
                case Overfuel:      baseSev = DiagnosticSeverity.Medium; break;
                case MafError:      baseSev = DiagnosticSeverity.Medium; break;
                default:            baseSev = DiagnosticSeverity.Low; break;
            }
            if (posterior >= 0.85) return Bump(baseSev, +1);
            if (posterior < 0.45) return Bump(baseSev, -1);
            return baseSev;
        }

        private static DiagnosticSeverity Bump(DiagnosticSeverity s, int delta)
        {
            int v = (int)s + delta;
            if (v < (int)DiagnosticSeverity.Low) v = (int)DiagnosticSeverity.Low;   // floor at Low, never Info
            if (v > (int)DiagnosticSeverity.Critical) v = (int)DiagnosticSeverity.Critical;
            return (DiagnosticSeverity)v;
        }

        // ── Bayes math ────────────────────────────────────────────────────────

        /// <summary>Log-odds of a probability, clamped away from 0/1 to stay finite.</summary>
        private static double Logit(double p)
        {
            p = SignalMath.Clamp(p, 1e-6, 1 - 1e-6);
            return Math.Log(p / (1 - p));
        }

        /// <summary>Inverse of <see cref="Logit"/>.</summary>
        private static double Sigmoid(double x) => 1.0 / (1.0 + Math.Exp(-x));

        // ── Small helpers ─────────────────────────────────────────────────────

        private static Candidate GetOrAdd(Dictionary<string, Candidate> map, string key, string label)
        {
            Candidate c;
            if (!map.TryGetValue(key, out c))
            {
                c = new Candidate { Key = key, Label = label };
                map[key] = c;
            }
            return c;
        }

        private static bool Contains(string haystack, params string[] needles)
        {
            for (int i = 0; i < needles.Length; i++)
                if (haystack.IndexOf(needles[i], StringComparison.Ordinal) >= 0) return true;
            return false;
        }

        /// <summary>True if <paramref name="needle"/> occurs in <paramref name="haystack"/>
        /// as a whole word (both edges at a non-alphanumeric boundary) — so a short token
        /// like "bus" is not matched inside "combustion".</summary>
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

        private static string PairKey(string a, string b)
        {
            return string.CompareOrdinal(a, b) <= 0 ? a + "|" + b : b + "|" + a;
        }

        private static string Short(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return "hypothesis";
            s = s.Trim();
            return s.Length <= 64 ? s : s.Substring(0, 61) + "...";
        }

        private static string Pct(double p) =>
            ((int)Math.Round(SignalMath.Clamp(p, 0, 1) * 100)).ToString(CultureInfo.InvariantCulture) + "%";

        private static string BuildAdvisoryReason(bool usedExpertPrior, bool anyContribAdvisory,
                                                  bool thinEvidence, bool haveFixedBy)
        {
            var parts = new List<string>();
            if (usedExpertPrior)
                parts.Add(haveFixedBy
                    ? "some priors fell back to the spec-seeded expert table (no fixed-by history for that fault)"
                    : "priors are the built-in spec-seeded expert table (no fixed-by history available)");
            if (anyContribAdvisory) parts.Add("at least one contributing module result was itself advisory");
            if (thinEvidence) parts.Add("thin evidence — a single candidate with little corroboration");
            if (parts.Count == 0) parts.Add("ranking rests on unvalidated priors");
            return string.Join("; ", parts);
        }

        /// <summary>Lossless public projection of the internal ranked candidate list — the
        /// full frontier the Investigation Tree needs (every live hypothesis, with band).</summary>
        private static IReadOnlyList<RankedFault> ProjectFrontier(List<Candidate> ranked, bool advisory)
        {
            var list = new List<RankedFault>(ranked.Count);
            for (int i = 0; i < ranked.Count; i++)
            {
                var c = ranked[i];
                var contribs = new List<FaultContribution>(c.Contributions.Count);
                foreach (var ct in c.Contributions)
                    contribs.Add(new FaultContribution { Source = ct.Source, Likelihood = ct.Likelihood, Detail = ct.Detail });
                list.Add(new RankedFault
                {
                    FaultKey = c.Key,
                    Label = c.Label,
                    Prior = c.Prior,
                    PriorFromHistory = c.PriorFromHistory,
                    LogOdds = c.LogOdds,
                    Posterior = c.Posterior,
                    NormShare = c.NormShare,
                    Rank = i + 1,
                    Contributions = contribs,
                    Suspects = new List<string>(c.Suspects),
                    Advisory = advisory || c.AnyAdvisoryContrib,
                    Volatile = c.Volatile,
                });
            }
            FaultBanding.Assign(list);
            return list;
        }

        /// <summary>
        /// Collapse correlated contributions on one candidate: entries sharing a non-null
        /// <see cref="Contribution.CorrelationKey"/> merge to a single witness — the
        /// strongest-status one survives (confirmed beats pending beats present) and its
        /// Source is annotated with who echoed it.  Un-keyed contributions pass through.
        /// </summary>
        private static void CollapseCorrelatedContributions(Candidate c)
        {
            if (c.Contributions.Count < 2) return;

            var result = new List<Contribution>(c.Contributions.Count);
            var groupIndex = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            var witnesses = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);
            var echoCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            foreach (var contrib in c.Contributions)
            {
                if (string.IsNullOrEmpty(contrib.CorrelationKey)) { result.Add(contrib); continue; }

                if (!groupIndex.TryGetValue(contrib.CorrelationKey, out int idx))
                {
                    groupIndex[contrib.CorrelationKey] = result.Count;
                    witnesses[contrib.CorrelationKey] = new List<string>();
                    echoCount[contrib.CorrelationKey] = 0;
                    result.Add(contrib);
                    idx = result.Count - 1;
                }
                else
                {
                    echoCount[contrib.CorrelationKey]++;
                    if (contrib.Likelihood > result[idx].Likelihood)
                    {
                        // keep the earlier witness name + source id; the stronger status wins the slot
                        var w = result[idx].Witness;
                        var sid = SourceId(result[idx].Source);
                        result[idx] = contrib;
                        if (!string.IsNullOrEmpty(w)) witnesses[contrib.CorrelationKey].Add(w);
                        if (sid != null && sid != SourceId(contrib.Source)) witnesses[contrib.CorrelationKey].Add(sid);
                        continue;
                    }
                    // A DIFFERENT code collapsing onto the same structural fault must stay visible in
                    // the evidence (and keep its Establishes link) — record its source identity too.
                    var echoedId = SourceId(contrib.Source);
                    if (echoedId != null && echoedId != SourceId(result[idx].Source))
                        witnesses[contrib.CorrelationKey].Add(echoedId);
                }
                if (!string.IsNullOrEmpty(contrib.Witness)
                    && result[idx].Witness != contrib.Witness)
                    witnesses[contrib.CorrelationKey].Add(contrib.Witness);
            }

            // Annotate any slot that swallowed echoes so the evidence chain stays honest.
            foreach (var kv in groupIndex)
            {
                int extra = echoCount[kv.Key];
                if (extra == 0) continue;
                var kept = result[kv.Value];
                var names = witnesses[kv.Key]
                    .Where(w => !string.IsNullOrEmpty(w) && w != kept.Witness)
                    .Distinct(StringComparer.OrdinalIgnoreCase).ToList();
                kept.Source += names.Count > 0
                    ? $" — also reported by {string.Join(", ", names)}; correlated, counted once"
                    : $" — echoed {extra + 1}×; correlated, counted once";
                result[kv.Value] = kept;
            }

            c.Contributions.Clear();
            c.Contributions.AddRange(result);
        }

        /// <summary>The identity part of a contribution source — "DTC P0122 (confirmed)" → "DTC P0122" —
        /// so a same-code state echo is not re-announced but a different code always is.</summary>
        private static string SourceId(string source)
        {
            if (string.IsNullOrEmpty(source)) return null;
            int p = source.IndexOf(" (", StringComparison.Ordinal);
            return p > 0 ? source.Substring(0, p) : source;
        }

        // ── Candidate accumulator types ───────────────────────────────────────

        /// <summary>A fault under consideration, with its accumulated evidence and Bayes posterior.</summary>
        private sealed class Candidate
        {
            public string Key;
            public string Label;
            public double Prior;
            public bool PriorFromHistory;
            public double LogOdds;
            public double Posterior;
            public double NormShare;
            public readonly List<Contribution> Contributions = new List<Contribution>();
            public readonly HashSet<string> Suspects = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            public bool AnyAdvisoryContrib;
            public bool Volatile;   // this scan's DTC(s) carried intermittent/erratic grammar
        }

        /// <summary>One piece of independent evidence bearing on a candidate.</summary>
        private struct Contribution
        {
            public string Source;         // "M1: Vacuum...", "DTC P0171 (confirmed)"
            public double Likelihood;     // evidence likelihood, clamped [0.05, 0.95]
            public string Detail;         // human amplification for the evidence chain
            public string CorrelationKey; // non-null ⇒ same-key contributions are ONE witness (e.g. "DTC:P0100")
            public string Witness;        // who reported it (module name / TX id) — for the echo annotation
        }
    }
}
