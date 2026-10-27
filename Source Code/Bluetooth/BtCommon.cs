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
//  Tester Present Specialist Automotive Solutions — Bluetooth Diagnostic & Assessment Suite
//  BtCommon.cs — shared models, UUID resolution, WinRT await plumbing, hex/MAC utilities.
//
//  This is the foundation layer for the vehicle-Bluetooth suite described in the
//  "Direct Bluetooth Attack Surface of Vehicle Systems" assessment. Everything here is
//  transport-neutral: the discovery, SDP, GATT, RFCOMM, OBEX, pairing and fuzzing layers
//  all build on the models and helpers defined in this file.
//
//  DESIGN
//    • In-process WinRT only. No NuGet Bluetooth stack, no PowerShell shell-out. The csproj
//      already references Windows.Devices/Foundation/Storage winmd; the suite adds
//      Windows.Networking.winmd for the RFCOMM StreamSocket. This matches the proven
//      in-process pattern in BleTrackerDetector / BleScannerDialog.
//    • Every I/O method is async Task and awaits IAsyncOperation<T>.AsTask() with a timeout.
//      Callers on the UI thread use `await` (WinForms sync context) — never .Result/.Wait().
//
//  HONESTY DOCTRINE (load-bearing — do not soften)
//    • A standard host radio is an active PEER and an active SCANNER, never a promiscuous
//      sniffer. This suite observes only its own links and open advertising. It cannot
//      intercept a piconet between two other devices — that needs capture hardware and is
//      out of scope. Do not add UI that implies otherwise.
//    • PBAP/MAP pulls return THIRD-PARTY personal data. Every such record is tagged
//      Sensitive in the findings store, with provenance, so the operator can honour the
//      engagement's handling rules. See BtAssessment.
//    • The stack advisory (BtStackAdvisory) is a REFERENCE + reachability heuristic, not an
//      exploit. It never claims to have compromised anything.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Storage.Streams;

namespace TesterPresent.OBD2.Bluetooth
{
    // ════════════════════════════════════════════════════════════════════════════════════
    //  Transport / profile taxonomy
    // ════════════════════════════════════════════════════════════════════════════════════

    /// <summary>Which radio the endpoint lives on.</summary>
    public enum BtTransport { Unknown = 0, Classic, LowEnergy, DualMode }

    /// <summary>Well-known Bluetooth Classic profiles reachable as a peer, per the assessment.</summary>
    public enum BtProfile
    {
        Unknown = 0,
        SDP, SPP, HFP_AG, HFP_HF, HSP, A2DP_Source, A2DP_Sink, AVRCP, AVRCP_Target, AVRCP_Controller,
        PBAP_Client, PBAP_Server, MAP_Server, MAP_Notify, OPP, PAN_NAP, PAN_GN, PAN_User, DUN, HID, DID
    }

    /// <summary>Severity ranking for a finding in the assessment report.</summary>
    public enum BtSeverity { Info = 0, Low, Medium, High, Critical }

    // ════════════════════════════════════════════════════════════════════════════════════
    //  Unified endpoint model
    // ════════════════════════════════════════════════════════════════════════════════════

    /// <summary>
    /// One reachable Bluetooth endpoint — a head unit, a phone-as-key, an aftermarket sensor,
    /// or an unknown advertiser. Populated incrementally by discovery, SDP and GATT layers.
    /// </summary>
    public sealed class BtEndpoint
    {
        public ulong Address;                 // 48-bit BD_ADDR (0 if only a WinRT device Id is known)
        public string MacColons = "";         // AA:BB:CC:DD:EE:FF
        public string Name = "";              // friendly / advertised local name
        public BtTransport Transport = BtTransport.Unknown;
        public bool IsPaired;
        public bool CanPair;
        public int Rssi = 0;                   // last observed advertising RSSI (dBm), 0 if unknown
        public uint ClassOfDevice;             // Classic CoD (0 if unknown / LE)
        public string DeviceClassText = "";    // decoded major class
        public string WinRtDeviceId = "";      // Windows.Devices.Enumeration Id (for FromIdAsync / pairing)
        public bool LooksLikeVehicle;          // heuristic flag from name/class
        public string Vendor = "";             // OUI vendor guess, if resolvable
        public DateTime LastSeenUtc = DateTime.MinValue;

        // Advertising extras (LE)
        public ushort? Appearance;
        public sbyte? TxPower;
        public readonly List<Guid> AdvertisedServiceUuids = new List<Guid>();
        public readonly List<ushort> ManufacturerCompanyIds = new List<ushort>();

