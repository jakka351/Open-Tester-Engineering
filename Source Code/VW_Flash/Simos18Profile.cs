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
//  Tester Present Specialist Automotive Solutions - VW/Continental ECU Profile Definitions
//  Full profile library for Simos 8/10/12/12.2/16/18/18.10/18.41, DQ250 MQB, DQ381, Haldex 4Motion
//  Ported from VW_Flash by bri3d (GPL-3.0 License)
//  https://testerpresent.com.au | https://github.com/jakka351
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;

namespace TesterPresent.OBD2.UDS
{
    // ====================================================================================
    //  BLOCK DEFINITION
    // ====================================================================================

    /// <summary>Represents a single flash memory block in a Continental/VW ECU</summary>
    public class Simos18Block
    {
        public int BlockNumber { get; set; }
        public string Name { get; set; }
        public byte BlockIdentifier { get; set; }
        public uint BaseAddress { get; set; }
        public uint Size { get; set; }
        public int TransferSize { get; set; }
        public uint ChecksumLocation { get; set; }
        public string FRFBlockName { get; set; }
        public bool ShouldErase { get; set; } = true;
        public bool ShouldChecksum { get; set; } = true;
        /// <summary>Offset of this block within a full BIN file</summary>
        public uint BinFileOffset { get; set; }

        public override string ToString() => $"Block {BlockNumber} ({Name}) @ 0x{BaseAddress:X8} [{Size / 1024} KB]";
    }

    /// <summary>Prepared block data ready for UDS transfer (after checksum fix, compression, encryption)</summary>
    public class Simos18PreparedBlock
    {
        public Simos18Block BlockDef { get; set; }
        public byte[] RawData { get; set; }
        public byte[] PreparedData { get; set; }
        public uint Checksum { get; set; }
        public byte CompressionType { get; set; }
        public byte EncryptionType { get; set; }
        public bool IsValid { get; set; }
        public string Status { get; set; }
    }

    // ====================================================================================
    //  PATCH INFO — Write-Without-Erase Exploit Configuration
    // ====================================================================================

    /// <summary>Configuration for the write-without-erase CBOOT unlock exploit</summary>
    public class VWPatchInfo
    {
        /// <summary>FRF box code required for the patch (e.g. "8V0906259H__0001")</summary>
        public string PatchBoxCode { get; set; }
        /// <summary>Which block to patch (e.g. 4=ASW3 for S18, 2=ASW1 for S18.10)</summary>
        public int PatchBlockNumber { get; set; }
        /// <summary>Embedded patch binary data (loaded from resource)</summary>
        public byte[] PatchBinary { get; set; }
        /// <summary>Transfer size map for patch: offset_threshold -> transfer_size.
        /// 8 bytes for patch areas (ECC-correct), 256 bytes for fill areas.</summary>
        public SortedList<uint, int> PatchTransferSizes { get; set; }

        /// <summary>Get the transfer size for a given offset within the patch block</summary>
        public int GetTransferSizeForOffset(uint offset)
        {
            if (PatchTransferSizes == null || PatchTransferSizes.Count == 0) return 0x8;
            int result = 0x100; // default fill
            foreach (var kvp in PatchTransferSizes)
            {
                if (offset >= kvp.Key) result = kvp.Value;
                else break;
            }
            return result;
        }
    }

    // ====================================================================================
    //  CRYPTO TYPE ENUMERATION
    // ====================================================================================

    /// <summary>Encryption algorithm used by the ECU</summary>
    public enum VWCryptoType
    {
        None = 0,
        AES_CBC = 1,
        SimosXOR = 2,
        DSGSubstitution = 3
    }

    // ====================================================================================
    //  ECU PROFILE BASE
    // ====================================================================================

    /// <summary>Base class for VW/Continental ECU profiles. Extend this for new ECU types.</summary>
    public abstract class VWECUProfile
    {
        public abstract string Name { get; }
        public abstract string ProjectName { get; }
        public abstract uint TxId { get; }
        public abstract uint RxId { get; }
        /// <summary>
        /// UDS SecurityAccess sub-function for seed request. Reference VW_Flash uses
        /// level 17 (0x11) → seed, 0x12 → send key. The +1 pair for send-key is derived
        /// by the UDS layer automatically. Previously was 0x03 across all profiles which
        /// is wrong — Simos18 rejects that with subFunctionNotSupported.
        /// </summary>
        public abstract byte SecurityLevel { get; }
        public abstract byte[] SA2Script { get; }
        public abstract byte[] AESKey { get; }
        public abstract byte[] AESIV { get; }
        public abstract byte CompressionType { get; }
        public abstract byte EncryptionType { get; }
        public abstract Dictionary<int, Simos18Block> Blocks { get; }
        /// <summary>Full BIN file size for this ECU</summary>
        public virtual uint BinFileSize => 0x400000; // 4MB default
        /// <summary>Crypto algorithm type</summary>
        public virtual VWCryptoType CryptoType => VWCryptoType.AES_CBC;
        /// <summary>Patch info for write-without-erase exploit (null if not supported)</summary>
        public virtual VWPatchInfo PatchInfo => null;
        /// <summary>Whether this profile supports ECU unlock via CBOOT patching</summary>
        public bool SupportsUnlock => PatchInfo != null;

        /// <summary>
        /// Externally-supplied UDS checksum bytes per block (big-endian 4-byte). When
        /// populated, these override the self-computed CRC32 in the 0x31 0x01 0x02 0x02
        /// "CheckFlashMemoryDependencies" routine data record. Required for blocks that
        /// use an external UDS checksum (e.g. DQ250 DRIVER = F9 74 17 6E). Blocks not
        /// listed fall back to the runtime-computed value.
        /// </summary>
        public virtual Dictionary<int, byte[]> UdsChecksums => null;

        /// <summary>
        /// ISO-TP separation time (STmin) the ECU needs on this bus, in microseconds.
        /// Null = use the J2534 channel's current setting. DQ250 sits behind a gateway
        /// that requires 900 us minimum — the reference's constants.DSG_STMIN = 900_000
        /// nanoseconds maps to 0xF9 in the ISO-TP STmin byte. Applied by the flash
        /// sequence BEFORE the first TransferData.
        /// </summary>
        public virtual int? IsoTpStMinMicroseconds => null;

