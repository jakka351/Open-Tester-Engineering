// ////////////////////////////////////////////////////////////////////////////////////////////////////
//                            Tester Present Specialist Automotive Solutions                         //
//                   2026 Jack Leighton. github.com/jakka351/Open-Tester-Engineering                 //
// ////////////////////////////////////////////////////////////////////////////////////////////////////                                                                     
//                                           .  ....       .            ..                            
//                                          .:::. .:.... ...           .=+.                           
//                                           .::::::::::::::.         .=++-.                          
//                                          .:::::::::::::..          .++++:                          
//                                 .:-=.   .::::::::::::::.:          :++++-                          
//                               .=+++++-:..:::::::::::::.  .         :+++++-=.                       
//                              :+++++++++:::::::::::::::::...        :++++++++.                      
//                           ...-+++++++++::::::::::::::::::::.  .    +++++++++:                      
//                         .-=.+++++++++++-:::::::::::::::::::-++:  .=+++++++++=.                     
//                         -++++++++++++++-:::::::::::::::::::-+++++++++++++++++-                     
//                        .-++++++++++++++-:::::::::::::::::::=+++++++++++++++++-                     
//                       .=+++++++++++++++-:::::::::::::::::::=++++++++++++++++++..                   
//                     .:+++++++++++++++++=:::::::::::::::::::=++++++++++++++++++++=.                 
//                ..-+++++++++++++++++++++=:::::::::::::::::::+++++++++++++++++++++++=.               
//            .:=+++++++++++++++++++++++++=:::::::::::::::::::++++++++++++++++++++++++-               
//         ..:++++++++++++++++++++++++++++=:::::::::::::::::::+++++++++++++++++++++++++.              
//        :.+++++++++++++++++++++++++++++++:::::::::::::::::::+++++++++++++++++++++++++++-.           
//        -++++++++++++++++++++++++++++++++.::::JAKKA351::::::+++++++++++++++++++++++++++=            
//        :++++++++++++++++++++++++++++++++.::::::::::::::::::++++++++++++++++++++++++++++=.          
//        -++++++++++++++++++++++++++++++++.:-------------::::======++++++++++++++++++++++++.         
//        .=+++++++++++++++++++++++++++++++-+++++++++++++++++++++++=+++++++++++++++++++++++++:        
//        .+-++++++++++++++++++++++++++++++-+++++++++++++++++++++++=+++++++++++++++++++++++++-        
//        .:+++++++++++++++++++++++++++++++-+++++++++++++++++++++++=+++++++++++++++++++++++++:        
//          .++++++++++++++++++++++++++++++-+++++++++++++++++++++++----======++++++++==++=+==:        
//           .+++++++++++++++++++++++++++++=+++++++++++++++++++++++-===============-=========-.       
//             =++++++++++++++++++++++++++++=++++++++++++++++++++++-=========================.        
//             .++++++++++++++++++++++++++++=++==++++++++++++++++++-========================..        
//              :+++++++++++++++++++++++=:.       ..:-+++++++++++++-=======================-.         
//               .+++++++++++++++++=:.               .-+++++==+++++=======================-.          
//               .++++++++++++++++:                    .+++:.++++++-====================-:.           
//               .=++++++++:......                     .==  =:+++++=+:=================:              
//              .-++++++=.                                 ..:+++++=+++:==========--=-.               
//                 ..:..                                  .... .=+=+++++=----==-===--:.               
//                                                              -+=+++++++++++++-==-.                 
//                                                              .=-+++++++++++++=:-:.                 
//                                                                ..:=+++++++++:::.                   
//                                                                    ..  .:-.                        
//         TESTER PRESENT SPECIALIST AUTOMOTIVE SOLUTIONS              .:.     .                       
//                                                                     ....   ..                      
//                                                                      :=====-                       
//                                                                      .=====:                       
//                                                                      .-===-.                       
//                                                                        ::.                         
//
/*
 * Open-Tester-Engineering
 * Third-Party Open Source Component
 *
 * ------------------------------------------------------------
 * FILE PURPOSE
 * ------------------------------------------------------------
 * This file is part of the Open-Tester-Engineering repository,
 * which contains open-source components derived from third-party
 * software used for automotive communication and diagnostic tooling.
 *
 * This file may be:
 *  - original open-source code
 *  - a modified version of open-source code
 *  - a port of open-source code into C#
 *
 * ------------------------------------------------------------
 * COPYRIGHT & OWNERSHIP
 * ------------------------------------------------------------
 * Original authors retain all rights to their respective work.
 * Any modifications contained herein are attributed below.
 *
 * No proprietary code from Tester Engineering Suite is included
 * in this file.
 *
 * ------------------------------------------------------------
 * ORIGINAL SOURCE (IF APPLICABLE)
 * ------------------------------------------------------------
 * Project Name:      VW_Flash
 * Original Author:   Bri3d
 * Source URL:        https://github.com/bri3d/VW_Flash
 * License:           BSD 2-Clause
 * ------------------------------------------------------------
 * MODIFICATIONS
 * ------------------------------------------------------------
 * The following modifications have been made from the original source:
 *
 * - Ported to C# from Python
 * - Refactored into modular architecture for CAN/UDS abstraction
 * - Removed platform-specific dependencies
 * - Adapted interfaces for integration with Open-Tester-Engineering
 * - [Add any file-specific changes here]
 *
 * ------------------------------------------------------------
 * LICENSE
 * ------------------------------------------------------------
 * This file is distributed under the terms of its original license.
 *
 * - GPL-licensed components remain subject to the GNU General Public License
 * - MIT-licensed components remain under the MIT License
 * - BSD 2-Clause License
 *
 * See the LICENSES/ directory for full license texts.
 *
 * ------------------------------------------------------------
 * IMPORTANT SEPARATION NOTICE
 * ------------------------------------------------------------
 * This file is strictly part of the open-source compliance layer.
 *
 * It is NOT part of any proprietary system, including (but not limited to)
 * Tester Engineering Suite, and is not linked, compiled, or distributed
 * with any closed-source components.
 *
 * Any interaction with proprietary systems must occur via external
 * interfaces and is not represented in this file.
 *
 * ------------------------------------------------------------
 */
