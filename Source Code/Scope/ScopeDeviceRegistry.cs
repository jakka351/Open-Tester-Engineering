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
//  Tester Present Specialist Automotive Solutions — USB Oscilloscope HAL: backend registry
//  Copyright (c) 2026 Benjamin Jack Leighton. All rights reserved.
//
//  Mirrors the J2534DeviceFinder discipline: a static enumerator producing device POCOs for
//  the UI combo, plus a factory turning the chosen entry into a live IScopeDevice. Every
//  backend enumerates inside its own try/catch — a missing vendor SDK must never take the
//  tab down, it just reports why that backend is unavailable.
//
//  x86/x64 dual-bitness (report §3.3): vendor DLLs must match the process. Rather than
//  SetDllDirectory (process-global, could disturb the Guard/TPSecurity extraction paths),
//  PreloadVendorDlls LoadLibrary()s the correct-arch copy from drivers\scope\<arch>\ by
//  absolute path — a later P/Invoke by module name then binds to the already-loaded module.
//  Falls back to the normal search path (installed PicoSDK) when the folder isn't shipped.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Runtime.InteropServices;

namespace TesterPresent.OBD2.Scope
{
    public static class ScopeDeviceRegistry
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern IntPtr LoadLibrary(string fileName);

        private static bool _preloaded;
        private static readonly object _preloadLock = new object();

        /// <summary>Vendor DLL names the scope HAL may P/Invoke, resolved per report §3.3.</summary>
        private static readonly string[] VENDOR_DLLS = { "ps4000a.dll" };

        public static void PreloadVendorDlls(Action<string> log)
        {
            lock (_preloadLock)
            {
                if (_preloaded) return;
                _preloaded = true;
                string arch = Environment.Is64BitProcess ? "x64" : "x86";
                string dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "drivers", "scope", arch);
                foreach (var dll in VENDOR_DLLS)
                {
                    string shipped = Path.Combine(dir, dll);
                    IntPtr h = File.Exists(shipped) ? LoadLibrary(shipped) : IntPtr.Zero;
                    if (h == IntPtr.Zero) h = LoadLibrary(dll);   // installed SDK / PATH
                    log?.Invoke(h != IntPtr.Zero
                        ? $"{dll} loaded ({(File.Exists(shipped) ? shipped : "system search path")})"
                        : $"{dll} not found — PicoScope backend unavailable (install PicoSDK or ship drivers\\scope\\{arch}\\)");
                }
            }
        }

        /// <summary>
        /// One pass over every backend. Never throws; per-backend failures are logged and that
        /// backend simply contributes no devices. SCPI COM candidates are unprobed (a COM port
        /// might be anything) — probing happens at connect via *IDN?.
        /// </summary>
        public static List<ScopeDeviceInfo> EnumerateAll(Action<string> log)
        {
            PreloadVendorDlls(log);
            var all = new List<ScopeDeviceInfo>();

            try
            {
                foreach (var d in PicoScopeDevice.Enumerate()) all.Add(d);
            }
            catch (DllNotFoundException)
            {
                log?.Invoke("PicoScope: ps4000a.dll not present — backend skipped.");
            }
            catch (Exception ex)
            {
                log?.Invoke($"PicoScope enumeration failed: {ex.Message}");
            }

            try
            {
                foreach (var d in Hantek6022Device.Enumerate()) all.Add(d);
            }
            catch (Exception ex)
            {
                log?.Invoke($"Hantek enumeration failed: {ex.Message}");
            }

            try
            {
                foreach (var port in SerialPort.GetPortNames())
                    all.Add(ScpiScopeDevice.MakeSerialInfo(port));
            }
            catch (Exception ex)
            {
                log?.Invoke($"COM port enumeration failed: {ex.Message}");
            }

            all.Add(DemoScopeDevice.MakeDeviceInfo());
            return all;
        }

        /// <summary>UI text box "host", "host:port" → SCPI-over-LXI entry (Rigol 5555, Siglent/most 5025).</summary>
        public static ScopeDeviceInfo MakeScpiTcpInfo(string hostSpec)
        {
            if (string.IsNullOrWhiteSpace(hostSpec)) return null;
            hostSpec = hostSpec.Trim();
            int port = 5555;
            int colon = hostSpec.LastIndexOf(':');
            if (colon > 0 && int.TryParse(hostSpec.Substring(colon + 1), out var p))
            {
                port = p;
                hostSpec = hostSpec.Substring(0, colon);
            }
            return ScpiScopeDevice.MakeTcpInfo(hostSpec, port);
        }

        public static IScopeDevice CreateDevice(ScopeDeviceInfo info)
        {
            if (info == null) throw new ArgumentNullException(nameof(info));
            switch (info.Backend)
            {
                case ScopeBackendKind.PicoPs4000a: return new PicoScopeDevice();
                case ScopeBackendKind.Scpi: return new ScpiScopeDevice();
                case ScopeBackendKind.Hantek6022: return new Hantek6022Device();
                case ScopeBackendKind.Demo: return new DemoScopeDevice();
                default: throw new NotSupportedException($"Unknown scope backend {info.Backend}.");
            }
        }
    }
}
