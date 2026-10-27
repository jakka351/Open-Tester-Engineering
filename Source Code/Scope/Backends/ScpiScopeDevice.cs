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
//  Tester Present Specialist Automotive Solutions — USB Oscilloscope HAL: generic SCPI backend
//  Copyright (c) 2026 Benjamin Jack Leighton. All rights reserved.
//
//  Zero-dependency breadth backend (report §02): plain SCPI text commands over a virtual COM
//  port (OWON VDS, many bench scopes) or a raw LXI TCP socket (Rigol port 5555, Siglent 5025).
//  No VISA, no vendor binaries. Dialect follows the Rigol DS1000Z convention, which the other
//  majors accept for the core :CHAN / :TRIG / :WAV set; every command failure degrades to a
//  fault event rather than a crash, because bench-scope SCPI dialects drift.
//
//  Probe attenuation note: unlike the Pico/Hantek backends, :CHAN<n>:PROB is pushed TO the
//  instrument and the returned preamble (YINC/YOR/YREF) already includes it — so this backend
//  must NOT multiply ProbeAttenuation locally or probes would scale twice.
//
//  Streaming: SCPI scopes have no continuous-sample stream. SupportsStreaming=false; the UI's
//  Run mode falls back to repeated block captures, which is how these instruments refresh
//  their own screens anyway.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TesterPresent.OBD2.Scope
{
    // ---- transports ------------------------------------------------------------------------

    internal interface IScpiTransport : IDisposable
    {
        void WriteLine(string cmd);
        string ReadLine(int timeoutMs);
        int ReadRaw(byte[] buf, int offset, int count, int timeoutMs);
        string Describe();
    }

    internal sealed class ScpiSerialTransport : IScpiTransport
    {
        private readonly SerialPort _port;

        public ScpiSerialTransport(string portName, int baud)
        {
            _port = new SerialPort(portName, baud, Parity.None, 8, StopBits.One)
            {
                NewLine = "\n",
                ReadTimeout = 2000,
                WriteTimeout = 2000,
                ReadBufferSize = 1 << 20,
            };
            _port.Open();
        }

        public void WriteLine(string cmd) => _port.WriteLine(cmd);

        public string ReadLine(int timeoutMs)
        {
            _port.ReadTimeout = timeoutMs;
            return _port.ReadLine();
        }

        public int ReadRaw(byte[] buf, int offset, int count, int timeoutMs)
        {
            _port.ReadTimeout = timeoutMs;
            return _port.Read(buf, offset, count);
        }

        public string Describe() => _port.PortName;
        public void Dispose() { try { _port.Close(); } catch { } _port.Dispose(); }
    }

    internal sealed class ScpiTcpTransport : IScpiTransport
    {
        private readonly TcpClient _client;
        private readonly NetworkStream _stream;
        private readonly string _endpoint;

        public ScpiTcpTransport(string host, int port)
        {
            _endpoint = $"{host}:{port}";
            _client = new TcpClient { ReceiveBufferSize = 1 << 20, NoDelay = true };
            if (!_client.ConnectAsync(host, port).Wait(3000))
                throw new IOException($"SCPI TCP connect to {_endpoint} timed out.");
            _stream = _client.GetStream();
        }

        public void WriteLine(string cmd)
        {
            var bytes = Encoding.ASCII.GetBytes(cmd + "\n");
            _stream.Write(bytes, 0, bytes.Length);
        }

        public string ReadLine(int timeoutMs)
        {
            _stream.ReadTimeout = timeoutMs;
            var sb = new StringBuilder(64);
            int b;
            while ((b = _stream.ReadByte()) >= 0)
            {
                if (b == '\n') return sb.ToString();
                if (b != '\r') sb.Append((char)b);
            }
            throw new IOException($"SCPI TCP {_endpoint}: connection closed mid-read.");
        }

        public int ReadRaw(byte[] buf, int offset, int count, int timeoutMs)
        {
            _stream.ReadTimeout = timeoutMs;
            return _stream.Read(buf, offset, count);
        }

        public string Describe() => _endpoint;
        public void Dispose() { try { _stream?.Dispose(); } catch { } try { _client?.Close(); } catch { } }
    }

    // ---- device ----------------------------------------------------------------------------

    public sealed class ScpiScopeDevice : IScopeDevice
    {
        private const string HANDLE_SERIAL_PREFIX = "serial:";   // "serial:COM7@115200"
        private const string HANDLE_TCP_PREFIX = "tcp:";         // "tcp:192.168.1.50:5555"

        private readonly object _ioLock = new object();
        // Config is stored under its own lock and pushed to the instrument at capture start —
        // the UI must never block behind a capture holding _ioLock (which can be seconds).
        private readonly object _cfgLock = new object();
        private IScpiTransport _io;
        private ChannelConfig[] _channels = Array.Empty<ChannelConfig>();
        private TriggerConfig _trigger = new TriggerConfig();
        private bool _cfgDirty = true;

        public event EventHandler<ScopeFaultEventArgs> Fault;

        public ScopeCapabilities Capabilities { get; private set; } = new ScopeCapabilities();
        public ScopeDeviceInfo DeviceInfo { get; private set; }
        public bool IsOpen => _io != null;

        public static ScopeDeviceInfo MakeSerialInfo(string portName, int baud = 115200) => new ScopeDeviceInfo
        {
            Backend = ScopeBackendKind.Scpi,
            DisplayName = $"SCPI scope @ {portName}",
            VendorHandle = $"{HANDLE_SERIAL_PREFIX}{portName}@{baud}",
            Detail = "Generic SCPI over virtual COM (unprobed until connect)",
        };

        public static ScopeDeviceInfo MakeTcpInfo(string host, int port) => new ScopeDeviceInfo
        {
            Backend = ScopeBackendKind.Scpi,
            DisplayName = $"SCPI scope @ {host}:{port}",
            VendorHandle = $"{HANDLE_TCP_PREFIX}{host}:{port}",
            Detail = "Generic SCPI over LXI socket",
        };

        private void RaiseFault(ScopeFaultKind kind, string msg)
            => Fault?.Invoke(this, new ScopeFaultEventArgs(kind, msg));

        // ---- open / close -------------------------------------------------------------------

        public Task<bool> OpenAsync(ScopeDeviceInfo device)
        {
            return Task.Run(() =>
            {
                lock (_ioLock)
                {
                    Close();
                    try
                    {
                        string h = device?.VendorHandle ?? "";
                        if (h.StartsWith(HANDLE_SERIAL_PREFIX, StringComparison.Ordinal))
                        {
                            var spec = h.Substring(HANDLE_SERIAL_PREFIX.Length).Split('@');
                            int baud = spec.Length > 1 && int.TryParse(spec[1], out var b) ? b : 115200;
                            _io = new ScpiSerialTransport(spec[0], baud);
                        }
                        else if (h.StartsWith(HANDLE_TCP_PREFIX, StringComparison.Ordinal))
                        {
                            var spec = h.Substring(HANDLE_TCP_PREFIX.Length);
                            int colon = spec.LastIndexOf(':');
                            _io = new ScpiTcpTransport(spec.Substring(0, colon), int.Parse(spec.Substring(colon + 1)));
                        }
                        else
                        {
                            RaiseFault(ScopeFaultKind.DriverError, $"Unrecognised SCPI handle '{h}'.");
                            return false;
                        }

                        _io.WriteLine("*IDN?");
                        string idn = _io.ReadLine(2500).Trim();
                        if (idn.Length == 0) throw new IOException("Empty *IDN? response.");

                        // "RIGOL TECHNOLOGIES,DS1054Z,DS1ZA0000000,00.04.04" — field 2 is the model.
                        var idnParts = idn.Split(',');
                        string model = idnParts.Length > 1 ? idnParts[1].Trim() : idn;

                        int chCount = GuessChannelCount(model);
                        _channels = new ChannelConfig[chCount];
                        for (int i = 0; i < chCount; i++)
                            _channels[i] = new ChannelConfig { Enabled = i == 0 };

                        Capabilities = new ScopeCapabilities
                        {
                            ChannelCount = chCount,
                            MaxSampleRateHz = 0,     // unknowable generically; true rate read back per capture via :WAV:XINC?
                            BufferDepthSamples = 250_000,
                            ResolutionBits = 8,
                            SupportsStreaming = false,
                            InputRangesVolts = new[] { 0.008, 0.016, 0.04, 0.08, 0.16, 0.4, 0.8, 1.6, 4.0, 8.0, 16.0, 40.0 },
                        };

                        DeviceInfo = new ScopeDeviceInfo
                        {
                            Backend = ScopeBackendKind.Scpi,
                            DisplayName = $"{model} [{_io.Describe()}]",
                            VendorHandle = device.VendorHandle,
                            Detail = idn,
                        };
                        return true;
                    }
                    catch (Exception ex)
                    {
                        RaiseFault(ScopeFaultKind.DriverError, $"SCPI open failed: {ex.Message}");
                        Close();
                        return false;
                    }
                }
            });
        }

        private static int GuessChannelCount(string model)
        {
            // Rigol/Siglent/OWON convention: last digit of the numeric family is the channel
            // count (DS1054Z→4, SDS1202X→2). Fall back to 2; a wrong guess only greys a
            // channel row — the instrument rejects :CHAN3 cleanly on a 2-channel unit.
            for (int i = model.Length - 1; i >= 0; i--)
            {
                if (model[i] == '4') return 4;
                if (model[i] == '2') return 2;
            }
            return 2;
        }

        public void Close()
        {
            lock (_ioLock)
            {
                _io?.Dispose();
                _io = null;
            }
        }

        public void Dispose() => Close();

        // ---- helpers ------------------------------------------------------------------------

        private void Cmd(string cmd)
        {
            _io.WriteLine(cmd);
        }

        private string Query(string cmd, int timeoutMs = 2000)
        {
            _io.WriteLine(cmd);
            return _io.ReadLine(timeoutMs).Trim();
        }

        private double QueryDouble(string cmd, double fallback)
        {
            try
            {
                var s = Query(cmd);
                return double.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out var v) ? v : fallback;
            }
            catch { return fallback; }
        }

        /// <summary>Reads an IEEE 488.2 definite-length block (#&lt;n&gt;&lt;len&gt;&lt;bytes&gt;) after a :WAV:DATA? query.</summary>
        private byte[] ReadDefiniteBlock(int timeoutMs)
        {
            var one = new byte[1];
            // Hunt for '#' — some firmwares emit a stray newline first.
            for (int guard = 0; guard < 8; guard++)
            {
                if (_io.ReadRaw(one, 0, 1, timeoutMs) != 1) throw new IOException("SCPI block: no data.");
                if (one[0] == (byte)'#') break;
                if (guard == 7) throw new IOException("SCPI block: '#' header not found.");
            }
            if (_io.ReadRaw(one, 0, 1, timeoutMs) != 1) throw new IOException("SCPI block: truncated header.");
            int nDigits = one[0] - '0';
            if (nDigits < 1 || nDigits > 9) throw new IOException("SCPI block: bad length-digit count.");
            var lenBuf = new byte[nDigits];
            int got = 0;
            while (got < nDigits)
            {
                // NetworkStream.Read returns 0 (no exception) after a graceful remote close —
                // treat ≤0 as truncation or this loop spins forever at 100% CPU holding _ioLock.
                int r = _io.ReadRaw(lenBuf, got, nDigits - got, timeoutMs);
                if (r <= 0) throw new IOException("SCPI block: truncated length header.");
                got += r;
            }
            int len = int.Parse(Encoding.ASCII.GetString(lenBuf), CultureInfo.InvariantCulture);
            var data = new byte[len];
            got = 0;
            while (got < len)
            {
                int r = _io.ReadRaw(data, got, len - got, timeoutMs);
                if (r <= 0) throw new IOException("SCPI block: truncated payload.");
                got += r;
            }
            // Trailing newline (best effort — some units omit it).
            try { _io.ReadRaw(one, 0, 1, 100); } catch { }
            return data;
        }

        // ---- configuration ------------------------------------------------------------------

        public void ConfigureChannel(int ch, ChannelConfig cfg)
        {
            if (ch < 0 || ch >= _channels.Length || cfg == null) return;
            lock (_cfgLock)
            {
                _channels[ch] = cfg.Clone();
                _cfgDirty = true;
            }
        }

        public void ConfigureTrigger(TriggerConfig cfg)
        {
            if (cfg == null) return;
            lock (_cfgLock)
            {
                _trigger = cfg.Clone();
                _cfgDirty = true;
            }
        }

        /// <summary>Push stored channel + trigger config to the instrument. Call under _ioLock.</summary>
        private void ApplyConfigLocked(ChannelConfig[] chans, TriggerConfig trig)
        {
            try
            {
                for (int ch = 0; ch < chans.Length; ch++)
                {
                    var cfg = chans[ch];
                    int n = ch + 1;
                    Cmd($":CHAN{n}:DISP {(cfg.Enabled ? "ON" : "OFF")}");
                    if (!cfg.Enabled) continue;
                    // 8 vertical divisions: ±range = 4 div each side. PROB first — the
                    // instrument rescales its SCAL/LEV ranges by the probe factor, and both
                    // SCAL and LEV are in displayed (probe-included) volts.
                    Cmd($":CHAN{n}:PROB {cfg.ProbeAttenuation.ToString(CultureInfo.InvariantCulture)}");
                    Cmd($":CHAN{n}:COUP {(cfg.Coupling == ScopeCoupling.AC ? "AC" : "DC")}");
                    Cmd($":CHAN{n}:SCAL {(cfg.RangeVolts / 4.0 * cfg.ProbeAttenuation).ToString("G6", CultureInfo.InvariantCulture)}");
                    Cmd($":CHAN{n}:OFFS {cfg.AnalogOffsetVolts.ToString("G6", CultureInfo.InvariantCulture)}");
                }

                Cmd(":TRIG:MODE EDGE");
                if (trig.Enabled && trig.SourceChannel >= 0 && trig.SourceChannel < chans.Length)
                {
                    Cmd($":TRIG:EDGE:SOUR CHAN{trig.SourceChannel + 1}");
                    Cmd($":TRIG:EDGE:SLOP {(trig.Slope == TriggerSlope.Falling ? "NEG" : "POS")}");
                    Cmd($":TRIG:EDGE:LEV {trig.LevelVolts.ToString("G6", CultureInfo.InvariantCulture)}");
                }
                Cmd($":TRIG:SWE {(trig.Mode == TriggerMode.Normal ? "NORM" : trig.Mode == TriggerMode.Single ? "SING" : "AUTO")}");
            }
            catch (Exception ex)
            {
                RaiseFault(ScopeFaultKind.DriverError, $"SCPI config push: {ex.Message}");
            }
        }

        // ---- block capture ------------------------------------------------------------------

        public Task<CaptureBlock> CaptureBlockAsync(BlockRequest req, CancellationToken ct)
        {
            return Task.Run(() =>
            {
                lock (_ioLock)
                {
                    if (_io == null) throw new InvalidOperationException("SCPI scope not open.");

                    ChannelConfig[] setup;
                    TriggerConfig trig;
                    bool dirty;
                    lock (_cfgLock)
                    {
                        setup = SnapshotSetupLocked();
                        trig = _trigger.Clone();
                        dirty = _cfgDirty;
                        _cfgDirty = false;
                    }
                    if (dirty) ApplyConfigLocked(setup, trig);

                    // Timebase: 10 horizontal divisions → window = n·dt, scale = window / 10.
                    double window = req.SampleCount * req.SampleIntervalSeconds;
                    Cmd($":TIM:SCAL {(window / 10.0).ToString("G6", CultureInfo.InvariantCulture)}");

                    Cmd(trig.Mode == TriggerMode.Single ? ":SING" : ":RUN");
                    long armedQpc = ScopeClock.Timestamp();

                    // Wait for a sweep: TD/STOP mean data is ready; AUTO free-runs so a short settle is enough.
                    var deadline = DateTime.UtcNow + TimeSpan.FromSeconds(Math.Max(2, window * 4 + 1));
                    while (true)
                    {
                        ct.ThrowIfCancellationRequested();
                        string st;
                        try { st = Query(":TRIG:STAT?", 1000).ToUpperInvariant(); }
                        catch { st = "?"; }
                        if (st.StartsWith("TD") || st.StartsWith("STOP") || st.StartsWith("AUTO")) break;
                        if (DateTime.UtcNow > deadline)
                        {
                            if (trig.Mode == TriggerMode.Normal || trig.Mode == TriggerMode.Single)
                                throw new TimeoutException("SCPI: no trigger within timeout.");
                            break;
                        }
                        Thread.Sleep(50);
                    }

                    // Freeze the acquisition so every channel reads the SAME sweep (and so RAW
                    // memory readout is legal — most dialects reject RAW while running).
                    bool stopped = false;
                    if (trig.Mode != TriggerMode.Single)
                    {
                        try { Cmd(":STOP"); stopped = true; } catch { }
                    }

                    var block = new CaptureBlock
                    {
                        ChannelSamples = new float[setup.Length][],
                        SampleIntervalSeconds = req.SampleIntervalSeconds,
                        TriggerIndex = -1,
                        Overrange = new bool[setup.Length],
                        QpcTimestamp = armedQpc,
                        UtcTimestamp = DateTime.UtcNow,
                        ChannelSetup = setup,
                    };

                    double xorSeconds = double.NaN;
                    try
                    {
                        for (int c = 0; c < setup.Length; c++)
                        {
                            if (!setup[c].Enabled) continue;
                            ct.ThrowIfCancellationRequested();
                            try
                            {
                                Cmd($":WAV:SOUR CHAN{c + 1}");
                                Cmd(":WAV:FORM BYTE");

                                // RAW = full acquisition memory (chunked); NORM = ~1200 screen
                                // points. Try RAW first so the advertised depth is real; fall
                                // back for dialects without RAW.
                                double xinc;
                                float[] volts = null;
                                try { volts = ReadWaveform("RAW", req, ct, out xinc); }
                                catch { xinc = 0; }
                                if (volts == null || volts.Length == 0)
                                    volts = ReadWaveform("NORM", req, ct, out xinc);

                                block.ChannelSamples[c] = volts;
                                if (xinc > 0) block.SampleIntervalSeconds = xinc;
                                if (double.IsNaN(xorSeconds))
                                    xorSeconds = QueryDouble(":WAV:XOR?", double.NaN);
                            }
                            catch (Exception ex)
                            {
                                RaiseFault(ScopeFaultKind.DriverError, $"SCPI CH{c + 1} readout: {ex.Message}");
                            }
                        }
                    }
                    finally
                    {
                        if (stopped)
                        {
                            try { Cmd(":RUN"); } catch { }
                        }
                    }

                    if (trig.Enabled && block.SampleCount > 0)
                    {
                        // XORigin = time of the first returned point relative to the trigger.
                        int idx = !double.IsNaN(xorSeconds) && block.SampleIntervalSeconds > 0
                            ? (int)Math.Round(-xorSeconds / block.SampleIntervalSeconds)
                            : block.SampleCount / 2;
                        block.TriggerIndex = Math.Max(0, Math.Min(block.SampleCount - 1, idx));
                    }
                    return block;
                }
            }, ct);
        }

        /// <summary>
        /// Read one channel's waveform in the given :WAV:MODE, chunking RAW reads through
        /// :WAV:STAR/:WAV:STOP (1-based). Returns volts via the Rigol preamble formula
        /// V = (raw − YREF − YOR) × YINC; the preamble already includes probe attenuation.
        /// </summary>
        private float[] ReadWaveform(string mode, BlockRequest req, CancellationToken ct, out double xinc)
        {
            Cmd($":WAV:MODE {mode}");
            xinc = QueryDouble(":WAV:XINC?", req.SampleIntervalSeconds);
            double yinc = QueryDouble(":WAV:YINC?", 1.0);
            double yor = QueryDouble(":WAV:YOR?", 0.0);
            double yref = QueryDouble(":WAV:YREF?", 128.0);

            byte[] raw;
            if (mode == "RAW")
            {
                int want = Math.Min(req.SampleCount, 250_000);
                using (var ms = new MemoryStream(want))
                {
                    int pos = 1;   // :WAV:STAR is 1-based
                    while (pos <= want)
                    {
                        ct.ThrowIfCancellationRequested();
                        int end = Math.Min(pos + 125_000 - 1, want);
                        int expected = end - pos + 1;
                        Cmd($":WAV:STAR {pos}");
                        Cmd($":WAV:STOP {end}");
                        Cmd(":WAV:DATA?");
                        byte[] chunk = ReadDefiniteBlock(8000);
                        if (chunk.Length == 0) break;
                        ms.Write(chunk, 0, chunk.Length);
                        pos += chunk.Length;
                        if (chunk.Length < expected) break;   // short chunk = end of acquisition memory
                    }
                    raw = ms.ToArray();
                }
                if (raw.Length == 0) return Array.Empty<float>();
            }
            else
            {
                Cmd(":WAV:DATA?");
                raw = ReadDefiniteBlock(5000);
            }

            var volts = new float[raw.Length];
            for (int i = 0; i < raw.Length; i++)
                volts[i] = (float)((raw[i] - yref - yor) * yinc);
            return volts;
        }

        private ChannelConfig[] SnapshotSetupLocked()
        {
            var setup = new ChannelConfig[_channels.Length];
            for (int i = 0; i < _channels.Length; i++) setup[i] = _channels[i].Clone();
            return setup;
        }

        public IScopeStream OpenStream(StreamRequest req)
            => throw new NotSupportedException("SCPI scopes cannot stream continuously — use repeated block captures.");
    }
}