        /// <summary>Get writable blocks (excludes SBOOT which is never written)</summary>
        public List<Simos18Block> GetWritableBlocks()
        {
            var list = new List<Simos18Block>();
            foreach (var kvp in Blocks)
                if (kvp.Key > 0) list.Add(kvp.Value);
            return list;
        }

        /// <summary>Get a block by block number</summary>
        public Simos18Block GetBlock(int number)
        {
            Simos18Block b;
            return Blocks.TryGetValue(number, out b) ? b : null;
        }
    }

    // ====================================================================================
    //  SIMOS 18.1 / 18.6 PROFILE (SC8 Project)
    // ====================================================================================

    public class Simos18_1Profile : VWECUProfile
    {
        public override string Name => "Simos 18.1/18.6 (Continental)";
        public override string ProjectName => "SC8";
        public override uint TxId => 0x7E0;
        public override uint RxId => 0x7E8;
        public override byte SecurityLevel => 0x11;
        public override uint BinFileSize => 0x400000; // 4MB

        public override byte[] SA2Script => new byte[] {
            0x68, 0x02, 0x81, 0x4A, 0x10, 0x68, 0x04, 0x93,
            0x08, 0x08, 0x20, 0x09, 0x4A, 0x05, 0x87, 0x22,
            0x12, 0x19, 0x54, 0x82, 0x49, 0x93, 0x07, 0x12,
            0x20, 0x11, 0x82, 0x4A, 0x05, 0x87, 0x03, 0x11,
            0x20, 0x10, 0x82, 0x4A, 0x01, 0x81, 0x49, 0x4C
        };

        public override byte[] AESKey => new byte[] {
            0x98, 0xD3, 0x12, 0x02, 0xE4, 0x8E, 0x38, 0x54,
            0xF2, 0xCA, 0x56, 0x15, 0x45, 0xBA, 0x6F, 0x2F
        };

        public override byte[] AESIV => new byte[] {
            0xE7, 0x86, 0x12, 0x78, 0xC5, 0x08, 0x53, 0x27,
            0x98, 0xBC, 0xA4, 0xFE, 0x45, 0x1D, 0x20, 0xD1
        };

        public override byte CompressionType => 0x0A; // LZSS
        public override byte EncryptionType => 0x0A;   // AES-CBC

        public override VWPatchInfo PatchInfo => new VWPatchInfo
        {
            PatchBoxCode = "8V0906259H__0001",
            PatchBlockNumber = 4, // ASW3
            PatchTransferSizes = new SortedList<uint, int> {
                { 0x0000, 0x100 }, { 0x9600, 0x8 }, { 0x9800, 0x100 },
                { 0x7DD00, 0x8 }, { 0x7E200, 0x100 }, { 0x7F900, 0x8 }
            }
        };

        public override Dictionary<int, Simos18Block> Blocks => new Dictionary<int, Simos18Block>
        {
            { 0, new Simos18Block { BlockNumber = 0, Name = "SBOOT",      BlockIdentifier = 0x00, BaseAddress = 0x80000000, Size = 0,        TransferSize = 0xFFD, ChecksumLocation = 0x300, FRFBlockName = null,   BinFileOffset = 0x0,      ShouldErase = false, ShouldChecksum = false } },
            { 1, new Simos18Block { BlockNumber = 1, Name = "CBOOT",      BlockIdentifier = 0x01, BaseAddress = 0x8001C000, Size = 0x23E00,  TransferSize = 0xFFD, ChecksumLocation = 0x300, FRFBlockName = "FD_0", BinFileOffset = 0x1C000 } },
            { 2, new Simos18Block { BlockNumber = 2, Name = "ASW1",       BlockIdentifier = 0x02, BaseAddress = 0x80040000, Size = 0xFFC00,  TransferSize = 0xFFD, ChecksumLocation = 0x300, FRFBlockName = "FD_1", BinFileOffset = 0x40000 } },
            { 3, new Simos18Block { BlockNumber = 3, Name = "ASW2",       BlockIdentifier = 0x03, BaseAddress = 0x80140000, Size = 0xBFC00,  TransferSize = 0xFFD, ChecksumLocation = 0x0,   FRFBlockName = "FD_2", BinFileOffset = 0x140000 } },
            { 4, new Simos18Block { BlockNumber = 4, Name = "ASW3",       BlockIdentifier = 0x04, BaseAddress = 0x80880000, Size = 0x7FC00,  TransferSize = 0xFFD, ChecksumLocation = 0x0,   FRFBlockName = "FD_3", BinFileOffset = 0x280000 } },
            { 5, new Simos18Block { BlockNumber = 5, Name = "CAL",        BlockIdentifier = 0x05, BaseAddress = 0xA0800000, Size = 0x7FC00,  TransferSize = 0xFFD, ChecksumLocation = 0x300, FRFBlockName = "FD_4", BinFileOffset = 0x200000 } },
            { 6, new Simos18Block { BlockNumber = 6, Name = "CBOOT_temp", BlockIdentifier = 0x06, BaseAddress = 0x80840000, Size = 0x23E00,  TransferSize = 0xFFD, ChecksumLocation = 0x340, FRFBlockName = null,   BinFileOffset = 0 } },
        };
    }

    // ====================================================================================
    //  SIMOS 18.10 PROFILE (SCG Project)
    // ====================================================================================

    public class Simos18_10Profile : VWECUProfile
    {
        public override string Name => "Simos 18.10 (Continental)";
        public override string ProjectName => "SCG";
        public override uint TxId => 0x7E0;
        public override uint RxId => 0x7E8;
        public override byte SecurityLevel => 0x11;
        public override uint BinFileSize => 0x400000;

        public override byte[] SA2Script => new byte[] {
            0x68, 0x03, 0x81, 0x4A, 0x10, 0x68, 0x02, 0x93,
            0x05, 0x05, 0x20, 0x15, 0x4A, 0x05, 0x87, 0x22,
            0x12, 0x19, 0x54, 0x82, 0x49, 0x93, 0xF4, 0x23,
            0xBF, 0x7D, 0x82, 0x4A, 0x05, 0x87, 0x5A, 0x63,
            0xFC, 0x5E, 0x82, 0x4A, 0x01, 0x81, 0x49, 0x4C
        };

