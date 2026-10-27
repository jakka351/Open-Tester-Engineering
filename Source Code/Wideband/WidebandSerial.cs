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
//  Tester Present Specialist Automotive Solutions — Tech Edge WBo2 wideband serial driver
//
//  Streaming + command/control driver for Tech Edge "WBo2" wideband O2 controllers (2A1/2J1/2Y
//  and 1.5-Logger compatible units) over RS232 / USB-serial.  Implements the documented serial
//  protocol (see Data\"Serial Connection to Wideband O2 Sensor.pdf"):
//
//   • Link            : 8 data / No parity / 1 stop (8N1), default 19200 baud.  ASCII commands
//                       are terminated with a single CR (0x0D).
//   • Trace commands  : t1 = start continuous frame stream, tf = stop, t0 = one frame,
//                       s03e1 = "2v0 binary" frame mode (the streaming format parsed here),
//                       s04xx = inter-frame delay (xx hex, units of 10 ms).
//   • Logging commands: x1/x0 = on-board flash log start/stop, q = memory status (aabb hex:
//                       aa sectors used, bb sessions), z[nn] = dump session(s), y0040 = clear all,
//                       k = memory device id.
//   • 2.0 data frame  : 28 bytes — 0x5A 0xA5 header, seq, Tick(16, 10 ms/tick), Lambda-16(16),
//                       Ipx(16), User1..3 ADC(16 ea), TC1..3 ADC(16 ea), Thermistor/Vss(16),
//                       RPM-count(16), Status/Error(16), CRC.  All 16-bit fields are big-endian
//                       (high byte first).  CRC valid when (Σ all 28 bytes) & 0xFF == 0xFF.
//   • 1.5 data frame  : 12 bytes — header, seq, SVout(16), User1(16), User2(16), RPM-count(16),
//                       CRC.  Parsed as a fallback when a unit is in 1.5 mode.
//   • Lambda          : λ = Lambda16 / 8192 + 0.5  (canonical Tech Edge λ-16).  AFR = λ × stoich.
//                       Only valid once the controller's PID state == 3 (warm / operational);
//                       states 0/1/2 mean off / sensing / heating.
//   • RPM             : count is the number of 5 µs periods between trigger pulses; for the usual
//                       two-pulses-per-rev case RPM = 6,000,000 / count (configurable).
//
//  Threading: one background reader thread owns the port and parses frames; FrameReceived and
//  the text/status events fire on that thread, so UI consumers must marshal back themselves.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Ports;
using System.Text;
using System.Threading;

namespace TesterPresent.OBD2.Wideband
{
    /// <summary>
    /// Vs/Ip (wideband) PID state — bits 2-0 of the HIGH status byte (byte 26 of the frame).
    /// λ/AFR are only valid once the state reaches <see cref="Operational"/> (Warm).
    /// </summary>
    public enum WbSensorState
    {
        Off = 0,        // null/off — start-up / debug
        Sensing = 1,    // looking for the sensor
        Heating = 2,    // "cold" — warming the sensor, readings not yet valid
        Operational = 3,// "warm" — PIDs running, λ/AFR valid
        Config = 4      // config / system-test state
    }

    /// <summary>
    /// Heater PID state — bits 2-0 of the LOW status byte (byte 27 of the frame).  States 1-5 are
    /// abnormal: 3/4/5 are hard heater faults, 1/2 are supply-voltage problems.
    /// </summary>
    public enum WbHeaterState
    {
        Normal = 0,
        VbattHigh = 1,    // supply voltage too high
        VbattLow = 2,     // supply voltage too low
        HeaterShort = 3,  // heater short circuit
        HeaterOpen = 4,   // heater open circuit (sensor not present)
        FetFailure = 5,   // heater drive FET failure
        Unused = 6
    }

    /// <summary>Which frame type the controller is currently streaming.</summary>
    public enum WbFrameMode { Data, Calibrate }

