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
//  MilcanSession.cs - the orchestrator that makes the MilCAN stack live.
//
//  WHAT THIS IS
//  ------------
//  MilcanId, MilcanSyncTracker, MilcanTransport, MilcanNodeTable and
//  MilcanConfigModeWatcher are all passive: no threads, no hardware. This class is the
//  join. It owns ONE pump thread, drives every state machine from it, and turns frames
//  into events the UI can render. It is modelled directly on J1939Session because the
//  two solve the same problem on the same wire, and a technician switching between the
//  J1939 HEAVY and MILCAN workspaces should not be reasoning about two different
//  threading contracts.
//
//  IT RIDES IJ1939Link ON PURPOSE
//  ------------------------------
//  MilCAN A is 29-bit CAN at 250/500k/1M. IJ1939Link is already exactly that: a raw
//  29-bit frame mover implemented by both Rp1210Provider (the heavy installed base) and
//  J1939J2534Link (a J2534 device's raw CAN channel). Inventing an IMilcanLink would
//  have duplicated two transports to gain nothing - the frame surface is identical, and
//  J1939Message is just "29-bit id + bytes + honest timestamp". The J1939 NAME in the
//  type name is historical; nothing J1939-specific is used here.
//
//  DEFAULT READ-ONLY. THIS IS A SAFETY PROPERTY, NOT A PREFERENCE.
//  --------------------------------------------------------------
//  A MilCAN bus carries fire control, motion control, weapon-sensor and NBC traffic.
//  This session TRANSMITS NOTHING unless a caller explicitly enables transmit and then
//  explicitly calls a send method - see AllowTransmit. Passive analysis is the whole
//  Tier-1 product and it never needs the bus to hear us. In particular, entering
//  configuration mode stops every scheduled message on the platform, so that path is
//  gated twice (AllowTransmit AND its own confirmation argument) and refuses by default.
//
//  THREADING
//  ---------
//  All bus I/O on one dedicated background thread. Events are raised on that thread's
//  drain loop but AFTER the protocol state has been updated, and consumers marshal to
//  the UI themselves - the repo convention, BeginInvoke((Action)(() => ...)). Snapshot()
//  takes a lock and copies, so the UI timer never reads a half-updated table.
//
//  THE CLOCK
//  ---------
//  One Stopwatch for liveness checks, and per-message timestamps taken from
//  J1939Message.TimestampMs (adapter clock when the device provides one). Never
//  DateTime.Now: at a 1.95 ms PTU an NTP step or DST change would invent a sync loss.
// =============================================================================

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using TesterPresent.OBD2.J1939;
using TesterPresent.OBD2.Transport;

namespace TesterPresent.OBD2.Milcan
{
    /// <summary>One decoded MilCAN application message, single-frame or reassembled.</summary>
    /// <remarks>Raised from the pump thread; marshal to the UI before touching a control.</remarks>
    public sealed class MilcanMessageEventArgs : EventArgs
    {
        /// <summary>Creates the event payload.</summary>
        /// <param name="id">The decoded identifier.</param>
        /// <param name="payload">The complete payload.</param>
        /// <param name="wasMultiFrame">True when reassembled from a multi-frame message.</param>
        /// <param name="frameCount">Frames the message occupied; 1 for a single-frame message.</param>
        /// <param name="timestampMs">Session-clock arrival time.</param>
        /// <param name="notes">Tolerated anomalies, or empty when clean.</param>
        public MilcanMessageEventArgs(MilcanId id, byte[] payload, bool wasMultiFrame,
            int frameCount, double timestampMs, string notes)
        {
            Id = id;
            Payload = payload ?? new byte[0];
            WasMultiFrame = wasMultiFrame;
            FrameCount = frameCount;
            TimestampMs = timestampMs;
            Notes = notes ?? string.Empty;
        }

        /// <summary>The decoded identifier.</summary>
        public MilcanId Id { get; private set; }

