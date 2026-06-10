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
//  Tester Present Specialist Automotive Solutions - VW Simos18 Checksum Validation & Fixing
//  CRC32 (Simos polynomial 0x4C11DB7), zlib CRC32, JAMCRC (DQ250), 16-bit sum (Haldex)
//  Ported from VW_Flash by bri3d (GPL-3.0 License)
//  https://testerpresent.com.au | https://github.com/jakka351
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;

namespace TesterPresent.OBD2.UDS
{
    public static class Simos18Checksum
    {
        // ====================================================================================
        //  SIMOS CRC32 (Polynomial 0x4C11DB7 — NOT standard zlib/Ethernet CRC)
        // ====================================================================================

        /// <summary>CRC32 lookup table using polynomial 0x04C11DB7 (VW/Simos)</summary>
        private static readonly uint[] CrcTab = GenerateCrcTable();

        private static uint[] GenerateCrcTable()
        {
            uint[] table = new uint[256];
            for (uint i = 0; i < 256; i++)
            {
                uint crc = i << 24;
                for (int j = 0; j < 8; j++)
                {
                    if ((crc & 0x80000000) != 0)
                        crc = (crc << 1) ^ 0x04C11DB7;
                    else
                        crc <<= 1;
                }
                table[i] = crc;
            }
            return table;
        }

        /// <summary>Compute CRC32 using Simos polynomial (0x4C11DB7). Init=0, FinalXor=0.</summary>
        public static uint CRC32Simos(byte[] data, int offset, int length)
        {
            uint crc = 0x00000000;
            for (int i = offset; i < offset + length; i++)
                crc = ((crc << 8) & 0xFFFFFF00) ^ CrcTab[((crc >> 24) & 0xFF) ^ data[i]];
            return crc;
        }

        /// <summary>Compute CRC32 for entire byte array</summary>
        public static uint CRC32Simos(byte[] data)
        {
            return CRC32Simos(data, 0, data.Length);
        }

        // ====================================================================================
        //  SIMOS BLOCK CHECKSUM VALIDATION & FIXING
        // ====================================================================================

        /// <summary>Checksum area definition: start_address, end_address pair</summary>
        public struct ChecksumArea
        {
            public uint StartAddress;
            public uint EndAddress;
        }

        /// <summary>
        /// Read checksum metadata from a Simos block.
        /// Format at checksumLocation: [4:initial_value] [4:current_crc] [4:area_count] [pairs of start/end addresses]
        /// </summary>
        public static bool ReadSimosChecksumInfo(byte[] blockData, uint checksumLocation, uint blockBaseAddress,
            out uint storedChecksum, out ChecksumArea[] areas)
        {
            storedChecksum = 0;
            areas = null;

            if (blockData == null || checksumLocation + 12 > blockData.Length)
                return false;

            uint offset = checksumLocation;

            // Initial value (not used for validation, just stored)
            // uint initialValue = ReadLE32(blockData, offset);

            // Current stored checksum
            storedChecksum = ReadLE32(blockData, offset + 4);

            // Number of checksum areas
            uint areaCount = ReadLE32(blockData, offset + 8);

            if (areaCount == 0 || areaCount > 16 || offset + 12 + areaCount * 8 > blockData.Length)
                return false;

            areas = new ChecksumArea[areaCount];
            for (uint i = 0; i < areaCount; i++)
            {
                uint areaOffset = offset + 12 + i * 8;
                uint startAddr = ReadLE32(blockData, areaOffset);
                uint endAddr = ReadLE32(blockData, areaOffset + 4);

                // Convert from absolute addresses to relative offsets
                areas[i] = new ChecksumArea
                {
                    StartAddress = startAddr - blockBaseAddress,
                    EndAddress = endAddr - blockBaseAddress
                };
            }

            return true;
        }