        public override byte[] AESKey => new byte[] {
            0xAE, 0x54, 0x05, 0x02, 0xE4, 0x8E, 0x38, 0x54,
            0xDB, 0xCA, 0x1A, 0x15, 0x45, 0xBA, 0x6F, 0x33
        };

        public override byte[] AESIV => new byte[] {
            0x62, 0xF3, 0x13, 0xFA, 0x5C, 0x08, 0x53, 0x27,
            0x98, 0xBC, 0xA4, 0x52, 0x47, 0x1D, 0x20, 0xD5
        };

        public override byte CompressionType => 0x0A;
        public override byte EncryptionType => 0x0A;

        public override VWPatchInfo PatchInfo => new VWPatchInfo
        {
            PatchBoxCode = "5G0906259Q__0005",
            PatchBlockNumber = 2, // ASW1
            PatchTransferSizes = new SortedList<uint, int> {
                { 0x0000, 0x100 }, { 0x5CB00, 0x8 }, { 0x5CC00, 0x100 },
                { 0xB3000, 0x8 }, { 0xB3100, 0x100 }, { 0xDFB00, 0x8 }
            }
        };

        public override Dictionary<int, Simos18Block> Blocks => new Dictionary<int, Simos18Block>
        {
            { 0, new Simos18Block { BlockNumber = 0, Name = "SBOOT",      BlockIdentifier = 0x00, BaseAddress = 0x80000000, Size = 0,         TransferSize = 0xFFD, ChecksumLocation = 0x300, FRFBlockName = null,        BinFileOffset = 0x0,      ShouldErase = false, ShouldChecksum = false } },
            { 1, new Simos18Block { BlockNumber = 1, Name = "CBOOT",      BlockIdentifier = 0x01, BaseAddress = 0x80800000, Size = 0x1FE00,   TransferSize = 0xFFD, ChecksumLocation = 0x300, FRFBlockName = "FD_01DATA", BinFileOffset = 0x200000 } },
            { 2, new Simos18Block { BlockNumber = 2, Name = "ASW1",       BlockIdentifier = 0x02, BaseAddress = 0x80020000, Size = 0xDFC00,   TransferSize = 0xFFD, ChecksumLocation = 0x300, FRFBlockName = "FD_02DATA", BinFileOffset = 0x20000 } },
            { 3, new Simos18Block { BlockNumber = 3, Name = "ASW2",       BlockIdentifier = 0x03, BaseAddress = 0x80100000, Size = 0xFFC00,   TransferSize = 0xFFD, ChecksumLocation = 0x0,   FRFBlockName = "FD_03DATA", BinFileOffset = 0x100000 } },
            { 4, new Simos18Block { BlockNumber = 4, Name = "ASW3",       BlockIdentifier = 0x04, BaseAddress = 0x808C0000, Size = 0x13FC00,  TransferSize = 0xFFD, ChecksumLocation = 0x0,   FRFBlockName = "FD_04DATA", BinFileOffset = 0x2C0000 } },
            { 5, new Simos18Block { BlockNumber = 5, Name = "CAL",        BlockIdentifier = 0x05, BaseAddress = 0xA0820000, Size = 0x9FC00,   TransferSize = 0xFFD, ChecksumLocation = 0x300, FRFBlockName = "FD_05DATA", BinFileOffset = 0x220000 } },
            { 6, new Simos18Block { BlockNumber = 6, Name = "CBOOT_temp", BlockIdentifier = 0x06, BaseAddress = 0x80880000, Size = 0x1FE00,   TransferSize = 0xFFD, ChecksumLocation = 0x340, FRFBlockName = null,        BinFileOffset = 0 } },
        };
    }

    // ====================================================================================
    //  SIMOS 18.41 PROFILE (SCB Project)
    // ====================================================================================

    public class Simos18_41Profile : VWECUProfile
    {
        public override string Name => "Simos 18.41 (Continental)";
        public override string ProjectName => "SCB";
        public override uint TxId => 0x7E0;
        public override uint RxId => 0x7E8;
        public override byte SecurityLevel => 0x11;
        public override uint BinFileSize => 0x400000;

        public override byte[] SA2Script => new byte[] {
            0x68, 0x02, 0x81, 0x4A, 0x10, 0x68, 0x04, 0x93,
            0xC1, 0x38, 0x7F, 0xA3, 0x4A, 0x05, 0x87, 0x22,
            0x12, 0x19, 0x54, 0x82, 0x49, 0x93, 0x18, 0x10,
            0x20, 0x12, 0x82, 0x4A, 0x05, 0x87, 0x28, 0x05,
            0x19, 0x77, 0x82, 0x4A, 0x01, 0x81, 0x49, 0x4C
        };

        public override byte[] AESKey => new byte[] {
            0x6E, 0x3F, 0xE0, 0x36, 0x19, 0xF1, 0x38, 0x79,
            0x8C, 0xB4, 0xEC, 0xDC, 0xC7, 0x62, 0x00, 0x5F
        };

        public override byte[] AESIV => new byte[] {
            0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07,
            0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F
        };

        public override byte CompressionType => 0x0A;
        public override byte EncryptionType => 0x0A;

        public override VWPatchInfo PatchInfo => new VWPatchInfo
        {
            PatchBoxCode = "80A906259F__0008",
            PatchBlockNumber = 2, // ASW1
            PatchTransferSizes = new SortedList<uint, int> {
                { 0x0000, 0x100 }, { 0x68500, 0x8 }, { 0x68600, 0x100 },
                { 0xCB000, 0x8 }, { 0xCB100, 0x100 }, { 0xDFB00, 0x8 }
            }
        };

