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
//  Tester Present Specialist Automotive Solutions — Classic RFCOMM transport (in-process WinRT)
//  BtRfcomm.cs — the true PEER channel behind assessment step 3 (profile interrogation).
//
//  Two IByteChannel implementations:
//    • RfcommSocketChannel — a WinRT StreamSocket bound to a specific RFCOMM service UUID on
//      the target (SPP, HFP-AG, PBAP, MAP, or a CUSTOM vendor UUID found by SDP). This is the
//      real bidirectional byte channel into whatever service backs it — not limited to the
//      Windows-created SPP virtual COM port.
//    • SerialComChannel — the legacy virtual-COM path (kept as a fallback for cars that only
//      surface a Windows COM port). Same interface, so HFP/OBEX/fuzzing work over either.
//
//  A dedicated background reader drains the transport into a byte queue; ReadAsync returns
//  whatever is buffered within the timeout. This avoids cancelling a WinRT LoadAsync mid-flight
//  (which would leave the DataReader in an awkward state) and gives clean line/frame reads to
//  the HFP and OBEX layers above.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.Rfcomm;
using Windows.Foundation;
using Windows.Networking.Sockets;
using Windows.Storage.Streams;

namespace TesterPresent.OBD2.Bluetooth
{
    /// <summary>Connects RFCOMM StreamSockets to a target endpoint by service UUID.</summary>
    public static class RfcommConnector
    {
        /// <summary>
        /// Open an RFCOMM channel to the service with the given class UUID on the endpoint.
        /// Tries plain, then encrypted-allow-null-auth protection (bonded head units often
        /// refuse a plain socket). Returns null on failure (reason logged).
        /// </summary>
        public static async Task<RfcommSocketChannel> ConnectAsync(BtEndpoint ep, Guid serviceClassUuid, Action<string> log = null)
        {
            if (ep == null) return null;
            try
            {
                BluetoothDevice dev = null;
                if (!string.IsNullOrEmpty(ep.WinRtDeviceId))
                    dev = await WinRt.Await(BluetoothDevice.FromIdAsync(ep.WinRtDeviceId), 10000).ConfigureAwait(false);
                if (dev == null && ep.Address != 0)
                    dev = await WinRt.Await(BluetoothDevice.FromBluetoothAddressAsync(ep.Address), 10000).ConfigureAwait(false);
                if (dev == null) { log?.Invoke("RFCOMM: device not reachable."); return null; }

                RfcommDeviceService svc = null;
                try
                {
                    var byId = await WinRt.Await(dev.GetRfcommServicesForIdAsync(RfcommServiceId.FromUuid(serviceClassUuid), BluetoothCacheMode.Uncached), 12000).ConfigureAwait(false);
                    if (byId != null && byId.Services != null && byId.Services.Count > 0) svc = byId.Services[0];
                }
                catch { }
                if (svc == null)
                {
                    var all = await WinRt.Await(dev.GetRfcommServicesAsync(BluetoothCacheMode.Uncached), 12000).ConfigureAwait(false);
                    if (all != null && all.Services != null)
                        foreach (var s in all.Services)
                            if (s.ServiceId != null && s.ServiceId.Uuid == serviceClassUuid) { svc = s; break; }
                }
                if (svc == null) { log?.Invoke("RFCOMM: service " + serviceClassUuid + " not found on device."); return null; }

                try
                {
                    foreach (var level in new[] { SocketProtectionLevel.PlainSocket, SocketProtectionLevel.BluetoothEncryptionAllowNullAuthentication })
                    {
                        StreamSocket socket = null;
                        try
                        {
                            socket = new StreamSocket();
                            await WinRt.Await(socket.ConnectAsync(svc.ConnectionHostName, svc.ConnectionServiceName, level), 12000).ConfigureAwait(false);
                            log?.Invoke("RFCOMM connected to channel " + svc.ConnectionServiceName + " (" + level + ").");
                            var chan = new RfcommSocketChannel(socket, svc.ConnectionServiceName);
                            socket = null;   // ownership handed to the channel
                            return chan;
                        }
                        catch (Exception ex)
                        {
                            log?.Invoke("RFCOMM connect (" + level + ") failed: " + ex.Message);
                        }
                        finally { try { socket?.Dispose(); } catch { } }   // dispose only on the failure path
                    }
                    return null;
                }
                finally { try { svc.Dispose(); } catch { } }   // svc only needed for ConnectionHostName/ServiceName
            }
            catch (Exception ex) { log?.Invoke("RFCOMM connect error: " + ex.Message); return null; }
        }
    }

    /// <summary>Shared background-reader plumbing for a streaming byte channel.</summary>
    public abstract class BufferedByteChannel : IByteChannel
    {
        private readonly Queue<byte> _rx = new Queue<byte>();
        private readonly object _rxLock = new object();
        protected volatile bool _closed;
        protected CancellationTokenSource _readerCts;

        public bool IsOpen => !_closed;
        public abstract string Describe { get; }
        public abstract Task WriteAsync(byte[] data, int offset, int count);
        protected abstract Task<byte[]> ReadFromTransportAsync(CancellationToken ct);