        /// <summary>
        /// Validate the CRC32 checksum of a Simos block.
        /// Returns true if checksum matches, false if mismatch or cannot validate.
        /// </summary>
        public static bool ValidateSimosChecksum(byte[] blockData, Simos18Block blockDef, out uint computed, out uint stored)
        {
            computed = 0;
            stored = 0;

            if (blockDef.ChecksumLocation == 0 && blockDef.BlockNumber > 2)
            {
                // ASW2/ASW3 blocks store checksum at offset 0x0
                // These use a different layout — checksum covers the entire block
                return ValidateSimosChecksumAtOffset(blockData, 0x0, blockDef.BaseAddress, out computed, out stored);
            }
            else if (blockDef.ChecksumLocation > 0)
            {
                return ValidateSimosChecksumAtOffset(blockData, blockDef.ChecksumLocation, blockDef.BaseAddress, out computed, out stored);
            }

            return false;
        }

        private static bool ValidateSimosChecksumAtOffset(byte[] blockData, uint csLocation, uint baseAddress,
            out uint computed, out uint stored)
        {
            computed = 0;
            stored = 0;

            ChecksumArea[] areas;
            if (!ReadSimosChecksumInfo(blockData, csLocation, baseAddress, out stored, out areas))
                return false;

            // Compute CRC32 over all checksum areas
            uint crc = 0;
            foreach (var area in areas)
            {
                if (area.StartAddress >= blockData.Length || area.EndAddress >= blockData.Length)
                    return false;

                int start = (int)area.StartAddress;
                int end = (int)area.EndAddress;
                if (end <= start) continue;

                // Accumulate CRC across all areas
                for (int i = start; i <= end; i++)
                    crc = ((crc << 8) & 0xFFFFFF00) ^ CrcTab[((crc >> 24) & 0xFF) ^ blockData[i]];
            }

            computed = crc;
            return computed == stored;
        }

        /// <summary>
        /// Fix (update) the CRC32 checksum in a Simos block to match the actual data.
        /// Returns true if checksum was updated successfully.
        /// </summary>
        public static bool FixSimosChecksum(byte[] blockData, Simos18Block blockDef)
        {
            uint csLocation = blockDef.ChecksumLocation;
            if (csLocation == 0 && blockDef.BlockNumber > 2)
                csLocation = 0x0;

            if (csLocation + 12 > blockData.Length)
                return false;

            ChecksumArea[] areas;
            uint oldChecksum;
            if (!ReadSimosChecksumInfo(blockData, csLocation, blockDef.BaseAddress, out oldChecksum, out areas))
                return false;

            // Zero out the stored checksum before computing
            blockData[csLocation + 4] = 0;
            blockData[csLocation + 5] = 0;
            blockData[csLocation + 6] = 0;
            blockData[csLocation + 7] = 0;

            // Compute new CRC32 over all areas
            uint crc = 0;
            foreach (var area in areas)
            {
                int start = (int)area.StartAddress;
                int end = (int)area.EndAddress;
                if (start < 0 || end >= blockData.Length || end <= start) continue;

                for (int i = start; i <= end; i++)
                    crc = ((crc << 8) & 0xFFFFFF00) ^ CrcTab[((crc >> 24) & 0xFF) ^ blockData[i]];
            }

            // Write new checksum
            WriteLE32(blockData, csLocation + 4, crc);
            return true;
        }

        // ====================================================================================
        //  STANDARD ZLIB CRC32 (for DQ381 blocks)
        // ====================================================================================

        private static readonly uint[] ZlibCrcTable = GenerateZlibCrcTable();

        private static uint[] GenerateZlibCrcTable()
        {
            uint[] table = new uint[256];
            for (uint i = 0; i < 256; i++)
            {
                uint crc = i;
                for (int j = 0; j < 8; j++)
                {
                    if ((crc & 1) != 0)
                        crc = (crc >> 1) ^ 0xEDB88320;
                    else
                        crc >>= 1;
                }
                table[i] = crc;
            }
            return table;
        }

