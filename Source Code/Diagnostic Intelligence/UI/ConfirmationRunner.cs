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
//  Tester Present Specialist Automotive Solutions — Confirmation Script Runner
//
//  Closes the diagnostic loop: signal-inversion → hypothesis → CONFIRMATION.  A
//  module (M7 bidirectional-confirm, T4 dither) emits a declarative
//  ConfirmationScript; this runner executes it against the live vehicle through
//  the existing UDSManager, one step at a time, behind hard safety gates.
//
//  Safety model (defence in depth):
//    • Observe-only steps that carry a READ payload (0x22/0x19/0x18/0x21/0x3E/0x1A)
//      are executed automatically and their response captured.
//    • Active-control steps are NEVER auto-fired.  They require (a) the session to
//      be ARMED, (b) the target NOT to be a restraints/airbag module — that is a
//      HARD BLOCK here, and (c) an explicit per-step confirmation from the operator
//      that shows the exact bytes to be sent (M7's payloads are platform-default
//      placeholders the operator must validate against service data before firing).
//    • UDSManager.SendRequest is itself the RCM chokepoint, so even a bug here is
//      backstopped by AllowRcmActiveControl staying false.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using TesterPresent.OBD2.UDS;

namespace TesterPresent.OBD2.Intelligence.UI
{
    /// <summary>What happened to one confirmation step.</summary>
    public enum StepOutcome
    {
        Observed,          // read executed, response captured
        ObservePrompt,     // observe-only step with no readable payload — operator watches
        Sent,              // active command sent after arm + confirm
        SkippedNotArmed,   // active step, session not armed
        SkippedByOperator, // operator declined at the confirmation prompt
        BlockedRestraints, // active step targeting an airbag/RCM module — hard blocked
        BlockedWrongTarget,// engine-only active step, but the live transport is a non-powertrain module — hard blocked
        NoResponse,        // sent but the ECU did not answer
        Error,             // exception during execution
    }

    /// <summary>Result of executing one step.</summary>
    public sealed class ConfirmationStepResult
    {
        public ConfirmationStep Step { get; set; }
        public StepOutcome Outcome { get; set; }
        public string Detail { get; set; }
        public UDSResponse Response { get; set; }
    }

    /// <summary>Everything the host needs to render an informed active-control confirmation prompt.</summary>
    public sealed class ConfirmActiveRequest
    {
        public ConfirmationStep Step { get; set; }
        public uint TxId { get; set; }
        public byte Sid { get; set; }
        public byte[] Payload { get; set; }
        public string PayloadHex { get; set; }
        public string WarningText { get; set; }
    }

    /// <summary>Executes a ConfirmationScript against the live vehicle behind safety gates.</summary>
    public sealed class ConfirmationRunner
    {
        private readonly UDSManager _uds;

        // SIDs that are pure reads — safe to auto-execute for observe steps.
        private static readonly HashSet<byte> SafeReadSids = new HashSet<byte> { 0x22, 0x19, 0x18, 0x21, 0x3E, 0x1A };

        public ConfirmationRunner(UDSManager uds) { _uds = uds; }

        /// <summary>
        /// Run the script step by step.
        /// </summary>
        /// <param name="script">The confirmation sequence to execute.</param>
        /// <param name="armed">Operator has authorised active-control tests this session.</param>
        /// <param name="confirmActive">Called before each active-control step with the exact bytes;
        /// return true to send. Not called for observe steps or hard-blocked restraints steps.</param>
        /// <param name="log">Progress sink.</param>
        public IReadOnlyList<ConfirmationStepResult> Run(
            ConfirmationScript script, bool armed,
            Func<ConfirmActiveRequest, bool> confirmActive, Action<string> log)
        {
            var results = new List<ConfirmationStepResult>();
            if (script == null || script.Steps == null) return results;

            Log(log, $"Confirmation: {script.Name}");
            if (!string.IsNullOrEmpty(script.Rationale)) Log(log, "  " + script.Rationale);

            foreach (var step in script.Steps)
            {
                if (step == null) continue;
                var res = RunStep(step, armed, confirmActive, log);
                results.Add(res);
            }

            Log(log, "Confirmation sequence complete.");
            return results;
        }

