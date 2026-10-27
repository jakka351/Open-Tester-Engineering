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
//  Tester Present Specialist Automotive Solutions — Diagnostic Snapshot (module input)
//
//  The read-only observation bundle every diagnostic module receives.  It is
//  pure data: captured signal time-series (keyed by canonical name), DTCs,
//  discovered modules (topology), and vehicle identity.  Modules never call
//  J2534 or the UDS stack directly — the host captures data via the existing
//  OBDonUDSManager / UDSManager / topology scan and hands it here.  That keeps
//  every module unit-testable against synthetic signals with known ground truth.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;

namespace TesterPresent.OBD2.Intelligence
{
    /// <summary>A single timestamped scalar sample.</summary>
    public struct TimedValue
    {
        public DateTime Utc;
        public double Value;
        public TimedValue(DateTime utc, double value) { Utc = utc; Value = value; }
    }

    /// <summary>
    /// A time-series of one signal (RPM, LTFT B1, battery voltage, a vendor DID…).
    /// Carries running min/max/mean via a Welford accumulator so a module can ask
    /// for summary stats without re-scanning the samples.
    /// </summary>
    public sealed class SignalSeries
    {
        public string Name { get; }
        public string Unit { get; set; }
        private readonly List<TimedValue> _samples = new List<TimedValue>();
        private WelfordAccumulator _acc;

        public SignalSeries(string name, string unit = "")
        {
            Name = name ?? "";
            Unit = unit ?? "";
        }

        public IReadOnlyList<TimedValue> Samples => _samples;
        public int Count => _samples.Count;
        public double Mean => _acc.Mean;
        public double StdDev => _acc.StdDev;
        public double Min => _acc.Count > 0 ? _acc.Min : 0;
        public double Max => _acc.Count > 0 ? _acc.Max : 0;

        public bool HasData => _samples.Count > 0;
        public double Latest => _samples.Count > 0 ? _samples[_samples.Count - 1].Value : 0;
        public DateTime LatestUtc => _samples.Count > 0 ? _samples[_samples.Count - 1].Utc : DateTime.MinValue;

        public void Add(DateTime utc, double value)
        {
            _samples.Add(new TimedValue(utc, value));
            _acc.Add(value);
        }

        public void Add(double value) => Add(DateTime.UtcNow, value);

        /// <summary>Just the values, in capture order.</summary>
        public IReadOnlyList<double> Values() => _samples.Select(s => s.Value).ToList();

        /// <summary>Values captured within the last <paramref name="seconds"/> of the series.</summary>
        public IReadOnlyList<double> WindowSeconds(double seconds)
        {
            if (_samples.Count == 0) return Array.Empty<double>();
            DateTime cut = _samples[_samples.Count - 1].Utc.AddSeconds(-seconds);
            return _samples.Where(s => s.Utc >= cut).Select(s => s.Value).ToList();
        }

        /// <summary>Estimated sample rate (Hz) from the first/last timestamps.</summary>
        public double EstimatedHz
        {
            get
            {
                if (_samples.Count < 2) return 0;
                double span = (_samples[_samples.Count - 1].Utc - _samples[0].Utc).TotalSeconds;
                return span > 1e-6 ? (_samples.Count - 1) / span : 0;
            }
        }
    }

    /// <summary>A DTC captured from a module, with decoded status bits.</summary>
    public sealed class DiagnosticDtc
    {
        public string Code { get; set; }            // "P0171", "U0100"
        public byte StatusByte { get; set; }
        public string Description { get; set; }
        public uint ModuleTxId { get; set; }         // which module reported it
        public string ModuleName { get; set; }

        public bool Confirmed => (StatusByte & 0x08) != 0;
        public bool Pending => (StatusByte & 0x04) != 0;
        public bool TestFailed => (StatusByte & 0x01) != 0;

        /// <summary>SAE J2012 family letter: P / C / B / U.</summary>
        public char Family => (Code != null && Code.Length > 0) ? char.ToUpperInvariant(Code[0]) : '?';
        public bool IsNetworkCode => Family == 'U';
    }

    /// <summary>A discovered ECU node — the vertices of the platform topology.</summary>
    public sealed class ModuleNode
    {
        public uint TxId { get; set; }
        public uint RxId { get; set; }
        public string Name { get; set; }
        public VehicleBus Bus { get; set; }
        public bool Present { get; set; }
        public int DtcCount { get; set; }
        public bool IsGateway { get; set; }

