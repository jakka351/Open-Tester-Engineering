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
//  MilcanTransport.cs - MilCAN A multi-frame message reassembly (MILA §3.2.12).
//
//  THIS IS NOT J1939 TP AND NOT ISO-TP. There is no connection management, no CTS, no
//  flow control and no session negotiation. A multi-frame message is simply a run of
//  frames that all carry the SAME 29-bit identifier, delimited by a message-count byte:
//
//     first frame        count = 0    bytes 1..3 = 24-bit byte count (LSB first)
//                                     bytes 4..7 reserved
//     intermediate frame count = 1..249 (wraps 249 -> 1), bytes 1..7 = data
//     last frame         count = 250  bytes 1..2 = optional CRC, 3..7 reserved
//
//  Because the delimiter is in the PAYLOAD and the identifier never changes, a
//  reassembler that loses the first frame cannot tell data from control. That is a
//  property of the protocol, not a defect here: this class refuses to emit a message
//  it did not see the start of, rather than guessing and handing up a payload whose
//  leading bytes are actually somebody else's control fields.
//
//  WHICH IDENTIFIERS ARE MULTI-FRAME IS A DESIGN-TIME FACT, NOT A GUESS.
//  §3.2.12.1: "Multi-frame messages shall be identified as such within the message
//  set." Membership is declared by the system designer; it is NOT inferable from the
//  payload. An earlier draft of this class inferred it - any frame of 4+ bytes whose
//  first byte was 0x00 started an assembly - and the emulator caught it immediately:
//  an ordinary Body Electronics status message with payload 00 01 00 00 was swallowed
//  as a first frame, and every subsequent one aborted the assembly the last had
//  started. Single-frame traffic silently disappeared from the decode.
//
//  So nothing is reassembled unless the caller has REGISTERED the message type. The
//  default - no registrations - means every frame is treated as single-frame, which is
//  the honest default for an unknown platform: a tool that has not been told the
//  message set does not know, and pretending otherwise loses real traffic.
//
//  A node may not have two multi-frame messages with the SAME identifier in flight at
//  once (§3.2.12.1), so one assembly slot per identifier is correct and sufficient.
// =============================================================================

using System;
using System.Collections.Generic;
using System.Globalization;

namespace TesterPresent.OBD2.Milcan
{
    /// <summary>
    /// Reassembles MilCAN A multi-frame messages keyed by 29-bit identifier
    /// (MWG-MILA-001 Rev 3 §3.2.12).
    /// </summary>
    /// <remarks>Not thread-safe; driven from the session's pump thread.</remarks>
    public sealed class MilcanTransport
    {
        /// <summary>Message-count value marking the first (control-only) frame.</summary>
        public const byte COUNT_FIRST = 0;

        /// <summary>Message-count value marking the last (control-only) frame.</summary>
        public const byte COUNT_LAST = 250;

        /// <summary>Lowest message-count value used by an intermediate frame.</summary>
        public const byte COUNT_INTERMEDIATE_MIN = 1;

        /// <summary>Highest message-count value used by an intermediate frame; the next frame restarts at 1.</summary>
        public const byte COUNT_INTERMEDIATE_MAX = 249;

        /// <summary>Data bytes carried by one intermediate frame (payload bytes 1..7).</summary>
        public const int DATA_BYTES_PER_FRAME = 7;

        /// <summary>
        /// Largest byte count the 24-bit field may express (§3.2.12.1.1). Note this is
        /// 0xFAFFFF, NOT 0xFFFFFF - the spec caps it below the full 24-bit range.
        /// </summary>
        public const uint MAX_BYTE_COUNT = 0xFAFFFFu;

        /// <summary>
        /// Abandon a partial assembly after this long with no further frame. MilCAN
        /// defines no transport timeout (there is no connection to time out), so this is
        /// OUR bound to stop a lost last-frame leaking memory for the session's life.
        /// Generous by design: multi-frame messages are explicitly not time critical and
        /// are rate-limited to one frame per PTU per identifier.
        /// </summary>
        public const double ASSEMBLY_TIMEOUT_MS = 30000.0;

        private sealed class Assembly
        {
            public uint DeclaredBytes;
            public List<byte> Data;
            public int FrameCount;
            public int ExpectedCount;
            public double StartedMs;
            public double LastFrameMs;
            public bool Damaged;
            public string DamageReason;
        }

        private readonly Dictionary<uint, Assembly> _assemblies = new Dictionary<uint, Assembly>();
        private readonly HashSet<ushort> _multiFrameTypes = new HashSet<ushort>();

        /// <summary>Number of multi-frame assemblies currently in progress.</summary>
        public int InFlightCount { get { return _assemblies.Count; } }

        /// <summary>Number of message types declared as carrying multi-frame messages.</summary>
        public int RegisteredTypeCount { get { return _multiFrameTypes.Count; } }

