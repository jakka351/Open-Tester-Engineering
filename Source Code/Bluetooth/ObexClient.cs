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
//  Tester Present Specialist Automotive Solutions — OBEX client (PBAP / MAP) over RFCOMM
//  ObexClient.cs — assessment step 3, the data-bearing profiles.
//
//  "PBAP/MAP: synchronised personal data. Pulls the phonebook, call history, and text messages
//   the unit cached from previously paired phones ... the mechanism underlying commercial vehicle
//   forensics (e.g. Berla iVe). High diagnostic and investigative value; correspondingly high
//   privacy sensitivity."
//
//  A compact, correct OBEX implementation over any IByteChannel (RFCOMM socket or virtual COM):
//    • CONNECT with a Target UUID (PBAP or MAP), capturing the server's ConnectionId.
//    • GET with Name/Type/AppParameters, reassembling multi-packet Body/EndOfBody (CONTINUE loop).
//    • SETPATH for folder navigation, DISCONNECT.
//  PBAP helpers pull pb.vcf / call-history objects; MAP helpers list folders and messages.
//
//  PRIVACY: every object this returns is third-party PII. Callers MUST record the pull as a
//  Sensitive finding (BtAssessment does this) and honour the engagement's handling rules.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TesterPresent.OBD2.Bluetooth
{
    public sealed class ObexClient : IDisposable
    {
        private readonly IByteChannel _ch;
        private uint _connectionId;
        private bool _haveConnId;
        private ushort _serverMaxPacket = 0x2000;

        public event Action<string> Log;

        // OBEX opcodes (Final bit 0x80 set on requests that expect the response immediately).
        private const byte OP_CONNECT = 0x80;
        private const byte OP_DISCONNECT = 0x81;
        private const byte OP_GET_FINAL = 0x83;
        private const byte OP_SETPATH = 0x85;
        // Response codes (Final bit set).
        private const byte RSP_CONTINUE = 0x90;
        private const byte RSP_SUCCESS = 0xA0;

        // Header identifiers.
        private const byte H_NAME = 0x01;          // Unicode
        private const byte H_TYPE = 0x42;          // byte-seq (ASCII, null-terminated)
        private const byte H_BODY = 0x48;          // byte-seq
        private const byte H_END_OF_BODY = 0x49;   // byte-seq
        private const byte H_TARGET = 0x46;        // byte-seq
        private const byte H_WHO = 0x4A;           // byte-seq
        private const byte H_CONNECTION_ID = 0xCB; // 4-byte
        private const byte H_APP_PARAMS = 0x4C;    // byte-seq

        // Well-known OBEX target UUIDs.
        // PBAP PSE OBEX Target UUID = 796135f0-f0c5-11d8-0966-0800200c9a66 (NOT the SIG base suffix).
        public static readonly byte[] TargetPbap = { 0x79, 0x61, 0x35, 0xF0, 0xF0, 0xC5, 0x11, 0xD8, 0x09, 0x66, 0x08, 0x00, 0x20, 0x0C, 0x9A, 0x66 };
        public static readonly byte[] TargetMap = { 0xBB, 0x58, 0x2B, 0x40, 0x42, 0x0C, 0x11, 0xDB, 0xB0, 0xDE, 0x08, 0x00, 0x20, 0x0C, 0x9A, 0x66 };

        public ObexClient(IByteChannel channel) { _ch = channel ?? throw new ArgumentNullException(nameof(channel)); }

        // ── CONNECT ─────────────────────────────────────────────────────────────────────
        public async Task<bool> ConnectAsync(byte[] targetUuid)
        {
            var body = new List<byte>();
            body.Add(0x10);                        // OBEX version 1.0
            body.Add(0x00);                        // flags
            body.Add(0x20); body.Add(0x00);        // max packet 0x2000
            if (targetUuid != null) AppendByteSeqHeader(body, H_TARGET, targetUuid);

            var resp = await SendRequestAsync(OP_CONNECT, body.ToArray()).ConfigureAwait(false);
            if (resp == null) { Log?.Invoke("OBEX CONNECT: no response."); return false; }
            if (resp.Code != RSP_SUCCESS) { Log?.Invoke("OBEX CONNECT refused: 0x" + resp.Code.ToString("X2") + " (" + ObexCodeText(resp.Code) + ")."); return false; }

            // CONNECT response body: version, flags, maxpacket(2), then headers.
            if (resp.Payload.Length >= 4)
                _serverMaxPacket = (ushort)((resp.Payload[2] << 8) | resp.Payload[3]);
            foreach (var h in ParseHeaders(resp.Payload, 4))
            {
                if (h.Id == H_CONNECTION_ID && h.Value.Length == 4)
                {
                    _connectionId = (uint)((h.Value[0] << 24) | (h.Value[1] << 16) | (h.Value[2] << 8) | h.Value[3]);
                    _haveConnId = true;
                }
            }
            Log?.Invoke("OBEX connected (server max packet " + _serverMaxPacket + (_haveConnId ? ", connId 0x" + _connectionId.ToString("X8") : "") + ").");
            return true;
        }

        // ── GET (with multi-packet reassembly) ───────────────────────────────────────────
        public async Task<byte[]> GetAsync(string name, string type, byte[] appParams = null)
        {
            var first = new List<byte>();
            if (_haveConnId) AppendConnectionId(first);
            if (type != null) AppendByteSeqHeader(first, H_TYPE, NullTermAscii(type));
            if (name != null) AppendUnicodeHeader(first, H_NAME, name);
            if (appParams != null) AppendByteSeqHeader(first, H_APP_PARAMS, appParams);

            var acc = new List<byte>();
            var resp = await SendRequestAsync(OP_GET_FINAL, first.ToArray()).ConfigureAwait(false);
            int guard = 0;
            bool complete = false;   // true only on a terminal SUCCESS — else the object is truncated
            while (resp != null && (resp.Code == RSP_CONTINUE || resp.Code == RSP_SUCCESS))
            {
                foreach (var h in ParseHeaders(resp.Payload, 0))
                    if (h.Id == H_BODY || h.Id == H_END_OF_BODY) acc.AddRange(h.Value);

                if (resp.Code == RSP_SUCCESS) { complete = true; break; }
                if (++guard > 4096) { Log?.Invoke("OBEX GET: too many CONTINUE packets, aborting (TRUNCATED)."); break; }

                // Continue: send GET-Final with just the ConnectionId.
                var cont = new List<byte>();
                if (_haveConnId) AppendConnectionId(cont);
                resp = await SendRequestAsync(OP_GET_FINAL, cont.ToArray()).ConfigureAwait(false);
            }
            if (resp == null) { Log?.Invoke("OBEX GET: no/short response for " + name + " (TRUNCATED, " + acc.Count + " bytes)."); return acc.ToArray(); }
            if (!complete)
            {
                // Non-success terminal code, or the CONTINUE guard tripped: the pull is incomplete.
                // Surface it loudly so a forensic record is never mistaken for a full object.
                string code = resp.Code == RSP_CONTINUE ? "guard-limit" : "0x" + resp.Code.ToString("X2") + " (" + ObexCodeText(resp.Code) + ")";
                Log?.Invoke("OBEX GET " + name + " INCOMPLETE — " + code + ", " + acc.Count + " byte(s) recovered.");
            }
            return acc.ToArray();
        }

        // ── SETPATH ──────────────────────────────────────────────────────────────────────
        public async Task<bool> SetPathAsync(string folder, bool toParent = false)
        {
            var body = new List<byte>();
            body.Add((byte)(toParent ? 0x03 : 0x02)); // flags: 0x02 = don't create; 0x03 = backup+don't create
            body.Add(0x00);                            // constants
            if (_haveConnId) AppendConnectionId(body);
            AppendUnicodeHeader(body, H_NAME, folder ?? "");
            var resp = await SendRequestAsync(OP_SETPATH, body.ToArray()).ConfigureAwait(false);
            bool ok = resp != null && resp.Code == RSP_SUCCESS;
            if (!ok) Log?.Invoke("OBEX SETPATH '" + folder + "' → " + (resp != null ? ObexCodeText(resp.Code) : "no response") + ".");
            return ok;
        }

        public async Task DisconnectAsync()
        {
            try
            {
                var body = new List<byte>();
                if (_haveConnId) AppendConnectionId(body);
                await SendRequestAsync(OP_DISCONNECT, body.ToArray()).ConfigureAwait(false);
            }
            catch { }
        }

        // ── PBAP helpers ─────────────────────────────────────────────────────────────────
        public Task<bool> ConnectPbapAsync() => ConnectAsync(TargetPbap);

        /// <summary>Pull a PBAP object as UTF-8 text. objectName e.g. "telecom/pb.vcf",
        /// "telecom/cch.vcf" (combined call history), "telecom/ich.vcf" (incoming),
        /// "telecom/och.vcf" (outgoing), "telecom/mch.vcf" (missed).</summary>
        public async Task<string> PullPhonebookAsync(string objectName, ushort maxCount = 0)
        {
            byte[] app = maxCount > 0 ? BuildAppParam(0x04, new[] { (byte)(maxCount >> 8), (byte)(maxCount & 0xFF) }) : null;
            var bytes = await GetAsync(objectName, "x-bt/phonebook", app).ConfigureAwait(false);
            return Encoding.UTF8.GetString(bytes);
        }

        // ── MAP helpers ──────────────────────────────────────────────────────────────────
        public Task<bool> ConnectMapAsync() => ConnectAsync(TargetMap);

        /// <summary>Get the folder listing at the current path (x-obex/folder-listing).</summary>
        public async Task<string> GetFolderListingAsync()
        {
            var bytes = await GetAsync(null, "x-obex/folder-listing").ConfigureAwait(false);
            return Encoding.UTF8.GetString(bytes);
        }

        /// <summary>Get the message listing for the current folder (x-bt/MAP-msg-listing).
        /// Navigate with SetPathAsync("telecom"), then "msg", then "inbox" first.</summary>
        public async Task<string> GetMessageListingAsync(ushort maxCount = 64)
        {
            byte[] app = BuildAppParam(0x01, new[] { (byte)(maxCount >> 8), (byte)(maxCount & 0xFF) }); // MaxListCount
            var bytes = await GetAsync("", "x-bt/MAP-msg-listing", app).ConfigureAwait(false);
            return Encoding.UTF8.GetString(bytes);
        }

        // ── Wire framing ─────────────────────────────────────────────────────────────────
        private sealed class ObexResponse { public byte Code; public byte[] Payload = Array.Empty<byte>(); }

        private async Task<ObexResponse> SendRequestAsync(byte opcode, byte[] afterLength)
        {
            int total = 3 + (afterLength?.Length ?? 0);
            var pkt = new byte[total];
            pkt[0] = opcode;
            pkt[1] = (byte)(total >> 8);
            pkt[2] = (byte)(total & 0xFF);
            if (afterLength != null) Array.Copy(afterLength, 0, pkt, 3, afterLength.Length);
            await _ch.WriteAsync(pkt, 0, pkt.Length).ConfigureAwait(false);
            return await ReadResponseAsync().ConfigureAwait(false);
        }

        private async Task<ObexResponse> ReadResponseAsync()
        {
            var head = await ReadExactAsync(3, 8000).ConfigureAwait(false);
            if (head == null) return null;
            int len = (head[1] << 8) | head[2];
            int remaining = len - 3;
            byte[] payload = Array.Empty<byte>();
            if (remaining > 0)
            {
                payload = await ReadExactAsync(remaining, 8000).ConfigureAwait(false);
                if (payload == null) return null;
            }
            return new ObexResponse { Code = head[0], Payload = payload };
        }

        private async Task<byte[]> ReadExactAsync(int count, int timeoutMs)
        {
            var outb = new byte[count];
            int got = 0;
            var sw = System.Diagnostics.Stopwatch.StartNew();
            while (got < count)
            {
                if (sw.ElapsedMilliseconds > timeoutMs) return null;
                // Size the read request to exactly what remains, so a channel that has more buffered
                // (the next OBEX packet) never gets bytes silently dropped past this packet boundary.
                var tmp = new byte[count - got];
                int n = await _ch.ReadAsync(tmp, Math.Max(50, (int)(timeoutMs - sw.ElapsedMilliseconds))).ConfigureAwait(false);
                if (n <= 0) { if (!_ch.IsOpen) return null; continue; }
                Array.Copy(tmp, 0, outb, got, n);
                got += n;
            }
            return outb;
        }

        // ── Header builders / parsers ─────────────────────────────────────────────────────
        private void AppendConnectionId(List<byte> b)
        {
            b.Add(H_CONNECTION_ID);
            b.Add((byte)(_connectionId >> 24)); b.Add((byte)(_connectionId >> 16));
            b.Add((byte)(_connectionId >> 8)); b.Add((byte)(_connectionId & 0xFF));
        }

        private static void AppendByteSeqHeader(List<byte> b, byte id, byte[] value)
        {
            int len = 3 + value.Length;
            b.Add(id); b.Add((byte)(len >> 8)); b.Add((byte)(len & 0xFF));
            b.AddRange(value);
        }

        private static void AppendUnicodeHeader(List<byte> b, byte id, string text)
        {
            // Null-terminated big-endian UTF-16; length includes the 3-byte header prefix.
            var chars = text ?? "";
            var uni = new List<byte>((chars.Length + 1) * 2);
            foreach (char c in chars) { uni.Add((byte)(c >> 8)); uni.Add((byte)(c & 0xFF)); }
            uni.Add(0x00); uni.Add(0x00);
            int len = 3 + uni.Count;
            b.Add(id); b.Add((byte)(len >> 8)); b.Add((byte)(len & 0xFF));
            b.AddRange(uni);
        }

        private static byte[] NullTermAscii(string s)
        {
            var bytes = Encoding.ASCII.GetBytes(s ?? "");
            var outb = new byte[bytes.Length + 1];
            Array.Copy(bytes, outb, bytes.Length);
            return outb;
        }

        /// <summary>Build a single-triplet OBEX application-parameters TLV (tag, value).</summary>
        private static byte[] BuildAppParam(byte tag, byte[] value)
        {
            var outb = new byte[2 + value.Length];
            outb[0] = tag; outb[1] = (byte)value.Length;
            Array.Copy(value, 0, outb, 2, value.Length);
            return outb;
        }

        private struct ObexHeader { public byte Id; public byte[] Value; }

        private static IEnumerable<ObexHeader> ParseHeaders(byte[] data, int start)
        {
            int i = start;
            var list = new List<ObexHeader>();
            while (i < data.Length)
            {
                byte id = data[i++];
                int enc = id & 0xC0;
                if (enc == 0x00 || enc == 0x40) // length-prefixed
                {
                    if (i + 1 >= data.Length) break;
                    int len = (data[i] << 8) | data[i + 1]; i += 2;
                    int valLen = len - 3;
                    if (valLen < 0 || i + valLen > data.Length) break;
                    var val = new byte[valLen];
                    Array.Copy(data, i, val, 0, valLen); i += valLen;
                    list.Add(new ObexHeader { Id = id, Value = val });
                }
                else if (enc == 0x80) // 1-byte
                {
                    if (i >= data.Length) break;
                    list.Add(new ObexHeader { Id = id, Value = new[] { data[i] } }); i += 1;
                }
                else // 0xC0 → 4-byte
                {
                    if (i + 3 >= data.Length) break;
                    var val = new byte[4]; Array.Copy(data, i, val, 0, 4); i += 4;
                    list.Add(new ObexHeader { Id = id, Value = val });
                }
            }
            return list;
        }

        public static string ObexCodeText(byte code)
        {
            switch (code)
            {
                case 0xA0: return "Success";
                case 0x90: return "Continue";
                case 0xC0: return "Bad Request";
                case 0xC1: return "Unauthorized";
                case 0xC3: return "Forbidden";
                case 0xC4: return "Not Found";
                case 0xCC: return "Precondition Failed";
                case 0xD0: return "Server Error";
                default: return "0x" + code.ToString("X2");
            }
        }

        public void Dispose() { }
    }
}