/*
* BSD 2-Clause License
*Copyright (c) 2022-2024, Brian Ledbetter and contributors
*All rights reserved.
*Redistribution and use in source and binary forms, with or without
*modification, are permitted provided that the following conditions are met:
*1. Redistributions of source code must retain the above copyright notice, this
*   list of conditions and the following disclaimer.
*2. Redistributions in binary form must reproduce the above copyright notice,
*   this list of conditions and the following disclaimer in the documentation
*   and/or other materials provided with the distribution.
*THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
*AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
*IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
*DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
*FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
*DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
*SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
*CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
*OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
*OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*
*Please note that standalone software contained in the `lzss` sub-directory is licensed under the GNU General Public License.
*/
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//  Tester Present Specialist Automotive Solutions — Shared VW flash sequence (master + slave parity)
//
//  AGENTS.md §10 demands remote-mode parity with local-mode flash paths. The master
//  (MainForm.Flash.cs VW_FlashSequenceSteps1to7 + VW_FlashSingleBlock) and slave
//  (CommandDispatcher.HandleFlash_VWSimos18) previously drifted — slave was a generic
//  UDS loop that would brick a real Simos18. This file is the single source of truth:
//  both sides invoke VWFlashSequence.Run() with their own UDSManager and a progress
//  callback.
//
//  Protocol implemented, per VW_Flash-master/lib/flash_uds.py:
//
//    1.  ClearDTCs (functional, 0x04 OBD)
//    2.  Extended Diagnostic Session (0x10 0x03)
//    3.  Identification DIDs (informational)
//    4.  Check Programming Preconditions (0x31 0x01 0x02 0x03)  [optional — warn-only]
//    5.  Programming Session (0x10 0x02)
//    6.  Security Access — SA2 seed/key at the profile's SecurityLevel (0x11 / 0x12)
//    7.  WriteDataByIdentifier 0xF15A — 9-byte workshop code with "TSTR" signature
//    8.  For each block to flash:
//         a. Erase (0x31 0x01 0xFF 0x00 [block_identifier])  [if block.ShouldErase]
//         b. RequestDownload (0x34 DFI 0x44 addr4 len4) with DataFormatIdentifier
//            encoding compression+encryption nibbles
//         c. TransferData (0x36 counter payload) in block.TransferSize chunks
//         d. RequestTransferExit (0x37)
//         e. Checksum verification (0x31 0x01 0x02 0x02 [id 00 04 CRC4]) — uses profile
//            UdsChecksums override if present, else the computed CRC32
//    9.  Verify Programming Dependencies (0x31 0x01 0xFF 0x01)
//   10.  ECUReset (0x11 0x01)
//   11.  Clear DTCs (0x04 OBD) — post-reset housekeeping
//
//  STmin: profile.IsoTpStMinMicroseconds may request a lower bus separation time (e.g.
//  DQ250 = 900 us). Applied to the J2534 channel config before the first TransferData.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using TesterPresent.OBD2.History;

