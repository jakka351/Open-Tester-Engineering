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
//  MilcanSyncTracker.cs - the Sync Frame observer: PTU, slots, master, system mode.
//
//  WHY THIS IS ITS OWN TYPE
//  ------------------------
//  The Sync Frame is the whole of MilCAN's determinism. Everything a technician needs
//  to know about whether a MilCAN bus is HEALTHY is derived here: is anyone mastering
//  the bus, at what period, with how much jitter, is the slot counter advancing
//  cleanly, and what mode is the system in. Keeping it separate from the session means
//  it can be driven from a synthetic frame sequence in a self-test with no adapter,
//  no thread and no bus - which is the only way to prove the timeout arithmetic is
//  right without a vehicle.
//
//  THE PTU IS MEASURED, NEVER ASSUMED
//  ----------------------------------
//  MilCAN A §3.2.5.3 recommends 512/128/64 Hz for 1M/500k/250k, but the Sync rate is
//  system specific and retunable through the System Management layer. A tracker that
//  assumed the recommended rate would compute a wrong sync-loss deadline on a system
//  that legitimately runs slower, and would then report a healthy bus as failed. So
//  the PTU is measured from the arrivals themselves; the recommended value is only
//  ever used to LABEL what was measured (see MilcanRegistry.RecommendedPtuMs).
//
//  TIMESTAMPS
//  ----------
//  Callers pass the message timestamp from J1939Message.TimestampMs, which prefers the
//  adapter clock and says so via TimestampSource. Host-clock timing includes driver and
//  scheduling latency, which at a 1.95 ms PTU (1 Mbps) is the same order as the
//  interval being measured - so IsTimingTrustworthy is surfaced rather than letting the
//  UI present soft jitter figures as if they were wire-accurate.
// =============================================================================

using System;
using System.Globalization;

namespace TesterPresent.OBD2.Milcan
{
    /// <summary>
    /// Observes Sync Frames and derives bus health: the measured Primary Time Unit,
    /// slot progression, the current Sync Master, and the system mode
    /// (MWG-MILA-001 Rev 3 §3.2.5.3, §4.1.5.6, §4.2).
    /// </summary>
    /// <remarks>
    /// Not thread-safe. <see cref="MilcanSession"/> drives it from its single pump
    /// thread and snapshots the results under its own lock.
    /// </remarks>
    public sealed class MilcanSyncTracker
    {
        // A short window: enough to smooth a scheduling hiccup, short enough that a
        // genuine rate change is reflected within a fraction of a second at any of the
        // three spec bit rates.
        private const int PTU_WINDOW = 16;

        private readonly double[] _intervals = new double[PTU_WINDOW];
        private int _intervalCount;
        private int _intervalNext;

        private bool _haveLast;
        private double _lastSyncMs;
        private int _lastSlot = -1;
        private byte _masterAddress;
        private bool _haveMaster;

        private long _syncCount;
        private long _slotDiscontinuities;
        private long _masterChanges;
        private bool _timingTrustworthy = true;

        private MilcanSystemMode _mode = MilcanSystemMode.Unknown;

        /// <summary>Number of Sync Frames observed.</summary>
        public long SyncCount { get { return _syncCount; } }

        /// <summary>
        /// Times the slot counter did not advance by exactly one (excluding the clean
        /// 1023 -> 0 wrap). Non-zero means Sync Frames were missed or a master changed
        /// mid-cycle: the schedule the whole bus depends on has been disturbed.
        /// </summary>
        public long SlotDiscontinuities { get { return _slotDiscontinuities; } }

        /// <summary>Times the Sync Master's source address changed. Non-zero means an election occurred.</summary>
        public long MasterChanges { get { return _masterChanges; } }

        /// <summary>True once a Sync Master has been seen.</summary>
        public bool HasMaster { get { return _haveMaster; } }

        /// <summary>Source address of the node currently emitting Sync Frames. Meaningless unless <see cref="HasMaster"/>.</summary>
        public byte MasterAddress { get { return _masterAddress; } }

        /// <summary>Most recent sync slot number (0..1023), or -1 before the first Sync Frame.</summary>
        public int CurrentSlot { get { return _lastSlot; } }

        /// <summary>The system mode inferred from Sync and configuration traffic.</summary>
        public MilcanSystemMode Mode { get { return _mode; } }

        /// <summary>
        /// False when Sync timing was measured against the host clock rather than an
        /// adapter clock. Jitter and PTU figures are then indicative only.
        /// </summary>
        public bool IsTimingTrustworthy { get { return _timingTrustworthy; } }

        /// <summary>
        /// Measured Primary Time Unit in milliseconds - the mean interval between recent
        /// Sync Frames - or 0 before two frames have been seen.
        /// </summary>
        public double MeasuredPtuMs
        {
            get
            {
                if (_intervalCount == 0) return 0.0;

                double sum = 0.0;
                for (int i = 0; i < _intervalCount; i++) sum += _intervals[i];
                return sum / _intervalCount;
            }
        }