        /// <summary>Compute standard zlib CRC32 (polynomial 0xEDB88320, reflected)</summary>
        public static uint CRC32Zlib(byte[] data, int offset, int length)
        {
            uint crc = 0xFFFFFFFF;
            for (int i = offset; i < offset + length; i++)
                crc = (crc >> 8) ^ ZlibCrcTable[(crc ^ data[i]) & 0xFF];
            return ~crc;
        }

        /// <summary>Compute standard zlib CRC32 for entire byte array</summary>
        public static uint CRC32Zlib(byte[] data)
        {
            return CRC32Zlib(data, 0, data.Length);
        }

        // ====================================================================================
        //  DQ381 CHECKSUM — Standard CRC32, stored big-endian at offset 0x44
        // ====================================================================================

        /// <summary>
        /// Validate DQ381 block checksum.
        /// DQ381 stores a standard zlib CRC32 at offset 0x44 (big-endian).
        /// The checksum covers the entire block excluding the 4 checksum bytes.
        /// </summary>
        public static bool ValidateDQ381Checksum(byte[] blockData, uint checksumOffset, out uint computed, out uint stored)
        {
            computed = 0;
            stored = 0;

            if (blockData == null || checksumOffset + 4 > blockData.Length)
                return false;

            // Read stored checksum (big-endian)
            stored = ReadBE32(blockData, checksumOffset);

            // Compute CRC32 over data before and after the checksum field
            uint crc = 0xFFFFFFFF;

            // Before checksum
            for (int i = 0; i < (int)checksumOffset; i++)
                crc = (crc >> 8) ^ ZlibCrcTable[(crc ^ blockData[i]) & 0xFF];

            // After checksum (skip the 4 checksum bytes)
            for (int i = (int)checksumOffset + 4; i < blockData.Length; i++)
                crc = (crc >> 8) ^ ZlibCrcTable[(crc ^ blockData[i]) & 0xFF];

            computed = ~crc;
            return computed == stored;
        }

        /// <summary>
        /// Fix DQ381 block checksum — recompute and store at offset 0x44 (big-endian).
        /// </summary>
        public static bool FixDQ381Checksum(byte[] blockData, uint checksumOffset)
        {
            if (blockData == null || checksumOffset + 4 > blockData.Length)
                return false;

            // Zero out checksum before computing
            blockData[checksumOffset] = 0;
            blockData[checksumOffset + 1] = 0;
            blockData[checksumOffset + 2] = 0;
            blockData[checksumOffset + 3] = 0;

            // Compute CRC32 over entire block (checksum bytes are zero)
            uint crc = CRC32Zlib(blockData, 0, blockData.Length);

            // Write checksum big-endian
            WriteBE32(blockData, checksumOffset, crc);
            return true;
        }

        // ====================================================================================
        //  DQ250 JAMCRC — ~CRC32 (bitwise NOT of standard CRC32)
        // ====================================================================================

        /// <summary>
        /// Compute DQ250 JAMCRC: 0xFFFFFFFF ^ CRC32 = bitwise NOT of standard CRC32.
        /// Also known as JAMCRC in the Boost CRC library.
        /// </summary>
        public static uint JAMCRC(byte[] data, int offset, int length)
        {
            // JAMCRC = CRC32 without the final XOR step
            // Which is the same as ~CRC32Zlib() since CRC32Zlib already does ~crc at the end
            // So JAMCRC = ~~crc = crc (the raw accumulator before final NOT)
            uint crc = 0xFFFFFFFF;
            for (int i = offset; i < offset + length; i++)
                crc = (crc >> 8) ^ ZlibCrcTable[(crc ^ data[i]) & 0xFF];
            return crc; // No final NOT — that's what makes JAMCRC different from standard CRC32
        }

        /// <summary>Compute DQ250 JAMCRC for entire byte array</summary>
        public static uint JAMCRC(byte[] data)
        {
            return JAMCRC(data, 0, data.Length);
        }

        // ====================================================================================
        //  HALDEX 16-BIT CHECKSUM
        // ====================================================================================

