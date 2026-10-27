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
//  MilcanId.cs - MilCAN A 29-bit CAN identifier (MWG-MILA-001 Rev 3, §3.2.1 / §4.1.4)
//
//  Layout, MSB -> LSB:
//    bits 28..26 priority | bit 25 protocol-type | bit 24 request
//    bits 23..16 primary-type | bits 15..8 sub-type | bits 7..0 source address
//
//  This is deliberately the SAME 29-bit envelope as SAE J1939 (see J1939Id), but the
//  field SEMANTICS differ and MilCAN has NO parameter-group number:
//
//     bit(s)   J1939                 MilCAN A
//     ------   -------------------   ----------------------
//     28..26   priority              priority          (same)
//     25       EDP (reserved = 0)    protocol-type  (1 = MilCAN, 0 = J1939)
//     24       DP (data page)        request bit    (1 = request, 0 = status/command)
//     23..16   PDU format (PF)       primary-type
//     15..8    PDU specific (PS)     sub-type
//     7..0     source address        source address    (same)
//
//  Bit 25 is the discriminator that lets MilCAN A and J1939 share one 250 kbps wire.
//  DO NOT run J1939 PGN logic (PDU1/PDU2 masking) on a MilCAN identifier - it produces
//  a plausible-looking wrong parameter group. Addressing in MilCAN is LOGICAL: an
//  operational message is interpreted from primary-type + sub-type only, and the source
//  address exists solely to keep identifiers unique (§3.2.4). 0x00 is reserved.
// =============================================================================

using System;
using System.Globalization;

namespace TesterPresent.OBD2.Milcan
{
    /// <summary>
    /// A MilCAN A 29-bit extended CAN identifier, decoded into its
    /// priority / protocol-type / request / primary-type / sub-type / source-address
    /// fields per MWG-MILA-001 Rev 3.
    /// </summary>
    /// <remarks>
    /// Value type: <c>default(MilcanId)</c> is a valid identifier (priority 0, primary
    /// 0, sub 0, source 0) whose protocol-type bit is 0 - i.e. it decodes as a J1939
    /// frame, not a MilCAN one. Use a nullable <c>MilcanId?</c> where absence must be
    /// representable.
    /// </remarks>
    public struct MilcanId : IEquatable<MilcanId>
    {
        /// <summary>Mask of the 29 identifier bits. Adapter flag bits (e.g. the extended-frame flag) must be stripped before construction.</summary>
        public const uint IDENTIFIER_MASK = 0x1FFFFFFFu;

        /// <summary>Largest encodable priority (3 bits). 0 is the highest priority on the wire.</summary>
        public const byte MAX_PRIORITY = 7;

        /// <summary>Source address reserved by the spec and never used by a real node (§3.2.1.1).</summary>
        public const byte RESERVED_SOURCE_ADDRESS = 0x00;

        // Well-known message types (MILA §3.2.5, Appendix A).
        /// <summary>Primary-type for protocol messages (Sync Frame, Enter/Exit config).</summary>
        public const byte PRIMARY_PROTOCOL = 0x00;
        /// <summary>Sub-type of the Sync Frame message.</summary>
        public const byte SUB_SYNC = 0x80;
        /// <summary>Sub-type of the Enter Configuration Mode message.</summary>
        public const byte SUB_ENTER_CONFIG = 0x81;
        /// <summary>Sub-type of the Exit Configuration Mode message.</summary>
        public const byte SUB_EXIT_CONFIG = 0x82;
        /// <summary>Primary-type used by non-operational / physically-addressed messages (§3.2.5.2). Sub-type carries the destination address.</summary>
        public const byte PRIMARY_NON_OPERATIONAL = 0x31;
        /// <summary>Primary-type of the Alive message (§3.2.5.5). Sub-type carries the node id (1..255).</summary>
        public const byte PRIMARY_ALIVE = 0x62;

        private const int PRIORITY_SHIFT = 26;
        private const int PROTOCOL_TYPE_SHIFT = 25;
        private const int REQUEST_SHIFT = 24;
        private const int PRIMARY_TYPE_SHIFT = 16;
        private const int SUB_TYPE_SHIFT = 8;

        private readonly uint _raw;

        private MilcanId(uint raw)
        {
            _raw = raw;
        }

        /// <summary>The raw 29-bit identifier as it appears on the wire.</summary>
        public uint Raw
        {
            get { return _raw; }
        }

        /// <summary>Priority, bits 28..26. 0 is the highest priority, 7 the lowest (§3.2.1.5).</summary>
        public byte Priority
        {
            get { return (byte)((_raw >> PRIORITY_SHIFT) & 0x07u); }
        }

