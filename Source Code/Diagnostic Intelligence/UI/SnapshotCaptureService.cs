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
//  Tester Present Specialist Automotive Solutions — Diagnostic Snapshot Capture Service
//
//  Turns a CaptureProfile into a DiagnosticSnapshot the engine can analyze.  It
//  is the ONE place that reads the vehicle for the intelligence layer: it polls
//  the profile's curated PID set, reads stored DTCs, and (for the network-scan
//  profile) pings the HS-CAN modules and records who answered and their DTCs.
//
//  SAFETY: the module ping only probes modules reachable on the OBD HS-CAN
//  channel and rebinds the J2534 flow-control filter per address.  It never
//  probes typical MS-CAN comfort modules — per CLAUDE.md, probing an MS-CAN ID
//  from the HS-CAN channel escalates the controller to BUS-OFF after ~10 TX
//  failures.  The only requests it sends are TesterPresent (0x3E) and ReadDTC
//  (0x19) — both read-only and always safe.
//
//  Runs on the CALLER's thread (the dialog calls it on a background thread) and
//  honours a cancel delegate so the user can abort a long capture.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using J2534;
using TesterPresent.OBD2.Controls;
using TesterPresent.OBD2.UDS;

namespace TesterPresent.OBD2.Intelligence.UI
{
    /// <summary>Captures a <see cref="DiagnosticSnapshot"/> for a given <see cref="CaptureProfile"/>.</summary>
    public sealed class SnapshotCaptureService
    {
        private readonly J2534Manager _j2534;
        private readonly UDSManager _uds;
        private readonly OBDonUDSManager _obd;

        public event Action<string> OnProgress;

        public SnapshotCaptureService(J2534Manager j2534, UDSManager uds, OBDonUDSManager obd)
        {
            _j2534 = j2534;
            _uds = uds;
            _obd = obd;
        }

        // Conservative HS-CAN module shortlist (11-bit request / response).  These
        // are the modules commonly present on the OBD HS-CAN backbone; MS-CAN
        // comfort modules are deliberately excluded to avoid a BUS-OFF from
        // probing the wrong bus. TesterPresent to any of these is read-only/safe.
        private static readonly (uint tx, uint rx, string name)[] HsCanModules =
        {
            (0x7E0, 0x7E8, "PCM (Engine)"),
            (0x7E1, 0x7E9, "TCM (Transmission)"),
            (0x7E2, 0x7EA, "PCM #2"),
            (0x760, 0x768, "ABS / Brakes"),
            (0x730, 0x738, "Power Steering"),
            (0x737, 0x73F, "RCM (Restraints)"),
            (0x706, 0x70E, "Parking Aid"),
            (0x764, 0x76C, "Ride Control"),
        };

        private void Progress(string msg) { try { OnProgress?.Invoke(msg); } catch { } }

        /// <summary>Capture a snapshot per the profile. Never throws; returns what it
        /// managed to gather even on partial failure.</summary>
        /// <param name="liveScanNodes">When supplied (the CAN Topographer's discovered-ECU
        /// list from a real scan), the snapshot's topology + per-module DTCs come from that
        /// live map instead of the built-in fallback probe — real bus membership, real
        /// gateways, real per-module DTCs for every OEM.</param>
        /// <param name="vehicleModel">Technician-selected model (identity for calibration/topology).</param>
        /// <param name="vehicleEngine">Technician-selected engine family.</param>
        public DiagnosticSnapshot Capture(CaptureProfile profile, int cylinderCount, string vin,
                                          AirMeteringKind airMetering, Func<bool> isCancelled,
                                          IReadOnlyList<NetworkTopologyPanel.TopoNode> liveScanNodes = null,
                                          string vehicleModel = null, string vehicleEngine = null)
        {
            var snap = new DiagnosticSnapshot
            {
                CapturedUtc = DateTime.UtcNow,
                CylinderCount = cylinderCount < 1 ? 4 : cylinderCount,
                Vin = vin ?? "",
                AirMetering = airMetering,
                VehicleModel = vehicleModel ?? "",
                VehicleEngine = vehicleEngine ?? "",
            };

            // ── Vehicle identity: OEM bucket + model year from the VIN ──
            if (!string.IsNullOrEmpty(snap.Vin))
            {
                try { snap.Oem = OEMDTCDatabase.FromVIN(snap.Vin); } catch { }
                try
                {
                    var decoded = VINDecoder.Decode(snap.Vin);
                    if (decoded != null && decoded.ModelYear > 0) snap.ModelYear = decoded.ModelYear;
                }
                catch { }
            }
            snap.Platform = ResolvePlatform(snap);

            if (profile == null) return snap;

            // ── Topology: reuse the CAN Topographer's live map when a scan has run ──
            bool haveLiveTopo = liveScanNodes != null && liveScanNodes.Count > 0;
            if (haveLiveTopo)
            {
                try
                {
                    int m = TopologyBridge.Apply(snap, liveScanNodes);
                    Progress($"Using CAN Topographer map — {m} module(s), {snap.Dtcs.Count} DTC(s) from the last scan.");
                }
                catch (Exception ex) { Progress("Topology import error: " + ex.Message); haveLiveTopo = false; }
            }

            try
            {
                if (profile.Kind == CaptureKind.NetworkScan)
                {
                    // The Topographer's live map already IS the network scan — only fall
                    // back to the built-in probe when no scan has been run.
                    if (!haveLiveTopo) RunNetworkScan(snap, isCancelled);
                }
                else
                {
                    RunLiveWindow(snap, profile, isCancelled, haveLiveTopo);
                }
            }
            catch (Exception ex)
            {
                Progress("Capture error: " + ex.Message);
            }

            return snap;
        }

