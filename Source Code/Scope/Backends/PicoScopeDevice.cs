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
//  Tester Present Specialist Automotive Solutions — USB Oscilloscope HAL: PicoScope ps4000a backend
//  Copyright (c) 2026 Benjamin Jack Leighton. All rights reserved.
//
//  Flagship backend (report §02) — covers the 4225A/4425A automotive units plus the wider
//  ps4000a family. Block capture and continuous streaming, both feeding volts-at-the-probe
//  through the vendor-neutral HAL types.
//
//  Threading discipline (report §3.2 / §06):
//    • ALL driver calls are serialized on _ioLock — the ps4000a driver is not re-entrant per handle.
//    • Callback delegates are instance fields, alive for the device lifetime, so the GC can
//      never collect a delegate the native driver still holds. Do not convert them to lambdas.
//    • The streaming callback copies out of the driver's overview buffer and returns; the
//      pump thread owns pacing.
//  Capabilities are probed from the driver (GetTimebase floor / maxSamples), never hard-coded
//  per model, so headline-spec lies are impossible (report §06 "sample-rate reality").
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using P = TesterPresent.OBD2.Scope.Ps4000aNative;

namespace TesterPresent.OBD2.Scope
{
    public sealed class PicoScopeDevice : IScopeDevice
    {
        private readonly object _ioLock = new object();
        // Config store has its own lock so ConfigureChannel/ConfigureTrigger from the UI never
        // block behind a capture holding _ioLock in its (possibly indefinite) trigger wait.
        private readonly object _cfgLock = new object();
        private short _handle = -1;
        private short _maxAdc = short.MaxValue;
        private ChannelConfig[] _channels = Array.Empty<ChannelConfig>();
        private int[] _appliedRangeIndex = Array.Empty<int>();
        private TriggerConfig _trigger = new TriggerConfig();
        private readonly ManualResetEventSlim _blockDone = new ManualResetEventSlim(false);
        private readonly P.ps4000aBlockReady _blockReadyCb;   // device-lifetime pin
        private int _blockGen;   // correlates BlockReady callbacks with the capture that armed them
        private PicoStream _activeStream;

        public event EventHandler<ScopeFaultEventArgs> Fault;

        public ScopeCapabilities Capabilities { get; private set; } = new ScopeCapabilities();
        public ScopeDeviceInfo DeviceInfo { get; private set; }
        public bool IsOpen => _handle > 0;

        public PicoScopeDevice()
        {
            // A late BlockReady from a cancelled capture must not satisfy the NEXT capture's
            // wait — RunBlock carries the arming generation in pVoid and stale ones are ignored.
            _blockReadyCb = (h, status, pVoid) =>
            {
                if ((int)pVoid == Volatile.Read(ref _blockGen)) _blockDone.Set();
            };
        }

        internal void RaiseFault(ScopeFaultKind kind, string msg)
            => Fault?.Invoke(this, new ScopeFaultEventArgs(kind, msg));

        // ---- enumeration ------------------------------------------------------------------

        /// <summary>Lists attached ps4000a-family units. Throws DllNotFoundException when the SDK DLL is absent.</summary>
        public static ScopeDeviceInfo[] Enumerate()
        {
            short count;
            short serialLen = 512;
            var serials = new StringBuilder(serialLen);
            uint status = P.EnumerateUnits(out count, serials, ref serialLen);
            if (status != P.PICO_OK || count <= 0) return Array.Empty<ScopeDeviceInfo>();

            var list = new System.Collections.Generic.List<ScopeDeviceInfo>();
            foreach (var serial in serials.ToString().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                list.Add(new ScopeDeviceInfo
                {
                    Backend = ScopeBackendKind.PicoPs4000a,
                    DisplayName = $"PicoScope [{serial.Trim()}]",
                    VendorHandle = serial.Trim(),
                    Detail = "ps4000a driver",
                });
            }
            return list.ToArray();
        }

        // ---- open / close -----------------------------------------------------------------

