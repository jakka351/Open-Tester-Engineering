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
//  Tester Present Specialist Automotive Solutions — Fix Arm: Fault → Procedure matcher (E4)
//
//  The 90k OEM procedures are the MUSCLE; this is the nerve that connects a fault
//  HYPOTHESIS to the routine families that help resolve it.  M6 says "vacuum leak";
//  this returns the throttle-relearn / adaptation-reset procedures the tech runs
//  after sealing it, drawn from that OEM's real procedure library.
//
//  It is ADVISORY and OWNER-VETTED by design.  The mapping below is a SEED — a
//  conservative, Ford-first ontology of which procedure families ring true for each
//  fault.  jakka351 vets/extends it per platform; a wrong suggestion on a real car
//  ranges from embarrassing to dangerous, so nothing here executes anything — it only
//  PROPOSES candidates, ranked, with a plain-language rationale.  The tech decides.
//
//  SAFETY (non-negotiable): a restraints/airbag procedure is NEVER surfaced as a fix,
//  regardless of keyword match — the matcher drops it before scoring.  The executor's
//  RCM hard-block is the backstop; this is the first gate.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using TesterPresent.OBD2.Data;

namespace TesterPresent.OBD2.Intelligence.Fix
{
    /// <summary>One procedure proposed as relevant to a fault hypothesis. Always advisory.</summary>
    public sealed class FixCandidate
    {
        public string FaultKey { get; set; }
        public ProcRecord Procedure { get; set; }
        public string ProcedureName { get; set; }
        public string CapabilityTag { get; set; }
        public string Archetype { get; set; }
        public bool IsExecutable { get; set; }
        /// <summary>Ontology-seeded relevance [0,1] — a ranking aid, NEVER a tech-facing number.</summary>
        public double Affinity { get; set; }
        /// <summary>Plain-language "why this procedure relates to this fault".</summary>
        public string Rationale { get; set; }
        /// <summary>Owner-vetted mapping is advisory; the tech confirms before anything runs.</summary>
        public bool Advisory => true;
    }

    /// <summary>
    /// The owner-vetted fault→procedure ontology. Each fault maps to the procedure-name
    /// keyword families (and archetype hints) that genuinely help resolve it, plus a rationale.
    /// SEED VALUES — Ford-first, conservative. Extend per platform after bench validation.
    /// </summary>
    public static class FaultProcedureOntology
    {
        /// <summary>One fault's affinity to a family of procedures.</summary>
        public sealed class Affinity
        {
            public string[] NameKeywords;    // matched (case-insensitive) against ProcRecord.Name
            public string[] ArchetypeHints;  // matched against ProcRecord.Archetype
            public string Rationale;         // mechanic-voice "why"
            public double Weight;            // base relevance [0,1]
        }

