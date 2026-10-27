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
//  MilcanRegistry.cs - MilCAN A constants, timings and the identifier name map.
//
//  Everything here is quoted from MWG-MILA-001 Rev 3 (May 2009). Where the spec says
//  "system specific" the value is a RECOMMENDATION and is named as such - a MilCAN
//  system integrator is free to retune the Sync rate via the System Management layer,
//  so nothing in the live decode path may assume a recommended value is the truth.
//  MilcanSyncTracker MEASURES the PTU rather than reading it from this table; these
//  constants exist to classify what was measured, not to substitute for measuring.
//
//  The primary-type table (Appendix A, Table A-1) is explicitly a SUGGESTED allocation.
//  Names are rendered as "suggested" in the UI for exactly that reason: on a given
//  platform 0x58 may not be Vision Sensor Control, and a tool that states it as fact
//  would be inventing a system it has not seen.
// =============================================================================

using System;
using System.Collections.Generic;
using System.Globalization;

namespace TesterPresent.OBD2.Milcan
{
    /// <summary>Bit rates a MilCAN A node may support (MILA §2.4.1).</summary>
    public enum MilcanBitRate
    {
        /// <summary>250 kbps. The only rate at which MilCAN A and SAE J1939 may share a bus.</summary>
        Rate250k = 250000,

        /// <summary>500 kbps (added by change request CR004).</summary>
        Rate500k = 500000,

        /// <summary>1 Mbps.</summary>
        Rate1M = 1000000
    }

    /// <summary>
    /// The system mode a MilCAN bus is in (MILA §4.2). Meaning of traffic depends on
    /// this: in pre-operational only Sync and config messages are legal, and in
    /// configuration mode operational messaging including Sync is suspended entirely.
    /// </summary>
    public enum MilcanSystemMode
    {
        /// <summary>No Sync Frame has been observed yet - the bus state is not yet known.</summary>
        Unknown = 0,

        /// <summary>Pre-operational: after power/reset/loss of Sync/exit-config. Only Sync + enter/exit-config are legal.</summary>
        PreOperational = 1,

        /// <summary>Operational: entered on a valid Sync Frame; normal message transmission.</summary>
        Operational = 2,

        /// <summary>System configuration mode: all operational messaging including Sync is suspended.</summary>
        SystemConfiguration = 3
    }

    /// <summary>
    /// Real-time class implied by a message's priority field (MILA Table 4-1). The
    /// latency bound is expressed in multiples of the PTU, not milliseconds, because
    /// the PTU is a property of the system's Sync rate.
    /// </summary>
    public enum MilcanRealTimeClass
    {
        /// <summary>Priority 0 - protocol messages (Sync, enter/exit config) or traffic that cannot tolerate 1 PTU.</summary>
        Hrt0 = 0,
        /// <summary>Priority 1 - hard real time, deadline within 1 PTU.</summary>
        Hrt1 = 1,
        /// <summary>Priority 2 - hard real time, deadline within 8 PTU.</summary>
        Hrt2 = 2,
        /// <summary>Priority 3 - hard real time, deadline within 64 PTU.</summary>
        Hrt3 = 3,
        /// <summary>Priority 4 - soft real time, target 8 PTU, not guaranteed.</summary>
        Srt1 = 4,
        /// <summary>Priority 5 - soft real time, target 64 PTU, not guaranteed.</summary>
        Srt2 = 5,
        /// <summary>Priority 6 - soft real time, target 1024 PTU, not guaranteed.</summary>
        Srt3 = 6,
        /// <summary>Priority 7 - non real time, no latency requirement.</summary>
        Nrt = 7
    }

    /// <summary>
    /// MilCAN A protocol constants, recommended timings and identifier naming.
    /// </summary>
    public static class MilcanRegistry
    {
        // ── Sync Frame / scheduling (MILA §3.2.5.3, §4.1.5) ───────────────────────

        /// <summary>Sync slot counter wraps at this value: the counter cycles 0..1023 (§3.2.5.3).</summary>
        public const int SYNC_SLOT_COUNT = 1024;

        /// <summary>Highest valid sync slot number.</summary>
        public const int SYNC_SLOT_MAX = SYNC_SLOT_COUNT - 1;

        /// <summary>Payload length of a Sync Frame message: a 2-byte little-endian slot counter (Table A-2).</summary>
        public const int SYNC_PAYLOAD_LENGTH = 2;