    /// <summary>
    /// Serial wire format / brand.  <see cref="TechEdgeWbo2"/> is the binary 2v0/1.5 frame protocol
    /// above.  <see cref="AemXSeries"/> is AEM's X-Series UEGO serial output (also matches the legacy
    /// 30-4100/30-4110 gauge): free-running 9600 8N1 ASCII, one numeric value per line ("14.7\r\n"),
    /// AFR or Lambda per the gauge's display mode (auto-detected here by magnitude).
    /// </summary>
    public enum WbProtocol { TechEdgeWbo2, AemXSeries }

    /// <summary>PID-code (bits 7-5 of a status byte) — feedback-loop clamp diagnostics.</summary>
    public enum WbPidCode
    {
        Normal = 0,             // operating normally
        IntegralClampLow = 1,   // integral accumulator at lower clamp
        IntegralClampHigh = 2,  // integral accumulator at upper clamp
        OutputClampLow = 3,     // output control value at lower clamp
        OutputClampHigh = 4     // output control value at upper clamp
    }

    /// <summary>
    /// One decoded "2.0 Calibrate Frame" (20 bytes, requested with s03e2).  Read-only controller
    /// telemetry — heater voltage/current/impedance + op-state — used to verify the controller is
    /// healthy and as the live readout while a free-air calibration is performed via the unit's
    /// hardware calibrate button.
    /// </summary>
    public sealed class WidebandCalFrame
    {
        public DateTime ArrivalUtc;
        public int      Sequence;
        public int      Ipx;
        public int      HeaterVoltsRaw, HeaterAmpsRaw;
        public double   HeaterVolts;       // htr_vh / 51.2
        public double   HeaterAmps;        // htr_hr / 51.2
        public int      WidebandA16;       // wideband A-16 / ADC
        public int      HeaterImpedanceRaw;
        public int      OpState;
        public int      StatusWord;
    }

    /// <summary>One decoded wideband data frame.</summary>
    public sealed class WidebandFrame
    {
        public DateTime ArrivalUtc;
        public int      Sequence;
        public int      TickRaw;          // 10 ms per tick (device timebase)
        public double   DeviceSeconds;    // TickRaw * 0.01

        public int      Lambda16;
        public double   Lambda;           // λ = Lambda16/8192 + 0.5
        public double   Afr;              // λ × stoich
        public int      Ipx;              // raw normalised pump current

        public double   User1V, User2V, User3V;   // 0-5 V analogue inputs
        public int      Tc1Raw, Tc2Raw, Tc3Raw;   // thermocouple ADC counts (10-bit, raw)
        public double   Tc1C, Tc2C, Tc3C;         // Type-K °C (NaN if no probe / not computed)
        public int      ThermistorRaw;            // byte 22-23 — thermistor OR Vss count (2J1)
        public double   ThermistorC;              // cold-junction sensor temperature (NaN if unknown)
        public double   ColdJunctionC;            // CJC temperature actually used for the TC maths
        public double   VssHz;                    // byte 22-23 read as a Vss pulse frequency (Hz)
        public double   VssSpeed;                 // VssHz × user scale (vehicle speed, when enabled)
        public int      RpmCount;
        public double   Rpm;
        public int      StatusWord;
        public WbSensorState State;               // Vs/Ip (wideband) PID state — high status byte
        public bool     ErrorBand;                // Vs/Ip PID error band exceeded (high byte bit 4)
        public WbPidCode PidCode;                 // Vs/Ip PID clamp code (high byte bits 7-5)
        public WbHeaterState HeaterState;         // heater PID state — low status byte
        public bool     HeaterErrorBand;          // heater PID error band exceeded (low byte bit 4)
        public WbPidCode HeaterPidCode;           // heater PID clamp code (low byte bits 7-5)
        public bool     Operational => State == WbSensorState.Operational;
        /// <summary>Hard heater fault (short / open / FET) — sensor cannot heat correctly.</summary>
        public bool     HeaterFault => HeaterState == WbHeaterState.HeaterShort
                                    || HeaterState == WbHeaterState.HeaterOpen
                                    || HeaterState == WbHeaterState.FetFailure;
        public bool     IsLite;           // true if decoded from a 12-byte 1.5 frame
    }

