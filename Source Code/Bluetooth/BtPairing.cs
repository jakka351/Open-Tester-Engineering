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
//  Tester Present Specialist Automotive Solutions — pairing & association assessment (in-process WinRT)
//  BtPairing.cs — assessment workflow step 4.
//
//  "Evaluate the pairing model — legacy vs secure, PIN strength, Just Works acceptance, MITM
//   protection." This uses Windows.Devices.Enumeration custom pairing to:
//    • report the current pairing state + negotiated protection level,
//    • attempt an association and record WHICH pairing kind the unit offered
//      (ConfirmOnly = Just Works = no MITM; ProvidePin = a PIN it will accept from us;
//       ConfirmPinMatch = secure numeric comparison),
//    • on a PIN-requesting unit, try a small fixed-PIN dictionary (0000/1234/… — the ones the
//      assessment calls out as common on embedded/aftermarket hardware).
//
//  This is a real association attempt — an in-scope, operator-driven step. The caller decides
//  whether to unpair afterward. Nothing here dials, reads data, or touches the vehicle bus.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.Devices.Enumeration;
using Windows.Foundation;

namespace TesterPresent.OBD2.Bluetooth
{
    public sealed class PairingAssessment
    {
        public bool WasAlreadyPaired;
        public bool CanPair;
        public string CurrentProtection = "";     // None / Encryption / EncryptionAndAuthentication
        public string OfferedPairingKind = "";     // ConfirmOnly / ProvidePin / DisplayPin / ConfirmPinMatch / ProvidePasswordCredential
        public bool JustWorksAccepted;             // ConfirmOnly path succeeded → no MITM
        public string AcceptedPin = "";            // the fixed PIN that worked, if any
        public bool PairedNow;                     // did we end up bonded during the assessment
        public string ResultStatus = "";           // DevicePairingResultStatus
        public BtSeverity Severity = BtSeverity.Info;
        public string Summary = "";
    }

    public static class BtPairing
    {
        /// <summary>Common fixed PINs called out by the assessment as widespread on embedded/aftermarket units.</summary>
        public static readonly string[] DefaultPinDictionary = { "0000", "1234", "1111", "8888", "9999", "1212", "2580", "0852" };