        /// <summary>
        /// Protocol-type bit (bit 25). True when the frame is a MilCAN message; false
        /// when it is an SAE J1939 message sharing the same bus. This is the routing
        /// bit a mixed-bus decoder must test first.
        /// </summary>
        public bool IsMilcan
        {
            get { return ((_raw >> PROTOCOL_TYPE_SHIFT) & 0x01u) != 0; }
        }

        /// <summary>True when bit 25 is clear: the frame is an SAE J1939 message, not MilCAN.</summary>
        public bool IsJ1939
        {
            get { return !IsMilcan; }
        }

        /// <summary>Request bit (bit 24). True = request message (no payload); false = status/command (§3.2.1.3).</summary>
        public bool IsRequest
        {
            get { return ((_raw >> REQUEST_SHIFT) & 0x01u) != 0; }
        }

        /// <summary>Primary-type, bits 23..16. Coarse message class (§3.2.1.2).</summary>
        public byte PrimaryType
        {
            get { return (byte)((_raw >> PRIMARY_TYPE_SHIFT) & 0xFFu); }
        }

        /// <summary>Sub-type, bits 15..8. Fine message discriminator within a primary-type.</summary>
        public byte SubType
        {
            get { return (byte)((_raw >> SUB_TYPE_SHIFT) & 0xFFu); }
        }

        /// <summary>Source address, bits 7..0. The transmitting node; 0x00 is reserved.</summary>
        public byte SourceAddress
        {
            get { return (byte)(_raw & 0xFFu); }
        }

        /// <summary>True when this is the Sync Frame message: MilCAN, priority 0, primary 0x00, sub 0x80 (§3.2.5.3).</summary>
        public bool IsSyncFrame
        {
            get { return IsMilcan && Priority == 0 && PrimaryType == PRIMARY_PROTOCOL && SubType == SUB_SYNC; }
        }

        /// <summary>True when this is an Enter Configuration Mode message: MilCAN, primary 0x00, sub 0x81 (§3.2.5.4.1).</summary>
        public bool IsEnterConfig
        {
            get { return IsMilcan && PrimaryType == PRIMARY_PROTOCOL && SubType == SUB_ENTER_CONFIG; }
        }

        /// <summary>True when this is an Exit Configuration Mode message: MilCAN, primary 0x00, sub 0x82 (§3.2.5.4.2).</summary>
        public bool IsExitConfig
        {
            get { return IsMilcan && PrimaryType == PRIMARY_PROTOCOL && SubType == SUB_EXIT_CONFIG; }
        }

        /// <summary>True when this is an Alive message: MilCAN, primary-type 0x62 (§3.2.5.5). Sub-type is the node id.</summary>
        public bool IsAlive
        {
            get { return IsMilcan && PrimaryType == PRIMARY_ALIVE; }
        }

        /// <summary>True when this is a non-operational / physically-addressed message: primary-type 0x31 (§3.2.5.2).</summary>
        public bool IsPhysicallyAddressed
        {
            get { return IsMilcan && PrimaryType == PRIMARY_NON_OPERATIONAL; }
        }

        /// <summary>
        /// The message-type key (primary-type in the high byte, sub-type in the low byte)
        /// used for logical addressing and message filtering. This is the MilCAN analogue
        /// of a J1939 PGN - it identifies WHAT the message is, independent of who sent it.
        /// </summary>
        public ushort MessageType
        {
            get { return (ushort)((PrimaryType << 8) | SubType); }
        }

        /// <summary>
        /// Builds an identifier from a raw 29-bit value received from an adapter.
        /// </summary>
        /// <param name="raw">The 29 identifier bits, with adapter flag bits already stripped.</param>
        /// <returns>The decoded identifier.</returns>
        /// <exception cref="ArgumentOutOfRangeException">The value does not fit in 29 bits.</exception>
        public static MilcanId FromRaw(uint raw)
        {
            if ((raw & ~IDENTIFIER_MASK) != 0)
            {
                throw new ArgumentOutOfRangeException("raw", raw,
                    "Value does not fit in a 29-bit MilCAN identifier. Strip adapter flag bits (mask with MilcanId.IDENTIFIER_MASK) before calling.");
            }

            return new MilcanId(raw);
        }

        /// <summary>
        /// Non-throwing form of <see cref="FromRaw"/>, for receive loops that may see
        /// frames the adapter did not filter out.
        /// </summary>
        /// <param name="raw">Candidate 29-bit identifier.</param>
        /// <param name="id">Receives the decoded identifier when the value is in range.</param>
        /// <returns>True when the value fits in 29 bits.</returns>
        public static bool TryFromRaw(uint raw, out MilcanId id)
        {
            if ((raw & ~IDENTIFIER_MASK) != 0)
            {
                id = default(MilcanId);
                return false;
            }

            id = new MilcanId(raw);
            return true;
        }