    public sealed class WidebandSerial : IDisposable
    {
        private const byte H0 = 0x5A, H1 = 0xA5;
        private const int  Frame20 = 28, Frame15 = 12, FrameCal = 20;

        private SerialPort _port;
        private Thread     _reader;
        private volatile bool _run;
        private readonly object _txLock = new object();

        public double StoichAfr   { get; set; } = 14.7;  // gasoline
        public double PulsesPerRev { get; set; } = 2.0;  // 4-cyl 4-stroke default

        /// <summary>Serial wire format. Set before Open(). Default = Tech Edge WBo2 binary frames.</summary>
        public WbProtocol Protocol { get; set; } = WbProtocol.TechEdgeWbo2;

        // ── thermocouple configuration ──────────────────────────────────────────────
        // The frame carries each Type-K probe as a raw 10-bit count; the controller doc defers the
        // exact channel gain elsewhere, so the ADC→EMF scale is operator-calibratable.  The default
        // maps the 10-bit span to ~0-1235 °C (50 mV full scale), sensible for an EGT probe — but
        // CALIBRATE it against a known reference for accurate readings on a given unit.
        public bool   TcCelsius           { get; set; } = true;          // show TCs as °C vs raw counts
        public double TcMillivoltsPerCount { get; set; } = 50.0 / 1023.0; // ≈0.0489 mV/count
        /// <summary>Cold-junction source: false = fixed ambient, true = on-board thermistor.</summary>
        public bool   UseThermistorCjc    { get; set; } = false;
        public double FixedColdJunctionC  { get; set; } = 25.0;          // assumed terminal-block temp
        public double NtcR25              { get; set; } = 10000;         // thermistor 25 °C resistance (Ω)
        public double NtcBeta             { get; set; } = 3950;          // thermistor Beta constant
        public double NtcSeriesR          { get; set; } = 10000;         // divider series resistor (Ω)

        // ── Vss (vehicle speed) configuration ───────────────────────────────────────
        // On 2J1 units byte 22-23 is a Vss count (100 µs periods) instead of the thermistor.
        // When enabled, that field is read as a pulse frequency; VssScale converts Hz → speed.
        public bool   InterpretThermistorAsVss { get; set; } = false;
        public double VssScale                 { get; set; } = 1.0;       // speed units per Hz

        public bool   IsOpen   => _port != null && _port.IsOpen;
        public string PortName => _port?.PortName ?? "";

        /// <summary>True while a continuous frame stream is running (vs. text/command mode).</summary>
        public bool   Streaming { get; private set; }
        /// <summary>Which frame type is currently being parsed (Data vs Calibrate).</summary>
        public WbFrameMode FrameMode { get; private set; } = WbFrameMode.Data;
        /// <summary>True while replaying an on-board memory dump.</summary>
        public bool   Dumping { get; private set; }

        public event Action<WidebandFrame>    FrameReceived;   // live data frame — reader thread
        public event Action<WidebandCalFrame> CalFrameReceived;// calibrate frame — reader thread
        public event Action<WidebandFrame>    DumpFrameReceived;// a frame decoded from a memory dump
        public event Action<int>              DumpComplete;    // dump finished (idle timeout); arg = frame count
        public event Action<string>           TextReceived;    // ASCII responses (q / k / z …) — reader thread
        public event Action<string>           Error;           // fatal port/parse error — reader thread

        private volatile bool _dumping;
        private volatile bool _resync;   // set on any frame-mode change → reader clears its byte buffer
        private int _dumpIdleTicks, _dumpFrameCount;

        public static string[] ListPorts()
        {
            try { var p = SerialPort.GetPortNames(); Array.Sort(p, StringComparer.OrdinalIgnoreCase); return p; }
            catch { return new string[0]; }
        }

        public static int[] CommonBauds => new[] { 9600, 19200, 38400, 57600, 115200 };