        public Task<bool> OpenAsync(ScopeDeviceInfo device)
        {
            return Task.Run(() =>
            {
                lock (_ioLock)
                {
                    if (IsOpen) Close();
                    var serial = string.IsNullOrEmpty(device?.VendorHandle) ? null : new StringBuilder(device.VendorHandle);
                    uint status = P.OpenUnit(out _handle, serial);

                    // USB-powered 4225A/4425A route: acknowledge the reported power source
                    // (Pico's own example flow — pass the status straight back).
                    if (status == P.PICO_POWER_SUPPLY_NOT_CONNECTED
                        || status == P.PICO_USB3_0_DEVICE_NON_USB3_0_PORT
                        || status == P.PICO_POWER_SUPPLY_CONNECTED)
                    {
                        status = P.ChangePowerSource(_handle, status);
                    }
                    if (status != P.PICO_OK || _handle <= 0)
                    {
                        RaiseFault(ScopeFaultKind.DriverError, $"ps4000aOpenUnit failed, PICO_STATUS=0x{status:X8}");
                        _handle = -1;
                        return false;
                    }

                    P.MaximumValue(_handle, out _maxAdc);
                    if (_maxAdc <= 0) _maxAdc = short.MaxValue;

                    string variant = ReadInfo(P.InfoType.VariantInfo);
                    string batch = ReadInfo(P.InfoType.BatchAndSerial);

                    int chCount = 4;
                    // Pico model convention: 2nd digit of the variant is the channel count (4225→2, 4425/4444→4, 4824→8).
                    if (variant.Length >= 2 && char.IsDigit(variant[1]))
                        chCount = Math.Max(2, Math.Min(8, variant[1] - '0'));

                    _channels = new ChannelConfig[chCount];
                    _appliedRangeIndex = new int[chCount];
                    for (int i = 0; i < chCount; i++)
                        _channels[i] = new ChannelConfig { Enabled = i == 0 };

                    DeviceInfo = new ScopeDeviceInfo
                    {
                        Backend = ScopeBackendKind.PicoPs4000a,
                        DisplayName = $"PicoScope {variant} [{batch}]",
                        VendorHandle = device?.VendorHandle,
                        Detail = "ps4000a driver",
                    };

                    ProbeCapabilities(chCount);
                    return true;
                }
            });
        }

        private string ReadInfo(P.InfoType info)
        {
            var sb = new StringBuilder(256);
            short required;
            return P.GetUnitInfo(_handle, sb, 256, out required, info) == P.PICO_OK ? sb.ToString() : "?";
        }

        /// <summary>Ask the driver, not a spec sheet: fastest legal timebase + deepest buffer for this unit.</summary>
        private void ProbeCapabilities(int chCount)
        {
            ApplyChannels();
            int intervalNs = 0, maxSamples = 0;
            uint tb = 0;
            for (; tb < 64; tb++)
                if (P.GetTimebase(_handle, tb, 1024, out intervalNs, out maxSamples, 0) == P.PICO_OK && intervalNs > 0)
                    break;

            long maxRate = intervalNs > 0 ? (long)(1e9 / intervalNs) : 0;
            var perChannel = new long[chCount];
            for (int n = 1; n <= chCount; n++)
                perChannel[n - 1] = maxRate / n;   // shared-ADC family; the true rate is re-read per capture

            Capabilities = new ScopeCapabilities
            {
                ChannelCount = chCount,
                MaxSampleRateHz = maxRate,
                BufferDepthSamples = maxSamples,
                ResolutionBits = 12,
                SupportsStreaming = true,
                HasExtTrigger = false,
                RatePerActiveChannels = perChannel,
                InputRangesVolts = (double[])P.RangeVolts.Clone(),
            };
        }

        public void Close()
        {
            // Stop the stream BEFORE taking _ioLock: the pump thread needs the lock to
            // finish its current iteration, and Stop() joins it.
            _activeStream?.Stop();
            lock (_ioLock)
            {
                if (_handle > 0)
                {
                    P.Stop(_handle);
                    P.CloseUnit(_handle);
                }
                _handle = -1;
            }
        }

        public void Dispose() => Close();

        // ---- configuration ----------------------------------------------------------------

        public void ConfigureChannel(int ch, ChannelConfig cfg)
        {
            if (ch < 0 || ch >= _channels.Length || cfg == null) return;
            lock (_cfgLock) _channels[ch] = cfg.Clone();
        }

        public void ConfigureTrigger(TriggerConfig cfg)
        {
            if (cfg == null) return;
            lock (_cfgLock) _trigger = cfg.Clone();
        }

