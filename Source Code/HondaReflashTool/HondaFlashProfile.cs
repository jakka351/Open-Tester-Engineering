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
using System.IO.Compression;
using System.Linq;
using System.Text;

namespace TesterPresent.OBD2.UDS
{
    // ==========================================================================
    //  Honda ECU Type enumeration (CAN address bytes)
    //  From Class_RWD.cs lines 460-477
    // ==========================================================================
    internal enum HondaEcuType : byte
    {
        ShiftByWire  = 0x0B,
        ECM_CVT      = 0x0E,
        ECM_Manual   = 0x10,
        ECM_Auto     = 0x11,
        TCM          = 0x1E,
        VSA          = 0x28,
        EBB          = 0x2B,
        EPS          = 0x30,
        Unknown3A    = 0x3A,
        SRS          = 0x53,
        ODO          = 0x60,
        HUD          = 0x61,
        FwdRadar     = 0xB0,
        FwdCamera    = 0xB5,
        Gateway      = 0xEF,
    }

    // ==========================================================================
    //  Honda Flash Profile
    // ==========================================================================
    internal class HondaFlashProfile
    {
        public string Name { get; set; }
        public string Processor { get; set; }       // "SH7058", "SH72531", "TC179X"
        public int RomSize { get; set; }            // Total ROM bytes
        public int FirmwareSize { get; set; }       // Firmware-only area bytes
        public byte EcuByte { get; set; }           // ECU address byte for CAN
        public string Description { get; set; }
        public string TransmissionType { get; set; }

        /// <summary>29-bit CAN TX ID: 18DA[ECU]F1</summary>
        public uint TxId { get { return 0x18DA0000U | ((uint)EcuByte << 8) | 0xF1U; } }

        /// <summary>29-bit CAN RX ID: 18DAF1[ECU]</summary>
        public uint RxId { get { return 0x18DAF100U | (uint)EcuByte; } }

        /// <summary>Bootloader start offset — firmware starts after this in a full .bin</summary>
        public int BootloaderSize
        {
            get
            {
                if (RomSize <= 0x100000) return 0x8000;   // 1MB: 0x8000
                return 0x10000;                            // 2MB/4MB: 0x10000
            }
        }
    }

    // ==========================================================================
    //  Honda Flash Profile Registry — 9 profiles
    //  From GForm_PlatformSelect.cs
    // ==========================================================================
    internal static class HondaFlashProfileRegistry
    {
        public static readonly List<HondaFlashProfile> Profiles = new List<HondaFlashProfile>
        {
            new HondaFlashProfile { Name = "1MB SH7058 Manual",  Processor = "SH7058",  RomSize = 0x100000, FirmwareSize = 0xF8000,  EcuByte = 0x10, TransmissionType = "Manual",    Description = "1MB Keihin ECM (Manual)" },
            new HondaFlashProfile { Name = "1MB SH7058 Auto",    Processor = "SH7058",  RomSize = 0x100000, FirmwareSize = 0xF8000,  EcuByte = 0x11, TransmissionType = "Automatic",  Description = "1MB Keihin ECM (Auto)" },
            new HondaFlashProfile { Name = "1MB SH7058 CVT",     Processor = "SH7058",  RomSize = 0x100000, FirmwareSize = 0xF8000,  EcuByte = 0x0E, TransmissionType = "CVT",        Description = "1MB Keihin ECM (CVT)" },
            new HondaFlashProfile { Name = "2MB SH72531 Manual", Processor = "SH72531", RomSize = 0x200000, FirmwareSize = 0x1F0000, EcuByte = 0x10, TransmissionType = "Manual",    Description = "2MB Keihin/Denso ECM (Manual)" },
            new HondaFlashProfile { Name = "2MB SH72531 Auto",   Processor = "SH72531", RomSize = 0x200000, FirmwareSize = 0x1F0000, EcuByte = 0x11, TransmissionType = "Automatic",  Description = "2MB Keihin/Denso ECM (Auto)" },
            new HondaFlashProfile { Name = "2MB SH72531 CVT",    Processor = "SH72531", RomSize = 0x200000, FirmwareSize = 0x1F0000, EcuByte = 0x0E, TransmissionType = "CVT",        Description = "2MB Keihin/Denso ECM (CVT)" },
            new HondaFlashProfile { Name = "4MB TC179X Manual",  Processor = "TC179X",  RomSize = 0x280000, FirmwareSize = 0x270000, EcuByte = 0x10, TransmissionType = "Manual",    Description = "4MB Bosch ECM (Manual)" },
            new HondaFlashProfile { Name = "4MB TC179X Auto",    Processor = "TC179X",  RomSize = 0x280000, FirmwareSize = 0x270000, EcuByte = 0x11, TransmissionType = "Automatic",  Description = "4MB Bosch ECM (Auto)" },
            new HondaFlashProfile { Name = "4MB TC179X CVT",     Processor = "TC179X",  RomSize = 0x280000, FirmwareSize = 0x270000, EcuByte = 0x0E, TransmissionType = "CVT",        Description = "4MB Bosch ECM (CVT)" },
        };