        public void Open(string portName, int baud)
        {
            Close();
            _port = new SerialPort(portName, baud, Parity.None, 8, StopBits.One)
            {
                Handshake = Handshake.None,
                DtrEnable = true,           // many USB-serial widebands need DTR asserted to talk
                RtsEnable = true,
                ReadTimeout = 200,
                WriteTimeout = 500,
                ReadBufferSize = 8192,
                NewLine = "\r"
            };
            _port.Open();
            _port.DiscardInBuffer();
            _port.DiscardOutBuffer();
            Streaming = false;
            _run = true;
            _reader = new Thread(ReadLoop) { IsBackground = true, Name = "WidebandReader" };
            _reader.Start();
        }

        public void Close()
        {
            _run = false;
            Streaming = false;
            try { if (_reader != null && _reader.IsAlive) _reader.Join(400); } catch { }
            _reader = null;
            try { if (_port != null && _port.IsOpen) { TrySend("tf"); _port.Close(); } } catch { }
            try { _port?.Dispose(); } catch { }
            _port = null;
        }

        public void Dispose() => Close();

        // ── command / control ───────────────────────────────────────────────────────
        /// <summary>Send an ASCII command, appending the protocol's CR terminator.</summary>
        public void Send(string cmd)
        {
            if (!IsOpen || string.IsNullOrEmpty(cmd)) return;
            lock (_txLock)
            {
                try { _port.Write(cmd + "\r"); }
                catch (Exception ex) { Error?.Invoke("TX failed: " + ex.Message); }
            }
        }

        private void TrySend(string cmd) { try { _port?.Write(cmd + "\r"); } catch { } }

        /// <summary>Select 2v0 binary data frame mode (s03e1) then start the continuous stream (t1).</summary>
        public void StartStream()
        {
            if (!IsOpen) return;
            FrameMode = WbFrameMode.Data;
            _resync = true;
            if (Protocol == WbProtocol.AemXSeries)
            {
                // AEM X-Series serial free-runs ASCII AFR/Lambda — there is no start command; just
                // begin parsing the bytes that are already arriving.  Do NOT touch _aemLine here: it
                // is owned by the reader thread, which clears it on the _resync flag set above.
                try { _port.DiscardInBuffer(); } catch { }
                Streaming = true;
                return;
            }
            Send("s03e1");           // 2v0 binary data — the format the frame parser expects
            Thread.Sleep(40);
            _port.DiscardInBuffer();
            Streaming = true;
            Send("t1");
        }

        /// <summary>
        /// Select the 2v0 binary CALIBRATE frame (s03e2 — frame-type bits = 2) and stream it.  This
        /// only selects a frame type; it is read-only and does not initiate a calibration.  The frame
        /// carries heater voltage / current / impedance and op-state for controller-health checks.
        /// </summary>
        public void StartCalibrate()
        {
            if (!IsOpen) return;
            FrameMode = WbFrameMode.Calibrate;
            _resync = true;
            Send("s03e2");           // 2v0 binary calibrate
            Thread.Sleep(40);
            _port.DiscardInBuffer();
            Streaming = true;
            Send("t1");
        }

        /// <summary>Stop the continuous stream (tf) and return to text/command mode.</summary>
        public void StopStream()
        {
            if (!IsOpen) return;
            if (Protocol == WbProtocol.AemXSeries) { Streaming = false; return; }   // output-only — nothing to send
            Send("tf");
            Streaming = false;
            FrameMode = WbFrameMode.Data;
            _resync = true;
        }

        public void RequestSingleFrame()        { FrameMode = WbFrameMode.Data; _resync = true; Streaming = true; Send("t0"); }
        public void SetFrameDelay(int tensOfMs) { Send("s04" + Math.Max(1, Math.Min(100, tensOfMs)).ToString("X2")); }

        public void OnboardLogStart()  => Send("x1");
        public void OnboardLogStop()   => Send("x0");
        public void OnboardQuery()     => Send("q");
        public void OnboardClearAll()  => Send("y0040");
        public void ReadMemoryId()     => Send("k");