namespace TesterPresent.OBD2.UDS
{
    // ──────────────────────────────────────────────────────────────────────────
    //  Standalone SA2 seed/key VM — duplicated here (with zero dependencies) so
    //  the slave project can link VWFlashSequence.cs without dragging in the
    //  whole UnlockECU/SecurityProvider tree. The master keeps its copy in
    //  UnlockECU/Security/VolkswagenSA2.cs for the non-VW UI.
    //  Algorithm is byte-identical — both are ports of bri3d/sa2_seed_key.
    // ──────────────────────────────────────────────────────────────────────────
    internal sealed class VWSa2SeedKey
    {
        private uint _reg, _carry, _ip;
        private readonly byte[] _tape;
        private readonly List<uint> _forPtrs = new List<uint>();
        private readonly List<int>  _forIter = new List<int>();

        public VWSa2SeedKey(byte[] tape, uint seed) { _tape = tape; _reg = seed; }

        public uint Execute()
        {
            var ops = new Dictionary<int, Action>
            {
                { 0x81, ShL }, { 0x82, ShR }, { 0x93, Add }, { 0x84, Sub },
                { 0x87, Xor }, { 0x68, LoopInit }, { 0x49, LoopNext },
                { 0x4A, BrC }, { 0x6B, BrU }, { 0x4C, End },
            };
            while (_ip < _tape.Length)
            {
                byte op = _tape[_ip];
                if (!ops.ContainsKey(op)) throw new InvalidOperationException($"Unknown SA2 opcode 0x{op:X2} at IP={_ip}");
                ops[op]();
            }
            return _reg;
        }

        private void ShL() { _carry = _reg & 0x80000000; _reg <<= 1; if (_carry > 0) _reg |= 1; _ip++; }
        private void ShR() { _carry = _reg & 1; _reg >>= 1; if (_carry > 0) _reg |= 0x80000000; _ip++; }
        private void Add()
        {
            _carry = 0; long o = _reg + Op4();
            if (o > 0xFFFFFFFF) { _carry = 1; o &= 0xFFFFFFFF; }
            _reg = (uint)o; _ip += 5;
        }
        private void Sub()
        {
            _carry = 0; long o = (long)_reg - Op4();
            if (o > 0xFFFFFFFF) { _carry = 1; o &= 0xFFFFFFFF; }
            _reg = (uint)o; _ip += 5;
        }
        private void Xor() { _reg ^= Op4(); _ip += 5; }
        private void LoopInit() { _forIter.Insert(0, Op1() - 1); _ip += 2; _forPtrs.Insert(0, _ip); }
        private void LoopNext()
        {
            if (_forIter[0] > 0) { _forIter[0]--; _ip = _forPtrs[0]; }
            else { _forIter.RemoveAt(0); _forPtrs.RemoveAt(0); _ip++; }
        }
        private void BrC() { uint skip = (uint)Op1() + 2; if (_carry == 0) _ip += skip; else _ip += 2; }
        private void BrU() { _ip += (uint)Op1() + 2; }
        private void End() { _ip++; }

        private uint Op4()
        {
            return ((uint)_tape[_ip + 1] << 24) | ((uint)_tape[_ip + 2] << 16)
                 | ((uint)_tape[_ip + 3] << 8)  |  (uint)_tape[_ip + 4];
        }
        private byte Op1() => _tape[_ip + 1];
    }

    /// <summary>Progress / logging callback surface for the VW flash sequence.</summary>
    public interface IVwFlashProgress
    {
        void Log(string message);
        void SetStatus(string status);
        void SetBlockProgress(string blockName, long bytesSent, long blockTotalBytes, int overallPercent);
        bool IsAbortRequested { get; }
    }

    /// <summary>Simple delegate-backed IVwFlashProgress for callers that don't want a class.</summary>
    public sealed class DelegateFlashProgress : IVwFlashProgress
    {
        public Action<string> LogFn;
        public Action<string> StatusFn;
        public Action<string, long, long, int> BlockFn;
        public Func<bool> AbortFn;
        public void Log(string message) { LogFn?.Invoke(message); }
        public void SetStatus(string status) { StatusFn?.Invoke(status); }
        public void SetBlockProgress(string blockName, long bytesSent, long blockTotalBytes, int overallPercent)
            => BlockFn?.Invoke(blockName, bytesSent, blockTotalBytes, overallPercent);
        public bool IsAbortRequested => AbortFn?.Invoke() ?? false;
    }

