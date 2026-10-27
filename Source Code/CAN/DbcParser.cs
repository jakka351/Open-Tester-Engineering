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
//  DbcParser.cs — Vector CANdb (.dbc) file parser
//  Parses message definitions (BO_), signal definitions (SG_), value tables
//  (VAL_), comments (CM_), signal value types (SIG_VALTYPE_ — IEEE float/double),
//  and extended multiplexing (SG_MUL_VAL_) from standard DBC files.
//  Also handles Python-wrapped DBC files (triple-quoted string content).
//
//  Correctness fixes (2026-09, CAN-sniffer audit):
//   • Multiplexed signals: the mux indicator (M / m<n>) used to be swallowed by a
//     non-capturing regex group and every sub-signal decoded unconditionally,
//     producing garbage for inactive groups. Now captured and gated on the
//     multiplexor's live value; SG_MUL_VAL_ ranges honoured.
//   • 11-bit vs 29-bit collision: messages were keyed by the bare id with the
//     extended marker masked off, so a standard 0x100 and an extended 0x100 shared
//     a slot (last-write-wins) and TryDecode ignored the frame's extended flag.
//     Messages are now keyed on (id, isExtended); isExtended-aware overloads added.
//   • IEEE float/double signals (SIG_VALTYPE_) were decoded as scaled integers.
//   • Short frames: FitsIn() lets callers flag a signal that runs past the DLC
//     instead of silently returning a zero-padded, plausible-but-wrong value.
// =============================================================================

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace TesterPresent.OBD2.CAN
{
    public enum DbcMuxRole { None, Multiplexor, Multiplexed }
    public enum DbcValueType { Integer, Float, Double }

    /// <summary>A single signal within a CAN message</summary>
    public class DbcSignal
    {
        public string Name { get; set; }
        public int StartBit { get; set; }
        public int BitLength { get; set; }
        public bool BigEndian { get; set; }   // @0 = big-endian (Motorola), @1 = little-endian (Intel)
        public bool Signed { get; set; }       // + = unsigned, - = signed
        public double Factor { get; set; } = 1;
        public double Offset { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
        public string Unit { get; set; } = "";
        public string Comment { get; set; } = "";
        public Dictionary<int, string> ValueDescriptions { get; set; } = new Dictionary<int, string>();

        // ── Multiplexing ──
        public DbcMuxRole MuxRole { get; set; } = DbcMuxRole.None;
        public int MuxValue { get; set; }                         // for m<n> simple multiplexing
        public List<int[]> MuxRanges { get; set; }                // for SG_MUL_VAL_ (each = {lo, hi})

        // ── Value type (SIG_VALTYPE_) ──
        public DbcValueType ValueType { get; set; } = DbcValueType.Integer;

        private int _maxByteIndex = -1;

        /// <summary>True if this multiplexed signal is present for the given multiplexor value.</summary>
        public bool MatchesMux(int switchValue)
        {
            if (MuxRole != DbcMuxRole.Multiplexed) return true;
            if (MuxRanges != null && MuxRanges.Count > 0)
            {
                foreach (var r in MuxRanges)
                    if (switchValue >= r[0] && switchValue <= r[1]) return true;
                return false;
            }
            return switchValue == MuxValue;
        }

        /// <summary>Highest byte index this signal reads; lets callers detect a signal past the DLC.</summary>
        public bool FitsIn(int dataLength)
        {
            if (_maxByteIndex < 0) _maxByteIndex = ComputeMaxByteIndex();
            return _maxByteIndex < dataLength;
        }

        private int ComputeMaxByteIndex()
        {
            if (BitLength <= 0) return 0;
            if (!BigEndian)
                return (StartBit + BitLength - 1) / 8;

            // Motorola: walk the same navigation Decode uses and track the max byte touched.
            int max = 0, currentBit = StartBit;
            for (int read = 0; read < BitLength; read++)
            {
                int byteIdx = currentBit / 8;
                if (byteIdx > max) max = byteIdx;
                int bitInByte = currentBit % 8;
                currentBit += (bitInByte == 0) ? 15 : -1;
            }
            return max;
        }

        /// <summary>Extract and decode this signal from raw CAN data bytes</summary>
        public double Decode(byte[] data)
        {
            if (data == null || data.Length == 0) return 0;

            long rawValue = BigEndian
                ? ExtractBigEndian(data, StartBit, BitLength)
                : ExtractLittleEndian(data, StartBit, BitLength);

            // IEEE-754 floats/doubles are not scaled two's-complement integers.
            if (ValueType == DbcValueType.Float && BitLength == 32)
            {
                float f = BitConverter.ToSingle(BitConverter.GetBytes((uint)(rawValue & 0xFFFFFFFFL)), 0);
                return f * Factor + Offset;
            }
            if (ValueType == DbcValueType.Double && BitLength == 64)
            {
                double d = BitConverter.Int64BitsToDouble(rawValue);
                return d * Factor + Offset;
            }

            // Handle signed values (two's complement)
            if (Signed && BitLength > 1 && BitLength < 64)
            {
                long signBit = 1L << (BitLength - 1);
                if ((rawValue & signBit) != 0)
                    rawValue -= (1L << BitLength);
            }

            return rawValue * Factor + Offset;
        }

        /// <summary>Pack a physical value for this signal into <paramref name="data"/> (for DBC-composed sends).</summary>
        public void Encode(byte[] data, double physical)
        {
            if (data == null) return;
            double factor = Math.Abs(Factor) < 1e-12 ? 1 : Factor;
            long raw;
            if (ValueType == DbcValueType.Float && BitLength == 32)
                raw = BitConverter.ToUInt32(BitConverter.GetBytes((float)((physical - Offset) / factor)), 0);
            else if (ValueType == DbcValueType.Double && BitLength == 64)
                raw = BitConverter.DoubleToInt64Bits((physical - Offset) / factor);
            else
                raw = (long)Math.Round((physical - Offset) / factor);

            if (BigEndian) InsertBigEndian(data, StartBit, BitLength, raw);
            else InsertLittleEndian(data, StartBit, BitLength, raw);
        }

        private static void InsertLittleEndian(byte[] data, int startBit, int bitLen, long value)
        {
            for (int i = 0; i < bitLen; i++)
            {
                int bitPos = startBit + i, bi = bitPos / 8, bib = bitPos % 8;
                if (bi < 0 || bi >= data.Length) continue;
                if (((value >> i) & 1) != 0) data[bi] |= (byte)(1 << bib);
                else data[bi] &= (byte)~(1 << bib);
            }
        }

        private static void InsertBigEndian(byte[] data, int startBit, int bitLen, long value)
        {
            int written = 0, currentBit = startBit;
            while (written < bitLen)
            {
                int bi = currentBit / 8, bib = currentBit % 8;
                if (bi >= 0 && bi < data.Length)
                {
                    if (((value >> (bitLen - 1 - written)) & 1) != 0) data[bi] |= (byte)(1 << bib);
                    else data[bi] &= (byte)~(1 << bib);
                }
                written++;
                currentBit += (bib == 0) ? 15 : -1;
            }
        }

        /// <summary>Get the value description string if one exists, else null</summary>
        public string GetValueDescription(double physicalValue)
        {
            int key = (int)Math.Round(physicalValue);
            string desc;
            if (ValueDescriptions.TryGetValue(key, out desc))
                return desc;

            // For factor != 1, try raw
            if (Math.Abs(Factor) > 0.0001)
            {
                int rawKey = (int)Math.Round((physicalValue - Offset) / Factor);
                if (ValueDescriptions.TryGetValue(rawKey, out desc))
                    return desc;
            }
            return null;
        }

        private static long ExtractBigEndian(byte[] data, int startBit, int bitLen)
        {
            // Motorola byte order: startBit is MSB position in DBC notation
            long result = 0;
            int bitsRead = 0;
            int currentBit = startBit;

            while (bitsRead < bitLen)
            {
                int byteIdx = currentBit / 8;
                int bitInByte = currentBit % 8;

                if (byteIdx >= 0 && byteIdx < data.Length)
                {
                    int bitVal = (data[byteIdx] >> bitInByte) & 1;
                    result |= ((long)bitVal << (bitLen - 1 - bitsRead));
                }

                bitsRead++;
                currentBit += (bitInByte == 0) ? 15 : -1;
            }
            return result;
        }

        private static long ExtractLittleEndian(byte[] data, int startBit, int bitLen)
        {
            long result = 0;
            for (int i = 0; i < bitLen; i++)
            {
                int bitPos = startBit + i;
                int byteIdx = bitPos / 8;
                int bitInByte = bitPos % 8;

                if (byteIdx >= 0 && byteIdx < data.Length)
                {
                    int bitVal = (data[byteIdx] >> bitInByte) & 1;
                    result |= ((long)bitVal << i);
                }
            }
            return result;
        }
    }

    /// <summary>A CAN message definition containing signals</summary>
    public class DbcMessage
    {
        public uint Id { get; set; }               // clean numeric id (no extended marker)
        public bool IsExtended { get; set; }       // true if the BO_ id carried bit 31
        public string Name { get; set; }
        public int DLC { get; set; }
        public string Transmitter { get; set; } = "";
        public string Comment { get; set; } = "";
        public List<DbcSignal> Signals { get; set; } = new List<DbcSignal>();

        /// <summary>The multiplexor switch signal (M), if this is a multiplexed message.</summary>
        public DbcSignal Multiplexor
        {
            get { return Signals.FirstOrDefault(s => s.MuxRole == DbcMuxRole.Multiplexor); }
        }

        /// <summary>Decode all signals present for the current multiplexor value.</summary>
        public List<(DbcSignal signal, double value, string desc)> DecodeAll(byte[] data)
        {
            var results = new List<(DbcSignal, double, string)>();

            int? switchVal = null;
            var mux = Multiplexor;
            if (mux != null)
            {
                // Gate on the RAW multiplexor value — m<n> selectors and SG_MUL_VAL_ ranges are
                // raw, so undo the multiplexor's own factor/offset before comparing.
                double factor = Math.Abs(mux.Factor) < 1e-12 ? 1 : mux.Factor;
                switchVal = (int)Math.Round((mux.Decode(data) - mux.Offset) / factor);
            }

            foreach (var sig in Signals)
            {
                if (sig.MuxRole == DbcMuxRole.Multiplexed)
                {
                    if (switchVal == null) continue;          // can't resolve which group is live
                    if (!sig.MatchesMux(switchVal.Value)) continue;
                }
                double val = sig.Decode(data);
                string desc = sig.GetValueDescription(val);
                results.Add((sig, val, desc));
            }
            return results;
        }
    }

    /// <summary>Parsed DBC database</summary>
    public class DbcDatabase
    {
        public string FilePath { get; set; } = "";
        public string FileName { get; set; } = "";
        // Keyed on the composite (id, isExtended) key so 11-bit and 29-bit definitions
        // that share low bits do not collide. Iterate .Values for the message list.
        public Dictionary<uint, DbcMessage> Messages { get; set; } = new Dictionary<uint, DbcMessage>();
        public int TotalSignals => Messages.Values.Sum(m => m.Signals.Count);

        internal static uint Key(uint cleanId, bool ext) => ext ? ((cleanId & 0x1FFFFFFF) | 0x80000000u) : (cleanId & 0x1FFFFFFF);

        // ── isExtended-aware API (preferred) ──

        /// <summary>Decode a CAN frame against its exact (id, extended) definition. Null if unknown.</summary>
        public List<(DbcSignal signal, double value, string desc)> TryDecode(uint canId, byte[] data, bool isExtended)
        {
            DbcMessage msg;
            return Messages.TryGetValue(Key(canId, isExtended), out msg) ? msg.DecodeAll(data) : null;
        }

        /// <summary>Message name for an exact (id, extended) match, or null.</summary>
        public string GetMessageName(uint canId, bool isExtended)
        {
            DbcMessage msg;
            return Messages.TryGetValue(Key(canId, isExtended), out msg) ? msg.Name : null;
        }

        /// <summary>Resolve the message definition for an exact (id, extended) match, or null.</summary>
        public DbcMessage GetMessage(uint canId, bool isExtended)
        {
            DbcMessage msg;
            return Messages.TryGetValue(Key(canId, isExtended), out msg) ? msg : null;
        }

        // ── Legacy overloads (extended-agnostic): try standard first, then extended ──

        public List<(DbcSignal signal, double value, string desc)> TryDecode(uint canId, byte[] data)
        {
            DbcMessage msg;
            if (Messages.TryGetValue(Key(canId, false), out msg)) return msg.DecodeAll(data);
            if (Messages.TryGetValue(Key(canId, true), out msg)) return msg.DecodeAll(data);
            return null;
        }

        public string GetMessageName(uint canId)
        {
            DbcMessage msg;
            if (Messages.TryGetValue(Key(canId, false), out msg)) return msg.Name;
            if (Messages.TryGetValue(Key(canId, true), out msg)) return msg.Name;
            return null;
        }
    }

    /// <summary>Parser for Vector CANdb (.dbc) files</summary>
    public static class DbcParser
    {
        static readonly Regex RxMessage = new Regex(
            @"^\s*BO_\s+(\d+)\s+(\w+)\s*:\s*(\d+)\s+(\S+)", RegexOptions.Compiled);
        // Signal, now capturing the optional multiplex indicator (M or m<n>) as group 2.
        static readonly Regex RxSignal = new Regex(
            @"^\s*SG_\s+(\w+)\s*(M|m\d+)?\s*:\s*(\d+)\|(\d+)@([01])([+-])\s*\(([^,]+),([^)]+)\)\s*\[([^|]*)\|([^\]]*)\]\s*""([^""]*)""\s*(.*)",
            RegexOptions.Compiled);
        static readonly Regex RxValDef = new Regex(
            @"^\s*VAL_\s+(\d+)\s+(\w+)\s+(.*?)\s*;", RegexOptions.Compiled | RegexOptions.Multiline);
        static readonly Regex RxComment = new Regex(
            @"^\s*CM_\s+SG_\s+(\d+)\s+(\w+)\s+""([^""]*)""\s*;", RegexOptions.Compiled | RegexOptions.Multiline);
        static readonly Regex RxMsgComment = new Regex(
            @"^\s*CM_\s+BO_\s+(\d+)\s+""([^""]*)""\s*;", RegexOptions.Compiled | RegexOptions.Multiline);
        static readonly Regex RxValType = new Regex(
            @"^\s*SIG_VALTYPE_\s+(\d+)\s+(\w+)\s*:?\s*(\d+)\s*;", RegexOptions.Compiled | RegexOptions.Multiline);
        // SG_MUL_VAL_ <msgid> <muxed_sig> <switch_sig> <lo>-<hi>[, <lo>-<hi>] ;
        static readonly Regex RxMulVal = new Regex(
            @"^\s*SG_MUL_VAL_\s+(\d+)\s+(\w+)\s+(\w+)\s+(.*?)\s*;", RegexOptions.Compiled | RegexOptions.Multiline);

        /// <summary>Parse a .dbc file from disk</summary>
        public static DbcDatabase ParseFile(string path)
        {
            if (!File.Exists(path)) return null;
            string content = File.ReadAllText(path);

            // Handle Python-wrapped DBC files (class with triple-quoted string)
            if (content.Contains("'''") || content.Contains("\"\"\""))
            {
                int start = content.IndexOf("'''");
                int end = -1;
                string quote = "'''";
                if (start < 0)
                {
                    start = content.IndexOf("\"\"\"");
                    quote = "\"\"\"";
                }
                if (start >= 0)
                {
                    start += 3;
                    end = content.IndexOf(quote, start);
                    if (end > start)
                        content = content.Substring(start, end - start);
                }
            }

            var db = ParseContent(content);
            db.FilePath = path;
            db.FileName = Path.GetFileName(path);
            return db;
        }

        /// <summary>Parse DBC content string</summary>
        public static DbcDatabase ParseContent(string content)
        {
            var db = new DbcDatabase();
            var lines = content.Split(new[] { '\r', '\n' }, StringSplitOptions.None);

            DbcMessage currentMsg = null;

            // First pass: messages and signals
            foreach (string rawLine in lines)
            {
                string line = rawLine.TrimEnd();

                var mMatch = RxMessage.Match(line);
                if (mMatch.Success)
                {
                    if (!uint.TryParse(mMatch.Groups[1].Value, NumberStyles.Integer, CultureInfo.InvariantCulture, out uint rawId))
                        continue;
                    bool ext = (rawId & 0x80000000u) != 0;
                    uint clean = rawId & 0x1FFFFFFF;

                    int dlc = 0;
                    int.TryParse(mMatch.Groups[3].Value, NumberStyles.Integer, CultureInfo.InvariantCulture, out dlc);

                    currentMsg = new DbcMessage
                    {
                        Id = clean,
                        IsExtended = ext,
                        Name = mMatch.Groups[2].Value,
                        DLC = dlc,
                        Transmitter = mMatch.Groups[4].Value
                    };
                    db.Messages[DbcDatabase.Key(clean, ext)] = currentMsg;
                    continue;
                }

                if (currentMsg != null)
                {
                    var sMatch = RxSignal.Match(line);
                    if (sMatch.Success)
                    {
                        // TryParse (not Parse) — a malformed / oversized bit field must skip the
                        // signal, not throw and abort the whole DBC load.
                        if (!int.TryParse(sMatch.Groups[3].Value, NumberStyles.Integer, CultureInfo.InvariantCulture, out int _startBit) ||
                            !int.TryParse(sMatch.Groups[4].Value, NumberStyles.Integer, CultureInfo.InvariantCulture, out int _bitLen))
                            continue;
                        var sig = new DbcSignal
                        {
                            Name = sMatch.Groups[1].Value,
                            StartBit = _startBit,
                            BitLength = _bitLen,
                            BigEndian = sMatch.Groups[5].Value == "0",
                            Signed = sMatch.Groups[6].Value == "-",
                            Factor = ParseDouble(sMatch.Groups[7].Value),
                            Offset = ParseDouble(sMatch.Groups[8].Value),
                            Min = ParseDouble(sMatch.Groups[9].Value),
                            Max = ParseDouble(sMatch.Groups[10].Value),
                            Unit = sMatch.Groups[11].Value
                        };

                        string mux = sMatch.Groups[2].Value;
                        if (!string.IsNullOrEmpty(mux))
                        {
                            if (mux == "M") sig.MuxRole = DbcMuxRole.Multiplexor;
                            else
                            {
                                sig.MuxRole = DbcMuxRole.Multiplexed;
                                int.TryParse(mux.Substring(1), NumberStyles.Integer, CultureInfo.InvariantCulture, out int mv);
                                sig.MuxValue = mv;
                            }
                        }
                        currentMsg.Signals.Add(sig);
                        continue;
                    }

                    if (!string.IsNullOrWhiteSpace(line) && !line.TrimStart().StartsWith("SG_"))
                        currentMsg = null;
                }
            }

            // Second pass: value definitions, comments, value types, extended mux
            string joined = string.Join("\n", lines);

            foreach (Match m in RxValDef.Matches(joined))
            {
                DbcSignal sig = FindSignal(db, m.Groups[1].Value, m.Groups[2].Value);
                if (sig == null) continue;
                var valRx = new Regex(@"(-?\d+)\s+""([^""]*)""");
                foreach (Match vm in valRx.Matches(m.Groups[3].Value))
                    if (int.TryParse(vm.Groups[1].Value, NumberStyles.Integer, CultureInfo.InvariantCulture, out int val))
                        sig.ValueDescriptions[val] = vm.Groups[2].Value;
            }

            foreach (Match m in RxComment.Matches(joined))
            {
                DbcSignal sig = FindSignal(db, m.Groups[1].Value, m.Groups[2].Value);
                if (sig != null) sig.Comment = m.Groups[3].Value;
            }

            foreach (Match m in RxMsgComment.Matches(joined))
            {
                DbcMessage msg = FindMessage(db, m.Groups[1].Value);
                if (msg != null) msg.Comment = m.Groups[2].Value;
            }

            foreach (Match m in RxValType.Matches(joined))
            {
                DbcSignal sig = FindSignal(db, m.Groups[1].Value, m.Groups[2].Value);
                if (sig == null) continue;
                if (int.TryParse(m.Groups[3].Value, out int vt))
                    sig.ValueType = vt == 1 ? DbcValueType.Float : vt == 2 ? DbcValueType.Double : DbcValueType.Integer;
            }

            foreach (Match m in RxMulVal.Matches(joined))
            {
                DbcSignal sig = FindSignal(db, m.Groups[1].Value, m.Groups[2].Value);
                if (sig == null) continue;
                sig.MuxRole = DbcMuxRole.Multiplexed;
                sig.MuxRanges = sig.MuxRanges ?? new List<int[]>();
                foreach (Match rm in Regex.Matches(m.Groups[4].Value, @"(\d+)\s*-\s*(\d+)"))
                    if (int.TryParse(rm.Groups[1].Value, out int lo) && int.TryParse(rm.Groups[2].Value, out int hi))
                        sig.MuxRanges.Add(new[] { lo, hi });
            }

            return db;
        }

        private static DbcMessage FindMessage(DbcDatabase db, string rawIdText)
        {
            if (!uint.TryParse(rawIdText, NumberStyles.Integer, CultureInfo.InvariantCulture, out uint rawId)) return null;
            bool ext = (rawId & 0x80000000u) != 0;
            db.Messages.TryGetValue(DbcDatabase.Key(rawId & 0x1FFFFFFF, ext), out DbcMessage msg);
            return msg;
        }

        private static DbcSignal FindSignal(DbcDatabase db, string rawIdText, string sigName)
        {
            var msg = FindMessage(db, rawIdText);
            return msg?.Signals.FirstOrDefault(s => s.Name == sigName);
        }

        private static double ParseDouble(string s)
        {
            s = s.Trim();
            return double.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out double v) ? v : 0;
        }
    }
}
