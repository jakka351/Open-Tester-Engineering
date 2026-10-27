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
//  CalModel.cs — the unified, definition-agnostic calibration model.
//
//  Both the A2L (ASAM MCD-2 MC) importer and the TunerPro XDF importer target this
//  single model, so the editor, the 3D/heatmap views, the binary read/write engine and
//  the checksum framework are written ONCE against it.  Adding a new definition format
//  is just another importer; adding a new ECU is just another checksum plug-in.
//
//  A CalTable is a scalar, a 1-D curve, a 2-D map, an array (VAL_BLK) or a string.
//  Each table carries its own data layout (type, endianness, rows/cols, address) plus a
//  z-axis Conversion (raw<->physical) and optional X/Y CalAxis objects.  The address is
//  the definition's address; CalBinary turns it into a file offset.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;

namespace TesterPresent.OBD2.Calibration
{
    /// <summary>Storage type of a calibration element in the binary image.</summary>
    public enum CalDataType
    {
        U8, S8, U16, S16, U32, S32, U64, S64, F32, F64
    }

    /// <summary>Shape of a calibration object.</summary>
    public enum CalTableKind
    {
        Scalar,     // single value (A2L VALUE / XDF XDFCONSTANT)
        Curve,      // 1-D table with one axis (A2L CURVE)
        Map,        // 2-D table with two axes (A2L MAP / XDF XDFTABLE)
        Array,      // fixed-length block, no axes (A2L VAL_BLK)
        Ascii,      // string (A2L ASCII)
        Axis,       // a stand-alone axis (A2L AXIS_PTS) surfaced as its own editable curve
        Flag        // bit flag / boolean (XDF XDFFLAG)
    }

    /// <summary>
    /// Safety/legal classification used to colour-flag tables and gate writing-to-ECU.
    /// The editor never blocks bench editing, but it warns loudly and (for safety class)
    /// double-confirms before a value that controls a safety system is changed.
    /// </summary>
    public enum CalRiskClass
    {
        Normal,
        Emissions,   // cat/EGR/DPF/O2/lambda/readiness — legal line in many jurisdictions
        Safety       // torque limits, ABS/airbag/restraint thresholds, rev/boost limiters
    }

    /// <summary>Byte order of multi-byte values in the image.</summary>
    public enum CalEndian { Little, Big }

    public static class CalDataTypeInfo
    {
        public static int SizeBytes(CalDataType t)
        {
            switch (t)
            {
                case CalDataType.U8:
                case CalDataType.S8:  return 1;
                case CalDataType.U16:
                case CalDataType.S16: return 2;
                case CalDataType.U32:
                case CalDataType.S32:
                case CalDataType.F32: return 4;
                case CalDataType.U64:
                case CalDataType.S64:
                case CalDataType.F64: return 8;
                default: return 1;
            }
        }

        public static bool IsSigned(CalDataType t)
            => t == CalDataType.S8 || t == CalDataType.S16 || t == CalDataType.S32 || t == CalDataType.S64;

        public static bool IsFloat(CalDataType t)
            => t == CalDataType.F32 || t == CalDataType.F64;

        /// <summary>Map an A2L DATATYPE token to a CalDataType.</summary>
        public static CalDataType FromA2l(string token)
        {
            switch ((token ?? "").Trim().ToUpperInvariant())
            {
                case "UBYTE":        return CalDataType.U8;
                case "SBYTE":        return CalDataType.S8;
                case "UWORD":        return CalDataType.U16;
                case "SWORD":        return CalDataType.S16;
                case "ULONG":        return CalDataType.U32;
                case "SLONG":        return CalDataType.S32;
                case "A_UINT64":     return CalDataType.U64;
                case "A_INT64":      return CalDataType.S64;
                case "FLOAT32_IEEE": return CalDataType.F32;
                case "FLOAT64_IEEE": return CalDataType.F64;
                default:             return CalDataType.U8;
            }
        }

        /// <summary>Map a TunerPro element size (bits) + signed/float flags to a CalDataType.</summary>
        public static CalDataType FromXdf(int sizeBits, bool signed, bool isFloat)
        {
            if (isFloat) return sizeBits >= 64 ? CalDataType.F64 : CalDataType.F32;
            switch (sizeBits)
            {
                case 8:  return signed ? CalDataType.S8  : CalDataType.U8;
                case 16: return signed ? CalDataType.S16 : CalDataType.U16;
                case 32: return signed ? CalDataType.S32 : CalDataType.U32;
                case 64: return signed ? CalDataType.S64 : CalDataType.U64;
                default: return signed ? CalDataType.S8  : CalDataType.U8;
            }
        }
    }

    /// <summary>
    /// One axis of a table.  Either embedded (its values live in the binary at Address,
    /// with their own data type and conversion) or static (a fixed label list that is not
    /// stored in the image — A2L FIX_AXIS, or an index axis).
    /// </summary>
    public sealed class CalAxis
    {
        public string       Name        { get; set; } = "";
        public string       Units       { get; set; } = "";
        public int          Count       { get; set; } = 1;