        /// <summary>Compute Haldex 16-bit checksum: 0xFFFF - sum of all 16-bit words</summary>
        public static ushort ChecksumHaldex16(byte[] data, int offset, int length)
        {
            uint sum = 0;
            for (int i = offset; i < offset + length - 1; i += 2)
            {
                sum += (uint)(data[i] | (data[i + 1] << 8));
            }
            if (length % 2 != 0)
                sum += data[offset + length - 1];
            return (ushort)(0xFFFF - (sum & 0xFFFF));
        }

        // ====================================================================================
        //  UNIFIED CHECKSUM FOR BLOCK (dispatches by profile/block type)
        // ====================================================================================

        /// <summary>
        /// Compute the appropriate checksum for a block based on the profile type.
        /// Returns the checksum value to send during the verification routine.
        /// </summary>
        public static uint ComputeBlockChecksum(byte[] blockData, Simos18Block blockDef, VWECUProfile profile)
        {
            if (profile is DQ381Profile)
            {
                // DQ381: standard zlib CRC32, big-endian
                return CRC32Zlib(blockData);
            }
            else if (profile is DQ250MQBProfile)
            {
                // DQ250: JAMCRC (NOT of CRC32)
                return JAMCRC(blockData);
            }
            else if (profile is Haldex4MotionProfile)
            {
                // Haldex: 16-bit additive checksum (return as uint)
                return ChecksumHaldex16(blockData, 0, blockData.Length);
            }
            else
            {
                // All Simos variants: CRC32 with Simos polynomial 0x4C11DB7
                return CRC32Simos(blockData);
            }
        }

        /// <summary>
        /// Validate and optionally fix the checksum for a block, dispatching by profile type.
        /// Returns true if checksum is valid (or was fixed successfully).
        /// </summary>
        public static bool ValidateBlockChecksum(byte[] blockData, Simos18Block blockDef, VWECUProfile profile,
            out uint computed, out uint stored, bool autoFix = false)
        {
            computed = 0;
            stored = 0;

            if (profile is DQ381Profile)
            {
                bool valid = ValidateDQ381Checksum(blockData, blockDef.ChecksumLocation, out computed, out stored);
                if (!valid && autoFix)
                {
                    FixDQ381Checksum(blockData, blockDef.ChecksumLocation);
                    valid = true;
                    computed = stored; // After fix they match
                }
                return valid;
            }
            else if (profile is DQ250MQBProfile)
            {
                // DQ250 blocks don't have embedded checksums in the same way
                // The checksum is sent during the verification routine
                computed = JAMCRC(blockData);
                stored = computed; // No stored checksum to compare
                return true;
            }
            else if (profile is Haldex4MotionProfile)
            {
                // Haldex uses simple 16-bit sum — no embedded checksum structure
                computed = ChecksumHaldex16(blockData, 0, blockData.Length);
                stored = computed;
                return true;
            }
            else
            {
                // Simos variants: use the existing Simos CRC32 validation
                bool valid = ValidateSimosChecksum(blockData, blockDef, out computed, out stored);
                if (!valid && autoFix)
                {
                    FixSimosChecksum(blockData, blockDef);
                    valid = true;
                }
                return valid;
            }
        }

        // ====================================================================================
        //  ECM3 64-BIT SUMMATION CHECKSUM (Simos CAL monitoring — Level 2 protection)
        //
        //  Ref: lib/checksum.py:validate_ecm3 + locate_ecm3_with_asw1.
        //  The ECM3 monitoring task in ASW continuously recomputes a 64-bit summation
        //  across specific regions of ASW and CAL. The expected value is stored as a
        //  split 64-bit word at [CAL offset 0x408..0x40F] (high 32 at +0, low 32 at +4
        //  relative to 0x408 — i.e. checksum_location 0x400 + 8 .. +16).
        //
        //  Address list layout options (chosen by whichever is populated):
        //    (a) Old cars / CAL-resident — addresses live at CAL[0x418..] i.e.
        //        checksum_location 0x400 + 24. Detected by CAL[0x418..0x41B] != 0.
        //    (b) New cars / ASW1-resident — addresses live at ASW1[0x520..] (or 0x540
        //        for "early" cars).
        //
        //  Addresses are absolute; ASW caches at offset 0x20000000 on newer Simos so the
        //  raw address may need to be unwrapped. We try uncached first, fall back to
        //  cached-subtract.
        //
        //  Per-area the sum walks 32-bit LE words from start_address to end_address (excl).
        //  The final sum includes the "initial value" from CAL[0x408..0x40F].
        // ====================================================================================