        public static HondaFlashProfile FindByName(string name)
        {
            foreach (var p in Profiles)
                if (p.Name == name) return p;
            return null;
        }

        public static string[] GetNames()
        {
            string[] names = new string[Profiles.Count];
            for (int i = 0; i < Profiles.Count; i++)
                names[i] = Profiles[i].Name;
            return names;
        }
    }

    // ==========================================================================
    //  Honda RWD File Parser
    //  Ported from Class_RWD.LoadRWD()
    //
    //  RWD format (mode 0x5A):
    //    [5A 0D 0A]                 — magic bytes
    //    [header0..header5]          — 6 sections, each: [count] { [len][data] ... }
    //    [start_addr : 4 bytes BE]  — firmware start address
    //    [size : 4 bytes BE]        — firmware size
    //    [firmware_encrypted]       — encrypted firmware bytes
    //    [checksum : 4 bytes BE]    — file checksum (sum of all prior bytes)
    // ==========================================================================
    internal class HondaRwdFile
    {
        public bool IsValid { get; private set; }
        public string ErrorMessage { get; private set; }

        // Parsed header sections
        public byte[] Header0 { get; private set; }         // ECU type identifier
        public byte[] Header1 { get; private set; }         // Software version info
        public byte EcuByte { get; private set; }            // headers2[0] — CAN address byte
        public string[] SupportedVersions { get; private set; }
        public string[] SupportedFWKeys { get; private set; }
        public byte[] FirmwareKeys { get; private set; }     // 3 encryption keys (headers5)
        public byte[] FirmwareEncrypted { get; private set; }

        // Address info
        public uint StartAddress { get; private set; }
        public uint Size { get; private set; }

        // CAN IDs (derived from EcuByte)
        public uint TxId { get { return HondaCanProtocol.BuildTxId(EcuByte); } }
        public uint RxId { get { return HondaCanProtocol.BuildRxId(EcuByte); } }

        // Raw header bytes for BIN→RWD re-encoding
        public byte[] RwdHeaderBytes { get; private set; }

        /// <summary>Get the 3-byte write keys for WriteDataByIdentifier (0x2E F1 01)</summary>
        public byte[] GetWriteKeys()
        {
            return FirmwareKeys != null ? (byte[])FirmwareKeys.Clone() : new byte[0];
        }

        /// <summary>Load an RWD file from disk (supports .gz compressed)</summary>
        public static HondaRwdFile Load(string filePath)
        {
            try
            {
                byte[] data;
                string ext = Path.GetExtension(filePath).ToLowerInvariant();
                if (ext == ".gz" || filePath.ToLowerInvariant().Contains(".gz"))
                {
                    using (var fs = File.OpenRead(filePath))
                    using (var gz = new GZipStream(fs, CompressionMode.Decompress))
                    using (var ms = new MemoryStream())
                    {
                        gz.CopyTo(ms);
                        data = ms.ToArray();
                    }
                }
                else
                {
                    data = File.ReadAllBytes(filePath);
                }
                return Parse(data);
            }
            catch (Exception ex)
            {
                return new HondaRwdFile { IsValid = false, ErrorMessage = "Load error: " + ex.Message };
            }
        }