        /// <summary>Measured Sync frequency in hertz, or 0 before a PTU is available.</summary>
        public double MeasuredSyncHz
        {
            get
            {
                double ptu = MeasuredPtuMs;
                return ptu > 0.0 ? 1000.0 / ptu : 0.0;
            }
        }

        /// <summary>
        /// Peak absolute deviation from the mean PTU across the measurement window, in
        /// milliseconds. This is the jitter figure a systems engineer cares about: the
        /// schedule reserves worst-case response time per slot, and jitter eats it.
        /// </summary>
        public double PtuJitterMs
        {
            get
            {
                if (_intervalCount < 2) return 0.0;

                double mean = MeasuredPtuMs;
                double worst = 0.0;
                for (int i = 0; i < _intervalCount; i++)
                {
                    double d = Math.Abs(_intervals[i] - mean);
                    if (d > worst) worst = d;
                }
                return worst;
            }
        }

        /// <summary>
        /// Milliseconds after which, with no further Sync Frame, every device on the bus
        /// drops to pre-operational: <see cref="MilcanRegistry.SYNC_LOSS_PTU_THRESHOLD"/>
        /// PTUs (§4.2.2). Zero until a PTU has been measured.
        /// </summary>
        public double SyncLossDeadlineMs
        {
            get { return MeasuredPtuMs * MilcanRegistry.SYNC_LOSS_PTU_THRESHOLD; }
        }

        /// <summary>Timestamp of the most recent Sync Frame, on the same clock the caller supplies.</summary>
        public double LastSyncMs { get { return _lastSyncMs; } }

        /// <summary>True once at least one Sync Frame has been timestamped.</summary>
        public bool HasSync { get { return _haveLast; } }

        /// <summary>
        /// Feeds a Sync Frame to the tracker.
        /// </summary>
        /// <param name="id">The Sync Frame identifier; its source address is the master.</param>
        /// <param name="payload">Frame payload. The slot counter is the first two bytes, little-endian (Table A-2).</param>
        /// <param name="timestampMs">Arrival timestamp, from <c>J1939Message.TimestampMs</c>.</param>
        /// <param name="adapterTimed">True when the timestamp came from the adapter clock rather than the host clock.</param>
        /// <returns>What changed, for the caller to log or surface.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="payload"/> is null.</exception>
        public MilcanSyncObservation OnSyncFrame(MilcanId id, byte[] payload, double timestampMs, bool adapterTimed)
        {
            if (payload == null) throw new ArgumentNullException("payload");

            var observation = new MilcanSyncObservation();
            _syncCount++;

            if (!adapterTimed) _timingTrustworthy = false;

            // A Sync Frame carries a 2-byte slot counter. A short payload is a
            // malformed frame, not a slot 0 - reporting it as slot 0 would fabricate a
            // major-cycle restart that never happened.
            int slot = -1;
            if (payload.Length >= MilcanRegistry.SYNC_PAYLOAD_LENGTH)
            {
                slot = payload[0] | (payload[1] << 8);
                if (slot > MilcanRegistry.SYNC_SLOT_MAX)
                {
                    observation.Anomaly = string.Format(CultureInfo.InvariantCulture,
                        "Sync slot {0} exceeds the 0..{1} range defined by MilCAN A §3.2.5.3.",
                        slot, MilcanRegistry.SYNC_SLOT_MAX);
                    slot = -1;
                }
            }
            else
            {
                observation.Anomaly = string.Format(CultureInfo.InvariantCulture,
                    "Sync Frame carried {0} payload byte(s); MilCAN A defines a 2-byte slot counter.",
                    payload.Length);
            }

            // Master identity. A change is an election having taken place - the spec
            // resolves contention toward the LOWEST source address (§4.1.5.6), so the
            // direction of the change is itself diagnostic.
            if (!_haveMaster)
            {
                _haveMaster = true;
                _masterAddress = id.SourceAddress;
                observation.MasterEstablished = true;
            }
            else if (_masterAddress != id.SourceAddress)
            {
                observation.PreviousMaster = _masterAddress;
                observation.MasterChanged = true;
                _masterChanges++;
                _masterAddress = id.SourceAddress;
            }

            // Slot progression. The clean wrap 1023 -> 0 is expected once per major
            // cycle and is not a discontinuity.
            if (slot >= 0)
            {
                if (_lastSlot >= 0)
                {
                    int expected = (_lastSlot + 1) % MilcanRegistry.SYNC_SLOT_COUNT;
                    if (slot != expected)
                    {
                        _slotDiscontinuities++;
                        observation.SlotDiscontinuity = true;
                        observation.ExpectedSlot = expected;
                    }
                    else if (slot == 0)
                    {
                        observation.MajorCycleWrapped = true;
                    }
                }
                _lastSlot = slot;
            }

            observation.Slot = slot;

            // Interval / PTU measurement.
            if (_haveLast)
            {
                double interval = timestampMs - _lastSyncMs;

                // Guard against a non-monotonic or duplicated timestamp: a zero or
                // negative interval would drag the mean toward zero and make the
                // sync-loss deadline fire immediately.
                if (interval > 0.0)
                {
                    _intervals[_intervalNext] = interval;
                    _intervalNext = (_intervalNext + 1) % PTU_WINDOW;
                    if (_intervalCount < PTU_WINDOW) _intervalCount++;
                    observation.IntervalMs = interval;
                }
            }

            _lastSyncMs = timestampMs;
            _haveLast = true;

            // Any valid Sync Frame means the bus is running: §4.2.2 has devices enter
            // operational mode on receipt of a valid Sync Frame.
            if (_mode != MilcanSystemMode.Operational)
            {
                observation.ModeChangedTo = MilcanSystemMode.Operational;
                _mode = MilcanSystemMode.Operational;
            }

            return observation;
        }