        // Same block layout as Simos 18.10
        public override Dictionary<int, Simos18Block> Blocks => new Dictionary<int, Simos18Block>
        {
            { 0, new Simos18Block { BlockNumber = 0, Name = "SBOOT",      BlockIdentifier = 0x00, BaseAddress = 0x80000000, Size = 0,         TransferSize = 0xFFD, ChecksumLocation = 0x300, FRFBlockName = null,            BinFileOffset = 0x0,      ShouldErase = false, ShouldChecksum = false } },
            { 1, new Simos18Block { BlockNumber = 1, Name = "CBOOT",      BlockIdentifier = 0x01, BaseAddress = 0x80800000, Size = 0x1FE00,   TransferSize = 0xFFD, ChecksumLocation = 0x300, FRFBlockName = "FD_01FLASHDATA", BinFileOffset = 0x200000 } },
            { 2, new Simos18Block { BlockNumber = 2, Name = "ASW1",       BlockIdentifier = 0x02, BaseAddress = 0x80020000, Size = 0xDFC00,   TransferSize = 0xFFD, ChecksumLocation = 0x300, FRFBlockName = "FD_02FLASHDATA", BinFileOffset = 0x20000 } },
            { 3, new Simos18Block { BlockNumber = 3, Name = "ASW2",       BlockIdentifier = 0x03, BaseAddress = 0x80100000, Size = 0xFFC00,   TransferSize = 0xFFD, ChecksumLocation = 0x0,   FRFBlockName = "FD_03FLASHDATA", BinFileOffset = 0x100000 } },
            { 4, new Simos18Block { BlockNumber = 4, Name = "ASW3",       BlockIdentifier = 0x04, BaseAddress = 0x808C0000, Size = 0x13FC00,  TransferSize = 0xFFD, ChecksumLocation = 0x0,   FRFBlockName = "FD_04FLASHDATA", BinFileOffset = 0x2C0000 } },
            { 5, new Simos18Block { BlockNumber = 5, Name = "CAL",        BlockIdentifier = 0x05, BaseAddress = 0xA0820000, Size = 0x9FC00,   TransferSize = 0xFFD, ChecksumLocation = 0x300, FRFBlockName = "FD_05FLASHDATA", BinFileOffset = 0x220000 } },
            { 6, new Simos18Block { BlockNumber = 6, Name = "CBOOT_temp", BlockIdentifier = 0x06, BaseAddress = 0x80880000, Size = 0x1FE00,   TransferSize = 0xFFD, ChecksumLocation = 0x340, FRFBlockName = null,             BinFileOffset = 0 } },
        };
    }

    // ====================================================================================
    //  SIMOS 16.11 PROFILE (SG1 Project)
    // ====================================================================================

    public class Simos16Profile : VWECUProfile
    {
        public override string Name => "Simos 16.11 (Continental)";
        public override string ProjectName => "SG1";
        public override uint TxId => 0x7E0;
        public override uint RxId => 0x7E8;
        public override byte SecurityLevel => 0x11;
        public override uint BinFileSize => 0x400000;

        public override byte[] SA2Script => new byte[] {
            0x68, 0x03, 0x93, 0x71, 0x2E, 0xAB, 0x7C, 0x4A,
            0x05, 0x93, 0x14, 0x06, 0x20, 0x12, 0x49, 0x68,
            0x03, 0x87, 0x01, 0x12, 0x20, 0x12, 0x82, 0x82,
            0x4A, 0x05, 0x84, 0xFD, 0x07, 0x3A, 0x5D, 0x49, 0x4C
        };

        public override byte[] AESKey => new byte[] {
            0x0A, 0xCF, 0xFB, 0x51, 0x3E, 0x95, 0x64, 0x4A,
            0x39, 0x6A, 0x41, 0x32, 0x52, 0x35, 0xD9, 0xA9
        };

        public override byte[] AESIV => new byte[] {
            0x01, 0xD1, 0x37, 0x42, 0x6B, 0x6B, 0x53, 0x6F,
            0xB3, 0x33, 0x3F, 0x69, 0x1B, 0x36, 0x6D, 0x34
        };

        public override byte CompressionType => 0x0A;
        public override byte EncryptionType => 0x0A;

        // Same block sizes as Simos 18.1 but different CBOOT base address
        public override Dictionary<int, Simos18Block> Blocks => new Dictionary<int, Simos18Block>
        {
            { 0, new Simos18Block { BlockNumber = 0, Name = "SBOOT",      BlockIdentifier = 0x00, BaseAddress = 0x80000000, Size = 0,        TransferSize = 0xFFD, ChecksumLocation = 0x300, FRFBlockName = null,        BinFileOffset = 0x0,      ShouldErase = false, ShouldChecksum = false } },
            { 1, new Simos18Block { BlockNumber = 1, Name = "CBOOT",      BlockIdentifier = 0x01, BaseAddress = 0x80020000, Size = 0x23E00,  TransferSize = 0xFFD, ChecksumLocation = 0x300, FRFBlockName = "FD_01DATA", BinFileOffset = 0x20000 } },
            { 2, new Simos18Block { BlockNumber = 2, Name = "ASW1",       BlockIdentifier = 0x02, BaseAddress = 0x80040000, Size = 0xFFC00,  TransferSize = 0xFFD, ChecksumLocation = 0x300, FRFBlockName = "FD_02DATA", BinFileOffset = 0x40000 } },
            { 3, new Simos18Block { BlockNumber = 3, Name = "ASW2",       BlockIdentifier = 0x03, BaseAddress = 0x80140000, Size = 0xBFC00,  TransferSize = 0xFFD, ChecksumLocation = 0x0,   FRFBlockName = "FD_03DATA", BinFileOffset = 0x140000 } },
            { 4, new Simos18Block { BlockNumber = 4, Name = "ASW3",       BlockIdentifier = 0x04, BaseAddress = 0x80880000, Size = 0x7FC00,  TransferSize = 0xFFD, ChecksumLocation = 0x0,   FRFBlockName = "FD_04DATA", BinFileOffset = 0x280000 } },
            { 5, new Simos18Block { BlockNumber = 5, Name = "CAL",        BlockIdentifier = 0x05, BaseAddress = 0xA0800000, Size = 0x7FC00,  TransferSize = 0xFFD, ChecksumLocation = 0x300, FRFBlockName = "FD_05DATA", BinFileOffset = 0x200000 } },
            { 6, new Simos18Block { BlockNumber = 6, Name = "CBOOT_temp", BlockIdentifier = 0x06, BaseAddress = 0x80840000, Size = 0x23E00,  TransferSize = 0xFFD, ChecksumLocation = 0x340, FRFBlockName = null,        BinFileOffset = 0 } },
        };
    }