        /// <summary>The complete payload. Treat as read-only; not copied per subscriber.</summary>
        public byte[] Payload { get; private set; }

        /// <summary>True when the payload was reassembled from a multi-frame message.</summary>
        public bool WasMultiFrame { get; private set; }

        /// <summary>Frames the message occupied.</summary>
        public int FrameCount { get; private set; }

        /// <summary>Session-clock arrival time in milliseconds.</summary>
        public double TimestampMs { get; private set; }

        /// <summary>Tolerated anomalies observed while receiving. Empty when clean.</summary>
        public string Notes { get; private set; }
    }

    /// <summary>An immutable view of bus state, safe to read on the UI thread.</summary>
    public sealed class MilcanBusSnapshot
    {
        /// <summary>The system mode inferred from Sync and configuration traffic.</summary>
        public MilcanSystemMode Mode { get; internal set; }

        /// <summary>True once a Sync Master has been observed.</summary>
        public bool HasMaster { get; internal set; }

        /// <summary>Source address of the current Sync Master.</summary>
        public byte MasterAddress { get; internal set; }

        /// <summary>Most recent sync slot (0..1023), or -1.</summary>
        public int CurrentSlot { get; internal set; }

        /// <summary>Measured Primary Time Unit in milliseconds.</summary>
        public double PtuMs { get; internal set; }

        /// <summary>Measured Sync frequency in hertz.</summary>
        public double SyncHz { get; internal set; }

        /// <summary>Peak deviation from the mean PTU in milliseconds.</summary>
        public double JitterMs { get; internal set; }

        /// <summary>False when PTU/jitter were measured against the host clock.</summary>
        public bool TimingTrustworthy { get; internal set; }

        /// <summary>Sync Frames observed.</summary>
        public long SyncCount { get; internal set; }

        /// <summary>Slot-counter discontinuities observed.</summary>
        public long SlotDiscontinuities { get; internal set; }

        /// <summary>Sync Master changes (elections) observed.</summary>
        public long MasterChanges { get; internal set; }

        /// <summary>Total frames seen, including non-MilCAN ones.</summary>
        public long TotalFrames { get; internal set; }

        /// <summary>Frames whose protocol-type bit was clear: SAE J1939 traffic sharing the bus.</summary>
        public long J1939Frames { get; internal set; }

        /// <summary>MilCAN frames seen.</summary>
        public long MilcanFrames { get; internal set; }

        /// <summary>Remote-transmission-request frames seen. MilCAN forbids RTR (§3.2.11), so any is an anomaly.</summary>
        public long RtrFrames { get; internal set; }

        /// <summary>The nodes observed.</summary>
        public List<MilcanNode> Nodes { get; internal set; }

        /// <summary>Distinct message types (primary/sub pairs) seen.</summary>
        public int MessageTypeCount { get; internal set; }

        /// <summary>Multi-frame assemblies currently in progress.</summary>
        public int MultiFrameInFlight { get; internal set; }
    }

    /// <summary>
    /// Drives a live MilCAN A analysis session over a 29-bit CAN link
    /// (MWG-MILA-001 Rev 3). Read-only unless transmit is explicitly enabled.
    /// </summary>
    public sealed class MilcanSession : IDisposable
    {
        private const int DRAIN_BATCH = 256;
        private const int IDLE_SLEEP_MS = 2;

        private readonly IJ1939Link _link;
        private readonly object _gate = new object();
        private readonly Stopwatch _clock = Stopwatch.StartNew();

        private readonly MilcanSyncTracker _sync = new MilcanSyncTracker();
        private readonly MilcanTransport _transport = new MilcanTransport();
        private readonly MilcanNodeTable _nodes = new MilcanNodeTable();
        private readonly MilcanConfigModeWatcher _config = new MilcanConfigModeWatcher();
        private readonly HashSet<ushort> _messageTypes = new HashSet<ushort>();

        private Thread _pump;
        private volatile bool _running;
        private bool _disposed;