        /// <summary>
        /// Encodes a MilCAN identifier for transmission.
        /// </summary>
        /// <param name="priority">Priority 0..7 (§3.2.1.5).</param>
        /// <param name="primaryType">Primary-type, bits 23..16.</param>
        /// <param name="subType">Sub-type, bits 15..8.</param>
        /// <param name="sourceAddress">This tool's source address. 0x00 is reserved and rejected.</param>
        /// <param name="request">True to set the request bit (bit 24).</param>
        /// <returns>The encoded identifier with the protocol-type bit set (MilCAN).</returns>
        /// <exception cref="ArgumentOutOfRangeException">Priority is out of range.</exception>
        /// <exception cref="ArgumentException">Source address is the reserved value 0x00.</exception>
        public static MilcanId Create(byte priority, byte primaryType, byte subType, byte sourceAddress, bool request = false)
        {
            if (priority > MAX_PRIORITY)
            {
                throw new ArgumentOutOfRangeException("priority", priority,
                    "MilCAN priority is a 3-bit field (0..7).");
            }

            if (sourceAddress == RESERVED_SOURCE_ADDRESS)
            {
                throw new ArgumentException(
                    "Source address 0x00 is reserved by MilCAN A (§3.2.1.1) and must not be transmitted. Choose 0x01..0xFF.",
                    "sourceAddress");
            }

            uint raw = ((uint)priority << PRIORITY_SHIFT)
                     | (1u << PROTOCOL_TYPE_SHIFT)               // protocol-type = MilCAN
                     | ((request ? 1u : 0u) << REQUEST_SHIFT)
                     | ((uint)primaryType << PRIMARY_TYPE_SHIFT)
                     | ((uint)subType << SUB_TYPE_SHIFT)
                     | sourceAddress;

            return new MilcanId(raw);
        }

        /// <summary>The Sync Frame identifier (priority 0, primary 0x00, sub 0x80) for a given Sync Master source address.</summary>
        /// <param name="sourceAddress">The Sync Master's source address.</param>
        /// <returns>The Sync Frame identifier, e.g. 0x02008010 for source 0x10.</returns>
        public static MilcanId SyncFrame(byte sourceAddress)
        {
            return Create(0, PRIMARY_PROTOCOL, SUB_SYNC, sourceAddress);
        }

        /// <summary>The Enter Configuration Mode identifier (priority 0, primary 0x00, sub 0x81) for a given Config Master source address.</summary>
        /// <param name="sourceAddress">The Config Master's source address.</param>
        /// <returns>The Enter Config identifier, e.g. 0x02008110 for source 0x10.</returns>
        public static MilcanId EnterConfig(byte sourceAddress)
        {
            return Create(0, PRIMARY_PROTOCOL, SUB_ENTER_CONFIG, sourceAddress);
        }

        /// <summary>The Exit Configuration Mode identifier (priority 0, primary 0x00, sub 0x82) for a given Config Master source address.</summary>
        /// <param name="sourceAddress">The Config Master's source address.</param>
        /// <returns>The Exit Config identifier, e.g. 0x02008210 for source 0x10.</returns>
        public static MilcanId ExitConfig(byte sourceAddress)
        {
            return Create(0, PRIMARY_PROTOCOL, SUB_EXIT_CONFIG, sourceAddress);
        }

        /// <summary>Value equality over the raw identifier.</summary>
        /// <param name="other">Identifier to compare with.</param>
        /// <returns>True when the raw identifiers match.</returns>
        public bool Equals(MilcanId other)
        {
            return _raw == other._raw;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            return obj is MilcanId && Equals((MilcanId)obj);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return (int)_raw;
        }

        /// <summary>Equality operator.</summary>
        public static bool operator ==(MilcanId left, MilcanId right) { return left._raw == right._raw; }

        /// <summary>Inequality operator.</summary>
        public static bool operator !=(MilcanId left, MilcanId right) { return left._raw != right._raw; }

        /// <summary>
        /// Human-readable form, e.g.
        /// "MilCAN pri0 SYNC pt0x00 st0x80 SA0x10" or
        /// "MilCAN pri3 REQ pt0x58 st0x01 SA0x22".
        /// </summary>
        /// <returns>The formatted identifier.</returns>
        public override string ToString()
        {
            if (!IsMilcan)
            {
                return string.Format(CultureInfo.InvariantCulture,
                    "J1939(non-MilCAN) 0x{0:X8} pri{1} SA0x{2:X2}", _raw, Priority, SourceAddress);
            }

            return string.Format(CultureInfo.InvariantCulture,
                "MilCAN pri{0}{1} pt0x{2:X2} st0x{3:X2} SA0x{4:X2}",
                Priority, IsRequest ? " REQ" : string.Empty, PrimaryType, SubType, SourceAddress);
        }
    }
}