        // Embedded axis (values read from / written to the image)
        public bool         IsEmbedded  { get; set; }
        public uint         Address     { get; set; }
        public CalDataType  DataType    { get; set; } = CalDataType.U16;
        public CalEndian    Endian      { get; set; } = CalEndian.Little;
        public CalConversion Conversion { get; set; } = CalConversion.Identity;

        // Static axis (fixed numeric labels, not stored in the image)
        public double[]     StaticValues { get; set; }

        public double Min { get; set; }
        public double Max { get; set; }

        public static CalAxis Index(int count)
            => new CalAxis { Name = "Index", Count = count, IsEmbedded = false,
                             StaticValues = Enumerable.Range(0, count).Select(i => (double)i).ToArray() };
    }

    /// <summary>A single calibration object (scalar / curve / map / array / axis / flag / string).</summary>
    public sealed class CalTable
    {
        public string        Name        { get; set; } = "";
        public string        Title       { get; set; } = "";
        public string        Description { get; set; } = "";
        public CalTableKind  Kind        { get; set; } = CalTableKind.Scalar;
        public CalRiskClass  Risk        { get; set; } = CalRiskClass.Normal;

        /// <summary>Hierarchical category path for the table tree (e.g. ["Fuel","VE Tables"]).</summary>
        public List<string>  Categories  { get; } = new List<string>();

        // ── Z (value) data layout ────────────────────────────────────────────────
        public uint          Address     { get; set; }
        public CalDataType   DataType    { get; set; } = CalDataType.U8;
        public CalEndian     Endian      { get; set; } = CalEndian.Little;
        public int           Columns     { get; set; } = 1;   // X count
        public int           Rows        { get; set; } = 1;   // Y count
        /// <summary>
        /// Z-cell ordering of the flat data block in the image.
        /// false = row-major (idx = row*Cols + col) — the A2L / ASAM default.
        /// true  = column-major (idx = col*Rows + row) — TunerPro's XDF layout for 2-D
        /// tables. Set per-parser so XDF and A2L maps each read in their native order;
        /// <see cref="CalBinary.CellOffset"/> honours it. (No effect on 1-D tables.)
        /// </summary>
        public bool          ColumnMajor { get; set; }
        public CalConversion Conversion  { get; set; } = CalConversion.Identity;
        public string        Units       { get; set; } = "";
        public string        DisplayFormat { get; set; } = "0.###";

        // Display/clamp limits (physical)
        public double        Min         { get; set; } = double.NegativeInfinity;
        public double        Max         { get; set; } = double.PositiveInfinity;

        // Optional axes
        public CalAxis       XAxis       { get; set; }
        public CalAxis       YAxis       { get; set; }

        // For Flag tables
        public uint          BitMask     { get; set; }

        public int Cells => Math.Max(1, Columns) * Math.Max(1, Rows);

        /// <summary>Total byte span of the z-data block in the image.</summary>
        public int ByteSize => CalDataTypeInfo.SizeBytes(DataType) * Cells;

        public bool IsTwoD  => Kind == CalTableKind.Map;
        public bool IsOneD  => Kind == CalTableKind.Curve || Kind == CalTableKind.Array || Kind == CalTableKind.Axis;
        public bool IsScalarLike => Kind == CalTableKind.Scalar || Kind == CalTableKind.Flag;

        public override string ToString()
            => $"{Title} [{Kind} {Columns}x{Rows} @0x{Address:X}]";
    }

    /// <summary>A loaded definition (one A2L or one XDF) reduced to the unified model.</summary>
    public sealed class CalProject
    {
        public enum SourceKind { A2L, XDF }

        public string       Name          { get; set; } = "Calibration";
        public SourceKind   Source        { get; set; }
        public string       SourcePath    { get; set; } = "";
        public List<CalTable> Tables      { get; } = new List<CalTable>();

        // Address → file-offset mapping.  fileOffset = Subtract ? addr - BaseAddress
        //                                                      : addr + BaseAddress
        // A2L: BaseAddress = the ROM/flash segment base, Subtract = true.
        // XDF: BaseAddress = header BASEOFFSET, Subtract per header attribute.
        public long         BaseAddress   { get; set; } = 0;
        public bool         SubtractBase  { get; set; } = true;

        public CalEndian    DefaultEndian { get; set; } = CalEndian.Little;
        public long         ExpectedImageSize { get; set; } = 0;   // hint from MEMORY_SEGMENT / REGION

        /// <summary>Distinct top-level category names, for the tree.</summary>
        public IEnumerable<string> TopCategories
            => Tables.Select(t => t.Categories.FirstOrDefault() ?? "Uncategorised")
                     .Distinct().OrderBy(s => s, StringComparer.OrdinalIgnoreCase);

        public long ToFileOffset(uint address)
            => SubtractBase ? address - BaseAddress : address + BaseAddress;
    }
}