        protected void StartReader()
        {
            _readerCts = new CancellationTokenSource();
            var ct = _readerCts.Token;
            Task.Run(async () =>
            {
                while (!ct.IsCancellationRequested && !_closed)
                {
                    byte[] chunk;
                    try { chunk = await ReadFromTransportAsync(ct).ConfigureAwait(false); }
                    catch { break; }
                    if (chunk == null) { break; }              // stream closed
                    if (chunk.Length == 0) { continue; }
                    lock (_rxLock) foreach (var b in chunk) _rx.Enqueue(b);
                }
                _closed = true;
            });
        }

        public async Task<int> ReadAsync(byte[] buffer, int timeoutMs)
        {
            var sw = System.Diagnostics.Stopwatch.StartNew();
            while (sw.ElapsedMilliseconds < timeoutMs)
            {
                int n = DrainInto(buffer);
                if (n > 0) return n;
                if (_closed) return 0;
                await Task.Delay(15).ConfigureAwait(false);
            }
            return DrainInto(buffer);
        }

        private int DrainInto(byte[] buffer)
        {
            lock (_rxLock)
            {
                int n = 0;
                while (n < buffer.Length && _rx.Count > 0) buffer[n++] = _rx.Dequeue();
                return n;
            }
        }

        public void DiscardInput() { lock (_rxLock) _rx.Clear(); }

        public virtual void Dispose()
        {
            _closed = true;
            try { _readerCts?.Cancel(); } catch { }
        }
    }

    /// <summary>RFCOMM over a WinRT StreamSocket.</summary>
    public sealed class RfcommSocketChannel : BufferedByteChannel
    {
        // We use the socket's raw IInputStream/IOutputStream rather than DataReader/DataWriter:
        // their ReadAsync/WriteAsync are DECLARED to return the Windows.Foundation async INTERFACE
        // types, so the WinRt.AwaitProgress bridge binds cleanly from the split winmds. The concrete
        // DataReaderLoadOperation/DataWriterStoreOperation classes only expose that interface through
        // the union "Windows" assembly, which we cannot reference (forwarder cycle) — see BtCommon.
        private readonly StreamSocket _socket;
        private readonly IInputStream _input;
        private readonly IOutputStream _output;
        private readonly string _channel;
        private readonly SemaphoreSlim _writeGate = new SemaphoreSlim(1, 1);

        internal RfcommSocketChannel(StreamSocket socket, string channel)
        {
            _socket = socket;
            _channel = channel;
            _input = socket.InputStream;
            _output = socket.OutputStream;
            StartReader();
        }

        public override string Describe => "RFCOMM ch " + _channel;

        protected override async Task<byte[]> ReadFromTransportAsync(CancellationToken ct)
        {
            var buffer = new Windows.Storage.Streams.Buffer(512);
            IBuffer result = await WinRt.AwaitProgress<IBuffer, uint>(
                _input.ReadAsync(buffer, 512, InputStreamOptions.Partial), 3600000, ct).ConfigureAwait(false); // long timeout; cancelled on close
            if (result == null || result.Length == 0) return null;
            return WinRt.ToBytes(result);
        }

        public override async Task WriteAsync(byte[] data, int offset, int count)
        {
            if (_closed) return;
            byte[] slice;
            if (offset == 0 && count == data.Length) slice = data;
            else { slice = new byte[count]; Array.Copy(data, offset, slice, 0, count); }
            IBuffer buf = WinRt.ToBuffer(slice);
            await _writeGate.WaitAsync().ConfigureAwait(false);
            try { await WinRt.AwaitProgress<uint, uint>(_output.WriteAsync(buf), 8000).ConfigureAwait(false); }
            finally { _writeGate.Release(); }
        }

        public override void Dispose()
        {
            base.Dispose();
            try { _socket.Dispose(); } catch { }
            // Do NOT dispose _writeGate: an in-flight WriteAsync would then throw ObjectDisposedException
            // on Release(). A SemaphoreSlim whose AvailableWaitHandle is never touched needs no disposal.
        }
    }

    /// <summary>Legacy fallback: RFCOMM via the Windows-created virtual COM port (SerialPort).</summary>
    public sealed class SerialComChannel : BufferedByteChannel
    {
        private readonly SerialPort _port;
        private readonly byte[] _readBuf = new byte[512];

        public SerialComChannel(string comPort, int baud = 115200)
        {
            _port = new SerialPort(comPort, baud, Parity.None, 8, StopBits.One)
            {
                ReadTimeout = 200,
                WriteTimeout = 800,
                DtrEnable = true,
                RtsEnable = true,
            };
            _port.Open();
            StartReader();
        }

        public override string Describe => "COM " + _port.PortName;

        protected override Task<byte[]> ReadFromTransportAsync(CancellationToken ct)
        {
            try
            {
                int n = _port.Read(_readBuf, 0, _readBuf.Length);
                if (n <= 0) return Task.FromResult(Array.Empty<byte>());
                var outb = new byte[n];
                Array.Copy(_readBuf, outb, n);
                return Task.FromResult(outb);
            }
            catch (TimeoutException) { return Task.FromResult(Array.Empty<byte>()); }
            catch { return Task.FromResult<byte[]>(null); }
        }

        public override Task WriteAsync(byte[] data, int offset, int count)
        {
            try { if (_port.IsOpen) _port.Write(data, offset, count); } catch { }
            return Task.CompletedTask;
        }

        public override void Dispose()
        {
            base.Dispose();
            try { if (_port.IsOpen) _port.Close(); } catch { }
            try { _port.Dispose(); } catch { }
        }
    }
}
