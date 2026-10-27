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
//  Tester Present Specialist Automotive Solutions — assessment findings store & report
//  BtAssessment.cs — assessment workflow step 6 (document & handle).
//
//  "Record findings and provenance; treat any recovered personal data as sensitive per the
//   engagement's handling rules." This is the findings ledger: every SDP/GATT/pairing/fuzzing
//   observation and every PBAP/MAP data pull lands here with provenance (endpoint, profile,
//   time) and a Sensitive flag for third-party PII. Exports a Markdown report the operator can
//   sign per the outbound-document SOP before it leaves the shop.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TesterPresent.OBD2.Bluetooth
{
    public sealed class BtAssessment
    {
        private readonly List<BtFinding> _findings = new List<BtFinding>();
        private readonly object _lock = new object();

        public string OperatorName = "";
        public string EngagementRef = "";       // work order / authorisation reference
        public string VehicleDescription = "";
        public DateTime StartedUtc = DateTime.UtcNow;

        public event Action<BtFinding> FindingAdded;

        public void Add(BtFinding f)
        {
            if (f == null) return;
            lock (_lock) _findings.Add(f);
            try { FindingAdded?.Invoke(f); } catch { }
        }

        public BtFinding Add(BtSeverity sev, string category, string title, string detail, BtEndpoint ep = null, string profile = "", bool sensitive = false, string evidenceHex = "")
        {
            var f = new BtFinding
            {
                Severity = sev, Category = category, Title = title, Detail = detail,
                EndpointMac = ep != null ? ep.MacColons : "", EndpointName = ep != null ? ep.Name : "",
                Profile = profile, IsSensitiveData = sensitive, EvidenceHex = evidenceHex,
            };
            Add(f);
            return f;
        }

        public IReadOnlyList<BtFinding> Findings { get { lock (_lock) return _findings.ToList(); } }
        public int Count { get { lock (_lock) return _findings.Count; } }
        public bool HasSensitive { get { lock (_lock) return _findings.Any(f => f.IsSensitiveData); } }

        public void Clear() { lock (_lock) _findings.Clear(); }

        // ── Report ───────────────────────────────────────────────────────────────────────
        public string BuildMarkdown(IEnumerable<BtEndpoint> endpoints)
        {
            var sb = new StringBuilder();
            sb.AppendLine("# Vehicle Bluetooth Assessment Report");
            sb.AppendLine();
            sb.AppendLine("Prepared by Tester Present — Specialist Automotive Solutions.");
            sb.AppendLine();
            sb.AppendLine("| Field | Value |");
            sb.AppendLine("|---|---|");
            sb.AppendLine("| Operator | " + Esc(OperatorName) + " |");
            sb.AppendLine("| Authorisation / work order | " + Esc(EngagementRef) + " |");
            sb.AppendLine("| Vehicle | " + Esc(VehicleDescription) + " |");
            sb.AppendLine("| Started (UTC) | " + StartedUtc.ToString("yyyy-MM-dd HH:mm:ss") + " |");
            sb.AppendLine("| Generated (UTC) | " + DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss") + " |");
            sb.AppendLine("| Scope | Bluetooth (BR/EDR) + LE, reached from the host radio as a peer/scanner. |");
            sb.AppendLine();
            sb.AppendLine("> **Authorisation.** This report documents authorised diagnostic/security work on a vehicle the operator owns or has explicit written permission to test. Interrogating a vehicle's Bluetooth systems without authorisation may breach computer-misuse, interception and privacy law.");
            sb.AppendLine();

            // Endpoint inventory
            sb.AppendLine("## 1. Endpoints discovered");
            sb.AppendLine();
            sb.AppendLine("| Name | MAC | Transport | Paired | RSSI | Class | Vendor |");
            sb.AppendLine("|---|---|---|---|---|---|---|");
            if (endpoints != null)
                foreach (var e in endpoints.OrderByDescending(e => e.Rssi))
                    sb.AppendLine("| " + Esc(e.Name) + " | " + e.MacColons + " | " + e.Transport + " | " + (e.IsPaired ? "yes" : "no") +
                                  " | " + (e.Rssi != 0 ? e.Rssi + " dBm" : "-") + " | " + Esc(e.DeviceClassText) + " | " + Esc(e.Vendor) + " |");
            sb.AppendLine();

            // Findings by severity
            var findings = Findings;
            sb.AppendLine("## 2. Findings (" + findings.Count + ")");
            sb.AppendLine();
            foreach (var sev in new[] { BtSeverity.Critical, BtSeverity.High, BtSeverity.Medium, BtSeverity.Low, BtSeverity.Info })
            {
                var group = findings.Where(f => f.Severity == sev).ToList();
                if (group.Count == 0) continue;
                sb.AppendLine("### " + sev.ToString().ToUpperInvariant() + " (" + group.Count + ")");
                sb.AppendLine();
                foreach (var f in group)
                {
                    sb.AppendLine("- **" + Esc(f.Title) + "**" + (f.IsSensitiveData ? "  _[SENSITIVE PII]_" : ""));
                    if (!string.IsNullOrEmpty(f.EndpointName) || !string.IsNullOrEmpty(f.EndpointMac))
                        sb.AppendLine("  - Endpoint: " + Esc(f.EndpointName) + " (" + f.EndpointMac + ")" + (string.IsNullOrEmpty(f.Profile) ? "" : ", profile " + Esc(f.Profile)));
                    if (!string.IsNullOrEmpty(f.Detail)) sb.AppendLine("  - " + Esc(f.Detail));
                    if (!string.IsNullOrEmpty(f.EvidenceHex)) sb.AppendLine("  - Evidence: `" + f.EvidenceHex + "`");
                    sb.AppendLine("  - Recorded (UTC): " + f.TimestampUtc.ToString("yyyy-MM-dd HH:mm:ss"));
                }
                sb.AppendLine();
            }

            // Sensitive-data handling
            if (HasSensitive)
            {
                sb.AppendLine("## 3. Sensitive-data handling");
                sb.AppendLine();
                sb.AppendLine("This assessment pulled third-party personal information (phonebook / call history / messages via PBAP or MAP). Treat it as sensitive evidence:");
                sb.AppendLine();
                sb.AppendLine("- Record provenance (done above — each item is tagged SENSITIVE PII with its source endpoint).");
                sb.AppendLine("- Minimise retention; store only per the engagement's handling rules.");
                sb.AppendLine("- Do not transmit outside the engagement without authorisation.");
                sb.AppendLine();
            }

            sb.AppendLine("---");
            sb.AppendLine();
            sb.AppendLine("_Before sending this report outside TPSAS, sign it per the outbound-document SOP (TesSign / Ed25519) and verify the signature._");
            return sb.ToString();
        }

        // Neutralise table-breaking chars AND Markdown inline metacharacters, because device-supplied
        // strings (advertised name, vendor, class) flow into the report — an advertised name like
        // "[x](javascript:…)" or "**inject**" must render as literal text in the signed document.
        private static string Esc(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";
            var sb = new StringBuilder(s.Length + 8);
            foreach (char c in s)
            {
                if (c == '\r' || c == '\n') { sb.Append(' '); continue; }
                if (c == '\\' || c == '|' || c == '*' || c == '_' || c == '[' || c == ']' ||
                    c == '(' || c == ')' || c == '#' || c == '<' || c == '>' || c == '~' || c == '`')
                    sb.Append('\\');
                sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