        private long _totalFrames;
        private long _j1939Frames;
        private long _milcanFrames;
        private long _rtrFrames;

        /// <summary>Raised for each decoded MilCAN application message.</summary>
        public event EventHandler<MilcanMessageEventArgs> MessageReceived;

        /// <summary>Raised for protocol events worth a log line: mode changes, elections, anomalies.</summary>
        public event EventHandler<string> Log;

        /// <summary>
        /// Creates a session over an open 29-bit CAN link.
        /// </summary>
        /// <param name="link">The frame mover. Must be connected before <see cref="Start"/>.</param>
        /// <exception cref="ArgumentNullException"><paramref name="link"/> is null.</exception>
        public MilcanSession(IJ1939Link link)
        {
            if (link == null) throw new ArgumentNullException("link");
            _link = link;
        }

        /// <summary>
        /// Master transmit interlock. False by default and must be set deliberately.
        /// While false every send method refuses and says why. A MilCAN bus carries
        /// safety-critical traffic; nothing leaves this tool by accident.
        /// </summary>
        public bool AllowTransmit { get; set; }

        /// <summary>
        /// Source address this tool uses when it transmits. 0x00 is reserved by the spec
        /// and is rejected by <see cref="MilcanId.Create"/>; the default is a high
        /// address, which also loses Sync-Master arbitration to any real node (§4.1.5.6)
        /// and so cannot accidentally take the bus over.
        /// </summary>
        public byte SourceAddress { get; set; }

        /// <summary>True while the pump thread is running.</summary>
        public bool IsRunning { get { return _running; } }

        /// <summary>The link's description of the open channel.</summary>
        public string ProtocolString
        {
            get { return _link.ProtocolString ?? string.Empty; }
        }

        /// <summary>Session monotonic clock reading in milliseconds.</summary>
        public double ClockMs
        {
            get { return _clock.Elapsed.TotalMilliseconds; }
        }

        /// <summary>
        /// Starts the pump thread.
        /// </summary>
        /// <exception cref="InvalidOperationException">The session is disposed, already running, or the link is not connected.</exception>
        public void Start()
        {
            if (_disposed) throw new ObjectDisposedException("MilcanSession");
            if (_running) throw new InvalidOperationException("The MilCAN session is already running.");

            if (!_link.IsConnected)
            {
                throw new InvalidOperationException(
                    "The adapter is not open. Connect a 29-bit CAN channel before starting a MilCAN session.");
            }

            if (SourceAddress == MilcanId.RESERVED_SOURCE_ADDRESS)
            {
                SourceAddress = 0xFE;
            }

            _link.MarkUnloadUnsafe("A MilCAN session pump thread is running against this link.");

            _running = true;
            _pump = new Thread(PumpLoop)
            {
                IsBackground = true,
                Name = "MilCAN pump"
            };
            _pump.Start();

            RaiseLog(string.Format(CultureInfo.InvariantCulture,
                "MilCAN session started on \"{0}\". Passive: transmit is {1}.",
                ProtocolString, AllowTransmit ? "ENABLED" : "disabled (read-only)"));
        }

        /// <summary>Stops the pump thread and waits briefly for it to exit.</summary>
        public void Stop()
        {
            if (!_running) return;
            _running = false;

            Thread pump = _pump;
            if (pump != null)
            {
                try { pump.Join(1000); }
                catch { }
            }

            _pump = null;
        }

