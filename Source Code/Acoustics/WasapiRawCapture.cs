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
//  Tester Present Specialist Automotive Solutions — Acoustic Diagnostics: raw-mode WASAPI capture
//  Copyright (c) 2026 Benjamin Jack Leighton. All rights reserved.
//
//  Direct WASAPI capture via COM interop so the stream can be opened in RAW mode
//  (AUDCLNT_STREAMOPTIONS_RAW), which asks the audio engine to BYPASS the endpoint's APO effect
//  chain — on this bench the "Realtek System Effect" (AGC + noise suppression) that otherwise
//  reshapes the spectrum. NAudio 2.3 exposes AudioClientProperties/Raw but WasapiCapture gives no
//  seam to call IAudioClient2::SetClientProperties between Activate and Initialize, so capture is
//  hand-rolled here. Enumeration still uses NAudio's MMDeviceEnumerator (see MicrophoneCapture).
//
//  Threading: the entire COM lifetime (enumerator → device → client → capture loop → teardown)
//  lives on ONE dedicated MTA thread. Nothing touches these interfaces from the UI thread. Start()
//  blocks until the worker reports init success/failure. Raw is attempted first (Win8.1+); on any
//  failure it falls back to a normal shared-mode stream and reports RawGranted = false.
//
//  IIDs/CLSIDs/flags below are fixed Windows constants (mmdeviceapi.h / audioclient.h / ksmedia.h),
//  not invented values.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace TesterPresent.OBD2.Acoustics
{
    /// <summary>Low-level raw-capable WASAPI capture. Delivers mono float blocks on its own thread.</summary>
    public sealed class WasapiRawCapture : IDisposable
    {
        // caller-facing
        public int SampleRate { get; private set; }
        public int Channels { get; private set; }
        public bool RawGranted { get; private set; }
        /// <summary>Raised on the capture thread with a shared mono buffer + valid sample count.</summary>
        public event Action<float[], int> MonoAvailable;

        private Thread _thread;
        private volatile bool _running;
        private IntPtr _hEvent = IntPtr.Zero;
        private Exception _initError;
        private readonly ManualResetEventSlim _initDone = new ManualResetEventSlim(false);
        private readonly object _evtLock = new object();
        private int _disposed;
        private string _deviceId;
        private bool _preferRaw = true;

        // format resolved at init
        private int _bits;
        private bool _isFloat;
        private int _blockAlign;
        private float[] _mono = Array.Empty<float>();
        private byte[] _scratch = Array.Empty<byte>();

        public void Start(string deviceId, bool preferRaw = true)
        {
            Stop();
            _deviceId = deviceId;
            _preferRaw = preferRaw;
            _initError = null;
            _initDone.Reset();
            _running = true;
            _thread = new Thread(CaptureThread) { IsBackground = true, Name = "AcousticWasapiCapture" };
            _thread.SetApartmentState(ApartmentState.MTA);
            _thread.Start();
            // Bounded wait — a wedged/exclusive-held endpoint must not freeze the UI thread forever.
            if (!_initDone.Wait(TimeSpan.FromSeconds(5)))
            {
                Stop();
                throw new TimeoutException("Microphone did not initialize within 5 s — the device may be busy or held exclusively by another app.");
            }
            if (_initError != null)
            {
                var ex = _initError;
                Stop();
                throw ex;
            }
        }

        public void Stop()
        {
            _running = false;
            lock (_evtLock) { if (_hEvent != IntPtr.Zero) { try { SetEvent(_hEvent); } catch { } } }
            var t = _thread;
            if (t != null && t.IsAlive && t.ManagedThreadId != Thread.CurrentThread.ManagedThreadId)
                t.Join(2000);
            _thread = null;
        }

        public void Dispose()
        {
            Stop();
            if (System.Threading.Interlocked.Exchange(ref _disposed, 1) == 0)
                try { _initDone.Dispose(); } catch { }
        }

        private void CaptureThread()
        {
            IntPtr pFormat = IntPtr.Zero;
            object enumObj = null, deviceObj = null, clientObj = null, captureObj = null;
            IAudioCaptureClient capture = null;
            bool started = false;
            object clientForStartStop = null;   // IAudioClient2 or IAudioClient — both expose Start/Stop at same slots
            try
            {
                CoInitializeEx(IntPtr.Zero, COINIT_MULTITHREADED);

                var enumType = Type.GetTypeFromCLSID(CLSID_MMDeviceEnumerator);
                enumObj = Activator.CreateInstance(enumType);
                var mmEnum = (IMMDeviceEnumerator)enumObj;

                IMMDevice device;
                if (string.IsNullOrEmpty(_deviceId))
                    Marshal.ThrowExceptionForHR(mmEnum.GetDefaultAudioEndpoint(EDataFlow.eCapture, ERole.eCommunications, out device));
                else
                    Marshal.ThrowExceptionForHR(mmEnum.GetDevice(_deviceId, out device));
                deviceObj = device;

                // Try IAudioClient2 (raw-capable, Win8.1+); fall back to plain IAudioClient (Win7).
                IAudioClient2 client2 = null;
                IAudioClient client1 = null;
                Guid iidC2 = IID_IAudioClient2, iidC1 = IID_IAudioClient;
                bool haveC2 = false;
                if (_preferRaw)
                {
                    try
                    {
                        object o2;
                        int hr = device.Activate(ref iidC2, CLSCTX_ALL, IntPtr.Zero, out o2);
                        if (hr == 0 && o2 != null) { client2 = (IAudioClient2)o2; clientObj = o2; haveC2 = true; }
                    }
                    catch { haveC2 = false; }
                }
                if (!haveC2)
                {
                    object o1;
                    Marshal.ThrowExceptionForHR(device.Activate(ref iidC1, CLSCTX_ALL, IntPtr.Zero, out o1));
                    client1 = (IAudioClient)o1; clientObj = o1;
                }

                // Request RAW (bypass APO) — only meaningful on the IAudioClient2 path.
                RawGranted = false;
                if (haveC2)
                {
                    var props = new AudioClientProperties
                    {
                        cbSize = (uint)Marshal.SizeOf(typeof(AudioClientProperties)),
                        bIsOffload = 0,
                        eCategory = AUDIO_STREAM_CATEGORY_Other,
                        Options = AudioClientStreamOptions.Raw,
                    };
                    IntPtr pProps = Marshal.AllocHGlobal((int)props.cbSize);
                    try
                    {
                        Marshal.StructureToPtr(props, pProps, false);
                        int hr = client2.SetClientProperties(pProps);
                        RawGranted = hr == 0;
                    }
                    finally { Marshal.FreeHGlobal(pProps); }
                }

                // Mix format (engine-native; no conversion path needed).
                if (haveC2) Marshal.ThrowExceptionForHR(client2.GetMixFormat(out pFormat));
                else        Marshal.ThrowExceptionForHR(client1.GetMixFormat(out pFormat));
                ReadFormat(pFormat);

                const long hns = 0;   // shared event-driven: engine picks buffer + period
                int initHr = haveC2
                    ? client2.Initialize(AUDCLNT_SHAREMODE_SHARED, AUDCLNT_STREAMFLAGS_EVENTCALLBACK, hns, 0, pFormat, IntPtr.Zero)
                    : client1.Initialize(AUDCLNT_SHAREMODE_SHARED, AUDCLNT_STREAMFLAGS_EVENTCALLBACK, hns, 0, pFormat, IntPtr.Zero);
                Marshal.ThrowExceptionForHR(initHr);

                IntPtr hEvent = CreateEvent(IntPtr.Zero, false, false, null);
                if (hEvent == IntPtr.Zero) throw new InvalidOperationException("CreateEvent failed.");
                lock (_evtLock) _hEvent = hEvent;
                Marshal.ThrowExceptionForHR(haveC2 ? client2.SetEventHandle(hEvent) : client1.SetEventHandle(hEvent));

                Guid iidCap = IID_IAudioCaptureClient;
                object capObj;
                Marshal.ThrowExceptionForHR(haveC2 ? client2.GetService(ref iidCap, out capObj) : client1.GetService(ref iidCap, out capObj));
                capture = (IAudioCaptureClient)capObj; captureObj = capObj;

                Marshal.ThrowExceptionForHR(haveC2 ? client2.Start() : client1.Start());
                started = true;
                clientForStartStop = clientObj;

                // init complete — release the caller
                _initDone.Set();

                CaptureLoop(capture);
            }
            catch (Exception ex)
            {
                _initError = ex;
                _initDone.Set();   // unblock Start() even on failure
            }
            finally
            {
                // NOTE: a raw-path RCW satisfies BOTH interface casts (QI succeeds for IAudioClient
                // on an IAudioClient2 object), so use else-if to Stop() exactly once.
                try
                {
                    if (started && clientForStartStop is IAudioClient2 c2) c2.Stop();
                    else if (started && clientForStartStop is IAudioClient c1) c1.Stop();
                }
                catch { }
                if (pFormat != IntPtr.Zero) { try { Marshal.FreeCoTaskMem(pFormat); } catch { } }
                lock (_evtLock)
                {
                    if (_hEvent != IntPtr.Zero) { try { CloseHandle(_hEvent); } catch { } _hEvent = IntPtr.Zero; }
                }
                if (captureObj != null) { try { Marshal.ReleaseComObject(captureObj); } catch { } }
                if (clientObj != null) { try { Marshal.ReleaseComObject(clientObj); } catch { } }
                if (deviceObj != null) { try { Marshal.ReleaseComObject(deviceObj); } catch { } }
                if (enumObj != null) { try { Marshal.ReleaseComObject(enumObj); } catch { } }
                try { CoUninitialize(); } catch { }
            }
        }

        private void ReadFormat(IntPtr pFormat)
        {
            // Base WAVEFORMATEX: wFormatTag(0) nChannels(2) nSamplesPerSec(4) nAvgBytesPerSec(8)
            //                    nBlockAlign(12) wBitsPerSample(14) cbSize(16)
            ushort tag = (ushort)Marshal.ReadInt16(pFormat, 0);
            Channels = (ushort)Marshal.ReadInt16(pFormat, 2);
            SampleRate = Marshal.ReadInt32(pFormat, 4);
            _blockAlign = (ushort)Marshal.ReadInt16(pFormat, 12);
            _bits = (ushort)Marshal.ReadInt16(pFormat, 14);
            if (Channels < 1) Channels = 1;

            if (tag == WAVE_FORMAT_IEEE_FLOAT) _isFloat = true;
            else if (tag == WAVE_FORMAT_PCM) _isFloat = false;
            else if (tag == WAVE_FORMAT_EXTENSIBLE)
            {
                // WAVEFORMATEXTENSIBLE.SubFormat GUID at offset 24.
                var sub = new byte[16];
                Marshal.Copy(pFormat + 24, sub, 0, 16);
                var subGuid = new Guid(sub);
                _isFloat = subGuid == KSDATAFORMAT_SUBTYPE_IEEE_FLOAT;
            }
            else _isFloat = _bits == 32;   // best-effort
        }

        private void CaptureLoop(IAudioCaptureClient capture)
        {
            while (_running)
            {
                uint wait = WaitForSingleObject(_hEvent, 200);
                if (!_running) break;
                if (wait != WAIT_OBJECT_0) continue;   // timeout — re-check _running

                uint packet;
                if (capture.GetNextPacketSize(out packet) != 0) continue;
                while (packet > 0 && _running)
                {
                    IntPtr pData; uint frames; AudioClientBufferFlags flags; ulong devPos, qpcPos;
                    int hr = capture.GetBuffer(out pData, out frames, out flags, out devPos, out qpcPos);
                    if (hr != 0) break;

                    if (frames > 0)
                    {
                        if (_mono.Length < frames) _mono = new float[frames];
                        if ((flags & AudioClientBufferFlags.Silent) != 0)
                        {
                            Array.Clear(_mono, 0, (int)frames);
                        }
                        else
                        {
                            int bytes = (int)frames * _blockAlign;
                            if (_scratch.Length < bytes) _scratch = new byte[bytes];
                            Marshal.Copy(pData, _scratch, 0, bytes);
                            Downmix(_scratch, (int)frames);
                        }
                        try { MonoAvailable?.Invoke(_mono, (int)frames); } catch { }
                    }

                    capture.ReleaseBuffer(frames);
                    if (capture.GetNextPacketSize(out packet) != 0) break;
                }
            }
        }

        private void Downmix(byte[] buf, int frames)
        {
            int ch = Channels;
            int bps = _bits / 8;
            for (int f = 0; f < frames; f++)
            {
                int baseIdx = f * _blockAlign;
                double sum = 0;
                for (int c = 0; c < ch; c++)
                {
                    int idx = baseIdx + c * bps;
                    double v;
                    if (_isFloat) v = BitConverter.ToSingle(buf, idx);
                    else if (bps == 2) v = BitConverter.ToInt16(buf, idx) / 32768.0;
                    else if (bps == 4) v = BitConverter.ToInt32(buf, idx) / 2147483648.0;
                    else if (bps == 3)
                    {
                        int s24 = buf[idx] | (buf[idx + 1] << 8) | ((sbyte)buf[idx + 2] << 16);
                        v = s24 / 8388608.0;
                    }
                    else v = 0;
                    sum += v;
                }
                _mono[f] = (float)(sum / ch);
            }
        }

        // ── Win32 / COM ──────────────────────────────────────────────────────────────
        private const uint COINIT_MULTITHREADED = 0x0;
        private const uint CLSCTX_ALL = 0x17;
        private const int AUDCLNT_SHAREMODE_SHARED = 0;
        private const uint AUDCLNT_STREAMFLAGS_EVENTCALLBACK = 0x00040000;
        private const int AUDIO_STREAM_CATEGORY_Other = 0;
        private const ushort WAVE_FORMAT_PCM = 1;
        private const ushort WAVE_FORMAT_IEEE_FLOAT = 3;
        private const ushort WAVE_FORMAT_EXTENSIBLE = 0xFFFE;
        private const uint WAIT_OBJECT_0 = 0;

        private static readonly Guid CLSID_MMDeviceEnumerator = new Guid("BCDE0395-E52F-467C-8E3D-C4579291692E");
        private static readonly Guid IID_IAudioClient = new Guid("1CB9AD4C-DBFA-4C32-B178-C2F568A703B2");
        private static readonly Guid IID_IAudioClient2 = new Guid("726778CD-F60A-4EDA-82DE-E47610CD78AA");
        private static readonly Guid IID_IAudioCaptureClient = new Guid("C8ADBD64-E71E-48A0-A4DE-185C395CD317");
        private static readonly Guid KSDATAFORMAT_SUBTYPE_IEEE_FLOAT = new Guid("00000003-0000-0010-8000-00AA00389B71");

        [DllImport("ole32.dll")] private static extern int CoInitializeEx(IntPtr r, uint c);
        [DllImport("ole32.dll")] private static extern void CoUninitialize();
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern IntPtr CreateEvent(IntPtr attr, bool manualReset, bool initialState, string name);
        [DllImport("kernel32.dll", SetLastError = true)] private static extern bool SetEvent(IntPtr h);
        [DllImport("kernel32.dll", SetLastError = true)] private static extern bool CloseHandle(IntPtr h);
        [DllImport("kernel32.dll", SetLastError = true)] private static extern uint WaitForSingleObject(IntPtr h, uint ms);

        private enum EDataFlow { eRender, eCapture, eAll }
        private enum ERole { eConsole, eMultimedia, eCommunications }

        [StructLayout(LayoutKind.Sequential)]
        private struct AudioClientProperties
        {
            public uint cbSize;
            public int bIsOffload;           // BOOL
            public int eCategory;            // AUDIO_STREAM_CATEGORY
            public AudioClientStreamOptions Options;
        }
        private enum AudioClientStreamOptions { None = 0, Raw = 1, MatchFormat = 2, Ambisonics = 4 }

        [Flags]
        private enum AudioClientBufferFlags { None = 0, DataDiscontinuity = 1, Silent = 2, TimestampError = 4 }

        [ComImport, Guid("A95664D2-9614-4F35-A746-DE8DB63617E6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        private interface IMMDeviceEnumerator
        {
            [PreserveSig] int EnumAudioEndpoints(EDataFlow dataFlow, uint stateMask, out IntPtr devices);
            [PreserveSig] int GetDefaultAudioEndpoint(EDataFlow dataFlow, ERole role, out IMMDevice endpoint);
            [PreserveSig] int GetDevice([MarshalAs(UnmanagedType.LPWStr)] string id, out IMMDevice device);
            [PreserveSig] int RegisterEndpointNotificationCallback(IntPtr client);
            [PreserveSig] int UnregisterEndpointNotificationCallback(IntPtr client);
        }

        [ComImport, Guid("D666063F-1587-4E43-81F1-B948E807363F"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        private interface IMMDevice
        {
            [PreserveSig] int Activate(ref Guid iid, uint clsCtx, IntPtr activationParams,
                                       [MarshalAs(UnmanagedType.IUnknown)] out object iface);
            [PreserveSig] int OpenPropertyStore(uint access, out IntPtr props);
            [PreserveSig] int GetId([MarshalAs(UnmanagedType.LPWStr)] out string id);
            [PreserveSig] int GetState(out uint state);
        }

        [ComImport, Guid("1CB9AD4C-DBFA-4C32-B178-C2F568A703B2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        private interface IAudioClient
        {
            [PreserveSig] int Initialize(int shareMode, uint streamFlags, long bufferDuration, long periodicity, IntPtr format, IntPtr sessionGuid);
            [PreserveSig] int GetBufferSize(out uint frames);
            [PreserveSig] int GetStreamLatency(out long latency);
            [PreserveSig] int GetCurrentPadding(out uint padding);
            [PreserveSig] int IsFormatSupported(int shareMode, IntPtr format, out IntPtr closest);
            [PreserveSig] int GetMixFormat(out IntPtr format);
            [PreserveSig] int GetDevicePeriod(out long defaultPeriod, out long minimumPeriod);
            [PreserveSig] int Start();
            [PreserveSig] int Stop();
            [PreserveSig] int Reset();
            [PreserveSig] int SetEventHandle(IntPtr handle);
            [PreserveSig] int GetService(ref Guid iid, [MarshalAs(UnmanagedType.IUnknown)] out object service);
        }

        [ComImport, Guid("726778CD-F60A-4EDA-82DE-E47610CD78AA"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        private interface IAudioClient2
        {
            // IAudioClient (must repeat base vtable in order)
            [PreserveSig] int Initialize(int shareMode, uint streamFlags, long bufferDuration, long periodicity, IntPtr format, IntPtr sessionGuid);
            [PreserveSig] int GetBufferSize(out uint frames);
            [PreserveSig] int GetStreamLatency(out long latency);
            [PreserveSig] int GetCurrentPadding(out uint padding);
            [PreserveSig] int IsFormatSupported(int shareMode, IntPtr format, out IntPtr closest);
            [PreserveSig] int GetMixFormat(out IntPtr format);
            [PreserveSig] int GetDevicePeriod(out long defaultPeriod, out long minimumPeriod);
            [PreserveSig] int Start();
            [PreserveSig] int Stop();
            [PreserveSig] int Reset();
            [PreserveSig] int SetEventHandle(IntPtr handle);
            [PreserveSig] int GetService(ref Guid iid, [MarshalAs(UnmanagedType.IUnknown)] out object service);
            // IAudioClient2 additions
            [PreserveSig] int IsOffloadCapable(int category, out bool offloadCapable);
            [PreserveSig] int SetClientProperties(IntPtr properties);
            [PreserveSig] int GetBufferSizeLimits(IntPtr format, bool eventDriven, out long minDuration, out long maxDuration);
        }

        [ComImport, Guid("C8ADBD64-E71E-48A0-A4DE-185C395CD317"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        private interface IAudioCaptureClient
        {
            [PreserveSig] int GetBuffer(out IntPtr data, out uint numFrames, out AudioClientBufferFlags flags, out ulong devicePosition, out ulong qpcPosition);
            [PreserveSig] int ReleaseBuffer(uint numFrames);
            [PreserveSig] int GetNextPacketSize(out uint numFrames);
        }
    }
}