        /// <summary>
        /// Declares that a message type carries multi-frame messages (§3.2.12.1). Until
        /// a type is registered its frames are passed through as single-frame messages,
        /// because multi-frame membership is part of the platform's message set and
        /// cannot be inferred from the wire.
        /// </summary>
        /// <param name="primaryType">Primary-type of the multi-frame message.</param>
        /// <param name="subType">Sub-type of the multi-frame message.</param>
        public void RegisterMultiFrameType(byte primaryType, byte subType)
        {
            _multiFrameTypes.Add((ushort)((primaryType << 8) | subType));
        }

        /// <summary>True when the message type has been declared as multi-frame.</summary>
        /// <param name="id">The identifier to test.</param>
        /// <returns>True when registered.</returns>
        public bool IsMultiFrameType(MilcanId id)
        {
            return _multiFrameTypes.Contains(id.MessageType);
        }

        /// <summary>
        /// Offers one frame to the reassembler.
        /// </summary>
        /// <param name="id">The frame's identifier. All frames of one message share it.</param>
        /// <param name="payload">The 0..8 byte frame payload.</param>
        /// <param name="timestampMs">Arrival timestamp on the session clock.</param>
        /// <param name="result">
        /// The completed message when this frame finished one; null otherwise.
        /// </param>
        /// <returns>
        /// True when the frame was consumed as part of a multi-frame message (whether or
        /// not it completed one). False means the frame is an ordinary single-frame
        /// message and the caller should dispatch it directly.
        /// </returns>
        /// <exception cref="ArgumentNullException"><paramref name="payload"/> is null.</exception>
        public bool Offer(MilcanId id, byte[] payload, double timestampMs, out MilcanMultiFrameResult result)
        {
            if (payload == null) throw new ArgumentNullException("payload");

            result = null;
            ExpireStale(timestampMs);

            // Not declared multi-frame by the message set => single-frame, always.
            // This test comes FIRST so no payload-shaped coincidence can start an
            // assembly on an ordinary status message (see the file header).
            if (!IsMultiFrameType(id)) return false;

            // A frame with no payload cannot carry a message count, so it can only be a
            // single-frame message.
            if (payload.Length == 0) return false;

            uint key = id.Raw;
            byte count = payload[0];
            Assembly assembly;
            bool tracking = _assemblies.TryGetValue(key, out assembly);

            if (count == COUNT_FIRST)
            {
                // A first frame needs its 24-bit byte count. Anything shorter is not a
                // multi-frame start, and a message whose payload merely happens to begin
                // with 0x00 must not be swallowed as one.
                if (payload.Length < 4) return false;

                uint declared = (uint)(payload[1] | (payload[2] << 8) | (payload[3] << 16));
                if (declared == 0 || declared > MAX_BYTE_COUNT)
                {
                    // Out-of-range length: treat as an ordinary frame rather than
                    // starting an assembly that can never be satisfied.
                    return false;
                }

                if (tracking)
                {
                    // A new start while one is open means the previous message was
                    // truncated. Report it - a silently discarded partial is exactly the
                    // kind of drop that makes a tool look like it is working.
                    result = MilcanMultiFrameResult.Aborted(id, assembly.Data.Count, assembly.DeclaredBytes,
                        "a new first frame arrived before the previous multi-frame message completed");
                }

                _assemblies[key] = new Assembly
                {
                    DeclaredBytes = declared,
                    Data = new List<byte>((int)Math.Min(declared, 65536u)),
                    FrameCount = 1,
                    ExpectedCount = COUNT_INTERMEDIATE_MIN,
                    StartedMs = timestampMs,
                    LastFrameMs = timestampMs
                };

                return true;
            }

            // Not a first frame. Without an open assembly this is either an ordinary
            // single-frame message or the tail of a message we started listening
            // mid-way through; either way it cannot be reassembled.
            if (!tracking) return false;

            assembly.LastFrameMs = timestampMs;

            if (count == COUNT_LAST)
            {
                _assemblies.Remove(key);
                assembly.FrameCount++;

                byte[] data = assembly.Data.ToArray();

                // Trim the padding the spec requires on the final intermediate frame.
                // The declared byte count is authoritative; anything beyond it is pad.
                if (data.Length > assembly.DeclaredBytes)
                {
                    Array.Resize(ref data, (int)assembly.DeclaredBytes);
                }

                bool complete = data.Length == assembly.DeclaredBytes && !assembly.Damaged;

                ushort? crc = null;
                if (payload.Length >= 3)
                {
                    crc = (ushort)(payload[1] | (payload[2] << 8));
                }

                if (!complete)
                {
                    string why = assembly.Damaged
                        ? assembly.DamageReason
                        : string.Format(CultureInfo.InvariantCulture,
                            "declared {0} byte(s) but {1} arrived", assembly.DeclaredBytes, data.Length);

                    result = MilcanMultiFrameResult.Incomplete(id, data, assembly.DeclaredBytes,
                        assembly.FrameCount, crc, why);
                }
                else
                {
                    result = MilcanMultiFrameResult.Completed(id, data, assembly.FrameCount, crc);
                }

                return true;
            }

            // Intermediate frame.
            if (count < COUNT_INTERMEDIATE_MIN || count > COUNT_INTERMEDIATE_MAX)
            {
                assembly.Damaged = true;
                assembly.DamageReason = string.Format(CultureInfo.InvariantCulture,
                    "message count {0} is outside the intermediate range {1}..{2}",
                    count, COUNT_INTERMEDIATE_MIN, COUNT_INTERMEDIATE_MAX);
                return true;
            }

            if (count != assembly.ExpectedCount && !assembly.Damaged)
            {
                // Out-of-order or missing frame. The message is kept so its length is
                // still reported at the end, but it is flagged: handing up a payload
                // with a hole silently would be worse than saying it is short.
                assembly.Damaged = true;
                assembly.DamageReason = string.Format(CultureInfo.InvariantCulture,
                    "expected message count {0} but received {1} - frame(s) lost or reordered",
                    assembly.ExpectedCount, count);
            }

            for (int i = 1; i < payload.Length; i++)
            {
                assembly.Data.Add(payload[i]);
            }

            assembly.FrameCount++;
            assembly.ExpectedCount = count >= COUNT_INTERMEDIATE_MAX
                ? COUNT_INTERMEDIATE_MIN
                : (byte)(count + 1);

            return true;
        }

