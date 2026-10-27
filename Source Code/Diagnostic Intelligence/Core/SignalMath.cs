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
//  Tester Present Specialist Automotive Solutions — Signal Math
//
//  Small, dependency-free numerical helpers shared across the intelligence
//  layer: Welford's online mean/variance accumulator (used by the fleet store
//  and the operating-point grid), coefficient-of-variation, robust percentile,
//  linear regression slope, and a simple recursive-least-squares tracker.
//
//  No MathNet, no external package — the math is small enough to self-contain
//  and this keeps the obfuscated x86 build free of another native dependency.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;

namespace TesterPresent.OBD2.Intelligence
{
    /// <summary>
    /// Welford's online algorithm for numerically-stable running mean and
    /// variance.  O(1) per sample, no accumulation of catastrophic cancellation.
    /// Mutable struct — hold it in a field, not a readonly.
    /// </summary>
    public struct WelfordAccumulator
    {
        public long Count;
        public double Mean;
        private double _m2;
        public double Min;
        public double Max;

        public void Add(double x)
        {
            if (Count == 0) { Min = x; Max = x; }
            else { if (x < Min) Min = x; if (x > Max) Max = x; }
            Count++;
            double delta = x - Mean;
            Mean += delta / Count;
            double delta2 = x - Mean;
            _m2 += delta * delta2;
        }

        /// <summary>Population variance (divides by N). Zero for &lt; 2 samples.</summary>
        public double Variance => Count > 1 ? _m2 / Count : 0.0;

        /// <summary>Sample variance (divides by N-1). Zero for &lt; 2 samples.</summary>
        public double SampleVariance => Count > 1 ? _m2 / (Count - 1) : 0.0;

        public double StdDev => Math.Sqrt(Variance);
        public double SampleStdDev => Math.Sqrt(SampleVariance);

        /// <summary>Merge another accumulator (parallel-chunk combine).</summary>
        public void Merge(WelfordAccumulator other)
        {
            if (other.Count == 0) return;
            if (Count == 0) { this = other; return; }
            long n = Count + other.Count;
            double delta = other.Mean - Mean;
            double mean = Mean + delta * other.Count / n;
            double m2 = _m2 + other._m2 + delta * delta * Count * other.Count / n;
            Mean = mean;
            _m2 = m2;
            Count = n;
            if (other.Min < Min) Min = other.Min;
            if (other.Max > Max) Max = other.Max;
        }
    }

    /// <summary>Static numerical helpers over sample sequences.</summary>
    public static class SignalMath
    {
        public static double Mean(IEnumerable<double> xs)
        {
            double sum = 0; long n = 0;
            foreach (var x in xs) { sum += x; n++; }
            return n == 0 ? 0 : sum / n;
        }

        public static double StdDev(IReadOnlyList<double> xs, bool sample = false)
        {
            if (xs == null || xs.Count < 2) return 0;
            double m = 0; for (int i = 0; i < xs.Count; i++) m += xs[i]; m /= xs.Count;
            double s2 = 0; for (int i = 0; i < xs.Count; i++) { double d = xs[i] - m; s2 += d * d; }
            return Math.Sqrt(s2 / (sample ? xs.Count - 1 : xs.Count));
        }

        /// <summary>Coefficient of variation = stddev / |mean|.  Returns 0 when
        /// mean is ~0 to avoid a divide-by-zero blowing up the ratio.</summary>
        public static double CoefficientOfVariation(IReadOnlyList<double> xs)
        {
            if (xs == null || xs.Count < 2) return 0;
            double m = Mean(xs);
            if (Math.Abs(m) < 1e-9) return 0;
            return StdDev(xs) / Math.Abs(m);
        }

        /// <summary>Linear-interpolated percentile (0..100) over a copy of the data.</summary>
        public static double Percentile(IReadOnlyList<double> xs, double p)
        {
            if (xs == null || xs.Count == 0) return 0;
            if (xs.Count == 1) return xs[0];
            var sorted = xs.ToArray();
            Array.Sort(sorted);
            double rank = (p / 100.0) * (sorted.Length - 1);
            int lo = (int)Math.Floor(rank);
            int hi = (int)Math.Ceiling(rank);
            if (lo == hi) return sorted[lo];
            double frac = rank - lo;
            return sorted[lo] * (1 - frac) + sorted[hi] * frac;
        }

        public static double Median(IReadOnlyList<double> xs) => Percentile(xs, 50);

        /// <summary>Ordinary-least-squares slope of y vs x (per unit x). Zero if degenerate.</summary>
        public static double Slope(IReadOnlyList<double> x, IReadOnlyList<double> y)
        {
            if (x == null || y == null || x.Count != y.Count || x.Count < 2) return 0;
            double mx = Mean(x), my = Mean(y);
            double num = 0, den = 0;
            for (int i = 0; i < x.Count; i++)
            {
                double dx = x[i] - mx;
                num += dx * (y[i] - my);
                den += dx * dx;
            }
            return Math.Abs(den) < 1e-12 ? 0 : num / den;
        }

        /// <summary>Z-score of a value against a known mean and stddev. Zero if stddev ~0.</summary>
        public static double ZScore(double value, double mean, double stdDev)
            => stdDev < 1e-9 ? 0 : (value - mean) / stdDev;

        /// <summary>Clamp helper (System.Math.Clamp is not available on net4.8).</summary>
        public static double Clamp(double v, double lo, double hi)
            => v < lo ? lo : (v > hi ? hi : v);
    }

    /// <summary>
    /// Scalar recursive-least-squares tracker with a forgetting factor.
    /// Estimates a slowly-drifting parameter θ in the model y = θ·φ + noise
    /// (φ = regressor).  Used by T3 prognostics to track e.g. volumetric-
    /// efficiency drift.  Kept scalar to stay dependency-free; the vector form
    /// is a future extension if a module needs multi-parameter estimation.
    /// </summary>
    public sealed class ScalarRls
    {
        private double _theta;
        private double _p;              // covariance
        private readonly double _lambda; // forgetting factor (0.95–1.0)

        public ScalarRls(double initialTheta = 0, double initialCovariance = 1e4, double forgettingFactor = 0.999)
        {
            _theta = initialTheta;
            _p = initialCovariance;
            _lambda = forgettingFactor <= 0 ? 1.0 : forgettingFactor;
        }

        public double Theta => _theta;
        public double Covariance => _p;

        /// <summary>Feed one (regressor φ, measurement y) pair; returns updated θ.</summary>
        public double Update(double phi, double y)
        {
            double denom = _lambda + phi * _p * phi;
            if (Math.Abs(denom) < 1e-12) return _theta;
            double gain = _p * phi / denom;
            double err = y - _theta * phi;
            _theta += gain * err;
            _p = (_p - gain * phi * _p) / _lambda;
            return _theta;
        }
    }
}