        /// <summary>
        /// Compute ECM3 64-bit summation checksum for Simos calibration blocks.
        /// This is a pure 64-bit add of all 32-bit words in the data range.
        /// Used by the ECU runtime for CAL monitoring (not flash verification).
        /// </summary>
        public static ulong ECM3Checksum64(byte[] data, int offset, int length)
        {
            ulong sum = 0;
            for (int i = offset; i < offset + length - 3; i += 4)
            {
                uint word = (uint)(data[i] | (data[i + 1] << 8) | (data[i + 2] << 16) | (data[i + 3] << 24));
                sum += word;
            }
            return sum;
        }

        /// <summary>
        /// Compute the ECM3 address list for a CAL + ASW1 block pair. Returns pairs of
        /// (start_offset, end_offset) relative to CAL. Returns null if the addresses
        /// can't be located or all resolve to negative offsets.
        /// </summary>
        /// <param name="asw1">ASW1 block bytes (may be null — then CAL-resident lookup only)</param>
        /// <param name="cal">CAL block bytes</param>
        /// <param name="calBaseAddress">Absolute flash base of the CAL block (profile.Blocks[5].BaseAddress)</param>
        /// <param name="isEarly">true = use 0x540 offset into ASW1, false = 0x520</param>
        public static int[] LocateEcm3Areas(byte[] asw1, byte[] cal, uint calBaseAddress, bool isEarly)
        {
            if (cal == null || cal.Length < 0x420) return null;
            uint csLoc = 0x400;
            uint areaCount = ReadLE32(cal, csLoc + 16);
            if (areaCount == 0 || areaCount > 32) return null;

            byte[] addrSource;
            uint addrBase;
            // Prefer CAL-resident addresses when present (older ECUs).
            uint calProbe = ReadLE32(cal, csLoc + 24);
            if (calProbe > 0)
            {
                addrSource = cal;
                addrBase = csLoc + 24;
            }
            else
            {
                if (asw1 == null) return null;
                addrSource = asw1;
                addrBase = isEarly ? (uint)0x540 : (uint)0x520;
            }

            const uint CacheOffset = 0x20000000;
            var pairs = new int[areaCount * 2];
            for (int i = 0; i < areaCount * 2; i++)
            {
                uint addr = ReadLE32(addrSource, addrBase + (uint)(i * 4));
                long rel = (long)addr - calBaseAddress;
                if (rel < 0) rel = (long)(addr + CacheOffset) - calBaseAddress;  // hm, actually subtract cache — reference adds
                if (rel < 0)
                {
                    // Try cached address — reference adds cached offset to addr first then subtracts base.
                    rel = (long)addr - CacheOffset - calBaseAddress;
                }
                if (rel < 0 || rel > int.MaxValue) return null;
                pairs[i] = (int)rel;
            }
            return pairs;
        }

