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
//  Tester Present Specialist Automotive Solutions — profile-parser fuzzer
//  BtFuzzer.cs — assessment workflow step 5 (stack-level testing).
//
//  "The high-value parsers are the ones handling attacker-controllable structured input: the HFP
//   AT-command interpreter, the OBEX / PBAP object parser, and AVRCP metadata handling. Malformed
//   and boundary-case input across these channels is the standard method for surfacing memory-
//   safety and logic faults in the unit's stack."
//
//  Runs over an established RFCOMM IByteChannel. For each generated case it: confirms the channel
//  is still open, sends the case, reads any response within a per-case timeout, then classifies —
//    • Normal        : the parser answered (OK / ERROR / some bytes) — healthy.
//    • NoResponse    : silence after the unit had been responsive — possible parser hang.
//    • ChannelClosed : the link dropped mid/after the case — possible crash / watchdog reset.
//  A safety governor rate-limits, bounds each case, and STOPS on the first ChannelClosed so a
//  suspected crash is not hammered. This is for in-scope hardware only — the UI gates it behind
//  an explicit authorisation confirmation.
//
//  HONESTY: HFP-AT and OBEX are reachable over RFCOMM and are fuzzed live. AVRCP metadata rides
//  AVCTP/L2CAP, which this WinRT stack cannot open as a peer — so AvrcpCases() is a case GENERATOR
//  (emits the malformed frames for use with a media-session tool), not a live channel. Labelled as
//  such; it never claims a live result.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TesterPresent.OBD2.Bluetooth
{
    public enum FuzzOutcome { Normal, NoResponse, ChannelClosed, Error }

    public sealed class FuzzCase
    {
        public string Description = "";
        public byte[] Payload = Array.Empty<byte>();
        public bool ExpectResponse = true;
    }

    public sealed class FuzzResult
    {
        public int Index;
        public string Description = "";
        public string InputPreview = "";
        public string ResponsePreview = "";
        public FuzzOutcome Outcome = FuzzOutcome.Normal;
        public BtSeverity Severity = BtSeverity.Info;
    }

    public static class BtFuzzer
    {
        /// <summary>Run a case list over a channel with a safety governor. Stops on first ChannelClosed.</summary>
        public static async Task<List<FuzzResult>> RunAsync(
            IByteChannel channel, IEnumerable<FuzzCase> cases, int perCaseTimeoutMs, int interCaseDelayMs,
            CancellationToken ct, Action<FuzzResult> onResult = null)
        {
            var results = new List<FuzzResult>();
            int idx = 0;
            bool everResponded = false;
            foreach (var c in cases)
            {
                if (ct.IsCancellationRequested) break;
                var r = new FuzzResult { Index = idx++, Description = c.Description, InputPreview = BtUtil.ToHex(c.Payload, 0, Math.Min(48, c.Payload.Length), spaced: true) };

                if (!channel.IsOpen)
                {
                    r.Outcome = FuzzOutcome.ChannelClosed; r.Severity = BtSeverity.High;
                    r.ResponsePreview = "(channel already closed before case)";
                    results.Add(r); onResult?.Invoke(r); break;
                }

                channel.DiscardInput();   // isolate this case: drop any late bytes from the previous case
                try { await channel.WriteAsync(c.Payload, 0, c.Payload.Length).ConfigureAwait(false); }
                catch (Exception ex)
                {
                    r.Outcome = channel.IsOpen ? FuzzOutcome.Error : FuzzOutcome.ChannelClosed;
                    r.Severity = channel.IsOpen ? BtSeverity.Low : BtSeverity.High;
                    r.ResponsePreview = "write threw: " + ex.Message;
                    results.Add(r); onResult?.Invoke(r);
                    if (!channel.IsOpen) break; else continue;
                }

                var buf = new byte[512];
                int n = 0;
                try { n = await channel.ReadAsync(buf, perCaseTimeoutMs).ConfigureAwait(false); }
                catch { }

                if (!channel.IsOpen)
                { r.Outcome = FuzzOutcome.ChannelClosed; r.Severity = BtSeverity.Critical; r.ResponsePreview = "LINK DROPPED after this case — possible crash/watchdog reset."; }
                else if (n > 0)
                { everResponded = true; r.Outcome = FuzzOutcome.Normal; r.Severity = BtSeverity.Info; r.ResponsePreview = BtUtil.ToAscii(buf, 0, Math.Min(80, n)).Replace("\r", " ").Replace("\n", " "); }
                else if (c.ExpectResponse && everResponded)
                { r.Outcome = FuzzOutcome.NoResponse; r.Severity = BtSeverity.Medium; r.ResponsePreview = "(no response — possible parser hang)"; }
                else
                { r.Outcome = FuzzOutcome.Normal; r.Severity = BtSeverity.Info; r.ResponsePreview = "(no response; not previously responsive)"; }

                results.Add(r); onResult?.Invoke(r);
                if (r.Outcome == FuzzOutcome.ChannelClosed) break;         // governor: stop on suspected crash
                try { await Task.Delay(interCaseDelayMs, ct).ConfigureAwait(false); } catch { break; }
            }
            return results;
        }

        // ── HFP AT parser cases ──────────────────────────────────────────────────────────
        public static IEnumerable<FuzzCase> HfpAtCases()
        {
            var list = new List<FuzzCase>();
            // ISO-8859-1 (28591) is byte-transparent: every char 0x00-0xFF maps to its byte value, so the
            // high-byte "binary garbage" / 0xFF cases actually reach the parser (Encoding.ASCII would fold them to '?').
            var enc = Encoding.GetEncoding(28591);
            Action<string, string> add = (desc, cmd) => list.Add(new FuzzCase { Description = desc, Payload = enc.GetBytes(cmd) });

            add("empty line", "\r\n");
            add("bare AT", "AT\r\n");
            add("no terminator", "AT+BRSF=1234567890");
            add("oversized numeric arg", "AT+BRSF=" + new string('9', 512) + "\r\n");
            add("oversized string arg", "AT+CLIP=\"" + new string('A', 1024) + "\"\r\n");
            add("unterminated quote", "AT+CLCC=\"unterminated\r\n");
            add("format-specifier payload", "AT+CLIP=\"%s%s%s%s%n%x\"\r\n");
            add("negative index", "AT+CPBR=-1\r\n");
            add("huge index", "AT+CPBR=4294967295\r\n");
            add("deep CSV", "AT+CIND=" + string.Join(",", new string[64].Select(_ => "0")) + "\r\n");
            add("nested quotes", "AT+CLIP=\"\"\"\"\"\"\r\n");
            add("nulls in arg", "AT+CGMI\0\0\0\r\n");
            add("many separators", "AT+" + new string('=', 200) + "\r\n");
            add("unknown vendor verb", "AT+ZZZZZZZ=1,2,3,4,5\r\n");
            add("binary garbage", "AT+" + new string((char)0xFF, 64) + "\r\n");
            add("cr flood", new string('\r', 256));
            return list;
        }

        // ── OBEX object parser cases ───────────────────────────────────────────────────────
        public static IEnumerable<FuzzCase> ObexCases()
        {
            var list = new List<FuzzCase>();

            // CONNECT with declared length shorter than actual body.
            list.Add(new FuzzCase { Description = "CONNECT len=3 but body present", Payload = new byte[] { 0x80, 0x00, 0x03, 0x10, 0x00, 0x20, 0x00 } });
            // CONNECT with declared length far larger than sent.
            list.Add(new FuzzCase { Description = "CONNECT len=0xFFFF, short body", Payload = new byte[] { 0x80, 0xFF, 0xFF, 0x10, 0x00, 0x20, 0x00 } });
            // GET with a Name header whose length field overflows the packet.
            list.Add(new FuzzCase { Description = "GET Name header len overflow", Payload = new byte[] { 0x83, 0x00, 0x08, 0x01, 0x7F, 0xFF, 0x41, 0x00 } });
            // Truncated header (HI present, length missing).
            list.Add(new FuzzCase { Description = "truncated header", Payload = new byte[] { 0x83, 0x00, 0x04, 0x01 } });
            // Unknown opcode.
            list.Add(new FuzzCase { Description = "unknown opcode 0x7F", Payload = new byte[] { 0x7F, 0x00, 0x03 } });
            // Zero-length packet claim.
            list.Add(new FuzzCase { Description = "length=0 packet", Payload = new byte[] { 0x80, 0x00, 0x00 } });
            // Oversized Name header (declared) with big-endian unicode-ish junk.
            var big = new List<byte> { 0x83, 0x00, 0x00, 0x01, 0x04, 0x00 };
            for (int i = 0; i < 300; i++) big.Add(0x41);
            int total = big.Count; big[1] = (byte)(total >> 8); big[2] = (byte)(total & 0xFF); big[4] = (byte)((total - 3) >> 8); big[5] = (byte)((total - 3) & 0xFF);
            list.Add(new FuzzCase { Description = "oversized Name header (300B)", Payload = big.ToArray() });
            // SETPATH with malformed flags.
            list.Add(new FuzzCase { Description = "SETPATH bad flags", Payload = new byte[] { 0x85, 0x00, 0x05, 0xFF, 0xFF, 0x01 } });
            return list;
        }

        // ── AVRCP metadata cases (GENERATOR ONLY — AVCTP not reachable from WinRT) ──────────
        public sealed class AvrcpCase { public string Description = ""; public byte[] Frame = Array.Empty<byte>(); }

        /// <summary>
        /// Emits malformed AVRCP GetElementAttributes / metadata frames for use with a media-session
        /// tool. NOT sent live — WinRT cannot open AVCTP. Documented so the operator can exercise the
        /// track/artist metadata parser the assessment flags as high-value.
        /// </summary>
        public static IEnumerable<AvrcpCase> AvrcpCases()
        {
            var list = new List<AvrcpCase>();
            // GetElementAttributes (PDU 0x20) with an impossible attribute count.
            list.Add(new AvrcpCase { Description = "GetElementAttributes count=0xFF", Frame = new byte[] { 0x20, 0x00, 0x00, 0x09, 0,0,0,0,0,0,0,0, 0xFF } });
            // A metadata response declaring a huge attribute-value length.
            list.Add(new AvrcpCase { Description = "attr value len=0xFFFF, short body", Frame = new byte[] { 0x20, 0x00, 0x00, 0x08, 0x01, 0x00,0x00,0x00,0x01, 0x00,0x6A, 0xFF,0xFF } });
            // Oversized track title (declared 0x0400, short body).
            var t = new List<byte> { 0x20, 0x00, 0x00, 0x00, 0x01, 0x00,0x00,0x00,0x01, 0x00,0x6A, 0x04,0x00 };
            for (int i = 0; i < 32; i++) t.Add(0x41);
            list.Add(new AvrcpCase { Description = "track title declared 1024B, 32B body", Frame = t.ToArray() });
            return list;
        }
    }
}