        /// <summary>
        /// Operational mode is abandoned when Sync Frames cease for longer than this
        /// many PTUs (§4.2.2). The single most important liveness rule on the bus.
        /// </summary>
        public const int SYNC_LOSS_PTU_THRESHOLD = 8;

        /// <summary>Sync arbitration timeout as a fraction of the PTU: 0.8 PTU ±12.5% (§4.1.5.6).</summary>
        public const double SYNC_ARBITRATION_TIMEOUT_PTU = 0.8;

        // ── Configuration mode (MILA §4.2.3) ──────────────────────────────────────

        /// <summary>The three ASCII payload bytes of the enter-configuration sequence: 'C', 'F', 'G'.</summary>
        public static readonly byte[] ENTER_CONFIG_SEQUENCE = new byte[] { 0x43, 0x46, 0x47 };

        /// <summary>The three ASCII payload bytes of the exit-configuration message: "OPR".</summary>
        public static readonly byte[] EXIT_CONFIG_PAYLOAD = new byte[] { 0x4F, 0x50, 0x52 };

        /// <summary>The enter-config sequence must be transmitted inside this window (§4.2.3).</summary>
        public const int ENTER_CONFIG_TRANSMIT_WINDOW_MS = 400;

        /// <summary>A receiver abandons a partial enter-config sequence after this long: 500 ms ±5% (§4.2.3).</summary>
        public const int ENTER_CONFIG_SEQUENCE_TIMEOUT_MS = 500;

        /// <summary>In configuration mode the Config Master repeats the enter sequence at this interval (§4.2.3).</summary>
        public const int CONFIG_MODE_REFRESH_MS = 1000;

        /// <summary>Devices leave configuration mode if the enter sequence stops for this long: 8 s ±1 s (§4.2.3).</summary>
        public const int CONFIG_MODE_IDLE_TIMEOUT_MS = 8000;

        // ── Alive (MILA §3.2.5.5) ─────────────────────────────────────────────────

        /// <summary>Minimum Alive transmission rate for every node, in hertz.</summary>
        public const double ALIVE_MINIMUM_HZ = 1.0;

        /// <summary>Reserved Alive identifier (primary 0x62, sub 0x00) that no node may use.</summary>
        public const ushort ALIVE_RESERVED_MESSAGE_TYPE = 0x6200;

        /// <summary>Payload byte 0 of an Alive message is a health indication; this value means healthy.</summary>
        public const byte ALIVE_HEALTHY = 0x00;

        /// <summary>Asynchronous periodic messages must use priority 2 or lower-priority (numerically greater) (§3.2.6.3).</summary>
        public const byte ASYNC_MINIMUM_PRIORITY_VALUE = 2;

        /// <summary>
        /// Recommended Sync Frame frequency for a bit rate (§3.2.5.3). System specific -
        /// use only to sanity-check a MEASURED PTU, never as a substitute for measuring.
        /// </summary>
        /// <param name="bitRate">The bus bit rate.</param>
        /// <returns>Recommended Sync frequency in hertz.</returns>
        public static double RecommendedSyncHz(MilcanBitRate bitRate)
        {
            switch (bitRate)
            {
                case MilcanBitRate.Rate1M: return 512.0;
                case MilcanBitRate.Rate500k: return 128.0;
                case MilcanBitRate.Rate250k: return 64.0;
                default: return 0.0;
            }
        }

        /// <summary>
        /// Recommended Primary Time Unit (the interval between Sync Frames) for a bit
        /// rate, in milliseconds. Derived from <see cref="RecommendedSyncHz"/>.
        /// </summary>
        /// <param name="bitRate">The bus bit rate.</param>
        /// <returns>Recommended PTU in milliseconds, or 0 when the rate is unknown.</returns>
        public static double RecommendedPtuMs(MilcanBitRate bitRate)
        {
            double hz = RecommendedSyncHz(bitRate);
            return hz > 0.0 ? 1000.0 / hz : 0.0;
        }

        /// <summary>The real-time class a priority value denotes (Table 4-1).</summary>
        /// <param name="priority">Priority 0..7.</param>
        /// <returns>The corresponding class.</returns>
        public static MilcanRealTimeClass ClassOf(byte priority)
        {
            return (MilcanRealTimeClass)(priority & 0x07);
        }

