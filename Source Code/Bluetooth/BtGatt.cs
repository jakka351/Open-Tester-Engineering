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
//  Tester Present Specialist Automotive Solutions — BLE GATT client (in-process WinRT)
//  BtGatt.cs — assessment workflow step 2 (LE side) + step 3 (LE characteristic read/probe).
//
//  Full service / characteristic / descriptor walk with properties (read/write/notify/indicate),
//  then interactive read, write and subscribe on any characteristic. Standard UUIDs are named;
//  128-bit custom UUIDs are flagged as the manufacturer's private LE control surface — the LE
//  counterpart to the vendor RFCOMM channels SDP surfaces.
//
//  Uses Windows.Devices.Bluetooth.GenericAttributeProfile directly (same winmd already in the
//  csproj). Holds the BluetoothLEDevice for the session so notifications keep flowing and the
//  link stays up; Dispose tears it down.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.GenericAttributeProfile;

namespace TesterPresent.OBD2.Bluetooth
{
    public sealed class BtGatt : IDisposable
    {
        private BluetoothLEDevice _device;
        private readonly List<GattCharacteristic> _subscribed = new List<GattCharacteristic>();
        private readonly List<GattDeviceService> _services = new List<GattDeviceService>();  // owned; disposed in Dispose

        /// <summary>Raised when a subscribed characteristic notifies/indicates. (uuid, bytes).</summary>
        public event Action<Guid, byte[]> Notification;
        public event Action<string> Log;

        public bool IsConnected => _device != null;
        public string DeviceName => _device != null ? _device.Name : "";

        /// <summary>Connect and walk the full GATT tree into ep.GattServices. Returns true on success.</summary>
        public async Task<bool> ConnectAndEnumerateAsync(BtEndpoint ep)
        {
            if (ep == null || ep.Address == 0) { Log?.Invoke("GATT: endpoint has no address to connect to."); return false; }
            try
            {
                DisposeSession();   // release any prior device/services before re-enumerating
                _device = await WinRt.Await(BluetoothLEDevice.FromBluetoothAddressAsync(ep.Address), 12000).ConfigureAwait(false);
                if (_device == null) { Log?.Invoke("GATT: FromBluetoothAddressAsync returned null (device unreachable)."); return false; }

                var svcResult = await WinRt.Await(_device.GetGattServicesAsync(BluetoothCacheMode.Uncached), 15000).ConfigureAwait(false);
                if (svcResult == null || svcResult.Status != GattCommunicationStatus.Success)
                {
                    Log?.Invoke("GATT: service discovery status = " + (svcResult != null ? svcResult.Status.ToString() : "null"));
                    return false;
                }

                var nodes = new List<GattServiceNode>();
                foreach (var svc in svcResult.Services)
                {
                    _services.Add(svc);   // retain to dispose in DisposeSession (chars keep the service alive)
                    var sn = new GattServiceNode { Uuid = svc.Uuid, AttributeHandle = svc.AttributeHandle };
                    bool vendor; sn.Name = BtUtil.DescribeUuid(svc.Uuid, out vendor); sn.IsVendorSpecific = vendor;

                    try
                    {
                        var chResult = await WinRt.Await(svc.GetCharacteristicsAsync(BluetoothCacheMode.Uncached), 12000).ConfigureAwait(false);
                        if (chResult != null && chResult.Status == GattCommunicationStatus.Success)
                        {
                            foreach (var ch in chResult.Characteristics)
                                sn.Characteristics.Add(await BuildCharNodeAsync(ch).ConfigureAwait(false));
                        }
                    }
                    catch (Exception ex) { Log?.Invoke("GATT: char enum for " + sn.Name + " failed: " + ex.Message); }
                    nodes.Add(sn);
                }

                lock (ep.GattServices)
                {
                    ep.GattServices.Clear();
                    ep.GattServices.AddRange(nodes);
                }
                Log?.Invoke("GATT: enumerated " + nodes.Count + " service(s).");
                return true;
            }
            catch (Exception ex) { Log?.Invoke("GATT connect/enumerate failed: " + ex.Message); return false; }
        }

        private async Task<GattCharacteristicNode> BuildCharNodeAsync(GattCharacteristic ch)
        {
            var cn = new GattCharacteristicNode { Uuid = ch.Uuid, AttributeHandle = ch.AttributeHandle, WinRtCharacteristic = ch };
            bool vendor; cn.Name = BtUtil.DescribeUuid(ch.Uuid, out vendor); cn.IsVendorSpecific = vendor;
            if (string.IsNullOrEmpty(cn.Name) || cn.IsVendorSpecific)
            {
                try { if (!string.IsNullOrEmpty(ch.UserDescription)) cn.Name = ch.UserDescription + (cn.IsVendorSpecific ? "  [custom]" : ""); } catch { }
            }

            var p = ch.CharacteristicProperties;
            cn.CanRead = (p & GattCharacteristicProperties.Read) != 0;
            cn.CanWrite = (p & GattCharacteristicProperties.Write) != 0;
            cn.CanWriteNoResp = (p & GattCharacteristicProperties.WriteWithoutResponse) != 0;
            cn.CanNotify = (p & GattCharacteristicProperties.Notify) != 0;
            cn.CanIndicate = (p & GattCharacteristicProperties.Indicate) != 0;
            cn.Properties = PropsText(p);

            try
            {
                var dr = await WinRt.Await(ch.GetDescriptorsAsync(BluetoothCacheMode.Uncached), 8000).ConfigureAwait(false);
                if (dr != null && dr.Status == GattCommunicationStatus.Success)
                    foreach (var d in dr.Descriptors) cn.DescriptorUuids.Add(d.Uuid);
            }
            catch { }

            return cn;
        }