        /// <summary>Resolve the platform key from the vehicle identity.  Ford AU Falcon WMIs
        /// map to the FordFG calibration; a technician-supplied model refines the key so a
        /// DB-backed calibration can match a specific platform; else the OEM bucket.</summary>
        private static string ResolvePlatform(DiagnosticSnapshot snap)
        {
            if (FordFgCalibration.Matches(snap.Oem, snap.Vin)) return "FordFG";
            if (!string.IsNullOrWhiteSpace(snap.VehicleModel))
                return (snap.Oem != OEMManufacturer.Generic ? snap.Oem + ":" : "") + snap.VehicleModel.Trim();
            return snap.Oem != OEMManufacturer.Generic ? snap.Oem.ToString() : "Generic";
        }

        /// <summary>Resolve a DTC's human description through the general OEM database.</summary>
        private static string Describe(DiagnosticSnapshot snap, string code)
            => TopologyBridge.DescribeDtc(code, snap != null ? snap.Oem : OEMManufacturer.Generic);

        // ── Live-data window (idle / drive / crank / full) ──────────────────────
        private void RunLiveWindow(DiagnosticSnapshot snap, CaptureProfile profile, Func<bool> isCancelled,
                                   bool haveLiveTopo = false)
        {
            var pidDefs = OBD2PidDatabase.Mode01Pids
                .Where(p => profile.Pids != null && profile.Pids.Contains(p.PID))
                .ToList();

            // OEM Mode-22 extended PIDs that FILL a canonical-signal gap generic Mode-01
            // does not cover on this OEM (oil temp / rail pressure via $22) or that feed a
            // module with no Mode-01 equivalent (a knock channel for T6).  Only curated PIDs
            // with real scaling are polled — never unscaled auto-labels (which would look
            // populated but be wrong and never reach the engine's canonical signals).
            var oemExtended = ResolveOemExtendedPids(snap, profile);
            CustomPidManager customMgr = oemExtended.Count > 0 ? new CustomPidManager() : null;
            uint pcmTx = _uds != null ? _uds.TxID : 0x7E0;
            if (oemExtended.Count > 0)
                Progress($"  + {oemExtended.Count} OEM extended PID(s) for {snap.Oem}: "
                         + string.Join(", ", oemExtended.Select(x => x.canon)));

            Progress($"Capturing {profile.Name} — {profile.DurationSeconds}s over {pidDefs.Count} PIDs…");

            var sw = Stopwatch.StartNew();
            int cycles = 0;
            while (!(isCancelled?.Invoke() ?? false) && sw.Elapsed.TotalSeconds < profile.DurationSeconds)
            {
                var batch = new List<PidReading>();
                foreach (var pid in pidDefs)
                {
                    if (isCancelled?.Invoke() ?? false) break;
                    PidReading r = null;
                    try { r = _obd?.ReadPid(pid); } catch { }
                    if (r != null && r.Definition != null) batch.Add(r);
                }
                if (batch.Count > 0) snap.AddPidReadings(batch);

                // OEM extended ($22) polls — decoded with the curated formula, stored under
                // the canonical signal name so the modules consume them like any other signal.
                if (customMgr != null && !(isCancelled?.Invoke() ?? false))
                {
                    foreach (var ext in oemExtended)
                    {
                        try
                        {
                            var rr = customMgr.ReadCustomPid(ext.pid, _j2534, _uds, pcmTx);
                            if (rr != null && !double.IsNaN(rr.Value) && !double.IsInfinity(rr.Value))
                                snap.AddSignal(ext.canon, rr.Value, DateTime.UtcNow, ext.pid.Unit ?? "");
                        }
                        catch { }
                    }
                }

                cycles++;
                if ((cycles % 5) == 0)
                    Progress($"  {sw.Elapsed.TotalSeconds:0}s — {snap.Signals.Count} signals, {cycles} cycles");
                Thread.Sleep(10);
            }
            Progress($"Captured {cycles} cycle(s), {snap.Signals.Count} signal(s).");

            // Stored DTCs from the current ECU help M6 (and are cheap).  Skip when the
            // Topographer already supplied every module's DTCs — avoid duplicates.
            if (!haveLiveTopo) ReadDtcsFromCurrent(snap);
        }