        /// <summary>
        /// Dump on-board memory and decode the stored 28-byte data frames onto DumpFrameReceived.
        /// session &lt; 0 dumps everything (z); otherwise dumps one session (znn).  Completion is
        /// detected by an idle-timeout (no bytes for ~1.4 s) → DumpComplete.
        /// </summary>
        public void BeginDump(int session = -1)
        {
            if (!IsOpen) return;
            Send("tf");                          // stop any live stream so it can't interleave with the dump
            FrameMode = WbFrameMode.Data;        // logged frames are the 2v0 data format
            _dumpIdleTicks = 0; _dumpFrameCount = 0;
            _dumping = true; Dumping = true;
            _resync = true;                      // discard any partial frame left in the reader buffer
            Streaming = true;                    // binary-parse incoming bytes
            Send(session < 0 ? "z" : "z" + (session & 0x7F).ToString("X2"));
        }

        // ── reader thread ───────────────────────────────────────────────────────────
        private void ReadLoop()
        {
            var buf = new List<byte>(256);
            var tmp = new byte[1024];
            var textSb = new StringBuilder(128);

            while (_run && _port != null && _port.IsOpen)
            {
                int n;
                try { n = _port.Read(tmp, 0, tmp.Length); }
                catch (TimeoutException) { if (_dumping) DumpIdleTick(buf); continue; }
                catch (Exception ex) { if (_run) Error?.Invoke("Port read error: " + ex.Message); break; }
                if (_resync) { _resync = false; buf.Clear(); _aemLine.Clear(); }   // mode changed — drop stale bytes (reader owns _aemLine)
                if (n <= 0) continue;
                if (_dumping) _dumpIdleTicks = 0;   // data still flowing — reset the dump idle counter

                // AEM X-Series: line-based ASCII, independent of the Tech Edge frame/command state.
                if (Protocol == WbProtocol.AemXSeries)
                {
                    if (Streaming) ParseAemAscii(tmp, n); else _aemLine.Clear();
                    continue;
                }

                if (!Streaming)
                {
                    // Text / command-response mode: surface CR/LF-delimited lines (q, k, z, banners…).
                    for (int i = 0; i < n; i++)
                    {
                        char c = (char)tmp[i];
                        if (c == '\r' || c == '\n')
                        {
                            if (textSb.Length > 0) { TextReceived?.Invoke(textSb.ToString()); textSb.Clear(); }
                        }
                        else if (c >= ' ' && c < 0x7F && textSb.Length < 512) textSb.Append(c);
                    }
                    continue;
                }

                for (int i = 0; i < n; i++) buf.Add(tmp[i]);
                if (FrameMode == WbFrameMode.Calibrate) ParseCalFrames(buf);
                else ParseFrames(buf);
            }
        }

        // ── AEM X-Series serial (ASCII) ───────────────────────────────────────────────
        private readonly StringBuilder _aemLine = new StringBuilder(32);

        /// <summary>Accumulate CR/LF-delimited ASCII lines from the AEM stream and emit a frame per line.</summary>
        private void ParseAemAscii(byte[] data, int n)
        {
            for (int i = 0; i < n; i++)
            {
                char c = (char)data[i];
                if (c == '\r' || c == '\n')
                {
                    if (_aemLine.Length > 0) { EmitAemReading(_aemLine.ToString()); _aemLine.Clear(); }
                }
                else if (c >= ' ' && c < 0x7F)
                {
                    if (_aemLine.Length < 24) _aemLine.Append(c);
                    else _aemLine.Clear();   // runaway line (no terminator) — drop and resync
                }
            }
        }

        /// <summary>
        /// Decode one AEM X-Series serial line.  The gauge outputs a single value per line — AFR or
        /// Lambda depending on its display mode (e.g. "14.7\r\n").  The two ranges don't overlap
        /// (AEM lambda 0.55–2.00, AFR ~8–29), so a value &lt; 5 is lambda and ≥ 5 is AFR.  Non-numeric
        /// status text ("----", "SEnS", "bAtt") fails to parse and is skipped (no frame emitted).
        /// </summary>
        private void EmitAemReading(string line)
        {
            string s = line.Trim();
            if (!double.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out double v)) return;

