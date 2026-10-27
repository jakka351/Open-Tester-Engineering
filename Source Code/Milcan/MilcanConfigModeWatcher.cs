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
//  MilcanConfigModeWatcher.cs - the 'C' 'F' 'G' enter-configuration handshake.
//
//  WHY THIS IS A SEPARATE, DELIBERATELY FUSSY LITTLE MACHINE
//  --------------------------------------------------------
//  Entering system configuration mode SUSPENDS ALL OPERATIONAL MESSAGING ON THE BUS,
//  INCLUDING SYNC FRAMES (MILA §4.2.3). On a military platform that is not a diagnostic
//  nicety - it is every scheduled message on the vehicle stopping at once. The three
//  message sequence exists precisely so that a stray frame cannot do it by accident,
//  and this class reproduces those rules exactly rather than approximately:
//
//    * The payload characters must be 'C' (0x43), 'F' (0x46), 'G' (0x47), IN ORDER.
//    * Out of order restarts the sequence. An exit-config message mid-sequence
//      restarts it too.
//    * The whole sequence must complete within 500 ms +/-5% of the FIRST message,
//      measured from the first message, not between adjacent ones.
//
//  This watcher is used two ways and both matter:
//    - PASSIVELY, to know what mode the bus is in so the analyzer stops reporting the
//      (legitimate) absence of Sync Frames as a fault.
//    - As the RULE SOURCE for the transmit path, so if TES is ever asked to act as
//      Config Master the timing comes from one place that was written against the spec.
// =============================================================================

using System;

namespace TesterPresent.OBD2.Milcan
{
    /// <summary>
    /// Follows the enter/exit configuration-mode message sequences on the bus
    /// (MWG-MILA-001 Rev 3 §3.2.5.4, §4.2.3).
    /// </summary>
    /// <remarks>Not thread-safe; driven from the session pump thread.</remarks>
    public sealed class MilcanConfigModeWatcher
    {
        // 500 ms +/-5%: a receiver must not accept a sequence that took longer.
        private const double SEQUENCE_TIMEOUT_MS =
            MilcanRegistry.ENTER_CONFIG_SEQUENCE_TIMEOUT_MS * 1.05;

        private int _matched;
        private double _firstMs;
        private bool _inConfigMode;
        private double _lastEnterSequenceMs;

        /// <summary>True when the observed traffic has placed the bus in system configuration mode.</summary>
        public bool InConfigurationMode { get { return _inConfigMode; } }

        /// <summary>How many of the three enter-config characters have matched so far (0..3).</summary>
        public int SequenceProgress { get { return _matched; } }

        /// <summary>
        /// Offers an enter-config frame (primary 0x00, sub 0x81) to the sequence matcher.
        /// </summary>
        /// <param name="payload">The single-byte payload carrying 'C', 'F' or 'G'.</param>
        /// <param name="timestampMs">Session-clock arrival time.</param>
        /// <param name="note">Receives a human-readable note when something notable happened; otherwise null.</param>
        /// <returns>True when this frame COMPLETED the sequence and the bus has just entered configuration mode.</returns>
        public bool OnEnterConfigFrame(byte[] payload, double timestampMs, out string note)
        {
            note = null;

            if (payload == null || payload.Length == 0)
            {
                _matched = 0;
                note = "Enter-config message carried no payload; sequence reset.";
                return false;
            }

            byte c = payload[0];
            byte expected = MilcanRegistry.ENTER_CONFIG_SEQUENCE[_matched];

            // The window is measured from the FIRST character, per §4.2.3.
            if (_matched > 0 && (timestampMs - _firstMs) > SEQUENCE_TIMEOUT_MS)
            {
                _matched = 0;
                expected = MilcanRegistry.ENTER_CONFIG_SEQUENCE[0];
                note = "Enter-config sequence timed out (over 500 ms from its first message); restarted.";
            }

            if (c != expected)
            {
                // A wrong character restarts the sequence. If it happens to be the first
                // character, this frame legitimately starts a NEW attempt.
                bool restarts = c == MilcanRegistry.ENTER_CONFIG_SEQUENCE[0];
                if (_matched > 0)
                {
                    note = string.Format(System.Globalization.CultureInfo.InvariantCulture,
                        "Enter-config sequence broken: expected '{0}' but received 0x{1:X2}{2}.",
                        (char)expected, c, restarts ? "; treated as a new first message" : "; sequence reset");
                }

                _matched = restarts ? 1 : 0;
                if (restarts) _firstMs = timestampMs;
                return false;
            }

            if (_matched == 0) _firstMs = timestampMs;
            _matched++;

            if (_matched < MilcanRegistry.ENTER_CONFIG_SEQUENCE.Length) return false;

            _matched = 0;
            _lastEnterSequenceMs = timestampMs;

            if (_inConfigMode)
            {
                // The Config Master repeats the sequence once per second while it holds
                // the bus in config mode, so a repeat is expected and is NOT a new entry.
                return false;
            }

            _inConfigMode = true;
            note = "ENTER CONFIGURATION MODE sequence completed - all operational messaging including Sync Frames is now suspended on this bus.";
            return true;
        }

        /// <summary>
        /// Offers an exit-config frame (primary 0x00, sub 0x82) carrying "OPR".
        /// </summary>
        /// <param name="payload">The three-byte payload.</param>
        /// <param name="note">Receives a human-readable note, or null.</param>
        /// <returns>True when the bus has just left configuration mode.</returns>
        public bool OnExitConfigFrame(byte[] payload, out string note)
        {
            note = null;

            // An exit message part-way through an enter sequence invalidates it (§4.2.3).
            if (_matched > 0)
            {
                _matched = 0;
                note = "Exit-config message arrived mid enter-sequence; the enter sequence was abandoned.";
            }

            if (payload == null || payload.Length < MilcanRegistry.EXIT_CONFIG_PAYLOAD.Length)
            {
                return false;
            }

            for (int i = 0; i < MilcanRegistry.EXIT_CONFIG_PAYLOAD.Length; i++)
            {
                if (payload[i] != MilcanRegistry.EXIT_CONFIG_PAYLOAD[i]) return false;
            }

            if (!_inConfigMode) return false;

            _inConfigMode = false;
            note = "EXIT CONFIGURATION MODE ('OPR') received - the bus returns to pre-operational.";
            return true;
        }

        /// <summary>
        /// Checks whether configuration mode has lapsed: a device leaves it when the
        /// enter sequence has not been repeated for 8 s +/-1 s (§4.2.3). Called from the
        /// pump so the lapse is detected from the absence of traffic.
        /// </summary>
        /// <param name="nowMs">Current session clock reading.</param>
        /// <returns>True when configuration mode has just lapsed.</returns>
        public bool CheckConfigModeLapse(double nowMs)
        {
            if (!_inConfigMode) return false;

            if ((nowMs - _lastEnterSequenceMs) > MilcanRegistry.CONFIG_MODE_IDLE_TIMEOUT_MS)
            {
                _inConfigMode = false;
                return true;
            }

            return false;
        }

        /// <summary>Clears all sequence and mode state.</summary>
        public void Reset()
        {
            _matched = 0;
            _firstMs = 0.0;
            _inConfigMode = false;
            _lastEnterSequenceMs = 0.0;
        }
    }
}