    // ====================================================================================
    //  SIMOS 12 PROFILE (SC1 Project)
    // ====================================================================================

    public class Simos12Profile : VWECUProfile
    {
        public override string Name => "Simos 12 (Continental)";
        public override string ProjectName => "SC1";
        public override uint TxId => 0x7E0;
        public override uint RxId => 0x7E8;
        public override byte SecurityLevel => 0x11;
        public override uint BinFileSize => 0x400000;

        public override byte[] SA2Script => new byte[] {
            0x68, 0x03, 0x81, 0x4A, 0x10, 0x68, 0x03, 0x93,
            0x29, 0x07, 0x20, 0x09, 0x4A, 0x05, 0x87, 0x22,
            0x12, 0x19, 0x54, 0x82, 0x49, 0x93, 0x09, 0x01,
            0x19, 0x53, 0x82, 0x4A, 0x05, 0x87, 0x30, 0x03,
            0x20, 0x09, 0x82, 0x4A, 0x01, 0x81, 0x49, 0x4C
        };

        public override byte[] AESKey => new byte[] {
            0x31, 0x4D, 0x75, 0x36, 0x41, 0x6E, 0x30, 0x47,
            0x39, 0x6A, 0x41, 0x32, 0x52, 0x35, 0x6F, 0x45
        };

        public override byte[] AESIV => new byte[] {
            0x30, 0x6E, 0x37, 0x42, 0x6B, 0x6B, 0x53, 0x6F,
            0x31, 0x6D, 0x4A, 0x69, 0x74, 0x36, 0x6D, 0x34
        };

        public override byte CompressionType => 0x0A;
        public override byte EncryptionType => 0x0A;

        public override Dictionary<int, Simos18Block> Blocks => new Dictionary<int, Simos18Block>
        {
            { 0, new Simos18Block { BlockNumber = 0, Name = "SBOOT",      BlockIdentifier = 0x00, BaseAddress = 0x80000000, Size = 0,        TransferSize = 0xFFD, ChecksumLocation = 0x300, FRFBlockName = null,   BinFileOffset = 0x0,      ShouldErase = false, ShouldChecksum = false } },
            { 1, new Simos18Block { BlockNumber = 1, Name = "CBOOT",      BlockIdentifier = 0x01, BaseAddress = 0x80020000, Size = 0x1FE00,  TransferSize = 0xFFD, ChecksumLocation = 0x300, FRFBlockName = "FD_0", BinFileOffset = 0x20000 } },
            { 2, new Simos18Block { BlockNumber = 2, Name = "ASW1",       BlockIdentifier = 0x02, BaseAddress = 0x800C0000, Size = 0xBFC00,  TransferSize = 0xFFD, ChecksumLocation = 0x300, FRFBlockName = "FD_1", BinFileOffset = 0xC0000 } },
            { 3, new Simos18Block { BlockNumber = 3, Name = "ASW2",       BlockIdentifier = 0x03, BaseAddress = 0x80180000, Size = 0xBFC00,  TransferSize = 0xFFD, ChecksumLocation = 0x0,   FRFBlockName = "FD_2", BinFileOffset = 0x180000 } },
            { 4, new Simos18Block { BlockNumber = 4, Name = "ASW3",       BlockIdentifier = 0x04, BaseAddress = 0x80240000, Size = 0xBFC00,  TransferSize = 0xFFD, ChecksumLocation = 0x0,   FRFBlockName = "FD_3", BinFileOffset = 0x240000 } },
            { 5, new Simos18Block { BlockNumber = 5, Name = "CAL",        BlockIdentifier = 0x05, BaseAddress = 0xA0040000, Size = 0x6FC00,  TransferSize = 0xFFD, ChecksumLocation = 0x300, FRFBlockName = "FD_4", BinFileOffset = 0x40000 } },
            { 6, new Simos18Block { BlockNumber = 6, Name = "CBOOT_temp", BlockIdentifier = 0x06, BaseAddress = 0x80080000, Size = 0x1FE00,  TransferSize = 0xFFD, ChecksumLocation = 0x340, FRFBlockName = null,   BinFileOffset = 0 } },
        };
    }

    // ====================================================================================
    //  SIMOS 12.2 PROFILE (SC2 Project)
    // ====================================================================================

    public class Simos122Profile : VWECUProfile
    {
        public override string Name => "Simos 12.2 (Continental)";
        public override string ProjectName => "SC2";
        public override uint TxId => 0x7E0;
        public override uint RxId => 0x7E8;
        public override byte SecurityLevel => 0x11;
        public override uint BinFileSize => 0x400000;

        // Same SA2 script as Simos 12
        public override byte[] SA2Script => new byte[] {
            0x68, 0x03, 0x81, 0x4A, 0x10, 0x68, 0x03, 0x93,
            0x29, 0x07, 0x20, 0x09, 0x4A, 0x05, 0x87, 0x22,
            0x12, 0x19, 0x54, 0x82, 0x49, 0x93, 0x09, 0x01,
            0x19, 0x53, 0x82, 0x4A, 0x05, 0x87, 0x30, 0x03,
            0x20, 0x09, 0x82, 0x4A, 0x01, 0x81, 0x49, 0x4C
        };

        // Different key/IV from Simos 12
        public override byte[] AESKey => new byte[] {
            0x41, 0x32, 0x6D, 0x3F, 0x50, 0x61, 0x3D, 0x30,
            0x6C, 0x4C, 0x36, 0x61, 0x6E, 0x34, 0x67, 0x21
        };

        public override byte[] AESIV => new byte[] {
            0x70, 0x49, 0x34, 0x65, 0x72, 0x63, 0x45, 0x29,
            0x64, 0x70, 0x55, 0x73, 0x33, 0x23, 0x53, 0x79
        };

        public override byte CompressionType => 0x0A;
        public override byte EncryptionType => 0x0A;

