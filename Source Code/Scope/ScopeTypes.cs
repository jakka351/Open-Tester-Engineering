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
//  Tester Present Specialist Automotive Solutions — USB Oscilloscope hardware abstraction layer
//  Copyright (c) 2026 Benjamin Jack Leighton. All rights reserved.
//
//  Core vendor-neutral contracts for USB oscilloscope support (TES_USB_Oscilloscope_Integration_Report §3.1).
//  Mirrors the J2534 adapter discipline: every consumer codes against IScopeDevice; no vendor
//  type leaks above this layer. Backends: PicoScope ps4000a (flagship), SCPI (serial/LXI),
//  Hantek 6022 (budget, WinUSB), plus a built-in demo signal source for offline use.
//
//  NOTE: this HAL is deliberately OUTSIDE the heavy obfuscation envelope (report §3.4) —
//  virtualised code + native driver callbacks is a known crash factory. The IP boundary is
//  the guided-test / reference-waveform layer, not this plumbing.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Threading;
using System.Threading.Tasks;

namespace TesterPresent.OBD2.Scope
{
    /// <summary>Which vendor backend owns a device. Never branch on this above the HAL except for UI hints.</summary>
    public enum ScopeBackendKind
    {
        Demo,
        PicoPs4000a,
        Scpi,
        Hantek6022,
    }

    public enum ScopeCoupling
    {
        DC,
        AC,
    }

    public enum TriggerSlope
    {
        Rising,
        Falling,
        Either,
    }

    public enum TriggerMode
    {
        /// <summary>Free-run: capture regardless, re-arm continuously.</summary>
        Auto,
        /// <summary>Capture only when the trigger condition fires.</summary>
        Normal,
        /// <summary>One capture on the next trigger, then stop.</summary>
        Single,
    }

    /// <summary>
    /// Identity of an enumerated device before it is opened. VendorHandle is backend-private
    /// (Pico serial string, COM port name, USB device path, ...) — opaque above the HAL.
    /// </summary>
    public sealed class ScopeDeviceInfo
    {
        public ScopeBackendKind Backend;
        public string DisplayName;      // "PicoScope 4425A [FW123/456]", "SCPI @ COM7", ...
        public string VendorHandle;     // backend-private open token
        public string Detail;           // free-text: driver hint, firmware state, bitness caveat

        public override string ToString() => DisplayName ?? "(unknown scope)";
    }

    /// <summary>
    /// Capability descriptor (report §3.1). MaxSampleRateHz is the per-active-channel truth,
    /// not the headline spec — RateForActiveChannels() answers "what can I actually get".
    /// </summary>
    public sealed class ScopeCapabilities
    {
        public int ChannelCount;             // 2 / 4 / 8
        public long MaxSampleRateHz;         // single active channel
        public long BufferDepthSamples;
        public int ResolutionBits;           // 8 / 12 / 16
        public bool HasAwg, HasExtTrigger, SupportsStreaming;

        /// <summary>
        /// Per-active-channel achievable rate table (report §06 "Sample-rate reality").
        /// Index [n-1] = max rate with n channels active. Backends that share one ADC
        /// divide; backends with per-channel ADCs repeat the headline figure.
        /// </summary>
        public long[] RatePerActiveChannels = Array.Empty<long>();

        public long RateForActiveChannels(int activeChannels)
        {
            if (activeChannels < 1) activeChannels = 1;
            if (RatePerActiveChannels != null && RatePerActiveChannels.Length >= activeChannels)
                return RatePerActiveChannels[activeChannels - 1];
            return MaxSampleRateHz / Math.Max(1, activeChannels);
        }

        /// <summary>Supported ±full-scale input ranges in volts (at 1:1 probe), ascending.</summary>
        public double[] InputRangesVolts = Array.Empty<double>();
    }

    /// <summary>Per-channel acquisition configuration. ProbeAttenuation multiplies displayed volts (report §06).</summary>
    public sealed class ChannelConfig
    {
        public bool Enabled;
        public double RangeVolts = 5.0;        // ±full-scale at the BNC (1:1), backend snaps to nearest legal
        public ScopeCoupling Coupling = ScopeCoupling.DC;
        public double ProbeAttenuation = 1.0;  // 1, 10, 100 — display/export scaling only, never sent to hardware
        public double AnalogOffsetVolts = 0.0;

        public ChannelConfig Clone() => (ChannelConfig)MemberwiseClone();
    }