        /// <summary>Parse RWD from byte array</summary>
        public static HondaRwdFile Parse(byte[] data)
        {
            var rwd = new HondaRwdFile();
            try
            {
                if (data == null || data.Length < 20)
                {
                    rwd.IsValid = false;
                    rwd.ErrorMessage = "File too small";
                    return rwd;
                }

                // Check magic: 5A 0D 0A
                if (data[0] != 0x5A || data[1] != 0x0D || data[2] != 0x0A)
                {
                    rwd.IsValid = false;
                    rwd.ErrorMessage = string.Format("Invalid magic: {0:X2} {1:X2} {2:X2} (expected 5A 0D 0A)", data[0], data[1], data[2]);
                    return rwd;
                }

                // Parse 6 header sections
                byte[][] headers = new byte[6][];
                int idx = 3;

                for (int i = 0; i < 6; i++)
                {
                    var headerData = new List<byte>();
                    byte count = data[idx++];

                    for (int j = 0; j < count; j++)
                    {
                        int length = data[idx++];
                        // Prepend each value (same as Push in Class_RWD — inserts at front)
                        byte[] v = new byte[length];
                        Buffer.BlockCopy(data, idx, v, 0, length);
                        idx += length;

                        // Class_RWD.Push prepends new bytes — replicate that behavior
                        byte[] combined = new byte[v.Length + headerData.Count];
                        Buffer.BlockCopy(v, 0, combined, 0, v.Length);
                        if (headerData.Count > 0)
                            headerData.CopyTo(0, combined, v.Length, headerData.Count);
                        headerData = new List<byte>(combined);
                    }

                    headers[i] = headerData.ToArray();
                }

                rwd.Header0 = headers[0];
                rwd.Header1 = headers[1];

                // headers2[0] = ECU byte
                if (headers[2].Length > 0)
                    rwd.EcuByte = headers[2][0];

                // Start address and size (4 bytes BE each)
                rwd.StartAddress = ReadUInt32BE(data, idx); idx += 4;
                rwd.Size = ReadUInt32BE(data, idx); idx += 4;

                // Save raw header bytes for re-encoding
                rwd.RwdHeaderBytes = new byte[idx];
                Buffer.BlockCopy(data, 0, rwd.RwdHeaderBytes, 0, idx);

                // Encrypted firmware data (everything until last 4 bytes)
                int fwLen = data.Length - idx - 4;
                if (fwLen > 0)
                {
                    rwd.FirmwareEncrypted = new byte[fwLen];
                    Buffer.BlockCopy(data, idx, rwd.FirmwareEncrypted, 0, fwLen);
                    idx += fwLen;
                }
                else
                {
                    rwd.FirmwareEncrypted = new byte[0];
                }

                // Firmware keys (3 bytes from headers5)
                rwd.FirmwareKeys = headers[5];

                // Parse supported versions from headers3 (16 bytes per version)
                if (headers[3].Length >= 16)
                {
                    int versionCount = headers[3].Length / 16;
                    rwd.SupportedVersions = new string[versionCount];
                    for (int i = 0; i < versionCount; i++)
                    {
                        var buf = new byte[16];
                        int nonEmpty = 0;
                        for (int j = 0; j < 16; j++)
                        {
                            int idx3 = i * 16 + j;
                            if (idx3 >= headers[3].Length) break;
                            buf[j] = headers[3][idx3];
                            if (buf[j] != 0) nonEmpty++;
                        }
                        byte[] trimmed = new byte[nonEmpty];
                        int ti = 0;
                        for (int j = 0; j < 16 && ti < nonEmpty; j++)
                        {
                            if (buf[j] != 0)
                                trimmed[ti++] = buf[j];
                        }
                        rwd.SupportedVersions[i] = Encoding.ASCII.GetString(trimmed);
                    }
                }
                else
                {
                    rwd.SupportedVersions = new string[0];
                }

                // Parse supported firmware keys from headers4 (6 bytes per entry)
                if (headers[4].Length >= 6)
                {
                    int fwKeyCount = headers[4].Length / 6;
                    rwd.SupportedFWKeys = new string[fwKeyCount];
                    for (int i = 0; i < fwKeyCount; i++)
                    {
                        var sb = new StringBuilder(12);
                        for (int j = 0; j < 6; j++)
                        {
                            int idx4 = i * 6 + j;
                            if (idx4 >= headers[4].Length) break;
                            sb.Append(headers[4][idx4].ToString("X2"));
                        }
                        rwd.SupportedFWKeys[i] = sb.ToString();
                    }
                }
                else
                {
                    rwd.SupportedFWKeys = new string[0];
                }

                rwd.IsValid = true;
            }
            catch (Exception ex)
            {
                rwd.IsValid = false;
                rwd.ErrorMessage = "Parse error: " + ex.Message;
            }

            return rwd;
        }

