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
//  Tester Present Specialist Automotive Solutions — USB Oscilloscope HAL: demo signal source
//  Copyright (c) 2026 Benjamin Jack Leighton. All rights reserved.
//
//  Synthetic 4-channel device so the scope tab is fully exercisable with no hardware attached
//  (training, UI work, offline demos). Sits in the device list BESIDE the real backends —
//  it never replaces them and is clearly labelled. Signals are automotive-shaped:
//    CH1  crank-style 36-1 pulse train        CH2  injector-style current ramp
//    CH3  charging ripple on 14.2 V           CH4  500 kbit/s CAN-H-shaped bursts
//  Trigger, block capture, and streaming all behave like a real backend so every UI path runs.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Threading;
using System.Threading.Tasks;

namespace TesterPresent.OBD2.Scope
{
    public sealed class DemoScopeDevice : IScopeDevice
    {
        private readonly ChannelConfig[] _channels;
        private TriggerConfig _trigger = new TriggerConfig();
        private bool _open;

        public event EventHandler<ScopeFaultEventArgs> Fault { add { } remove { } } // demo device never faults

        public DemoScopeDevice()
        {
            _channels = new ChannelConfig[4];
            for (int i = 0; i < 4; i++) _channels[i] = new ChannelConfig { Enabled = i == 0 };
        }

        public static ScopeDeviceInfo MakeDeviceInfo() => new ScopeDeviceInfo
        {
            Backend = ScopeBackendKind.Demo,
            DisplayName = "Demo signal source (no hardware)",
            VendorHandle = "demo",
            Detail = "Synthetic CKP / injector / charging / CAN waveforms",
        };

        public ScopeCapabilities Capabilities { get; } = new ScopeCapabilities
        {
            ChannelCount = 4,
            MaxSampleRateHz = 10_000_000,
            BufferDepthSamples = 8_000_000,
            ResolutionBits = 12,
            SupportsStreaming = true,
            RatePerActiveChannels = new long[] { 10_000_000, 10_000_000, 10_000_000, 10_000_000 },
            InputRangesVolts = new[] { 0.05, 0.1, 0.2, 0.5, 1, 2, 5, 10, 20, 50 },
        };

        public ScopeDeviceInfo DeviceInfo { get; private set; }

        public bool IsOpen => _open;

        public Task<bool> OpenAsync(ScopeDeviceInfo device)
        {
            DeviceInfo = device ?? MakeDeviceInfo();
            _open = true;
            return Task.FromResult(true);
        }

        public void Close() => _open = false;

        public void ConfigureChannel(int ch, ChannelConfig cfg)
        {
            if (ch >= 0 && ch < _channels.Length && cfg != null) _channels[ch] = cfg.Clone();
        }

        public void ConfigureTrigger(TriggerConfig cfg)
        {
            if (cfg != null) _trigger = cfg.Clone();
        }

        // ---- signal synthesis -------------------------------------------------------------

        /// <summary>Stateless hash-noise so concurrent block + stream synthesis needs no locking.</summary>
        private static double Noise(double t)
        {
            double s = Math.Sin(t * 12345.6789) * 43758.5453;
            return (s - Math.Floor(s)) - 0.5;
        }

        /// <summary>t in seconds → volts for the demo channel shapes.</summary>
        internal static float Synthesize(int channel, double t)
        {
            double noise = Noise(t + channel) * 0.04;
            switch (channel)
            {
                case 0:
                {
                    // 36-1 crank wheel at ~800 rpm: tooth period ≈ 2.08 ms, one gap per rev.
                    const double toothPeriod = 75e-3 / 36.0;
                    double rev = t % (36 * toothPeriod);
                    int tooth = (int)(rev / toothPeriod);
                    if (tooth == 35) return (float)(0.05 + noise);                  // missing tooth
                    double ph = (rev % toothPeriod) / toothPeriod;
                    return (float)(2.5 * Math.Sin(ph * Math.PI) * (ph < 0.5 ? 1 : -1) + noise);
                }
                case 1:
                {
                    // Injector current: 1.2 ms ramp-and-hold every 10 ms.
                    double ph = t % 10e-3;
                    if (ph < 0.4e-3) return (float)(ph / 0.4e-3 * 4.0 + noise);     // peak ramp
                    if (ph < 1.2e-3) return (float)(1.5 + 0.3 * Math.Sin(ph * 40000) + noise); // hold chop
                    if (ph < 1.35e-3) return (float)(-2.0 + noise);                 // flyback
                    return (float)noise;
                }
                case 2:
                    // Charging system: 14.2 V DC + 3-phase alternator ripple + whine.
                    return (float)(14.2 + 0.25 * Math.Sin(2 * Math.PI * 420 * t)
                                        + 0.08 * Math.Sin(2 * Math.PI * 1260 * t) + noise);
                default:
                {
                    // CAN-H-shaped: 2.5 V recessive, 3.5 V dominant bursts at 500 kbit/s.
                    double bit = Math.Floor(t * 500_000);
                    double frame = bit % 200;
                    bool dominant = frame < 90 && ((long)bit * 2654435761L & 0x30) != 0;
                    return (float)((dominant ? 3.5 : 2.5) + noise);
                }
            }
        }

        private int FindTriggerIndex(float[] src, TriggerConfig trig, double levelBncVolts)
        {
            if (trig == null || !trig.Enabled || src == null || src.Length < 3) return -1;
            float level = (float)levelBncVolts;
            for (int i = 1; i < src.Length; i++)
            {
                bool rising = src[i - 1] < level && src[i] >= level;
                bool falling = src[i - 1] > level && src[i] <= level;
                if ((trig.Slope == TriggerSlope.Rising && rising)
                    || (trig.Slope == TriggerSlope.Falling && falling)
                    || (trig.Slope == TriggerSlope.Either && (rising || falling)))
                    return i;
            }
            return -1;
        }

