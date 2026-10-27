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
//  Tester Present Specialist Automotive Solutions — unified Bluetooth discovery (in-process WinRT)
//  BtDiscovery.cs — assessment workflow step 1 (passive advertising scan) + step 2 setup (enumerate targets).
//
//  Three discovery paths, all merged into one BtEndpoint table keyed by MAC:
//    • BLE advertising scan  — passive/active watcher; readable without connecting (the "establish
//      what is present without touching anything" step). Captures name, RSSI, service UUIDs,
//      manufacturer company ids, TX power, appearance.
//    • Paired-device enumeration — Classic + LE via Windows.Devices.Enumeration selectors, so a
//      head unit that is already paired shows up with its WinRT device Id (needed for SDP/pairing).
//    • Unpaired inquiry — a DeviceWatcher over the unpaired selectors, so discoverable head units
//      and sensors appear even before pairing.
//
//  Vehicle heuristic mirrors the one already shipping in VehicleBluetoothTestingDialog.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.Advertisement;
using Windows.Devices.Enumeration;

namespace TesterPresent.OBD2.Bluetooth
{
    /// <summary>
    /// Owns the advertising watcher and the paired/unpaired enumerators. Raises
    /// <see cref="EndpointUpdated"/> whenever an endpoint is discovered or enriched.
    /// Events fire on WinRT/threadpool threads — subscribers marshal to the UI themselves.
    /// </summary>
    public sealed class BtDiscovery : IDisposable
    {
        private readonly object _sync = new object();
        private readonly Dictionary<string, BtEndpoint> _byMac = new Dictionary<string, BtEndpoint>(StringComparer.OrdinalIgnoreCase);

        private BluetoothLEAdvertisementWatcher _adWatcher;
        private DeviceWatcher _unpairedClassic;
        private DeviceWatcher _unpairedLe;

        public event Action<BtEndpoint> EndpointUpdated;
        public event Action<string> Log;

        public bool IsScanning { get; private set; }

        public IReadOnlyList<BtEndpoint> Snapshot()
        {
            lock (_sync) return new List<BtEndpoint>(_byMac.Values);
        }

        // ── Passive/active BLE advertising scan ───────────────────────────────────────────
        public void StartAdvertisingScan(bool active = true)
        {
            StopAdvertisingScan();
            try
            {
                _adWatcher = new BluetoothLEAdvertisementWatcher
                {
                    ScanningMode = active ? BluetoothLEScanningMode.Active : BluetoothLEScanningMode.Passive,
                };
                _adWatcher.Received += OnAdvertisement;
                _adWatcher.Stopped += OnAdvStopped;
                _adWatcher.Start();
                IsScanning = true;
                RaiseLog("BLE advertising scan started (" + (active ? "active" : "passive") + ", Status=" + _adWatcher.Status + ").");
            }
            catch (Exception ex)
            {
                IsScanning = false;
                _adWatcher = null;
                RaiseLog("BLE scan start FAILED: " + ex.Message + " (radio off? Location service off? driver error?).");
            }
        }

        public void StopAdvertisingScan()
        {
            try
            {
                if (_adWatcher != null)
                {
                    _adWatcher.Received -= OnAdvertisement;
                    _adWatcher.Stopped -= OnAdvStopped;
                    if (_adWatcher.Status == BluetoothLEAdvertisementWatcherStatus.Started) _adWatcher.Stop();
                }
            }
            catch { }
            finally { _adWatcher = null; IsScanning = false; }
        }

        private void OnAdvStopped(BluetoothLEAdvertisementWatcher s, BluetoothLEAdvertisementWatcherStoppedEventArgs a)
        {
            IsScanning = false;
            if (a.Error != BluetoothError.Success) RaiseLog("BLE scan stopped: " + a.Error);
        }

