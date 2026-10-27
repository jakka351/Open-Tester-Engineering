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
//  Tester Present Specialist Automotive Solutions — Wideband serial data source
//
//  WidebandStreamSource.cs — adapts the Tech Edge WBo2 serial driver (WidebandSerial) into the
//  same data shape the Live Diagnostics / Signal Analyser pipeline already consumes: a list of
//  PidReading keyed by a stable ShortName.  This lets wideband AFR / Lambda / EGT / RPM be
//  streamed, graphed and recorded ALONGSIDE J2534 PID data with no changes to the J2534 path —
//  the form's pump timer snapshots this source each tick and feeds the grid, graphMain and the
//  DataLogger exactly like a poll cycle does.
//
//  Thread model: WidebandSerial.FrameReceived fires on its reader thread; we snapshot the latest
//  frame under a lock.  Snapshot() is called from the UI thread (the pump timer) and reads that
//  snapshot.  Start/Stop are UI-thread only.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using TesterPresent.OBD2;   // OBD2Pid, PidReading

namespace TesterPresent.OBD2.Wideband
{
    public sealed class WidebandStreamSource : IDisposable
    {
        // Fixed channel set.  ShortName is the stable key used as the graph series name, the CSV
        // column and the live-grid row tag — it must match across all three sinks.  PID stays 0:
        // these never route through the PidHex-keyed J2534 grid/index, only through ShortName.
        public static readonly OBD2Pid[] AllChannels =
        {
            Ch("WB AFR",    "Wideband Air/Fuel Ratio", "AFR",  8,   22),
            Ch("WB Lambda", "Wideband Lambda",         "λ", 0.6, 1.4),
            Ch("WB EGT1",   "Exhaust Gas Temp 1",      "°C", 0, 1000),
            Ch("WB EGT2",   "Exhaust Gas Temp 2",      "°C", 0, 1000),
            Ch("WB EGT3",   "Exhaust Gas Temp 3",      "°C", 0, 1000),
            Ch("WB RPM",    "Wideband RPM",            "rpm",  0, 8000),
            Ch("WB VSS",    "Wideband Vehicle Speed",  "",     0,  250),
        };

        private WidebandSerial _dev;
        private readonly object _lock = new object();
        private WidebandFrame _last;
        private readonly HashSet<string> _enabled = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        public bool   IsStreaming { get; private set; }
        public string PortName    { get; private set; } = "";
        public int    Baud        { get; private set; }
        public double StoichAfr   { get; private set; } = 14.7;

        /// <summary>Fatal port/parse error from the device reader thread (forwarded).</summary>
        public event Action<string> Error;

        public IEnumerable<OBD2Pid> EnabledChannels => AllChannels.Where(c => _enabled.Contains(c.ShortName));

        public void Start(string port, int baud, IEnumerable<string> enabledChannels, double stoichAfr)
        {
            Stop();
            StoichAfr = stoichAfr > 0 ? stoichAfr : 14.7;
            _enabled.Clear();
            if (enabledChannels != null)
                foreach (var n in enabledChannels) _enabled.Add(n);
            if (_enabled.Count == 0)            // default-on set when the caller passes nothing
                foreach (var n in new[] { "WB AFR", "WB Lambda", "WB EGT1", "WB RPM" }) _enabled.Add(n);

            var dev = new WidebandSerial { StoichAfr = StoichAfr, TcCelsius = true };
            dev.FrameReceived += OnFrame;
            dev.Error += OnError;
            dev.Open(port, baud);              // throws if the COM port is busy/missing — caller handles
            dev.StartStream();
            _dev = dev;
            PortName = port; Baud = baud; IsStreaming = true;
        }

        public void Stop()
        {
            IsStreaming = false;
            var d = _dev; _dev = null;
            if (d != null)
            {
                d.FrameReceived -= OnFrame;
                d.Error -= OnError;
                try { d.StopStream(); } catch { }
                try { d.Close(); } catch { }
            }
            lock (_lock) { _last = null; }
        }

        private void OnFrame(WidebandFrame f) { lock (_lock) { _last = f; } }
        private void OnError(string msg) => Error?.Invoke(msg);

        /// <summary>Build PidReadings for the enabled channels from the latest frame. Skips NaN
        /// channels (e.g. an EGT input with no probe) so dead channels don't graph as zero.</summary>
        public List<PidReading> Snapshot()
        {
            WidebandFrame f;
            lock (_lock) { f = _last; }
            var list = new List<PidReading>(AllChannels.Length);
            if (f == null) return list;

            void Add(string shortName, double val)
            {
                if (double.IsNaN(val) || double.IsInfinity(val)) return;
                if (!_enabled.Contains(shortName)) return;
                var def = AllChannels.First(c => c.ShortName == shortName);
                list.Add(new PidReading { Definition = def, Value = val, Timestamp = DateTime.Now });
            }

            Add("WB AFR",    f.Afr);
            Add("WB Lambda", f.Lambda);
            Add("WB EGT1",   f.Tc1C);
            Add("WB EGT2",   f.Tc2C);
            Add("WB EGT3",   f.Tc3C);
            Add("WB RPM",    f.Rpm);
            Add("WB VSS",    f.VssSpeed);
            return list;
        }

        private static OBD2Pid Ch(string shortName, string name, string unit, double min, double max)
            => new OBD2Pid { ShortName = shortName, Name = name, Unit = unit, MinValue = min, MaxValue = max, PID = 0, IsGaugePid = false };

        public void Dispose() => Stop();
    }
}
