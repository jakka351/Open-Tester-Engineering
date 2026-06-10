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
 * Project Name:      HondaReflashTool
 * Original Author:   bouletmarc
 * Source URL:        https://github.com/bouletmarc/HondaReflashTool
 * License:           None
 *
 * ------------------------------------------------------------
 * MODIFICATIONS
 * ------------------------------------------------------------
 * The following modifications have been made from the original source:
 *
 * - Ported to C# from C#
 * - Refactored into modular architecture for CAN/UDS abstraction
 * - Removed platform-specific dependencies
 * - Adapted interfaces for integration with Open-Tester-Engineering
 *
 * ------------------------------------------------------------
 * LICENSE
 * ------------------------------------------------------------
 * This file is distributed under the terms of its original license.
 *
 * - GPL-licensed components remain subject to the GNU General Public License
 * - MIT-licensed components remain under the MIT License
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
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace TesterPresent.OBD2.UDS
{
    // ==========================================================================
    //  Honda Security Access Algorithms
    //  Ported from HondaReflashTool — Class_Cypher.cs
    //
    //  Algorithm 0x27,0x01 : 16-bit seed/key with 3 parameters (k0, k1, k2)
    //                        sourced from the ECUS_KEYS.txt database.
    //  Algorithm 0x27,0x41 : 32-bit seed/key with rotation operations;
    //                        ECU_Byte selects the parameter set.
    // ==========================================================================
    internal static class HondaKeyAlgorithm
    {
        // ------------------------------------------------------------------
        //  Algorithm 0x27,0x01 — 16-bit
        //  Formula: (((k2 != 0 ? seed*k1 % k2 : seed*k1) ^ (seed+k0)) & 0xFFFF)
        //  Seed: 2 bytes (big-endian), Key: 2 bytes (big-endian)
        // ------------------------------------------------------------------
        public static ushort GetKey01(ushort seed, ushort k0, ushort k1, ushort k2)
        {
            // Native TPSecurity.dll path first — falls back to the managed
            // implementation below on any failure.
            if (SecurityNative.TryHonda2701(seed, k0, k1, k2, out ushort nativeKey))
                return nativeKey;

            int s = seed;
            int result = (((k2 != 0 ? s * k1 % k2 : s * k1) ^ (s + k0)) & 0xFFFF);
            return (ushort)result;
        }

        // ------------------------------------------------------------------
        //  Algorithm 0x27,0x41 — 32-bit
        //  Formula: (RotL(KB1+seed, p1) ^ RotR(KB2+seed, p2) ^
        //            (seed & 0xFFFF) * (seed >> 16)) + FinalAdder
        //  Seed: 4 bytes, Key: 4 bytes
        //  ECU_Byte selects which parameter set to use.
        // ------------------------------------------------------------------
        public static uint GetKey41(uint seed, byte ecuByte)
        {
            if (SecurityNative.TryHonda2741(seed, ecuByte, out uint nativeKey))
                return nativeKey;

            uint rotL, rotR;
            uint keyBytes1, keyBytes2, finalAdder;

            switch (ecuByte)
            {
                case 1: // Civic 06-10
                    rotL = 2; rotR = 0;
                    keyBytes1 = 2920096767U;  // AE 0D 23 FF -> LE 0xFF230DAE
                    keyBytes2 = 1080383667U;  // 40 65 58 B3 -> LE 0xB3586540
                    finalAdder = 0;
                    break;

                case 4: // Ridgeline 06-13
                    rotL = 1; rotR = 0;
                    keyBytes1 = 379890608U;   // 16 A4 AB B0
                    keyBytes2 = 3219675757U;  // BF E8 5A 6D
                    finalAdder = 0;
                    break;

                case 8: // CR-V 07-10
                    rotL = 2; rotR = 0;
                    keyBytes1 = 0x6D7532ACU;  // bytes: AC 32 75 6D (LE)
                    keyBytes2 = 0x9D623B64U;  // bytes: 64 3B 62 9D (LE)
                    finalAdder = 0;
                    break;

                case 26: // RDX 07-12
                    rotL = 2; rotR = 0;
                    keyBytes1 = 0x67E976C1U;  // bytes: C1 76 E9 67 (LE)
                    keyBytes2 = 0x783E1739U;  // bytes: 39 17 3E 78 (LE)
                    finalAdder = 0;
                    break;

                case 32: // Freed 11-13
                    rotL = 3; rotR = 0;
                    keyBytes1 = 0x95583E2CU;  // bytes: 2C 3E 58 95 (LE)
                    keyBytes2 = 0xF396B56FU;  // bytes: 6F B5 96 F3 (LE)
                    finalAdder = 0;
                    break;

                case 2: // Unknown — error case in original
                default: // Generic/fallback
                    rotL = 2; rotR = 0;
                    keyBytes1 = 3129510011U;
                    keyBytes2 = 0;
                    finalAdder = 955378367U;
                    break;
            }

            uint left = RotateLeft32(keyBytes1 + seed, (int)rotL);
            uint right = RotateRight32(keyBytes2 + seed, (int)rotR);
            return (left ^ right ^ (seed & 0xFFFFU) * (seed >> 16)) + finalAdder;
        }

        // ------------------------------------------------------------------
        //  32-bit rotation helpers (from Class_Cypher.smethod_3 / smethod_4)
        // ------------------------------------------------------------------
        private static uint RotateLeft32(uint value, int shift)
        {
            shift &= 31;
            return (value << shift) | (value >> (32 - shift));
        }

        private static uint RotateRight32(uint value, int shift)
        {
            shift &= 31;
            return (value >> shift) | (value << (32 - shift));
        }
    }

    // ==========================================================================
    //  Honda ECU Key Database Entry
    // ==========================================================================
    internal class HondaEcuKeyEntry
    {
        public string EcuId { get; set; }         // e.g. "37805-RBB-A530"
        public ushort K0 { get; set; }
        public ushort K1 { get; set; }
        public ushort K2 { get; set; }
        public string Description { get; set; }    // info field from ECUS_KEYS.txt

        public override string ToString()
        {
            return string.Format("{0}  K0={1:X4} K1={2:X4} K2={3:X4}  ({4})",
                EcuId, K0, K1, K2, Description);
        }
    }

    // ==========================================================================
    //  Searchable database of 4,749 Honda ECU key entries
    //  Loaded from embedded resource ECUS_KEYS.txt
    // ==========================================================================
    internal static class HondaEcuKeyDatabase
    {
        private static readonly List<HondaEcuKeyEntry> _entries;
        private static readonly Dictionary<string, HondaEcuKeyEntry> _lookup;

        static HondaEcuKeyDatabase()
        {
            _entries = new List<HondaEcuKeyEntry>(5000);
            _lookup = new Dictionary<string, HondaEcuKeyEntry>(5000, StringComparer.OrdinalIgnoreCase);

            try
            {
                // Try embedded resource first
                var asm = Assembly.GetExecutingAssembly();
                string resourceName = null;
                foreach (var name in asm.GetManifestResourceNames())
                {
                    if (name.EndsWith("ECUS_KEYS.txt", StringComparison.OrdinalIgnoreCase))
                    {
                        resourceName = name;
                        break;
                    }
                }

                string[] lines = null;
                if (resourceName != null)
                {
                    using (var stream = asm.GetManifestResourceStream(resourceName))
                    using (var reader = new StreamReader(stream, Encoding.UTF8))
                    {
                        lines = reader.ReadToEnd().Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    }
                }
                else
                {
                    // Fallback: try loading from file next to executable
                    string filePath = Path.Combine(Path.GetDirectoryName(asm.Location), "ECUS_KEYS.txt");
                    if (!File.Exists(filePath))
                        filePath = Path.Combine(Path.GetDirectoryName(asm.Location), "UDS", "ECUS_KEYS.txt");
                    if (File.Exists(filePath))
                        lines = File.ReadAllLines(filePath);
                }

                if (lines != null)
                {
                    foreach (string line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;
                        string[] parts = line.Split('|');
                        if (parts.Length < 2) continue;

                        string ecuId = parts[0].TrimEnd('.', ' ');
                        string hex = parts[1].Trim();
                        if (hex.Length < 12) continue;

                        try
                        {
                            ushort k0 = Convert.ToUInt16(hex.Substring(0, 4), 16);
                            ushort k1 = Convert.ToUInt16(hex.Substring(4, 4), 16);
                            ushort k2 = Convert.ToUInt16(hex.Substring(8, 4), 16);

                            string desc = parts.Length >= 3 ? parts[2].Trim() : "";

                            var entry = new HondaEcuKeyEntry
                            {
                                EcuId = ecuId,
                                K0 = k0,
                                K1 = k1,
                                K2 = k2,
                                Description = desc
                            };

                            _entries.Add(entry);

                            // First match wins for exact lookup
                            if (!_lookup.ContainsKey(ecuId))
                                _lookup[ecuId] = entry;
                        }
                        catch { /* skip malformed lines */ }
                    }
                }
            }
            catch { /* database unavailable — will be empty */ }
        }

        /// <summary>All loaded entries.</summary>
        public static List<HondaEcuKeyEntry> Entries { get { return _entries; } }

        /// <summary>Number of loaded entries.</summary>
        public static int Count { get { return _entries.Count; } }

        /// <summary>Find entries matching a partial ECU ID string (case-insensitive).</summary>
        public static List<HondaEcuKeyEntry> Search(string query)
        {
            if (string.IsNullOrWhiteSpace(query)) return new List<HondaEcuKeyEntry>();
            string q = query.Trim().ToUpperInvariant();
            var results = new List<HondaEcuKeyEntry>();
            foreach (var e in _entries)
            {
                if (e.EcuId.ToUpperInvariant().Contains(q))
                    results.Add(e);
                if (results.Count >= 200) break; // cap results for UI performance
            }
            return results;
        }

        /// <summary>Find exact match by full ECU ID (case-insensitive).</summary>
        public static HondaEcuKeyEntry FindExact(string ecuId)
        {
            if (string.IsNullOrWhiteSpace(ecuId)) return null;
            string key = ecuId.TrimEnd('.', ' ');
            HondaEcuKeyEntry entry;
            _lookup.TryGetValue(key, out entry);
            return entry;
        }
    }
}
