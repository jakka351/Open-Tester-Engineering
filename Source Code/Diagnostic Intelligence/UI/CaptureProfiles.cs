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
//  Tester Present Specialist Automotive Solutions — Diagnostic Intelligence Capture Profiles
//
//  Different modules want different capture conditions: M2 (crank velocity) needs
//  a crank event, M1 (fuel-trim surface) needs a drive with varied RPM/load, T5
//  (electrical) needs key-on→crank→run, M3 (bus fault) needs a module scan + DTCs.
//  Running everything over one idle sample produces a handful of findings and a
//  pile of honest "insufficient data" skips — correct, but poor UX.
//
//  A CaptureProfile tells the mechanic WHAT to do, captures the RIGHT signals for
//  the RIGHT duration, and orients the run toward the modules that consume them.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections.Generic;

namespace TesterPresent.OBD2.Intelligence.UI
{
    /// <summary>How a profile captures its data.</summary>
    public enum CaptureKind
    {
        /// <summary>Poll a curated PID set over a fixed window (idle, drive, full).</summary>
        LiveWindow,
        /// <summary>Capture across a key-off → crank → start transition (compression, battery).</summary>
        CrankStart,
        /// <summary>No live PIDs — ping modules and read stored DTCs (bus-fault localization).</summary>
        NetworkScan,
    }

    /// <summary>A declarative capture recipe: instructions + which signals + how long.</summary>
    public sealed class CaptureProfile
    {
        public string Id { get; set; }
        public string Name { get; set; }
        /// <summary>Plain-language instructions shown to the mechanic before capture.</summary>
        public string Instructions { get; set; }
        public CaptureKind Kind { get; set; }
        public int DurationSeconds { get; set; }
        /// <summary>Mode-01 PIDs to poll (empty for NetworkScan).</summary>
        public byte[] Pids { get; set; }
        /// <summary>Module IDs this profile is oriented toward (for display only).</summary>
        public string[] OrientedModules { get; set; }

        public override string ToString() => Name;
    }

    /// <summary>The built-in capture profiles, ordered from quickest/safest to most involved.</summary>
    public static class CaptureProfileCatalog
    {
        // Signal groups reused across profiles.
        private static readonly byte[] FuelAir = { 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F, 0x10, 0x11, 0x33, 0x42 };
        private static readonly byte[] CrankSet = { 0x0C, 0x42, 0x05, 0x04 };            // RPM, Vbatt, ECT, Load
        private static readonly byte[] FullSet  = { 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F, 0x10, 0x11, 0x1F, 0x33, 0x42, 0x43, 0x5C };

        private static readonly List<CaptureProfile> _all = new List<CaptureProfile>
        {
            new CaptureProfile
            {
                Id = "network-scan",
                Name = "Network & DTC Scan",
                Kind = CaptureKind.NetworkScan,
                DurationSeconds = 0,
                Pids = new byte[0],
                OrientedModules = new[] { "M3", "M6" },
                Instructions =
                    "Key ON, engine OFF (or running — either is fine). No driving needed.\n\n" +
                    "This pings the common modules on the bus, records which answer, and reads their stored " +
                    "DTCs. It then localizes lost-communication (U-code) clusters to a shared bus segment " +
                    "instead of blaming each silent module — so you check wiring/terminators/gateway, not parts.",
            },
            new CaptureProfile
            {
                Id = "idle-health",
                Name = "Idle Health",
                Kind = CaptureKind.LiveWindow,
                DurationSeconds = 12,
                Pids = FuelAir,
                OrientedModules = new[] { "M1", "M2", "T1", "T2", "M5" },
                Instructions =
                    "Warm engine, idling in PARK or NEUTRAL. Leave it steady — don't touch the throttle.\n\n" +
                    "Captures fuel trims, idle stability, MAF/MAP/RPM and the air-metering cross-checks. " +
                    "Good for vacuum leaks, idle roughness, sensor plausibility, and intermittent glitches.",
            },
            new CaptureProfile
            {
                Id = "drive-sample",
                Name = "Drive Sample",
                Kind = CaptureKind.LiveWindow,
                DurationSeconds = 60,
                Pids = FuelAir,
                OrientedModules = new[] { "M1", "M4", "T2", "T3" },
                Instructions =
                    "SAFELY drive through a range of conditions — accelerate, cruise, and coast — for about a " +
                    "minute. Have a second person operate the tool if possible.\n\n" +
                    "Builds the RPM×Load fuel-trim SURFACE (idle-lean vs load-lean tell vacuum leak from fuel " +
                    "delivery), compares against the fleet baseline, and estimates volumetric efficiency for " +
                    "prognostics. The more varied the drive, the better the surface.",
            },
            new CaptureProfile
            {
                Id = "crank-start",
                Name = "Crank & Start",
                Kind = CaptureKind.CrankStart,
                DurationSeconds = 15,
                Pids = CrankSet,
                OrientedModules = new[] { "M2", "T5" },
                Instructions =
                    "Engine OFF. Press Capture, THEN crank and start the engine.\n\n" +
                    "Reads the crank-speed ripple (uneven ripple = a weak cylinder) and the battery voltage " +
                    "under starter load (a sag below ~9.6 V = weak battery/starter/cables). Gross screen only " +
                    "at OBD sample rates — confirm a weak cylinder with a compression/leak-down test.",
            },
            new CaptureProfile
            {
                Id = "full",
                Name = "Full Assessment",
                Kind = CaptureKind.LiveWindow,
                DurationSeconds = 45,
                Pids = FullSet,
                OrientedModules = new[] { "M1", "M2", "M4", "M5", "M6", "T1", "T2", "T3", "T5" },
                Instructions =
                    "Warm engine. Idle for a few seconds, then (safely) vary load if you can. ~45 seconds.\n\n" +
                    "Runs the widest set of live-data modules over one window and lets the Bayesian engine " +
                    "compose them into a ranked hypothesis with the single most discriminating next test.",
            },
        };

        public static IReadOnlyList<CaptureProfile> All => _all;

        public static CaptureProfile ById(string id)
        {
            foreach (var p in _all) if (p.Id == id) return p;
            return null;
        }

        /// <summary>The default profile to select on open.</summary>
        public static CaptureProfile Default => _all[1]; // Idle Health
    }
}