        /// <summary>Read a characteristic's current value. Returns bytes (empty on failure) and fills the node.</summary>
        public async Task<byte[]> ReadAsync(GattCharacteristicNode node)
        {
            var ch = node?.WinRtCharacteristic as GattCharacteristic;
            if (ch == null) return Array.Empty<byte>();
            try
            {
                var res = await WinRt.Await(ch.ReadValueAsync(BluetoothCacheMode.Uncached), 8000).ConfigureAwait(false);
                if (res == null || res.Status != GattCommunicationStatus.Success)
                {
                    Log?.Invoke("GATT read status = " + (res != null ? res.Status.ToString() : "null"));
                    return Array.Empty<byte>();
                }
                var bytes = WinRt.ToBytes(res.Value);
                node.LastValueHex = BtUtil.ToHex(bytes, 0, -1, spaced: true);
                node.LastValueText = BtUtil.ToAscii(bytes);
                return bytes;
            }
            catch (Exception ex) { Log?.Invoke("GATT read failed: " + ex.Message); return Array.Empty<byte>(); }
        }

        /// <summary>Write bytes to a characteristic (with or without response).</summary>
        public async Task<bool> WriteAsync(GattCharacteristicNode node, byte[] data, bool withResponse)
        {
            var ch = node?.WinRtCharacteristic as GattCharacteristic;
            if (ch == null) return false;
            try
            {
                var opt = withResponse ? GattWriteOption.WriteWithResponse : GattWriteOption.WriteWithoutResponse;
                var status = await WinRt.Await(ch.WriteValueAsync(WinRt.ToBuffer(data), opt), 8000).ConfigureAwait(false);
                bool ok = status == GattCommunicationStatus.Success;
                Log?.Invoke("GATT write " + (ok ? "OK" : status.ToString()) + " (" + data.Length + " bytes) to " + node.Name);
                return ok;
            }
            catch (Exception ex) { Log?.Invoke("GATT write failed: " + ex.Message); return false; }
        }

        /// <summary>Subscribe (Notify preferred, else Indicate) to a characteristic. Notifications raise the event.</summary>
        public async Task<bool> SubscribeAsync(GattCharacteristicNode node)
        {
            var ch = node?.WinRtCharacteristic as GattCharacteristic;
            if (ch == null) return false;
            try
            {
                var cccd = node.CanNotify ? GattClientCharacteristicConfigurationDescriptorValue.Notify
                         : node.CanIndicate ? GattClientCharacteristicConfigurationDescriptorValue.Indicate
                         : GattClientCharacteristicConfigurationDescriptorValue.None;
                if (cccd == GattClientCharacteristicConfigurationDescriptorValue.None)
                { Log?.Invoke("GATT: " + node.Name + " supports neither Notify nor Indicate."); return false; }

                var status = await WinRt.Await(ch.WriteClientCharacteristicConfigurationDescriptorAsync(cccd), 8000).ConfigureAwait(false);
                if (status != GattCommunicationStatus.Success) { Log?.Invoke("GATT subscribe status = " + status); return false; }

                ch.ValueChanged += OnValueChanged;
                lock (_subscribed) _subscribed.Add(ch);
                Log?.Invoke("GATT subscribed to " + node.Name + " (" + cccd + ").");
                return true;
            }
            catch (Exception ex) { Log?.Invoke("GATT subscribe failed: " + ex.Message); return false; }
        }

        private void OnValueChanged(GattCharacteristic sender, GattValueChangedEventArgs args)
        {
            try { Notification?.Invoke(sender.Uuid, WinRt.ToBytes(args.CharacteristicValue)); } catch { }
        }

        private static string PropsText(GattCharacteristicProperties p)
        {
            var parts = new List<string>();
            if ((p & GattCharacteristicProperties.Read) != 0) parts.Add("Read");
            if ((p & GattCharacteristicProperties.Write) != 0) parts.Add("Write");
            if ((p & GattCharacteristicProperties.WriteWithoutResponse) != 0) parts.Add("WriteNoResp");
            if ((p & GattCharacteristicProperties.Notify) != 0) parts.Add("Notify");
            if ((p & GattCharacteristicProperties.Indicate) != 0) parts.Add("Indicate");
            if ((p & GattCharacteristicProperties.AuthenticatedSignedWrites) != 0) parts.Add("SignedWrite");
            if ((p & GattCharacteristicProperties.Broadcast) != 0) parts.Add("Broadcast");
            if ((p & GattCharacteristicProperties.ExtendedProperties) != 0) parts.Add("Ext");
            return string.Join(",", parts);
        }

        public void Dispose() => DisposeSession();

        /// <summary>Unsubscribe handlers and dispose the device + all enumerated services (each owns a handle).</summary>
        private void DisposeSession()
        {
            lock (_subscribed)
            {
                foreach (var ch in _subscribed) { try { ch.ValueChanged -= OnValueChanged; } catch { } }
                _subscribed.Clear();
            }
            foreach (var svc in _services) { try { svc.Dispose(); } catch { } }
            _services.Clear();
            try { _device?.Dispose(); } catch { }
            _device = null;
        }
    }
}
