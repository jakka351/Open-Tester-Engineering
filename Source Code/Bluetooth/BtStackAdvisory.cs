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
//  Tester Present Specialist Automotive Solutions — Bluetooth stack advisory (reference + reachability heuristic)
//  BtStackAdvisory.cs — assessment workflow step 5 (stack-level exposure, non-destructive side).
//
//  "Bluetooth stacks have historically carried remotely reachable memory-corruption flaws — the
//   BlueBorne class (2017) being the canonical example ... it establishes the category: the stack
//   itself, reachable from the host radio, is a legitimate boundary to probe on in-scope hardware."
//
//  This is a REFERENCE catalogue of notable Bluetooth stack vulnerability classes plus a
//  conservative reachability heuristic keyed on the endpoint's advertised stack hints (name, OUI,
//  device class). It NEVER exploits anything and NEVER claims a unit is compromised — it advises
//  which classes are worth checking against the unit's firmware, so the operator knows where to
//  look. The fuzzer (BtFuzzer) is the active complement; this is the informed checklist.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace TesterPresent.OBD2.Bluetooth
{
    public sealed class StackVulnClass
    {
        public string Name = "";
        public int Year;
        public string Category = "";        // RCE / Info-leak / MITM / DoS
        public string Transport = "";       // Classic / LE / Both
        public bool PreAuth;                // reachable without pairing
        public string AffectedStacks = "";
        public string Note = "";
    }

    public static class BtStackAdvisory
    {
        /// <summary>Notable, well-documented Bluetooth stack vulnerability classes (public CVE families).</summary>
        public static readonly IReadOnlyList<StackVulnClass> Classes = new List<StackVulnClass>
        {
            new StackVulnClass { Name = "BlueBorne", Year = 2017, Category = "RCE / Info-leak", Transport = "Classic+LE", PreAuth = true,
                AffectedStacks = "Linux BlueZ, Android (Fluoride), Windows, iOS",
                Note = "CVE-2017-1000251 (BlueZ L2CAP), CVE-2017-0781/0782 (Android BNEP/PAN), CVE-2017-8628 (Windows). OS-level RCE reachable over the radio with no pairing. Canonical example of the class; most fielded units are patched, but embedded/older head units lag." },
            new StackVulnClass { Name = "KNOB", Year = 2019, Category = "MITM / key downgrade", Transport = "Classic", PreAuth = false,
                AffectedStacks = "BR/EDR controllers broadly",
                Note = "CVE-2019-9506. Negotiates BR/EDR encryption key entropy down to 1 byte, enabling brute-force of the link key. Relevant to how strong an existing bond actually is." },
            new StackVulnClass { Name = "BLURtooth", Year = 2020, Category = "MITM (CTKD)", Transport = "Both", PreAuth = false,
                AffectedStacks = "Dual-mode devices with cross-transport key derivation",
                Note = "CVE-2020-15802. Cross-Transport Key Derivation lets an attacker overwrite/weaken keys across BR/EDR and LE. Head units are dual-mode by definition — in scope." },
            new StackVulnClass { Name = "BLESA", Year = 2020, Category = "Spoofing (reconnection)", Transport = "LE", PreAuth = false,
                AffectedStacks = "Many LE peripheral stacks",
                Note = "Reconnection spoofing — the LE central does not force re-authentication on reconnect. Relevant to companion/telematics LE services." },
            new StackVulnClass { Name = "SweynTooth", Year = 2020, Category = "DoS / deadlock / RCE", Transport = "LE", PreAuth = true,
                AffectedStacks = "Cypress, NXP, Dialog, TI, Telink, ST SoCs",
                Note = "12+ CVEs in LE SoC link layers — crash, deadlock or bypass reachable pre-auth. Aftermarket BLE sensors/dongles frequently use these SoCs." },
            new StackVulnClass { Name = "BrakTooth", Year = 2021, Category = "DoS / crash / RCE", Transport = "Classic", PreAuth = true,
                AffectedStacks = "ESP32, Intel, Qualcomm, Cypress, Bluetrum BR/EDR",
                Note = "16+ CVEs in BR/EDR baseband firmware — crashes and firmware faults from malformed LMP/L2CAP. ESP32-based aftermarket kit is directly in scope." },
        };

        /// <summary>
        /// Advisory findings for an endpoint: which classes are worth checking given what the unit
        /// advertises. Conservative — every finding is Info/Low and explicitly says "check", never
        /// "vulnerable". Provenance points at the endpoint.
        /// </summary>
        public static List<BtFinding> AdviseForEndpoint(BtEndpoint ep)
        {
            var findings = new List<BtFinding>();
            if (ep == null) return findings;

            bool dual = ep.Transport == BtTransport.DualMode;
            bool le = ep.Transport == BtTransport.LowEnergy || dual;
            bool classic = ep.Transport == BtTransport.Classic || dual;
            string name = (ep.Name ?? "").ToLowerInvariant();
            string vendor = (ep.Vendor ?? "").ToLowerInvariant();
            bool espHint = name.Contains("esp") || vendor.Contains("espressif");

            foreach (var vc in Classes)
            {
                bool relevant = false;
                string why = "";
                if (vc.Name == "BlueBorne" && classic) { relevant = true; why = "Classic + reachable pre-auth; verify the unit's OS/stack patch level (2017+)."; }
                else if (vc.Name == "KNOB" && classic && ep.IsPaired) { relevant = true; why = "Bonded Classic link — verify negotiated key entropy is not downgraded."; }
                else if (vc.Name == "BLURtooth" && dual) { relevant = true; why = "Dual-mode unit — cross-transport key derivation applies."; }
                else if (vc.Name == "BLESA" && le) { relevant = true; why = "Exposes LE services — check reconnection re-authentication."; }
                else if (vc.Name == "SweynTooth" && le) { relevant = true; why = "LE endpoint — if built on an affected SoC, pre-auth link-layer faults apply."; }
                else if (vc.Name == "BrakTooth" && classic) { relevant = true; why = espHint ? "ESP32/Bluetrum hint in name/OUI — directly in the BrakTooth affected set." : "BR/EDR baseband — check firmware against BrakTooth."; }

                if (!relevant) continue;
                findings.Add(new BtFinding
                {
                    Severity = espHint && vc.Name == "BrakTooth" ? BtSeverity.Low : BtSeverity.Info,
                    Category = "Stack",
                    Title = "Check " + vc.Name + " (" + vc.Year + ", " + vc.Category + ")",
                    Detail = why + "  Affected: " + vc.AffectedStacks + ". " + vc.Note,
                    EndpointMac = ep.MacColons,
                    EndpointName = ep.Name,
                    Profile = "stack/" + vc.Transport,
                });
            }
            return findings;
        }
    }
}