    public sealed class TriggerConfig
    {
        public bool Enabled;
        public int SourceChannel;              // 0-based
        /// <summary>
        /// In DISPLAYED volts — i.e. circuit volts including the source channel's probe
        /// attenuation, the same domain as CaptureBlock samples and the drawn trigger line.
        /// Backends whose hardware works at the BNC divide by the probe factor themselves.
        /// </summary>
        public double LevelVolts;
        public TriggerSlope Slope = TriggerSlope.Rising;
        public TriggerMode Mode = TriggerMode.Auto;
        public double PreTriggerFraction = 0.5; // 0..1 of the capture ahead of the trigger point
        public int AutoTriggerMs = 1000;        // Auto mode: fire anyway after this long

        public TriggerConfig Clone() => (TriggerConfig)MemberwiseClone();
    }

    public sealed class BlockRequest
    {
        public int SampleCount = 100_000;
        public double SampleIntervalSeconds = 1e-6;  // requested; actual comes back in the CaptureBlock
    }

    public sealed class StreamRequest
    {
        public double SampleIntervalSeconds = 1e-5;
        /// <summary>Ring depth per channel; backends round up to a power of two.</summary>
        public int RingDepthSamples = 4_000_000;
    }

    /// <summary>
    /// One completed block capture, already converted to volts at the BNC × probe attenuation.
    /// Timestamped at ingest on the shared monotonic clock (report §3.2) so scope data can be
    /// laid on the same timeline as CAN/UDS traffic later without retrofit.
    /// </summary>
    public sealed class CaptureBlock
    {
        /// <summary>[channel][sample] in volts; null entries = channel disabled.</summary>
        public float[][] ChannelSamples;
        public double SampleIntervalSeconds;
        public int TriggerIndex = -1;              // sample index of the trigger point, -1 = untriggered
        public bool[] Overrange;                   // per channel: ADC clipped during this block
        public long QpcTimestamp;                  // ScopeClock.Timestamp() at first sample (approx.)
        public DateTime UtcTimestamp;              // wall-clock companion for exports
        public ChannelConfig[] ChannelSetup;       // snapshot of the config that produced this block

        public int SampleCount
        {
            get
            {
                if (ChannelSamples == null) return 0;
                foreach (var ch in ChannelSamples) if (ch != null) return ch.Length;
                return 0;
            }
        }
    }

    /// <summary>
    /// Continuous streaming session. The vendor callback thread writes into per-channel ring
    /// buffers and does NOTHING else (report §3.2); the UI polls SnapshotLatest on its own timer.
    /// </summary>
    public interface IScopeStream : IDisposable
    {
        void Start();
        void Stop();
        bool IsRunning { get; }
        double ActualSampleIntervalSeconds { get; }
        /// <summary>Total samples ingested per channel since Start (monotonic; overrun-independent).</summary>
        long TotalSamples { get; }
        /// <summary>Copy the most recent <paramref name="sampleCount"/> samples of each enabled channel into volts.</summary>
        CaptureBlock SnapshotLatest(int sampleCount);
        /// <summary>Raised (on the acquisition thread) when the driver reported dropped data.</summary>
        event EventHandler Overrun;
    }

    public enum ScopeFaultKind
    {
        DriverError,
        UsbDisconnected,
        Overrange,
        Overrun,
    }

    public sealed class ScopeFaultEventArgs : EventArgs
    {
        public ScopeFaultKind Kind;
        public string Message;
        public ScopeFaultEventArgs(ScopeFaultKind kind, string message) { Kind = kind; Message = message; }
    }

    /// <summary>
    /// Core abstraction — vendor backends implement this (report §3.1). All voltage values at
    /// this boundary are volts at the BNC scaled by the channel's ProbeAttenuation, so every
    /// consumer sees real circuit volts regardless of vendor ADC format.
    /// </summary>
    public interface IScopeDevice : IDisposable
    {
        ScopeCapabilities Capabilities { get; }
        ScopeDeviceInfo DeviceInfo { get; }
        bool IsOpen { get; }

        Task<bool> OpenAsync(ScopeDeviceInfo device);
        void Close();

        void ConfigureChannel(int ch, ChannelConfig cfg);
        void ConfigureTrigger(TriggerConfig cfg);

        Task<CaptureBlock> CaptureBlockAsync(BlockRequest req, CancellationToken ct);
        IScopeStream OpenStream(StreamRequest req);

        /// <summary>Overrange, USB drop, driver error — raised on the acquisition thread.</summary>
        event EventHandler<ScopeFaultEventArgs> Fault;
    }
}