        // ── SEED ONTOLOGY — jakka351 vets/extends. All [RequiresValidation]. ──
        private static readonly Dictionary<string, Affinity> _map =
            new Dictionary<string, Affinity>(StringComparer.OrdinalIgnoreCase)
        {
            ["VacuumLeak"] = new Affinity
            {
                NameKeywords = new[] { "THROTTLE RELEARN", "THROTTLE LEARN", "IDLE RELEARN", "IDLE LEARN",
                                       "RESET ADAPTATION", "ADAPTATION RESET", "ADAPTATION VALUES", "FUEL TRIM RESET" },
                ArchetypeHints = new[] { "ADAPTATION", "RELEARN", "RESET" },
                Weight = 0.7,
                Rationale = "A vacuum/unmetered-air leak is a mechanical repair (gasket, hose, PCV, brake booster). "
                          + "After sealing it, reset the fuel adaptations and relearn idle so the ECU drops the "
                          + "trims it learned to mask the leak.",
            },
            ["MafError"] = new Affinity
            {
                NameKeywords = new[] { "MAF RESET", "MAF ADAPT", "MASS AIR", "RESET ADAPTATION", "ADAPTATION RESET",
                                       "THROTTLE RELEARN", "FUEL TRIM RESET" },
                ArchetypeHints = new[] { "ADAPTATION", "RESET", "RELEARN" },
                Weight = 0.7,
                Rationale = "A MAF reading low under-reports airflow. After cleaning or replacing the MAF, reset its "
                          + "adaptation and the fuel trims; some platforms pair a throttle relearn.",
            },
            ["FuelDelivery"] = new Affinity
            {
                NameKeywords = new[] { "FUEL PUMP", "INJECTOR TEST", "INJECTOR FLOW", "FUEL PRESSURE",
                                       "FUEL SYSTEM", "FUEL RAIL", "FUEL DELIVERY" },
                ArchetypeHints = new[] { "ACTUATOR_TEST", "ROUTINE" },
                Weight = 0.65,
                Rationale = "A fuel-delivery shortfall — confirm the pump, injectors and rail pressure. These "
                          + "bidirectional tests exercise the fuel system so you see the shortfall directly.",
            },
            ["Misfire"] = new Affinity
            {
                NameKeywords = new[] { "MISFIRE", "CYLINDER BALANCE", "CYLINDER CONTRIBUTION", "CYLINDER POWER",
                                       "COMPRESSION", "INJECTOR TEST", "COIL TEST", "IGNITION TEST" },
                ArchetypeHints = new[] { "ACTUATOR_TEST", "ROUTINE" },
                Weight = 0.65,
                Rationale = "Misfire — localize the dead hole. Cylinder-balance/contribution and injector/coil tests "
                          + "point at the weak cylinder; compression separates mechanical from ignition/fuel.",
            },
            ["WeakCylinder"] = new Affinity
            {
                NameKeywords = new[] { "COMPRESSION", "RELATIVE COMPRESSION", "CYLINDER BALANCE",
                                       "CYLINDER CONTRIBUTION", "LEAK DOWN", "LEAKDOWN" },
                ArchetypeHints = new[] { "ACTUATOR_TEST", "ROUTINE" },
                Weight = 0.7,
                Rationale = "A weak cylinder is mechanical — relative-compression and cylinder-balance quantify it; "
                          + "a leak-down localizes the loss (valve, ring, or head gasket).",
            },
            ["Overfuel"] = new Affinity
            {
                NameKeywords = new[] { "RESET ADAPTATION", "ADAPTATION RESET", "FUEL TRIM RESET", "INJECTOR CODING",
                                       "INJECTOR PROGRAM", "FUEL PRESSURE" },
                ArchetypeHints = new[] { "ADAPTATION", "RESET" },
                Weight = 0.6,
                Rationale = "System-too-rich — after fixing the cause (injector, pressure, sensor), reset the fuel "
                          + "adaptations; injector coding corrects a flow-mismatched injector.",
            },
            ["BusFault"] = new Affinity
            {
                NameKeywords = new[] { "NETWORK TEST", "MODULE SCAN", "GATEWAY", "COMMUNICATION", "BUS TEST", "TOPOLOGY" },
                ArchetypeHints = new[] { "NETWORK" },
                Weight = 0.4,   // a bus fault is usually wiring/terminator/gateway — mostly physical, not a routine
                Rationale = "A shared-bus / lost-comms fault is usually wiring, a missing terminator, or a gateway "
                          + "that stopped forwarding — not a routine. These network tools help localize the segment "
                          + "or node that dropped.",
            },
            ["SensorDropout"] = new Affinity
            {
                NameKeywords = new[] { "SENSOR TEST", "SIGNAL TEST", "SELF TEST", "SELF-TEST" },
                ArchetypeHints = new[] { "ACTUATOR_TEST" },
                Weight = 0.35,  // intermittent dropout is a wiring/connector fault — wiggle-test under live data
                Rationale = "An intermittent sensor dropout is a wiring/connector fault — wiggle-test the harness "
                          + "under live data; a sensor self-test may reproduce it.",
            },
        };

        public static Affinity For(string faultKey)
            => faultKey != null && _map.TryGetValue(faultKey, out var a) ? a : null;

        public static bool IsKnown(string faultKey) => faultKey != null && _map.ContainsKey(faultKey);

        public static IReadOnlyCollection<string> KnownFaultKeys => _map.Keys;
    }

    /// <summary>Matches a fault hypothesis to candidate procedures from an OEM's library.</summary>
    public static class ProcedureMatcher
    {
        // A restraints/airbag procedure is NEVER a "fix" candidate, no matter what it matches.
        // Two tiers (audit 2026-07-12 — the old English-full-word list let "RCM Self Test" slip
        // through because "RCM" wasn't listed):
        //  (1) descriptive restraint WORDS matched as substrings (over-blocking here is SAFE —
        //      better to hide a legit fix than surface a dangerous one), and
        //  (2) restraint/airbag MODULE ACRONYMS matched as whole TOKENS, so "RCM"/"OCS"/"SDM"
        //      are always caught but "FORCE"/"PROCESS" are not false-blocked.
        private static readonly string[] SAFETY_SUBSTRINGS =
        {
            "AIRBAG", "AIR BAG", "RESTRAINT", "RÜCKHALT", "RUCKHALT", "PYRO", "SEAT BELT", "SEATBELT",
            "SAFETY BELT", "BELT TENSION", "PRETENSION", "PRE-TENSION", "PRE TENSION", "GURTSTRAFFER",
            "SQUIB", "INFLATOR", "INFLATER", "IGNITER", "IGNITOR", "INITIATOR", "DEPLOY",
            "CLOCKSPRING", "CLOCK SPRING", "CLOCK-SPRING", "OCCUPANT", "ROLLOVER", "ROLL OVER",
            "SIDE CURTAIN", "KNEE BOLSTER", "IMPACT SENSOR", "CRASH", "COLLISION",
        };