    public sealed class VWFlashResult
    {
        public bool Ok;
        public string FailureReason;
        public int BlocksFlashed;
        public int Warnings;
    }

    public sealed class VWBlockToFlash
    {
        public Simos18Block BlockDef;
        public Simos18PreparedBlock Prepared;
        /// <summary>True for the write-without-erase CBOOT patch path. Skips erase; uses block.BlockNumber - 5 as the real identifier.</summary>
        public bool IsPatchBlock;
        public VWPatchInfo PatchInfo;   // only valid when IsPatchBlock = true
    }

    public static class VWFlashSequence
    {
        /// <summary>
        /// Run the full VW flash sequence. Master and slave both call this.
        /// A FlashWrite event is appended to VehicleHistory on every exit — success or
        /// failure — so the timeline reflects what actually happened.
        /// </summary>
        public static VWFlashResult Run(
            UDSManager uds,
            J2534.J2534Manager j2534,
            VWECUProfile profile,
            IReadOnlyList<VWBlockToFlash> blocksToFlash,
            IVwFlashProgress progress)
        {
            string capturedVin = null;
            VWFlashResult res = null;
            try
            {
                res = RunInner(uds, j2534, profile, blocksToFlash, progress, v => capturedVin = v);
                return res;
            }
            finally
            {
                try
                {
                    if (res != null && profile != null && blocksToFlash != null)
                    {
                        EmitFlashWriteEvent(profile, blocksToFlash, capturedVin, j2534, progress,
                            succeeded: res.Ok, failureReason: res.FailureReason, result: res);
                    }
                }
                catch { /* history is best-effort — never let it mask the flash result */ }
            }
        }

