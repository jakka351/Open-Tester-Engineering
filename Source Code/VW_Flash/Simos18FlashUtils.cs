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
 * Project Name:      VW_Flash
 * Original Author:   Bri3d
 * Source URL:        https://github.com/bri3d/VW_Flash
 * License:           BSD 2-Clause
 * ------------------------------------------------------------
 * MODIFICATIONS
 * ------------------------------------------------------------
 * The following modifications have been made from the original source:
 *
 * - Ported to C# from Python
 * - Refactored into modular architecture for CAN/UDS abstraction
 * - Removed platform-specific dependencies
 * - Adapted interfaces for integration with Open-Tester-Engineering
 * - [Add any file-specific changes here]
 *
 * ------------------------------------------------------------
 * LICENSE
 * ------------------------------------------------------------
 * This file is distributed under the terms of its original license.
 *
 * - GPL-licensed components remain subject to the GNU General Public License
 * - MIT-licensed components remain under the MIT License
 * - BSD 2-Clause License
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
/*
* BSD 2-Clause License
*Copyright (c) 2022-2024, Brian Ledbetter and contributors
*All rights reserved.
*Redistribution and use in source and binary forms, with or without
*modification, are permitted provided that the following conditions are met:
*1. Redistributions of source code must retain the above copyright notice, this
*   list of conditions and the following disclaimer.
*2. Redistributions in binary form must reproduce the above copyright notice,
*   this list of conditions and the following disclaimer in the documentation
*   and/or other materials provided with the distribution.
*THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
*AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
*IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
*DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
*FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
*DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
*SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
*CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
*OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
*OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*
*Please note that standalone software contained in the `lzss` sub-directory is licensed under the GNU General Public License.
*/
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//  Tester Present Specialist Automotive Solutions - VW Simos18 Flash Sequence Utilities
//  Workshop code generation, block transfer helpers, FRF block extraction, BIN/ODX export
//  Ported from VW_Flash by bri3d (GPL-3.0 License)
//  https://testerpresent.com.au | https://github.com/jakka351
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace TesterPresent.OBD2.UDS
{
    public static class Simos18FlashUtils
    {
        // ====================================================================================
        //  WORKSHOP CODE GENERATION
        // ====================================================================================

        /// <summary>
        /// Generate a VW workshop code for WriteDataByIdentifier (DID 0xF15A).
        /// Format: 9 bytes = [YearBCD, MonthBCD, DayBCD, Code1..Code5, CRC8].
        /// Bytes [3..7] (5 ASCII chars) are the workshop signature — we stamp "TSTR"
        /// (padded to 5 with '*') so every ECU we touch carries our fingerprint; handy
        /// for post-hoc verification and customer support traceability.
        /// </summary>
        public static byte[] GenerateWorkshopCode()
        {
            DateTime now = DateTime.Now;
            byte[] code = new byte[9];

            // Date in BCD format
            code[0] = ToBCD((byte)(now.Year % 100));
            code[1] = ToBCD((byte)now.Month);
            code[2] = ToBCD((byte)now.Day);

            // Workshop signature — 5 ASCII chars "TSTR*"
            // T = 0x54, S = 0x53, T = 0x54, R = 0x52, * = 0x2A
            code[3] = (byte)'T';
            code[4] = (byte)'S';
            code[5] = (byte)'T';
            code[6] = (byte)'R';
            code[7] = (byte)'*';

            // CRC8 checksum of first 8 bytes
            byte crc = 0;
            for (int i = 0; i < 8; i++)
                crc ^= code[i];
            code[8] = crc;

            return code;
        }

        private static byte ToBCD(byte value)
        {
            return (byte)(((value / 10) << 4) | (value % 10));
        }

        // ====================================================================================
        //  FRF / ODX BLOCK EXTRACTION
        // ====================================================================================

        /// <summary>
        /// Extract firmware blocks from decrypted FRF/ODX content.
        /// The FRF contains a ZIP with ODX/SGO XML files that reference binary flash data.
        /// Returns a dictionary of block name -> block data.
        /// </summary>
        public static Dictionary<string, byte[]> ExtractBlocksFromODX(byte[] odxXmlData)
        {
            var blocks = new Dictionary<string, byte[]>();

            try
            {
                var doc = new XmlDocument();
                doc.LoadXml(Encoding.UTF8.GetString(odxXmlData));

                // Look for FLASH-DATA nodes which contain the binary firmware
                XmlNodeList flashNodes = doc.GetElementsByTagName("FLASH-DATA");
                if (flashNodes == null || flashNodes.Count == 0)
                    flashNodes = doc.GetElementsByTagName("DATA");

                foreach (XmlNode node in flashNodes)
                {
                    string id = node.Attributes != null && node.Attributes["ID"] != null
                        ? node.Attributes["ID"].Value : null;

                    // Get the hex-encoded binary data
                    string hexData = node.InnerText.Trim();
                    if (string.IsNullOrEmpty(hexData)) continue;

                    // Remove whitespace and convert from hex
                    hexData = hexData.Replace(" ", "").Replace("\r", "").Replace("\n", "").Replace("\t", "");
                    if (hexData.Length % 2 != 0) continue;

                    byte[] data = HexToBytes(hexData);
                    if (data != null && data.Length > 0)
                    {
                        string blockName = id ?? $"Block_{blocks.Count}";
                        blocks[blockName] = data;
                    }
                }
            }
            catch
            {
                // If ODX parsing fails, return empty
            }

            return blocks;
        }

        /// <summary>
        /// Extract blocks from a raw binary file using profile BinFileOffset definitions.
        /// Works for ALL profiles — Simos 8/10/12/12.2/16/18/18.10/18.41, DQ250, DQ381, Haldex.
        /// </summary>
        public static Dictionary<int, byte[]> ExtractBlocksFromBinary(byte[] fullBinary, VWECUProfile profile)
        {
            var blocks = new Dictionary<int, byte[]>();

            // Check if the binary matches the profile's expected BIN file size
            if (fullBinary.Length < 1024) return blocks; // Too small

            foreach (var kvp in profile.Blocks)
            {
                if (kvp.Key == 0) continue; // Skip SBOOT
                var blockDef = kvp.Value;
                if (blockDef.Size == 0) continue;

                uint offset = blockDef.BinFileOffset;
                if (offset + blockDef.Size > fullBinary.Length) continue;

                byte[] blockData = new byte[blockDef.Size];
                Array.Copy(fullBinary, (int)offset, blockData, 0, (int)blockDef.Size);

                // Basic validation: check if the block is not all 0xFF (erased)
                bool hasContent = false;
                for (int i = 0; i < Math.Min(256, blockData.Length); i++)
                {
                    if (blockData[i] != 0xFF) { hasContent = true; break; }
                }
                if (hasContent)
                    blocks[kvp.Key] = blockData;
            }

            return blocks;
        }

        /// <summary>
        /// Match FRF block names from extracted ZIP/ODX files to profile block definitions.
        /// Returns dictionary of block number -> block data.
        /// </summary>
        public static Dictionary<int, byte[]> MatchFRFBlocksToProfile(Dictionary<string, byte[]> frfBlocks, VWECUProfile profile)
        {
            var matched = new Dictionary<int, byte[]>();

            foreach (var blockDef in profile.Blocks)
            {
                if (blockDef.Value.FRFBlockName == null) continue;

                foreach (var frfEntry in frfBlocks)
                {
                    // Match by FRF block name (case-insensitive, partial match)
                    if (frfEntry.Key.IndexOf(blockDef.Value.FRFBlockName, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        matched[blockDef.Key] = frfEntry.Value;
                        break;
                    }
                }
            }

            return matched;
        }

        // ====================================================================================
        //  BIN FILE EXPORT
        // ====================================================================================

        /// <summary>
        /// Assemble individual blocks into a full BIN file and save to disk.
        /// Uses the profile's BinFileOffset definitions for correct block placement.
        /// </summary>
        public static bool ExportToBinFile(Dictionary<int, byte[]> blockData, VWECUProfile profile, string outputPath)
        {
            try
            {
                byte[] fullBin = Simos18Crypto.AssembleFullBin(blockData, profile);
                File.WriteAllBytes(outputPath, fullBin);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Export individual blocks as separate binary files.
        /// Files are named: {prefix}_{blockNumber}_{blockName}.bin
        /// </summary>
        public static int ExportBlockFiles(Dictionary<int, byte[]> blockData, VWECUProfile profile, string outputDir, string prefix = "block")
        {
            int count = 0;
            if (!Directory.Exists(outputDir))
                Directory.CreateDirectory(outputDir);

            foreach (var kvp in blockData)
            {
                var blockDef = profile.GetBlock(kvp.Key);
                string name = blockDef != null ? blockDef.Name : $"Block{kvp.Key}";
                string fileName = $"{prefix}_{kvp.Key}_{name}.bin";
                string fullPath = Path.Combine(outputDir, fileName);

                try
                {
                    File.WriteAllBytes(fullPath, kvp.Value);
                    count++;
                }
                catch { }
            }

            return count;
        }

        // ====================================================================================
        //  ODX EXPORT (rebuild XML from block data)
        // ====================================================================================

        /// <summary>
        /// Export block data as a minimal ODX/SGO XML file.
        /// This creates a simple XML structure with hex-encoded FLASH-DATA nodes.
        /// </summary>
        public static bool ExportToODX(Dictionary<int, byte[]> blockData, VWECUProfile profile, string outputPath)
        {
            try
            {
                var sb = new StringBuilder();
                sb.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
                sb.AppendLine($"<!-- Exported by TesterPresent v2.0 from {profile.Name} -->");
                sb.AppendLine($"<!-- Date: {DateTime.Now:yyyy-MM-dd HH:mm:ss} -->");
                sb.AppendLine("<ODX version=\"2.0.0\">");
                sb.AppendLine("  <FLASH>");
                sb.AppendLine($"    <ECU-VARIANT>{profile.Name}</ECU-VARIANT>");
                sb.AppendLine($"    <PROJECT>{profile.ProjectName}</PROJECT>");

                foreach (var kvp in blockData)
                {
                    var blockDef = profile.GetBlock(kvp.Key);
                    string name = blockDef != null ? blockDef.Name : $"Block{kvp.Key}";
                    string frfName = blockDef != null && blockDef.FRFBlockName != null ? blockDef.FRFBlockName : $"FD_{kvp.Key}";

                    sb.AppendLine($"    <FLASH-DATA ID=\"{frfName}\">");
                    sb.AppendLine($"      <SHORT-NAME>{name}</SHORT-NAME>");
                    sb.AppendLine($"      <BLOCK-NUMBER>{kvp.Key}</BLOCK-NUMBER>");
                    if (blockDef != null)
                    {
                        sb.AppendLine($"      <BASE-ADDRESS>0x{blockDef.BaseAddress:X8}</BASE-ADDRESS>");
                        sb.AppendLine($"      <SIZE>{blockDef.Size}</SIZE>");
                    }

                    // Hex-encode the binary data (wrapped at 64 chars per line)
                    string hex = BytesToHex(kvp.Value);
                    sb.Append("      <DATA>");
                    for (int i = 0; i < hex.Length; i += 64)
                    {
                        int len = Math.Min(64, hex.Length - i);
                        sb.AppendLine();
                        sb.Append("        ");
                        sb.Append(hex.Substring(i, len));
                    }
                    sb.AppendLine();
                    sb.AppendLine("      </DATA>");
                    sb.AppendLine("    </FLASH-DATA>");
                }

                sb.AppendLine("  </FLASH>");
                sb.AppendLine("</ODX>");

                File.WriteAllText(outputPath, sb.ToString(), Encoding.UTF8);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // ====================================================================================
        //  FRF FULL PIPELINE — Decrypt FRF, extract all blocks, match to profile
        // ====================================================================================

        /// <summary>
        /// Complete FRF extraction pipeline:
        /// 1. Decrypt FRF using key material
        /// 2. Extract ZIP contents
        /// 3. Parse ODX/SGO XML files for FLASH-DATA
        /// 4. Match blocks to profile definitions
        /// Returns matched block dictionary, or null on failure.
        /// Also returns raw decrypted ZIP entries via out parameter.
        /// </summary>
        public static Dictionary<int, byte[]> ProcessFRFFile(byte[] frfData, byte[] keyMaterial, VWECUProfile profile,
            out Dictionary<string, byte[]> zipEntries, out string errorMessage)
        {
            zipEntries = null;
            errorMessage = null;

            try
            {
                // Step 1: Decrypt
                byte[] decrypted = Simos18Crypto.DecryptFRF(frfData, keyMaterial);
                if (!Simos18Crypto.IsValidZip(decrypted))
                {
                    errorMessage = "FRF decryption failed — result is not a valid ZIP. Check key file.";
                    return null;
                }

                // Step 2: Extract ZIP
                zipEntries = Simos18Crypto.ExtractZipEntries(decrypted);

                // Step 3: Extract blocks from ODX/SGO XML files
                var allBlocks = new Dictionary<string, byte[]>();
                foreach (var entry in zipEntries)
                {
                    string ext = Path.GetExtension(entry.Key).ToLower();
                    if (ext == ".odx" || ext == ".sgo" || ext == ".xml")
                    {
                        var extracted = ExtractBlocksFromODX(entry.Value);
                        foreach (var b in extracted)
                            allBlocks[b.Key] = b.Value;
                    }
                    else
                    {
                        allBlocks[Path.GetFileNameWithoutExtension(entry.Key)] = entry.Value;
                    }
                }

                if (allBlocks.Count == 0)
                {
                    errorMessage = "FRF decrypted but no blocks found in ODX content";
                    return null;
                }

                // Step 4: Match to profile
                var matched = MatchFRFBlocksToProfile(allBlocks, profile);
                if (matched.Count == 0)
                {
                    // Fall back: assign by index
                    matched = new Dictionary<int, byte[]>();
                    int idx = 1;
                    foreach (var b in allBlocks)
                        matched[idx++] = b.Value;
                    errorMessage = $"Matched {allBlocks.Count} blocks by index (no FRF name match)";
                }

                return matched;
            }
            catch (Exception ex)
            {
                errorMessage = $"FRF processing error: {ex.Message}";
                return null;
            }
        }

        /// <summary>
        /// Try to load a FRF file and extract the box code / software version from it.
        /// Used to verify the FRF matches the ECU before patch operations.
        /// </summary>
        public static string ExtractFRFBoxCode(byte[] frfData, byte[] keyMaterial)
        {
            try
            {
                byte[] decrypted = Simos18Crypto.DecryptFRF(frfData, keyMaterial);
                if (!Simos18Crypto.IsValidZip(decrypted)) return null;

                var entries = Simos18Crypto.ExtractZipEntries(decrypted);
                foreach (var entry in entries)
                {
                    string ext = Path.GetExtension(entry.Key).ToLower();
                    if (ext == ".odx" || ext == ".sgo" || ext == ".xml")
                    {
                        // Look for the box code / part number in the XML
                        string xml = Encoding.UTF8.GetString(entry.Value);
                        // Common ODX tags for identification
                        string[] searchTags = { "PART-NUMBER", "BOX-CODE", "LOGICAL-BLOCK-ID", "SW-VERSION" };
                        foreach (string tag in searchTags)
                        {
                            int startIdx = xml.IndexOf($"<{tag}>", StringComparison.OrdinalIgnoreCase);
                            if (startIdx >= 0)
                            {
                                int tagEnd = startIdx + tag.Length + 2;
                                int endIdx = xml.IndexOf($"</{tag}>", tagEnd, StringComparison.OrdinalIgnoreCase);
                                if (endIdx > tagEnd)
                                    return xml.Substring(tagEnd, endIdx - tagEnd).Trim();
                            }
                        }
                    }
                }
            }
            catch { }
            return null;
        }

        // ====================================================================================
        //  UDS FLASH SEQUENCE HELPERS
        // ====================================================================================

        /// <summary>Build the erase routine option record for a VW block</summary>
        public static byte[] BuildEraseOptionRecord(byte blockIdentifier)
        {
            return new byte[] { blockIdentifier };
        }

        /// <summary>Build RequestDownload (0x34) parameters for a VW block</summary>
        public static byte[] BuildVWRequestDownload(byte blockIdentifier, uint dataLength, byte compressionType, byte encryptionType)
        {
            byte dfi = (byte)((compressionType << 4) | encryptionType);
            return new byte[]
            {
                0x34,
                dfi,
                0x44,  // addressAndLengthFormatIdentifier: 4-byte address, 4-byte length
                0x00,  // Block identifier high byte (always 0 for VW)
                0x00,
                0x00,
                blockIdentifier,
                (byte)((dataLength >> 24) & 0xFF),
                (byte)((dataLength >> 16) & 0xFF),
                (byte)((dataLength >> 8) & 0xFF),
                (byte)(dataLength & 0xFF)
            };
        }

        /// <summary>Build RequestDownload for patch mode (no compression, encrypted)</summary>
        public static byte[] BuildPatchRequestDownload(byte blockIdentifier, uint dataLength, byte encryptionType)
        {
            // Patch mode: compression=0, encryption=profile type
            byte dfi = (byte)((0x00 << 4) | encryptionType);
            return new byte[]
            {
                0x34,
                dfi,
                0x44,
                0x00,
                0x00,
                0x00,
                blockIdentifier,
                (byte)((dataLength >> 24) & 0xFF),
                (byte)((dataLength >> 16) & 0xFF),
                (byte)((dataLength >> 8) & 0xFF),
                (byte)(dataLength & 0xFF)
            };
        }

        /// <summary>Build checksum verification routine option record</summary>
        public static byte[] BuildChecksumVerifyRecord(byte blockIdentifier, uint checksum)
        {
            return new byte[]
            {
                blockIdentifier,
                0x00,
                0x04,
                (byte)((checksum >> 24) & 0xFF),
                (byte)((checksum >> 16) & 0xFF),
                (byte)((checksum >> 8) & 0xFF),
                (byte)(checksum & 0xFF)
            };
        }

        /// <summary>Read identification DIDs from a VW ECU</summary>
        public static readonly ushort[] IdentificationDIDs = new ushort[]
        {
            VWDIDs.VIN,
            VWDIDs.AppSoftwareVersion,
            VWDIDs.ECUHardwareNumber,
            VWDIDs.SparePartNumber,
            VWDIDs.SystemName,
            VWDIDs.BootloaderID,
            VWDIDs.ODXFileVersion,
        };

        // ====================================================================================
        //  DSG KEY TABLE HANDLING
        // ====================================================================================

        /// <summary>
        /// Load a DSG substitution cipher key table from file.
        /// The key file must be exactly 256 bytes.
        /// </summary>
        public static byte[] LoadDSGKeyTable(string filePath)
        {
            if (!File.Exists(filePath)) return null;
            byte[] data = File.ReadAllBytes(filePath);
            if (data.Length != 256) return null;
            return data;
        }

        /// <summary>
        /// Search common locations for the DSG key file.
        /// Returns the key table or null if not found.
        /// </summary>
        public static byte[] FindDSGKeyTable()
        {
            // Check common relative paths
            string[] searchPaths = {
                "mqb_dsg_key.bin",
                Path.Combine("Data", "mqb_dsg_key.bin"),
                Path.Combine("Keys", "mqb_dsg_key.bin"),
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "mqb_dsg_key.bin"),
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "mqb_dsg_key.bin"),
            };

            foreach (string path in searchPaths)
            {
                byte[] key = LoadDSGKeyTable(path);
                if (key != null) return key;
            }

            return null;
        }

        // ====================================================================================
        //  CUSTOM KEY/IV PARSING
        // ====================================================================================

        /// <summary>
        /// Parse a hex string into a byte array (for custom AES key/IV input).
        /// Accepts formats: "AA BB CC DD", "AABBCCDD", "AA-BB-CC-DD"
        /// </summary>
        public static byte[] ParseHexString(string hex)
        {
            if (string.IsNullOrWhiteSpace(hex)) return null;
            hex = hex.Replace(" ", "").Replace("-", "").Replace("0x", "").Replace("0X", "").Trim();
            if (hex.Length % 2 != 0) return null;
            return HexToBytes(hex);
        }

        /// <summary>
        /// Validate a custom AES key (must be 16 bytes / 128-bit)
        /// </summary>
        public static bool ValidateAESKey(byte[] key)
        {
            return key != null && key.Length == 16;
        }

        /// <summary>
        /// Validate a custom AES IV (must be 16 bytes / 128-bit)
        /// </summary>
        public static bool ValidateAESIV(byte[] iv)
        {
            return iv != null && iv.Length == 16;
        }

        // ====================================================================================
        //  UTILITY
        // ====================================================================================

        private static byte[] HexToBytes(string hex)
        {
            if (string.IsNullOrEmpty(hex) || hex.Length % 2 != 0) return null;
            byte[] bytes = new byte[hex.Length / 2];
            for (int i = 0; i < bytes.Length; i++)
                bytes[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            return bytes;
        }

        /// <summary>Convert byte array to hex string without separators</summary>
        public static string BytesToHex(byte[] data)
        {
            if (data == null) return "";
            var sb = new StringBuilder(data.Length * 2);
            foreach (byte b in data)
                sb.Append(b.ToString("X2"));
            return sb.ToString();
        }

        /// <summary>Format byte array as hex string with spaces</summary>
        public static string ToHexString(byte[] data)
        {
            if (data == null) return "";
            return BitConverter.ToString(data).Replace("-", " ");
        }

        /// <summary>Format size in human-readable form</summary>
        public static string FormatSize(long bytes)
        {
            if (bytes < 1024) return $"{bytes} B";
            if (bytes < 1024 * 1024) return $"{bytes / 1024.0:F1} KB";
            return $"{bytes / (1024.0 * 1024.0):F1} MB";
        }
    }
}