        public override string ToString() =>
            $"{Name} (0x{TxId:X3}{(Bus != VehicleBus.Unknown ? ", " + Bus : "")})";
    }

    /// <summary>Coarse physical-layer state of a CAN segment from a bus-health check.</summary>
    public enum BusHealthState { Unknown, Healthy, Degraded, Dead }

    /// <summary>
    /// Physical-layer facts about one vehicle bus: how many terminators it should carry
    /// (a standard dual-terminated CAN pair reads ~60 Ω), any measured resistance a DVOM
    /// supplied, and a coarse health verdict from a bus-health burst.  M3 uses this to
    /// distinguish a genuinely dead/degraded segment (which supports a shared-bus fault)
    /// from a healthy bus (which points back at the individual modules).
    /// </summary>
    public sealed class BusHealth
    {
        public VehicleBus Bus { get; set; }
        /// <summary>Terminators the segment should carry (2 ⇒ ~60 Ω across CAN-H/CAN-L).</summary>
        public int ExpectedTerminators { get; set; } = 2;
        /// <summary>Measured CAN-H/CAN-L resistance in ohms, if a DVOM/health check supplied it.</summary>
        public double? MeasuredResistanceOhms { get; set; }
        public BusHealthState State { get; set; } = BusHealthState.Unknown;
        /// <summary>Human one-line verdict from a bus-health check, if run.</summary>
        public string Verdict { get; set; }
        /// <summary>Probable physical fault mode (e.g. open, short, missing terminator), if diagnosed.</summary>
        public string ProbableFaultMode { get; set; }
    }

    /// <summary>
    /// Immutable-by-convention observation bundle passed to every module's
    /// Analyze().  Build it with the fluent AddPidReadings / AddSignal helpers,
    /// then hand it to the module.  Signals are keyed by canonical name — use the
    /// <see cref="CanonicalSignals"/> constants so modules and capture agree.
    /// </summary>
    public sealed class DiagnosticSnapshot
    {
        public DateTime CapturedUtc { get; set; } = DateTime.UtcNow;
        public OEMManufacturer Oem { get; set; } = OEMManufacturer.Generic;
        /// <summary>Platform key for fleet/calibration lookup, e.g. "FordFG", "Generic".</summary>
        public string Platform { get; set; } = "Generic";
        public string Vin { get; set; } = "";
        /// <summary>Model year decoded from the VIN (0 if unknown) — lets OemDialect pick
        /// the Ford CGDS vs UDS era and keys the platform/calibration lookup.</summary>
        public int ModelYear { get; set; }
        /// <summary>Technician-selected vehicle model (e.g. "Falcon FG", "Ranger PX") —
        /// the identity that keys the per-vehicle topology / calibration tables.</summary>
        public string VehicleModel { get; set; } = "";
        /// <summary>Technician-selected engine family (e.g. "Barra 4.0 I6") — refines the
        /// calibration/geometry beyond the OEM bucket.</summary>
        public string VehicleEngine { get; set; } = "";
        public int CylinderCount { get; set; } = 4;
        /// <summary>The bus the active diagnostic channel is on (for M3 sanity checks).</summary>
        public VehicleBus ActiveBus { get; set; } = VehicleBus.Unknown;

        /// <summary>How the engine meters intake air.  Set by the technician (or
        /// auto-detected from the PIDs that answered).  Modules that compare a
        /// measured MAF against a speed-density prediction MUST honour this — a
        /// speed-density engine has no MAF to compare.</summary>
        public AirMeteringKind AirMetering { get; set; } = AirMeteringKind.AutoDetect;

        /// <summary>True if this engine has a mass-airflow sensor whose reading can be
        /// treated as a measured truth.  Under AutoDetect, decided by whether the MAF
        /// signal actually carries non-degenerate data.</summary>
        public bool HasMaf
        {
            get
            {
                switch (AirMetering)
                {
                    case AirMeteringKind.MafOnly:
                    case AirMeteringKind.MafAndMap:
                        return true;
                    case AirMeteringKind.SpeedDensityMap:
                    case AirMeteringKind.Tmap:
                        return false;
                    default: // AutoDetect
                        return MafLooksReal();
                }
            }
        }