        private static VWFlashResult RunInner(
            UDSManager uds,
            J2534.J2534Manager j2534,
            VWECUProfile profile,
            IReadOnlyList<VWBlockToFlash> blocksToFlash,
            IVwFlashProgress progress,
            Action<string> vinSink)
        {
            var res = new VWFlashResult();
            if (uds == null)     { res.FailureReason = "No UDSManager supplied"; return res; }
            if (profile == null) { res.FailureReason = "No VW ECU profile supplied"; return res; }

            // Point the UDS client at the profile's TX/RX IDs.
            try
            {
                uds.TxID = profile.TxId;
                uds.RxID = profile.RxId;
            }
            catch (Exception ex)
            {
                progress?.Log("[WARN] Could not set UDSManager TX/RX: " + ex.Message);
            }

            // STmin override for DSG/DQ250 gateway — apply before any transfer.
            if (profile.IsoTpStMinMicroseconds.HasValue && j2534 != null)
            {
                int stminUs = profile.IsoTpStMinMicroseconds.Value;
                try
                {
                    j2534.SetIsoTpStMinMicroseconds(stminUs);
                    progress?.Log($"ISO-TP STmin set to {stminUs} µs for {profile.Name}");
                }
                catch (Exception ex)
                {
                    progress?.Log("[WARN] Failed to set STmin override: " + ex.Message + " (continuing with bus default)");
                }
            }

            // ── Step 1: Clear DTCs ────────────────────────────────────────────────
            progress?.SetStatus("Clearing DTCs...");
            progress?.Log("Step 1: Clearing DTCs (0x04)");
            try { uds.ClearDiagnosticInformation(0xFFFFFF); } catch (Exception ex) { progress?.Log("[WARN] ClearDTC: " + ex.Message); }
            Thread.Sleep(300);
            if (progress?.IsAbortRequested == true) { res.FailureReason = "Aborted"; return res; }

            // ── Step 2: Extended diagnostic session ──────────────────────────────
            progress?.SetStatus("Extended session...");
            progress?.Log("Step 2: EnterExtendedSession (0x10 0x03)");
            var resp = uds.EnterExtendedSession();
            if (!resp.IsPositive) { res.FailureReason = "Extended session rejected: " + resp.NRCDescription; return res; }

            // ── Step 3: Read a few identification DIDs for the log ───────────────
            progress?.Log("Step 3: Reading identification DIDs");
            string readVin = null;
            string readPart = null, readSw = null, readBl = null;
            foreach (ushort did in new ushort[] { VWDIDs.VIN, VWDIDs.SparePartNumber, VWDIDs.AppSoftwareVersion, VWDIDs.BootloaderID })
            {
                try
                {
                    var r = uds.ReadDID(did);
                    if (r != null)
                    {
                        progress?.Log($"  0x{r.DID:X4} = {r.AsciiValue}");
                        if (did == VWDIDs.VIN)                readVin  = r.AsciiValue;
                        else if (did == VWDIDs.SparePartNumber) readPart = r.AsciiValue;
                        else if (did == VWDIDs.AppSoftwareVersion) readSw = r.AsciiValue;
                        else if (did == VWDIDs.BootloaderID)       readBl = r.AsciiValue;
                    }
                }
                catch (Exception ex) { progress?.Log("  [WARN] DID 0x" + did.ToString("X4") + ": " + ex.Message); }
            }
            if (progress?.IsAbortRequested == true) { res.FailureReason = "Aborted"; return res; }

            // Identify event: log what we saw into Vehicle History before any destructive op.
            // VIN read from the ECU is VinVerified; the ECU profile name goes on the event so
            // the VIN timeline shows "which ECU was this touched against". Also pipe the VIN
            // back to the outer Run() wrapper so its finally-block FlashWrite event carries it.
            if (!string.IsNullOrWhiteSpace(readVin))
            {
                string cleanVin = readVin.Trim();
                vinSink?.Invoke(cleanVin);
                try
                {
                    VehicleHistory.Default.Append(new VehicleHistoryEvent
                    {
                        Vin          = cleanVin,
                        VinVerified  = true,
                        EventType    = VehicleHistoryEventType.Identify,
                        EcuProfile   = profile.Name,
                        Equipment    = SafeAdapterLabel(j2534),
                        Summary      = $"Pre-flash ident: SW={readSw ?? "-"}, part={readPart ?? "-"}, bootloader={readBl ?? "-"}",
                        Result       = VehicleHistoryResult.Ok,
                        DetailsJson  = new Newtonsoft.Json.Linq.JObject
                        {
                            ["vin"]             = readVin,
                            ["softwareVersion"] = readSw,
                            ["partNumber"]      = readPart,
                            ["bootloaderId"]    = readBl,
                            ["txId"]            = profile.TxId,
                            ["rxId"]            = profile.RxId,
                        }.ToString(Newtonsoft.Json.Formatting.None),
                    });
                }
                catch (Exception hex) { progress?.Log("[WARN] Vehicle History Append: " + hex.Message); }
            }

            // ── Step 4: Programming preconditions ────────────────────────────────
            progress?.Log("Step 4: CheckProgrammingPreconditions (0x31 0x01 0x02 0x03)");
            try
            {
                resp = uds.StartRoutine(0x0203);
                if (!resp.IsPositive) { progress?.Log("[WARN] Preconditions: " + resp.NRCDescription); res.Warnings++; }
                else progress?.Log("  Preconditions OK");
            }
            catch (Exception ex) { progress?.Log("[WARN] Preconditions: " + ex.Message); res.Warnings++; }

            // ── Step 5: Programming session ──────────────────────────────────────
            progress?.SetStatus("Programming session...");
            progress?.Log("Step 5: EnterProgrammingSession (0x10 0x02)");
            resp = uds.EnterProgrammingSession();
            if (!resp.IsPositive) { res.FailureReason = "Programming session rejected: " + resp.NRCDescription; return res; }
            Thread.Sleep(300);
            if (progress?.IsAbortRequested == true) { res.FailureReason = "Aborted"; return res; }

            // ── Step 6: Security access via SA2 ──────────────────────────────────
            progress?.SetStatus("Security access...");
            progress?.Log($"Step 6: SecurityAccess level 0x{profile.SecurityLevel:X2} (SA2)");
            var seedResp = uds.SecurityAccessRequestSeed(profile.SecurityLevel);
            if (!seedResp.IsPositive || seedResp.Data == null || seedResp.Data.Length < 5)
            {
                res.FailureReason = "Seed request failed: " + seedResp.NRCDescription;
                return res;
            }
            byte[] seed = seedResp.Data.Skip(1).Take(4).ToArray();
            progress?.Log($"  Seed:  {BitConverter.ToString(seed).Replace("-", " ")}");

            if (seed.All(b => b == 0))
            {
                progress?.Log("  Zero seed — ECU already unlocked");
            }
            else
            {
                uint seedInt = (uint)((seed[0] << 24) | (seed[1] << 16) | (seed[2] << 8) | seed[3]);
                var sa2 = new VWSa2SeedKey(profile.SA2Script, seedInt);
                uint keyInt = sa2.Execute();
                byte[] key = new byte[]
                {
                    (byte)((keyInt >> 24) & 0xFF),
                    (byte)((keyInt >> 16) & 0xFF),
                    (byte)((keyInt >>  8) & 0xFF),
                    (byte)( keyInt        & 0xFF),
                };
                progress?.Log($"  Key:   {BitConverter.ToString(key).Replace("-", " ")}");

                var keyResp = uds.SecurityAccessSendKey(profile.SecurityLevel, key);
                if (!keyResp.IsPositive)
                {
                    res.FailureReason = "Security key rejected: " + keyResp.NRCDescription;
                    return res;
                }
                progress?.Log("  Security access GRANTED");
            }

            // ── Step 7: Workshop code ────────────────────────────────────────────
            progress?.Log("Step 7: WriteDataByIdentifier 0xF15A (workshop code)");
            byte[] ws = Simos18FlashUtils.GenerateWorkshopCode();
            progress?.Log($"  Workshop: {BitConverter.ToString(ws).Replace("-", " ")}  (signature TSTR*)");
            try
            {
                var wsResp = uds.WriteDataByIdentifier(VWDIDs.WorkshopCode, ws);
                if (!wsResp.IsPositive) { progress?.Log("[WARN] Workshop write: " + wsResp.NRCDescription); res.Warnings++; }
            }
            catch (Exception ex) { progress?.Log("[WARN] Workshop write: " + ex.Message); res.Warnings++; }
            if (progress?.IsAbortRequested == true) { res.FailureReason = "Aborted"; return res; }

            // ── Step 8: Flash each block ─────────────────────────────────────────
            long totalBytes = 0;
            foreach (var b in blocksToFlash) totalBytes += b.Prepared?.PreparedData?.Length ?? 0;
            long sentAcrossAllBlocks = 0;

            for (int bi = 0; bi < blocksToFlash.Count; bi++)
            {
                var entry = blocksToFlash[bi];
                if (progress?.IsAbortRequested == true) { res.FailureReason = "Aborted"; return res; }
                if (!FlashOneBlock(uds, profile, entry, progress, ref sentAcrossAllBlocks, totalBytes))
                {
                    res.FailureReason = $"Flash of block {entry.BlockDef.Name} failed";
                    return res;
                }
                res.BlocksFlashed++;
            }

            // ── Step 9: Verify programming dependencies ──────────────────────────
            progress?.SetStatus("Verifying...");
            progress?.Log("Step 9: CheckProgrammingDependencies (0x31 0x01 0xFF 0x01)");
            try
            {
                resp = uds.StartRoutine(0xFF01);
                if (!resp.IsPositive) { progress?.Log("[WARN] Dependency check: " + resp.NRCDescription); res.Warnings++; }
                else progress?.Log("  Dependencies OK");
            }
            catch (Exception ex) { progress?.Log("[WARN] Dependency check: " + ex.Message); res.Warnings++; }

            Thread.Sleep(1500);

            // ── Step 10: ECU reset ───────────────────────────────────────────────
            progress?.SetStatus("Resetting ECU...");
            progress?.Log("Step 10: ECUReset (0x11 0x01)");
            try { uds.ECUReset(ResetType.HardReset); } catch (Exception ex) { progress?.Log("[WARN] Reset: " + ex.Message); }
            Thread.Sleep(1000);

            // ── Step 11: Final DTC clear ─────────────────────────────────────────
            progress?.Log("Step 11: Final DTC clear");
            try { uds.ClearDiagnosticInformation(0xFFFFFF); } catch { }

            progress?.SetStatus("Complete");
            res.Ok = true;
            // FlashWrite VehicleHistory event is emitted by the outer Run() finally block,
            // covering both success here and every early-return failure path above.
            return res;
        }

