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
//  Tester Present Specialist Automotive Solutions — USB Oscilloscope HAL: Hantek 6022 backend
//  Copyright (c) 2026 Benjamin Jack Leighton. All rights reserved.
//
//  Budget-tier, best-effort backend (report §02). Talks the community-documented 6022BE/BL
//  USB protocol directly over WinUSB — no Hantek vendor DLLs, which sidesteps their x86-only
//  binaries entirely. Register map and code tables are from the sigrok hantek-6xxx driver
//  (protocol.h): vendor control requests 0xE0/0xE1 = CH1/CH2 gain, 0xE2 = sample rate,
//  0xE3 = acquisition start/stop, 0xE4 = channel count, 0xE5 = coupling (later hw revisions);
//  samples arrive on bulk IN endpoint 0x86 as unsigned bytes, mid-scale 0x80, interleaved
//  CH1/CH2 in two-channel mode.
//
//  Constraints owned honestly:
//    • No hardware trigger — block capture reads a window and soft-triggers in software.
//    • No calibration EEPROM readout — expect a few % gain/offset error vs a bench meter.
//    • Requires the device bound to the WinUSB driver (Zadig). The stock Hantek driver is
//      reported as unavailable with that exact hint rather than failing cryptically.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace TesterPresent.OBD2.Scope
{
    public sealed class Hantek6022Device : IScopeDevice
    {
        // sigrok hantek-6xxx protocol.h register map.
        private const byte VDIV_CH1_REG = 0xE0;
        private const byte VDIV_CH2_REG = 0xE1;
        private const byte SAMPLERATE_REG = 0xE2;
        private const byte TRIGGER_REG = 0xE3;
        private const byte CHANNELS_REG = 0xE4;
        private const byte COUPLING_REG = 0xE5;
        private const byte BULK_EP_IN = 0x86;

        // Rate register codes (sigrok): value ≥ 1 is MHz directly; 50/20/10 encode kHz rates.
        private static readonly (long hz, byte code)[] RATES =
        {
            (48_000_000, 48), (30_000_000, 30), (24_000_000, 24), (16_000_000, 16),
            (8_000_000, 8), (4_000_000, 4), (1_000_000, 1),
            (500_000, 50), (200_000, 20), (100_000, 10),
        };

        // Gain codes (sigrok VDIV_REG/VDIV_VALUES): code 1→±5 V, 2→±2.5 V, 5→±1 V, 10→±0.5 V.
        private static readonly (double fullScaleVolts, byte code)[] GAINS =
        {
            (5.0, 1), (2.5, 2), (1.0, 5), (0.5, 10),
        };

        private static readonly (ushort vid, ushort pid, string name)[] KNOWN_IDS =
        {
            (0x04B4, 0x6022, "Hantek 6022BE"),
            (0x04B5, 0x6022, "Hantek 6022BE (alt fw)"),
            (0x04B4, 0x602A, "Hantek 6022BL"),
            (0x04B5, 0x602A, "Hantek 6022BL (alt fw)"),
            (0x1D50, 0x608E, "Hantek 6022 (fx2lafw fw)"),
        };

        private readonly object _ioLock = new object();
        // Config store has its own lock so the UI never blocks behind a long bulk capture
        // that holds _ioLock (stored config is applied at the next capture/stream start).
        private readonly object _cfgLock = new object();
        private SafeFileHandle _file;
        private IntPtr _winusb = IntPtr.Zero;
        private readonly ChannelConfig[] _channels =
        {
            new ChannelConfig { Enabled = true }, new ChannelConfig(),
        };
        private readonly byte[] _appliedGainCode = { 1, 1 };
        private TriggerConfig _trigger = new TriggerConfig();
        private long _appliedRateHz = 1_000_000;
        private Hantek6022Stream _activeStream;

        public event EventHandler<ScopeFaultEventArgs> Fault;

        public ScopeCapabilities Capabilities { get; } = new ScopeCapabilities
        {
            ChannelCount = 2,
            MaxSampleRateHz = 48_000_000,
            BufferDepthSamples = 4_000_000,
            ResolutionBits = 8,
            SupportsStreaming = true,
            // One shared byte pipe: two active channels halve the per-channel rate (report §06).
            RatePerActiveChannels = new long[] { 48_000_000, 24_000_000 },
            InputRangesVolts = new[] { 0.5, 1.0, 2.5, 5.0 },
        };

        public ScopeDeviceInfo DeviceInfo { get; private set; }
        public bool IsOpen => _winusb != IntPtr.Zero;

        internal void RaiseFault(ScopeFaultKind kind, string msg)
            => Fault?.Invoke(this, new ScopeFaultEventArgs(kind, msg));

        // ---- enumeration --------------------------------------------------------------------

        public static ScopeDeviceInfo[] Enumerate()
        {
            var list = new List<ScopeDeviceInfo>();
            foreach (var (vid, pid, name) in KNOWN_IDS)
            {
                foreach (var path in WinUsbInterop.FindDevicePaths(vid, pid))
                {
                    list.Add(new ScopeDeviceInfo
                    {
                        Backend = ScopeBackendKind.Hantek6022,
                        DisplayName = name,
                        VendorHandle = path,
                        Detail = "WinUSB (bind with Zadig if connect fails); software trigger; uncalibrated",
                    });
                }
            }
            return list.ToArray();
        }

        // ---- open / close -------------------------------------------------------------------

        public Task<bool> OpenAsync(ScopeDeviceInfo device)
        {
            return Task.Run(() =>
            {
                lock (_ioLock)
                {
                    Close();
                    string error;
                    if (!WinUsbInterop.TryOpen(device.VendorHandle, out _file, out _winusb, out error))
                    {
                        _winusb = IntPtr.Zero;
                        RaiseFault(ScopeFaultKind.DriverError, $"{device.DisplayName}: {error}");
                        return false;
                    }
                    uint timeoutMs = 1000;
                    WinUsbInterop.WinUsb_SetPipePolicy(_winusb, BULK_EP_IN, WinUsbInterop.PIPE_TRANSFER_TIMEOUT, 4, ref timeoutMs);
                    DeviceInfo = device;
                    return true;
                }
            });
        }

        public void Close()
        {
            // Stop the stream BEFORE taking _ioLock: the pump thread needs the lock to
            // finish its current bulk read, and Stop() joins it.
            _activeStream?.Stop();
            lock (_ioLock)
            {
                if (_winusb != IntPtr.Zero)
                {
                    try { WriteReg(TRIGGER_REG, 0); } catch { }
                    WinUsbInterop.WinUsb_Free(_winusb);
                    _winusb = IntPtr.Zero;
                }
                _file?.Dispose();
                _file = null;
            }
        }

        public void Dispose() => Close();

        // ---- register I/O -------------------------------------------------------------------

        private void WriteReg(byte reg, byte value)
        {
            var packet = new WinUsbInterop.WINUSB_SETUP_PACKET
            {
                RequestType = 0x40,   // vendor | host-to-device | device
                Request = reg,
                Value = 0,
                Index = 0,
                Length = 1,
            };
            uint sent;
            if (!WinUsbInterop.WinUsb_ControlTransfer(_winusb, packet, new[] { value }, 1, out sent, IntPtr.Zero) || sent != 1)
                throw new InvalidOperationException($"Hantek control write 0x{reg:X2}={value} failed.");
        }

        // ---- configuration ------------------------------------------------------------------

        public void ConfigureChannel(int ch, ChannelConfig cfg)
        {
            if (ch < 0 || ch > 1 || cfg == null) return;
            lock (_cfgLock) _channels[ch] = cfg.Clone();
        }

        public void ConfigureTrigger(TriggerConfig cfg)
        {
            if (cfg == null) return;
            lock (_cfgLock) _trigger = cfg.Clone();
        }

        private int ActiveChannelCount()
        {
            lock (_cfgLock) return _channels[1].Enabled ? 2 : 1;
        }

        /// <summary>Push rate/gain/channel-count registers. Call under _ioLock with the device open.</summary>
        private void ApplyConfig(double desiredIntervalSeconds)
        {
            ChannelConfig[] chans;
            lock (_cfgLock) chans = new[] { _channels[0].Clone(), _channels[1].Clone() };
            int chCount = chans[1].Enabled ? 2 : 1;

            long desiredHz = desiredIntervalSeconds > 0 ? (long)(1.0 / desiredIntervalSeconds) : 1_000_000;
            // The rate register sets the SHARED byte rate; two channels halve each channel's rate.
            long desiredShared = desiredHz * chCount;
            // Start from the FASTEST entry so a request beyond 48 MS/s clamps to the device
            // maximum rather than falling through to the 100 kS/s initialiser.
            var best = RATES[0];
            foreach (var r in RATES)
            {
                // Smallest table rate ≥ requested (table is descending) — prefer not to undersample.
                if (r.hz >= desiredShared) best = r;
            }
            WriteReg(SAMPLERATE_REG, best.code);
            _appliedRateHz = best.hz;

            WriteReg(CHANNELS_REG, (byte)chCount);

            for (int c = 0; c < 2; c++)
            {
                var g = GAINS[0];
                foreach (var cand in GAINS)
                {
                    // Smallest full-scale ≥ requested range (table is descending in fullScale).
                    if (cand.fullScaleVolts >= chans[c].RangeVolts) g = cand;
                }
                _appliedGainCode[c] = g.code;
                WriteReg(c == 0 ? VDIV_CH1_REG : VDIV_CH2_REG, g.code);
            }

            // Coupling register only exists on later hardware revisions — best effort, DC otherwise.
            try
            {
                byte coup = (byte)((chans[0].Coupling == ScopeCoupling.AC ? 0x01 : 0x00)
                                 | (chans[1].Coupling == ScopeCoupling.AC ? 0x02 : 0x00));
                WriteReg(COUPLING_REG, coup);
            }
            catch { /* 6022BE early revisions: DC only */ }
        }

        private static double FullScaleFor(byte gainCode)
        {
            foreach (var g in GAINS) if (g.code == gainCode) return g.fullScaleVolts;
            return 5.0;
        }

        private float[] BytesToVolts(byte[] interleaved, int channel, int chCount, int maxSamples, double probeAttenuation)
        {
            int available = interleaved.Length / chCount;
            int n = Math.Min(available, maxSamples);
            double scale = FullScaleFor(_appliedGainCode[channel]) / 128.0 * probeAttenuation;
            var dst = new float[n];
            for (int i = 0; i < n; i++)
                dst[i] = (float)((interleaved[i * chCount + channel] - 128) * scale);
            return dst;
        }

        // ---- block capture ------------------------------------------------------------------

        public Task<CaptureBlock> CaptureBlockAsync(BlockRequest req, CancellationToken ct)
        {
            return Task.Run(() =>
            {
                lock (_ioLock)
                {
                    if (!IsOpen) throw new InvalidOperationException("Hantek 6022 not open.");
                    ApplyConfig(req.SampleIntervalSeconds);
                    var setup = SnapshotSetup();
                    int chCount = setup[1].Enabled ? 2 : 1;
                    int n = Math.Min(req.SampleCount, (int)Capabilities.BufferDepthSamples);

                    // 2× overscan so the soft trigger can centre per PreTriggerFraction.
                    long wantBytes = (long)n * 2 * chCount;
                    wantBytes = (wantBytes + 511) / 512 * 512;
                    var raw = new byte[wantBytes];

                    WriteReg(TRIGGER_REG, 1);
                    long qpcStart = ScopeClock.Timestamp();
                    try
                    {
                        int got = 0;
                        var chunk = new byte[65536];
                        while (got < raw.Length)
                        {
                            ct.ThrowIfCancellationRequested();
                            uint read;
                            if (!WinUsbInterop.WinUsb_ReadPipe(_winusb, BULK_EP_IN, chunk,
                                    (uint)Math.Min(chunk.Length, raw.Length - got), out read, IntPtr.Zero) || read == 0)
                                throw new InvalidOperationException("Hantek bulk read failed/timed out — check WinUSB binding and cable.");
                            Array.Copy(chunk, 0, raw, got, read);
                            got += (int)read;
                        }
                    }
                    finally
                    {
                        try { WriteReg(TRIGGER_REG, 0); } catch { }
                        try { WinUsbInterop.WinUsb_FlushPipe(_winusb, BULK_EP_IN); } catch { }
                    }

                    double perChannelDt = chCount / (double)_appliedRateHz;
                    var full = new float[2][];
                    for (int c = 0; c < chCount; c++)
                        if (setup[c].Enabled) full[c] = BytesToVolts(raw, c, chCount, n * 2, setup[c].ProbeAttenuation);

                    // Software trigger on the source channel, then window n samples around it.
                    // LevelVolts is in displayed volts — same domain as BytesToVolts output.
                    int trigAt = -1;
                    TriggerConfig t;
                    lock (_cfgLock) t = _trigger.Clone();
                    if (t.Enabled && t.SourceChannel >= 0 && t.SourceChannel < 2 && full[t.SourceChannel] != null)
                    {
                        var src = full[t.SourceChannel];
                        float level = (float)t.LevelVolts;
                        for (int i = 1; i < src.Length; i++)
                        {
                            bool rising = src[i - 1] < level && src[i] >= level;
                            bool falling = src[i - 1] > level && src[i] <= level;
                            if ((t.Slope == TriggerSlope.Rising && rising)
                                || (t.Slope == TriggerSlope.Falling && falling)
                                || (t.Slope == TriggerSlope.Either && (rising || falling)))
                            { trigAt = i; break; }
                        }
                    }
                    int pre = (int)(n * Math.Min(Math.Max(t.PreTriggerFraction, 0), 1));
                    int start = trigAt >= 0 ? Math.Max(0, Math.Min(trigAt - pre, n)) : 0;

                    var block = new CaptureBlock
                    {
                        ChannelSamples = new float[2][],
                        SampleIntervalSeconds = perChannelDt,
                        TriggerIndex = trigAt >= 0 ? trigAt - start : -1,
                        Overrange = new bool[2],
                        QpcTimestamp = qpcStart,
                        UtcTimestamp = DateTime.UtcNow,
                        ChannelSetup = setup,
                    };
                    for (int c = 0; c < 2; c++)
                    {
                        if (full[c] == null) continue;
                        int len = Math.Min(n, full[c].Length - start);
                        var dst = new float[len];
                        Array.Copy(full[c], start, dst, 0, len);
                        block.ChannelSamples[c] = dst;
                        // Rail clip = overrange. Detect on the RAW bytes: 0x00 / 0xFF are the ADC
                        // rails (the positive rail converts to 0.992·fs, so a volts-domain
                        // threshold above that can never catch positive clipping).
                        for (int i = 0; i < len; i++)
                        {
                            byte b = raw[(start + i) * chCount + c];
                            if (b == 0x00 || b == 0xFF) { block.Overrange[c] = true; break; }
                        }
                    }
                    return block;
                }
            }, ct);
        }

        private ChannelConfig[] SnapshotSetup()
        {
            var setup = new ChannelConfig[2];
            lock (_cfgLock)
            {
                for (int i = 0; i < 2; i++)
                {
                    setup[i] = _channels[i].Clone();
                    setup[i].RangeVolts = FullScaleFor(_appliedGainCode[i]);
                }
            }
            return setup;
        }

        // ---- streaming ----------------------------------------------------------------------

        public IScopeStream OpenStream(StreamRequest req)
        {
            if (!IsOpen) throw new InvalidOperationException("Hantek 6022 not open.");
            return _activeStream = new Hantek6022Stream(this, req);
        }

        private sealed class Hantek6022Stream : IScopeStream
        {
            private readonly Hantek6022Device _dev;
            private readonly StreamRequest _req;
            private ScopeRingBuffer[] _rings;
            private ChannelConfig[] _setup;
            private int _chCount;
            private Thread _thread;
            private volatile bool _run;
            private long _total;
            private double _actualDt;

            public event EventHandler Overrun;

            public Hantek6022Stream(Hantek6022Device dev, StreamRequest req)
            {
                _dev = dev;
                _req = req;
            }

            public bool IsRunning => _run;
            public double ActualSampleIntervalSeconds => _actualDt;
            public long TotalSamples => Interlocked.Read(ref _total);

            public void Start()
            {
                if (_run) return;
                lock (_dev._ioLock)
                {
                    _dev.ApplyConfig(_req.SampleIntervalSeconds);
                    _chCount = _dev.ActiveChannelCount();
                    _setup = _dev.SnapshotSetup();
                    _actualDt = _chCount / (double)_dev._appliedRateHz;
                    _rings = new ScopeRingBuffer[2];
                    for (int c = 0; c < _chCount; c++)
                        if (_setup[c].Enabled) _rings[c] = new ScopeRingBuffer(_req.RingDepthSamples);
                    _dev.WriteReg(TRIGGER_REG, 1);
                }
                _run = true;
                _thread = new Thread(Pump) { IsBackground = true, Name = "Hantek6022Stream" };
                _thread.Start();
            }

            private void Pump()
            {
                var raw = new byte[65536];
                var scratch = new float[raw.Length];
                int faults = 0;
                while (_run)
                {
                    uint read = 0;
                    bool ok;
                    lock (_dev._ioLock)
                    {
                        if (!_run || !_dev.IsOpen) break;
                        ok = WinUsbInterop.WinUsb_ReadPipe(_dev._winusb, BULK_EP_IN, raw, (uint)raw.Length, out read, IntPtr.Zero);
                    }
                    if (!ok || read == 0)
                    {
                        // USB 2.0 units drop data under load (report §06) — surface, don't crash.
                        Overrun?.Invoke(this, EventArgs.Empty);
                        if (++faults >= 5)
                        {
                            _dev.RaiseFault(ScopeFaultKind.UsbDisconnected, "Hantek bulk stream stalled — stopping stream.");
                            _run = false;
                            break;
                        }
                        Thread.Sleep(20);
                        continue;
                    }
                    faults = 0;
                    int perCh = (int)read / _chCount;
                    for (int c = 0; c < _chCount; c++)
                    {
                        var ring = _rings[c];
                        if (ring == null) continue;
                        double scale = FullScaleFor(_dev._appliedGainCode[c]) / 128.0 * _setup[c].ProbeAttenuation;
                        for (int i = 0; i < perCh; i++)
                            scratch[i] = (float)((raw[i * _chCount + c] - 128) * scale);
                        ring.Write(scratch, 0, perCh);
                    }
                    Interlocked.Add(ref _total, perCh);
                }
            }

            public void Stop()
            {
                if (!_run && _thread == null) return;
                _run = false;
                var th = _thread;
                if (th != null && th.IsAlive) th.Join(1500);
                _thread = null;
                lock (_dev._ioLock)
                {
                    if (_dev.IsOpen)
                    {
                        try { _dev.WriteReg(TRIGGER_REG, 0); } catch { }
                        try { WinUsbInterop.WinUsb_FlushPipe(_dev._winusb, BULK_EP_IN); } catch { }
                    }
                }
            }

            public CaptureBlock SnapshotLatest(int sampleCount)
            {
                var block = new CaptureBlock
                {
                    ChannelSamples = new float[2][],
                    SampleIntervalSeconds = _actualDt,
                    Overrange = new bool[2],
                    QpcTimestamp = ScopeClock.Timestamp(),
                    UtcTimestamp = DateTime.UtcNow,
                    ChannelSetup = _setup,
                };
                for (int c = 0; c < 2; c++)
                {
                    if (_rings[c] == null) continue;
                    var dst = new float[sampleCount];
                    int got = _rings[c].SnapshotLatest(dst, sampleCount);
                    if (got < sampleCount)
                    {
                        var trimmed = new float[got];
                        Array.Copy(dst, 0, trimmed, 0, got);
                        dst = trimmed;
                    }
                    block.ChannelSamples[c] = dst;
                }
                return block;
            }

            public void Dispose() => Stop();
        }
    }
}