        /// <summary>
        /// Assess the pairing model of an endpoint. If tryPinDictionary is true and the unit asks
        /// for a PIN, attempts each PIN in <paramref name="pins"/>. Set unpairAfter to leave the
        /// device as it was found. Never throws.
        /// </summary>
        public static async Task<PairingAssessment> AssessAsync(BtEndpoint ep, bool tryPinDictionary, IEnumerable<string> pins, bool unpairAfter, Action<string> log = null)
        {
            var a = new PairingAssessment();
            if (ep == null || string.IsNullOrEmpty(ep.WinRtDeviceId))
            { a.Summary = "No WinRT device id — enumerate the device (paired or inquiry) before assessing pairing."; return a; }

            DeviceInformation di;
            try { di = await WinRt.Await(DeviceInformation.CreateFromIdAsync(ep.WinRtDeviceId), 8000).ConfigureAwait(false); }
            catch (Exception ex) { a.Summary = "CreateFromId failed: " + ex.Message; return a; }
            if (di == null || di.Pairing == null) { a.Summary = "No pairing information available."; return a; }

            a.WasAlreadyPaired = di.Pairing.IsPaired;
            a.CanPair = di.Pairing.CanPair;
            a.CurrentProtection = di.Pairing.ProtectionLevel.ToString();

            if (di.Pairing.IsPaired)
            {
                a.PairedNow = true;
                a.Severity = di.Pairing.ProtectionLevel == DevicePairingProtectionLevel.EncryptionAndAuthentication ? BtSeverity.Info : BtSeverity.Medium;
                a.Summary = "Already paired; negotiated protection = " + a.CurrentProtection +
                            (a.Severity == BtSeverity.Medium ? "  (no authentication → MITM-susceptible bond)." : ".");
                return a;
            }
            if (!di.Pairing.CanPair) { a.Summary = "Device reports it cannot be paired from this host."; return a; }

            var custom = di.Pairing.Custom;
            var pinList = new List<string>();
            if (tryPinDictionary) pinList.AddRange(pins ?? DefaultPinDictionary);
            int pinIdx = 0;
            string usedPin = null;

            TypedEventHandler<DeviceInformationCustomPairing, DevicePairingRequestedEventArgs> handler = (s, args) =>
            {
                a.OfferedPairingKind = args.PairingKind.ToString();
                switch (args.PairingKind)
                {
                    case DevicePairingKinds.ConfirmOnly:          // Just Works — accept, note the lack of MITM
                        a.JustWorksAccepted = true;
                        args.Accept();
                        break;
                    case DevicePairingKinds.ConfirmPinMatch:      // secure numeric comparison — accept the match
                        args.Accept();
                        break;
                    case DevicePairingKinds.DisplayPin:           // unit displays a PIN it expects us to enter elsewhere — accept
                        args.Accept();
                        break;
                    case DevicePairingKinds.ProvidePin:           // unit wants a PIN from us — only feed one if the dictionary is enabled
                        if (pinIdx < pinList.Count) { usedPin = pinList[pinIdx]; args.Accept(usedPin); }
                        // else: leave the request unaccepted — we never submit a guessed PIN the operator didn't authorise.
                        break;
                    default:
                        try { args.Accept(); } catch { }
                        break;
                }
            };
            custom.PairingRequested += handler;

            try
            {
                // Only offer to negotiate a PIN when the dictionary is enabled; otherwise never ask the
                // unit to enter a PIN-based (legacy) association the operator hasn't authorised.
                var kinds = DevicePairingKinds.ConfirmOnly | DevicePairingKinds.DisplayPin | DevicePairingKinds.ConfirmPinMatch;
                if (tryPinDictionary && pinList.Count > 0) kinds |= DevicePairingKinds.ProvidePin;

                DevicePairingResult result = null;
                do
                {
                    result = await WinRt.Await(custom.PairAsync(kinds, DevicePairingProtectionLevel.Default), 25000).ConfigureAwait(false);
                    a.ResultStatus = result.Status.ToString();
                    if (result.Status == DevicePairingResultStatus.Paired)
                    {
                        a.PairedNow = true;
                        a.AcceptedPin = usedPin ?? "";
                        a.CurrentProtection = result.ProtectionLevelUsed.ToString();
                        break;
                    }
                    // If a wrong PIN failed, advance and retry the next dictionary entry.
                    pinIdx++;
                    log?.Invoke("Pairing attempt status: " + result.Status + (usedPin != null ? " (pin " + usedPin + ")" : ""));
                }
                while (a.OfferedPairingKind == DevicePairingKinds.ProvidePin.ToString() && pinIdx < pinList.Count);
            }
            catch (Exception ex) { a.Summary = "Pairing attempt error: " + ex.Message; }
            finally { custom.PairingRequested -= handler; }

            // Classify severity.
            if (a.PairedNow && a.JustWorksAccepted)
            { a.Severity = BtSeverity.High; a.Summary = "Just Works pairing accepted with NO MITM protection — any nearby host can associate."; }
            else if (a.PairedNow && !string.IsNullOrEmpty(a.AcceptedPin))
            { a.Severity = BtSeverity.High; a.Summary = "Fixed PIN accepted: '" + a.AcceptedPin + "'. Legacy/guessable pairing."; }
            else if (a.PairedNow)
            { a.Severity = a.CurrentProtection == DevicePairingProtectionLevel.EncryptionAndAuthentication.ToString() ? BtSeverity.Info : BtSeverity.Medium;
              a.Summary = "Paired; protection = " + a.CurrentProtection + ". Offered kind = " + a.OfferedPairingKind + "."; }
            else
            { a.Severity = BtSeverity.Info; a.Summary = "Did not pair (status " + a.ResultStatus + "). Offered kind = " + a.OfferedPairingKind + "."; }

            if (a.PairedNow && unpairAfter)
            {
                try
                {
                    var unpair = await WinRt.Await(di.Pairing.UnpairAsync(), 10000).ConfigureAwait(false);
                    log?.Invoke("Unpaired after assessment: " + unpair.Status);
                    a.PairedNow = false;
                }
                catch (Exception ex) { log?.Invoke("Unpair failed: " + ex.Message); }
            }
            return a;
        }
    }
}
