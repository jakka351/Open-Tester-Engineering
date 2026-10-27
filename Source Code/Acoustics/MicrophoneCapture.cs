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
//  Tester Present Specialist Automotive Solutions — Acoustic Diagnostics: microphone capture
//  Copyright (c) 2026 Benjamin Jack Leighton. All rights reserved.
//
//  Orchestrates raw-mode WASAPI capture (Acoustics\WasapiRawCapture) into the reused lock-free
//  Scope\ScopeRingBuffer, with optional WAV recording. The raw-capable capture asks the audio
//  engine to bypass the endpoint APO (Realtek AGC / noise suppression); RawGranted reports whether
//  the request was honoured so the UI can tell the operator the truth about the signal path.
//
//  Device ENUMERATION stays on NAudio's MMDeviceEnumerator — it lists every active capture
//  endpoint, so the built-in laptop microphone AND any USB microphone both appear and either can
//  be selected. WAV recording uses NAudio's WaveFileWriter. The low-level capture is hand-rolled
//  because NAudio's WasapiCapture offers no seam to enable raw mode.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using TesterPresent.OBD2.Scope;

namespace TesterPresent.OBD2.Acoustics
{
    /// <summary>One selectable audio capture endpoint.</summary>
    public sealed class AudioInputDevice
    {
        public string Id;
        public string Name;
        public bool IsDefault;
        public override string ToString() => Name;
    }

    public sealed class MicrophoneCapture : IDisposable
    {
        private WasapiRawCapture _raw;
        private WaveFileWriter _writer;
        private readonly object _writerLock = new object();
        private long _peakRaw;          // fixed-point ×1e6 of running max |sample|, via Interlocked
        private volatile bool _started;

        public ScopeRingBuffer Ring { get; private set; }
        public int SampleRate { get; private set; }
        public int Channels { get; private set; }
        public string DeviceName { get; private set; }
        public bool RawGranted { get; private set; }
        public bool IsRecording { get { lock (_writerLock) return _writer != null; } }

        /// <summary>Enumerate active capture endpoints; the system default is flagged and sorted first.</summary>
        public static List<AudioInputDevice> Enumerate()
        {
            var list = new List<AudioInputDevice>();
            try
            {
                using (var mm = new MMDeviceEnumerator())
                {
                    string defId = null;
                    try
                    {
                        using (var def = mm.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Communications))
                            defId = def?.ID;
                    }
                    catch { }

                    foreach (var dev in mm.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active))
                    {
                        using (dev)
                        {
                            list.Add(new AudioInputDevice
                            {
                                Id = dev.ID,
                                Name = dev.FriendlyName,
                                IsDefault = dev.ID == defId,
                            });
                        }
                    }
                }
            }
            catch { /* enumeration can throw on locked-down endpoints — return what we have */ }

            list.Sort((a, b) => a.IsDefault != b.IsDefault
                ? (a.IsDefault ? -1 : 1)
                : string.Compare(a.Name, b.Name, StringComparison.OrdinalIgnoreCase));
            return list;
        }

        private static string ResolveName(string deviceId)
        {
            try
            {
                using (var mm = new MMDeviceEnumerator())
                {
                    if (string.IsNullOrEmpty(deviceId))
                        using (var def = mm.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Communications))
                            return def?.FriendlyName ?? "(default microphone)";
                    using (var d = mm.GetDevice(deviceId)) return d?.FriendlyName ?? deviceId;
                }
            }
            catch { return deviceId ?? "(microphone)"; }
        }

        /// <summary>Open the given endpoint (null/empty = system default) and begin capturing.</summary>
        public void Start(string deviceId)
        {
            Stop();
            // Ring capacity is fixed and sample-rate independent, so create it before the capture
            // thread can deliver its first block — no null-Ring race in OnMono.
            Ring = new ScopeRingBuffer(1 << 18);   // ~5.5 s at 48 kHz
            _peakRaw = 0;
            DeviceName = ResolveName(deviceId);

            var raw = new WasapiRawCapture();
            raw.MonoAvailable += OnMono;
            try
            {
                raw.Start(deviceId, preferRaw: true);
            }
            catch
            {
                raw.MonoAvailable -= OnMono;
                try { raw.Dispose(); } catch { }
                throw;
            }
            _raw = raw;
            SampleRate = raw.SampleRate;
            Channels = raw.Channels;
            RawGranted = raw.RawGranted;
            _started = true;
        }

        private void OnMono(float[] mono, int count)
        {
            if (count <= 0) return;
            Ring?.Write(mono, 0, count);

            double peak = 0;
            for (int i = 0; i < count; i++) { float a = mono[i] < 0 ? -mono[i] : mono[i]; if (a > peak) peak = a; }
            long pk = (long)(peak * 1_000_000);
            long cur = System.Threading.Interlocked.Read(ref _peakRaw);
            if (pk > cur) System.Threading.Interlocked.Exchange(ref _peakRaw, pk);

            lock (_writerLock)
            {
                if (_writer != null) { try { _writer.WriteSamples(mono, 0, count); } catch { } }
            }
        }

        /// <summary>Peak |sample| since the last call, then resets the hold (for a clip LED).</summary>
        public double ReadAndResetPeak()
        {
            long pk = System.Threading.Interlocked.Exchange(ref _peakRaw, 0);
            return pk / 1_000_000.0;
        }

        // ── recording ────────────────────────────────────────────────────────────────
        public void StartRecording(string path)
        {
            if (!_started) throw new InvalidOperationException("Capture is not running.");
            lock (_writerLock)
            {
                StopRecordingLocked();
                _writer = new WaveFileWriter(path, WaveFormat.CreateIeeeFloatWaveFormat(SampleRate, 1));
            }
        }

        public void StopRecording() { lock (_writerLock) StopRecordingLocked(); }

        private void StopRecordingLocked()
        {
            if (_writer != null)
            {
                try { _writer.Flush(); _writer.Dispose(); } catch { }
                _writer = null;
            }
        }

        public void Stop()
        {
            _started = false;
            StopRecording();
            if (_raw != null)
            {
                try { _raw.MonoAvailable -= OnMono; } catch { }
                try { _raw.Stop(); } catch { }
                try { _raw.Dispose(); } catch { }
                _raw = null;
            }
        }

        public void Dispose() => Stop();
    }
}