        // ── OEM extended (Mode-22) signal resolution ────────────────────────────

        /// <summary>
        /// Resolve the curated OEM Mode-22 PIDs worth polling for this vehicle: those that
        /// map to a canonical signal generic Mode-01 does NOT already cover on this profile
        /// (oil temp, fuel-rail pressure) or that feed a module with no Mode-01 equivalent (a
        /// knock channel for T6).  Only PIDs with real scaling are returned — an unscaled
        /// auto-label would be plausible-but-wrong data that never reaches a canonical signal.
        /// </summary>
        private static List<(CustomPidDefinition pid, string canon)> ResolveOemExtendedPids(
            DiagnosticSnapshot snap, CaptureProfile profile)
        {
            var result = new List<(CustomPidDefinition, string)>();
            if (snap == null || snap.Oem == OEMManufacturer.Generic) return result;

            List<CustomPidDefinition> curated;
            try { curated = OEMPidDatabase.GetPids(snap.Oem); } catch { return result; }
            if (curated == null) return result;

            var takenCanon = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (var pid in curated)
            {
                if (pid == null || pid.PidType != CustomPidType.Mode22_UDS) continue;

                string canon = MapOemPidToCanonical(pid);
                if (canon == null) continue;
                if (!takenCanon.Add(canon)) continue; // first curated PID per canonical wins

                bool isKnock = canon.IndexOf("knock", StringComparison.OrdinalIgnoreCase) >= 0
                               || canon.IndexOf("KR", StringComparison.Ordinal) >= 0;

                // A non-knock canonical signal already covered by the profile's Mode-01 set
                // is left to Mode-01 (the standard, better-trusted source).
                if (!isKnock && ProfileCoversCanonicalViaMode01(profile, canon)) continue;

                // Non-knock signals must carry real scaling; a knock channel is accepted for
                // its dynamic content (T6 order-analyses the raw swing, not an absolute unit).
                bool realScale = pid.Formula != FormulaType.SingleByteUnsigned
                                 || Math.Abs(pid.Multiplier - 1.0) > 1e-9
                                 || !string.IsNullOrWhiteSpace(pid.ExpressionText);
                if (!isKnock && !realScale) continue;

                result.Add((pid, canon));
            }
            return result;
        }

        /// <summary>Map a curated OEM PID to a canonical signal name it should populate, or
        /// null if it does not correspond to one the modules consume.  Knock channels keep a
        /// name T6 discovers by (contains "knock"/"KR").</summary>
        private static string MapOemPidToCanonical(CustomPidDefinition pid)
        {
            string t = ((pid.Name ?? "") + " " + (pid.ShortName ?? "")).ToLowerInvariant();
            if (t.Contains("oil temp") || t.Contains("oiltemp") || (t.Contains("oil") && t.Contains("temp")))
                return CanonicalSignals.OilTemp;
            if (t.Contains("rail pressure") || t.Contains("fuel rail") || t.Contains("railpres"))
                return CanonicalSignals.FuelRailPressure;
            if (t.Contains("knock") || t.Contains("detonation"))
            {
                // Keep the OEM ShortName if it is already T6-discoverable; else give it one.
                string sn = pid.ShortName ?? "";
                if (sn.IndexOf("knock", StringComparison.OrdinalIgnoreCase) >= 0
                    || sn.IndexOf("KR", StringComparison.Ordinal) >= 0) return sn;
                return "KnockSensor";
            }
            return null;
        }

