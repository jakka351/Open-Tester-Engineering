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
//  Tester Present Specialist Automotive Solutions — Structural DTC → Fault Model
//
//  A FAULT CODE IS NOT THE FAULT.  A DTC is an *observation* the ECU logged (e.g. P0122 =
//  "Throttle Position Sensor A Circuit Low") — it is evidence, not the broken thing.  The broken
//  thing is a physical failure mode: an open wire, a short, a corroded connector, an internally
//  failed sensor, a stuck valve, a drifted reference, a mechanically-out-of-range system, or the
//  ECU's own driver.  This class inverts every DTC into the SET of physical faults that could
//  *emit* that observation, so the M6 Bayesian frontier can rank them (not just look the code up).
//
//  It is STRUCTURAL, not a lookup table: it reads the SAE J2012 system char (P/C/B/U) + subsystem
//  digit and the standard description grammar ("Circuit Low/High", "Open", "Short to ground/voltage",
//  "Range/Performance", "Correlation", "Intermittent", "Stuck", "Signal", "Flow/Leak") plus the
//  component named in the text.  So it covers EVERY DTC in the database — every OEM, every subsystem
//  — without inventing car-specific causes.  The failure-mode taxonomy it maps onto is exactly the
//  set an automotive circuit/rationality fault can physically take; nothing here is hallucinated.
//
//  Every fault it yields is ADVISORY (M6 flags expert-prior results as such): a physically-plausible
//  hypothesis to rank and discriminate with a test — never a verdict.  Priors are coarse base rates
//  and are [RequiresValidation]; a validated platform overrides them through the calibration store.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TesterPresent.OBD2.Intelligence
{
    /// <summary>One physical fault hypothesis extrapolated from a DTC observation.</summary>
    public sealed class DtcFault
    {
        public string Key { get; set; }        // stable hypothesis identity (tree node key): "<MODE>@<slug>"
        public string Label { get; set; }      // human fault sentence
        public string Meaning { get; set; }    // why this DTC implicates this fault (evidence detail)
        public double Prior { get; set; }      // coarse base rate [0.01..0.9] — [RequiresValidation]
        // Structural witness weight [0..1]: the FRACTIONAL log-odds discount M6 applies to this
        // fault's DTC-state evidence (LOWER = the code fans over more candidate faults, so each
        // gets weaker evidence). NOT a raw P(DTC|fault) — do not "correct" it upward, that
        // reintroduces the connector-outranks-everything defect (audit #1, 2026-07-18).
        public double DtcLikelihood { get; set; }
        public string NextTest { get; set; }   // the discriminating test that would confirm/deny it
        public string[] Suspects { get; set; } = Array.Empty<string>();
        /// <summary>True when the fault hides under probing (intermittent/erratic grammar, lost comms) —
        /// the Investigation Tree must not refute it on one clean pass.</summary>
        public bool Volatile { get; set; }
    }

    /// <summary>
    /// Structural inversion of a DTC observation into its candidate physical faults.  Pure, thread-safe,
    /// no external dependencies.  <see cref="Expand"/> is the entry point; <see cref="TryGetLabel"/> /
    /// <see cref="TryGetPrior"/> / <see cref="GetSuspects"/> let M6 resolve labels/priors for the keys it
    /// generated (populated as a side effect of Expand — the registry never shrinks, so keys stay stable).
    /// </summary>
    [RequiresValidation("Structural failure-mode priors are coarse base rates, not platform-characterised.")]
    public static class DtcFaultModel
    {
        // ── Failure-mode classes (the physical taxonomy every circuit/rationality fault maps onto) ──
        private const string OPEN  = "Open";        // open circuit / broken wire / high-resistance to spec-out
        private const string SG    = "ShortGnd";    // short to ground
        private const string SV    = "ShortVolt";   // short to voltage / battery
        private const string HR    = "Connector";   // corroded / high-resistance / spread-pin connector
        private const string INT   = "SensorInt";   // sensor/component internally failed
        private const string DRV   = "EcuDriver";   // ECU output driver / ground / supply
        private const string DRIFT = "SensorDrift"; // biased / drifted / contaminated reading (rationality)
        private const string MECH  = "MechRange";   // the measured system is genuinely out of range
        private const string CORR  = "Correlation"; // redundant-sensor disagreement / linkage
        private const string STUCK = "ActStuck";    // actuator stuck / seized / carboned
        private const string FLOW  = "FlowLeak";    // flow restriction / leak (valve, hose, passage)
        private const string COMMS = "Network";     // bus / communication fault

        // Coarse base rates. Connectors/wiring are the single most common real-world automotive electrical
        // fault, so HR/OPEN lead; drivers are rarer. All [RequiresValidation]; the calibration store can
        // override any of them once a platform is characterised.
        private static readonly Dictionary<string, double> ClassPrior = new Dictionary<string, double>
        {
            [HR] = 0.30, [OPEN] = 0.22, [INT] = 0.18, [SG] = 0.12, [SV] = 0.11, [DRV] = 0.08,
            [DRIFT] = 0.16, [MECH] = 0.16, [CORR] = 0.13, [STUCK] = 0.16, [FLOW] = 0.16, [COMMS] = 0.22,
        };

        // key -> (label, prior, suspects). Populated by Expand so M6.FaultLabel/ExpertPrior can resolve
        // dynamically-generated component keys later in the same (or a subsequent) analysis.
        private static readonly ConcurrentDictionary<string, DtcFault> _registry =
            new ConcurrentDictionary<string, DtcFault>(StringComparer.OrdinalIgnoreCase);

        public static bool TryGetLabel(string key, out string label)
        {
            if (key != null && _registry.TryGetValue(key, out var f)) { label = f.Label; return true; }
            label = null; return false;
        }
        public static bool TryGetPrior(string key, out double prior)
        {
            if (key != null && _registry.TryGetValue(key, out var f)) { prior = f.Prior; return true; }
            prior = 0; return false;
        }
        public static string[] GetSuspects(string key)
            => (key != null && _registry.TryGetValue(key, out var f)) ? f.Suspects : Array.Empty<string>();

        /// <summary>
        /// Expand one DTC (code + description) into every physical fault that could emit it.  Returns a
        /// physically-grounded, deduplicated set; empty only for a null/blank code.  Registers each key's
        /// label/prior/suspects for later lookup.
        /// </summary>
        public static IReadOnlyList<DtcFault> Expand(string code, string description)
        {
            code = (code ?? "").Trim().ToUpperInvariant();
            if (code.Length < 2) return Array.Empty<DtcFault>();
            char sys = code[0];
            string desc = (description ?? "").Trim();
            string dl = desc.ToLowerInvariant();

            // ── Network / communication codes: the fault is a bus/comm problem, not a sensor. ──
            if (sys == 'U')
            {
                var lost = dl.Contains("lost communication") || dl.Contains("no communication") || dl.Contains("missing message");
                var faults = new List<DtcFault>();
                Add(faults, COMMS, ComponentOf(desc, dl) ?? "the reporting module", code,
                    lost ? "module stopped transmitting — dead module, its power/ground, or a broken bus branch"
                         : "network/communication fault on the bus",
                    "back-probe the module's power & ground, then check bus continuity/termination (60Ω) to it",
                    new[] { "module power/ground", "CAN bus wiring / connector", "bus termination", "the module itself" });
                if (dl.Contains("bus off") || dl.Contains("bus-off"))
                    Add(faults, HR, "bus wiring", code, "bus-off — a shorted or open CAN pair forces the controller off the bus",
                        "check CAN-H/CAN-L for short-together, short-to-power/ground, and open", new[] { "CAN pair short/open", "a node dragging the bus" });
                // Lost-comms faults classically hide under probing — mark them volatile.
                foreach (var f in faults) MarkVolatile(f);
                return Finish(faults);
            }

            // Split "component noun phrase + grammar tail" FIRST, then read the grammar flags from
            // the TAIL only — so a component whose NAME contains a grammar word ("Mass Air Flow
            // Sensor", "High Pressure Pump") never raises a spurious failure mode. When the split
            // fails (free-form description), fall back to scanning the whole string as before.
            SplitDescription(desc, out string comp0, out string tail);
            string g = tail ?? dl;

            bool low   = Has(g, "low");
            bool high  = Has(g, "high");
            bool shortGnd = (Has(g, "short") || g.Contains("shorted")) && Has(g, "ground");
            bool shortVolt = (Has(g, "short") || g.Contains("shorted")) && (Has(g, "voltage") || Has(g, "battery") || g.Contains("b+"));
            low  = low || shortGnd;
            high = high || shortVolt;
            bool stuck = g.Contains("stuck") || g.Contains("seized");
            // "stuck open / stuck closed" is a MECHANICAL position, not an electrical open circuit.
            string gOpen = g.Replace("stuck open", "").Replace("stuck closed", "");
            bool open  = Has(gOpen, "open");
            bool range = Has(g, "range") || Has(g, "performance") || g.Contains("plausib") || Has(g, "rationality");
            bool correlation = g.Contains("correlation") || g.Contains("mismatch") || g.Contains("incorrect");
            bool intermittent = g.Contains("intermittent") || g.Contains("erratic");
            bool flow = Has(g, "flow") || g.Contains("insufficient") || g.Contains("excessive") || Has(g, "leak") || g.Contains("restrict") || g.Contains("blocked");
            bool circuit = g.Contains("circuit") || g.Contains("signal") || Has(g, "input") || Has(g, "malfunction");
            // Rationality / threshold grammar ("Efficiency Below Threshold", "Slow Response", "Too
            // Low"): the measured VALUE is out of spec — a system/sensor fault, not a wiring one.
            bool threshold = g.Contains("efficiency") || g.Contains("threshold") || Has(g, "below") || Has(g, "above")
                          || g.Contains("slow response") || g.Contains("too low") || g.Contains("too high");
            bool actuatorish = dl.Contains("solenoid") || dl.Contains("valve") || dl.Contains("actuator") || dl.Contains("control ") || dl.Contains("commanded") || dl.Contains("relay") || dl.Contains("motor") || dl.Contains("pump") || dl.Contains("driver");
            // An electrical reading needs an electrical CONTEXT (circuit/signal/input/short/open).
            // "Battery Voltage Low" or "Efficiency Below Threshold" name a VALUE, not a signal wire —
            // those route to the rationality pair (DRIFT/MECH) below, never to short/connector modes.
            bool electrical = circuit || shortGnd || shortVolt || open;
            bool valueOutOfRange = (low || high) && !electrical;

            string comp = comp0 ?? SubsystemName(code);
            var outp = new List<DtcFault>();

            // ── Electrical circuit failure modes ─────────────────────────────────────────────
            // A LOW reading = signal dragged to ground (an OPEN reads HIGH on a pulled-up sensor, so
            // 'low' does NOT imply open). A HIGH reading = the signal floated up: an OPEN / high-
            // resistance circuit (the MOST common cause on a pulled-up sensor) OR a short to voltage.
            if (shortGnd || (low && electrical))
                Add(outp, SG, comp, code, "reading pulled LOW — the signal wire shorted to ground, or the sensor/actuator failed low",
                    $"back-probe the {comp} signal at the ECU: unplug it — signal should go HIGH (biased) if the wire is shorted to ground",
                    Suspects(comp, "signal wire short-to-ground", "the " + comp, "connector"));
            if (open)
                Add(outp, OPEN, comp, code, "open circuit — broken wire, lost ground, or disconnected " + comp,
                    $"check continuity of the {comp} circuit end-to-end and its ground",
                    Suspects(comp, "open wire / ground", "connector", "the " + comp));
            if ((high && electrical) || shortVolt)
            {
                Add(outp, OPEN, comp, code, "reading floated HIGH — an OPEN / high-resistance circuit lets the " + comp + " signal drift to its reference (the usual cause of a high reading)",
                    $"unplug the {comp}: an open reads HIGH/max; check continuity and the ground / return path",
                    Suspects(comp, "open / high-resistance wire", "connector", "ground / return"));
                Add(outp, SV, comp, code, "reading pulled HIGH — the signal wire shorted to voltage, or the " + comp + " failed high",
                    $"back-probe the {comp} for a signal-to-voltage short; wiggle-test the harness",
                    Suspects(comp, "signal wire short-to-voltage", "the " + comp, "reference voltage"));
            }
            if (circuit || open)
            {
                Add(outp, HR, comp, code, "corroded / high-resistance / spread-pin connector on the " + comp + " circuit (the most common real-world cause of a circuit code)",
                    $"inspect & pin-drag the {comp} connector both ends; check for green corrosion, back-out terminals, water ingress",
                    Suspects(comp + " connector", "harness chafe", "terminal corrosion"));
                Add(outp, INT, comp, code, "the " + comp + " has failed internally",
                    $"substitute a known-good {comp} (or compare its output against a reference) once wiring is proven clean",
                    Suspects("the " + comp));
            }
            if ((actuatorish && circuit) || g.Contains("control circuit") || Has(g, "output"))
                Add(outp, DRV, comp, code, "the ECU output driver / ground / supply feeding the " + comp + " is at fault",
                    $"command the {comp} with bidirectional control and watch the driver voltage; if the ECU won't drive a good load, suspect the driver",
                    Suspects("ECU output driver", comp + " power/ground", "the " + comp));

            // ── Rationality / range / correlation ────────────────────────────────────────────
            if (range || threshold || valueOutOfRange)
            {
                Add(outp, DRIFT, comp, code, "the " + comp + " reads within circuit limits but the VALUE is wrong — drifted, biased, or contaminated",
                    $"compare the {comp} against a known-good reference / a second sensor at a known operating point",
                    Suspects("the " + comp + " (drift/contamination)", "reference input"));
                Add(outp, MECH, comp, code, "the reading is honest but the SYSTEM is genuinely out of range — the mechanical thing being measured is off",
                    $"verify the physical quantity independently (gauge/scope) before condemning the {comp}",
                    Suspects("mechanical system behind " + comp, "upstream cause"));
            }
            if (correlation)
                Add(outp, CORR, comp, code, "two signals that should agree do not — one sensor is wrong, or the mechanical linkage/timing between them has shifted",
                    $"log both correlated signals together; the one that departs from physical expectation (or the linkage/timing) is the fault",
                    Suspects("either correlated sensor", "mechanical linkage / timing", "wiring to one sensor"));

            // ── Actuator-specific ────────────────────────────────────────────────────────────
            if (stuck || (actuatorish && (flow || range)))
                Add(outp, STUCK, comp, code, "the " + comp + " is mechanically stuck / seized / carbon-fouled (won't move to the commanded position)",
                    $"command the {comp} open & closed with bidirectional control and confirm actual movement / feedback",
                    Suspects("the " + comp + " (stuck/carboned)", "linkage", "ECU driver"));
            if (flow)
                Add(outp, FLOW, comp, code, "flow/leak fault in the " + comp + " path — restriction, leak, or blocked passage",
                    $"pressure/flow-test the {comp} path; smoke-test for leaks where applicable",
                    Suspects(comp + " passage/hose", "restriction / leak", "the valve"));

            // If the grammar was too generic to place, still give the honest electrical baseline so no
            // code contributes *nothing* — a bare "…Malfunction" is at minimum wiring/connector/component.
            if (outp.Count == 0)
            {
                Add(outp, HR, comp, code, "unspecified malfunction — start at the " + comp + " wiring & connector",
                    $"inspect the {comp} circuit & connector, then verify the {comp} against a reference", Suspects(comp + " connector", "the " + comp, "wiring"));
                Add(outp, INT, comp, code, "the " + comp + " itself may have failed", $"substitute/compare the {comp}", Suspects("the " + comp));
            }

            // Intermittent/erratic grammar: every fault behind this code hides under probing — the
            // Investigation Tree must suspend (not refute) them on a lone clean pass.
            if (intermittent)
                foreach (var f in outp) MarkVolatile(f);

            return Finish(outp);
        }

        // ── helpers ──────────────────────────────────────────────────────────────────────────
        private static bool Has(string s, string word)
        {
            // word-ish contains: avoid "low" matching "flow"/"below", "high" matching nothing odd.
            int i = s.IndexOf(word, StringComparison.Ordinal);
            while (i >= 0)
            {
                bool lb = i == 0 || !char.IsLetter(s[i - 1]);
                bool rb = i + word.Length >= s.Length || !char.IsLetter(s[i + word.Length]);
                if (lb && rb) return true;
                i = s.IndexOf(word, i + 1, StringComparison.Ordinal);
            }
            return false;
        }

        private static string[] Suspects(params string[] s) => s?.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray() ?? Array.Empty<string>();

        // The vocabulary a J2012 grammar TAIL is written in.  The component/grammar split walks
        // tokens backward from the end of the description while every token is in this set; the
        // walk stops at the first component word ("sensor", "pump", "a") so grammar words INSIDE
        // a component name ("Mass Air FLOW Sensor", "HIGH Pressure Pump") are never consumed.
        private static readonly HashSet<string> GrammarWords = new HashSet<string>(StringComparer.Ordinal)
        {
            "circuit","signal","low","high","open","short","shorted","ground","battery","voltage","input","output",
            "malfunction","range","performance","rationality","plausible","implausible","correlation","mismatch",
            "incorrect","intermittent","erratic","stuck","closed","seized","insufficient","excessive","leak","flow",
            "restricted","restriction","blocked","slow","response","below","above","threshold","efficiency","too",
            "detected","missing","b+","of","or","and","to","on","off","no","not",
        };
        // Identity qualifiers ("Bank 1", "Sensor 2", "Cylinder 3") stay part of the COMPONENT so
        // Bank-1 and Bank-2 sensors keep distinct fault keys.
        private static readonly HashSet<string> QualifierHeads = new HashSet<string>(StringComparer.Ordinal)
            { "bank", "sensor", "cylinder", "module", "row", "pump" };

        /// <summary>
        /// Split a description into (component noun phrase, grammar tail).  The component keeps
        /// identity qualifiers ("Bank 1 Sensor 1") and its original casing; the tail is the
        /// lowercase grammar phrase for flag detection, or null when no grammar was found.
        /// </summary>
        private static void SplitDescription(string desc, out string comp, out string tail)
        {
            comp = null; tail = null;
            if (string.IsNullOrWhiteSpace(desc)) return;
            string work = desc.Trim();
            string qualifier = "";
            var tailParts = new List<string>();

            // Trailing parentheticals: "(Bank 1 Sensor 1)" is identity → keep for the component;
            // "(large leak)" is grammar → route to the tail; anything else ("(MIL Request)") drops.
            while (work.EndsWith(")", StringComparison.Ordinal))
            {
                int i = work.LastIndexOf('(');
                if (i < 0) break;
                string inner = work.Substring(i + 1, work.Length - i - 2).Trim();
                work = work.Substring(0, i).TrimEnd();
                var innerToks = inner.ToLowerInvariant().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (innerToks.Any(t => GrammarWords.Contains(CleanToken(t)) && !IsGlue(t)))
                    tailParts.Add(inner.ToLowerInvariant());
                else if (innerToks.Any(t => QualifierHeads.Contains(CleanToken(t)) || t.All(char.IsDigit)))
                    qualifier = " " + inner + qualifier;
            }

            var tokens = work.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            // End-anchored identity pairs: "… Bank 1", "… Sensor 2" move to the qualifier so the
            // grammar walk can reach the real tail ("Circuit Low Bank 1" → walk sees "circuit low").
            while (tokens.Count >= 2)
            {
                string last = CleanToken(tokens[tokens.Count - 1].ToLowerInvariant());
                string prev = CleanToken(tokens[tokens.Count - 2].ToLowerInvariant());
                if (IsNumberish(last) && QualifierHeads.Contains(prev))
                {
                    qualifier = " " + tokens[tokens.Count - 2] + " " + tokens[tokens.Count - 1] + qualifier;
                    tokens.RemoveRange(tokens.Count - 2, 2);
                }
                else break;
            }

            // Backward grammar walk: consume trailing tokens while every one is grammar vocabulary.
            int cut = tokens.Count;
            while (cut > 0)
            {
                string t = tokens[cut - 1].ToLowerInvariant();
                // A slash-joined token counts as grammar only if EVERY part is ("circuit/open" yes,
                // "ECM/PCM" and "Crankshaft/Camshaft" no).
                var parts = CleanToken(t).Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                bool grammar = parts.Length == 0 || parts.All(p => GrammarWords.Contains(p));
                if (!grammar) break;
                cut--;
            }
            if (cut < tokens.Count)
                tailParts.Insert(0, string.Join(" ",
                    tokens.Skip(cut).Select(t => CleanToken(t.ToLowerInvariant()).Replace('/', ' '))));

            // Component = the un-walked head + preserved identity qualifiers, minus dangling glue.
            var head = tokens.Take(cut).ToList();
            while (head.Count > 0 && IsGlue(CleanToken(head[head.Count - 1].ToLowerInvariant())))
                head.RemoveAt(head.Count - 1);
            string c = (string.Join(" ", head) + qualifier).Trim().TrimEnd('-', '/', ',', ':', ';').Trim();
            c = string.Join(" ", c.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries));
            if (c.Length >= 2) comp = c;
            if (tailParts.Count > 0) tail = string.Join(" ", tailParts);
        }

        private static string CleanToken(string t) => t.Trim('-', '/', ',', ':', ';', '.', '(', ')').Trim();
        private static bool IsGlue(string t) => t == "or" || t == "and" || t == "of" || t == "to" || t == "with" || t.Length == 0;
        private static bool IsNumberish(string t) => t.Length > 0 && (t.All(char.IsDigit) || (t.Length == 1 && (t[0] == 'a' || t[0] == 'b')));

        /// <summary>Recover the component phrase (e.g. "Throttle Position Sensor A") from a description.</summary>
        private static string ComponentOf(string desc, string dl)
        {
            SplitDescription(desc, out string comp, out _);
            return comp;
        }

        // Coarse subsystem name from the SAE structure when the description is empty/unhelpful.
        private static string SubsystemName(string code)
        {
            if (code.Length < 3) return "the affected circuit";
            char sys = code[0];
            if (sys == 'C') return "the chassis (ABS/traction/steering) circuit";
            if (sys == 'B') return "the body electrical circuit";
            if (sys != 'P' || code.Length < 3) return "the affected circuit";
            switch (code[2])
            {
                case '1': return "the fuel/air metering sensor";
                case '2': return "the fuel injector / metering circuit";
                case '3': return "the ignition / misfire system";
                case '4': return "the emissions system (EGR/EVAP/catalyst/O2)";
                case '5': return "the vehicle-speed / idle / aux input";
                case '6': return "the computer output / auxiliary circuit";
                case '7': case '8': case '9': return "the transmission (solenoid/pressure/ratio) circuit";
                default: return "the powertrain circuit";
            }
        }

        private static void Add(List<DtcFault> list, string mode, string comp, string code, string meaning, string nextTest, string[] suspects)
        {
            string key = mode + "@" + Slug(comp);
            double prior = ClassPrior.TryGetValue(mode, out var p) ? p : 0.12;
            double like = mode == INT || mode == STUCK || mode == MECH ? 0.55 : 0.45;   // circuit modes are cheaper/likelier witnesses
            var f = new DtcFault
            {
                Key = key, Label = FriendlyLabel(mode, comp), Meaning = meaning,
                Prior = prior, DtcLikelihood = like, NextTest = nextTest, Suspects = suspects ?? Array.Empty<string>(),
            };
            list.Add(f);
            _registry.AddOrUpdate(key, f, (_, existing) => existing);   // first writer wins (stable label/prior)
        }

        /// <summary>Flag THIS expansion's fault volatile. Per-instance only — deliberately does NOT
        /// latch into the process-global _registry: that is first-writer-wins and shared across every
        /// vehicle scanned in the process, so a registry latch would make a later PLAIN code on a
        /// different car wrongly volatile. M6 carries this flag onto the hypothesis instead.</summary>
        private static void MarkVolatile(DtcFault f) => f.Volatile = true;

        private static string FriendlyLabel(string mode, string comp)
        {
            switch (mode)
            {
                case OPEN:  return "Open / broken wire — " + comp;
                case SG:    return "Short to ground — " + comp;
                case SV:    return "Short to voltage — " + comp;
                case HR:    return "Corroded / high-resistance connector — " + comp;
                case INT:   return comp + " failed internally";
                case DRV:   return "ECU driver / power / ground — " + comp;
                case DRIFT: return comp + " drifted / contaminated (reads wrong)";
                case MECH:  return "Mechanically out of range — " + comp;
                case CORR:  return "Correlation / linkage mismatch — " + comp;
                case STUCK: return comp + " stuck / seized";
                case FLOW:  return "Flow restriction / leak — " + comp;
                case COMMS: return "Communication / bus fault — " + comp;
                default:    return mode + " — " + comp;
            }
        }

        private static string Slug(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return "SYSTEM";
            var sb = new StringBuilder(s.Length);
            foreach (char c in s)
                if (char.IsLetterOrDigit(c)) sb.Append(char.ToUpperInvariant(c));
            var slug = sb.ToString();
            if (slug.Length == 0) return "SYSTEM";
            if (slug.Length <= 64) return slug;
            // Long components truncate WITH a stable content hash so two long descriptions sharing a
            // prefix can never collide onto one key (first-writer-wins registry made that silent).
            return slug.Substring(0, 55) + "~" + Fnv1a(slug).ToString("X8");
        }

        /// <summary>Deterministic 32-bit FNV-1a — stable across processes (string.GetHashCode is not).</summary>
        private static uint Fnv1a(string s)
        {
            uint h = 2166136261;
            foreach (char c in s) { h ^= c; h *= 16777619; }
            return h;
        }

        // Dedup by key (keep the richest meaning) and return.
        private static IReadOnlyList<DtcFault> Finish(List<DtcFault> list)
        {
            var seen = new Dictionary<string, DtcFault>(StringComparer.OrdinalIgnoreCase);
            foreach (var f in list)
                if (!seen.ContainsKey(f.Key)) seen[f.Key] = f;
            return seen.Values.ToList();
        }
    }
}