        // Restraint/airbag control-module acronyms (RCM Ford, ACU Airbag Control Unit, ORC occupant
        // restraint controller, OCS/OCSM occupant classification, SDM GM sensing-diagnostic, SRS/SRSCM).
        // "ACM" is NOT here on purpose: it is overwhelmingly the Audio (or Aftertreatment) Control
        // Module, not an airbag module — blocking it hid legitimate audio routines. The real airbag
        // control acronym is ACU.
        private static readonly HashSet<string> SAFETY_MODULE_TOKENS =
            new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            { "RCM", "ACU", "ORC", "OCS", "OCSM", "SDM", "SRS", "SRSCM", "RSM", "AOM", "PPS" };

        // camelCase / acronym boundary — so "RCMSelfTest" splits to RCM|Self|Test.
        private static readonly System.Text.RegularExpressions.Regex CamelBoundary =
            new System.Text.RegularExpressions.Regex(
                @"(?<=[\p{Ll}\p{N}])(?=\p{Lu})|(?<=\p{Lu})(?=\p{Lu}\p{Ll})",
                System.Text.RegularExpressions.RegexOptions.Compiled);

        /// <summary>Candidate fixes for a fault, drawn from that OEM's live procedure library.</summary>
        public static IReadOnlyList<FixCandidate> Match(string faultKey, OEMManufacturer oem, int max = 6)
            => Match(faultKey, OemProcedureLibrary.For(oem), max);

        /// <summary>Testable overload — matches against an explicit procedure list.</summary>
        public static IReadOnlyList<FixCandidate> Match(string faultKey, IReadOnlyList<ProcRecord> procedures, int max = 6)
        {
            var result = new List<FixCandidate>();
            if (string.IsNullOrEmpty(faultKey) || procedures == null) return result;

            var aff = FaultProcedureOntology.For(faultKey);
            if (aff == null) return result;   // no vetted mapping for this fault yet — surface nothing

            foreach (var p in procedures)
            {
                if (p == null || string.IsNullOrEmpty(p.Name)) continue;
                string upper = p.Name.ToUpperInvariant();
                if (IsSafetyProcedure(p.Name)) continue;   // hard safety gate, before scoring (raw name — needs original case for camelCase split)

                bool nameHit = aff.NameKeywords != null && aff.NameKeywords.Any(k => upper.Contains(k));
                bool archHit = aff.ArchetypeHints != null && aff.ArchetypeHints.Length > 0
                               && !string.IsNullOrEmpty(p.Archetype)
                               && aff.ArchetypeHints.Any(h => p.Archetype.ToUpperInvariant().Contains(h));
                if (!nameHit && !archHit) continue;

                double score = (nameHit ? aff.Weight : 0.0) + (archHit ? 0.15 : 0.0) + (p.IsExecutable ? 0.1 : 0.0);
                result.Add(new FixCandidate
                {
                    FaultKey = faultKey,
                    Procedure = p,
                    ProcedureName = p.Name,
                    CapabilityTag = p.CapabilityTag,
                    Archetype = p.Archetype,
                    IsExecutable = p.IsExecutable,
                    Affinity = Math.Min(1.0, score),
                    Rationale = aff.Rationale,
                });
            }

            return result.OrderByDescending(c => c.Affinity)
                         .ThenByDescending(c => c.IsExecutable)
                         .ThenBy(c => c.ProcedureName, StringComparer.Ordinal)
                         .Take(max)
                         .ToList();
        }

        /// <summary>True if a procedure name touches a restraint/airbag system — the hard safety gate.
        /// Pass the RAW name (any case): the descriptive-word check is case-insensitive, and the
        /// module-acronym check needs the original casing to split glued names like "RCMSelfTest".</summary>
        public static bool IsSafetyProcedure(string name)
        {
            if (string.IsNullOrEmpty(name)) return false;
            string upper = name.ToUpperInvariant();
            // (1) descriptive restraint words anywhere in the name (substring — over-block is SAFE)
            if (SAFETY_SUBSTRINGS.Any(k => upper.Contains(k))) return true;
            // (2) restraint-module acronyms as whole tokens. Tokenised on ANY non-letter/digit run
            //     (space/hyphen/en-dash/NBSP/…) AND camelCase boundaries, so glued ("RCMSelfTest")
            //     and non-ASCII-separated ("RCM–Reset") module names are caught, not just delimited ones.
            foreach (var tok in SafetyTokenize(name))
                if (SAFETY_MODULE_TOKENS.Contains(tok)) return true;
            return false;
        }

        private static IEnumerable<string> SafetyTokenize(string name)
        {
            foreach (var raw in System.Text.RegularExpressions.Regex.Split(name, @"[^\p{L}\p{N}]+"))
            {
                if (raw.Length == 0) continue;
                foreach (var t in CamelBoundary.Split(raw))
                    if (t.Length > 0) yield return t.ToUpperInvariant();
            }
        }
    }
}