        /// <summary>Push channel config to hardware, snapping each request to the nearest legal range upward.</summary>
        private void ApplyChannels()
        {
            for (int i = 0; i < _channels.Length; i++)
            {
                ChannelConfig cfg;
                lock (_cfgLock) cfg = _channels[i].Clone();
                int idx = 0;
                while (idx < P.RangeVolts.Length - 1 && P.RangeVolts[idx] < cfg.RangeVolts - 1e-12) idx++;
                uint status = 1;
                // 4225A/4425A reject the sub-50 mV codes — walk up until the driver accepts.
                for (; idx < P.RangeVolts.Length; idx++)
                {
                    status = P.SetChannel(_handle, (P.Channel)i, (short)(cfg.Enabled ? 1 : 0),
                        cfg.Coupling == ScopeCoupling.AC ? P.Coupling.AC : P.Coupling.DC,
                        idx, (float)cfg.AnalogOffsetVolts);
                    if (status == P.PICO_OK) break;
                }
                if (status != P.PICO_OK && cfg.Enabled)
                    RaiseFault(ScopeFaultKind.DriverError, $"SetChannel {(char)('A' + i)} failed, PICO_STATUS=0x{status:X8}");
                _appliedRangeIndex[i] = Math.Min(idx, P.RangeVolts.Length - 1);
            }
        }

        private void ApplyTrigger()
        {
            TriggerConfig t;
            double probe;
            lock (_cfgLock)
            {
                t = _trigger.Clone();
                probe = t.SourceChannel >= 0 && t.SourceChannel < _channels.Length
                    ? Math.Max(1e-9, _channels[t.SourceChannel].ProbeAttenuation) : 1.0;
            }
            if (!t.Enabled || t.SourceChannel < 0 || t.SourceChannel >= _channels.Length)
            {
                P.SetSimpleTrigger(_handle, 0, P.Channel.A, 0, P.ThresholdDirection.Rising, 0, 1);
                return;
            }
            double range = P.RangeVolts[_appliedRangeIndex[t.SourceChannel]];
            // LevelVolts is in displayed (probe-scaled) volts; the ADC threshold lives at the BNC.
            double frac = t.LevelVolts / probe / range;
            short threshold = (short)Math.Max(short.MinValue + 1, Math.Min(short.MaxValue - 1, (int)(frac * _maxAdc)));
            var dir = t.Slope == TriggerSlope.Falling ? P.ThresholdDirection.Falling
                    : t.Slope == TriggerSlope.Either ? P.ThresholdDirection.RisingOrFalling
                    : P.ThresholdDirection.Rising;
            short autoMs = t.Mode == TriggerMode.Auto ? (short)Math.Max(1, Math.Min(short.MaxValue, t.AutoTriggerMs)) : (short)0;
            uint status = P.SetSimpleTrigger(_handle, 1, (P.Channel)t.SourceChannel, threshold, dir, 0, autoMs);
            if (status != P.PICO_OK)
                RaiseFault(ScopeFaultKind.DriverError, $"SetSimpleTrigger failed, PICO_STATUS=0x{status:X8}");
        }

