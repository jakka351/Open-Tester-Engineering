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
//  Tester Present Specialist Automotive Solutions — Classic SDP service browse (in-process WinRT)
//  BtSdp.cs — assessment workflow step 2 (Classic side).
//
//  "An sdptool browse (or equivalent WinRT/32feet enumeration) is the single most informative
//   first action against a head unit." — this is that enumeration, done through WinRT's
//  BluetoothDevice.GetRfcommServicesAsync + GetSdpRawAttributesAsync (no NuGet).
//
//  For each RFCOMM service it resolves:
//    • the service-class UUID → well-known name, OR flags it CUSTOM (vendor-specific = the
//      high-value finds: manufacturer update / engineering / diagnostic channels).
//    • the RFCOMM channel number (from ConnectionServiceName, else parsed from the raw
//      ProtocolDescriptorList SDP attribute 0x0004).
//    • the service name (SDP attribute 0x0100) and a raw-attribute hexdump for the record.
//
//  Honesty: WinRT surfaces RFCOMM-backed services. L2CAP-only records and services the local
//  SDP cache never resolved may not appear — the browser says so rather than implying it saw
//  everything.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.Rfcomm;

namespace TesterPresent.OBD2.Bluetooth
{
    public static class BtSdp
    {
        // SDP attribute ids we care about.
        private const uint ATTR_SERVICE_CLASS_ID_LIST = 0x0001;
        private const uint ATTR_PROTOCOL_DESCRIPTOR_LIST = 0x0004;
        private const uint ATTR_SERVICE_NAME = 0x0100;
        private const ushort UUID_RFCOMM = 0x0003;

        /// <summary>
        /// Browse the SDP records of a paired/connectable Classic device. Populates
        /// ep.SdpRecords and returns them. Never throws — errors surface via the log callback.
        /// </summary>
        public static async Task<List<SdpRecord>> BrowseAsync(BtEndpoint ep, Action<string> log = null)
        {
            var records = new List<SdpRecord>();
            if (ep == null) return records;
            BluetoothDevice dev = null;
            try
            {
                if (!string.IsNullOrEmpty(ep.WinRtDeviceId))
                    dev = await WinRt.Await(BluetoothDevice.FromIdAsync(ep.WinRtDeviceId), 10000).ConfigureAwait(false);
                if (dev == null && ep.Address != 0)
                    dev = await WinRt.Await(BluetoothDevice.FromBluetoothAddressAsync(ep.Address), 10000).ConfigureAwait(false);
                if (dev == null) { log?.Invoke("SDP: could not open device (not reachable / not paired)."); return records; }

                var result = await WinRt.Await(dev.GetRfcommServicesAsync(BluetoothCacheMode.Uncached), 15000).ConfigureAwait(false);
                if (result == null || result.Services == null || result.Services.Count == 0)
                {
                    log?.Invoke("SDP: no RFCOMM services returned (device may be out of range, or exposes only L2CAP/LE services).");
                    return records;
                }

                foreach (var svc in result.Services)
                {
                    try
                    {
                        var rec = await BuildRecordAsync(svc).ConfigureAwait(false);
                        records.Add(rec);
                    }
                    finally { try { svc.Dispose(); } catch { } }   // each RfcommDeviceService owns a handle
                }
            }
            catch (Exception ex) { log?.Invoke("SDP browse failed: " + ex.Message); }

            lock (ep.SdpRecords)
            {
                ep.SdpRecords.Clear();
                ep.SdpRecords.AddRange(records);
            }
            return records;
        }