        // Same block layout as Simos 12
        public override Dictionary<int, Simos18Block> Blocks => new Dictionary<int, Simos18Block>
        {
            { 0, new Simos18Block { BlockNumber = 0, Name = "SBOOT",      BlockIdentifier = 0x00, BaseAddress = 0x80000000, Size = 0,        TransferSize = 0xFFD, ChecksumLocation = 0x300, FRFBlockName = null,   BinFileOffset = 0x0,      ShouldErase = false, ShouldChecksum = false } },
            { 1, new Simos18Block { BlockNumber = 1, Name = "CBOOT",      BlockIdentifier = 0x01, BaseAddress = 0x80020000, Size = 0x1FE00,  TransferSize = 0xFFD, ChecksumLocation = 0x300, FRFBlockName = "FD_0", BinFileOffset = 0x20000 } },
            { 2, new Simos18Block { BlockNumber = 2, Name = "ASW1",       BlockIdentifier = 0x02, BaseAddress = 0x800C0000, Size = 0xBFC00,  TransferSize = 0xFFD, ChecksumLocation = 0x300, FRFBlockName = "FD_1", BinFileOffset = 0xC0000 } },
            { 3, new Simos18Block { BlockNumber = 3, Name = "ASW2",       BlockIdentifier = 0x03, BaseAddress = 0x80180000, Size = 0xBFC00,  TransferSize = 0xFFD, ChecksumLocation = 0x0,   FRFBlockName = "FD_2", BinFileOffset = 0x180000 } },
            { 4, new Simos18Block { BlockNumber = 4, Name = "ASW3",       BlockIdentifier = 0x04, BaseAddress = 0x80240000, Size = 0xBFC00,  TransferSize = 0xFFD, ChecksumLocation = 0x0,   FRFBlockName = "FD_3", BinFileOffset = 0x240000 } },
            { 5, new Simos18Block { BlockNumber = 5, Name = "CAL",        BlockIdentifier = 0x05, BaseAddress = 0xA0040000, Size = 0x6FC00,  TransferSize = 0xFFD, ChecksumLocation = 0x300, FRFBlockName = "FD_4", BinFileOffset = 0x40000 } },
            { 6, new Simos18Block { BlockNumber = 6, Name = "CBOOT_temp", BlockIdentifier = 0x06, BaseAddress = 0x80080000, Size = 0x1FE00,  TransferSize = 0xFFD, ChecksumLocation = 0x340, FRFBlockName = null,   BinFileOffset = 0 } },
        };
    }

    // ====================================================================================
    //  SIMOS 10 PROFILE (SA Project) — 3-block, XOR encrypted
    // ====================================================================================

    public class Simos10Profile : VWECUProfile
    {
        public override string Name => "Simos 10 (Continental)";
        public override string ProjectName => "SA";
        public override uint TxId => 0x7E0;
        public override uint RxId => 0x7E8;
        public override byte SecurityLevel => 0x11;
        public override uint BinFileSize => 0x200000; // 2MB
        public override VWCryptoType CryptoType => VWCryptoType.SimosXOR;

        public override byte[] SA2Script => new byte[] {
            0x68, 0x03, 0x82, 0x4A, 0x10, 0x68, 0x02, 0x84,
            0x44, 0x39, 0x32, 0x24, 0x4A, 0x05, 0x87, 0x27,
            0x09, 0x20, 0x04, 0x81, 0x49, 0x93, 0x84, 0x25,
            0x16, 0x48, 0x82, 0x4A, 0x05, 0x87, 0x12, 0x08,
            0x20, 0x01, 0x82, 0x4A, 0x01, 0x81, 0x49, 0x4C
        };

        public override byte[] AESKey => null; // Uses XOR, not AES
        public override byte[] AESIV => null;
        public override byte CompressionType => 0x0A;
        public override byte EncryptionType => 0x0A;

        public override Dictionary<int, Simos18Block> Blocks => new Dictionary<int, Simos18Block>
        {
            { 1, new Simos18Block { BlockNumber = 1, Name = "BOOT",        BlockIdentifier = 0x01, BaseAddress = 0x8000C000, Size = 0x13E00,  TransferSize = 0xFFD, ChecksumLocation = 0x300, FRFBlockName = "FD_1", BinFileOffset = 0xC000 } },
            { 2, new Simos18Block { BlockNumber = 2, Name = "SOFTWARE",    BlockIdentifier = 0x02, BaseAddress = 0x80020000, Size = 0x19FA00, TransferSize = 0xFFD, ChecksumLocation = 0x300, FRFBlockName = "FD_2", BinFileOffset = 0x20000 } },
            { 3, new Simos18Block { BlockNumber = 3, Name = "CALIBRATION", BlockIdentifier = 0x03, BaseAddress = 0xA01C0000, Size = 0x3C000,  TransferSize = 0xFFD, ChecksumLocation = 0x300, FRFBlockName = "FD_3", BinFileOffset = 0x1C0000 } },
        };
    }

    // ====================================================================================
    //  SIMOS 8 PROFILE (S85 Project) — 3-block, XOR encrypted
    // ====================================================================================

    public class Simos8Profile : VWECUProfile
    {
        public override string Name => "Simos 8 (Continental)";
        public override string ProjectName => "S85";
        public override uint TxId => 0x7E0;
        public override uint RxId => 0x7E8;
        public override byte SecurityLevel => 0x11;
        public override uint BinFileSize => 0x200000; // 2MB
        public override VWCryptoType CryptoType => VWCryptoType.SimosXOR;

        public override byte[] SA2Script => new byte[] {
            0x68, 0x05, 0x82, 0x4A, 0x10, 0x68, 0x04, 0x93,
            0x30, 0x04, 0x19, 0x62, 0x4A, 0x05, 0x87, 0x15,
            0x10, 0x19, 0x70, 0x82, 0x49, 0x93, 0x24, 0x04,
            0x19, 0x66, 0x82, 0x4A, 0x05, 0x87, 0x02, 0x03,
            0x19, 0x70, 0x82, 0x4A, 0x01, 0x81, 0x49, 0x4C
        };

        public override byte[] AESKey => null; // Uses XOR, not AES
        public override byte[] AESIV => null;
        public override byte CompressionType => 0x0A;
        public override byte EncryptionType => 0x0A;