        private void OnAdvertisement(BluetoothLEAdvertisementWatcher sender, BluetoothLEAdvertisementReceivedEventArgs args)
        {
            try
            {
                string mac = BtUtil.MacFromUlong(args.BluetoothAddress);
                var ep = GetOrCreate(mac, args.BluetoothAddress);
                lock (_sync)
                {
                    ep.Transport = ep.Transport == BtTransport.Classic ? BtTransport.DualMode : BtTransport.LowEnergy;
                    ep.Rssi = args.RawSignalStrengthInDBm;
                    ep.LastSeenUtc = DateTime.UtcNow;
                    var adv = args.Advertisement;
                    if (adv != null)
                    {
                        if (!string.IsNullOrEmpty(adv.LocalName)) ep.Name = adv.LocalName;
                        foreach (var g in adv.ServiceUuids)
                            if (!ep.AdvertisedServiceUuids.Contains(g)) ep.AdvertisedServiceUuids.Add(g);
                        foreach (var md in adv.ManufacturerData)
                            if (!ep.ManufacturerCompanyIds.Contains(md.CompanyId)) ep.ManufacturerCompanyIds.Add(md.CompanyId);
                        // Appearance (AD type 0x19) and TX power (0x0A) live in data sections.
                        foreach (var ds in adv.DataSections)
                        {
                            var b = WinRt.ToBytes(ds.Data);
                            if (ds.DataType == 0x19 && b.Length >= 2) ep.Appearance = (ushort)(b[0] | (b[1] << 8));
                            else if (ds.DataType == 0x0A && b.Length >= 1) ep.TxPower = (sbyte)b[0];
                        }
                    }
                    ep.LooksLikeVehicle = LooksLikeVehicle(ep.Name, ep.DeviceClassText);
                    ep.Vendor = OuiVendor.Lookup(args.BluetoothAddress);
                }
                Raise(ep);
            }
            catch { /* tolerate a malformed advert */ }
        }

        // ── Paired-device enumeration (Classic + LE) ──────────────────────────────────────
        public async Task EnumeratePairedAsync()
        {
            await EnumerateSelectorAsync(BluetoothDevice.GetDeviceSelectorFromPairingState(true), BtTransport.Classic).ConfigureAwait(false);
            await EnumerateSelectorAsync(BluetoothLEDevice.GetDeviceSelectorFromPairingState(true), BtTransport.LowEnergy).ConfigureAwait(false);
        }

        private async Task EnumerateSelectorAsync(string selector, BtTransport transport)
        {
            try
            {
                var col = await WinRt.Await(DeviceInformation.FindAllAsync(selector), 10000).ConfigureAwait(false);
                foreach (var di in col) await IngestDeviceInformationAsync(di, transport).ConfigureAwait(false);
            }
            catch (Exception ex) { RaiseLog("Paired enum (" + transport + ") failed: " + ex.Message); }
        }

        private async Task IngestDeviceInformationAsync(DeviceInformation di, BtTransport transport)
        {
            try
            {
                ulong addr = 0; uint cod = 0;
                if (transport == BtTransport.Classic)
                {
                    var dev = await WinRt.Await(BluetoothDevice.FromIdAsync(di.Id), 8000).ConfigureAwait(false);
                    if (dev != null) { addr = dev.BluetoothAddress; cod = dev.ClassOfDevice != null ? dev.ClassOfDevice.RawValue : 0; }
                }
                else
                {
                    var dev = await WinRt.Await(BluetoothLEDevice.FromIdAsync(di.Id), 8000).ConfigureAwait(false);
                    if (dev != null) addr = dev.BluetoothAddress;
                }
                string mac = addr != 0 ? BtUtil.MacFromUlong(addr) : ("ID:" + di.Id.GetHashCode().ToString("X8"));
                var ep = GetOrCreate(mac, addr);
                lock (_sync)
                {
                    if (!string.IsNullOrEmpty(di.Name)) ep.Name = di.Name;
                    ep.WinRtDeviceId = di.Id;
                    ep.IsPaired = di.Pairing != null && di.Pairing.IsPaired;
                    ep.CanPair = di.Pairing != null && di.Pairing.CanPair;
                    ep.Transport = ep.Transport == BtTransport.Unknown ? transport
                                 : (ep.Transport != transport ? BtTransport.DualMode : ep.Transport);
                    if (cod != 0) { ep.ClassOfDevice = cod; ep.DeviceClassText = DecodeMajorClass(cod); }
                    ep.LooksLikeVehicle = LooksLikeVehicle(ep.Name, ep.DeviceClassText);
                    if (addr != 0) ep.Vendor = OuiVendor.Lookup(addr);
                }
                Raise(ep);
            }
            catch (Exception ex) { RaiseLog("Ingest device failed: " + ex.Message); }
        }

        // ── Unpaired inquiry (discoverable devices in range) ──────────────────────────────
        public void StartUnpairedInquiry()
        {
            StopUnpairedInquiry();
            _unpairedClassic = MakeWatcher(BluetoothDevice.GetDeviceSelectorFromPairingState(false), BtTransport.Classic);
            _unpairedLe = MakeWatcher(BluetoothLEDevice.GetDeviceSelectorFromPairingState(false), BtTransport.LowEnergy);
            try { _unpairedClassic?.Start(); _unpairedLe?.Start(); RaiseLog("Unpaired-device inquiry started."); }
            catch (Exception ex) { RaiseLog("Inquiry start failed: " + ex.Message); }
        }