        private void PumpLoop()
        {
            while (_running)
            {
                bool sawFrames = false;

                try
                {
                    List<J1939Message> frames = _link.DrainJ1939(DRAIN_BATCH);
                    if (frames != null && frames.Count > 0)
                    {
                        sawFrames = true;
                        for (int i = 0; i < frames.Count; i++)
                        {
                            Ingest(frames[i]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // A transport fault must be reported, not swallowed: a pump that dies
                    // quietly looks exactly like a bus with no traffic.
                    RaiseLog("MilCAN transport fault while draining: " + ex.GetType().Name + ": " + ex.Message);
                    Thread.Sleep(50);
                }

                // Liveness is judged from the ABSENCE of frames, so these run every
                // iteration regardless of what arrived.
                CheckTimeouts();

                if (!sawFrames) Thread.Sleep(IDLE_SLEEP_MS);
            }
        }

        private void Ingest(J1939Message frame)
        {
            if (frame == null) return;

            MilcanId id;
            if (!MilcanId.TryFromRaw(frame.Id.Raw & MilcanId.IDENTIFIER_MASK, out id)) return;

            double t = frame.TimestampMs;
            bool adapterTimed = frame.TimestampSource == J1939TimestampSource.Adapter;
            byte[] payload = frame.Data;

            string note = null;
            MilcanMessageEventArgs message = null;

            lock (_gate)
            {
                _totalFrames++;

                // Bit 25 routes the frame. MilCAN A and J1939 may legitimately share a
                // 250 kbps bus (§3.2.1), so a J1939 frame here is not an error - it is
                // counted so the analyzer can say the bus is mixed.
                if (!id.IsMilcan)
                {
                    _j1939Frames++;
                    return;
                }

                _milcanFrames++;
                _messageTypes.Add(id.MessageType);

                string nodeNote = _nodes.Observe(id, payload, t);
                if (nodeNote != null) note = nodeNote;

                if (id.IsSyncFrame)
                {
                    MilcanSyncObservation obs = _sync.OnSyncFrame(id, payload, t, adapterTimed);
                    string syncNote = DescribeSync(obs, id);
                    if (syncNote != null) note = note == null ? syncNote : note + " " + syncNote;
                }
                else if (id.IsEnterConfig)
                {
                    string cfgNote;
                    if (_config.OnEnterConfigFrame(payload, t, out cfgNote))
                    {
                        _sync.OnEnteredConfigurationMode();
                    }
                    if (cfgNote != null) note = note == null ? cfgNote : note + " " + cfgNote;
                }
                else if (id.IsExitConfig)
                {
                    string cfgNote;
                    if (_config.OnExitConfigFrame(payload, out cfgNote))
                    {
                        _sync.OnExitedConfigurationMode();
                    }
                    if (cfgNote != null) note = note == null ? cfgNote : note + " " + cfgNote;
                }

                // Multi-frame reassembly. A frame consumed by the transport is not
                // dispatched as a single-frame message.
                MilcanMultiFrameResult mf;
                if (_transport.Offer(id, payload, t, out mf))
                {
                    if (mf != null)
                    {
                        string mfNote = mf.IsComplete
                            ? string.Empty
                            : "multi-frame incomplete: " + mf.Fault;

                        if (!mf.IsComplete && note == null)
                        {
                            note = string.Format(CultureInfo.InvariantCulture,
                                "Multi-frame message on {0} did not complete: {1}.",
                                MilcanRegistry.Describe(mf.Id), mf.Fault);
                        }

                        message = new MilcanMessageEventArgs(mf.Id, mf.Data, true, mf.FrameCount, t, mfNote);
                    }
                }
                else
                {
                    message = new MilcanMessageEventArgs(id, payload, false, 1, t, string.Empty);
                }
            }

            if (note != null) RaiseLog(note);
            if (message != null) RaiseMessage(message);
        }

        private string DescribeSync(MilcanSyncObservation obs, MilcanId id)
        {
            if (obs == null || !obs.IsNoteworthy) return null;

            var parts = new List<string>(4);

            if (obs.MasterEstablished)
            {
                parts.Add(string.Format(CultureInfo.InvariantCulture,
                    "Sync Master is 0x{0:X2} (slot {1}).", id.SourceAddress, obs.Slot));
            }

            if (obs.MasterChanged)
            {
                parts.Add(string.Format(CultureInfo.InvariantCulture,
                    "SYNC MASTER CHANGED 0x{0:X2} -> 0x{1:X2} - an election occurred; MilCAN resolves toward the LOWEST source address.",
                    obs.PreviousMaster, id.SourceAddress));
            }

            if (obs.SlotDiscontinuity)
            {
                parts.Add(string.Format(CultureInfo.InvariantCulture,
                    "Sync slot jumped to {0}, expected {1} - Sync Frames were missed; the bus schedule has been disturbed.",
                    obs.Slot, obs.ExpectedSlot));
            }

            if (obs.ModeChangedTo.HasValue && obs.ModeChangedTo.Value == MilcanSystemMode.Operational)
            {
                parts.Add("Bus is OPERATIONAL (valid Sync Frame received).");
            }

            if (obs.Anomaly != null) parts.Add(obs.Anomaly);

            return parts.Count == 0 ? null : string.Join(" ", parts.ToArray());
        }

        private void CheckTimeouts()
        {
            double now = ClockMs;
            bool syncLost;
            bool configLapsed;
            double ptu;
            int threshold = MilcanRegistry.SYNC_LOSS_PTU_THRESHOLD;

            lock (_gate)
            {
                configLapsed = _config.CheckConfigModeLapse(now);
                if (configLapsed) _sync.OnExitedConfigurationMode();

                syncLost = _sync.CheckSyncLoss(now);
                ptu = _sync.MeasuredPtuMs;
            }

            if (configLapsed)
            {
                RaiseLog("Configuration mode lapsed (the enter sequence stopped being repeated for over 8 s); devices return to pre-operational.");
            }

            if (syncLost)
            {
                RaiseLog(string.Format(CultureInfo.InvariantCulture,
                    "SYNC LOST - no Sync Frame for more than {0} PTU ({1:F1} ms). Every device on this bus has dropped to PRE-OPERATIONAL and normal message transmission has stopped.",
                    threshold, ptu * threshold));
            }
        }

        /// <summary>
        /// Declares that a message type carries multi-frame messages (§3.2.12.1).
        /// </summary>
        /// <remarks>
        /// Multi-frame membership is part of the platform's message set and cannot be
        /// inferred from the wire - the message-count byte lives in the payload, so an
        /// ordinary status message can look exactly like a first frame. Nothing is
        /// reassembled until a type is declared here; until then every frame is
        /// reported as single-frame, which is the honest default for a platform whose
        /// message set the tool has not been given.
        /// </remarks>
        /// <param name="primaryType">Primary-type of the multi-frame message.</param>
        /// <param name="subType">Sub-type of the multi-frame message.</param>
        public void RegisterMultiFrameMessageType(byte primaryType, byte subType)
        {
            lock (_gate)
            {
                _transport.RegisterMultiFrameType(primaryType, subType);
            }

            RaiseLog(string.Format(CultureInfo.InvariantCulture,
                "Message type 0x{0:X2}/0x{1:X2} declared as multi-frame; its frames will now be reassembled.",
                primaryType, subType));
        }

        /// <summary>
        /// Takes a consistent copy of bus state for the UI.
        /// </summary>
        /// <returns>A snapshot; never null.</returns>
        public MilcanBusSnapshot Snapshot()
        {
            lock (_gate)
            {
                return new MilcanBusSnapshot
                {
                    Mode = _config.InConfigurationMode ? MilcanSystemMode.SystemConfiguration : _sync.Mode,
                    HasMaster = _sync.HasMaster,
                    MasterAddress = _sync.MasterAddress,
                    CurrentSlot = _sync.CurrentSlot,
                    PtuMs = _sync.MeasuredPtuMs,
                    SyncHz = _sync.MeasuredSyncHz,
                    JitterMs = _sync.PtuJitterMs,
                    TimingTrustworthy = _sync.IsTimingTrustworthy,
                    SyncCount = _sync.SyncCount,
                    SlotDiscontinuities = _sync.SlotDiscontinuities,
                    MasterChanges = _sync.MasterChanges,
                    TotalFrames = _totalFrames,
                    J1939Frames = _j1939Frames,
                    MilcanFrames = _milcanFrames,
                    RtrFrames = _rtrFrames,
                    Nodes = _nodes.Snapshot(),
                    MessageTypeCount = _messageTypes.Count,
                    MultiFrameInFlight = _transport.InFlightCount
                };
            }
        }

        // ── Transmit paths. All gated. ───────────────────────────────────────────

        /// <summary>
        /// Sends a MilCAN Request message (request bit set, no payload) for a given
        /// message type (§3.2.5.1.2). The responder replies with the same primary/sub
        /// type, its own source address and the request bit clear.
        /// </summary>
        /// <param name="primaryType">Primary-type to request.</param>
        /// <param name="subType">Sub-type to request.</param>
        /// <param name="priority">Priority for the request. Must be 2 or numerically greater (§3.2.6.3) - a tool is asynchronous to the bus.</param>
        /// <param name="failureReason">Why the request was refused, or empty on success.</param>
        /// <returns>True when the frame was handed to the adapter.</returns>
        public bool SendRequest(byte primaryType, byte subType, byte priority, out string failureReason)
        {
            if (!AllowTransmit)
            {
                failureReason = "transmit is disabled for this session (MilCAN analysis is read-only by default).";
                return false;
            }

            if (!_running)
            {
                failureReason = "the MilCAN session is not running.";
                return false;
            }

            // A tool is an asynchronous device. §3.2.6.3 restricts asynchronous traffic
            // to priority 2 or lower-priority, so that a tool cannot displace the hard
            // real-time schedule the platform depends on.
            if (priority < MilcanRegistry.ASYNC_MINIMUM_PRIORITY_VALUE)
            {
                failureReason = string.Format(CultureInfo.InvariantCulture,
                    "priority {0} is reserved for synchronous/protocol traffic. MilCAN A §3.2.6.3 restricts asynchronous devices such as this tool to priority {1} or lower priority.",
                    priority, MilcanRegistry.ASYNC_MINIMUM_PRIORITY_VALUE);
                return false;
            }

            if (primaryType == MilcanId.PRIMARY_PROTOCOL)
            {
                failureReason = "primary-type 0x00 is the protocol group (Sync / configuration mode). It cannot be requested.";
                return false;
            }

            try
            {
                MilcanId id = MilcanId.Create(priority, primaryType, subType, SourceAddress, true);
                var frame = new J1939Message(J1939Id.FromRaw(id.Raw), new byte[0]);

                if (!_link.SendJ1939(frame))
                {
                    failureReason = "the adapter refused the frame.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                failureReason = ex.Message;
                return false;
            }

            RaiseLog(string.Format(CultureInfo.InvariantCulture,
                "MilCAN request sent for 0x{0:X2}/0x{1:X2} at priority {2} from SA 0x{3:X2}.",
                primaryType, subType, priority, SourceAddress));

            failureReason = string.Empty;
            return true;
        }

        /// <summary>
        /// Drives the bus into system configuration mode by transmitting the ordered
        /// 'C' / 'F' / 'G' sequence (§4.2.3).
        /// </summary>
        /// <remarks>
        /// THIS SUSPENDS ALL OPERATIONAL MESSAGING ON THE BUS, INCLUDING SYNC FRAMES.
        /// On a live platform that stops every scheduled message at once. It is gated
        /// twice deliberately: <see cref="AllowTransmit"/> must be set AND
        /// <paramref name="confirmedSafeToHaltBus"/> must be true, so it cannot be
        /// reached by a mis-click or a default.
        /// </remarks>
        /// <param name="confirmedSafeToHaltBus">Must be true. The caller asserts the platform is safe to halt.</param>
        /// <param name="failureReason">Why the request was refused, or empty on success.</param>
        /// <returns>True when all three frames were handed to the adapter.</returns>
        public bool SendEnterConfigurationMode(bool confirmedSafeToHaltBus, out string failureReason)
        {
            if (!AllowTransmit)
            {
                failureReason = "transmit is disabled for this session (MilCAN analysis is read-only by default).";
                return false;
            }

            if (!confirmedSafeToHaltBus)
            {
                failureReason = "entering configuration mode suspends ALL operational messaging on the bus, including Sync Frames. "
                              + "It was refused because the caller did not confirm the platform is safe to halt.";
                return false;
            }

            if (!_running)
            {
                failureReason = "the MilCAN session is not running.";
                return false;
            }

            try
            {
                MilcanId id = MilcanId.EnterConfig(SourceAddress);

                // The whole sequence must be on the wire inside 400 ms (§4.2.3); three
                // back-to-back frames are far inside that.
                for (int i = 0; i < MilcanRegistry.ENTER_CONFIG_SEQUENCE.Length; i++)
                {
                    var frame = new J1939Message(J1939Id.FromRaw(id.Raw),
                        new byte[] { MilcanRegistry.ENTER_CONFIG_SEQUENCE[i] });

                    if (!_link.SendJ1939(frame))
                    {
                        failureReason = string.Format(CultureInfo.InvariantCulture,
                            "the adapter refused frame {0} of the enter-configuration sequence. The bus may be in an indeterminate state; "
                            + "send the exit-configuration message before continuing.", i + 1);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                failureReason = ex.Message;
                return false;
            }

            RaiseLog("ENTER CONFIGURATION MODE sequence transmitted ('C','F','G'). All operational messaging on this bus, including Sync Frames, is now suspended. "
                   + "The sequence must be repeated once per second to hold the bus in configuration mode.");

            failureReason = string.Empty;
            return true;
        }

        /// <summary>
        /// Returns the bus to pre-operational by transmitting the "OPR" exit message
        /// (§4.2.3). Gated by <see cref="AllowTransmit"/> only - leaving configuration
        /// mode restores normal operation and is the safe direction.
        /// </summary>
        /// <param name="failureReason">Why the request was refused, or empty on success.</param>
        /// <returns>True when the frame was handed to the adapter.</returns>
        public bool SendExitConfigurationMode(out string failureReason)
        {
            if (!AllowTransmit)
            {
                failureReason = "transmit is disabled for this session (MilCAN analysis is read-only by default).";
                return false;
            }

            if (!_running)
            {
                failureReason = "the MilCAN session is not running.";
                return false;
            }

            try
            {
                MilcanId id = MilcanId.ExitConfig(SourceAddress);
                byte[] payload = (byte[])MilcanRegistry.EXIT_CONFIG_PAYLOAD.Clone();
                var frame = new J1939Message(J1939Id.FromRaw(id.Raw), payload);

                if (!_link.SendJ1939(frame))
                {
                    failureReason = "the adapter refused the frame.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                failureReason = ex.Message;
                return false;
            }

            RaiseLog("EXIT CONFIGURATION MODE ('OPR') transmitted; devices return to pre-operational and will re-enter operational on the next Sync Frame.");

            failureReason = string.Empty;
            return true;
        }

        private void RaiseLog(string text)
        {
            EventHandler<string> handler = Log;
            if (handler == null) return;
            try { handler(this, text); }
            catch { }
        }

        private void RaiseMessage(MilcanMessageEventArgs args)
        {
            EventHandler<MilcanMessageEventArgs> handler = MessageReceived;
            if (handler == null) return;
            try { handler(this, args); }
            catch { }
        }

        /// <summary>Stops the pump and releases session state. The link is NOT disposed; its owner keeps it.</summary>
        public void Dispose()
        {
            if (_disposed) return;
            _disposed = true;

            Stop();

            lock (_gate)
            {
                _sync.Reset();
                _transport.Reset();
                _nodes.Reset();
                _config.Reset();
                _messageTypes.Clear();
            }
        }
    }
}
