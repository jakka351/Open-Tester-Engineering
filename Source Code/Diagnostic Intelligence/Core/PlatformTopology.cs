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
//  Tester Present Specialist Automotive Solutions — Platform Topology (ECU graph view)
//
//  A structural, graph-style view of the vehicle's discovered ECU nodes grouped
//  by physical bus.  Built from a DiagnosticSnapshot's ModuleNode list, it answers
//  the shape questions the network-fault modules need: which nodes share a bus,
//  which buses are present, and whether a bus carries a gateway.  The actual
//  U-code / shared-bus localization reasoning lives in M3 — this class is pure
//  structure + grouping, nothing more.  Consumers: M3, M4, T7.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace TesterPresent.OBD2.Intelligence
{
    /// <summary>
    /// A graph view of the vehicle's ECU nodes grouped by <see cref="VehicleBus"/>.
    /// Nodes are stored in discovery (insertion) order; lookup by transmit ID is
    /// O(1) via an internal index.  The class holds structure only — the fault
    /// reasoning that walks it belongs in the diagnostic modules.
    /// </summary>
    public sealed class PlatformTopology
    {
        private readonly List<ModuleNode> _nodes = new List<ModuleNode>();
        private readonly Dictionary<uint, ModuleNode> _byTx = new Dictionary<uint, ModuleNode>();

        /// <summary>Creates an empty topology.</summary>
        public PlatformTopology() { }

        /// <summary>
        /// Adds a node to the graph.  Null nodes and nodes whose <see cref="ModuleNode.TxId"/>
        /// duplicates one already present are ignored (first-seen wins).
        /// </summary>
        /// <param name="node">The discovered ECU node to add.</param>
        public void AddNode(ModuleNode node)
        {
            if (node == null) return;
            if (_byTx.ContainsKey(node.TxId)) return;
            _nodes.Add(node);
            _byTx[node.TxId] = node;
        }

        /// <summary>All nodes, in discovery (insertion) order.</summary>
        public IReadOnlyList<ModuleNode> Nodes => _nodes;

        /// <summary>Total number of nodes in the topology.</summary>
        public int ModuleCount => _nodes.Count;

        /// <summary>Looks up a node by its transmit ID; returns null if absent.</summary>
        /// <param name="txId">The module's diagnostic request (Tx) CAN ID.</param>
        public ModuleNode NodeByTx(uint txId)
        {
            ModuleNode node;
            return _byTx.TryGetValue(txId, out node) ? node : null;
        }

        /// <summary>All nodes on the given bus, in discovery order.</summary>
        /// <param name="bus">The physical bus to filter on.</param>
        public IReadOnlyList<ModuleNode> OnBus(VehicleBus bus)
        {
            var result = new List<ModuleNode>();
            foreach (var n in _nodes)
                if (n.Bus == bus) result.Add(n);
            return result;
        }

        /// <summary>
        /// The distinct set of buses present among the nodes.  If any node sits on
        /// a known (non-Unknown) bus, <see cref="VehicleBus.Unknown"/> is excluded
        /// so callers reason over real buses; if every node is Unknown, the single
        /// Unknown entry is returned.
        /// </summary>
        public IReadOnlyList<VehicleBus> Buses
        {
            get
            {
                var distinct = new List<VehicleBus>();
                var seen = new HashSet<VehicleBus>();
                bool hasKnown = false;
                foreach (var n in _nodes)
                {
                    if (seen.Add(n.Bus)) distinct.Add(n.Bus);
                    if (n.Bus != VehicleBus.Unknown) hasKnown = true;
                }
                if (hasKnown && seen.Contains(VehicleBus.Unknown))
                    distinct.Remove(VehicleBus.Unknown);
                return distinct;
            }
        }

        /// <summary>True if any node with <see cref="ModuleNode.IsGateway"/> set sits on the given bus.</summary>
        /// <param name="bus">The bus to check for a gateway.</param>
        public bool AnyGatewayOn(VehicleBus bus)
        {
            foreach (var n in _nodes)
                if (n.IsGateway && n.Bus == bus) return true;
            return false;
        }

        /// <summary>
        /// Builds a topology from a snapshot's discovered module list.  Null-safe:
        /// a null snapshot (or null module list) yields an empty topology.  Adds
        /// modules via <see cref="AddNode"/>, so duplicate Tx IDs are collapsed.
        /// </summary>
        /// <param name="snap">The diagnostic snapshot to read modules from.</param>
        public static PlatformTopology FromSnapshot(DiagnosticSnapshot snap)
        {
            var topo = new PlatformTopology();
            if (snap == null || snap.Modules == null) return topo;
            foreach (var m in snap.Modules)
                topo.AddNode(m);
            return topo;
        }
    }
}