        private static uint ReadUInt32BE(byte[] data, int offset)
        {
            return ((uint)data[offset] << 24) |
                   ((uint)data[offset + 1] << 16) |
                   ((uint)data[offset + 2] << 8) |
                   (uint)data[offset + 3];
        }
    }

    // ==========================================================================
    //  Honda Firmware Cipher — 4 known cipher types + brute-force auto-decrypt
    //  Ported from Class_RWD.decrypt() / _get_decoder()
    //
    //  Known ciphers (from Class_RWD.cs lines 1013-1016):
    //    Keihin:    (((i ^ k2) + k1) - k0) & 0xFF
    //    Hitachi:   (((i + k0) ^ k1) + k2) & 0xFF
    //    Panasonic: (((i + k2) + k1) ^ k0) & 0xFF
    //    Temic:     (((i ^ k2) ^ k1) - k0) & 0xFF
    // ==========================================================================
    internal enum HondaCipherType
    {
        Keihin,     // (((i ^ k2) + k1) - k0) & 0xFF
        Hitachi,    // (((i + k0) ^ k1) + k2) & 0xFF
        Panasonic,  // (((i + k2) + k1) ^ k0) & 0xFF
        Temic,      // (((i ^ k2) ^ k1) - k0) & 0xFF
    }

    internal static class HondaFirmwareCipher
    {
        /// <summary>Build a 256-byte decoder lookup table for the given cipher and keys.</summary>
        public static byte[] BuildDecoder(byte k0, byte k1, byte k2, HondaCipherType cipherType)
        {
            byte[] decoder = new byte[256];
            for (int i = 0; i < 256; i++)
            {
                uint d;
                switch (cipherType)
                {
                    case HondaCipherType.Keihin:
                        d = (uint)((((i ^ k2) + k1) - k0) & 0xFF);
                        break;
                    case HondaCipherType.Hitachi:
                        d = (uint)((((i + k0) ^ k1) + k2) & 0xFF);
                        break;
                    case HondaCipherType.Panasonic:
                        d = (uint)((((i + k2) + k1) ^ k0) & 0xFF);
                        break;
                    case HondaCipherType.Temic:
                        d = (uint)((((i ^ k2) ^ k1) - k0) & 0xFF);
                        break;
                    default:
                        d = (uint)i;
                        break;
                }
                decoder[i] = (byte)d;
            }
            return decoder;
        }

        /// <summary>Build the inverse encoder lookup table from a decoder.</summary>
        public static byte[] BuildEncoder(byte[] decoder)
        {
            byte[] encoder = new byte[256];
            for (int i = 0; i < 256; i++)
                encoder[decoder[i]] = (byte)i;
            return encoder;
        }

        /// <summary>Apply substitution cipher to data using a lookup table.</summary>
        public static byte[] Apply(byte[] data, byte[] table)
        {
            byte[] result = new byte[data.Length];
            for (int i = 0; i < data.Length; i++)
                result[i] = table[data[i]];
            return result;
        }