            // Recover fuel-agnostic lambda.  AEM AFR output is ALWAYS gasoline-referenced (14.65 per
            // the manual) regardless of the engine's fuel, so AFR-mode values divide by 14.65 — NOT
            // the user's fuel stoich.  Lambda is then re-expressed as AFR in the selected fuel.
            const double AemGasolineStoich = 14.65;
            double userStoich = StoichAfr > 0 ? StoichAfr : 14.7;
            double lambda = (v < 5.0) ? v : v / AemGasolineStoich;
            double afr = lambda * userStoich;
            if (lambda < 0.3 || lambda > 4.0) return;   // outside any sane wideband range — reject noise

            var f = new WidebandFrame
            {
                ArrivalUtc    = DateTime.UtcNow,
                Lambda        = lambda,
                Afr           = afr,
                Tc1C          = double.NaN, Tc2C = double.NaN, Tc3C = double.NaN,
                ThermistorC   = double.NaN, ColdJunctionC = double.NaN,
                Rpm           = double.NaN, VssHz = double.NaN, VssSpeed = double.NaN,
                State         = WbSensorState.Operational,   // serial value present ⇒ treat as warm/valid
                IsLite        = true                         // AFR/λ only — no TC / RPM / status fields
            };
            FrameReceived?.Invoke(f);
        }

        private void ParseFrames(List<byte> buf)
        {
            int i = 0;
            while (true)
            {
                // find the next header pair
                int h = -1;
                for (int j = i; j + 1 < buf.Count; j++)
                    if (buf[j] == H0 && buf[j + 1] == H1) { h = j; break; }
                if (h < 0)
                {
                    // no header — keep at most one trailing byte (could be a split 0x5A)
                    if (buf.Count > 1) buf.RemoveRange(0, buf.Count - 1);
                    return;
                }
                if (h > 0) { buf.RemoveRange(0, h); h = 0; }   // drop junk before the header

                // try a 28-byte 2.0 frame first, then a 12-byte 1.5 frame
                if (buf.Count >= Frame20 && ChecksumOk(buf, Frame20))
                {
                    var f = Parse20(buf); buf.RemoveRange(0, Frame20);
                    if (f != null) EmitData(f);
                    i = 0; continue;
                }
                // Only attempt a 12-byte 1.5 decode once a full 28-byte 2.0 frame's worth of bytes
                // is buffered — otherwise Could20Fit can't run and a partial 2.0 frame gets
                // mis-decoded as a 1.5 frame (spurious AFR, real frame discarded). Streaming
                // sensors always have more bytes; the last frame flushes on read-timeout.
                if (buf.Count >= Frame20 && ChecksumOk(buf, Frame15) && !Could20Fit(buf))
                {
                    var f = Parse15(buf); buf.RemoveRange(0, Frame15);
                    if (f != null) EmitData(f);
                    i = 0; continue;
                }
                if (buf.Count < Frame20) return;   // wait for more bytes

                // header present but neither frame validated — resync past this header
                buf.RemoveRange(0, 2);
                i = 0;
            }
        }

        // Route a decoded data frame to the live consumer or the dump consumer.
        private void EmitData(WidebandFrame f)
        {
            if (_dumping) { _dumpFrameCount++; DumpFrameReceived?.Invoke(f); }
            else FrameReceived?.Invoke(f);
        }

        // Called once per read-timeout while dumping; ends the dump after ~1.4 s of silence.
        private void DumpIdleTick(List<byte> buf)
        {
            if (++_dumpIdleTicks < 7) return;     // 7 × 200 ms ReadTimeout ≈ 1.4 s idle
            _dumping = false; Dumping = false; Streaming = false;
            buf.Clear();
            int count = _dumpFrameCount;
            DumpComplete?.Invoke(count);
        }