        /// <summary>True if this engine exposes a manifold-absolute-pressure signal
        /// (a discrete MAP or the MAP half of a TMAP).</summary>
        public bool HasMap
        {
            get
            {
                switch (AirMetering)
                {
                    case AirMeteringKind.SpeedDensityMap:
                    case AirMeteringKind.MafAndMap:
                    case AirMeteringKind.Tmap:
                        return true;
                    case AirMeteringKind.MafOnly:
                        return false;
                    default: // AutoDetect
                        return Has(CanonicalSignals.Map);
                }
            }
        }

        /// <summary>Heuristic for AutoDetect: the MAF series exists AND carries
        /// non-degenerate data (some samples above a tiny floor).  A speed-density
        /// ECU that NRCs the MAF PID leaves no data, so this reads false; one that
        /// reports a flat ~0 also reads false rather than being trusted as a sensor.</summary>
        private bool MafLooksReal()
        {
            SignalSeries s;
            if (!_signals.TryGetValue(CanonicalSignals.Maf, out s) || s == null || !s.HasData) return false;
            // Any sample above 0.2 g/s means a real airflow reading was seen.
            return s.Max > 0.2;
        }

        private readonly Dictionary<string, SignalSeries> _signals =
            new Dictionary<string, SignalSeries>(StringComparer.OrdinalIgnoreCase);
        private readonly List<DiagnosticDtc> _dtcs = new List<DiagnosticDtc>();
        private readonly List<ModuleNode> _modules = new List<ModuleNode>();
        private readonly List<BusHealth> _busHealth = new List<BusHealth>();

        public IReadOnlyDictionary<string, SignalSeries> Signals => _signals;
        public IReadOnlyList<DiagnosticDtc> Dtcs => _dtcs;
        public IReadOnlyList<ModuleNode> Modules => _modules;
        /// <summary>Per-bus physical-layer health (terminator expectation + any measured
        /// verdict), used by M3 to firm up or soften a shared-bus localization.</summary>
        public IReadOnlyList<BusHealth> BusHealth => _busHealth;

        // ── Signal access ──────────────────────────────────────────────────
        public SignalSeries GetOrCreate(string name, string unit = "")
        {
            SignalSeries s;
            if (!_signals.TryGetValue(name, out s))
            {
                s = new SignalSeries(name, unit);
                _signals[name] = s;
            }
            return s;
        }

        public bool TryGetSeries(string name, out SignalSeries series) => _signals.TryGetValue(name, out series);
        public bool Has(string name) => _signals.ContainsKey(name) && _signals[name].HasData;
        public SignalSeries Series(string name) { SignalSeries s; return _signals.TryGetValue(name, out s) ? s : null; }

        /// <summary>Latest value of a named signal, or <paramref name="fallback"/> if absent.</summary>
        public double Latest(string name, double fallback = double.NaN)
        {
            SignalSeries s;
            return (_signals.TryGetValue(name, out s) && s.HasData) ? s.Latest : fallback;
        }

        public DiagnosticSnapshot AddSignal(string name, double value, DateTime utc, string unit = "")
        {
            GetOrCreate(name, unit).Add(utc, value);
            return this;
        }

        public DiagnosticSnapshot AddSignal(string name, double value, string unit = "")
            => AddSignal(name, value, DateTime.UtcNow, unit);

        /// <summary>
        /// Ingest a batch of live PidReadings, mapping each standard Mode-01 PID
        /// to its canonical signal name.  Non-standard PIDs are keyed by their
        /// definition ShortName so vendor DIDs still land as named series.
        /// </summary>
        public DiagnosticSnapshot AddPidReadings(IEnumerable<PidReading> readings)
        {
            if (readings == null) return this;
            foreach (var r in readings)
            {
                if (r == null || r.Definition == null) continue;
                string canon = CanonicalSignals.FromPid(r.Definition);
                GetOrCreate(canon, r.Definition.Unit).Add(r.Timestamp == default(DateTime) ? DateTime.UtcNow : r.Timestamp, r.Value);
            }
            return this;
        }

        // ── DTCs & topology ────────────────────────────────────────────────
        public DiagnosticSnapshot AddDtc(DiagnosticDtc dtc) { if (dtc != null) _dtcs.Add(dtc); return this; }
        public DiagnosticSnapshot AddModule(ModuleNode node) { if (node != null) _modules.Add(node); return this; }

