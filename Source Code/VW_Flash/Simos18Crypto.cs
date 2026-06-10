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
//  Tester Present Specialist Automotive Solutions - VW Simos18 Cryptographic Utilities
//  FRF Decryption, AES-128-CBC, LZSS Compression, DSG Substitution Cipher, Simos XOR,
//  CBOOT Sample Mode Patching (Write-Without-Erase Unlock Exploit)
//  Ported from VW_Flash by bri3d (GPL-3.0 License)
//  https://testerpresent.com.au | https://github.com/jakka351
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace TesterPresent.OBD2.UDS
{
    public static class Simos18Crypto
    {
        // ====================================================================================
        //  FRF FILE DECRYPTION (Recursive XOR Cipher)
        // ====================================================================================

        /// <summary>
        /// Decrypt an FRF file using the recursive XOR cipher with the provided key material.
        /// The decrypted output is a ZIP archive containing ODX/SGO files.
        /// </summary>
        public static byte[] DecryptFRF(byte[] encryptedData, byte[] keyMaterial)
        {
            if (encryptedData == null || keyMaterial == null || keyMaterial.Length == 0)
                throw new ArgumentException("Encrypted data and key material are required");

            byte[] nativeOut = new byte[encryptedData.Length];
            if (SecurityNative.TrySimos18FrfDecrypt(encryptedData, keyMaterial, nativeOut))
                return nativeOut;

            byte[] output = new byte[encryptedData.Length];
            byte firstSeed = 0;
            byte secondSeed = 1;
            int keyIndex = 0;

            for (int i = 0; i < encryptedData.Length; i++)
            {
                byte keyByte = keyMaterial[keyIndex];
                firstSeed = (byte)(((firstSeed + keyByte) * 3) & 0xFF);
                output[i] = (byte)(encryptedData[i] ^ (firstSeed ^ 0xFF ^ secondSeed ^ keyByte));
                secondSeed = (byte)(((secondSeed + 1) * firstSeed) & 0xFF);
                keyIndex = (keyIndex + 1) % keyMaterial.Length;
            }

            return output;
        }

        /// <summary>Check if decrypted data looks like a valid ZIP file (PK header)</summary>
        public static bool IsValidZip(byte[] data)
        {
            return data != null && data.Length > 4 && data[0] == 0x50 && data[1] == 0x4B;
        }

        private static byte[] _embeddedFrfKeyCache;
        private static readonly object _embeddedFrfKeyLock = new object();

        /// <summary>
        /// Load the embedded FRF key material (ported verbatim from VW_Flash data/frf.key).
        /// Used as a fallback when the operator hasn't supplied their own key file.
        /// Cached on first call — the key file is small (4095 bytes) so the memory cost
        /// is negligible.
        /// </summary>
        public static byte[] GetEmbeddedFrfKey()
        {
            if (_embeddedFrfKeyCache != null) return _embeddedFrfKeyCache;
            lock (_embeddedFrfKeyLock)
            {
                if (_embeddedFrfKeyCache != null) return _embeddedFrfKeyCache;
                var asm  = typeof(Simos18Crypto).Assembly;
                var name = "TesterPresent.OBD2.UDS.frf.key";
                using (var s = asm.GetManifestResourceStream(name))
                {
                    if (s == null) return null;
                    using (var ms = new MemoryStream())
                    {
                        s.CopyTo(ms);
                        _embeddedFrfKeyCache = ms.ToArray();
                    }
                }
                return _embeddedFrfKeyCache;
            }
        }

        /// <summary>
        /// Resolve the FRF key to use: operator-supplied path wins; fall back to the
        /// embedded reference key if the path is empty or doesn't exist.
        /// </summary>
        public static byte[] ResolveFrfKey(string operatorProvidedPath)
        {
            if (!string.IsNullOrEmpty(operatorProvidedPath) && File.Exists(operatorProvidedPath))
            {
                try { return File.ReadAllBytes(operatorProvidedPath); }
                catch { /* fall through to embedded */ }
            }
            return GetEmbeddedFrfKey();
        }

        /// <summary>Extract files from a ZIP byte array (decrypted FRF content)</summary>
        public static Dictionary<string, byte[]> ExtractZipEntries(byte[] zipData)
        {
            var entries = new Dictionary<string, byte[]>();
            using (var ms = new MemoryStream(zipData))
            using (var archive = new ZipArchive(ms, ZipArchiveMode.Read))
            {
                foreach (var entry in archive.Entries)
                {
                    using (var es = entry.Open())
                    using (var buf = new MemoryStream())
                    {
                        es.CopyTo(buf);
                        entries[entry.FullName] = buf.ToArray();
                    }
                }
            }
            return entries;
        }

        // ====================================================================================
        //  AES-128-CBC ENCRYPTION / DECRYPTION
        // ====================================================================================

        /// <summary>Encrypt data using AES-128-CBC (block cipher, zero-padded to 16-byte boundary)</summary>
        public static byte[] AESEncrypt(byte[] plainData, byte[] key, byte[] iv)
        {
            if (key == null || iv == null)
                throw new ArgumentException("AES key and IV are required");

            int paddedLen = ((plainData.Length + 15) / 16) * 16;
            byte[] nativeOut = new byte[paddedLen];
            if (SecurityNative.TrySimos18AesCbcEncrypt(plainData, key, iv, nativeOut))
                return nativeOut;

            byte[] padded = new byte[paddedLen];
            Array.Copy(plainData, 0, padded, 0, plainData.Length);

            using (var aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.None;
                using (var enc = aes.CreateEncryptor())
                    return enc.TransformFinalBlock(padded, 0, padded.Length);
            }
        }

        /// <summary>Decrypt data using AES-128-CBC</summary>
        public static byte[] AESDecrypt(byte[] cipherData, byte[] key, byte[] iv)
        {
            if (key == null || iv == null)
                throw new ArgumentException("AES key and IV are required");

            int alignedLen = ((cipherData.Length + 15) / 16) * 16;
            byte[] nativeOut = new byte[alignedLen];
            if (SecurityNative.TrySimos18AesCbcDecrypt(cipherData, key, iv, nativeOut))
                return nativeOut;

            byte[] aligned = new byte[alignedLen];
            Array.Copy(cipherData, 0, aligned, 0, cipherData.Length);

            using (var aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.None;
                using (var dec = aes.CreateDecryptor())
                    return dec.TransformFinalBlock(aligned, 0, aligned.Length);
            }
        }

        // ====================================================================================
        //  SIMOS XOR CIPHER (Simos 8 / Simos 10)
        //  Each byte XORed with incrementing counter (0, 1, 2, ... 255, 0, 1, ...)
        //  Found at 0x80017168 in 03F906070AK firmware
        // ====================================================================================

        /// <summary>Simos XOR encrypt/decrypt (symmetric — same operation for both)</summary>
        public static byte[] SimosXorCrypt(byte[] data)
        {
            byte[] output = new byte[data.Length];
            if (SecurityNative.TrySimos18Xor(data, output))
                return output;
            for (int i = 0; i < data.Length; i++)
                output[i] = (byte)(data[i] ^ (i & 0xFF));
            return output;
        }

        // ====================================================================================
        //  DSG PROGRESSIVE SUBSTITUTION CIPHER (DQ250 MQB)
        //  Rolling substitution using 256-byte key table with feedback
        //  Found at 0x800164AC in DQ250_MQB_0D9300012L_4516
        // ====================================================================================

        /// <summary>DSG decrypt using progressive substitution cipher with key table</summary>
        public static byte[] DSGDecrypt(byte[] data, byte[] keyTable)
        {
            if (keyTable == null || keyTable.Length < 256)
                throw new ArgumentException("DSG key table must be 256 bytes");

            byte[] output = new byte[data.Length];
            if (SecurityNative.TrySimos18DsgDecrypt(data, keyTable, output))
                return output;

            int offset = 0;
            int rollingStreamOffset = 0;
            int lastData = 0;

            for (int i = 0; i < data.Length; i++)
            {
                int cipherData = keyTable[(data[i] + offset) & 0xFF] & 0xFF;
                output[i] = (byte)cipherData;
                offset += cipherData;
                offset += lastData;
                rollingStreamOffset += 0x167;
                offset += keyTable[(rollingStreamOffset >> 8) & 0xFF] & 0xFF;
                lastData = cipherData;
            }

            return output;
        }

        /// <summary>DSG encrypt using progressive substitution cipher (inverse of decrypt)</summary>
        public static byte[] DSGEncrypt(byte[] data, byte[] keyTable)
        {
            if (keyTable == null || keyTable.Length < 256)
                throw new ArgumentException("DSG key table must be 256 bytes");

            byte[] output = new byte[data.Length];
            if (SecurityNative.TrySimos18DsgEncrypt(data, keyTable, output))
                return output;

            int offset = 0;
            int rollingStreamOffset = 0;
            int lastData = 0;

            for (int i = 0; i < data.Length; i++)
            {
                // Find the index in keyTable that maps to data[i]
                int matchIndex = -1;
                for (int j = 0; j < 256; j++)
                {
                    if (keyTable[j] == data[i])
                    {
                        matchIndex = j;
                        break;
                    }
                }
                if (matchIndex < 0) matchIndex = 0;

                // Reverse the offset to get the encrypted byte
                output[i] = (byte)((matchIndex - offset) & 0xFF);

                int cipherData = data[i] & 0xFF;
                offset += cipherData;
                offset += lastData;
                rollingStreamOffset += 0x167;
                offset += keyTable[(rollingStreamOffset >> 8) & 0xFF] & 0xFF;
                lastData = cipherData;
            }

            return output;
        }

        // ====================================================================================
        //  UNIFIED BLOCK ENCRYPTION/DECRYPTION (dispatches by profile crypto type)
        // ====================================================================================

        /// <summary>Encrypt a flash block using the appropriate algorithm for the profile</summary>
        public static byte[] EncryptBlock(byte[] data, VWECUProfile profile, byte[] dsgKeyTable = null)
        {
            switch (profile.CryptoType)
            {
                case VWCryptoType.AES_CBC:
                    if (profile.AESKey == null || profile.AESIV == null)
                        return data; // No encryption configured
                    return AESEncrypt(data, profile.AESKey, profile.AESIV);

                case VWCryptoType.SimosXOR:
                    return SimosXorCrypt(data);

                case VWCryptoType.DSGSubstitution:
                    if (dsgKeyTable == null) return data;
                    return DSGEncrypt(data, dsgKeyTable);

                case VWCryptoType.None:
                default:
                    return data;
            }
        }

        /// <summary>Decrypt a flash block using the appropriate algorithm for the profile</summary>
        public static byte[] DecryptBlock(byte[] data, VWECUProfile profile, byte[] dsgKeyTable = null)
        {
            switch (profile.CryptoType)
            {
                case VWCryptoType.AES_CBC:
                    if (profile.AESKey == null || profile.AESIV == null)
                        return data;
                    return AESDecrypt(data, profile.AESKey, profile.AESIV);

                case VWCryptoType.SimosXOR:
                    return SimosXorCrypt(data); // Symmetric

                case VWCryptoType.DSGSubstitution:
                    if (dsgKeyTable == null) return data;
                    return DSGDecrypt(data, dsgKeyTable);

                case VWCryptoType.None:
                default:
                    return data;
            }
        }

        // ====================================================================================
        //  CBOOT SAMPLE MODE PATCHING (Write-Without-Erase Unlock Exploit)
        //  Patches is_sample_mode() in CBOOT to always return 1 (true)
        //  Disables RSA signature verification on ASW blocks
        // ====================================================================================

        // TriCore assembly: the is_sample_mode() function pattern
        // DA 00 = mov d15, #0x0  (return false)
        // 3C 02 = j +2           (skip mov #1)
        // DA 01 = mov d15, #0x1  (return true - normally unreachable)
        // 02 F2 = mov d2, d15    (set return register)
        private static readonly byte[] CbootNeedle = new byte[] { 0xDA, 0x00, 0x3C, 0x02, 0xDA, 0x01, 0x02, 0xF2 };

        // Patched: NOP out the "mov #0" and "jump", so "mov #1" always executes
        // 00 00 = nop
        // 00 00 = nop
        // DA 01 = mov d15, #0x1  (always executes now)
        // 02 F2 = mov d2, d15    (returns 1 = sample mode enabled)
        private static readonly byte[] CbootPatch = new byte[] { 0x00, 0x00, 0x00, 0x00, 0xDA, 0x01, 0x02, 0xF2 };

        /// <summary>
        /// Patch CBOOT binary to enable Sample Mode (bypass RSA signature checks).
        /// Exactly 2 occurrences of is_sample_mode() must be found and patched.
        /// Returns the patched CBOOT or the original if already patched or pattern not found.
        /// </summary>
        /// <param name="cbootBinary">Raw CBOOT binary data</param>
        /// <param name="patchCount">Number of occurrences patched (output)</param>
        /// <returns>Patched CBOOT binary (or original if not patchable)</returns>
        public static byte[] PatchCBOOT(byte[] cbootBinary, out int patchCount)
        {
            patchCount = 0;
            if (cbootBinary == null || cbootBinary.Length < CbootNeedle.Length)
                return cbootBinary;

            // Find all occurrences of the needle
            var matches = new List<int>();
            for (int i = 0; i <= cbootBinary.Length - CbootNeedle.Length; i++)
            {
                bool found = true;
                for (int j = 0; j < CbootNeedle.Length; j++)
                {
                    if (cbootBinary[i + j] != CbootNeedle[j])
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                    matches.Add(i);
            }

            // Must find exactly 2 occurrences
            if (matches.Count != 2)
                return cbootBinary; // Already patched, or unexpected structure

            // Apply patch to both occurrences
            byte[] patched = new byte[cbootBinary.Length];
            Array.Copy(cbootBinary, patched, cbootBinary.Length);

            foreach (int offset in matches)
            {
                Array.Copy(CbootPatch, 0, patched, offset, CbootPatch.Length);
                patchCount++;
            }

            return patched;
        }

        /// <summary>Check if a CBOOT binary is already patched (sample mode enabled)</summary>
        public static bool IsCBOOTPatched(byte[] cbootBinary)
        {
            if (cbootBinary == null) return false;

            // Look for the patched pattern (NOPs + mov #1)
            for (int i = 0; i <= cbootBinary.Length - CbootPatch.Length; i++)
            {
                bool found = true;
                for (int j = 0; j < CbootPatch.Length; j++)
                {
                    if (cbootBinary[i + j] != CbootPatch[j])
                    {
                        found = false;
                        break;
                    }
                }
                if (found) return true;
            }
            return false;
        }

        // ====================================================================================
        //  LZSS COMPRESSION / DECOMPRESSION
        // ====================================================================================

        // LZSS parameters matching VW_Flash implementation
        private const int EI = 10;   // Window size exponent (10 bits for position)
        private const int EJ = 6;    // Match length exponent (6 bits for length)
        private const int P = 2;     // Minimum match threshold
        private const int N = 1 << EI;       // 1024 - Window size
        private const int F = (1 << EJ) + 1; // 65 - Max match length

        /// <summary>LZSS compress data (matching VW_Flash algorithm)</summary>
        public static byte[] LZSSCompress(byte[] input)
        {
            var output = new List<byte>();
            byte[] window = new byte[N];
            for (int i = 0; i < N; i++) window[i] = 0x20; // Fill with spaces per VW_Flash
            int windowPos = 0;
            int inputPos = 0;

            var pendingBits = new List<int>();

            Action<int, int> writeBits = (value, numBits) =>
            {
                for (int i = numBits - 1; i >= 0; i--)
                    pendingBits.Add((value >> i) & 1);
            };

            while (inputPos < input.Length)
            {
                int bestLen = 0;
                int bestOff = 0;

                for (int off = 0; off < N; off++)
                {
                    int matchLen = 0;
                    while (matchLen < F && inputPos + matchLen < input.Length &&
                           window[(off + matchLen) % N] == input[inputPos + matchLen])
                        matchLen++;

                    if (matchLen > bestLen)
                    {
                        bestLen = matchLen;
                        bestOff = off;
                    }
                }

                if (bestLen >= P + 1)
                {
                    writeBits(0, 1);
                    writeBits(bestOff, EI);
                    writeBits(bestLen - P, EJ);

                    for (int i = 0; i < bestLen; i++)
                    {
                        window[windowPos] = input[inputPos++];
                        windowPos = (windowPos + 1) % N;
                    }
                }
                else
                {
                    writeBits(1, 1);
                    writeBits(input[inputPos], 8);
                    window[windowPos] = input[inputPos++];
                    windowPos = (windowPos + 1) % N;
                }
            }

            for (int i = 0; i < pendingBits.Count; i += 8)
            {
                byte b = 0;
                for (int j = 0; j < 8 && i + j < pendingBits.Count; j++)
                    b |= (byte)(pendingBits[i + j] << (7 - j));
                output.Add(b);
            }

            return output.ToArray();
        }

        /// <summary>LZSS decompress data (matching VW_Flash algorithm)</summary>
        public static byte[] LZSSDecompress(byte[] input, int expectedSize = 0)
        {
            var output = new List<byte>();
            byte[] window = new byte[N];
            for (int i = 0; i < N; i++) window[i] = 0x20;
            int windowPos = 0;
            int bitPos = 0;

            Func<int> readBit = () =>
            {
                if (bitPos / 8 >= input.Length) return -1;
                int bit = (input[bitPos / 8] >> (7 - (bitPos % 8))) & 1;
                bitPos++;
                return bit;
            };

            Func<int, int> readBits = (int n) =>
            {
                int value = 0;
                for (int i = 0; i < n; i++)
                {
                    int bit = readBit();
                    if (bit < 0) return -1;
                    value = (value << 1) | bit;
                }
                return value;
            };

            while (true)
            {
                if (expectedSize > 0 && output.Count >= expectedSize) break;

                int controlBit = readBit();
                if (controlBit < 0) break;

                if (controlBit == 1)
                {
                    int b = readBits(8);
                    if (b < 0) break;
                    output.Add((byte)b);
                    window[windowPos] = (byte)b;
                    windowPos = (windowPos + 1) % N;
                }
                else
                {
                    int offset = readBits(EI);
                    if (offset < 0) break;
                    int length = readBits(EJ);
                    if (length < 0) break;
                    length += P;

                    for (int i = 0; i < length; i++)
                    {
                        byte b = window[(offset + i) % N];
                        output.Add(b);
                        window[windowPos] = b;
                        windowPos = (windowPos + 1) % N;
                    }
                }
            }

            return output.ToArray();
        }

        // ====================================================================================
        //  BLOCK DATA PREPARATION PIPELINE
        // ====================================================================================

        /// <summary>
        /// Prepare a block for flashing: compress (LZSS) + encrypt (AES/XOR/DSG).
        /// Returns the PreparedBlockData ready for UDS transfer.
        /// </summary>
        public static Simos18PreparedBlock PrepareBlockForFlash(Simos18Block blockDef, byte[] rawData,
            VWECUProfile profile, byte[] dsgKeyTable = null, bool isPatchBlock = false)
        {
            var prepared = new Simos18PreparedBlock
            {
                BlockDef = blockDef,
                RawData = rawData,
                CompressionType = profile.CompressionType,
                EncryptionType = profile.EncryptionType
            };

            try
            {
                byte[] processedData = rawData;

                // Step 1: Compress if needed (skip for patch blocks)
                if (!isPatchBlock && profile.CompressionType != 0x00)
                {
                    processedData = LZSSCompress(processedData);
                }

                // Step 2: Encrypt
                processedData = EncryptBlock(processedData, profile, dsgKeyTable);

                // For patch blocks: no compression, but encryption is still applied
                if (isPatchBlock)
                {
                    prepared.CompressionType = 0x00;
                }

                prepared.PreparedData = processedData;
                prepared.IsValid = true;
                prepared.Status = $"OK ({rawData.Length} -> {processedData.Length} bytes)";
            }
            catch (Exception ex)
            {
                prepared.IsValid = false;
                prepared.Status = $"Error: {ex.Message}";
                prepared.PreparedData = rawData;
            }

            return prepared;
        }

        // ====================================================================================
        //  FRF BLOCK DECRYPTION PIPELINE (decrypt + decompress extracted ODX blocks)
        // ====================================================================================

        /// <summary>
        /// Decrypt and decompress a flash block extracted from FRF/ODX.
        /// The ENCRYPT-COMPRESS-METHOD field from ODX specifies the algorithms.
        /// </summary>
        /// <param name="encryptedBlockData">Hex-decoded raw block data from ODX</param>
        /// <param name="compressType">Compression type character from ODX ('A'/'a' = LZSS10, '1' = legacy, '0' = none)</param>
        /// <param name="encryptType">Encryption type character from ODX ('0' = none, else = profile crypto)</param>
        /// <param name="profile">ECU profile for crypto keys</param>
        /// <param name="expectedSize">Expected decompressed size (0 = auto)</param>
        /// <param name="dsgKeyTable">DSG key table if applicable</param>
        public static byte[] DecryptAndDecompressFRFBlock(byte[] encryptedBlockData, char compressType, char encryptType,
            VWECUProfile profile, int expectedSize = 0, byte[] dsgKeyTable = null)
        {
            byte[] data = encryptedBlockData;

            // Step 1: Decrypt if needed
            if (encryptType != '0')
            {
                data = DecryptBlock(data, profile, dsgKeyTable);
            }

            // Step 2: Decompress if needed
            if (compressType == 'A' || compressType == 'a')
            {
                data = LZSSDecompress(data, expectedSize);
            }
            // Type '1' = legacy Simos compression (not commonly used, skip for now)

            return data;
        }

        // ====================================================================================
        //  BIN FILE ASSEMBLY / EXTRACTION
        // ====================================================================================

        /// <summary>Assemble individual blocks into a full BIN file using profile layout</summary>
        public static byte[] AssembleFullBin(Dictionary<int, byte[]> blockData, VWECUProfile profile)
        {
            byte[] fullBin = new byte[profile.BinFileSize];

            foreach (var kvp in blockData)
            {
                var blockDef = profile.GetBlock(kvp.Key);
                if (blockDef == null || blockDef.BinFileOffset == 0 && kvp.Key != 0) continue;

                uint offset = blockDef.BinFileOffset;
                int copyLen = Math.Min(kvp.Value.Length, (int)(profile.BinFileSize - offset));
                if (copyLen > 0)
                    Array.Copy(kvp.Value, 0, fullBin, (int)offset, copyLen);
            }

            return fullBin;
        }

        /// <summary>Extract individual blocks from a full BIN file using profile layout</summary>
        public static Dictionary<int, byte[]> ExtractBlocksFromFullBin(byte[] fullBin, VWECUProfile profile)
        {
            var blocks = new Dictionary<int, byte[]>();

            foreach (var kvp in profile.Blocks)
            {
                if (kvp.Key == 0) continue; // Skip SBOOT
                var blockDef = kvp.Value;
                if (blockDef.Size == 0) continue;

                uint offset = blockDef.BinFileOffset;
                if (offset + blockDef.Size > fullBin.Length) continue;

                byte[] blockData = new byte[blockDef.Size];
                Array.Copy(fullBin, (int)offset, blockData, 0, (int)blockDef.Size);
                blocks[kvp.Key] = blockData;
            }

            return blocks;
        }
    }
}
