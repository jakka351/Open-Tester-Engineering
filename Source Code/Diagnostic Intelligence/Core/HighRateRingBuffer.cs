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
//  Tester Present Specialist Automotive Solutions — High-Rate Ring Buffer (shared capture primitive)
//
//  A fixed-capacity, oldest-overwrite circular buffer of TimedValue samples for
//  1–100+ Hz signal streams.  The capture thread pushes samples via Add() while
//  analysis threads read windowed slices concurrently, so every operation is
//  guarded by a single private lock.  All reads return copies — the internal
//  array is never exposed, which keeps callers safe from torn state and keeps
//  the buffer reusable across M2 (drift), M5 (intermittent capture), and the
//  T-series time-domain testers.
//
//  The pre-trigger freeze (FreezePreTrigger) exists for M5: when an event fires
//  we want the N samples that led up to it, already sitting in the ring.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace TesterPresent.OBD2.Intelligence
{
    /// <summary>
    /// Thread-safe fixed-capacity circular buffer of <see cref="TimedValue"/> samples.
    /// Writes overwrite the oldest sample once full; all reads return independent copies.
    /// Designed for high-rate (1–100+ Hz) capture on a background thread with concurrent
    /// analysis reads.
    /// </summary>
    public sealed class HighRateRingBuffer
    {
        private readonly object _lock = new object();
        private readonly TimedValue[] _buffer;
        private int _head;   // index where the NEXT sample will be written
        private int _count;  // number of valid samples currently held (<= Capacity)

        /// <summary>
        /// Create a ring buffer holding up to <paramref name="capacity"/> samples.
        /// </summary>
        /// <param name="capacity">Maximum sample count; clamped to a minimum of 1.</param>
        public HighRateRingBuffer(int capacity)
        {
            if (capacity < 1) capacity = 1;
            _buffer = new TimedValue[capacity];
            _head = 0;
            _count = 0;
        }

        /// <summary>Maximum number of samples this buffer retains.</summary>
        public int Capacity => _buffer.Length;

        /// <summary>Number of samples currently held (never exceeds <see cref="Capacity"/>).</summary>
        public int Count
        {
            get { lock (_lock) { return _count; } }
        }

        /// <summary>Append a sample with an explicit UTC timestamp, overwriting the oldest if full.</summary>
        /// <param name="value">The scalar sample value.</param>
        /// <param name="utc">The sample timestamp (UTC).</param>
        public void Add(double value, DateTime utc)
        {
            lock (_lock)
            {
                _buffer[_head] = new TimedValue(utc, value);
                _head = (_head + 1) % _buffer.Length;
                if (_count < _buffer.Length) _count++;
            }
        }

        /// <summary>Append a sample stamped with <see cref="DateTime.UtcNow"/>.</summary>
        /// <param name="value">The scalar sample value.</param>
        public void Add(double value) => Add(value, DateTime.UtcNow);

        /// <summary>
        /// Copy of every held sample, ordered oldest → newest.
        /// </summary>
        public IReadOnlyList<TimedValue> Snapshot()
        {
            lock (_lock)
            {
                return CopyRangeLocked(_count);
            }
        }

        /// <summary>
        /// Copy of the held sample values only, ordered oldest → newest.
        /// </summary>
        public IReadOnlyList<double> Values()
        {
            lock (_lock)
            {
                var result = new double[_count];
                int start = StartIndexLocked();
                for (int i = 0; i < _count; i++)
                    result[i] = _buffer[(start + i) % _buffer.Length].Value;
                return result;
            }
        }

        /// <summary>
        /// Copy of the most recent <paramref name="n"/> samples (or fewer if not yet filled),
        /// ordered oldest → newest.
        /// </summary>
        /// <param name="n">Requested sample count; values &lt;= 0 return an empty list.</param>
        public IReadOnlyList<TimedValue> LastN(int n)
        {
            lock (_lock)
            {
                if (n <= 0 || _count == 0) return Array.Empty<TimedValue>();
                int take = n < _count ? n : _count;
                return CopyLastLocked(take);
            }
        }

        /// <summary>
        /// Copy of every sample whose timestamp is within <paramref name="seconds"/> of the
        /// newest sample, ordered oldest → newest.
        /// </summary>
        /// <param name="seconds">Window length in seconds relative to the newest sample.</param>
        public IReadOnlyList<TimedValue> LastSeconds(double seconds)
        {
            lock (_lock)
            {
                if (_count == 0) return Array.Empty<TimedValue>();
                int start = StartIndexLocked();
                int newest = (start + _count - 1) % _buffer.Length;
                DateTime cut = _buffer[newest].Utc.AddSeconds(-seconds);

                // Walk newest → oldest to find how many samples fall inside the window.
                int inWindow = 0;
                for (int i = _count - 1; i >= 0; i--)
                {
                    if (_buffer[(start + i) % _buffer.Length].Utc >= cut) inWindow++;
                    else break;
                }
                return CopyLastLocked(inWindow);
            }
        }

        /// <summary>
        /// Snapshot copy of the last <paramref name="preCount"/> samples for an M5
        /// pre-trigger window (the samples leading up to an event), oldest → newest.
        /// Returns an empty array when <paramref name="preCount"/> &lt;= 0.
        /// </summary>
        /// <param name="preCount">How many pre-trigger samples to retain.</param>
        public TimedValue[] FreezePreTrigger(int preCount)
        {
            lock (_lock)
            {
                if (preCount <= 0 || _count == 0) return Array.Empty<TimedValue>();
                int take = preCount < _count ? preCount : _count;
                // CopyLastLocked already returns a fresh TimedValue[] copy.
                return CopyLastLocked(take);
            }
        }

        /// <summary>
        /// Estimated sample rate (Hz) computed as (Count-1) / span between the oldest
        /// and newest timestamps; 0 when fewer than two samples are held.
        /// </summary>
        public double EstimatedHz
        {
            get
            {
                lock (_lock)
                {
                    if (_count < 2) return 0;
                    int start = StartIndexLocked();
                    int newest = (start + _count - 1) % _buffer.Length;
                    double span = (_buffer[newest].Utc - _buffer[start].Utc).TotalSeconds;
                    return span > 1e-6 ? (_count - 1) / span : 0;
                }
            }
        }

        /// <summary>Discard all held samples; capacity is unchanged.</summary>
        public void Clear()
        {
            lock (_lock)
            {
                _head = 0;
                _count = 0;
            }
        }

        // ── internals (all callers already hold _lock) ─────────────────────────

        /// <summary>Index of the oldest held sample. Caller must hold <see cref="_lock"/>.</summary>
        private int StartIndexLocked()
        {
            // When not full, samples occupy [0.._count); when full, the oldest sits at _head.
            if (_count < _buffer.Length) return 0;
            return _head;
        }

        /// <summary>Copy the oldest <paramref name="take"/> samples. Caller must hold <see cref="_lock"/>.</summary>
        private TimedValue[] CopyRangeLocked(int take)
        {
            var result = new TimedValue[take];
            int start = StartIndexLocked();
            for (int i = 0; i < take; i++)
                result[i] = _buffer[(start + i) % _buffer.Length];
            return result;
        }

        /// <summary>Copy the newest <paramref name="take"/> samples, oldest → newest. Caller must hold <see cref="_lock"/>.</summary>
        private TimedValue[] CopyLastLocked(int take)
        {
            if (take <= 0) return Array.Empty<TimedValue>();
            var result = new TimedValue[take];
            int start = StartIndexLocked();
            int offset = _count - take; // skip the older samples
            for (int i = 0; i < take; i++)
                result[i] = _buffer[(start + offset + i) % _buffer.Length];
            return result;
        }
    }
}