        /// <summary>
        /// Try all 4 cipher types with both key orderings to decrypt firmware.
        /// Validates by searching for the part number prefix in the decrypted output.
        /// Returns the first successful decryption, or null if none work.
        /// </summary>
        public static byte[] AutoDecrypt(byte[] encrypted, byte[] keys, string partNumberPrefix)
        {
            if (keys == null || keys.Length < 3 || encrypted == null || encrypted.Length == 0)
                return null;

            string searchExact = (partNumberPrefix ?? "").ToUpperInvariant();
            // Also build padded search (e.g., "37805-RBB" -> "3.7.8.0.5.-.R.B.B.")
            string searchPadded = "";
            foreach (char c in searchExact)
                searchPadded += c + ".";
            searchPadded = searchPadded.ToUpperInvariant();

            // Try two key orderings: normal (k2,k1,k0 as listed) and reversed (k0,k1,k2)
            byte[][] keyOrders = new byte[][]
            {
                new byte[] { keys[2], keys[1], keys[0] }, // reversed: k2, k1, k0
                new byte[] { keys[0], keys[1], keys[2] }, // forward: k0, k1, k2
            };

            HondaCipherType[] ciphers = new HondaCipherType[]
            {
                HondaCipherType.Keihin,
                HondaCipherType.Hitachi,
                HondaCipherType.Panasonic,
                HondaCipherType.Temic,
            };

            foreach (byte[] ko in keyOrders)
            {
                foreach (HondaCipherType cipher in ciphers)
                {
                    byte[] decoder = BuildDecoder(ko[0], ko[1], ko[2], cipher);

                    // Validate: all 256 values must be unique (bijective mapping)
                    bool[] seen = new bool[256];
                    bool valid = true;
                    for (int i = 0; i < 256; i++)
                    {
                        if (seen[decoder[i]]) { valid = false; break; }
                        seen[decoder[i]] = true;
                    }
                    if (!valid) continue;

                    byte[] decrypted = Apply(encrypted, decoder);

                    // Search for part number in decrypted data
                    string ascii = Encoding.ASCII.GetString(decrypted);
                    string upper = ascii.ToUpperInvariant();

                    if (!string.IsNullOrEmpty(searchExact) && upper.Contains(searchExact))
                        return decrypted;

                    if (!string.IsNullOrEmpty(searchPadded) && searchPadded.Length > 2 && upper.Contains(searchPadded.TrimEnd('.')))
                        return decrypted;
                }
            }

            return null; // No cipher/key combination worked
        }
    }

    // ==========================================================================
    //  Honda Checksum — negative-sum byte checksum
    //  Ported from Class_Checksums.cs / Class_RWD.GetChecksumFWBin()
    // ==========================================================================
    internal static class HondaChecksum
    {
        /// <summary>Get the checksum location based on data length.</summary>
        public static int GetChecksumLocation(int dataLength)
        {
            // From Class_Checksums.cs line 80-85
            switch (dataLength - 1)
            {
                case 0xF7FFF:  return 0x400;     // 1MB firmware-only (minus bootloader 0x8000)
                case 0xFFFFF:  return 0x8400;    // 1MB full bin
                case 0x1EFFFF: return 0x10012;   // 2MB firmware-only
                case 0x1FFFFF: return 0x10012;   // 2MB full bin
                case 0x26FFFF: return 0x2003E6;  // 4MB firmware-only
                case 0x27FFFF: return 0x2003E6;  // 4MB full bin
                default: return 0;
            }
        }

        /// <summary>
        /// Compute negative-sum checksum for Honda firmware.
        /// For each byte (except at checksumLocation), subtract from running total.
        /// If total goes negative, add 255.
        /// </summary>
        public static byte ComputeNegativeSum(byte[] data, int checksumLocation)
        {
            int b = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (i != checksumLocation)
                {
                    b -= data[i];
                    if (b < 0) b += 255;
                }
            }
            return (byte)b;
        }

