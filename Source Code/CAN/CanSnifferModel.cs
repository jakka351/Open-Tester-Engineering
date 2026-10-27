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
//  CanSnifferModel.cs — backing store for the CAN sniffer (Keystone A).
//
//  The sniffer used to treat the DataGridView AS its datastore: capture, decode,
//  and grid mutation all happened on one 50 ms UI-thread tick, capped at ~1000 fps,
//  with an O(n) RemoveAt(0) per frame at a 10 000-row ceiling and no record of any
//  frame beyond what the (capped, collapsed) grid held. That defeated the tool's
//  own purpose on a busy bus and made replay / import / search / diff impossible.
//
//  This class is the single source of truth instead:
//    • a background capture thread calls AddFrame() at full bus speed,
//    • the UI timer only READS snapshots and renders them.
//  The grid becomes a view, not the store.
//
//  It is deliberately UI-free and decoder-free so Live Data / exporters / replay
//  can all read the same model. All public members are safe to call from any
//  thread (one lock; the hot path is a per-frame append + a few counter bumps).
// =============================================================================

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TesterPresent.OBD2.CAN
{
    /// <summary>One captured CAN frame, with a host-monotonic 64-bit timestamp.</summary>
    public struct CanFrameRecord
    {
        public long   Seq;          // monotonic sequence number assigned by the model
        public double TimeSec;      // seconds since capture start (unwrapped, host-anchored)
        public uint   CanId;
        public byte[] Data;
        public bool   IsExtended;
        public bool   IsTxEcho;
    }

    /// <summary>Rolled-up state for one CAN ID (sniffer view + statistics).</summary>
    public sealed class CanIdRow
    {
        public uint   CanId;
        public bool   IsExtended;
        public bool   IsTxEcho;
        public byte[] LastData;
        public byte   ChangedMask;   // bit i set => byte i changed on the most recent frame
        public long   Count;
        public double PeriodMs;      // smoothed inter-frame period (0 until 2+ frames seen)
        public double LastSeenSec;
        public double AgeMsAtSnapshot; // ms since this ID last spoke, at snapshot time
    }

    /// <summary>Point-in-time statistics for the header strip.</summary>
    public struct CanSnifferStats
    {
        public long   TotalFrames;
        public long   ErrorFrames;
        public int    UniqueIds;
        public double Fps;
        public double BusLoadPercent;
    }

    public sealed class CanSnifferModel
    {
        private readonly object _lock = new object();

        // ── Ring buffer of every captured frame (for render/export/replay/search) ──
        private CanFrameRecord[] _ring;
        private int  _head;          // next write index
        private int  _count;         // valid entries (<= capacity)
        private long _seq;           // ever-increasing; Seq of the next frame to be written

        // ── Per-ID rollup ──
        private sealed class IdState
        {
            public bool   IsExtended;
            public bool   IsTxEcho;
            public byte[] LastData;
            public byte   ChangedMask;
            public long   Count;
            public double LastSec;
            public double PeriodMs;   // EMA
            public bool   HavePeriod;
        }
        private readonly Dictionary<uint, IdState> _ids = new Dictionary<uint, IdState>();

        // ── Timestamp unwrap (device µs counter is uint, wraps ~71.6 min, resets per connect) ──
        private bool   _haveLastRaw;
        private uint   _lastRawUs;
        private ulong  _accumUs;      // unwrapped device microseconds
        private ulong  _baseUs;       // device time at capture start (first frame)
        private bool   _haveBase;

        // ── Totals / rates ──
        private long _totalFrames;
        private long _errorFrames;
        private long _bits1s;             // CAN bits seen inside the current FPS window
        private long _frames1s;
        private readonly Stopwatch _win = new Stopwatch();
        private double _lastFps;
        private double _lastBusLoad;
        private uint  _baudRate = 500000;

        public CanSnifferModel(int capacity = 500000)
        {
            if (capacity < 1000) capacity = 1000;
            _ring = new CanFrameRecord[capacity];
            _win.Start();
        }

        public int Capacity { get { return _ring.Length; } }

        /// <summary>Set the bus baud so bus-load % can be estimated. Safe to call anytime.</summary>
        public void Configure(uint baudRate)
        {
            lock (_lock) { if (baudRate > 0) _baudRate = baudRate; }
        }

        /// <summary>Wipe all captured data and statistics (keeps the configured baud).</summary>
        public void Clear()
        {
            lock (_lock)
            {
                _head = 0; _count = 0; _seq = 0;
                _ids.Clear();
                _haveLastRaw = false; _accumUs = 0; _haveBase = false; _baseUs = 0;
                _totalFrames = 0; _errorFrames = 0;
                _bits1s = 0; _frames1s = 0; _lastFps = 0; _lastBusLoad = 0;
                _win.Restart();
            }
        }

        /// <summary>Note N bus errors / RX overflows (from J2534 RxStatus flags).</summary>
        public void AddErrors(int n)
        {
            if (n <= 0) return;
            lock (_lock) { _errorFrames += n; }
        }

        /// <summary>
        /// Append one frame. Called from the capture thread. <paramref name="rawDeviceUs"/> is the
        /// device's uint microsecond timestamp; the model unwraps it into host-monotonic time.
        /// </summary>
        public void AddFrame(uint rawDeviceUs, uint canId, byte[] data, bool isExtended, bool isTxEcho)
        {
            if (data == null) data = Array.Empty<byte>();
            lock (_lock)
            {
                // Unwrap the device µs counter into a 64-bit accumulator.
                if (!_haveLastRaw) { _accumUs = rawDeviceUs; _haveLastRaw = true; }
                else
                {
                    if (rawDeviceUs >= _lastRawUs) _accumUs += (ulong)(rawDeviceUs - _lastRawUs);
                    else _accumUs += (ulong)((0x100000000UL - _lastRawUs) + rawDeviceUs); // wrap
                }
                _lastRawUs = rawDeviceUs;
                if (!_haveBase) { _baseUs = _accumUs; _haveBase = true; }
                double tSec = (_accumUs - _baseUs) / 1_000_000.0;
                AppendCoreLocked(tSec, canId, data, isExtended, isTxEcho);
            }
        }

        /// <summary>
        /// Append a frame with an explicit relative timestamp (for imported captures / replay preview).
        /// Bypasses the device-counter unwrap. Not for live capture — use AddFrame there.
        /// </summary>
        public void AddImportedFrame(double timeSec, uint canId, byte[] data, bool isExtended, bool isTxEcho)
        {
            if (data == null) data = Array.Empty<byte>();
            lock (_lock)
            {
                if (!_haveBase) { _baseUs = 0; _haveBase = true; }
                // Advance the clock to the latest imported timestamp every call, or SnapshotIds
                // computes age against the FIRST frame's time and reports negative ages.
                _accumUs = (ulong)Math.Max(0, timeSec * 1_000_000.0);
                AppendCoreLocked(timeSec, canId, data, isExtended, isTxEcho);
            }
        }

        // Shared append + per-ID rollup + totals. Caller holds _lock.
        private void AppendCoreLocked(double tSec, uint canId, byte[] data, bool isExtended, bool isTxEcho)
        {
            {
                // Ring append.
                var rec = new CanFrameRecord
                {
                    Seq = _seq,
                    TimeSec = tSec,
                    CanId = canId,
                    Data = data,
                    IsExtended = isExtended,
                    IsTxEcho = isTxEcho
                };
                _ring[_head] = rec;
                _head = (_head + 1) % _ring.Length;
                if (_count < _ring.Length) _count++;
                _seq++;

                // Per-ID rollup + changed-byte mask.
                IdState st;
                if (!_ids.TryGetValue(canId, out st))
                {
                    st = new IdState { IsExtended = isExtended, LastData = data, ChangedMask = 0 };
                    _ids[canId] = st;
                }
                else
                {
                    byte mask = 0;
                    byte[] prev = st.LastData ?? Array.Empty<byte>();
                    int n = Math.Min(8, Math.Max(prev.Length, data.Length));
                    for (int i = 0; i < n; i++)
                    {
                        byte a = i < prev.Length ? prev[i] : (byte)0;
                        byte b = i < data.Length ? data[i] : (byte)0;
                        if (a != b) mask |= (byte)(1 << i);
                    }
                    st.ChangedMask = mask;
                    st.LastData = data;
                    // EMA of the inter-frame period.
                    double dtMs = (tSec - st.LastSec) * 1000.0;
                    if (dtMs > 0 && dtMs < 60000)
                    {
                        st.PeriodMs = st.HavePeriod ? (st.PeriodMs * 0.8 + dtMs * 0.2) : dtMs;
                        st.HavePeriod = true;
                    }
                }
                st.IsExtended = isExtended;
                st.IsTxEcho = isTxEcho;
                st.LastSec = tSec;
                st.Count++;

                // Totals / bus-load accounting.
                _totalFrames++;
                _frames1s++;
                _bits1s += EstimateFrameBits(isExtended, data.Length);

                RollWindowLocked();
            }
        }

        // Approximate on-wire bit count for bus-load: SOF + arbitration + control + data + CRC +
        // delim/ACK/EOF/IFS, inflated ~10% for average bit-stuffing. Good enough for a health gauge.
        private static long EstimateFrameBits(bool extended, int dlc)
        {
            int overhead = extended ? 67 : 47; // incl. inter-frame space
            int bits = overhead + dlc * 8;
            return (long)(bits * 1.1);
        }

        private void RollWindowLocked()
        {
            double el = _win.Elapsed.TotalSeconds;
            if (el >= 0.5)
            {
                _lastFps = _frames1s / el;
                if (_baudRate > 0)
                {
                    double load = (_bits1s / el) / _baudRate * 100.0;
                    _lastBusLoad = load > 100 ? 100 : load;
                }
                _frames1s = 0; _bits1s = 0;
                _win.Restart();
            }
        }

        public CanSnifferStats GetStats()
        {
            lock (_lock)
            {
                RollWindowLocked();
                return new CanSnifferStats
                {
                    TotalFrames = _totalFrames,
                    ErrorFrames = _errorFrames,
                    UniqueIds = _ids.Count,
                    Fps = _lastFps,
                    BusLoadPercent = _lastBusLoad
                };
            }
        }

        /// <summary>Current sequence number (Seq the next frame will get). Cursor baseline for dump view.</summary>
        public long CurrentSeq { get { lock (_lock) return _seq; } }

        /// <summary>
        /// Copy frames with Seq &gt;= <paramref name="sinceSeq"/> into <paramref name="dst"/> (up to
        /// <paramref name="max"/>), oldest first, and return the next cursor. Frames that have already
        /// scrolled out of the ring are skipped (their loss is reported via droppedFromRing).
        /// </summary>
        public long GetSince(long sinceSeq, int max, List<CanFrameRecord> dst, out long droppedFromRing)
        {
            droppedFromRing = 0;
            lock (_lock)
            {
                if (_count == 0) return _seq;
                long oldest = _seq - _count;              // Seq of the oldest frame still in the ring
                if (sinceSeq < oldest) { droppedFromRing = oldest - sinceSeq; sinceSeq = oldest; }
                long take = _seq - sinceSeq;
                if (take <= 0) return _seq;
                if (take > max) take = max;

                // Index of sinceSeq in the ring.
                int startBack = (int)(_seq - sinceSeq);   // how far back from head
                int idx = ((_head - startBack) % _ring.Length + _ring.Length) % _ring.Length;
                for (long i = 0; i < take; i++)
                {
                    dst.Add(_ring[idx]);
                    idx = (idx + 1) % _ring.Length;
                }
                return sinceSeq + take;
            }
        }

        /// <summary>Snapshot of all per-ID rows, sorted by CAN ID (for sniffer view + summaries).</summary>
        public List<CanIdRow> SnapshotIds()
        {
            lock (_lock)
            {
                double nowSec = _haveBase ? (_accumUs - _baseUs) / 1_000_000.0 : 0;
                var list = new List<CanIdRow>(_ids.Count);
                foreach (var kv in _ids)
                {
                    var s = kv.Value;
                    list.Add(new CanIdRow
                    {
                        CanId = kv.Key,
                        IsExtended = s.IsExtended,
                        IsTxEcho = s.IsTxEcho,
                        LastData = s.LastData,
                        ChangedMask = s.ChangedMask,
                        Count = s.Count,
                        PeriodMs = s.HavePeriod ? s.PeriodMs : 0,
                        LastSeenSec = s.LastSec,
                        AgeMsAtSnapshot = (nowSec - s.LastSec) * 1000.0
                    });
                }
                list.Sort((a, b) => a.CanId.CompareTo(b.CanId));
                return list;
            }
        }

        /// <summary>Per-ID cumulative counts (id → count) for report/summary export.</summary>
        public Dictionary<uint, long> SnapshotCounts()
        {
            lock (_lock)
            {
                var d = new Dictionary<uint, long>(_ids.Count);
                foreach (var kv in _ids) d[kv.Key] = kv.Value.Count;
                return d;
            }
        }

        /// <summary>All frames currently in the ring, oldest first (for CSV/ASC/replay export).</summary>
        public List<CanFrameRecord> SnapshotAll()
        {
            lock (_lock)
            {
                var list = new List<CanFrameRecord>(_count);
                int idx = ((_head - _count) % _ring.Length + _ring.Length) % _ring.Length;
                for (int i = 0; i < _count; i++)
                {
                    list.Add(_ring[idx]);
                    idx = (idx + 1) % _ring.Length;
                }
                return list;
            }
        }

        /// <summary>Most recent data bytes seen for a given ID, or null.</summary>
        public byte[] LastDataFor(uint canId)
        {
            lock (_lock)
            {
                IdState s;
                return _ids.TryGetValue(canId, out s) ? s.LastData : null;
            }
        }
    }
}