        // Discovery results (filled by SDP / GATT layers)
        public readonly List<SdpRecord> SdpRecords = new List<SdpRecord>();
        public readonly List<GattServiceNode> GattServices = new List<GattServiceNode>();

        public string Display => string.IsNullOrEmpty(Name) ? MacColons : Name + "  (" + MacColons + ")";
    }

    /// <summary>A single SDP service record discovered on a Classic device.</summary>
    public sealed class SdpRecord
    {
        public string ServiceName = "";
        public Guid ServiceClassUuid;
        public string ServiceClassName = "";  // resolved well-known name, or "" for custom
        public int RfcommChannel = -1;         // -1 if not RFCOMM-based
        public bool IsVendorSpecific;          // 128-bit / non-SIG UUID → the interesting ones
        public BtProfile Profile = BtProfile.Unknown;
        public string RawAttributesHex = "";   // best-effort raw SDP attribute dump
        public string WinRtServiceId = "";     // for RfcommDeviceService.FromIdAsync / connect

        public string ChannelText => RfcommChannel >= 0 ? RfcommChannel.ToString() : "-";
    }

    /// <summary>A GATT service node with its characteristics (LE).</summary>
    public sealed class GattServiceNode
    {
        public Guid Uuid;
        public string Name = "";               // resolved well-known name, or "" for custom
        public bool IsVendorSpecific;
        public ushort AttributeHandle;
        public readonly List<GattCharacteristicNode> Characteristics = new List<GattCharacteristicNode>();
    }

    /// <summary>A GATT characteristic with resolved properties and descriptor UUIDs.</summary>
    public sealed class GattCharacteristicNode
    {
        public Guid Uuid;
        public string Name = "";
        public bool IsVendorSpecific;
        public ushort AttributeHandle;
        public string Properties = "";         // "Read,Write,Notify,..."
        public bool CanRead, CanWrite, CanWriteNoResp, CanNotify, CanIndicate;
        public string LastValueHex = "";
        public string LastValueText = "";
        public readonly List<Guid> DescriptorUuids = new List<Guid>();
        public object WinRtCharacteristic;     // Windows.Devices.Bluetooth.GenericAttributeProfile.GattCharacteristic
    }

    // ════════════════════════════════════════════════════════════════════════════════════
    //  Findings
    // ════════════════════════════════════════════════════════════════════════════════════

    /// <summary>One assessment finding — the atomic unit of the report. Carries provenance.</summary>
    public sealed class BtFinding
    {
        public DateTime TimestampUtc = DateTime.UtcNow;
        public BtSeverity Severity = BtSeverity.Info;
        public string Category = "";           // "Recon", "SDP", "GATT", "Pairing", "Fuzzing", "Data", "Stack"
        public string Title = "";
        public string Detail = "";
        public string EndpointMac = "";        // provenance: which endpoint
        public string EndpointName = "";
        public string Profile = "";            // provenance: which profile / channel
        public bool IsSensitiveData;           // PBAP/MAP third-party PII → special handling
        public string EvidenceHex = "";        // raw bytes backing the finding, if any

        public string SeverityText => Severity.ToString().ToUpperInvariant();
    }

    // ════════════════════════════════════════════════════════════════════════════════════
    //  WinRT await plumbing
    // ════════════════════════════════════════════════════════════════════════════════════

    /// <summary>
    /// Helpers to await WinRT IAsyncOperation/IAsyncAction with a timeout, from .NET Framework.
    ///
    /// We deliberately DO NOT use the System.Runtime.WindowsRuntime `.AsTask()` extension: its
    /// overload set is declared against the async-interface family in the union "Windows" assembly
    /// (255.255.255.255), which is not referenced here and cannot be added without a type-forwarder
    /// cycle against the split platform winmds. Instead we bridge to a Task through the interfaces'
    /// own raw members (Completed handler + GetResults + Status), which resolve entirely from the
    /// referenced split winmds — no union assembly, no projection.
    /// </summary>
    internal static class WinRt
    {
        public const int DefaultTimeoutMs = 12000;