        private ConfirmationStepResult RunStep(
            ConfirmationStep step, bool armed,
            Func<ConfirmActiveRequest, bool> confirmActive, Action<string> log)
        {
            var res = new ConfirmationStepResult { Step = step };
            byte[] payload = step.Payload;
            byte sid = (payload != null && payload.Length > 0) ? payload[0] : step.ServiceId;
            uint txId = _uds != null ? _uds.TxID : 0;

            try
            {
                if (!step.IsActiveControl)
                {
                    // Observe-only. Auto-execute a read if the payload is a safe read; else prompt.
                    if (_uds != null && payload != null && payload.Length > 0 && SafeReadSids.Contains(sid))
                    {
                        var r = _uds.SendRequest(payload);
                        res.Response = r;
                        if (r == null || (r.RawResponse == null || r.RawResponse.Length == 0))
                        {
                            res.Outcome = StepOutcome.NoResponse;
                            res.Detail = $"{step.Description} — no response";
                        }
                        else
                        {
                            res.Outcome = StepOutcome.Observed;
                            res.Detail = $"{step.Description} → {(r.IsPositive ? r.DataHex : r.ToString())}. Watch for: {step.ExpectedObservation}";
                        }
                        Log(log, "  [read] " + res.Detail);
                    }
                    else
                    {
                        res.Outcome = StepOutcome.ObservePrompt;
                        res.Detail = $"{step.Description}. Watch for: {step.ExpectedObservation}";
                        Log(log, "  [observe] " + res.Detail);
                    }
                    return res;
                }

                // ── Active-control step ──
                // HARD BLOCK: never fire an active-control service at a restraints/airbag module from here.
                if (RcmSafetyGuard.IsDangerous(txId, sid))
                {
                    res.Outcome = StepOutcome.BlockedRestraints;
                    res.Detail = $"BLOCKED — {step.Description} targets a restraints/airbag module (0x{txId:X3}, service 0x{sid:X2}). "
                               + "Active-control tests to an airbag module are not permitted from the intelligence workbench.";
                    Log(log, "  [BLOCKED] " + res.Detail);
                    return res;
                }

                // HARD BLOCK: an engine-only step (injector-cut, idle/actuator dither) must
                // never leave the powertrain.  The module carries no address, so the command
                // goes to whatever the live transport (UDSManager.TxID) is currently pointed
                // at.  If that is not a powertrain module (e.g. the operator left the session
                // on ABS 0x760), refuse — an arbitrary 0x31/0x2F to the wrong module can
                // trigger an unintended actuator/pump/bleed routine.
                if (step.RequiresPowertrainTarget && !IsPowertrainTarget(txId))
                {
                    res.Outcome = StepOutcome.BlockedWrongTarget;
                    res.Detail = $"BLOCKED — {step.Description} is an engine/powertrain-only test but the live transport is "
                               + $"0x{txId:X3} (not a powertrain module). Point the session at the engine PCM before running it.";
                    Log(log, "  [BLOCKED] " + res.Detail);
                    return res;
                }

                if (!armed)
                {
                    res.Outcome = StepOutcome.SkippedNotArmed;
                    res.Detail = $"{step.Description} — skipped (active-control not armed).";
                    Log(log, "  [skip] " + res.Detail);
                    return res;
                }

                if (payload == null || payload.Length == 0)
                {
                    res.Outcome = StepOutcome.ObservePrompt;
                    res.Detail = $"{step.Description} — no command bytes defined (perform manually per service data). Watch for: {step.ExpectedObservation}";
                    Log(log, "  [manual] " + res.Detail);
                    return res;
                }

                string hex = BitConverter.ToString(payload).Replace("-", " ");
                var req = new ConfirmActiveRequest
                {
                    Step = step, TxId = txId, Sid = sid, Payload = payload, PayloadHex = hex,
                    WarningText =
                        $"About to send an ACTIVE command to 0x{txId:X3}:\n\n    {hex}\n\n" +
                        $"Intent: {step.Description}\nExpected: {step.ExpectedObservation}\n\n" +
                        "This payload is a platform-default — CONFIRM it matches the DID/routine in your service " +
                        "data before sending. Vehicle in PARK/NEUTRAL, engine warm as required, and the area clear " +
                        "of people and moving parts.\n\nSend this command?",
                };

                bool proceed = confirmActive != null && confirmActive(req);
                if (!proceed)
                {
                    res.Outcome = StepOutcome.SkippedByOperator;
                    res.Detail = $"{step.Description} — operator declined.";
                    Log(log, "  [decline] " + res.Detail);
                    return res;
                }

                var resp = _uds.SendRequest(payload);
                res.Response = resp;
                if (resp == null || (resp.RawResponse == null || resp.RawResponse.Length == 0))
                {
                    res.Outcome = StepOutcome.NoResponse;
                    res.Detail = $"{step.Description} — sent, no response.";
                }
                else
                {
                    res.Outcome = StepOutcome.Sent;
                    res.Detail = $"{step.Description} — sent. ECU: {(resp.IsPositive ? "positive" : resp.ToString())}. Watch for: {step.ExpectedObservation}";
                }
                Log(log, "  [sent] " + res.Detail);
                return res;
            }
            catch (Exception ex)
            {
                res.Outcome = StepOutcome.Error;
                res.Detail = $"{step.Description} — error: {ex.Message}";
                Log(log, "  [error] " + res.Detail);
                return res;
            }
        }

        /// <summary>True if an 11-bit CAN TX id addresses an engine/powertrain module —
        /// physical PCM/TCM 0x7E0–0x7E7 or the OBD functional request id 0x7DF.  Engine-only
        /// active-control steps are refused against anything outside this set.</summary>
        private static bool IsPowertrainTarget(uint txId)
            => txId == 0x7DFu || (txId >= 0x7E0u && txId <= 0x7E7u);

        private static void Log(Action<string> log, string msg) { try { log?.Invoke(msg); } catch { } }
    }
}
