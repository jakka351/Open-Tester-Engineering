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
// =============================================================================
//  CanJazzSynth.cs — "Diagnosis as Jazz" audio engine for the CAN sniffer.
//
//  A polyphonic software synth exposed to NAudio as an ISampleProvider: one VOICE
//  per live CAN ID. The managed jazz controller (MainForm.CANSniffer.Jazz.cs) pushes
//  per-ID targets each ~40 ms tick — a scale-quantised pitch, a health->detune amount,
//  a sustain level and a per-frame pluck — and the audio thread renders them here.
//
//  The diagnostic idea: a healthy periodic module holds a steady, in-tune note; a
//  module whose frames go overdue bends FLAT and wobbles (the "sour note") before it
//  fades out — i.e. you HEAR a module drop off the bus. Bus error frames add a rattle.
//
//  Threading: the controller mutates voice targets under _lock on the UI thread; Read()
//  snapshots the voice list under a short lock and renders lock-free (float target
//  updates may tear across a buffer boundary — inaudible, and never crashes).
// =============================================================================
using System;
using System.Collections.Generic;
using NAudio.Wave;

namespace TesterPresent.OBD2.CAN
{
    public sealed class CanJazzSynth : ISampleProvider
    {
        public WaveFormat WaveFormat { get; }

        private sealed class Voice
        {
            public double Phase;
            public double VibPhase;
            public float  Freq;      // target base Hz (already scale-quantised)
            public float  CurFreq;   // smoothed current Hz (glide)
            public float  Detune;    // frequency multiplier from health cents (1.0 = in tune)
            public float  Sustain;   // target sustained level (continuous hum of fast IDs)
            public float  Level;     // smoothed sustained level
            public float  Pluck;     // pluck envelope 0..1, decays after each frame burst
            public float  Vib;       // vibrato depth 0..1 (erratic / dying timing)
            public float  Bright;    // added harmonics 0..1 (data liveliness)
            public long   LastTouch; // controller tick when last Apply'd (for retirement)
        }

        private readonly int    _sr;
        private readonly object _lock = new object();
        private readonly Dictionary<uint, Voice> _voices = new Dictionary<uint, Voice>();
        private Voice[] _scratch = new Voice[32];
        private long  _tick;
        private float _master = 0.6f;
        private float _noise;                 // error-rattle level (decays)
        private uint  _rng = 0x1234567u;

        public float Master { get { return _master; } set { _master = value < 0f ? 0f : value > 1f ? 1f : value; } }
        public int   ActiveVoices { get { lock (_lock) return _voices.Count; } }

        public CanJazzSynth(int sampleRate = 44100)
        {
            _sr = sampleRate;
            WaveFormat = NAudio.Wave.WaveFormat.CreateIeeeFloatWaveFormat(sampleRate, 1);   // mono float
        }

        /// <summary>Stamp the current controller tick before an Apply() batch (drives retirement).</summary>
        public void Bump(long tick) { lock (_lock) { _tick = tick; } }

        /// <summary>Push one ID's target state. pluck &gt; 0 retriggers the note (new frames arrived).</summary>
        public void Apply(uint id, float freqHz, float detuneMult, float sustain, float pluck, float vib, float bright)
        {
            if (freqHz < 20f) freqHz = 20f;
            lock (_lock)
            {
                Voice v;
                if (!_voices.TryGetValue(id, out v)) { v = new Voice { CurFreq = freqHz, Detune = 1f }; _voices[id] = v; }
                v.Freq = freqHz; v.Detune = detuneMult; v.Sustain = sustain; v.Vib = vib; v.Bright = bright;
                if (pluck > v.Pluck) v.Pluck = pluck;
                v.LastTouch = _tick;
            }
        }

        /// <summary>Drop voices untouched for staleTicks that have already faded to silence.</summary>
        public void Sweep(long staleTicks)
        {
            lock (_lock)
            {
                List<uint> dead = null;
                foreach (var kv in _voices)
                {
                    var v = kv.Value;
                    if (_tick - v.LastTouch > staleTicks && v.Level < 0.001f && v.Pluck < 0.001f)
                        (dead ?? (dead = new List<uint>())).Add(kv.Key);
                }
                if (dead != null) foreach (var id in dead) _voices.Remove(id);
            }
        }

        /// <summary>Add a burst of filtered noise — bus error / fault frames rattle the kit.</summary>
        public void Rattle(float amt) { float n = _noise + amt; _noise = n > 1f ? 1f : n; }

        public void AllOff() { lock (_lock) { _voices.Clear(); _noise = 0f; } }

        public int Read(float[] buffer, int offset, int count)
        {
            int nv;
            lock (_lock)
            {
                nv = _voices.Count;
                if (_scratch.Length < nv) _scratch = new Voice[nv + 8];
                _voices.Values.CopyTo(_scratch, 0);
            }
            Voice[] vs = _scratch;

            const double TAU = 6.283185307179586;
            double dt        = 1.0 / _sr;
            float  pluckDecay = (float)Math.Exp(-dt / 0.22);   // ~220 ms pluck tail
            float  lvlGlide   = (float)(1.0 - Math.Exp(-dt / 0.03));
            float  frqGlide   = (float)(1.0 - Math.Exp(-dt / 0.05));
            float  noiseDecay = (float)Math.Exp(-dt / 0.06);
            float  master     = _master * 0.5f;

            for (int n = 0; n < count; n++)
            {
                float mix = 0f;
                for (int i = 0; i < nv; i++)
                {
                    var v = vs[i];
                    v.Level += (v.Sustain - v.Level) * lvlGlide;
                    v.Pluck *= pluckDecay;
                    float amp = v.Level * 0.6f + v.Pluck * 0.6f;
                    if (amp < 0.00025f) continue;

                    v.CurFreq += (v.Freq - v.CurFreq) * frqGlide;
                    float f = v.CurFreq * v.Detune;
                    if (v.Vib > 0.001f)
                    {
                        v.VibPhase += TAU * 5.5 * dt;
                        f *= (float)(1.0 + v.Vib * 0.03 * Math.Sin(v.VibPhase));
                    }
                    v.Phase += TAU * f * dt;
                    if (v.Phase > TAU) v.Phase -= TAU;

                    double s = Math.Sin(v.Phase);
                    if (v.Bright > 0.01f)
                        s += v.Bright * 0.30 * Math.Sin(2.0 * v.Phase) + v.Bright * 0.12 * Math.Sin(3.0 * v.Phase);
                    mix += (float)s * amp;
                }

                if (_noise > 0.001f)
                {
                    _rng = _rng * 1664525u + 1013904223u;
                    float wn = ((_rng >> 8) & 0xFFFFFF) / 8388608f - 1f;   // white noise ~[-1,1]
                    mix += wn * _noise * 0.18f;
                    _noise *= noiseDecay;
                }

                mix *= master;
                if (mix > 1f) mix = 1f; else if (mix < -1f) mix = -1f;
                mix = mix - 0.16666667f * mix * mix * mix;   // gentle cubic soft-clip
                buffer[offset + n] = mix;
            }
            return count;
        }
    }
}