        /// <summary>
        /// Smallest timebase whose interval ≥ the requested one, driver-verified. The interval
        /// is NOT linear in timebase across the whole range (power-of-two fast region, then a
        /// linear region with a different slope), so this uses exponential bound + binary
        /// search rather than a slope estimate.
        /// </summary>
        private uint FindTimebase(double desiredIntervalSeconds, int sampleCount, out double actualIntervalSeconds)
        {
            long desiredNs = Math.Max(1, (long)Math.Round(desiredIntervalSeconds * 1e9));
            int intervalNs, maxSamples;

            uint floor = 0;
            while (floor < 64 && (P.GetTimebase(_handle, floor, sampleCount, out intervalNs, out maxSamples, 0) != P.PICO_OK || intervalNs <= 0))
                floor++;
            if (P.GetTimebase(_handle, floor, sampleCount, out intervalNs, out maxSamples, 0) != P.PICO_OK || intervalNs <= 0)
            {
                // Driver refused everything — report the request back; RunBlock will surface the real error.
                actualIntervalSeconds = desiredIntervalSeconds;
                return floor;
            }

            uint tb = floor;
            if (intervalNs < desiredNs)
            {
                // Exponential search upward for a timebase whose interval ≥ desired.
                uint lo = floor, hi = floor, span = 1;
                int hiNs = intervalNs;
                for (int guard = 0; guard < 48 && hiNs < desiredNs; guard++)
                {
                    lo = hi;
                    hi = hi + span > hi ? hi + span : uint.MaxValue;   // overflow guard
                    span <<= 1;
                    if (P.GetTimebase(_handle, hi, sampleCount, out hiNs, out maxSamples, 0) != P.PICO_OK)
                        hiNs = 0;   // invalid high tb: treat as not-yet-satisfying, keep expanding
                    if (hi == uint.MaxValue) break;
                }
                if (hiNs < desiredNs)
                {
                    // Could not reach the requested interval — use the best (slowest valid) found.
                    P.GetTimebase(_handle, lo, sampleCount, out intervalNs, out maxSamples, 0);
                    actualIntervalSeconds = Math.Max(1, intervalNs) * 1e-9;
                    return lo;
                }
                // Binary search the smallest tb in (lo, hi] with interval ≥ desired.
                while (lo + 1 < hi)
                {
                    uint mid = lo + (hi - lo) / 2;
                    if (P.GetTimebase(_handle, mid, sampleCount, out intervalNs, out maxSamples, 0) != P.PICO_OK)
                    { lo = mid; continue; }   // invalid mid: push the lower bound up
                    if (intervalNs >= desiredNs) hi = mid; else lo = mid;
                }
                tb = hi;
            }
            P.GetTimebase(_handle, tb, sampleCount, out intervalNs, out maxSamples, 0);
            actualIntervalSeconds = Math.Max(1, intervalNs) * 1e-9;
            return tb;
        }

        private float[] ToVolts(short[] raw, int count, int channel, double probeAttenuation)
        {
            double scale = P.RangeVolts[_appliedRangeIndex[channel]] * probeAttenuation / _maxAdc;
            var dst = new float[count];
            for (int i = 0; i < count; i++) dst[i] = (float)(raw[i] * scale);
            return dst;
        }

        // ---- block capture ----------------------------------------------------------------

        public Task<CaptureBlock> CaptureBlockAsync(BlockRequest req, CancellationToken ct)
        {
            return Task.Run(() =>
            {
                lock (_ioLock)
                {
                    if (!IsOpen) throw new InvalidOperationException("PicoScope not open.");
                    ApplyChannels();
                    ApplyTrigger();
                    var setup = SnapshotSetup();
                    TriggerConfig trig;
                    lock (_cfgLock) trig = _trigger.Clone();

                    int n = (int)Math.Min(req.SampleCount, Math.Max(1024, Capabilities.BufferDepthSamples));
                    double actualDt;
                    uint timebase = FindTimebase(req.SampleIntervalSeconds, n, out actualDt);

                    int pre = trig.Enabled
                        ? (int)(n * Math.Min(Math.Max(trig.PreTriggerFraction, 0), 1)) : 0;
                    int post = n - pre;

                    // The driver keeps the SetDataBuffer pointers and writes into them AFTER the
                    // P/Invoke calls return (between RunBlock and the ready callback). Marshalling
                    // only pins for the call itself, so pin explicitly for the whole capture — a
                    // GC compaction mid-capture would otherwise let the driver write into moved
                    // memory (report §06 "callback marshalling crashes").
                    var rawBufs = new short[_channels.Length][];
                    var pins = new System.Collections.Generic.List<System.Runtime.InteropServices.GCHandle>();
                    uint got = (uint)n;
                    short overflow;
                    long qpcStart = 0;
                    try
                    {
                        for (int c = 0; c < _channels.Length; c++)
                        {
                            if (!setup[c].Enabled) continue;
                            rawBufs[c] = new short[n];
                            pins.Add(System.Runtime.InteropServices.GCHandle.Alloc(rawBufs[c], System.Runtime.InteropServices.GCHandleType.Pinned));
                            uint st = P.SetDataBuffer(_handle, (P.Channel)c, rawBufs[c], n, 0, P.DownSamplingMode.None);
                            if (st != P.PICO_OK)
                                throw new InvalidOperationException($"SetDataBuffer {(char)('A' + c)} failed, PICO_STATUS=0x{st:X8}");
                        }

                        _blockDone.Reset();
                        int gen = Interlocked.Increment(ref _blockGen);
                        int indisposedMs;
                        uint status = P.RunBlock(_handle, pre, post, timebase, out indisposedMs, 0, _blockReadyCb, (IntPtr)gen);
                        if (status != P.PICO_OK)
                            throw new InvalidOperationException($"RunBlock failed, PICO_STATUS=0x{status:X8}");
                        qpcStart = ScopeClock.Timestamp();

                        // In Normal/Single mode with no signal, the driver waits forever — honour cancellation.
                        while (!_blockDone.Wait(50))
                            ct.ThrowIfCancellationRequested();

                        status = P.GetValues(_handle, 0, ref got, 1, P.DownSamplingMode.None, 0, out overflow);
                        P.Stop(_handle);
                        if (status != P.PICO_OK)
                            throw new InvalidOperationException($"GetValues failed, PICO_STATUS=0x{status:X8}");
                    }
                    catch (OperationCanceledException)
                    {
                        P.Stop(_handle);
                        throw;
                    }
                    finally
                    {
                        foreach (var pin in pins) pin.Free();
                    }

                    var block = new CaptureBlock
                    {
                        ChannelSamples = new float[_channels.Length][],
                        SampleIntervalSeconds = actualDt,
                        TriggerIndex = trig.Enabled ? pre : -1,
                        Overrange = new bool[_channels.Length],
                        QpcTimestamp = qpcStart,
                        UtcTimestamp = DateTime.UtcNow,
                        ChannelSetup = setup,
                    };
                    for (int c = 0; c < _channels.Length; c++)
                    {
                        if (rawBufs[c] == null) continue;
                        block.ChannelSamples[c] = ToVolts(rawBufs[c], (int)got, c, setup[c].ProbeAttenuation);
                        block.Overrange[c] = (overflow & (1 << c)) != 0;
                    }
                    return block;
                }
            }, ct);
        }

