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

// =============================================================================
//  MilcanNodeTable.cs - who is on the bus, and are they healthy.
//
//  MilCAN has NO address-claim protocol (that is J1939-81) and no node directory. A
//  MilCAN bus tells you who is on it in exactly two ways:
//
//    1. The Alive message (primary-type 0x62, sub-type = node id), which every node
//       must transmit at >= 1 Hz with at least a health byte (§3.2.5.5).
//    2. The source address in the identifier of anything else it transmits.
//
//  Both are tracked, and the table distinguishes them: a node seen ONLY as a source
//  address is transmitting but has not announced itself, and a node whose Alive has
//  stopped while its other traffic continues is a different fault from one that has
//  gone silent altogether. Collapsing those into one "present" flag would hide the
//  most useful thing this table knows.
//
//  ADDRESS vs NODE ID: they are not the same field and the spec does not require them
//  to match - §3.2.5.5 lets the designer either allocate a separate node id or reuse
//  the source address "for ease of identification". So both are stored, and a mismatch
//  is reported rather than silently normalised away.
// =============================================================================

using System;
using System.Collections.Generic;
using System.Globalization;

namespace TesterPresent.OBD2.Milcan
{
    /// <summary>One node observed on a MilCAN bus.</summary>
    public sealed class MilcanNode
    {
        /// <summary>Source address seen in the identifier of frames from this node.</summary>
        public byte SourceAddress { get; internal set; }

        /// <summary>Node id from the Alive message sub-type, or null when no Alive has been seen.</summary>
        public byte? NodeId { get; internal set; }

        /// <summary>Total frames observed from this source address.</summary>
        public long FrameCount { get; internal set; }

        /// <summary>Alive messages observed from this node.</summary>
        public long AliveCount { get; internal set; }

        /// <summary>Session-clock time of the most recent frame from this address.</summary>
        public double LastSeenMs { get; internal set; }

        /// <summary>Session-clock time of the most recent Alive, or 0 when none.</summary>
        public double LastAliveMs { get; internal set; }

        /// <summary>Health byte from the most recent Alive (payload byte 0), or null when no Alive has been seen.</summary>
        public byte? Health { get; internal set; }

        /// <summary>True when the node is a Sync Master (or has been observed emitting Sync Frames).</summary>
        public bool EmitsSyncFrames { get; internal set; }

        /// <summary>Distinct message types (primary/sub pairs) this node has transmitted.</summary>
        public int MessageTypeCount { get { return MessageTypes.Count; } }

        /// <summary>The set of message types this node has transmitted.</summary>
        internal HashSet<ushort> MessageTypes = new HashSet<ushort>();

        /// <summary>True once an Alive message has been received from this node.</summary>
        public bool HasAnnounced { get { return AliveCount > 0; } }

        /// <summary>
        /// True when the node's most recent Alive reported healthy. Null when no Alive
        /// has been seen - which is NOT the same as unhealthy and must not be rendered
        /// as such.
        /// </summary>
        public bool? IsHealthy
        {
            get
            {
                if (!Health.HasValue) return null;
                return Health.Value == MilcanRegistry.ALIVE_HEALTHY;
            }
        }

        /// <summary>
        /// True when this node announced itself with an Alive but has since missed the
        /// 1 Hz minimum by a wide margin, while still being seen on the bus.
        /// </summary>
        /// <param name="nowMs">Current session clock reading.</param>
        /// <param name="graceMs">How long past the 1 s minimum to tolerate.</param>
        /// <returns>True when the Alive is overdue.</returns>
        public bool IsAliveOverdue(double nowMs, double graceMs)
        {
            if (AliveCount == 0) return false;
            return (nowMs - LastAliveMs) > (1000.0 + graceMs);
        }
    }

    /// <summary>
    /// Tracks the nodes seen on a MilCAN bus, their Alive health and their traffic.
    /// </summary>
    /// <remarks>Not thread-safe; driven from the session pump and snapshotted under the session lock.</remarks>
    public sealed class MilcanNodeTable
    {
        private readonly Dictionary<byte, MilcanNode> _nodes = new Dictionary<byte, MilcanNode>();

        /// <summary>Number of distinct source addresses seen.</summary>
        public int Count { get { return _nodes.Count; } }

        /// <summary>
        /// Records a frame against its source address.
        /// </summary>
        /// <param name="id">The decoded identifier.</param>
        /// <param name="payload">The frame payload; the Alive health byte is read from it.</param>
        /// <param name="timestampMs">Session-clock arrival time.</param>
        /// <returns>A note when something changed that is worth logging, otherwise null.</returns>
        public string Observe(MilcanId id, byte[] payload, double timestampMs)
        {
            byte address = id.SourceAddress;

            MilcanNode node;
            bool isNew = !_nodes.TryGetValue(address, out node);
            if (isNew)
            {
                node = new MilcanNode { SourceAddress = address };
                _nodes[address] = node;
            }

            node.FrameCount++;
            node.LastSeenMs = timestampMs;
            node.MessageTypes.Add(id.MessageType);

            if (id.IsSyncFrame)
            {
                node.EmitsSyncFrames = true;
            }

            string note = null;

            if (id.IsAlive)
            {
                node.AliveCount++;
                node.LastAliveMs = timestampMs;

                byte? previousHealth = node.Health;
                node.NodeId = id.SubType;

                if (payload != null && payload.Length > 0)
                {
                    node.Health = payload[0];

                    if (previousHealth.HasValue && previousHealth.Value != payload[0])
                    {
                        note = string.Format(CultureInfo.InvariantCulture,
                            "Node 0x{0:X2} health byte changed 0x{1:X2} -> 0x{2:X2}.",
                            address, previousHealth.Value, payload[0]);
                    }
                }

                if (note == null && node.AliveCount == 1)
                {
                    string health = node.Health.HasValue
                        ? (node.Health.Value == MilcanRegistry.ALIVE_HEALTHY
                            ? "healthy"
                            : string.Format(CultureInfo.InvariantCulture, "NOT healthy (0x{0:X2})", node.Health.Value))
                        : "no health byte";

                    // The spec permits node id and source address to differ; say so
                    // rather than quietly presenting one as the other.
                    string idNote = id.SubType == address
                        ? string.Empty
                        : string.Format(CultureInfo.InvariantCulture, " (node id 0x{0:X2} differs from source address)", id.SubType);

                    note = string.Format(CultureInfo.InvariantCulture,
                        "Node 0x{0:X2} announced itself: {1}{2}.", address, health, idNote);
                }
            }
            else if (isNew)
            {
                note = string.Format(CultureInfo.InvariantCulture,
                    "New source address 0x{0:X2} transmitting ({1}) - no Alive message seen from it yet.",
                    address, MilcanRegistry.Describe(id));
            }

            return note;
        }

        /// <summary>Returns the tracked nodes ordered by source address.</summary>
        /// <returns>A snapshot list; the node objects themselves are live and must be read on the owning thread.</returns>
        public List<MilcanNode> Snapshot()
        {
            var list = new List<MilcanNode>(_nodes.Count);
            foreach (KeyValuePair<byte, MilcanNode> kv in _nodes) list.Add(kv.Value);
            list.Sort(delegate (MilcanNode a, MilcanNode b) { return a.SourceAddress.CompareTo(b.SourceAddress); });
            return list;
        }

        /// <summary>Forgets every node.</summary>
        public void Reset()
        {
            _nodes.Clear();
        }
    }
}