        /// <summary>
        /// Validate and optionally fix the ECM3 Level-2 CAL monitoring checksum.
        /// Writes the corrected 64-bit sum to CAL[0x408..0x40F] (split high/low 32-bit LE).
        /// Returns true if the checksum was valid or successfully fixed.
        /// </summary>
        public static bool ValidateAndFixEcm3(byte[] asw1, byte[] cal, uint calBaseAddress, bool shouldFix, out ulong computed, out ulong stored)
        {
            computed = 0; stored = 0;
            if (cal == null || cal.Length < 0x420) return false;
            uint csLoc = 0x400;

            int[] areas = LocateEcm3Areas(asw1, cal, calBaseAddress, isEarly: false);
            if (areas == null) areas = LocateEcm3Areas(asw1, cal, calBaseAddress, isEarly: true);
            if (areas == null) return false;

            // Initial value (hi:lo at +8/+12 from csLoc)
            ulong sum = ((ulong)ReadLE32(cal, csLoc + 8) << 32) + ReadLE32(cal, csLoc + 12);

            for (int i = 0; i + 1 < areas.Length; i += 2)
            {
                int start = areas[i], end = areas[i + 1];
                if (start < 0 || end > cal.Length || end <= start) return false;
                for (int j = start; j + 3 < end; j += 4)
                {
                    uint word = (uint)(cal[j] | (cal[j + 1] << 8) | (cal[j + 2] << 16) | (cal[j + 3] << 24));
                    sum += word;
                }
            }

            // Old ECM3 stored its embedded checksum at csLoc+56 — reference triggers that path
            // when cal[csLoc+56] > 0. Reproduce it here.
            uint storedLoc = csLoc;
            if (cal[csLoc + 56] > 0) storedLoc = csLoc + 56;

            stored = ((ulong)ReadLE32(cal, storedLoc) << 32) + ReadLE32(cal, storedLoc + 4);
            computed = sum;

            if (stored == sum) return true;
            if (!shouldFix) return false;

            WriteLE32(cal, storedLoc,     (uint)(sum >> 32));
            WriteLE32(cal, storedLoc + 4, (uint)(sum & 0xFFFFFFFFu));
            return true;
        }

        /// <summary>
        /// Recompute and write the CBOOT_TEMP secondary Simos CRC32 checksum at offset 0x340.
        /// Used after flashing CBOOT so the ECU's bootloader validation accepts the image
        /// on next power cycle. Assumes the block already has a valid primary checksum at
        /// 0x300 and the secondary header shares the same area definitions — mirrors the
        /// reference's double-checksum pass in simos_flash_utils.py:99-111.
        /// </summary>
        public static bool FixCbootTempSecondaryChecksum(byte[] cbootData, Simos18Block cbootBlockDef)
        {
            if (cbootData == null || cbootBlockDef == null) return false;
            var secondary = new Simos18Block
            {
                BlockNumber      = cbootBlockDef.BlockNumber,
                Name             = cbootBlockDef.Name + "_TEMP",
                BlockIdentifier  = cbootBlockDef.BlockIdentifier,
                BaseAddress      = cbootBlockDef.BaseAddress,
                Size             = cbootBlockDef.Size,
                TransferSize     = cbootBlockDef.TransferSize,
                ChecksumLocation = 0x340,
                FRFBlockName     = cbootBlockDef.FRFBlockName,
            };
            return FixSimosChecksum(cbootData, secondary);
        }

        // ====================================================================================
        //  UTILITY
        // ====================================================================================

        private static uint ReadLE32(byte[] data, uint offset)
        {
            return (uint)(data[offset] | (data[offset + 1] << 8) | (data[offset + 2] << 16) | (data[offset + 3] << 24));
        }

        private static void WriteLE32(byte[] data, uint offset, uint value)
        {
            data[offset] = (byte)(value & 0xFF);
            data[offset + 1] = (byte)((value >> 8) & 0xFF);
            data[offset + 2] = (byte)((value >> 16) & 0xFF);
            data[offset + 3] = (byte)((value >> 24) & 0xFF);
        }

        /// <summary>Read Big-Endian 32-bit value</summary>
        public static uint ReadBE32(byte[] data, uint offset)
        {
            return (uint)((data[offset] << 24) | (data[offset + 1] << 16) | (data[offset + 2] << 8) | data[offset + 3]);
        }

        /// <summary>Write Big-Endian 32-bit value</summary>
        public static void WriteBE32(byte[] data, uint offset, uint value)
        {
            data[offset] = (byte)((value >> 24) & 0xFF);
            data[offset + 1] = (byte)((value >> 16) & 0xFF);
            data[offset + 2] = (byte)((value >> 8) & 0xFF);
            data[offset + 3] = (byte)(value & 0xFF);
        }
    }
}