        /// <summary>Bridge an IAsyncOperation&lt;T&gt; to a Task&lt;T&gt; via its Completed handler.</summary>
        private static Task<T> ToTask<T>(IAsyncOperation<T> op)
        {
            var tcs = new TaskCompletionSource<T>();
            op.Completed = (o, status) =>
            {
                try
                {
                    if (status == AsyncStatus.Completed) tcs.TrySetResult(o.GetResults());
                    else if (status == AsyncStatus.Canceled) tcs.TrySetCanceled();
                    else tcs.TrySetException(new Exception("WinRT operation failed (status=" + status + ")."));
                }
                catch (Exception ex) { tcs.TrySetException(ex); }
            };
            return tcs.Task;
        }

        /// <summary>Bridge an IAsyncOperationWithProgress&lt;T,P&gt; to a Task&lt;T&gt;.</summary>
        private static Task<T> ToTask<T, P>(IAsyncOperationWithProgress<T, P> op)
        {
            var tcs = new TaskCompletionSource<T>();
            op.Completed = (o, status) =>
            {
                try
                {
                    if (status == AsyncStatus.Completed) tcs.TrySetResult(o.GetResults());
                    else if (status == AsyncStatus.Canceled) tcs.TrySetCanceled();
                    else tcs.TrySetException(new Exception("WinRT progress operation failed (status=" + status + ")."));
                }
                catch (Exception ex) { tcs.TrySetException(ex); }
            };
            return tcs.Task;
        }

        /// <summary>Bridge an IAsyncAction to a Task via its Completed handler.</summary>
        private static Task ToTask(IAsyncAction act)
        {
            var tcs = new TaskCompletionSource<bool>();
            act.Completed = (o, status) =>
            {
                if (status == AsyncStatus.Completed) tcs.TrySetResult(true);
                else if (status == AsyncStatus.Canceled) tcs.TrySetCanceled();
                else tcs.TrySetException(new Exception("WinRT action failed (status=" + status + ")."));
            };
            return tcs.Task;
        }

        // Each helper scopes the timeout's Task.Delay to a linked CTS and cancels it once the
        // operation wins, so the Delay's armed timer + the registration it appends to the caller's
        // (long-lived) token are released immediately instead of staying rooted for the full window.
        // Without this, a hot read loop with a large timeout (BtRfcomm's 1-hour reader) accumulates
        // one live timer per successful read for the life of the session.

        /// <summary>Await a WinRT operation with a timeout. Throws TimeoutException on expiry.</summary>
        public static async Task<T> Await<T>(IAsyncOperation<T> op, int timeoutMs = DefaultTimeoutMs, CancellationToken ct = default(CancellationToken))
        {
            var task = ToTask(op);
            using (var to = CancellationTokenSource.CreateLinkedTokenSource(ct))
            {
                var done = await Task.WhenAny(task, Task.Delay(timeoutMs, to.Token)).ConfigureAwait(false);
                if (done != task)
                {
                    try { op.Cancel(); } catch { }
                    throw new TimeoutException("WinRT operation timed out after " + timeoutMs + " ms.");
                }
                to.Cancel();
            }
            return await task.ConfigureAwait(false);
        }

        /// <summary>Await a WinRT operation-with-progress (e.g. IInputStream.ReadAsync) with a timeout.</summary>
        public static async Task<T> AwaitProgress<T, P>(IAsyncOperationWithProgress<T, P> op, int timeoutMs = DefaultTimeoutMs, CancellationToken ct = default(CancellationToken))
        {
            var task = ToTask(op);
            using (var to = CancellationTokenSource.CreateLinkedTokenSource(ct))
            {
                var done = await Task.WhenAny(task, Task.Delay(timeoutMs, to.Token)).ConfigureAwait(false);
                if (done != task)
                {
                    try { op.Cancel(); } catch { }
                    throw new TimeoutException("WinRT progress operation timed out after " + timeoutMs + " ms.");
                }
                to.Cancel();
            }
            return await task.ConfigureAwait(false);
        }

        /// <summary>Await a WinRT action with a timeout.</summary>
        public static async Task Await(IAsyncAction act, int timeoutMs = DefaultTimeoutMs, CancellationToken ct = default(CancellationToken))
        {
            var task = ToTask(act);
            using (var to = CancellationTokenSource.CreateLinkedTokenSource(ct))
            {
                var done = await Task.WhenAny(task, Task.Delay(timeoutMs, to.Token)).ConfigureAwait(false);
                if (done != task)
                {
                    try { act.Cancel(); } catch { }
                    throw new TimeoutException("WinRT action timed out after " + timeoutMs + " ms.");
                }
                to.Cancel();
            }
            await task.ConfigureAwait(false);
        }