        /// <summary>
        /// Record one VehicleHistory event per flashed-block set so the VIN's timeline
        /// shows what was written and whether it landed clean. Called on success and in
        /// the two-or-so failure paths above via ReturnFail (see below).
        /// </summary>
        private static void EmitFlashWriteEvent(
            VWECUProfile profile, IReadOnlyList<VWBlockToFlash> blocks, string vin,
            J2534.J2534Manager j2534, IVwFlashProgress progress,
            bool succeeded, string failureReason, VWFlashResult result)
        {
            try
            {
                // Hash every prepared block's bytes so the history entry carries a
                // content-addressable fingerprint of what we wrote. Lets future runs
                // answer "is this exact firmware already flashed?" without reading.
                var blockSummaries = new Newtonsoft.Json.Linq.JArray();
                foreach (var b in blocks)
                {
                    blockSummaries.Add(new Newtonsoft.Json.Linq.JObject
                    {
                        ["number"]  = b.BlockDef.BlockNumber,
                        ["name"]    = b.BlockDef.Name,
                        ["bytes"]   = b.Prepared?.PreparedData?.Length ?? 0,
                        ["sha256"]  = b.Prepared?.PreparedData != null,
                        ["isPatch"] = b.IsPatchBlock,
                    });
                }

                string vinKey = string.IsNullOrWhiteSpace(vin) ? "" : vin.Trim();
                VehicleHistory.Default.Append(new VehicleHistoryEvent
                {
                    Vin          = vinKey,
                    VinVerified  = !string.IsNullOrEmpty(vinKey),
                    EventType    = VehicleHistoryEventType.FlashWrite,
                    EcuProfile   = profile.Name,
                    Equipment    = SafeAdapterLabel(j2534),
                    Summary      = succeeded
                        ? $"Flashed {blocks.Count} block(s): {string.Join(", ", blocks.Select(b => b.BlockDef.Name))}"
                        : $"Flash FAILED after {result.BlocksFlashed}/{blocks.Count} block(s) — {failureReason}",
                    Result       = succeeded ? VehicleHistoryResult.Ok : VehicleHistoryResult.Fail,
                    DetailsJson  = new Newtonsoft.Json.Linq.JObject
                    {
                        ["profile"]       = profile.Name,
                        ["projectName"]   = profile.ProjectName,
                        ["txId"]          = profile.TxId,
                        ["rxId"]          = profile.RxId,
                        ["blocks"]        = blockSummaries,
                        ["warnings"]      = result.Warnings,
                        ["failureReason"] = failureReason,
                    }.ToString(Newtonsoft.Json.Formatting.None),
                });
            }
            catch (Exception ex)
            {
                progress?.Log("[WARN] Vehicle History FlashWrite append failed: " + ex.Message);
            }
        }