        /// <summary>True if the profile's Mode-01 PID set already covers a canonical signal,
        /// so the OEM $22 equivalent should not be polled (Mode-01 wins).</summary>
        private static bool ProfileCoversCanonicalViaMode01(CaptureProfile profile, string canon)
        {
            if (profile == null || profile.Pids == null) return false;
            if (canon == CanonicalSignals.OilTemp) return profile.Pids.Contains((byte)0x5C);
            if (canon == CanonicalSignals.FuelRailPressure)
                return profile.Pids.Contains((byte)0x22) || profile.Pids.Contains((byte)0x23);
            return false;
        }

        // ── Network scan: HS-CAN module ping + per-module DTCs ──────────────────
        private void RunNetworkScan(DiagnosticSnapshot snap, Func<bool> isCancelled)
        {
            snap.ActiveBus = VehicleBus.HsCan;

            uint savedTx = _uds != null ? _uds.TxID : 0x7E0;
            uint savedRx = _uds != null ? _uds.RxID : 0x7E8;
            try
            {
                Progress("Pinging HS-CAN modules…");
                foreach (var m in HsCanModules)
                {
                    if (isCancelled?.Invoke() ?? false) break;
                    if (_uds == null) break;

                    bool present = PingModule(m.tx, m.rx);
                    if (!present) { Progress($"  {m.name} (0x{m.tx:X3}) — no answer"); continue; }

                    var node = new ModuleNode
                    {
                        TxId = m.tx, RxId = m.rx, Name = m.name,
                        Bus = VehicleBus.HsCan, Present = true,
                        IsGateway = m.name.IndexOf("Gateway", StringComparison.OrdinalIgnoreCase) >= 0,
                    };

                    int dtcCount = ReadDtcsForModule(snap, m.tx, m.name);
                    node.DtcCount = dtcCount;
                    snap.AddModule(node);
                    Progress($"  {m.name} (0x{m.tx:X3}) — present, {dtcCount} DTC(s)");
                }
            }
            finally
            {
                // Restore the original target + hardware filter so the rest of the
                // session keeps talking to the ECU the user had selected.
                try { _j2534?.UpdateFilters(savedTx, savedRx); } catch { }
                if (_uds != null) { _uds.TxID = savedTx; _uds.RxID = savedRx; }
            }

            Progress($"Network scan complete — {snap.Modules.Count} module(s), {snap.Dtcs.Count} DTC(s).");
        }

        private bool PingModule(uint tx, uint rx)
        {
            try
            {
                _j2534?.UpdateFilters(tx, rx);
                _uds.TxID = tx;
                _uds.RxID = rx;
                // Standard UDS/OBD TesterPresent (3E 00) first.  If the module is silent to
                // it, fall back to the Ford CGDS sub-function (3E 01): pre-2011 Ford
                // (FG/BA/BF) KWP-on-CAN modules SILENT-DROP 3E 00 entirely (no answer, not
                // even an NRC — per CLAUDE.md), so a 3E-00-only ping records an empty
                // topology on exactly the platform this layer is calibrated for and starves
                // M3.  Any answer to either sub-function means the module is on the bus.
                if (ProbeResponds(new byte[] { 0x3E, 0x00 })) return true;
                if (ProbeResponds(new byte[] { 0x3E, 0x01 })) return true;
                return false;
            }
            catch { return false; }
        }

        /// <summary>Send a read-only probe and report whether the module answered at all
        /// (a positive response OR any negative NRC — both prove it is on the bus).</summary>
        private bool ProbeResponds(byte[] request)
        {
            var r = _uds.SendRequest(request);
            return r != null && (r.IsPositive || (r.RawResponse != null && r.RawResponse.Length > 0));
        }

        private int ReadDtcsForModule(DiagnosticSnapshot snap, uint tx, string moduleName)
        {
            try
            {
                var resp = _uds.ReadDTCInformation(DTCReportType.ReportDTCByStatusMask, 0xFF);
                if (resp != null && resp.IsPositive)
                {
                    var entries = _uds.ParseDTCList(resp);
                    if (entries != null)
                    {
                        foreach (var e in entries)
                        {
                            string code = NormalizeDtcCode(e.DTCCode);   // raw 0x… → P0171 so M6 can map it
                            snap.AddDtc(new DiagnosticDtc
                            {
                                Code = code, StatusByte = e.StatusMask,
                                Description = Describe(snap, code), ModuleTxId = tx, ModuleName = moduleName,
                            });
                        }
                        return entries.Count;
                    }
                    return 0;
                }
                // UDS ReadDTCInformation (0x19) got no positive answer — a Ford CGDS /
                // KWP-on-CAN module needs the KWP ReadDTCByStatus form (18 00 FF 00), not
                // the UDS 19 02, or it returns nothing.
                return ReadKwpDtcs(snap, tx, moduleName);
            }
            catch { return 0; }
        }