        /// <summary>
        /// Verify and optionally fix the checksum in a firmware image.
        /// Returns true if checksum was already correct, false if it was fixed.
        /// </summary>
        public static bool VerifyAndFix(byte[] data, int checksumLocation, out byte expected, out byte actual)
        {
            actual = data[checksumLocation];
            expected = ComputeNegativeSum(data, checksumLocation);
            if (actual != expected)
            {
                data[checksumLocation] = expected;
                return false;
            }
            return true;
        }
    }

    // ==========================================================================
    //  Honda RWD Checksum — 4-byte big-endian sum of all bytes before checksum
    //  Ported from Class_RWD.Get_rwd_checksum()
    // ==========================================================================
    internal static class HondaRwdChecksum
    {
        /// <summary>Compute the RWD file checksum (sum of all bytes in range).</summary>
        public static uint Compute(byte[] data, int start, int length)
        {
            uint s = 0;
            for (int i = 0; i < length; i++)
            {
                s += data[start + i];
            }
            // Convert to big-endian representation (matches Class_RWD behavior)
            return s;
        }
    }

    // ==========================================================================
    //  Honda CAN Protocol helpers — 29-bit extended addressing
    //  From Class_RWD.cs and GForm_Main.cs
    // ==========================================================================
    internal static class HondaCanProtocol
    {
        /// <summary>Build 29-bit CAN TX ID: 18DA[ecuByte]F1</summary>
        public static uint BuildTxId(byte ecuByte)
        {
            return 0x18DA0000U | ((uint)ecuByte << 8) | 0xF1U;
        }

        /// <summary>Build 29-bit CAN RX ID: 18DAF1[ecuByte]</summary>
        public static uint BuildRxId(byte ecuByte)
        {
            return 0x18DAF100U | (uint)ecuByte;
        }

        /// <summary>Get CAN ID bytes for J2534 filter setup (4 bytes)</summary>
        public static byte[] IdToBytes(uint id)
        {
            return new byte[]
            {
                (byte)((id >> 24) & 0xFF),
                (byte)((id >> 16) & 0xFF),
                (byte)((id >> 8) & 0xFF),
                (byte)(id & 0xFF)
            };
        }

        /// <summary>Get ECU module description from ECU byte.</summary>
        public static string GetModuleDescription(byte ecuByte)
        {
            switch (ecuByte)
            {
                case 0x0B: return "Shift-by-Wire";
                case 0x0E: return "ECM (CVT Transmission)";
                case 0x10: return "ECM (Manual Transmission)";
                case 0x11: return "ECM (Automatic Transmission)";
                case 0x1E: return "TCM (Transmission Control Module)";
                case 0x28: return "VSA Module";
                case 0x2B: return "Electric Brake Booster";
                case 0x30: return "Electric Power Steering";
                case 0x3A: return "Unknown Module (0x3A)";
                case 0x53: return "SRS Module";
                case 0x60: return "Odometer Module";
                case 0x61: return "HUD Module";
                case 0xB0: return "Forward Radar Module";
                case 0xB5: return "Forward Camera Module";
                case 0xEF: return "Gateway Module";
                default: return string.Format("Unknown (0x{0:X2})", ecuByte);
            }
        }

        /// <summary>Honda UDS Service IDs (from Class_ODB.cs)</summary>
        public static class ServiceId
        {
            public const byte DiagnosticSessionControl = 0x10;
            public const byte EcuReset = 0x11;
            public const byte SecurityAccess = 0x27;
            public const byte WriteDataByIdentifier = 0x2E;
            public const byte RoutineControl = 0x31;
            public const byte RequestDownload = 0x34;
            public const byte TransferData = 0x36;
            public const byte RequestTransferExit = 0x37;
            public const byte ReadDataByAddress = 0x23;
        }

        /// <summary>Honda Diagnostic Session types</summary>
        public static class DiagSession
        {
            public const byte Default = 0x01;
            public const byte Programming = 0x02;
            public const byte Extended = 0x03;
        }

        /// <summary>Honda Security Access modes from GForm_Main.cs SetUnlockingMode()</summary>
        public static class SecurityMode
        {
            public const byte Mode01 = 0x01;   // 16-bit seed/key
            public const byte Mode03 = 0x03;
            public const byte Mode05 = 0x05;
            public const byte Mode41 = 0x41;   // 32-bit seed/key (rotation)
        }
    }
}