        public Task<CaptureBlock> CaptureBlockAsync(BlockRequest req, CancellationToken ct)
        {
            return Task.Run(() =>
            {
                double dt = Math.Max(req.SampleIntervalSeconds, 1.0 / Capabilities.MaxSampleRateHz);
                int n = Math.Min(req.SampleCount, (int)Capabilities.BufferDepthSamples);
                // Overscan 2× so a trigger point can be centred per PreTriggerFraction.
                double t0 = ScopeClock.TicksToSeconds(ScopeClock.Timestamp()) % 3600.0;
                var setup = SnapshotSetup();

                var raw = new float[_channels.Length][];
                for (int c = 0; c < _channels.Length; c++)
                {
                    if (!setup[c].Enabled) continue;
                    var buf = new float[n * 2];
                    for (int i = 0; i < buf.Length; i++)
                        buf[i] = Synthesize(c, t0 + i * dt);
                    raw[c] = buf;
                }

                int trigAt = -1;
                if (_trigger.Enabled && _trigger.SourceChannel >= 0
                    && _trigger.SourceChannel < raw.Length && raw[_trigger.SourceChannel] != null)
                {
                    // raw[] is synthesized at the BNC; LevelVolts is displayed (probe-scaled) volts.
                    double probe = Math.Max(1e-9, setup[_trigger.SourceChannel].ProbeAttenuation);
                    trigAt = FindTriggerIndex(raw[_trigger.SourceChannel], _trigger, _trigger.LevelVolts / probe);
                }

                int pre = (int)(n * Math.Min(Math.Max(_trigger.PreTriggerFraction, 0), 1));
                int start = trigAt >= 0 ? Math.Max(0, Math.Min(trigAt - pre, n)) : 0;

                var block = new CaptureBlock
                {
                    ChannelSamples = new float[_channels.Length][],
                    SampleIntervalSeconds = dt,
                    TriggerIndex = trigAt >= 0 ? trigAt - start : -1,
                    Overrange = new bool[_channels.Length],
                    QpcTimestamp = ScopeClock.Timestamp(),
                    UtcTimestamp = DateTime.UtcNow,
                    ChannelSetup = setup,
                };
                for (int c = 0; c < raw.Length; c++)
                {
                    if (raw[c] == null) continue;
                    var dst = new float[n];
                    Array.Copy(raw[c], start, dst, 0, n);
                    // Apply probe attenuation the way a real backend does (report §06).
                    float k = (float)setup[c].ProbeAttenuation;
                    if (k != 1f) for (int i = 0; i < n; i++) dst[i] *= k;
                    block.ChannelSamples[c] = dst;
                }
                return block;
            }, ct);
        }

        private ChannelConfig[] SnapshotSetup()
        {
            var setup = new ChannelConfig[_channels.Length];
            for (int i = 0; i < _channels.Length; i++) setup[i] = _channels[i].Clone();
            return setup;
        }

        public IScopeStream OpenStream(StreamRequest req) => new DemoStream(this, req);

        public void Dispose() => Close();

        // ---- streaming --------------------------------------------------------------------

        private sealed class DemoStream : IScopeStream
        {
            private readonly DemoScopeDevice _dev;
            private readonly double _dt;
            private readonly ScopeRingBuffer[] _rings;
            private readonly ChannelConfig[] _setup;
            private Thread _thread;
            private volatile bool _run;
            private long _total;

            public event EventHandler Overrun { add { } remove { } }  // demo never overruns

            public DemoStream(DemoScopeDevice dev, StreamRequest req)
            {
                _dev = dev;
                _dt = Math.Max(req.SampleIntervalSeconds, 1e-6);
                _setup = dev.SnapshotSetup();
                _rings = new ScopeRingBuffer[_setup.Length];
                for (int i = 0; i < _setup.Length; i++)
                    if (_setup[i].Enabled) _rings[i] = new ScopeRingBuffer(req.RingDepthSamples);
            }

            public bool IsRunning => _run;
            public double ActualSampleIntervalSeconds => _dt;
            public long TotalSamples => Interlocked.Read(ref _total);

            public void Start()
            {
                if (_run) return;
                _run = true;
                _thread = new Thread(Pump) { IsBackground = true, Name = "DemoScopeStream" };
                _thread.Start();
            }

            private void Pump()
            {
                double t = 0;
                var chunk = new float[8192];
                while (_run)
                {
                    // Real time pacing: generate ~20 ms of signal per iteration.
                    int n = Math.Min(chunk.Length, Math.Max(64, (int)(0.02 / _dt)));
                    for (int c = 0; c < _rings.Length; c++)
                    {
                        if (_rings[c] == null) continue;
                        float k = (float)_setup[c].ProbeAttenuation;
                        for (int i = 0; i < n; i++)
                            chunk[i] = Synthesize(c, t + i * _dt) * k;
                        _rings[c].Write(chunk, 0, n);
                    }
                    t += n * _dt;
                    Interlocked.Add(ref _total, n);
                    Thread.Sleep(20);
                }
            }

            public void Stop()
            {
                _run = false;
                var th = _thread;
                if (th != null && th.IsAlive) th.Join(500);
                _thread = null;
            }

            public CaptureBlock SnapshotLatest(int sampleCount)
            {
                var block = new CaptureBlock
                {
                    ChannelSamples = new float[_rings.Length][],
                    SampleIntervalSeconds = _dt,
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