        private static async Task<SdpRecord> BuildRecordAsync(RfcommDeviceService svc)
        {
            var rec = new SdpRecord();
            try
            {
                rec.ServiceClassUuid = svc.ServiceId != null ? svc.ServiceId.Uuid : Guid.Empty;
                rec.WinRtServiceId = svc.ConnectionServiceName ?? "";

                bool vendor;
                rec.ServiceClassName = BtUtil.DescribeUuid(rec.ServiceClassUuid, out vendor);
                rec.IsVendorSpecific = vendor;

                ushort u16;
                if (BtUtil.TryUuid16(rec.ServiceClassUuid, out u16))
                    rec.Profile = UuidNames.ProfileFor16(u16);

                // RFCOMM channel: ConnectionServiceName is usually the channel number as text.
                int chan;
                if (int.TryParse(rec.WinRtServiceId, NumberStyles.Integer, CultureInfo.InvariantCulture, out chan))
                    rec.RfcommChannel = chan;

                // Raw SDP attributes — parse channel + service name, and keep a hexdump.
                try
                {
                    var attrs = await WinRt.Await(svc.GetSdpRawAttributesAsync(BluetoothCacheMode.Uncached), 8000).ConfigureAwait(false);
                    if (attrs != null)
                    {
                        var sb = new StringBuilder();
                        foreach (var kv in attrs)
                        {
                            byte[] val = WinRt.ToBytes(kv.Value);
                            sb.Append("attr 0x").Append(kv.Key.ToString("X4")).Append(": ").Append(BtUtil.ToHex(val, 0, Math.Min(64, val.Length), spaced: true));
                            if (val.Length > 64) sb.Append(" ...");
                            sb.Append('\n');

                            if (kv.Key == ATTR_PROTOCOL_DESCRIPTOR_LIST && rec.RfcommChannel < 0)
                            {
                                int c = ExtractRfcommChannel(val);
                                if (c >= 0) rec.RfcommChannel = c;
                            }
                            else if (kv.Key == ATTR_SERVICE_NAME && string.IsNullOrEmpty(rec.ServiceName))
                            {
                                rec.ServiceName = ExtractString(val);
                            }
                        }
                        rec.RawAttributesHex = sb.ToString();
                    }
                }
                catch { /* raw attributes optional */ }

                if (string.IsNullOrEmpty(rec.ServiceName))
                    rec.ServiceName = rec.IsVendorSpecific ? "(vendor-specific)" : rec.ServiceClassName;
            }
            catch { }
            return rec;
        }

        // ── Minimal SDP data-element parsing ─────────────────────────────────────────────
        //  Enough to pull the RFCOMM channel out of a ProtocolDescriptorList and read a text
        //  string attribute. Not a full SDP decoder.

        /// <summary>Find the uint8 that follows the RFCOMM UUID (0x0003) inside a ProtocolDescriptorList.</summary>
        private static int ExtractRfcommChannel(byte[] data)
        {
            try
            {
                int i = 0;
                bool sawRfcomm = false;
                while (i < data.Length)
                {
                    byte header = data[i++];
                    int type = header >> 3;
                    int sizeIdx = header & 0x07;
                    int len = ElementLength(data, ref i, sizeIdx, type);
                    if (len < 0 || i + len > data.Length) break;

                    if (type == 3) // UUID
                    {
                        ushort u = 0;
                        if (len == 2) u = (ushort)((data[i] << 8) | data[i + 1]);
                        else if (len == 4) u = (ushort)((data[i + 2] << 8) | data[i + 3]);
                        if (u == UUID_RFCOMM) sawRfcomm = true;
                    }
                    else if (type == 1 && sawRfcomm && len == 1) // unsigned int right after RFCOMM UUID
                    {
                        return data[i];
                    }

                    // Descend into sequences/alternatives so we walk the whole tree.
                    if (type == 6 || type == 7) continue; // treat len as container; keep scanning inner elements
                    i += len;
                }
            }
            catch { }
            return -1;
        }

        private static string ExtractString(byte[] data)
        {
            try
            {
                int i = 0;
                if (data.Length == 0) return "";
                byte header = data[i++];
                int type = header >> 3;
                int sizeIdx = header & 0x07;
                int len = ElementLength(data, ref i, sizeIdx, type);
                if (type == 4 && len > 0 && i + len <= data.Length) // text string
                    return Encoding.UTF8.GetString(data, i, len).TrimEnd('\0');
            }
            catch { }
            return "";
        }

        /// <summary>Compute an SDP element's payload length from its size index; advances i past any length field.</summary>
        private static int ElementLength(byte[] data, ref int i, int sizeIdx, int type)
        {
            switch (sizeIdx)
            {
                case 0: return type == 0 ? 0 : 1; // Nil has no bytes; others 1 byte
                case 1: return 2;
                case 2: return 4;
                case 3: return 8;
                case 4: return 16;
                case 5: if (i < data.Length) return data[i++]; return -1;
                case 6: if (i + 1 < data.Length) { int l = (data[i] << 8) | data[i + 1]; i += 2; return l; } return -1;
                case 7: if (i + 3 < data.Length) { int l = (data[i] << 24) | (data[i + 1] << 16) | (data[i + 2] << 8) | data[i + 3]; i += 4; return l; } return -1;
                default: return -1;
            }
        }
    }
}
