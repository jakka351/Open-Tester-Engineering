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
//  Tester Present Specialist Automotive Solutions — Diagnostic Intelligence Layer
//
//  Core contracts shared by every Tier-1 (signal-inversion) and Tier-2
//  (model-based / prognostic) diagnostic module.  These are the load-bearing
//  types: enums, the [RequiresValidation] marker, and the tier taxonomy.
//
//  Design rule (from the implementation brief): every module emits an evidence
//  chain + a confidence + a recommended next discriminating test — never a bare
//  verdict.  No module is production-validated until characterised against a
//  real fault on a real vehicle; calibration constants are separated from
//  framework logic and marked [RequiresValidation].
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;

namespace TesterPresent.OBD2.Intelligence
{
    /// <summary>Which tier a diagnostic module belongs to.</summary>
    public enum DiagnosticTier
    {
        /// <summary>Signal-inversion: invert captured vehicle data into fault hypotheses.</summary>
        Tier1,
        /// <summary>Model-based / prognostic: run a physical model alongside the real vehicle.</summary>
        Tier2,
    }

    /// <summary>Verdict of a single step in an evidence chain.</summary>
    public enum EvidenceVerdict
    {
        /// <summary>The observation is within the expected range — consistent with a healthy system.</summary>
        Pass,
        /// <summary>The observation is out of range — consistent with the fault under test.</summary>
        Fail,
        /// <summary>Not enough signal, or the reading is ambiguous — cannot decide.</summary>
        Inconclusive,
        /// <summary>Neutral context — a measured value recorded for the record, not a pass/fail gate.</summary>
        Info,
    }

    /// <summary>Severity of a diagnostic finding, ordered low → high.</summary>
    public enum DiagnosticSeverity
    {
        Info,
        Low,
        Medium,
        High,
        Critical,
    }

    /// <summary>
    /// How the engine measures intake air — decisive for the analytical-redundancy
    /// and prognostic modules.  A speed-density engine has NO mass-airflow sensor,
    /// so "measured MAF vs speed-density prediction" is meaningless and must be
    /// suppressed; a MAF-only engine has no separate MAP; a TMAP is a combined
    /// temperature+MAP sensor (still no MAF).  Getting this wrong hands the
    /// technician a garbage MAF verdict on a car that has no MAF.
    /// </summary>
    public enum AirMeteringKind
    {
        /// <summary>Infer from which PIDs actually returned data (default).</summary>
        AutoDetect,
        /// <summary>Mass-airflow sensor only (no MAP).</summary>
        MafOnly,
        /// <summary>Speed-density: manifold-absolute-pressure sensor only, no MAF.</summary>
        SpeedDensityMap,
        /// <summary>Both a MAF and a MAP sensor — full analytical redundancy available.</summary>
        MafAndMap,
        /// <summary>Combined temperature + MAP (TMAP) sensor, speed-density, no MAF.</summary>
        Tmap,
    }

    /// <summary>Which physical vehicle bus a module / node is on.  Matters for
    /// M3 bus-fault localization and for confirming an ID actually lives on the
    /// channel being probed (per CLAUDE.md: probing an MS-CAN ID from the
    /// HS-CAN channel escalates the controller to BUS-OFF).</summary>
    public enum VehicleBus
    {
        Unknown,
        HsCan,   // 500 kbps, pins 6/14
        MsCan,   // 125 kbps, pins 3/11
        SwCan,   // single-wire CAN
        Lin,
        FlexRay,
        KLine,   // ISO 9141 / ISO 14230
        DoIP,    // diagnostics over IP
    }

    /// <summary>
    /// Marks a value (a calibration constant, a threshold, a model parameter) as
    /// NOT yet validated against a real fault on a real vehicle.  A module that
    /// consumes any [RequiresValidation] value SHALL flag its result as advisory.
    ///
    /// This is the honesty contract of the whole layer: seeded constants come
    /// from published engine specifications, not from assumptions, and they stay
    /// marked until a technician confirms them against a characterised fault.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Class,
                    AllowMultiple = false, Inherited = true)]
    public sealed class RequiresValidationAttribute : Attribute
    {
        public string Note { get; }
        public RequiresValidationAttribute() { Note = null; }
        public RequiresValidationAttribute(string note) { Note = note; }
    }
}