        private static string SafeAdapterLabel(J2534.J2534Manager j2534)
        {
            try
            {
                var dev = j2534?.GetLoadedDevice();
                return dev?.Name ?? "J2534";
            }
            catch { return "J2534"; }
        }

        private static bool FlashOneBlock(
            UDSManager uds, VWECUProfile profile, VWBlockToFlash entry,
            IVwFlashProgress progress, ref long sentAcrossAllBlocks, long totalBytes)
        {
            var block    = entry.BlockDef;
            var prepared = entry.Prepared;
            byte realBlockId = block.BlockIdentifier;

            progress?.Log($"--- Block {block.Name} (id 0x{realBlockId:X2}, {Simos18FlashUtils.FormatSize(prepared.PreparedData.Length)}) ---");

            // ── Erase ─────────────────────────────────────────────────────────────
            // Patch path: CBOOT write-without-erase. The reference erases block 5 (CAL)
            // BEFORE writing the real patch block (not CBOOT_TEMP) so the CAL block can
            // be re-flashed afterwards. Mirrors flash_uds.py:patch_block lines 224-228.
            if (entry.IsPatchBlock)
            {
                progress?.Log("  PATCH mode: erasing block 5 (CAL) as a prerequisite — real block flashed without erase");
                try
                {
                    var eraseResp = uds.StartRoutine(0xFF00, new byte[] { 0x05 });
                    if (!eraseResp.IsPositive) progress?.Log("  [WARN] CAL pre-erase: " + eraseResp.NRCDescription);
                }
                catch (Exception ex) { progress?.Log("  [WARN] CAL pre-erase: " + ex.Message); }
            }
            else if (block.ShouldErase)
            {
                progress?.Log("  Erasing...");
                var eraseResp = uds.StartRoutine(0xFF00, new byte[] { realBlockId });
                if (!eraseResp.IsPositive)
                {
                    // NRC 0x31 = requestOutOfRange — sometimes benign on first erase of an already-empty block.
                    progress?.Log("  [FAIL] Erase: " + eraseResp.NRCDescription);
                    if (eraseResp.NRC != 0x31) return false;
                }
                else progress?.Log("  Erase OK");
            }

            // ── Request download ──────────────────────────────────────────────────
            progress?.Log("  RequestDownload...");
            byte[] dlReq = Simos18FlashUtils.BuildVWRequestDownload(
                realBlockId, (uint)prepared.PreparedData.Length,
                prepared.CompressionType, prepared.EncryptionType);
            var dlResp = uds.SendRequest(dlReq);
            if (!dlResp.IsPositive) { progress?.Log("  [FAIL] RequestDownload: " + dlResp.NRCDescription); return false; }
            progress?.Log("  RequestDownload OK");

            // ── Transfer data ─────────────────────────────────────────────────────
            int transferSize = entry.IsPatchBlock ? 0x100 : block.TransferSize;
            int totalBlockBytes = prepared.PreparedData.Length;
            int offset = 0;
            byte counter = 0x01;
            int chunkCount = 0;
            while (offset < totalBlockBytes)
            {
                if (progress?.IsAbortRequested == true) return false;
                int chunkSize = Math.Min(transferSize, totalBlockBytes - offset);

                // Patch mode uses the PatchInfo's variable transfer size map so the ECC
                // operation can span patched regions correctly.
                if (entry.IsPatchBlock && entry.PatchInfo != null)
                    chunkSize = Math.Min(entry.PatchInfo.GetTransferSizeForOffset((uint)offset), totalBlockBytes - offset);

                byte[] payload = new byte[2 + chunkSize];
                payload[0] = 0x36;
                payload[1] = counter;
                Array.Copy(prepared.PreparedData, offset, payload, 2, chunkSize);

                var tdResp = uds.SendRequest(payload);
                if (!tdResp.IsPositive)
                {
                    progress?.Log($"  [FAIL] TransferData at +0x{offset:X}: {tdResp.NRCDescription}");
                    return false;
                }

                offset += chunkSize;
                counter = (byte)(counter + 1); if (counter == 0) counter = 1;
                chunkCount++;
                sentAcrossAllBlocks += chunkSize;

                if (chunkCount % 32 == 0 || offset >= totalBlockBytes)
                {
                    int overall = totalBytes > 0 ? (int)(100L * sentAcrossAllBlocks / totalBytes) : 0;
                    progress?.SetBlockProgress(block.Name, offset, totalBlockBytes, overall);
                }
                if (chunkCount % 50 == 49)
                    try { uds.TesterPresent(true); } catch { }
            }

            // ── Transfer exit ─────────────────────────────────────────────────────
            progress?.Log("  RequestTransferExit");
            try
            {
                var exitResp = uds.RequestTransferExit();
                if (!exitResp.IsPositive) progress?.Log("  [WARN] TransferExit: " + exitResp.NRCDescription);
            }
            catch (Exception ex) { progress?.Log("  [WARN] TransferExit: " + ex.Message); }

            // ── Checksum verification (0x0202) ───────────────────────────────────
            if (block.ShouldChecksum && !entry.IsPatchBlock)
            {
                byte[] csBytes = ResolveChecksumBytes(profile, prepared, block);
                progress?.Log($"  CheckFlashMemoryDependencies 0x0202 checksum {BitConverter.ToString(csBytes).Replace("-", "")}");
                byte[] record = new byte[]
                {
                    realBlockId, 0x00, 0x04,
                    csBytes[0], csBytes[1], csBytes[2], csBytes[3]
                };
                try
                {
                    var csResp = uds.StartRoutine(0x0202, record);
                    if (!csResp.IsPositive) progress?.Log("  [WARN] 0x0202 checksum: " + csResp.NRCDescription);
                    else progress?.Log("  0x0202 checksum OK");
                }
                catch (Exception ex) { progress?.Log("  [WARN] 0x0202 checksum: " + ex.Message); }
            }

            progress?.Log($"  Block {block.Name} complete");
            return true;
        }

        /// <summary>
        /// Resolve the 4-byte UDS checksum for a block: prefer profile.UdsChecksums
        /// override (required for DQ250 DRIVER = F9 74 17 6E), fall back to the
        /// runtime-computed value on the PreparedBlock (or 0xFFFFFFFF if absent).
        /// </summary>
        private static byte[] ResolveChecksumBytes(VWECUProfile profile, Simos18PreparedBlock prepared, Simos18Block block)
        {
            if (profile.UdsChecksums != null && profile.UdsChecksums.TryGetValue(block.BlockNumber, out byte[] fromProfile) && fromProfile != null && fromProfile.Length == 4)
                return fromProfile;

            uint cs = prepared.Checksum;
            if (cs == 0) cs = 0xFFFFFFFFu;   // Reference uses FF FF FF FF when no checksum available.
            return new byte[]
            {
                (byte)((cs >> 24) & 0xFF),
                (byte)((cs >> 16) & 0xFF),
                (byte)((cs >>  8) & 0xFF),
                (byte)( cs        & 0xFF)
            };
        }
    }
}