        private void ReadDtcsFromCurrent(DiagnosticSnapshot snap)
        {
            if (_uds == null) return;
            try
            {
                int n;
                var resp = _uds.ReadDTCInformation(DTCReportType.ReportDTCByStatusMask, 0xFF);
                if (resp != null && resp.IsPositive)
                {
                    var entries = _uds.ParseDTCList(resp);
                    if (entries == null) return;
                    foreach (var e in entries)
                    {
                        string code = NormalizeDtcCode(e.DTCCode);   // raw 0x… → P0171 so M6 can map it
                        snap.AddDtc(new DiagnosticDtc
                        {
                            Code = code, StatusByte = e.StatusMask,
                            Description = Describe(snap, code), ModuleTxId = _uds.TxID,
                        });
                    }
                    n = entries.Count;
                }
                else
                {
                    // CGDS / KWP-on-CAN fallback for the current ECU.
                    n = ReadKwpDtcs(snap, _uds.TxID, null);
                }
                Progress($"Read {n} DTC(s) from current ECU.");
            }
            catch { }
        }

        /// <summary>
        /// KWP-on-CAN ReadDTCByStatus fallback (Ford CGDS era): sends 18 00 FF 00 and parses
        /// the response shape 58 COUNT [DTC_hi DTC_mid status]×COUNT (3-byte records, NOT the
        /// UDS 4-byte form), decoding each code per SAE J2012.  Used only when the UDS 0x19
        /// read got no positive answer.
        /// </summary>
        private int ReadKwpDtcs(DiagnosticSnapshot snap, uint tx, string moduleName)
        {
            try
            {
                var r = _uds.SendRequest(new byte[] { 0x18, 0x00, 0xFF, 0x00 });
                if (r == null || r.RawResponse == null || r.RawResponse.Length < 2) return 0;
                byte[] d = r.RawResponse;
                if (d[0] != 0x58) return 0;   // not a positive ReadDTCByStatus response
                int count = d[1];
                int added = 0, p = 2;
                for (int i = 0; i < count && p + 3 <= d.Length; i++, p += 3)
                {
                    string code = DecodeJ2012Dtc(d[p], d[p + 1]);
                    snap.AddDtc(new DiagnosticDtc
                    {
                        Code = code, StatusByte = d[p + 2],
                        Description = Describe(snap, code), ModuleTxId = tx, ModuleName = moduleName,
                    });
                    added++;
                }
                return added;
            }
            catch { return 0; }
        }

        /// <summary>Decode a 2-byte SAE J2012 DTC (high 2 bits = family P/C/B/U, next 2 bits =
        /// leading digit 0–3, remaining 12 bits = the 3-hex-digit code).</summary>
        private static string DecodeJ2012Dtc(byte b0, byte b1)
        {
            char[] fam = { 'P', 'C', 'B', 'U' };
            int f = (b0 >> 6) & 0x03;
            int lead = (b0 >> 4) & 0x03;
            int code = ((b0 & 0x0F) << 8) | b1;
            return $"{fam[f]}{lead}{code:X3}";
        }

        /// <summary>Normalise a DTC code to J2012 P/C/B/U form. The UDS 0x19 path's ParseDTCList
        /// can hand back a RAW 3-byte hex string ("0x017100"); M6's fault mapper matches on the
        /// decoded form ("P0171"), so a raw code spawns NO hypothesis and the frontier stays empty
        /// on a car full of faults. Idempotent: an already-decoded "P0171" passes straight through
        /// (real-hardware ParseDTCList that already decodes is unaffected).</summary>
        private static string NormalizeDtcCode(string raw)
        {
            if (string.IsNullOrWhiteSpace(raw)) return raw;
            string s = raw.Trim();
            // Already a letter code (P/C/B/U + digits) and not the "0x…" raw form → leave as-is.
            if ("PCBU".IndexOf(char.ToUpperInvariant(s[0])) >= 0
                && !s.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
                return s.ToUpperInvariant();
            // Raw hex ("0xAABBCC" or "AABBCC") → decode the first two bytes per J2012.
            string hex = s.StartsWith("0x", StringComparison.OrdinalIgnoreCase) ? s.Substring(2) : s;
            if (hex.Length >= 4
                && uint.TryParse(hex.Substring(0, 4), System.Globalization.NumberStyles.HexNumber, null, out uint code2))
                return DecodeJ2012Dtc((byte)(code2 >> 8), (byte)(code2 & 0xFF));
            return s;
        }
    }
}
