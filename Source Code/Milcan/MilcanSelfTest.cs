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
//  MilcanSelfTest.cs - known-answer self-test for the MilCAN A stack.
//
//  This repo has no unit-test framework and deliberately does not want one; known
//  answer self-tests live in code, the way tps_self_test does inside TPSecurity.dll
//  and J1708SelfTest does for the heavy K-line stack. Call MilcanSelfTest.Run() and
//  read the report.
//
//  WHAT IT PROVES, AND WHAT IT CANNOT.
//  It proves the arithmetic against values quoted directly from MWG-MILA-001 Rev 3:
//  the identifier field layout and its round trip, the well-known identifiers
//  (0x020080xx / 0x020081xx / 0x020082xx), the J1939-vs-MilCAN protocol-type routing,
//  the priority/latency table, the Sync slot counter including its 1023 -> 0 wrap and
//  the discontinuity detector, the measured-PTU arithmetic and the 8-PTU sync-loss
//  deadline, the 'C'/'F'/'G' sequence rules including out-of-order restart and the
//  500 ms window, and the multi-frame message-count state machine with its padding
//  trim and its short-message refusal.
//
//  It CANNOT prove the two things that decide whether a real MilCAN decode is right:
//  the primary-type ALLOCATION on any given platform (Table A-1 is explicitly a
//  SUGGESTION and a real vehicle may allocate differently), and the timing behaviour of
//  a real bus under load - jitter, election churn and adapter timestamp fidelity. Both
//  need a real MilCAN bus. Passing this harness is a smoke test, not a passing grade -
//  the same rule this project already applies to the J2534 emulator.
// =============================================================================

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TesterPresent.OBD2.Milcan
{
    /// <summary>One self-test case and its outcome.</summary>
    public sealed class MilcanSelfTestCase
    {
        /// <summary>What the case checks.</summary>
        public string Name { get; set; }

        /// <summary>True when the observed value matched the known answer.</summary>
        public bool Passed { get; set; }

        /// <summary>Observed value, or the reason it did not match.</summary>
        public string Detail { get; set; }
    }

    /// <summary>Aggregate result of a self-test run.</summary>
    public sealed class MilcanSelfTestReport
    {
        private readonly List<MilcanSelfTestCase> _cases = new List<MilcanSelfTestCase>();

        /// <summary>Every case, in the order it ran.</summary>
        public List<MilcanSelfTestCase> Cases { get { return _cases; } }

        /// <summary>How many cases passed.</summary>
        public int Passed
        {
            get
            {
                int n = 0;
                for (int i = 0; i < _cases.Count; i++) if (_cases[i].Passed) n++;
                return n;
            }
        }

        /// <summary>How many cases ran.</summary>
        public int Total { get { return _cases.Count; } }

        /// <summary>True when every case passed.</summary>
        public bool AllPassed { get { return Passed == Total; } }

        /// <summary>Renders the report as text for a log pane.</summary>
        /// <returns>The formatted report.</returns>
        public string Render()
        {
            StringBuilder sb = new StringBuilder(4096);
            sb.AppendFormat(CultureInfo.InvariantCulture,
                "MilCAN A stack self-test: {0}/{1} passed", Passed, Total);
            sb.AppendLine();
            sb.AppendLine(new string('-', 78));

            for (int i = 0; i < _cases.Count; i++)
            {
                MilcanSelfTestCase c = _cases[i];
                sb.AppendFormat(CultureInfo.InvariantCulture, "[{0}] {1}", c.Passed ? "PASS" : "FAIL", c.Name);
                if (!string.IsNullOrEmpty(c.Detail))
                {
                    sb.Append("  - ");
                    sb.Append(c.Detail);
                }
                sb.AppendLine();
            }

            sb.AppendLine(new string('-', 78));
            sb.AppendLine("NOT covered by this harness:");
            sb.AppendLine("  * the primary-type ALLOCATION on any real platform - MilCAN A Table A-1 is a");
            sb.AppendLine("    SUGGESTED allocation and a given vehicle may assign differently");
            sb.AppendLine("  * real bus timing: jitter under load, Sync Master election churn, and whether");
            sb.AppendLine("    the adapter's timestamps are fine-grained enough at a 1.95 ms PTU (1 Mbps)");
            sb.AppendLine("  * payload semantics (MilCAN A Appendix B parameter scaling) - not implemented");
            sb.AppendLine("  * MilCAN B (11-bit / CANopen) - not implemented");
            return sb.ToString();
        }
    }

    /// <summary>Known-answer self-test for the MilCAN A stack.</summary>
    public static class MilcanSelfTest
    {
        /// <summary>Runs every case.</summary>
        /// <returns>The report; never null.</returns>
        public static MilcanSelfTestReport Run()
        {
            var report = new MilcanSelfTestReport();

            IdentifierLayout(report);
            WellKnownIdentifiers(report);
            ProtocolRouting(report);
            PriorityTable(report);
            SyncTracking(report);
            ConfigSequence(report);
            MultiFrame(report);

            return report;
        }

        // ------------------------------------------------------------------
        //  Identifier layout (MILA §3.2.1, §4.1.4)
        // ------------------------------------------------------------------

        private static void IdentifierLayout(MilcanSelfTestReport r)
        {
            // Priority 3, MilCAN, status/command, primary 0x58, sub 0x01, SA 0x22.
            //   pri 3   -> 011 at bits 28..26
            //   PT  1   -> bit 25
            //   req 0   -> bit 24
            //   0x58    -> bits 23..16
            //   0x01    -> bits 15..8
            //   0x22    -> bits 7..0
            //   = 0000 1110 0101 1000 0000 0001 0010 0010 = 0x0E580122
            MilcanId id = MilcanId.Create(3, 0x58, 0x01, 0x22);
            Add(r, "identifier: pri3 pt0x58 st0x01 SA0x22 -> 0x0E580122",
                id.Raw == 0x0E580122u, "0x" + id.Raw.ToString("X8", CultureInfo.InvariantCulture));

            MilcanId back = MilcanId.FromRaw(0x0E580122u);
            bool fields = back.Priority == 3 && back.IsMilcan && !back.IsRequest
                          && back.PrimaryType == 0x58 && back.SubType == 0x01
                          && back.SourceAddress == 0x22;
            Add(r, "identifier: decode round trip recovers every field", fields, back.ToString());

            // The request bit is bit 24 - where J1939 puts the data page.
            MilcanId req = MilcanId.Create(3, 0x58, 0x01, 0x22, true);
            Add(r, "identifier: request bit sets bit 24",
                req.Raw == (0x0E580122u | (1u << 24)) && req.IsRequest,
                "0x" + req.Raw.ToString("X8", CultureInfo.InvariantCulture));

            // MessageType is the logical-addressing key: primary in the high byte.
            Add(r, "identifier: message type key = primary<<8 | sub",
                back.MessageType == 0x5801,
                "0x" + back.MessageType.ToString("X4", CultureInfo.InvariantCulture));

            // Source address 0x00 is reserved (§3.2.1.1) and must be refused on encode.
            bool refused = false;
            try { MilcanId.Create(3, 0x58, 0x01, 0x00); }
            catch (ArgumentException) { refused = true; }
            Add(r, "identifier: reserved source address 0x00 refused on encode", refused,
                refused ? "ArgumentException" : "accepted - WRONG");

            // Out-of-range priority must throw rather than silently truncate.
            bool prioRefused = false;
            try { MilcanId.Create(8, 0x58, 0x01, 0x22); }
            catch (ArgumentOutOfRangeException) { prioRefused = true; }
            Add(r, "identifier: priority 8 refused (3-bit field)", prioRefused,
                prioRefused ? "ArgumentOutOfRangeException" : "accepted - WRONG");

            // A value with bits above 29 must not decode.
            MilcanId dummy;
            Add(r, "identifier: 30-bit value rejected by TryFromRaw",
                !MilcanId.TryFromRaw(0x20000000u, out dummy), "rejected");
        }

        // ------------------------------------------------------------------
        //  Well-known identifiers (MILA Appendix A.4 / A.5 / A.6, §3.2.5.5)
        // ------------------------------------------------------------------

        private static void WellKnownIdentifiers(MilcanSelfTestReport r)
        {
            // Spec quotes the Sync Frame identifier as 0x020080xx.
            MilcanId sync = MilcanId.SyncFrame(0x10);
            Add(r, "sync frame: identifier is 0x02008010 for SA 0x10 (spec: 0x020080xx)",
                sync.Raw == 0x02008010u && sync.IsSyncFrame,
                "0x" + sync.Raw.ToString("X8", CultureInfo.InvariantCulture));

            Add(r, "sync frame: priority 0, primary 0x00, sub 0x80",
                sync.Priority == 0 && sync.PrimaryType == 0x00 && sync.SubType == 0x80,
                MilcanRegistry.Describe(sync));

            // Enter config: 0x020081xx.
            MilcanId enter = MilcanId.EnterConfig(0x10);
            Add(r, "enter config: identifier is 0x02008110 (spec: 0x020081xx)",
                enter.Raw == 0x02008110u && enter.IsEnterConfig,
                "0x" + enter.Raw.ToString("X8", CultureInfo.InvariantCulture));

            // Exit config: 0x020082xx.
            MilcanId exit = MilcanId.ExitConfig(0x10);
            Add(r, "exit config: identifier is 0x02008210 (spec: 0x020082xx)",
                exit.Raw == 0x02008210u && exit.IsExitConfig,
                "0x" + exit.Raw.ToString("X8", CultureInfo.InvariantCulture));

            // Alive is primary-type 0x62 with the node id in the sub-type.
            MilcanId alive = MilcanId.Create(6, MilcanId.PRIMARY_ALIVE, 0x07, 0x07);
            Add(r, "alive: primary-type 0x62 recognised, node id in sub-type",
                alive.IsAlive && alive.SubType == 0x07, MilcanRegistry.Describe(alive));

            // Config payload constants: 'C','F','G' and "OPR".
            bool seq = MilcanRegistry.ENTER_CONFIG_SEQUENCE.Length == 3
                       && MilcanRegistry.ENTER_CONFIG_SEQUENCE[0] == 0x43
                       && MilcanRegistry.ENTER_CONFIG_SEQUENCE[1] == 0x46
                       && MilcanRegistry.ENTER_CONFIG_SEQUENCE[2] == 0x47;
            Add(r, "config: enter sequence is ASCII 'C' 'F' 'G' (43 46 47)", seq, "43 46 47");

            bool opr = MilcanRegistry.EXIT_CONFIG_PAYLOAD.Length == 3
                       && MilcanRegistry.EXIT_CONFIG_PAYLOAD[0] == 0x4F
                       && MilcanRegistry.EXIT_CONFIG_PAYLOAD[1] == 0x50
                       && MilcanRegistry.EXIT_CONFIG_PAYLOAD[2] == 0x52;
            Add(r, "config: exit payload is ASCII \"OPR\" (4F 50 52)", opr, "4F 50 52");

            // Recommended sync rates and their derived PTUs (§3.2.5.3).
            Add(r, "timing: 250k recommends 64 Hz -> 15.625 ms PTU",
                Math.Abs(MilcanRegistry.RecommendedPtuMs(MilcanBitRate.Rate250k) - 15.625) < 0.001,
                MilcanRegistry.RecommendedPtuMs(MilcanBitRate.Rate250k).ToString("F3", CultureInfo.InvariantCulture));

            Add(r, "timing: 500k recommends 128 Hz -> 7.8125 ms PTU",
                Math.Abs(MilcanRegistry.RecommendedPtuMs(MilcanBitRate.Rate500k) - 7.8125) < 0.001,
                MilcanRegistry.RecommendedPtuMs(MilcanBitRate.Rate500k).ToString("F4", CultureInfo.InvariantCulture));

            Add(r, "timing: 1M recommends 512 Hz -> 1.953 ms PTU",
                Math.Abs(MilcanRegistry.RecommendedPtuMs(MilcanBitRate.Rate1M) - 1.953125) < 0.001,
                MilcanRegistry.RecommendedPtuMs(MilcanBitRate.Rate1M).ToString("F4", CultureInfo.InvariantCulture));
        }

        // ------------------------------------------------------------------
        //  Protocol routing: bit 25 discriminates MilCAN from J1939 (§3.2.1.4)
        // ------------------------------------------------------------------

        private static void ProtocolRouting(MilcanSelfTestReport r)
        {
            // A real J1939 identifier: PGN 65226 (0xFECA) DM1, priority 6, SA 0x00.
            // 6<<26 | 0xFE<<16 | 0xCA<<8 | 0x00 = 0x18FECA00. Bit 25 clear -> J1939.
            MilcanId j1939 = MilcanId.FromRaw(0x18FECA00u);
            Add(r, "routing: 0x18FECA00 (J1939 DM1) has protocol-type clear -> J1939",
                j1939.IsJ1939 && !j1939.IsMilcan, j1939.ToString());

            Add(r, "routing: a J1939 frame is described as such, not decoded as MilCAN",
                MilcanRegistry.Describe(j1939).IndexOf("J1939", StringComparison.OrdinalIgnoreCase) >= 0,
                MilcanRegistry.Describe(j1939));

            // The same identifier with bit 25 set is a MilCAN frame - this is exactly
            // the coexistence rule that lets both share a 250 kbps bus.
            MilcanId milcan = MilcanId.FromRaw(0x18FECA00u | (1u << 25));
            Add(r, "routing: same identifier with bit 25 set decodes as MilCAN",
                milcan.IsMilcan && milcan.PrimaryType == 0xFE && milcan.SubType == 0xCA,
                milcan.ToString());

            // The Sync Frame must NOT be mistaken for a J1939 frame.
            Add(r, "routing: sync frame is not classified as J1939",
                MilcanId.SyncFrame(0x01).IsMilcan, "MilCAN");
        }

        // ------------------------------------------------------------------
        //  Priority / latency contract (MILA Table 4-1)
        // ------------------------------------------------------------------

        private static void PriorityTable(MilcanSelfTestReport r)
        {
            CheckClass(r, 0, MilcanRealTimeClass.Hrt0, 1);
            CheckClass(r, 1, MilcanRealTimeClass.Hrt1, 1);
            CheckClass(r, 2, MilcanRealTimeClass.Hrt2, 8);
            CheckClass(r, 3, MilcanRealTimeClass.Hrt3, 64);
            CheckClass(r, 4, MilcanRealTimeClass.Srt1, 8);
            CheckClass(r, 5, MilcanRealTimeClass.Srt2, 64);
            CheckClass(r, 6, MilcanRealTimeClass.Srt3, 1024);

            // Priority 7 is NRT: no deadline at all, which is represented as 0 rather
            // than a large number so a caller cannot accidentally treat it as a bound.
            Add(r, "priority: 7 is NRT with no latency requirement",
                MilcanRegistry.ClassOf(7) == MilcanRealTimeClass.Nrt
                && MilcanRegistry.LatencyBoundPtu(7) == 0,
                MilcanRegistry.DescribePriority(7));

            // §3.2.6.3: asynchronous traffic is restricted to priority 2 or lower.
            Add(r, "priority: async minimum is 2 (§3.2.6.3)",
                MilcanRegistry.ASYNC_MINIMUM_PRIORITY_VALUE == 2, "2");
        }

        private static void CheckClass(MilcanSelfTestReport r, byte priority,
            MilcanRealTimeClass expectedClass, int expectedPtu)
        {
            MilcanRealTimeClass actual = MilcanRegistry.ClassOf(priority);
            int bound = MilcanRegistry.LatencyBoundPtu(priority);

            Add(r, string.Format(CultureInfo.InvariantCulture,
                    "priority: {0} -> {1}, deadline {2} PTU", priority, expectedClass, expectedPtu),
                actual == expectedClass && bound == expectedPtu,
                MilcanRegistry.DescribePriority(priority));
        }

        // ------------------------------------------------------------------
        //  Sync tracking: slot counter, PTU measurement, sync loss (§3.2.5.3, §4.2.2)
        // ------------------------------------------------------------------

        private static void SyncTracking(MilcanSelfTestReport r)
        {
            var tracker = new MilcanSyncTracker();
            MilcanId sync = MilcanId.SyncFrame(0x10);

            // Feed 10 Sync Frames at exactly 15.625 ms (the 250 kbps recommendation),
            // slots 0..9.
            double t = 1000.0;
            for (int slot = 0; slot < 10; slot++)
            {
                tracker.OnSyncFrame(sync, Slot(slot), t, true);
                t += 15.625;
            }

            // The loop leaves t one interval PAST the final frame. The sync-loss
            // deadline is measured from the LAST FRAME ACTUALLY SENT, so anchor to that
            // - measuring from t would silently test a window 15.625 ms wider than
            // intended, which is how the first draft of this harness managed to call a
            // correct implementation broken.
            double lastSyncMs = t - 15.625;

            Add(r, "sync: 10 frames counted", tracker.SyncCount == 10,
                tracker.SyncCount.ToString(CultureInfo.InvariantCulture));

            Add(r, "sync: measured PTU is 15.625 ms",
                Math.Abs(tracker.MeasuredPtuMs - 15.625) < 0.001,
                tracker.MeasuredPtuMs.ToString("F4", CultureInfo.InvariantCulture));

            Add(r, "sync: measured frequency is 64 Hz",
                Math.Abs(tracker.MeasuredSyncHz - 64.0) < 0.01,
                tracker.MeasuredSyncHz.ToString("F2", CultureInfo.InvariantCulture));

            Add(r, "sync: master established as 0x10",
                tracker.HasMaster && tracker.MasterAddress == 0x10,
                "0x" + tracker.MasterAddress.ToString("X2", CultureInfo.InvariantCulture));

            Add(r, "sync: no discontinuities on a clean run",
                tracker.SlotDiscontinuities == 0,
                tracker.SlotDiscontinuities.ToString(CultureInfo.InvariantCulture));

            Add(r, "sync: bus is OPERATIONAL after a valid sync frame",
                tracker.Mode == MilcanSystemMode.Operational, tracker.Mode.ToString());

            // Sync-loss deadline is 8 PTU (§4.2.2) = 125 ms at this rate.
            Add(r, "sync: loss deadline is 8 PTU (125 ms at 15.625 ms PTU)",
                Math.Abs(tracker.SyncLossDeadlineMs - 125.0) < 0.01,
                tracker.SyncLossDeadlineMs.ToString("F2", CultureInfo.InvariantCulture));

            // Just inside the deadline (120 ms after the last frame, deadline 125 ms)
            // must NOT trip.
            Add(r, "sync: no loss reported just inside the 8-PTU deadline",
                !tracker.CheckSyncLoss(lastSyncMs + 120.0), "held");

            // Past it must trip exactly once and drop to pre-operational.
            bool lost = tracker.CheckSyncLoss(lastSyncMs + 200.0);
            Add(r, "sync: loss trips past the deadline and drops to PRE-OPERATIONAL",
                lost && tracker.Mode == MilcanSystemMode.PreOperational, tracker.Mode.ToString());

            Add(r, "sync: loss does not re-trip once already pre-operational",
                !tracker.CheckSyncLoss(lastSyncMs + 400.0), "single-shot");

            // Slot discontinuity: jump 5 -> 9.
            var jump = new MilcanSyncTracker();
            jump.OnSyncFrame(sync, Slot(5), 0.0, true);
            MilcanSyncObservation obs = jump.OnSyncFrame(sync, Slot(9), 15.625, true);
            Add(r, "sync: slot jump 5 -> 9 flagged as a discontinuity (expected 6)",
                obs.SlotDiscontinuity && obs.ExpectedSlot == 6 && jump.SlotDiscontinuities == 1,
                "expected " + obs.ExpectedSlot.ToString(CultureInfo.InvariantCulture));

            // The 1023 -> 0 wrap is NOT a discontinuity: it is the major cycle.
            var wrap = new MilcanSyncTracker();
            wrap.OnSyncFrame(sync, Slot(1023), 0.0, true);
            MilcanSyncObservation wrapObs = wrap.OnSyncFrame(sync, Slot(0), 15.625, true);
            Add(r, "sync: 1023 -> 0 wrap is a major cycle, not a discontinuity",
                !wrapObs.SlotDiscontinuity && wrapObs.MajorCycleWrapped && wrap.SlotDiscontinuities == 0,
                "clean wrap");

            // Master change = election. Lower source address should win on a real bus,
            // but the tracker reports whatever it sees rather than asserting the rule.
            var elect = new MilcanSyncTracker();
            elect.OnSyncFrame(MilcanId.SyncFrame(0x20), Slot(0), 0.0, true);
            MilcanSyncObservation electObs = elect.OnSyncFrame(MilcanId.SyncFrame(0x05), Slot(1), 15.625, true);
            Add(r, "sync: master change 0x20 -> 0x05 reported as an election",
                electObs.MasterChanged && electObs.PreviousMaster == 0x20
                && elect.MasterAddress == 0x05 && elect.MasterChanges == 1,
                "0x20 -> 0x05");

            // A short payload must not be read as slot 0 - that would fabricate a major
            // cycle restart.
            var shortPayload = new MilcanSyncTracker();
            MilcanSyncObservation shortObs = shortPayload.OnSyncFrame(sync, new byte[] { 0x00 }, 0.0, true);
            Add(r, "sync: 1-byte payload rejected as malformed, not read as slot 0",
                shortObs.Slot == -1 && shortObs.Anomaly != null, shortObs.Anomaly);

            // Host-clock timing must be flagged as untrustworthy.
            var soft = new MilcanSyncTracker();
            soft.OnSyncFrame(sync, Slot(0), 0.0, false);
            Add(r, "sync: host-clock timing marks the measurement untrustworthy",
                !soft.IsTimingTrustworthy, "flagged");
        }

        private static byte[] Slot(int slot)
        {
            // Little-endian, per MILA §4.1.1 (Intel byte order) and Table A-2.
            return new byte[] { (byte)(slot & 0xFF), (byte)((slot >> 8) & 0xFF) };
        }

        // ------------------------------------------------------------------
        //  Configuration mode sequence (MILA §4.2.3)
        // ------------------------------------------------------------------

        private static void ConfigSequence(MilcanSelfTestReport r)
        {
            string note;

            // Correct sequence within the window enters configuration mode.
            var w = new MilcanConfigModeWatcher();
            bool a = w.OnEnterConfigFrame(new byte[] { 0x43 }, 0.0, out note);      // 'C'
            bool b = w.OnEnterConfigFrame(new byte[] { 0x46 }, 50.0, out note);     // 'F'
            bool c = w.OnEnterConfigFrame(new byte[] { 0x47 }, 100.0, out note);    // 'G'
            Add(r, "config: 'C' 'F' 'G' within 400 ms enters configuration mode",
                !a && !b && c && w.InConfigurationMode, "entered on third message");

            // Out-of-order must NOT enter.
            var w2 = new MilcanConfigModeWatcher();
            w2.OnEnterConfigFrame(new byte[] { 0x43 }, 0.0, out note);              // 'C'
            w2.OnEnterConfigFrame(new byte[] { 0x47 }, 50.0, out note);             // 'G' - wrong
            bool entered = w2.OnEnterConfigFrame(new byte[] { 0x47 }, 100.0, out note);
            Add(r, "config: out-of-order sequence refused", !entered && !w2.InConfigurationMode,
                "not entered");

            // Over the 500 ms window must NOT enter.
            var w3 = new MilcanConfigModeWatcher();
            w3.OnEnterConfigFrame(new byte[] { 0x43 }, 0.0, out note);
            w3.OnEnterConfigFrame(new byte[] { 0x46 }, 100.0, out note);
            bool late = w3.OnEnterConfigFrame(new byte[] { 0x47 }, 900.0, out note);
            Add(r, "config: sequence exceeding the 500 ms window refused",
                !late && !w3.InConfigurationMode, "timed out");

            // An exit message mid-sequence invalidates it (§4.2.3).
            var w4 = new MilcanConfigModeWatcher();
            w4.OnEnterConfigFrame(new byte[] { 0x43 }, 0.0, out note);
            w4.OnEnterConfigFrame(new byte[] { 0x46 }, 50.0, out note);
            w4.OnExitConfigFrame(MilcanRegistry.EXIT_CONFIG_PAYLOAD, out note);
            bool afterExit = w4.OnEnterConfigFrame(new byte[] { 0x47 }, 100.0, out note);
            Add(r, "config: exit message mid-sequence invalidates the enter sequence",
                !afterExit && !w4.InConfigurationMode, "sequence abandoned");

            // Exit from configuration mode with "OPR".
            var w5 = new MilcanConfigModeWatcher();
            w5.OnEnterConfigFrame(new byte[] { 0x43 }, 0.0, out note);
            w5.OnEnterConfigFrame(new byte[] { 0x46 }, 10.0, out note);
            w5.OnEnterConfigFrame(new byte[] { 0x47 }, 20.0, out note);
            bool exited = w5.OnExitConfigFrame(MilcanRegistry.EXIT_CONFIG_PAYLOAD, out note);
            Add(r, "config: \"OPR\" exits configuration mode", exited && !w5.InConfigurationMode,
                "exited");

            // A wrong exit payload must not exit.
            var w6 = new MilcanConfigModeWatcher();
            w6.OnEnterConfigFrame(new byte[] { 0x43 }, 0.0, out note);
            w6.OnEnterConfigFrame(new byte[] { 0x46 }, 10.0, out note);
            w6.OnEnterConfigFrame(new byte[] { 0x47 }, 20.0, out note);
            bool wrongExit = w6.OnExitConfigFrame(new byte[] { 0x4F, 0x50, 0x53 }, out note); // "OPS"
            Add(r, "config: wrong exit payload (\"OPS\") refused",
                !wrongExit && w6.InConfigurationMode, "still in config mode");

            // Config mode lapses after 8 s without the sequence being repeated.
            var w7 = new MilcanConfigModeWatcher();
            w7.OnEnterConfigFrame(new byte[] { 0x43 }, 0.0, out note);
            w7.OnEnterConfigFrame(new byte[] { 0x46 }, 10.0, out note);
            w7.OnEnterConfigFrame(new byte[] { 0x47 }, 20.0, out note);
            Add(r, "config: no lapse before the 8 s idle timeout",
                !w7.CheckConfigModeLapse(5000.0) && w7.InConfigurationMode, "held");
            Add(r, "config: lapses after the 8 s idle timeout",
                w7.CheckConfigModeLapse(9000.0) && !w7.InConfigurationMode, "lapsed");
        }

        // ------------------------------------------------------------------
        //  Multi-frame transport (MILA §3.2.12)
        // ------------------------------------------------------------------

        private static void MultiFrame(MilcanSelfTestReport r)
        {
            var tp = new MilcanTransport();
            MilcanId id = MilcanId.Create(6, 0x63, 0x01, 0x22);
            MilcanMultiFrameResult result;

            // REGRESSION (found by the emulator end-to-end run): an ordinary single-frame
            // status message whose payload happens to start 0x00 and is 4+ bytes long
            // must NOT be swallowed as a multi-frame first frame. Multi-frame membership
            // is declared by the message set (§3.2.12.1), never inferred from the wire.
            MilcanId bodyElectronics = MilcanId.Create(5, 0x60, 0x01, 0x20);
            bool inferred = tp.Offer(bodyElectronics, new byte[] { 0x00, 0x01, 0x00, 0x00 }, 0.0, out result);
            Add(r, "multi-frame: unregistered type starting 0x00 is NOT swallowed as a first frame",
                !inferred && result == null, "passed through as single-frame");

            // Nothing is reassembled until the message set declares the type.
            tp.RegisterMultiFrameType(0x63, 0x01);
            Add(r, "multi-frame: registration is required before reassembly",
                tp.IsMultiFrameType(id) && !tp.IsMultiFrameType(bodyElectronics), "0x63/0x01 registered only");

            // A 10-byte message: first frame declares 10, two intermediate frames carry
            // 7 + 7 = 14 bytes (4 of which are padding), last frame closes it.
            bool consumed = tp.Offer(id, new byte[] { 0, 10, 0, 0, 0, 0, 0, 0 }, 0.0, out result);
            Add(r, "multi-frame: first frame (count 0) consumed, declares 10 bytes",
                consumed && result == null, "assembly started");

            tp.Offer(id, new byte[] { 1, 1, 2, 3, 4, 5, 6, 7 }, 10.0, out result);
            tp.Offer(id, new byte[] { 2, 8, 9, 10, 0xFF, 0xFF, 0xFF, 0xFF }, 20.0, out result);
            Add(r, "multi-frame: intermediate frames consumed without completing",
                result == null, "in flight");

            bool done = tp.Offer(id, new byte[] { 250, 0, 0, 0, 0, 0, 0, 0 }, 30.0, out result);
            bool correct = done && result != null && result.IsComplete
                           && result.Data.Length == 10
                           && result.Data[0] == 1 && result.Data[9] == 10;
            Add(r, "multi-frame: last frame (count 250) completes; padding trimmed to 10 bytes",
                correct, result == null ? "null" : result.Data.Length + " bytes");

            // A frame whose payload merely begins with 0x00 must NOT start an assembly
            // when it cannot carry a byte count.
            var tp2 = new MilcanTransport();
            tp2.RegisterMultiFrameType(0x63, 0x01);
            bool swallowed = tp2.Offer(id, new byte[] { 0x00, 0x11 }, 0.0, out result);
            Add(r, "multi-frame: short frame starting 0x00 is NOT treated as a first frame",
                !swallowed, "passed through as single-frame");

            // A declared length of zero is not a multi-frame message.
            var tp3 = new MilcanTransport();
            tp3.RegisterMultiFrameType(0x63, 0x01);
            bool zero = tp3.Offer(id, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }, 0.0, out result);
            Add(r, "multi-frame: zero declared byte count refused", !zero, "passed through");

            // A lost intermediate frame must be REPORTED, not silently handed up short.
            var tp4 = new MilcanTransport();
            tp4.RegisterMultiFrameType(0x63, 0x01);
            tp4.Offer(id, new byte[] { 0, 14, 0, 0, 0, 0, 0, 0 }, 0.0, out result);
            tp4.Offer(id, new byte[] { 1, 1, 2, 3, 4, 5, 6, 7 }, 10.0, out result);
            // count 2 is lost; count 3 arrives instead
            tp4.Offer(id, new byte[] { 3, 8, 9, 10, 11, 12, 13, 14 }, 20.0, out result);
            tp4.Offer(id, new byte[] { 250, 0, 0, 0, 0, 0, 0, 0 }, 30.0, out result);
            Add(r, "multi-frame: lost intermediate frame reported, not silently truncated",
                result != null && !result.IsComplete && result.Fault != null,
                result == null ? "null" : result.Fault);

            // The spec caps the byte count at 0xFAFFFF, not 0xFFFFFF.
            Add(r, "multi-frame: max byte count is 0xFAFFFF (16,449,535)",
                MilcanTransport.MAX_BYTE_COUNT == 0xFAFFFFu && MilcanTransport.MAX_BYTE_COUNT == 16449535u,
                "0x" + MilcanTransport.MAX_BYTE_COUNT.ToString("X6", CultureInfo.InvariantCulture));

            // An over-range declared length must not start an assembly.
            var tp5 = new MilcanTransport();
            tp5.RegisterMultiFrameType(0x63, 0x01);
            bool over = tp5.Offer(id, new byte[] { 0, 0xFF, 0xFF, 0xFF, 0, 0, 0, 0 }, 0.0, out result);
            Add(r, "multi-frame: declared length above 0xFAFFFF refused", !over, "passed through");

            // The CRC field from the last frame is surfaced when present.
            var tp6 = new MilcanTransport();
            tp6.RegisterMultiFrameType(0x63, 0x01);
            tp6.Offer(id, new byte[] { 0, 7, 0, 0, 0, 0, 0, 0 }, 0.0, out result);
            tp6.Offer(id, new byte[] { 1, 1, 2, 3, 4, 5, 6, 7 }, 10.0, out result);
            tp6.Offer(id, new byte[] { 250, 0x34, 0x12, 0, 0, 0, 0, 0 }, 20.0, out result);
            Add(r, "multi-frame: last-frame CRC surfaced little-endian (0x1234)",
                result != null && result.IsComplete && result.Crc.HasValue && result.Crc.Value == 0x1234,
                result == null || !result.Crc.HasValue ? "none" : "0x" + result.Crc.Value.ToString("X4", CultureInfo.InvariantCulture));
        }

        // ------------------------------------------------------------------

        private static void Add(MilcanSelfTestReport r, string name, bool passed, string detail)
        {
            r.Cases.Add(new MilcanSelfTestCase { Name = name, Passed = passed, Detail = detail });
        }
    }
}
