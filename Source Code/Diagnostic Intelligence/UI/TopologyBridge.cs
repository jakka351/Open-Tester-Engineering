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
//  Tester Present Specialist Automotive Solutions — Topology Bridge (CAN Topographer → Diagnostic Intelligence)
//
//  The CAN Topographer (the Network Topology tab) already GENERATES a real per-VIN
//  CAN map when a technician runs a scan: every discovered module carries its real
//  bus membership (which channel answered — HS / MS / K-Line), a real gateway flag
//  (IsBridge, from dual-bus presence), and its decoded DTCs.  That is exactly the
//  topology M3 needs and vastly better than the old hardcoded 8-module HS-CAN stub.
//
//  This bridge converts the Topographer's TopoNode list into the Diagnostic
//  Intelligence snapshot's ModuleNode + DiagnosticDtc records, re-decoding each DTC
//  through the GENERAL multi-OEM database (OEMDTCDatabase.GetDescription) so a
//  non-Ford code gets real text instead of the Topographer's Ford-only "Unknown
//  DTC".  It also stamps per-bus physical-layer expectations (a dual-terminated CAN
//  pair reads ~60 Ω) so M3 can reason about terminators, not just narrate them.
//
//  Host-side only (it reads a UI Controls type) — modules stay pure.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using TesterPresent.OBD2.Controls;
using TesterPresent.OBD2.Data;

namespace TesterPresent.OBD2.Intelligence.UI
{
    /// <summary>Converts CAN-Topographer scan results into Diagnostic Intelligence
    /// snapshot records (modules, DTCs, per-bus health).</summary>
    public static class TopologyBridge
    {
        /// <summary>
        /// Populate <paramref name="snap"/>'s Modules, Dtcs and per-bus health from the
        /// Topographer's discovered-ECU list.  DTC descriptions are resolved through the
        /// general OEM database using the snapshot's already-set <see cref="DiagnosticSnapshot.Oem"/>.
        /// Returns the number of modules applied.  Never throws.
        /// </summary>
        public static int Apply(DiagnosticSnapshot snap, IEnumerable<NetworkTopologyPanel.TopoNode> nodes)
        {
            if (snap == null || nodes == null) return 0;

            int applied = 0;
            var busesSeen = new HashSet<VehicleBus>();
            bool anyHs = false;
            VehicleBus firstBus = VehicleBus.Unknown;

            foreach (var n in nodes)
            {
                if (n == null) continue;
                VehicleBus bus = MapBus(n.Network);
                if (firstBus == VehicleBus.Unknown) firstBus = bus;
                if (bus == VehicleBus.HsCan) anyHs = true;
                busesSeen.Add(bus);

                var module = new ModuleNode
                {
                    TxId = n.TxId,
                    RxId = n.RxId,
                    Name = string.IsNullOrWhiteSpace(n.Name) ? $"ECU 0x{n.TxId:X3}" : n.Name,
                    Bus = bus,
                    Present = true,
                    IsGateway = n.IsBridge,
                    DtcCount = n.DTCCount < 0 ? 0 : n.DTCCount,
                };
                snap.AddModule(module);
                applied++;

                ApplyDtcs(snap, n);
            }

            // Active bus for M3 sanity: prefer HS-CAN if any module answered there.
            snap.ActiveBus = anyHs ? VehicleBus.HsCan
                           : (firstBus != VehicleBus.Unknown ? firstBus : snap.ActiveBus);

            // Per-bus terminator expectation (a real, universal fact for HS/MS-CAN; K-Line
            // is single-wire with no terminator pair).  A measured verdict, if the host runs
            // a bus-health check, is merged in later via snap.AddBusHealth.
            foreach (var bus in busesSeen)
            {
                if (bus == VehicleBus.Unknown) continue;
                snap.AddBusHealth(new BusHealth
                {
                    Bus = bus,
                    ExpectedTerminators = (bus == VehicleBus.KLine) ? 0 : 2,
                });
            }

            return applied;
        }

        /// <summary>Copy a TopoNode's parallel DTC lists into the snapshot, re-decoding each
        /// code through the general OEM database.</summary>
        private static void ApplyDtcs(DiagnosticSnapshot snap, NetworkTopologyPanel.TopoNode n)
        {
            var codes = n.DTCDisplayCodes;
            if (codes == null || codes.Count == 0) return;

            for (int i = 0; i < codes.Count; i++)
            {
                string code = codes[i];
                if (string.IsNullOrWhiteSpace(code)) continue;

                byte status = (n.DTCStatusBytes != null && i < n.DTCStatusBytes.Count) ? n.DTCStatusBytes[i] : (byte)0;
                string desc = DescribeDtc(code, snap.Oem,
                    (n.DTCNames != null && i < n.DTCNames.Count) ? n.DTCNames[i] : null);

                snap.AddDtc(new DiagnosticDtc
                {
                    Code = code,
                    StatusByte = status,
                    Description = desc,
                    ModuleTxId = n.TxId,
                    ModuleName = n.Name,
                });
            }
        }

        /// <summary>Resolve a human DTC description: the reconciled decode first (existing OEM database +
        /// J2012; the OEM/CarmanScan dataset fills gaps via OemDataFacade), then the Topographer's own name,
        /// then the code.</summary>
        public static string DescribeDtc(string code, OEMManufacturer oem, string topographerName = null)
        {
            if (string.IsNullOrWhiteSpace(code)) return code;
            try
            {
                string d = OemDataFacade.DtcText(code, oem);   // existing decode first; OEM dataset fills gaps
                if (!string.IsNullOrWhiteSpace(d)
                    && d.IndexOf("unknown", StringComparison.OrdinalIgnoreCase) < 0
                    && !string.Equals(d.Trim(), code.Trim(), StringComparison.OrdinalIgnoreCase))
                    return d;
            }
            catch { }
            if (!string.IsNullOrWhiteSpace(topographerName)
                && topographerName.IndexOf("unknown", StringComparison.OrdinalIgnoreCase) < 0)
                return topographerName;
            return code;
        }

        /// <summary>Map the Topographer's CanBus enum to the Intelligence VehicleBus enum.</summary>
        private static VehicleBus MapBus(NetworkTopologyPanel.CanBus bus)
        {
            switch (bus)
            {
                case NetworkTopologyPanel.CanBus.HighSpeed: return VehicleBus.HsCan;
                case NetworkTopologyPanel.CanBus.MidSpeed:  return VehicleBus.MsCan;
                case NetworkTopologyPanel.CanBus.KLine:     return VehicleBus.KLine;
                default:                                    return VehicleBus.HsCan;
            }
        }
    }
}