        public void StopUnpairedInquiry()
        {
            foreach (var w in new[] { _unpairedClassic, _unpairedLe })
            {
                try { if (w != null && (w.Status == DeviceWatcherStatus.Started || w.Status == DeviceWatcherStatus.EnumerationCompleted)) w.Stop(); }
                catch { }
            }
            _unpairedClassic = null; _unpairedLe = null;
        }

        private DeviceWatcher MakeWatcher(string selector, BtTransport transport)
        {
            try
            {
                var w = DeviceInformation.CreateWatcher(selector);
                w.Added += async (s, di) => { try { await IngestDeviceInformationAsync(di, transport).ConfigureAwait(false); } catch { } };
                w.Updated += (s, upd) => { };
                return w;
            }
            catch (Exception ex) { RaiseLog("Watcher create (" + transport + ") failed: " + ex.Message); return null; }
        }

        // ── Endpoint table helpers ────────────────────────────────────────────────────────
        private BtEndpoint GetOrCreate(string mac, ulong addr)
        {
            lock (_sync)
            {
                BtEndpoint ep;
                if (!_byMac.TryGetValue(mac, out ep))
                {
                    ep = new BtEndpoint { MacColons = mac, Address = addr };
                    _byMac[mac] = ep;
                }
                else if (ep.Address == 0 && addr != 0) ep.Address = addr;
                return ep;
            }
        }

        private void Raise(BtEndpoint ep) { try { EndpointUpdated?.Invoke(ep); } catch { } }
        private void RaiseLog(string s) { try { Log?.Invoke(s); } catch { } }

        public void Dispose() { StopAdvertisingScan(); StopUnpairedInquiry(); }

        // ── Static classifiers ──────────────────────────────────────────────────────────
        public static bool LooksLikeVehicle(string name, string deviceClass)
        {
            string n = (name ?? "").ToLowerInvariant();
            string c = (deviceClass ?? "").ToLowerInvariant();
            if (c.Contains("audio") || c.Contains("car")) return true;
            string[] hints = { "car", "sync", "uconnect", "mylink", "idrive", "audi", "bmw", "mercedes", "ford", "holden",
                "toyota", "lexus", "mazda", "nissan", "infiniti", "honda", "acura", "subaru", "kia", "hyundai",
                "vw", "volkswagen", "porsche", "tesla", "jaguar", "land rover", "mini", "fiat", "alfa", "peugeot",
                "renault", "citroen", "skoda", "volvo", "carplay", "android auto", "head unit", "kenwood", "pioneer",
                "alpine", "sony xav", "entune", "blue&me", "blueme", "connectednav" };
            foreach (var h in hints) if (n.Contains(h)) return true;
            return false;
        }

        public static string DecodeMajorClass(uint cod)
        {
            if (cod == 0) return "";
            uint major = (cod >> 8) & 0x1F;
            switch (major)
            {
                case 0x01: return "Computer";
                case 0x02: return "Phone";
                case 0x03: return "LAN/Network";
                case 0x04: return "Audio/Video";
                case 0x05: return "Peripheral";
                case 0x06: return "Imaging";
                case 0x07: return "Wearable";
                case 0x08: return "Toy";
                case 0x09: return "Health";
                default: return "Class 0x" + major.ToString("X2");
            }
        }
    }

    /// <summary>Very small OUI→vendor hint table (top head-unit / module chipset vendors). Best-effort only.</summary>
    internal static class OuiVendor
    {
        // Keyed by the 24-bit OUI (upper 3 bytes of the address). Deliberately tiny; a full IEEE
        // OUI database is not shipped. Unknown OUI returns "".
        private static readonly Dictionary<uint, string> _oui = new Dictionary<uint, string>
        {
            { 0x0004F8, "QUALCOMM (BT chipset)" },
            { 0x001BDC, "Cambridge Silicon Radio" },
            { 0x000272, "CSR" },
            { 0x00025B, "Cambridge Silicon Radio" },
            { 0x00060C, "Melco/Buffalo" },
            { 0x001A7D, "Cyber-blue (HK)" },
            { 0xF8F1B6, "Espressif (ESP32)" },
            { 0x246F28, "Espressif (ESP32)" },
            { 0x8C4B14, "Broadcom" },
            { 0x001988, "Continental Automotive" },
            { 0x0026E2, "LG Electronics" },
            { 0xAC221B, "Harman/Becker (head units)" },
            { 0x001D4F, "Apple" },
            { 0x004C00, "Apple (Find My)" },
        };

        public static string Lookup(ulong addr)
        {
            uint oui = (uint)((addr >> 24) & 0xFFFFFF);
            string v;
            return _oui.TryGetValue(oui, out v) ? v : "";
        }
    }
}