        /// <summary>
        /// Called when the bus is confirmed to have entered system configuration mode.
        /// Sync is suspended there, so sync-loss must NOT then be reported as a fault.
        /// </summary>
        public void OnEnteredConfigurationMode()
        {
            _mode = MilcanSystemMode.SystemConfiguration;

            // Sync is legitimately absent from here on; drop the timing baseline so the
            // first Sync Frame after exit starts a fresh PTU measurement rather than
            // measuring across the whole configuration session.
            _haveLast = false;
            _intervalCount = 0;
            _intervalNext = 0;
            _lastSlot = -1;
        }

        /// <summary>Called when the bus leaves configuration mode: devices return to pre-operational (§4.2.3).</summary>
        public void OnExitedConfigurationMode()
        {
            _mode = MilcanSystemMode.PreOperational;
        }

        /// <summary>
        /// Evaluates liveness against the current clock reading. Called on every pump
        /// iteration so sync loss is detected from the ABSENCE of frames - a condition
        /// no arriving message can announce.
        /// </summary>
        /// <param name="nowMs">Current reading of the same clock used for frame timestamps.</param>
        /// <returns>True when the bus has just transitioned to pre-operational through sync loss.</returns>
        public bool CheckSyncLoss(double nowMs)
        {
            if (_mode != MilcanSystemMode.Operational) return false;
            if (!_haveLast) return false;

            double deadline = SyncLossDeadlineMs;
            if (deadline <= 0.0) return false;

            if ((nowMs - _lastSyncMs) > deadline)
            {
                _mode = MilcanSystemMode.PreOperational;
                _lastSlot = -1;
                return true;
            }

            return false;
        }

        /// <summary>Resets every derived figure. Used when a session restarts on a different bus.</summary>
        public void Reset()
        {
            _intervalCount = 0;
            _intervalNext = 0;
            _haveLast = false;
            _lastSyncMs = 0.0;
            _lastSlot = -1;
            _haveMaster = false;
            _masterAddress = 0;
            _syncCount = 0;
            _slotDiscontinuities = 0;
            _masterChanges = 0;
            _timingTrustworthy = true;
            _mode = MilcanSystemMode.Unknown;
        }
    }

    /// <summary>
    /// What one Sync Frame told the tracker. Every field is an observation, not an
    /// inference: the session logs these verbatim so a trace shows what the bus did.
    /// </summary>
    public sealed class MilcanSyncObservation
    {
        /// <summary>Slot number carried by the frame, or -1 when the payload was malformed.</summary>
        public int Slot { get; set; }

        /// <summary>Interval since the previous Sync Frame in milliseconds, or 0 for the first frame.</summary>
        public double IntervalMs { get; set; }

        /// <summary>True when this frame established the first known Sync Master.</summary>
        public bool MasterEstablished { get; set; }

        /// <summary>True when the Sync Master's source address changed.</summary>
        public bool MasterChanged { get; set; }

        /// <summary>The previous master's address; meaningful only when <see cref="MasterChanged"/>.</summary>
        public byte PreviousMaster { get; set; }

        /// <summary>True when the slot counter did not advance by exactly one.</summary>
        public bool SlotDiscontinuity { get; set; }

        /// <summary>The slot that was expected; meaningful only when <see cref="SlotDiscontinuity"/>.</summary>
        public int ExpectedSlot { get; set; }

        /// <summary>True when the slot counter wrapped 1023 -> 0, completing a major cycle.</summary>
        public bool MajorCycleWrapped { get; set; }

        /// <summary>Non-null when this frame moved the system mode.</summary>
        public MilcanSystemMode? ModeChangedTo { get; set; }

        /// <summary>A tolerated malformation, or null when the frame was clean.</summary>
        public string Anomaly { get; set; }

        /// <summary>True when anything happened worth putting in a log.</summary>
        public bool IsNoteworthy
        {
            get
            {
                return MasterEstablished || MasterChanged || SlotDiscontinuity
                       || ModeChangedTo.HasValue || Anomaly != null;
            }
        }
    }
}