        /// <summary>Read all bytes out of a WinRT IBuffer.</summary>
        public static byte[] ToBytes(IBuffer buf)
        {
            if (buf == null || buf.Length == 0) return Array.Empty<byte>();
            var arr = new byte[buf.Length];
            using (var dr = DataReader.FromBuffer(buf)) dr.ReadBytes(arr);
            return arr;
        }

        /// <summary>Wrap a byte array as a WinRT IBuffer for WriteValueAsync etc.</summary>
        public static IBuffer ToBuffer(byte[] bytes)
        {
            using (var dw = new DataWriter())
            {
                dw.WriteBytes(bytes ?? Array.Empty<byte>());
                return dw.DetachBuffer();
            }
        }
    }

    // ════════════════════════════════════════════════════════════════════════════════════
    //  Hex / MAC / UUID utilities
    // ════════════════════════════════════════════════════════════════════════════════════

    public static class BtUtil
    {
        public static string MacFromUlong(ulong addr)
        {
            var sb = new StringBuilder(17);
            for (int i = 5; i >= 0; i--)
            {
                if (sb.Length > 0) sb.Append(':');
                sb.Append(((byte)(addr >> (8 * i))).ToString("X2"));
            }
            return sb.ToString();
        }

        public static ulong UlongFromMac(string macColons)
        {
            if (string.IsNullOrEmpty(macColons)) return 0;
            string hex = macColons.Replace(":", "").Replace("-", "").Trim();
            if (hex.Length != 12) return 0;
            ulong v;
            return ulong.TryParse(hex, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out v) ? v : 0;
        }

        public static string ToHex(byte[] b, int offset = 0, int len = -1, bool spaced = false)
        {
            if (b == null || b.Length == 0) return "";
            if (len < 0) len = b.Length - offset;
            if (offset < 0 || offset >= b.Length) return "";
            if (offset + len > b.Length) len = b.Length - offset;
            var sb = new StringBuilder(len * (spaced ? 3 : 2));
            for (int i = 0; i < len; i++)
            {
                if (spaced && sb.Length > 0) sb.Append(' ');
                sb.Append(b[offset + i].ToString("X2"));
            }
            return sb.ToString();
        }