        /// <summary>Drops assemblies that have gone quiet, so a lost last frame cannot leak for the session's life.</summary>
        /// <param name="nowMs">Current session clock reading.</param>
        private void ExpireStale(double nowMs)
        {
            if (_assemblies.Count == 0) return;

            List<uint> dead = null;
            foreach (KeyValuePair<uint, Assembly> kv in _assemblies)
            {
                if ((nowMs - kv.Value.LastFrameMs) > ASSEMBLY_TIMEOUT_MS)
                {
                    if (dead == null) dead = new List<uint>();
                    dead.Add(kv.Key);
                }
            }

            if (dead == null) return;
            for (int i = 0; i < dead.Count; i++) _assemblies.Remove(dead[i]);
        }

        /// <summary>Discards every in-flight assembly. Registered message types are kept.</summary>
        public void Reset()
        {
            _assemblies.Clear();
        }
    }

    /// <summary>The outcome of offering a frame to <see cref="MilcanTransport"/>.</summary>
    public sealed class MilcanMultiFrameResult
    {
        private MilcanMultiFrameResult() { }

        /// <summary>The identifier every frame of the message carried.</summary>
        public MilcanId Id { get; private set; }

        /// <summary>The reassembled payload. Short of <see cref="DeclaredBytes"/> when <see cref="IsComplete"/> is false.</summary>
        public byte[] Data { get; private set; }

        /// <summary>Byte count declared by the first frame.</summary>
        public uint DeclaredBytes { get; private set; }

        /// <summary>Frames the message occupied, including the first and last control frames.</summary>
        public int FrameCount { get; private set; }

        /// <summary>The optional user-defined CRC from the last frame, or null when none was carried.</summary>
        public ushort? Crc { get; private set; }

        /// <summary>True when the declared byte count was satisfied with no lost or reordered frames.</summary>
        public bool IsComplete { get; private set; }

        /// <summary>Why the message is not complete, or null when it is.</summary>
        public string Fault { get; private set; }

        internal static MilcanMultiFrameResult Completed(MilcanId id, byte[] data, int frames, ushort? crc)
        {
            return new MilcanMultiFrameResult
            {
                Id = id,
                Data = data,
                DeclaredBytes = (uint)data.Length,
                FrameCount = frames,
                Crc = crc,
                IsComplete = true
            };
        }

        internal static MilcanMultiFrameResult Incomplete(MilcanId id, byte[] data, uint declared,
            int frames, ushort? crc, string fault)
        {
            return new MilcanMultiFrameResult
            {
                Id = id,
                Data = data,
                DeclaredBytes = declared,
                FrameCount = frames,
                Crc = crc,
                IsComplete = false,
                Fault = fault
            };
        }

        internal static MilcanMultiFrameResult Aborted(MilcanId id, int received, uint declared, string fault)
        {
            return new MilcanMultiFrameResult
            {
                Id = id,
                Data = new byte[0],
                DeclaredBytes = declared,
                FrameCount = 0,
                IsComplete = false,
                Fault = string.Format(CultureInfo.InvariantCulture,
                    "{0} ({1} of {2} byte(s) had arrived)", fault, received, declared)
            };
        }
    }
}
