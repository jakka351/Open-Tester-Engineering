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
//  Tester Present Specialist Automotive Solutions — Calibration Constants (Primitive P8)
//
//  Separates per-platform numeric constants from framework logic, exactly as the
//  brief requires.  Every constant carries a Validated flag; a module that reads
//  ANY unvalidated constant must flag its result advisory (DiagnosticResult.
//  Advisory).  Seed values come from published engine specifications, never from
//  assumptions, and stay unvalidated until characterised against a real fault.
//
//  A module asks for a constant by key with a default:
//      double thr = cal.Value("M1.UniformDriftPct", 8.0, out bool validated);
//  If the platform doesn't define the key, it gets the default AND validated=false.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace TesterPresent.OBD2.Intelligence
{
    /// <summary>A single calibration constant plus its validation state and provenance.</summary>
    public sealed class CalibrationValue
    {
        public double Value { get; }
        public bool Validated { get; }
        public string Source { get; }

        public CalibrationValue(double value, bool validated, string source)
        {
            Value = value;
            Validated = validated;
            Source = source;
        }
    }

    /// <summary>
    /// Base class for a platform's calibration set.  Concrete platforms fill the
    /// dictionary in their constructor.  IsValidated is true only when EVERY
    /// value in the set is validated — the honest default is false for a
    /// spec-seeded set.
    /// </summary>
    public abstract class PlatformCalibration
    {
        protected readonly Dictionary<string, CalibrationValue> Values =
            new Dictionary<string, CalibrationValue>(StringComparer.OrdinalIgnoreCase);

        public abstract string PlatformId { get; }
        public abstract string DisplayName { get; }

        /// <summary>Add a spec-seeded (unvalidated) constant.</summary>
        protected void Seed(string key, double value, string source)
            => Values[key] = new CalibrationValue(value, false, source);

        /// <summary>Add a value validated against a real fault on a real vehicle.</summary>
        protected void Validated_(string key, double value, string source)
            => Values[key] = new CalibrationValue(value, true, source);

        /// <summary>True only if the set has values and every one is validated.</summary>
        public virtual bool IsValidated
        {
            get
            {
                if (Values.Count == 0) return false;
                foreach (var v in Values.Values) if (!v.Validated) return false;
                return true;
            }
        }

        public bool TryGet(string key, out CalibrationValue val) => Values.TryGetValue(key, out val);

        /// <summary>Get a constant's value with a fallback; reports whether the
        /// resolved value was validated (a missing key is never validated).</summary>
        public double Value(string key, double fallback, out bool validated)
        {
            CalibrationValue v;
            if (Values.TryGetValue(key, out v)) { validated = v.Validated; return v.Value; }
            validated = false;
            return fallback;
        }

        /// <summary>Value with fallback, ignoring the validated flag.</summary>
        public double Value(string key, double fallback)
        {
            bool _; return Value(key, fallback, out _);
        }

        public IReadOnlyDictionary<string, CalibrationValue> All => Values;
    }

    /// <summary>
    /// Resolves a platform calibration for the connected vehicle.  Ford AU (6FP…
    /// / 6MP… Broadmeadows VINs on the Ford OEM bucket) → FordFgCalibration;
    /// everything else → GenericCalibration (spec-generic, always advisory).
    ///
    /// Uses a self-registration list so this Core file carries no compile-time
    /// dependency on the concrete calibration classes.  Each concrete class
    /// registers itself via its static constructor being touched by
    /// EnsureBuiltInsRegistered().
    /// </summary>
    public static class CalibrationRegistry
    {
        private sealed class Provider
        {
            public Func<OEMManufacturer, string, bool> Matches;
            public Func<PlatformCalibration> Create;
            public int Priority;
        }

        private static readonly List<Provider> _providers = new List<Provider>();
        private static Func<PlatformCalibration> _fallback;
        private static Func<PlatformCalibration, PlatformCalibration> _overlay;
        private static readonly object _sync = new object();

        /// <summary>Install an overlay applied to every resolved calibration — used to layer
        /// field-validated overrides (a DB-backed store) over the spec-seeded base without a
        /// compile-time dependency from Core on the store.  Null (default) is a no-op.</summary>
        public static void SetOverlay(Func<PlatformCalibration, PlatformCalibration> overlay)
        {
            lock (_sync) { _overlay = overlay; }
        }

        /// <summary>Register a platform calibration provider. Higher priority wins.</summary>
        public static void Register(Func<OEMManufacturer, string, bool> matches,
                                    Func<PlatformCalibration> create, int priority = 0)
        {
            if (matches == null || create == null) return;
            lock (_sync) { _providers.Add(new Provider { Matches = matches, Create = create, Priority = priority }); }
        }

        /// <summary>Register the always-available generic fallback.</summary>
        public static void RegisterFallback(Func<PlatformCalibration> create)
        {
            lock (_sync) { _fallback = create; }
        }

        /// <summary>Resolve the best calibration for a vehicle. Never returns null.</summary>
        public static PlatformCalibration Resolve(OEMManufacturer oem, string vin)
        {
            PlatformCalibration baseCal = null;
            Func<PlatformCalibration, PlatformCalibration> overlay;
            lock (_sync)
            {
                Provider best = null;
                foreach (var p in _providers)
                {
                    try
                    {
                        if (!p.Matches(oem, vin ?? "")) continue;
                        if (best == null || p.Priority > best.Priority) best = p;
                    }
                    catch { }
                }
                if (best != null) { try { baseCal = best.Create(); } catch { } }
                if (baseCal == null && _fallback != null) { try { baseCal = _fallback(); } catch { } }
                if (baseCal == null) baseCal = new NullCalibration();
                overlay = _overlay;
            }
            // Apply the field-validated overlay OUTSIDE the lock (it may touch a JSON store).
            if (overlay != null) { try { var o = overlay(baseCal); if (o != null) return o; } catch { } }
            return baseCal;
        }

        /// <summary>Guaranteed non-null, always-unvalidated empty calibration.</summary>
        private sealed class NullCalibration : PlatformCalibration
        {
            public override string PlatformId => "None";
            public override string DisplayName => "No calibration";
            public override bool IsValidated => false;
        }
    }
}