        private ChannelConfig[] SnapshotSetup()
        {
            var setup = new ChannelConfig[_channels.Length];
            lock (_cfgLock)
            {
                for (int i = 0; i < _channels.Length; i++)
                {
                    setup[i] = _channels[i].Clone();
                    setup[i].RangeVolts = P.RangeVolts[_appliedRangeIndex[i]];
                }
            }
            return setup;
        }

        // ---- streaming --------------------------------------------------------------------

        public IScopeStream OpenStream(StreamRequest req)
        {
            if (!IsOpen) throw new InvalidOperationException("PicoScope not open.");
            return _activeStream = new PicoStream(this, req);
        }

        private sealed class PicoStream : IScopeStream
        {
            private const int OVERVIEW_SAMPLES = 1 << 18;

            private readonly PicoScopeDevice _dev;
            private readonly StreamRequest _req;
            private readonly P.ps4000aStreamingReady _cb;   // stream-lifetime pin
            private ScopeRingBuffer[] _rings;
            private short[][] _overview;
            private System.Runtime.InteropServices.GCHandle[] _overviewPins;   // driver writes after the call — pin for stream lifetime
            private float[] _scratch;
            private ChannelConfig[] _setup;
            private Thread _thread;
            private volatile bool _run;
            private long _total;
            private double _actualDt;

            public event EventHandler Overrun;

            public PicoStream(PicoScopeDevice dev, StreamRequest req)
            {
                _dev = dev;
                _req = req;
                _cb = OnStreamingReady;
            }

            public bool IsRunning => _run;
            public double ActualSampleIntervalSeconds => _actualDt;
            public long TotalSamples => Interlocked.Read(ref _total);

            public void Start()
            {
                if (_run) return;
                try
                {
                    StartLocked();
                }
                catch
                {
                    // A failed Start (SetDataBuffer/RunStreaming rejection) must not leak the
                    // pinned overview buffers — _run is still false so Stop() would early-return.
                    if (_overviewPins != null)
                    {
                        for (int i = 0; i < _overviewPins.Length; i++)
                            if (_overviewPins[i].IsAllocated) _overviewPins[i].Free();
                        _overviewPins = null;
                    }
                    throw;
                }
                _run = true;
                _thread = new Thread(Pump) { IsBackground = true, Name = "PicoScopeStream" };
                _thread.Start();
            }