        /// <summary>
        /// The latency bound a priority promises, expressed in PTUs, or 0 for priority 7
        /// which has no latency requirement (Table 4-1).
        /// </summary>
        /// <param name="priority">Priority 0..7.</param>
        /// <returns>Deadline in PTUs; 0 means "no requirement".</returns>
        public static int LatencyBoundPtu(byte priority)
        {
            switch (priority & 0x07)
            {
                case 0: return 1;
                case 1: return 1;
                case 2: return 8;
                case 3: return 64;
                case 4: return 8;
                case 5: return 64;
                case 6: return 1024;
                default: return 0;
            }
        }

        /// <summary>Short human label for a priority, e.g. "0 HRT0" or "7 NRT".</summary>
        /// <param name="priority">Priority 0..7.</param>
        /// <returns>The label.</returns>
        public static string DescribePriority(byte priority)
        {
            byte p = (byte)(priority & 0x07);
            int bound = LatencyBoundPtu(p);
            string cls = ClassOf(p).ToString().ToUpperInvariant();

            return bound > 0
                ? string.Format(CultureInfo.InvariantCulture, "{0} {1} (<={2} PTU)", p, cls, bound)
                : string.Format(CultureInfo.InvariantCulture, "{0} {1} (no deadline)", p, cls);
        }

        // ── Primary-type names (Appendix A, Table A-1 - SUGGESTED allocation) ─────

        private static readonly Dictionary<byte, string> _primaryTypeNames = BuildPrimaryTypeNames();

        private static Dictionary<byte, string> BuildPrimaryTypeNames()
        {
            var map = new Dictionary<byte, string>();

            map[0x00] = "Protocol";                 // Sync 0x80 / EnterCfg 0x81 / ExitCfg 0x82
            map[0x31] = "Non-operational (physically addressed)";
            map[0x56] = "HVAC / NBC";
            map[0x58] = "Vision Sensor Control";
            map[0x5A] = "Generic MMI";
            map[0x5C] = "FDSS";
            map[0x5E] = "Lighting";
            map[0x60] = "Body Electronics";
            map[0x62] = "Alive";
            map[0x63] = "Diagnostics";
            map[0x64] = "Diagnostics";
            map[0x65] = "Diagnostics";
            map[0x66] = "Diagnostics";

            return map;
        }

        /// <summary>
        /// Name of a primary-type from the spec's SUGGESTED allocation, or null when the
        /// value is not in the table. Null is a real answer - Table A-1 leaves
        /// 0x67..0xFF undefined and marks many values reserved, and inventing a name for
        /// one would describe a system that has not been observed.
        /// </summary>
        /// <param name="primaryType">The primary-type byte.</param>
        /// <returns>The suggested name, or null when unallocated.</returns>
        public static string PrimaryTypeName(byte primaryType)
        {
            string name;
            return _primaryTypeNames.TryGetValue(primaryType, out name) ? name : null;
        }

        /// <summary>
        /// Describes a decoded identifier for a trace line, naming the well-known
        /// protocol messages exactly and falling back to the suggested primary-type
        /// name (marked "?") or a bare hex pair when the allocation is unknown.
        /// </summary>
        /// <param name="id">The identifier to describe.</param>
        /// <returns>A short human-readable description.</returns>
        public static string Describe(MilcanId id)
        {
            if (!id.IsMilcan)
            {
                return "SAE J1939 frame (protocol-type bit clear)";
            }

            if (id.IsSyncFrame) return "SYNC FRAME";
            if (id.IsEnterConfig) return "ENTER CONFIG MODE";
            if (id.IsExitConfig) return "EXIT CONFIG MODE";

            if (id.IsAlive)
            {
                return string.Format(CultureInfo.InvariantCulture, "ALIVE (node 0x{0:X2})", id.SubType);
            }

            if (id.IsPhysicallyAddressed)
            {
                return id.SubType == 0x00
                    ? "Non-operational (broadcast)"
                    : string.Format(CultureInfo.InvariantCulture, "Non-operational (to 0x{0:X2})", id.SubType);
            }

            string suggested = PrimaryTypeName(id.PrimaryType);
            string body = suggested != null
                ? string.Format(CultureInfo.InvariantCulture, "{0}? 0x{1:X2}/0x{2:X2}", suggested, id.PrimaryType, id.SubType)
                : string.Format(CultureInfo.InvariantCulture, "0x{0:X2}/0x{1:X2}", id.PrimaryType, id.SubType);

            return id.IsRequest ? "REQUEST " + body : body;
        }
    }
}