        public override Dictionary<int, Simos18Block> Blocks => new Dictionary<int, Simos18Block>
        {
            { 1, new Simos18Block { BlockNumber = 1, Name = "BOOT",        BlockIdentifier = 0x01, BaseAddress = 0x80020000, Size = 0x13E00,  TransferSize = 0xFFD, ChecksumLocation = 0x300, FRFBlockName = "FD_0", BinFileOffset = 0x20000 } },
            { 2, new Simos18Block { BlockNumber = 2, Name = "SOFTWARE",    BlockIdentifier = 0x02, BaseAddress = 0x80080000, Size = 0x17FE00, TransferSize = 0xFFD, ChecksumLocation = 0x300, FRFBlockName = "FD_1", BinFileOffset = 0x80000 } },
            { 3, new Simos18Block { BlockNumber = 3, Name = "CALIBRATION", BlockIdentifier = 0x03, BaseAddress = 0xA0040000, Size = 0x3C000,  TransferSize = 0xFFD, ChecksumLocation = 0x300, FRFBlockName = "FD_2", BinFileOffset = 0x40000 } },
        };
    }

    // ====================================================================================
    //  DQ250 MQB DSG PROFILE — Rolling substitution cipher
    // ====================================================================================

    public class DQ250MQBProfile : VWECUProfile
    {
        public override string Name => "DQ250 MQB DSG (7-Speed)";
        public override string ProjectName => "F";
        public override uint TxId => 0x7E1;
        public override uint RxId => 0x7E9;
        public override byte SecurityLevel => 0x11;
        public override uint BinFileSize => 0x180000; // 1.5MB
        public override VWCryptoType CryptoType => VWCryptoType.DSGSubstitution;

        // Correct DQ250 SA2 script (NOT the DQ381 one)
        public override byte[] SA2Script => new byte[] {
            0x68, 0x02, 0x81, 0x49, 0x68, 0x05, 0x93, 0xA5,
            0x5A, 0x55, 0xAA, 0x4A, 0x05, 0x87, 0x81, 0x05,
            0x95, 0x26, 0x82, 0x49, 0x84, 0x5A, 0xA5, 0xAA,
            0x55, 0x87, 0x03, 0xF7, 0x80, 0x38, 0x4C
        };

        public override byte[] AESKey => null; // Uses DSG substitution cipher, not AES
        public override byte[] AESIV => null;
        public override byte CompressionType => 0x01;
        public override byte EncryptionType => 0x01;

        // DQ250 sits behind the MQB gateway, which enforces a minimum ISO-TP separation
        // time on the powertrain subnet. Reference VW_Flash passes 900_000 ns = 900 us.
        public override int? IsoTpStMinMicroseconds => 900;

        // External UDS checksums — reference lib/modules/dq250mqb.py block_checksums_dsg.
        // DRIVER (block 2) is the only one the ECU externally verifies via 0x0202; the
        // others use FF FF FF FF (internal checksum, no external verify).
        public override Dictionary<int, byte[]> UdsChecksums => new Dictionary<int, byte[]>
        {
            { 2, new byte[] { 0xF9, 0x74, 0x17, 0x6E } },
            { 3, new byte[] { 0xFF, 0xFF, 0xFF, 0xFF } },
            { 4, new byte[] { 0xFF, 0xFF, 0xFF, 0xFF } },
        };

        public override Dictionary<int, Simos18Block> Blocks => new Dictionary<int, Simos18Block>
        {
            { 2, new Simos18Block { BlockNumber = 2, Name = "DRIVER", BlockIdentifier = 0x30, BaseAddress = 0, Size = 0x80E,    TransferSize = 0x4B0, ChecksumLocation = 0, FRFBlockName = "FD_2", BinFileOffset = 0x0,     ShouldErase = false } },
            { 3, new Simos18Block { BlockNumber = 3, Name = "ASW",    BlockIdentifier = 0x50, BaseAddress = 0, Size = 0x130000, TransferSize = 0x800, ChecksumLocation = 0, FRFBlockName = "FD_3", BinFileOffset = 0x50000 } },
            { 4, new Simos18Block { BlockNumber = 4, Name = "CAL",    BlockIdentifier = 0x51, BaseAddress = 0, Size = 0x20000,  TransferSize = 0x800, ChecksumLocation = 0, FRFBlockName = "FD_4", BinFileOffset = 0x30000 } },
        };
    }

    // ====================================================================================
    //  DQ381 DSG PROFILE — AES with sequential keys (VERIFIED against reference)
    //
    //  Note: the AES key `00..0F` and IV `10..1F` below look like placeholders but are
    //  the REAL shipped keys per lib/modules/dq381.py. VW set a weak key on DQ381 —
    //  do NOT change these without an updated reference source.
    // ====================================================================================

    public class DQ381Profile : VWECUProfile
    {
        public override string Name => "DQ381 DSG (7-Speed)";
        public override string ProjectName => "F";
        public override uint TxId => 0x7E1;
        public override uint RxId => 0x7E9;
        public override byte SecurityLevel => 0x11;
        public override uint BinFileSize => 0x180000; // 1.5MB

        public override byte[] SA2Script => new byte[] {
            0x68, 0x06, 0x81, 0x4A, 0x05, 0x87, 0x6B, 0x5F,
            0x7D, 0xD5, 0x49, 0x4C
        };

        public override byte[] AESKey => new byte[] {
            0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07,
            0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F
        };

        public override byte[] AESIV => new byte[] {
            0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17,
            0x18, 0x19, 0x1A, 0x1B, 0x1C, 0x1D, 0x1E, 0x1F
        };

        public override byte CompressionType => 0x0A;
        public override byte EncryptionType => 0x0A;

        public override Dictionary<int, Simos18Block> Blocks => new Dictionary<int, Simos18Block>
        {
            { 1, new Simos18Block { BlockNumber = 1, Name = "BOOT", BlockIdentifier = 0x01, BaseAddress = 0x010200, Size = 0x1FE00,  TransferSize = 0xF0, ChecksumLocation = 0x44, FRFBlockName = "FD_01DATA", BinFileOffset = 0x010200 } },
            { 2, new Simos18Block { BlockNumber = 2, Name = "ASW",  BlockIdentifier = 0x02, BaseAddress = 0x030200, Size = 0x10FE00, TransferSize = 0xF0, ChecksumLocation = 0x44, FRFBlockName = "FD_02DATA", BinFileOffset = 0x030200 } },
            { 3, new Simos18Block { BlockNumber = 3, Name = "CAL",  BlockIdentifier = 0x03, BaseAddress = 0x140200, Size = 0x3FE00,  TransferSize = 0xF0, ChecksumLocation = 0x44, FRFBlockName = "FD_03DATA", BinFileOffset = 0x140200 } },
        };
    }

