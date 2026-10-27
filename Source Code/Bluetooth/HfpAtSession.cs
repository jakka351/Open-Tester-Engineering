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
//  Tester Present Specialist Automotive Solutions — HFP Audio-Gateway AT session (channel-agnostic)
//  HfpAtSession.cs — assessment step 3, the HFP AT surface.
//
//  "Acting as the audio gateway, the host drives the unit's hands-free state machine over an AT
//   modem channel. Standard verbs (AT+BRSF, AT+CIND, AT+CLCC, ATD) plus vendor AT extensions
//   that can surface device state and functions no user-facing interface exposes."
//
//  Runs over ANY IByteChannel — a real RFCOMM socket to the HFP-AG channel, or the legacy
//  virtual COM port. Assembles CR/LF-delimited lines, auto-answers the HF's handshake probes so
//  the unit stays in session, and offers:
//    • interactive AT send + RX log,
//    • incoming-call simulation (RING + +CLIP), incoming-SMS (+CMTI/+CMGR),
//    • a vendor-AT prober that sweeps a battery of standard and OEM AT verbs and records what
//      each returns — the fastest way to surface undocumented state/functions.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TesterPresent.OBD2.Bluetooth
{
    public sealed class HfpAtSession : IDisposable
    {
        private readonly IByteChannel _ch;
        private CancellationTokenSource _cts;
        private CancellationTokenSource _ringCts;
        private string _pendingSmsSender, _pendingSmsBody;

        /// <summary>Raised for every line received (already trimmed of CR/LF). Marshal to UI yourself.</summary>
        public event Action<string> LineReceived;
        /// <summary>Raised for every line transmitted.</summary>
        public event Action<string> LineSent;
        public event Action<string> Log;

        public bool AutoAnswerHandshake { get; set; } = true;
        public bool IsOpen => _ch != null && _ch.IsOpen;

        // The channel has ONE rx queue. When another consumer (OBEX pull, fuzzer) needs to own the
        // channel, pause this reader so it stops draining the queue and stops auto-answering. The
        // caller should settle (~300 ms) and DiscardInput() after pausing, then ResumeReader() when done.
        private volatile bool _paused;
        public void PauseReader() { _paused = true; }
        public void ResumeReader() { _paused = false; }

        public HfpAtSession(IByteChannel channel)
        {
            _ch = channel ?? throw new ArgumentNullException(nameof(channel));
            _cts = new CancellationTokenSource();
            StartReaderLoop(_cts.Token);
        }

        // ── TX ────────────────────────────────────────────────────────────────────────
        public async Task SendLineAsync(string line)
        {
            if (!IsOpen) return;
            byte[] data = Encoding.ASCII.GetBytes(line + "\r\n");
            try { await _ch.WriteAsync(data, 0, data.Length).ConfigureAwait(false); LineSent?.Invoke(line); }
            catch (Exception ex) { Log?.Invoke("HFP send failed: " + ex.Message); }
        }

        // ── Incoming-call simulation (HFP-AG → HF) ───────────────────────────────────────
        public async Task StartRingingAsync(string callerName, string callerNumber)
        {
            try { _ringCts?.Cancel(); } catch { }
            _ringCts = new CancellationTokenSource();
            var ct = _ringCts.Token;
            string num = (callerNumber ?? "").Trim();
            int ton = num.StartsWith("+") ? 145 : 129;
            string numClean = num.TrimStart('+');
            string name = (callerName ?? "").Replace('"', '\'');

            await SendLineAsync("+CIEV: 3,1").ConfigureAwait(false);   // callsetup = incoming
            await SendLineAsync($"+CLIP: \"{numClean}\",{ton},,,\"{name}\"").ConfigureAwait(false);
            while (!ct.IsCancellationRequested)
            {
                await SendLineAsync("RING").ConfigureAwait(false);
                await SendLineAsync($"+CLIP: \"{numClean}\",{ton},,,\"{name}\"").ConfigureAwait(false);
                try { await Task.Delay(3000, ct).ConfigureAwait(false); } catch { break; }
            }
        }

        public async Task EndCallAsync()
        {
            try { _ringCts?.Cancel(); } catch { }
            await SendLineAsync("+CIEV: 3,0").ConfigureAwait(false);   // callsetup idle
            await SendLineAsync("+CIEV: 2,0").ConfigureAwait(false);   // call inactive
            await SendLineAsync("NO CARRIER").ConfigureAwait(false);
        }

        // ── Incoming-SMS simulation (MAP-over-HFP) ───────────────────────────────────────
        public async Task SendSmsNotificationAsync(string sender, string body)
        {
            _pendingSmsSender = (sender ?? "").Trim();
            _pendingSmsBody = body ?? "";
            await SendLineAsync("+CMTI: \"ME\",1").ConfigureAwait(false);
        }

        // ── Vendor-AT probe ──────────────────────────────────────────────────────────────
        public sealed class AtProbeRow { public string Command = ""; public string Response = ""; public bool Ok; }

        /// <summary>Standard + common-OEM AT verbs. Read-only queries — never dials, never edits state.</summary>
        public static readonly string[] ProbeCommands =
        {
            "AT+BRSF=871", "AT+CIND=?", "AT+CIND?", "AT+CMER=3,0,0,1",
            "AT+CGMI", "AT+CGMM", "AT+CGMR", "AT+CGSN", "AT+GMI", "AT+GMM", "AT+GMR", "AT+GCAP",
            "AT+CSCS=?", "AT+CPBS=?", "AT+CPBR=?", "AT+CNUM", "AT+COPS?", "AT+CREG?", "AT+CSQ",
            "AT+CLCC", "AT+CLIP=1", "AT+CCWA=1", "AT+BIND=?", "AT+BIND?", "AT+BIA=?",
            "AT+XAPL=?", "AT+IPHONEACCEV=?", "AT+APLSIRI?",          // Apple accessory extensions
            "AT+XEVENT=?", "AT+CKPD=?", "AT+VGS=?", "AT+VGM=?",
        };

        /// <summary>
        /// Sweep the probe battery, collecting each command's response within perCmdMs. Records a
        /// findings-friendly table. Cancellable. Never dials or writes phonebook/SMS content.
        /// </summary>
        public async Task<List<AtProbeRow>> RunVendorProbeAsync(int perCmdMs, CancellationToken ct, Action<AtProbeRow> onRow = null)
        {
            var rows = new List<AtProbeRow>();
            foreach (var cmd in ProbeCommands)
            {
                if (ct.IsCancellationRequested) break;
                var tcs = new TaskCompletionSource<string>();
                var sb = new StringBuilder();
                var gate = new object();       // serialise the collector (reader thread) vs the reader below
                bool okSeen = false;
                Action<string> collector = line =>
                {
                    lock (gate)
                    {
                        sb.AppendLine(line);
                        string t = line.Trim();
                        if (t == "OK") okSeen = true;   // a terminating OK line, not a substring match
                        if (t == "OK" || t == "ERROR" || t.StartsWith("+CME ERROR") || t.StartsWith("+CMS ERROR"))
                            tcs.TrySetResult(sb.ToString());
                    }
                };
                LineReceived += collector;
                try
                {
                    await SendLineAsync(cmd).ConfigureAwait(false);
                    var completed = await Task.WhenAny(tcs.Task, Task.Delay(perCmdMs, ct)).ConfigureAwait(false);
                    string resp; bool ok;
                    lock (gate) { resp = completed == tcs.Task ? tcs.Task.Result : sb.ToString(); ok = okSeen; }
                    var row = new AtProbeRow { Command = cmd, Response = resp.Trim(), Ok = ok };
                    rows.Add(row);
                    onRow?.Invoke(row);
                }
                catch (Exception ex) { Log?.Invoke("Probe " + cmd + " error: " + ex.Message); }
                finally { LineReceived -= collector; }
            }
            return rows;
        }

        // ── RX ────────────────────────────────────────────────────────────────────────
        private void StartReaderLoop(CancellationToken ct)
        {
            Task.Run(async () =>
            {
                var sb = new StringBuilder();
                var buf = new byte[256];
                while (!ct.IsCancellationRequested)
                {
                    if (_paused) { try { await Task.Delay(30, ct).ConfigureAwait(false); } catch { break; } continue; }
                    int n;
                    try { n = await _ch.ReadAsync(buf, 250).ConfigureAwait(false); }
                    catch { break; }
                    // Drain any buffered bytes before exiting on close, so trailing lines aren't lost.
                    if (n == 0) { if (!_ch.IsOpen) break; else continue; }
                    for (int i = 0; i < n; i++)
                    {
                        char c = (char)buf[i];
                        if (c == '\r' || c == '\n')
                        {
                            if (sb.Length > 0) { string line = sb.ToString(); sb.Clear(); DispatchLine(line); }
                        }
                        else sb.Append(c);
                    }
                }
            }, ct);
        }

        private async void DispatchLine(string line)
        {
            try { LineReceived?.Invoke(line); } catch { }
            if (!AutoAnswerHandshake) return;
            string t = line.Trim();
            try
            {
                if (t.StartsWith("AT+BRSF", StringComparison.OrdinalIgnoreCase)) { await SendLineAsync("+BRSF: 871").ConfigureAwait(false); await SendLineAsync("OK").ConfigureAwait(false); }
                else if (t.StartsWith("AT+CIND=?", StringComparison.OrdinalIgnoreCase)) { await SendLineAsync("+CIND: (\"service\",(0,1)),(\"call\",(0,1)),(\"callsetup\",(0-3)),(\"callheld\",(0-2)),(\"signal\",(0-5)),(\"roam\",(0,1)),(\"battchg\",(0-5))").ConfigureAwait(false); await SendLineAsync("OK").ConfigureAwait(false); }
                else if (t.StartsWith("AT+CIND?", StringComparison.OrdinalIgnoreCase)) { await SendLineAsync("+CIND: 1,0,0,0,5,0,5").ConfigureAwait(false); await SendLineAsync("OK").ConfigureAwait(false); }
                else if (t.StartsWith("ATA", StringComparison.OrdinalIgnoreCase)) { try { _ringCts?.Cancel(); } catch { } await SendLineAsync("+CIEV: 2,1").ConfigureAwait(false); await SendLineAsync("+CIEV: 3,0").ConfigureAwait(false); await SendLineAsync("OK").ConfigureAwait(false); }
                else if (t.StartsWith("AT+CHUP", StringComparison.OrdinalIgnoreCase)) { await EndCallAsync().ConfigureAwait(false); await SendLineAsync("OK").ConfigureAwait(false); }
                else if (t.StartsWith("AT+CMGR", StringComparison.OrdinalIgnoreCase) && _pendingSmsBody != null)
                {
                    string s = (_pendingSmsSender ?? "").TrimStart('+');
                    string ts = DateTime.Now.ToString("yy/MM/dd,HH:mm:ss");
                    await SendLineAsync($"+CMGR: \"REC UNREAD\",\"{s}\",,\"{ts}\"").ConfigureAwait(false);
                    await SendLineAsync(_pendingSmsBody).ConfigureAwait(false);
                    await SendLineAsync("OK").ConfigureAwait(false);
                }
                else if (t.StartsWith("AT", StringComparison.OrdinalIgnoreCase)) { await SendLineAsync("OK").ConfigureAwait(false); }
            }
            catch (Exception ex) { Log?.Invoke("HFP auto-answer error: " + ex.Message); }
        }

        public void Dispose()
        {
            try { _ringCts?.Cancel(); } catch { }
            try { _ringCts?.Dispose(); } catch { }
            try { _cts?.Cancel(); } catch { }
            try { _cts?.Dispose(); } catch { }
        }
    }
}