        public static byte[] FromHex(string hex)
        {
            if (string.IsNullOrEmpty(hex)) return Array.Empty<byte>();
            var clean = new StringBuilder(hex.Length);
            foreach (char c in hex)
                if (Uri.IsHexDigit(c)) clean.Append(c);
            string s = clean.ToString();
            if (s.Length % 2 != 0) s = s.Substring(0, s.Length - 1);
            var outb = new byte[s.Length / 2];
            for (int i = 0; i < outb.Length; i++)
                outb[i] = byte.Parse(s.Substring(i * 2, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            return outb;
        }

        /// <summary>Printable-ASCII rendering of bytes (non-printables shown as '.').</summary>
        public static string ToAscii(byte[] b, int offset = 0, int len = -1)
        {
            if (b == null || b.Length == 0) return "";
            if (offset < 0 || offset >= b.Length) return "";
            if (len < 0) len = b.Length - offset;
            if (offset + len > b.Length) len = b.Length - offset;
            var sb = new StringBuilder(len);
            for (int i = 0; i < len; i++)
            {
                byte v = b[offset + i];
                sb.Append(v >= 0x20 && v < 0x7F ? (char)v : '.');
            }
            return sb.ToString();
        }

        /// <summary>Classic hexdump (offset | hex | ascii), 16 bytes/row.</summary>
        public static string HexDump(byte[] b, int maxBytes = 512)
        {
            if (b == null || b.Length == 0) return "(empty)";
            int n = Math.Min(b.Length, maxBytes);
            var sb = new StringBuilder();
            for (int row = 0; row < n; row += 16)
            {
                sb.Append(row.ToString("X4")).Append("  ");
                sb.Append(ToHex(b, row, Math.Min(16, n - row), spaced: true).PadRight(16 * 3));
                sb.Append("  ").Append(ToAscii(b, row, Math.Min(16, n - row)));
                sb.Append('\n');
            }
            if (b.Length > n) sb.Append("... (" + (b.Length - n) + " more bytes)\n");
            return sb.ToString();
        }

        private const string SIG_BASE_SUFFIX = "-0000-1000-8000-00805f9b34fb";

        /// <summary>Build the full 128-bit SIG base UUID for a 16-bit assigned number.</summary>
        public static Guid Sig16(ushort uuid16) => new Guid("0000" + uuid16.ToString("X4") + SIG_BASE_SUFFIX);

        /// <summary>True when the UUID is a Bluetooth-SIG base UUID (16- or 32-bit assigned number).</summary>
        public static bool IsSigUuid(Guid g)
        {
            string s = g.ToString("D");
            return s.Length == 36 && s.EndsWith(SIG_BASE_SUFFIX, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>Extract the 16-bit short id when the UUID is a SIG base UUID with a 16-bit value.</summary>
        public static bool TryUuid16(Guid g, out ushort uuid16)
        {
            uuid16 = 0;
            string s = g.ToString("D");
            if (s.Length != 36 || !s.EndsWith(SIG_BASE_SUFFIX, StringComparison.OrdinalIgnoreCase)) return false;
            if (!s.StartsWith("0000", StringComparison.OrdinalIgnoreCase)) return false;
            return ushort.TryParse(s.Substring(4, 4), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out uuid16);
        }

        /// <summary>Short human label for a UUID: known name if SIG, else "custom" with the full GUID.</summary>
        public static string DescribeUuid(Guid g, out bool isVendorSpecific)
        {
            isVendorSpecific = false;
            ushort u16;
            if (TryUuid16(g, out u16))
            {
                string name = UuidNames.Service16(u16);
                if (string.IsNullOrEmpty(name)) name = UuidNames.Characteristic16(u16);
                return string.IsNullOrEmpty(name) ? ("0x" + u16.ToString("X4")) : (name + " (0x" + u16.ToString("X4") + ")");
            }
            if (IsSigUuid(g)) return g.ToString("D");   // 32-bit SIG UUID — rare
            isVendorSpecific = true;                     // 128-bit vendor-specific — the high-value finds
            return "CUSTOM " + g.ToString("D");
        }

        /// <summary>DescribeUuid without the out-parameter, for logging.</summary>
        public static string DescribeUuidSafe(Guid g) { bool _; return DescribeUuid(g, out _); }
    }

    // ════════════════════════════════════════════════════════════════════════════════════
    //  Well-known UUID name tables (Bluetooth SIG Assigned Numbers, common subset)
    // ════════════════════════════════════════════════════════════════════════════════════

    public static class UuidNames
    {
        // SDP service-class + GATT service 16-bit UUIDs (overlapping ranges kept in one table
        // because their numeric spaces do not collide for the values we care about).
        private static readonly Dictionary<ushort, string> _services = new Dictionary<ushort, string>
        {
            { 0x0001, "SDP" },
            { 0x0003, "RFCOMM" },
            { 0x1000, "ServiceDiscoveryServer" },
            { 0x1101, "SPP (Serial Port)" },
            { 0x1103, "DUN (Dial-up Networking)" },
            { 0x1105, "OPP (Object Push)" },
            { 0x1106, "FTP (File Transfer)" },
            { 0x1108, "HSP (Headset)" },
            { 0x110A, "A2DP Source" },
            { 0x110B, "A2DP Sink" },
            { 0x110C, "AVRCP Target" },
            { 0x110D, "Advanced Audio Distribution" },
            { 0x110E, "AVRCP" },
            { 0x110F, "AVRCP Controller" },
            { 0x1112, "Headset Audio Gateway" },
            { 0x1115, "PAN-U" },
            { 0x1116, "NAP (Network Access Point)" },
            { 0x1117, "GN (Group Ad-hoc Network)" },
            { 0x111E, "HFP Hands-Free" },
            { 0x111F, "HFP Audio Gateway" },
            { 0x1122, "BIP (Basic Printing)" },
            { 0x112D, "SIM Access (SAP)" },
            { 0x112E, "PBAP Client (PCE)" },
            { 0x112F, "PBAP Server (PSE)" },
            { 0x1130, "Phonebook Access" },
            { 0x1132, "MAP Server (MAS)" },
            { 0x1133, "MAP Notification (MNS)" },
            { 0x1134, "Message Access Profile" },
            { 0x1200, "PnP Information (DID)" },
            { 0x1800, "Generic Access" },
            { 0x1801, "Generic Attribute" },
            { 0x1802, "Immediate Alert" },
            { 0x1803, "Link Loss" },
            { 0x1804, "Tx Power" },
            { 0x180A, "Device Information" },
            { 0x180F, "Battery Service" },
            { 0x1811, "Alert Notification" },
            { 0x1812, "HID over GATT (HOGP)" },
            { 0x1816, "Cycling Speed & Cadence" },
            { 0x181A, "Environmental Sensing" },
            { 0xFE59, "Nordic DFU" },
            { 0xFEAA, "Eddystone / Google FMDN" },
            { 0xFEED, "Tile" },
            { 0xFD5A, "Samsung SmartThings Find" },
        };

        // GATT characteristic 16-bit UUIDs (common device-info + battery + generic access).
        private static readonly Dictionary<ushort, string> _characteristics = new Dictionary<ushort, string>
        {
            { 0x2A00, "Device Name" },
            { 0x2A01, "Appearance" },
            { 0x2A04, "Peripheral Preferred Conn Params" },
            { 0x2A05, "Service Changed" },
            { 0x2A19, "Battery Level" },
            { 0x2A23, "System ID" },
            { 0x2A24, "Model Number" },
            { 0x2A25, "Serial Number" },
            { 0x2A26, "Firmware Revision" },
            { 0x2A27, "Hardware Revision" },
            { 0x2A28, "Software Revision" },
            { 0x2A29, "Manufacturer Name" },
            { 0x2A50, "PnP ID" },
            { 0x2A4A, "HID Information" },
            { 0x2A4D, "HID Report" },
        };

        // GATT descriptor 16-bit UUIDs.
        private static readonly Dictionary<ushort, string> _descriptors = new Dictionary<ushort, string>
        {
            { 0x2900, "Extended Properties" },
            { 0x2901, "User Description" },
            { 0x2902, "Client Characteristic Config (CCCD)" },
            { 0x2903, "Server Characteristic Config" },
            { 0x2904, "Presentation Format" },
        };

        public static string Service16(ushort u) { string v; return _services.TryGetValue(u, out v) ? v : ""; }
        public static string Characteristic16(ushort u) { string v; return _characteristics.TryGetValue(u, out v) ? v : ""; }
        public static string Descriptor16(ushort u) { string v; return _descriptors.TryGetValue(u, out v) ? v : ""; }

        /// <summary>Map a 16-bit service-class UUID to the profile taxonomy.</summary>
        public static BtProfile ProfileFor16(ushort u)
        {
            switch (u)
            {
                case 0x0001: return BtProfile.SDP;
                case 0x1101: return BtProfile.SPP;
                case 0x1103: return BtProfile.DUN;
                case 0x1105: return BtProfile.OPP;
                case 0x1108: return BtProfile.HSP;
                case 0x110A: return BtProfile.A2DP_Source;
                case 0x110B: return BtProfile.A2DP_Sink;
                case 0x110C: return BtProfile.AVRCP_Target;
                case 0x110E: return BtProfile.AVRCP;
                case 0x110F: return BtProfile.AVRCP_Controller;
                case 0x1115: return BtProfile.PAN_User;
                case 0x1116: return BtProfile.PAN_NAP;
                case 0x1117: return BtProfile.PAN_GN;
                case 0x111E: return BtProfile.HFP_HF;
                case 0x111F: return BtProfile.HFP_AG;
                case 0x112E: return BtProfile.PBAP_Client;
                case 0x112F: return BtProfile.PBAP_Server;
                case 0x1132: return BtProfile.MAP_Server;
                case 0x1133: return BtProfile.MAP_Notify;
                case 0x1200: return BtProfile.DID;
                case 0x1812: return BtProfile.HID;
                default: return BtProfile.Unknown;
            }
        }
    }

    // ════════════════════════════════════════════════════════════════════════════════════
    //  Byte-oriented channel abstraction (RFCOMM socket OR virtual COM both implement this)
    // ════════════════════════════════════════════════════════════════════════════════════

    /// <summary>
    /// A bidirectional byte pipe to a Classic RFCOMM endpoint. Both the WinRT StreamSocket
    /// transport (BtRfcomm) and the legacy virtual-COM transport implement this, so the HFP,
    /// OBEX and fuzzing layers work over either without change.
    /// </summary>
    public interface IByteChannel : IDisposable
    {
        bool IsOpen { get; }
        Task WriteAsync(byte[] data, int offset, int count);
        /// <summary>Read up to buffer.Length bytes; returns count read (0 on timeout).</summary>
        Task<int> ReadAsync(byte[] buffer, int timeoutMs);
        /// <summary>Discard any buffered-but-unread input (used to isolate fuzz cases).</summary>
        void DiscardInput();
        string Describe { get; }
    }
}