    // ====================================================================================
    //  HALDEX 4MOTION PROFILE — No encryption
    // ====================================================================================

    public class Haldex4MotionProfile : VWECUProfile
    {
        public override string Name => "Haldex Gen4/5 (4Motion AWD)";
        public override string ProjectName => "";
        public override uint TxId => 0x70F;
        public override uint RxId => 0x779;
        public override byte SecurityLevel => 0x11;
        public override uint BinFileSize => 0x50000; // 320KB
        public override VWCryptoType CryptoType => VWCryptoType.None;

        public override byte[] SA2Script => new byte[] {
            0x68, 0x05, 0x81, 0x4A, 0x05, 0x87, 0x0A, 0x22,
            0x12, 0x89, 0x49, 0x4C
        };

        public override byte[] AESKey => null; // No encryption
        public override byte[] AESIV => null;

        public override byte CompressionType => 0x00;
        public override byte EncryptionType => 0x00;

        public override Dictionary<int, Simos18Block> Blocks => new Dictionary<int, Simos18Block>
        {
            { 1, new Simos18Block { BlockNumber = 1, Name = "DRIVER",  BlockIdentifier = 0x30, BaseAddress = 0, Size = 0x434,   TransferSize = 0x100, ChecksumLocation = 0x0,   FRFBlockName = "FD_0DRIVE", BinFileOffset = 0x0,     ShouldErase = false, ShouldChecksum = false } },
            { 2, new Simos18Block { BlockNumber = 2, Name = "CAL",     BlockIdentifier = 0x02, BaseAddress = 0, Size = 0x333E,  TransferSize = 0x100, ChecksumLocation = 0x10,  FRFBlockName = "FD_1DATA",  BinFileOffset = 0xB400 } },
            { 3, new Simos18Block { BlockNumber = 3, Name = "ASW",     BlockIdentifier = 0x01, BaseAddress = 0, Size = 0x3DB80, TransferSize = 0x100, ChecksumLocation = 0x200, FRFBlockName = "FD_2DATA",  BinFileOffset = 0x10000 } },
            { 4, new Simos18Block { BlockNumber = 4, Name = "VERSION", BlockIdentifier = 0x03, BaseAddress = 0, Size = 0xE,     TransferSize = 0x100, ChecksumLocation = 0x0,   FRFBlockName = "FD_3DATA",  BinFileOffset = 0x4DC00, ShouldChecksum = false } },
        };
    }

    // ====================================================================================
    //  PROFILE REGISTRY
    // ====================================================================================

    public static class VWECUProfileRegistry
    {
        private static readonly VWECUProfile[] _profiles = new VWECUProfile[]
        {
            new Simos18_1Profile(),
            new Simos18_10Profile(),
            new Simos18_41Profile(),
            new Simos16Profile(),
            new Simos12Profile(),
            new Simos122Profile(),
            new Simos10Profile(),
            new Simos8Profile(),
            new DQ250MQBProfile(),
            new DQ381Profile(),
            new Haldex4MotionProfile(),
        };

        /// <summary>Get all registered VW ECU profiles</summary>
        public static VWECUProfile[] GetAll() => _profiles;

        /// <summary>Get profile by display name</summary>
        public static VWECUProfile GetByName(string name)
        {
            foreach (var p in _profiles)
                if (p.Name == name) return p;
            return null;
        }

        /// <summary>Get display names for combo box population</summary>
        public static string[] GetNames()
        {
            string[] names = new string[_profiles.Length];
            for (int i = 0; i < _profiles.Length; i++)
                names[i] = _profiles[i].Name;
            return names;
        }

        /// <summary>Try all profiles against a BIN file to auto-detect ECU type by project name</summary>
        public static VWECUProfile AutoDetectProfile(byte[] binData)
        {
            foreach (var p in _profiles)
            {
                if (string.IsNullOrEmpty(p.ProjectName)) continue;
                // Check software version locations for project name prefix
                foreach (var kvp in p.Blocks)
                {
                    if (kvp.Key == 0) continue;
                    var block = kvp.Value;
                    if (block.BinFileOffset + block.Size <= binData.Length && block.Size > 0)
                    {
                        // Check common SW version offsets
                        uint[] swOffsets = { 0x437, 0x627, 0x203, 0x23 };
                        foreach (uint off in swOffsets)
                        {
                            if (block.BinFileOffset + off + p.ProjectName.Length <= binData.Length)
                            {
                                string ver = System.Text.Encoding.ASCII.GetString(binData, (int)(block.BinFileOffset + off), p.ProjectName.Length);
                                if (ver == p.ProjectName) return p;
                            }
                        }
                    }
                }
            }
            return null;
        }
    }

    // ====================================================================================
    //  COMMON UDS DIDs FOR VW ECUs
    // ====================================================================================

    public static class VWDIDs
    {
        public const ushort VIN = 0xF190;
        public const ushort AppSoftwareVersion = 0xF189;
        public const ushort ECUHardwareNumber = 0xF191;
        public const ushort ECUHardwareVersion = 0xF1A3;
        public const ushort SparePartNumber = 0xF187;
        public const ushort SystemName = 0xF197;
        public const ushort BootloaderID = 0xF1F4;
        public const ushort FlashMemoryState = 0x0405;
        public const ushort ODXFileVersion = 0xF1A2;
        public const ushort ODXFileIdentifier = 0xF19E;
        public const ushort WorkshopCode = 0xF15A;
        public const ushort ProgrammingDate = 0xF15B;
        public const ushort EngineCodeLetters = 0xF1AD;
        public const ushort FAZITIdentification = 0xF17C;
        public const ushort CalibrationID = 0xF804;
        public const ushort CodingValue = 0x0600;
        public const ushort ECUSerialNumber = 0xF18C;
        public const ushort VWLogicalSWBlockVersion = 0xF1AB;
    }
}