        // 20-byte 2.0 calibrate frame parser (same 0x5A 0xA5 header + 1's-comp checksum).
        private void ParseCalFrames(List<byte> buf)
        {
            while (true)
            {
                int h = -1;
                for (int j = 0; j + 1 < buf.Count; j++)
                    if (buf[j] == H0 && buf[j + 1] == H1) { h = j; break; }
                if (h < 0) { if (buf.Count > 1) buf.RemoveRange(0, buf.Count - 1); return; }
                if (h > 0) buf.RemoveRange(0, h);

                if (buf.Count >= FrameCal && ChecksumOk(buf, FrameCal))
                {
                    var c = Parse20Cal(buf); buf.RemoveRange(0, FrameCal);
                    if (c != null) CalFrameReceived?.Invoke(c);
                    continue;
                }
                if (buf.Count < FrameCal) return;   // wait for more bytes
                buf.RemoveRange(0, 2);              // resync past a non-validating header
            }
        }

        private WidebandCalFrame Parse20Cal(List<byte> b)
        {
            return new WidebandCalFrame
            {
                ArrivalUtc         = DateTime.UtcNow,
                Sequence           = b[2],
                Ipx                = U16(b, 3),
                HeaterVoltsRaw     = U16(b, 7),
                HeaterAmpsRaw      = U16(b, 9),
                WidebandA16        = U16(b, 11),
                HeaterImpedanceRaw = U16(b, 13),
                OpState            = U16(b, 15),
                StatusWord         = U16(b, 17),
                HeaterVolts        = U16(b, 7) / 51.2,   // htr_vh / 51.2
                HeaterAmps         = U16(b, 9) / 51.2     // htr_hr / 51.2
            };
        }

        // Avoid mis-reading the leading 12 bytes of a real 28-byte frame as a (coincidentally valid)
        // 1.5 frame: only accept a 1.5 frame if a full 28-byte frame does NOT also checksum here.
        private static bool Could20Fit(List<byte> buf)
            => buf.Count >= Frame20 && ChecksumOk(buf, Frame20);

        private static bool ChecksumOk(List<byte> buf, int len)
        {
            int sum = 0;
            for (int k = 0; k < len; k++) sum += buf[k];
            return (sum & 0xFF) == 0xFF;
        }

        private static int U16(List<byte> b, int hi) => (b[hi] << 8) | b[hi + 1];   // big-endian high:low

        private WidebandFrame Parse20(List<byte> b)
        {
            var f = new WidebandFrame
            {
                ArrivalUtc = DateTime.UtcNow,
                Sequence   = b[2],
                TickRaw    = U16(b, 3),
                Lambda16   = U16(b, 5),
                Ipx        = U16(b, 7),
                User1V     = AdcVolts(U16(b, 9)),
                User2V     = AdcVolts(U16(b, 11)),
                User3V     = AdcVolts(U16(b, 13)),
                Tc1Raw     = U16(b, 15),
                Tc2Raw     = U16(b, 17),
                Tc3Raw     = U16(b, 19),
                ThermistorRaw = U16(b, 21),
                RpmCount   = U16(b, 23),
                StatusWord = U16(b, 25)
            };
            Finish(f);
            return f;
        }

        private WidebandFrame Parse15(List<byte> b)
        {
            // 1.5 frame: SVout, User1, User2, RPM-count.  SVout → λ via the documented clamp range
            // (0x068E≈0.102 V rich … 0x199A≈4.00 V free-air); approximate λ linearly across that span.
            int svout = U16(b, 3);
            var f = new WidebandFrame
            {
                ArrivalUtc = DateTime.UtcNow,
                Sequence   = b[2],
                User1V     = AdcVolts(U16(b, 5)),
                User2V     = AdcVolts(U16(b, 7)),
                RpmCount   = U16(b, 9),
                IsLite     = true,
                State      = WbSensorState.Operational
            };
            double svClamped = Math.Max(1678, Math.Min(6554, svout));
            f.Lambda = 0.68 + (svClamped - 1678) / (6554.0 - 1678.0) * (1.36 - 0.68);   // ~0.68 rich … 1.36 lean
            f.Afr = f.Lambda * StoichAfr;
            f.Rpm = RpmFromCount(f.RpmCount);
            return f;
        }

