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
//  Tester Present Specialist Automotive Solutions — Investigation Session persistence (E2)
//
//  A real job pauses: the car is on the hoist three days waiting on a part. The
//  investigation tree must survive that wait and resurrect EXACTLY where it stopped —
//  every hypothesis, every ruled-out branch, the fix that's mid-flight. This is
//  LOCAL-ONLY JSON on the workshop's own machine (%LOCALAPPDATA%\TesterPresent\sessions),
//  keyed by VIN — the mechanic's own notebook, never transmitted (data-privacy doctrine).
//
//  Serialisation is hand-built JObject with STABLE STRING KEYS and enum NAMES, on purpose:
//  Obfuscate-iT renames properties (reflection-based JSON would break saved jobs across an
//  app update) and enum ordinals shift on a reorder — names + string keys are immune to both.
//  EvidenceChain is intentionally NOT persisted (display detail the next capture refreshes);
//  the load-bearing belief state + graph structure round-trips in full.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TesterPresent.OBD2.Intelligence.Session
{
    /// <summary>A paused investigation the tech can resume — for a "resume a job" picker.</summary>
    public sealed class SessionSummary
    {
        public string Vin { get; set; } = "";
        public string Platform { get; set; } = "";
        public int ModelYear { get; set; }
        public DateTime SavedUtc { get; set; }
        public int LiveHypotheses { get; set; }
        public int NodeCount { get; set; }
        public string BestSupported { get; set; } = "";
    }

    /// <summary>Local JSON persistence for the Investigation Tree, one file per VIN.</summary>
    public sealed class SessionStore
    {
        private const int SchemaVersion = 1;
        private readonly string _dir;
        private readonly object _gate = new object();

        public SessionStore() : this(null) { }

        /// <param name="baseDir">Directory for the session files; defaults to
        /// %LOCALAPPDATA%\TesterPresent\sessions. Explicit path used by tests.</param>
        public SessionStore(string baseDir)
        {
            _dir = string.IsNullOrWhiteSpace(baseDir) ? DefaultDir() : baseDir;
        }

        private static string DefaultDir()
        {
            try
            {
                string root = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(root, "TesterPresent", "sessions");
            }
            catch { return "sessions"; }
        }

        /// <summary>Filesystem-safe file name for a VIN (VINs are alphanumeric; guard anyway).</summary>
        private string PathFor(string vin)
        {
            string safe = string.IsNullOrWhiteSpace(vin) ? "_novin" : vin.Trim();
            foreach (char c in Path.GetInvalidFileNameChars()) safe = safe.Replace(c, '_');
            if (safe.Length == 0) safe = "_novin";
            return Path.Combine(_dir, safe + ".json");
        }

        public bool Exists(string vin) => File.Exists(PathFor(vin));

        // ── Save ────────────────────────────────────────────────────────────────

        /// <summary>Persist a session to its VIN file (atomic via temp-then-replace). Best-effort — never throws.</summary>
        public void Save(DiagnosticSession session)
        {
            if (session == null) return;
            lock (_gate)
            {
                try
                {
                    var nodes = new JArray();
                    foreach (var n in session.Nodes) nodes.Add(NodeToJson(n));
                    var edges = new JArray();
                    foreach (var e in session.Edges) edges.Add(EdgeToJson(e));

                    var root = new JObject
                    {
                        ["version"] = SchemaVersion,
                        ["savedUtc"] = DateTime.UtcNow.ToString("o"),
                        ["vin"] = session.Vin ?? "",
                        ["platform"] = session.Platform ?? "",
                        ["modelYear"] = session.ModelYear,
                        ["connectedUtc"] = session.ConnectedUtc.ToString("o"),
                        ["rootId"] = session.RootId.ToString(),
                        ["lastDiscriminator"] = session.LastDiscriminator ?? "",
                        ["nodes"] = nodes,
                        ["edges"] = edges,
                    };

                    if (!Directory.Exists(_dir)) Directory.CreateDirectory(_dir);
                    string path = PathFor(session.Vin);
                    string tmp = path + ".tmp";
                    File.WriteAllText(tmp, root.ToString(Formatting.Indented));
                    // Atomic swap: File.Replace overwrites the destination in a single OS operation —
                    // no delete-then-move window where a crash / AV lock could leave only the .tmp and
                    // destroy the paused session (the survive-a-multi-day-pause promise). First write
                    // (no existing file) uses Move.
                    if (File.Exists(path)) File.Replace(tmp, path, null);
                    else File.Move(tmp, path);
                }
                catch { /* disk full / locked — keep the in-memory session working */ }
            }
        }

        private static JObject NodeToJson(ReasoningNode n) => new JObject
        {
            ["id"] = n.Id.ToString(),
            ["kind"] = n.Kind.ToString(),
            ["parentId"] = n.ParentId.HasValue ? n.ParentId.Value.ToString() : null,
            ["title"] = n.Title ?? "",
            ["createdUtc"] = n.CreatedUtc.ToString("o"),
            ["status"] = n.Status.ToString(),
            ["source"] = n.Source ?? "",
            ["faultKey"] = n.FaultKey,
            ["band"] = n.Band.ToString(),
            ["baseLogOdds"] = n.BaseLogOdds,
            ["accumulatedDelta"] = n.AccumulatedDelta,
            ["priorFromHistory"] = n.PriorFromHistory,
            ["volatile"] = n.Volatile,
            ["refuteAttempts"] = n.RefuteAttempts,
            ["confirmedOnVehicle"] = n.ConfirmedOnVehicle,
            ["verdict"] = n.Verdict.ToString(),
            ["fixAction"] = n.FixAction,
            ["suspects"] = new JArray(n.Suspects ?? new List<string>()),
        };

        private static JObject EdgeToJson(Edge e) => new JObject
        {
            ["from"] = e.FromId.ToString(),
            ["to"] = e.ToId.ToString(),
            ["kind"] = e.Kind.ToString(),
            ["delta"] = e.LogOddsDelta,
            ["rationale"] = e.Rationale ?? "",
        };

        // ── Load ────────────────────────────────────────────────────────────────

        /// <summary>Rebuild a session from its VIN file, or null if absent/corrupt (never throws).</summary>
        public DiagnosticSession Load(string vin)
        {
            lock (_gate)
            {
                string path = PathFor(vin);
                try
                {
                    if (!File.Exists(path)) return null;
                    string json = File.ReadAllText(path);
                    if (string.IsNullOrWhiteSpace(json)) return null;

                    var root = JObject.Parse(json);
                    var s = new DiagnosticSession
                    {
                        Vin = (string)root["vin"] ?? "",
                        Platform = (string)root["platform"] ?? "",
                        ModelYear = root.Value<int?>("modelYear") ?? 0,
                        ConnectedUtc = ParseUtc(root["connectedUtc"]) ?? DateTime.UtcNow,
                        LastDiscriminator = (string)root["lastDiscriminator"],
                    };
                    if (Guid.TryParse((string)root["rootId"], out var rid)) s.RootId = rid;

                    s.Nodes.Clear();
                    if (root["nodes"] is JArray nodes)
                        foreach (var jn in nodes.OfType<JObject>())
                        {
                            var node = NodeFromJson(jn);
                            if (node != null) s.Nodes.Add(node);
                        }

                    s.Edges.Clear();
                    if (root["edges"] is JArray edges)
                        foreach (var je in edges.OfType<JObject>())
                        {
                            var edge = EdgeFromJson(je);
                            if (edge != null) s.Edges.Add(edge);
                        }

                    // A session with no root node is corrupt — reject it.
                    if (s.Nodes.All(n => n.Id != s.RootId)) return null;
                    return s;
                }
                catch { return null; }
            }
        }

        private static ReasoningNode NodeFromJson(JObject j)
        {
            if (!Guid.TryParse((string)j["id"], out var id)) return null;
            var n = new ReasoningNode
            {
                Id = id,
                Kind = ParseEnum((string)j["kind"], NodeKind.Observation),
                ParentId = Guid.TryParse((string)j["parentId"], out var pid) ? pid : (Guid?)null,
                Title = (string)j["title"] ?? "",
                CreatedUtc = ParseUtc(j["createdUtc"]) ?? DateTime.UtcNow,
                Status = ParseEnum((string)j["status"], NodeStatus.Live),
                Source = (string)j["source"] ?? "",
                FaultKey = (string)j["faultKey"],
                Band = ParseEnum((string)j["band"], FaultBand.TrailingFar),
                BaseLogOdds = j.Value<double?>("baseLogOdds") ?? 0,
                AccumulatedDelta = j.Value<double?>("accumulatedDelta") ?? 0,
                PriorFromHistory = j.Value<bool?>("priorFromHistory") ?? false,
                Volatile = j.Value<bool?>("volatile") ?? false,
                RefuteAttempts = j.Value<int?>("refuteAttempts") ?? 0,
                ConfirmedOnVehicle = j.Value<bool?>("confirmedOnVehicle") ?? false,
                Verdict = ParseEnum((string)j["verdict"], EvidenceVerdict.Info),
                FixAction = (string)j["fixAction"],
            };
            if (j["suspects"] is JArray sus)
                n.Suspects = sus.Select(x => (string)x).Where(x => !string.IsNullOrEmpty(x)).ToList();
            return n;
        }

        private static Edge EdgeFromJson(JObject j)
        {
            if (!Guid.TryParse((string)j["from"], out var from) || !Guid.TryParse((string)j["to"], out var to))
                return null;
            return new Edge
            {
                FromId = from,
                ToId = to,
                Kind = ParseEnum((string)j["kind"], EdgeKind.Establishes),
                LogOddsDelta = j.Value<double?>("delta") ?? 0,
                Rationale = (string)j["rationale"] ?? "",
            };
        }

        // ── Listing / deletion (for a resume-a-job picker) ────────────────────────

        /// <summary>Summaries of every saved session, newest first.</summary>
        public IReadOnlyList<SessionSummary> List()
        {
            var outp = new List<SessionSummary>();
            try
            {
                if (!Directory.Exists(_dir)) return outp;
                foreach (var file in Directory.GetFiles(_dir, "*.json"))
                {
                    try
                    {
                        var root = JObject.Parse(File.ReadAllText(file));
                        var nodes = root["nodes"] as JArray ?? new JArray();
                        int live = nodes.OfType<JObject>().Count(n =>
                            (string)n["kind"] == nameof(NodeKind.Hypothesis) && (string)n["status"] == nameof(NodeStatus.Live));
                        var best = nodes.OfType<JObject>().FirstOrDefault(n =>
                            (string)n["kind"] == nameof(NodeKind.Hypothesis) && (string)n["status"] == nameof(NodeStatus.BestSupported));
                        outp.Add(new SessionSummary
                        {
                            Vin = (string)root["vin"] ?? "",
                            Platform = (string)root["platform"] ?? "",
                            ModelYear = root.Value<int?>("modelYear") ?? 0,
                            SavedUtc = ParseUtc(root["savedUtc"]) ?? DateTime.MinValue,
                            LiveHypotheses = live,
                            NodeCount = nodes.Count,
                            BestSupported = best != null ? (string)best["title"] : "",
                        });
                    }
                    catch { /* skip a corrupt file */ }
                }
            }
            catch { }
            return outp.OrderByDescending(s => s.SavedUtc).ToList();
        }

        public void Delete(string vin)
        {
            try { string p = PathFor(vin); if (File.Exists(p)) File.Delete(p); } catch { }
        }

        // ── Helpers ───────────────────────────────────────────────────────────────

        private static TEnum ParseEnum<TEnum>(string s, TEnum fallback) where TEnum : struct
            => !string.IsNullOrEmpty(s) && Enum.TryParse<TEnum>(s, out var v) ? v : fallback;

        private static DateTime? ParseUtc(JToken tok)
        {
            string s = (string)tok;
            if (string.IsNullOrEmpty(s)) return null;
            return DateTime.TryParse(s, null, System.Globalization.DateTimeStyles.RoundtripKind, out var dt) ? dt : (DateTime?)null;
        }
    }
}
