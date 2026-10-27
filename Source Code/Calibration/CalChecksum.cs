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
//  Tester Present Specialist Automotive Solutions — Calibration Workbench
//
//  CalChecksum.cs — checksum framework.  A modified image with a stale checksum will not
//  flash (or will brick), so this is the highest-stakes gate in the workbench.  The
//  framework computes / verifies / corrects per-region checksums with a pluggable
//  algorithm set (Sum16, Sum32, CRC16-CCITT, CRC32).  Per-ECU/per-OEM algorithms are
//  registered as regions; until a region is configured for an image the editor allows
//  bench saving but flags "checksum not configured" and refuses to mark the write
//  flash-ready.  Bench editing is never blocked.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace TesterPresent.OBD2.Calibration
{
    public enum ChecksumAlgo { Sum8, Sum16, Sum32, Xor32, Crc16Ccitt, Crc32 }

    /// <summary>One protected region: a data span and where its checksum is stored.</summary>
    public sealed class ChecksumRegion
    {
        public string       Name        { get; set; } = "Region";
        public ChecksumAlgo Algo        { get; set; } = ChecksumAlgo.Crc32;
        public long         DataStart   { get; set; }
        public long         DataLength  { get; set; }
        public long         StoreOffset { get; set; }   // where the checksum word lives
        public CalEndian    Endian      { get; set; } = CalEndian.Little;

        public int StoreSize
        {
            get
            {
                switch (Algo)
                {
                    case ChecksumAlgo.Sum8:       return 1;
                    case ChecksumAlgo.Sum16:
                    case ChecksumAlgo.Crc16Ccitt: return 2;
                    default:                      return 4;
                }
            }
        }
    }

    public sealed class ChecksumStatus
    {
        public ChecksumRegion Region   { get; set; }
        public ulong          Computed { get; set; }
        public ulong          Stored   { get; set; }
        public bool           Ok       => Computed == Stored;
    }

    public static class CalChecksum
    {
        // CRC32 (IEEE 802.3, reflected, poly 0xEDB88320) — the most common firmware CRC.
        private static readonly uint[] Crc32Table = BuildCrc32Table();
        private static uint[] BuildCrc32Table()
        {
            var t = new uint[256];
            for (uint i = 0; i < 256; i++)
            {
                uint c = i;
                for (int k = 0; k < 8; k++)
                    c = (c & 1) != 0 ? 0xEDB88320 ^ (c >> 1) : c >> 1;
                t[i] = c;
            }
            return t;
        }

        public static ulong Compute(byte[] data, ChecksumRegion r)
        {
            long start = r.DataStart, len = r.DataLength;
            // Overflow-safe (start+len can wrap for adversarial region offsets) + null guard.
            if (data == null || start < 0 || len <= 0 || start > data.Length - len) return 0;

            switch (r.Algo)
            {
                case ChecksumAlgo.Sum8:
                {
                    byte s = 0;
                    for (long i = 0; i < len; i++) s += data[start + i];
                    return s;
                }
                case ChecksumAlgo.Sum16:
                {
                    ushort s = 0;
                    for (long i = 0; i < len; i++) s += data[start + i];
                    return s;
                }
                case ChecksumAlgo.Sum32:
                {
                    uint s = 0;
                    for (long i = 0; i < len; i++) s += data[start + i];
                    return s;
                }
                case ChecksumAlgo.Xor32:
                {
                    uint s = 0; int word = 0; uint acc = 0;
                    for (long i = 0; i < len; i++)
                    {
                        acc |= (uint)data[start + i] << (8 * word);
                        if (++word == 4) { s ^= acc; acc = 0; word = 0; }
                    }
                    if (word != 0) s ^= acc;
                    return s;
                }
                case ChecksumAlgo.Crc16Ccitt:
                {
                    ushort crc = 0xFFFF;
                    for (long i = 0; i < len; i++)
                    {
                        crc ^= (ushort)(data[start + i] << 8);
                        for (int k = 0; k < 8; k++)
                            crc = (ushort)((crc & 0x8000) != 0 ? (crc << 1) ^ 0x1021 : crc << 1);
                    }
                    return crc;
                }
                case ChecksumAlgo.Crc32:
                default:
                {
                    uint crc = 0xFFFFFFFF;
                    for (long i = 0; i < len; i++)
                        crc = Crc32Table[(crc ^ data[start + i]) & 0xFF] ^ (crc >> 8);
                    return crc ^ 0xFFFFFFFF;
                }
            }
        }

        public static ulong ReadStored(byte[] data, ChecksumRegion r)
        {
            int size = r.StoreSize;
            if (data == null || size <= 0 || r.StoreOffset < 0 || r.StoreOffset > data.Length - size) return 0;
            var buf = new byte[size];
            Array.Copy(data, r.StoreOffset, buf, 0, size);
            if (r.Endian == CalEndian.Big) Array.Reverse(buf);
            ulong v = 0;
            for (int i = size - 1; i >= 0; i--) v = (v << 8) | buf[i];
            return v;
        }

        public static ChecksumStatus Verify(byte[] data, ChecksumRegion r)
            => new ChecksumStatus { Region = r, Computed = Compute(data, r), Stored = ReadStored(data, r) };

        /// <summary>Write the freshly-computed checksum back into the image's store offset.</summary>
        public static bool Correct(byte[] data, ChecksumRegion r)
        {
            ulong v = Compute(data, r);
            int size = r.StoreSize;
            if (data == null || size <= 0 || r.StoreOffset < 0 || r.StoreOffset > data.Length - size) return false;
            var buf = new byte[size];
            for (int i = 0; i < size; i++) buf[i] = (byte)((v >> (8 * i)) & 0xFF);
            if (r.Endian == CalEndian.Big) Array.Reverse(buf);
            Array.Copy(buf, 0, data, r.StoreOffset, size);
            return true;
        }
    }

    /// <summary>Per-image checksum configuration (a named set of regions, persistable alongside the project).</summary>
    public sealed class ChecksumProfile
    {
        public string Name { get; set; } = "(none)";
        public List<ChecksumRegion> Regions { get; } = new List<ChecksumRegion>();
        public bool Configured => Regions.Count > 0;
    }
}