        /// <summary>Record (or merge) per-bus physical-layer health.  A second entry for a
        /// bus already present is merged into the first (measured data wins over defaults).</summary>
        public DiagnosticSnapshot AddBusHealth(BusHealth bh)
        {
            if (bh == null) return this;
            foreach (var existing in _busHealth)
            {
                if (existing.Bus != bh.Bus) continue;
                if (bh.MeasuredResistanceOhms.HasValue) existing.MeasuredResistanceOhms = bh.MeasuredResistanceOhms;
                if (bh.State != BusHealthState.Unknown) existing.State = bh.State;
                if (!string.IsNullOrEmpty(bh.Verdict)) existing.Verdict = bh.Verdict;
                if (!string.IsNullOrEmpty(bh.ProbableFaultMode)) existing.ProbableFaultMode = bh.ProbableFaultMode;
                if (bh.ExpectedTerminators > 0) existing.ExpectedTerminators = bh.ExpectedTerminators;
                return this;
            }
            _busHealth.Add(bh);
            return this;
        }

        /// <summary>Per-bus health for a bus, or null if none recorded.</summary>
        public BusHealth BusHealthFor(VehicleBus bus)
        {
            foreach (var b in _busHealth) if (b.Bus == bus) return b;
            return null;
        }

        public IEnumerable<DiagnosticDtc> NetworkDtcs => _dtcs.Where(d => d.IsNetworkCode);
    }

    /// <summary>
    /// Canonical signal-name constants + the PID→name map.  Modules reference
    /// signals by these names; capture code populates them via the same map, so
    /// the two never drift apart.
    /// </summary>
    public static class CanonicalSignals
    {
        public const string Rpm = "RPM";
        public const string EngineLoad = "EngineLoad";
        public const string AbsoluteLoad = "AbsoluteLoad";
        public const string Coolant = "ECT";
        public const string IntakeAirTemp = "IAT";
        public const string AmbientAirTemp = "AAT";
        public const string OilTemp = "OilTemp";
        public const string Map = "MAP";
        public const string Maf = "MAF";
        public const string Baro = "BARO";
        public const string ThrottlePos = "TPS";
        public const string VehicleSpeed = "VSS";
        public const string TimingAdvance = "SparkAdv";
        public const string StftB1 = "STFT_B1";
        public const string LtftB1 = "LTFT_B1";
        public const string StftB2 = "STFT_B2";
        public const string LtftB2 = "LTFT_B2";
        public const string FuelPressure = "FuelPres";
        public const string FuelRailPressure = "FuelRailPres";           // PID 0x22 — relative to manifold vacuum
        public const string FuelRailGaugePressure = "FuelRailGaugePres";  // PID 0x23 — gauge/absolute (diesel/GDI), a different quantity
        public const string BatteryVoltage = "Vbatt";
        public const string CommandedEquivRatio = "EqRatio";
        public const string O2B1S1 = "O2_B1S1";
        public const string O2B2S1 = "O2_B2S1";
        public const string EngineRunTime = "RunTime";

        private static readonly Dictionary<byte, string> _mode01 = new Dictionary<byte, string>
        {
            { 0x04, EngineLoad }, { 0x05, Coolant },
            { 0x06, StftB1 },     { 0x07, LtftB1 }, { 0x08, StftB2 }, { 0x09, LtftB2 },
            { 0x0A, FuelPressure }, { 0x0B, Map },  { 0x0C, Rpm },    { 0x0D, VehicleSpeed },
            { 0x0E, TimingAdvance }, { 0x0F, IntakeAirTemp }, { 0x10, Maf }, { 0x11, ThrottlePos },
            { 0x14, O2B1S1 }, { 0x18, O2B2S1 },
            { 0x1F, EngineRunTime }, { 0x22, FuelRailPressure }, { 0x23, FuelRailGaugePressure },
            { 0x33, Baro }, { 0x42, BatteryVoltage }, { 0x43, AbsoluteLoad },
            { 0x44, CommandedEquivRatio }, { 0x46, AmbientAirTemp }, { 0x5C, OilTemp },
        };

        /// <summary>Canonical name for a PID definition; falls back to its ShortName/PidHex.</summary>
        public static string FromPid(OBD2Pid pid)
        {
            if (pid == null) return "?";
            string name;
            if (pid.Mode == 0x01 && _mode01.TryGetValue(pid.PID, out name)) return name;
            if (!string.IsNullOrEmpty(pid.ShortName)) return pid.ShortName;
            return $"PID_{pid.Mode:X2}_{pid.PID:X2}";
        }
    }
}