        private void Finish(WidebandFrame f)
        {
            f.DeviceSeconds = f.TickRaw * 0.01;

            // Status/Error is two independent PID bytes: HIGH byte (26) = Vs/Ip wideband PID,
            // LOW byte (27) = heater PID.  Each: bits 7-5 PID code, bit 4 error band, bits 2-0 state.
            int vs = (f.StatusWord >> 8) & 0xFF;     // Vs/Ip (wideband) PID
            int ht = f.StatusWord & 0xFF;            // heater PID
            f.State           = (WbSensorState)(vs & 0x07);
            f.ErrorBand       = (vs & 0x10) != 0;
            f.PidCode         = MapPid((vs >> 5) & 0x07);
            f.HeaterState     = (WbHeaterState)(ht & 0x07);
            f.HeaterErrorBand = (ht & 0x10) != 0;
            f.HeaterPidCode   = MapPid((ht >> 5) & 0x07);

            f.Lambda = f.Lambda16 / 8192.0 + 0.5;
            f.Afr = f.Lambda * StoichAfr;
            f.Rpm = RpmFromCount(f.RpmCount);

            // Byte 22-23 as a vehicle-speed count (2J1 units): 100 µs periods → frequency.
            if (InterpretThermistorAsVss)
            {
                f.VssHz = f.ThermistorRaw > 0 ? 10000.0 / f.ThermistorRaw : 0;
                f.VssSpeed = f.VssHz * VssScale;
            }
            ComputeTemps(f);
        }

        private static WbPidCode MapPid(int code) => code <= 4 ? (WbPidCode)code : WbPidCode.OutputClampHigh;

        /// <summary>Convert the raw thermocouple counts to °C with cold-junction compensation.</summary>
        private void ComputeTemps(WidebandFrame f)
        {
            // The thermistor is a 10-bit count; use it for CJC when configured, else a fixed ambient.
            // When byte 22-23 is being read as a Vss count it is not a thermistor, so fall back to fixed.
            double cj = FixedColdJunctionC;
            if (UseThermistorCjc && !InterpretThermistorAsVss)
            {
                double t = Thermocouple.NtcTempC(f.ThermistorRaw, 1024, NtcSeriesR, NtcR25, NtcBeta);
                if (!double.IsNaN(t)) { f.ThermistorC = t; cj = t; } else f.ThermistorC = double.NaN;
            }
            else f.ThermistorC = double.NaN;
            f.ColdJunctionC = cj;

            f.Tc1C = Thermocouple.ReadTypeK(f.Tc1Raw, TcMillivoltsPerCount, cj);
            f.Tc2C = Thermocouple.ReadTypeK(f.Tc2Raw, TcMillivoltsPerCount, cj);
            f.Tc3C = Thermocouple.ReadTypeK(f.Tc3Raw, TcMillivoltsPerCount, cj);
        }

        private double RpmFromCount(int count)
        {
            // count = 5 µs periods between trigger pulses; pulses/sec = 1e6/(count*5) = 200000/count.
            // RPM = pulses/sec * 60 / pulsesPerRev.  Guard the timed-out / no-signal case.
            if (count <= 0 || count >= 0xFFFF) return 0;
            double pps = 200000.0 / count;
            double ppr = PulsesPerRev <= 0 ? 2.0 : PulsesPerRev;
            return pps * 60.0 / ppr;
        }

        private static double AdcVolts(int raw)
        {
            // 0-5 V inputs are a 10-bit sample left-shifted ×8 (0..8184 ≈ full scale).
            if (raw < 0) raw = 0;
            return raw / 8192.0 * 5.0;
        }
    }
}