            private void StartLocked()
            {
                lock (_dev._ioLock)
                {
                    _dev.ApplyChannels();
                    _dev.ApplyTrigger();
                    _setup = _dev.SnapshotSetup();

                    _rings = new ScopeRingBuffer[_setup.Length];
                    _overview = new short[_setup.Length][];
                    _overviewPins = new System.Runtime.InteropServices.GCHandle[_setup.Length];
                    _scratch = new float[OVERVIEW_SAMPLES];
                    for (int c = 0; c < _setup.Length; c++)
                    {
                        if (!_setup[c].Enabled) continue;
                        _rings[c] = new ScopeRingBuffer(_req.RingDepthSamples);
                        _overview[c] = new short[OVERVIEW_SAMPLES];
                        _overviewPins[c] = System.Runtime.InteropServices.GCHandle.Alloc(_overview[c], System.Runtime.InteropServices.GCHandleType.Pinned);
                        uint st = P.SetDataBuffer(_dev._handle, (P.Channel)c, _overview[c], OVERVIEW_SAMPLES, 0, P.DownSamplingMode.None);
                        if (st != P.PICO_OK)
                            throw new InvalidOperationException($"SetDataBuffer {(char)('A' + c)} failed, PICO_STATUS=0x{st:X8}");
                    }

                    uint intervalNs = (uint)Math.Max(1, Math.Round(_req.SampleIntervalSeconds * 1e9));
                    uint status = P.RunStreaming(_dev._handle, ref intervalNs, P.ReportedTimeUnits.NanoSeconds,
                        0, 0, 0 /*autoStop*/, 1, P.DownSamplingMode.None, OVERVIEW_SAMPLES);
                    if (status != P.PICO_OK)
                        throw new InvalidOperationException($"RunStreaming failed, PICO_STATUS=0x{status:X8}");
                    _actualDt = intervalNs * 1e-9;
                }
            }

            private void Pump()
            {
                while (_run)
                {
                    lock (_dev._ioLock)
                    {
                        if (!_run || !_dev.IsOpen) break;
                        // Status deliberately unchecked — Pico's own streaming example polls
                        // this way; data arrives via the callback when the driver has some.
                        P.GetStreamingLatestValues(_dev._handle, _cb, IntPtr.Zero);
                    }
                    Thread.Sleep(2);
                }
            }

            /// <summary>Driver thread: copy overview → ring, flag overrun, return. Nothing else (report §3.2).</summary>
            private void OnStreamingReady(short handle, int noOfSamples, uint startIndex, short overflow,
                                          uint triggerAt, short triggered, short autoStop, IntPtr pVoid)
            {
                if (noOfSamples <= 0) return;
                for (int c = 0; c < _rings.Length; c++)
                {
                    var ring = _rings[c];
                    var src = _overview[c];
                    if (ring == null || src == null) continue;
                    double scale = _setup[c].RangeVolts * _setup[c].ProbeAttenuation / _dev._maxAdc;
                    int n = Math.Min(noOfSamples, src.Length - (int)startIndex);
                    for (int i = 0; i < n; i++)
                        _scratch[i] = (float)(src[startIndex + i] * scale);
                    ring.Write(_scratch, 0, n);
                }
                Interlocked.Add(ref _total, noOfSamples);
                if (overflow != 0) Overrun?.Invoke(this, EventArgs.Empty);
            }

            public void Stop()
            {
                if (!_run) return;
                _run = false;
                var th = _thread;
                if (th != null && th.IsAlive) th.Join(1000);
                _thread = null;
                lock (_dev._ioLock)
                    if (_dev.IsOpen) P.Stop(_dev._handle);
                // Unpin only after the driver is stopped — it may write until then.
                if (_overviewPins != null)
                {
                    for (int i = 0; i < _overviewPins.Length; i++)
                        if (_overviewPins[i].IsAllocated) _overviewPins[i].Free();
                    _overviewPins = null;
                }
            }

            public CaptureBlock SnapshotLatest(int sampleCount)
            {
                var block = new CaptureBlock
                {
                    ChannelSamples = new float[_rings.Length][],
                    SampleIntervalSeconds = _actualDt,
                    Overrange = new bool[_rings.Length],
                    QpcTimestamp = ScopeClock.Timestamp(),
                    UtcTimestamp = DateTime.UtcNow,
                    ChannelSetup = _setup,
                };
                for (int c = 0; c < _rings.Length; c++)
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
