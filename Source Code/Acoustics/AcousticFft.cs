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
//  Tester Present Specialist Automotive Solutions — Acoustic Diagnostics: FFT core
//  Copyright (c) 2026 Benjamin Jack Leighton. All rights reserved.
//
//  Self-contained iterative radix-2 Cooley-Tukey FFT + analysis windows + one-sided magnitude
//  in dBFS. No external dependency (System only) — the feasibility survey confirmed the solution
//  had NO FFT anywhere; this is that gap filled, in the house "hand-rolled, dependency-free DSP"
//  style of Intelligence\Tier2\T4_FrequencyResponse.cs, but built for audio-rate block transforms
//  rather than single-tone OBD estimation.
//
//  dBFS convention: a full-scale (±1.0) sine reads ~0 dBFS at its bin. Amplitude recovery uses the
//  window's coherent gain (sum of taps), so Hann/Hamming/Blackman-Harris all read the same peak
//  level for the same tone — only the skirts differ. All work is caller-allocated (scratch arrays
//  passed in) so the per-frame path on the UI timer allocates nothing.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;

namespace TesterPresent.OBD2.Acoustics
{
    public enum FftWindow { Rectangular, Hann, Hamming, BlackmanHarris }

    public static class AcousticFft
    {
        /// <summary>In-place iterative radix-2 forward FFT. <paramref name="re"/>/<paramref name="im"/>
        /// must be the same power-of-two length.</summary>
        public static void Forward(double[] re, double[] im)
        {
            int n = re.Length;
            if (n < 2 || (n & (n - 1)) != 0)
                throw new ArgumentException("FFT length must be a power of two ≥ 2.");

            // Decimation-in-time bit-reversal permutation.
            for (int i = 1, j = 0; i < n; i++)
            {
                int bit = n >> 1;
                for (; (j & bit) != 0; bit >>= 1) j ^= bit;
                j ^= bit;
                if (i < j)
                {
                    double tr = re[i]; re[i] = re[j]; re[j] = tr;
                    double ti = im[i]; im[i] = im[j]; im[j] = ti;
                }
            }

            for (int len = 2; len <= n; len <<= 1)
            {
                double ang = -2.0 * Math.PI / len;
                double wr = Math.Cos(ang), wi = Math.Sin(ang);
                int half = len >> 1;
                for (int i = 0; i < n; i += len)
                {
                    double cr = 1.0, ci = 0.0;
                    for (int k = 0; k < half; k++)
                    {
                        int a = i + k, b = a + half;
                        double xr = re[b] * cr - im[b] * ci;
                        double xi = re[b] * ci + im[b] * cr;
                        re[b] = re[a] - xr; im[b] = im[a] - xi;
                        re[a] += xr;       im[a] += xi;
                        double ncr = cr * wr - ci * wi;
                        ci = cr * wi + ci * wr;
                        cr = ncr;
                    }
                }
            }
        }

        /// <summary>Build an analysis window of <paramref name="n"/> taps.</summary>
        public static double[] MakeWindow(FftWindow type, int n)
        {
            var w = new double[n];
            if (n == 1) { w[0] = 1.0; return w; }
            for (int i = 0; i < n; i++)
            {
                double x = (double)i / (n - 1);
                double c1 = Math.Cos(2.0 * Math.PI * x);
                switch (type)
                {
                    case FftWindow.Hann:          w[i] = 0.5 - 0.5 * c1; break;
                    case FftWindow.Hamming:       w[i] = 0.54 - 0.46 * c1; break;
                    case FftWindow.BlackmanHarris:
                        double c2 = Math.Cos(4.0 * Math.PI * x);
                        double c3 = Math.Cos(6.0 * Math.PI * x);
                        w[i] = 0.35875 - 0.48829 * c1 + 0.14128 * c2 - 0.01168 * c3;
                        break;
                    default:                      w[i] = 1.0; break;
                }
            }
            return w;
        }

        /// <summary>
        /// Window <paramref name="count"/> real samples, forward-transform them, and write one-sided
        /// magnitude in dBFS to <paramref name="outDb"/> (indices 0..count/2). Also returns broadband
        /// RMS and peak level of the raw (un-windowed) block in dBFS. All buffers are caller-owned:
        /// <paramref name="win"/>/<paramref name="re"/>/<paramref name="im"/> length == count,
        /// <paramref name="outDb"/> length ≥ count/2 + 1.
        /// </summary>
        public static void MagnitudeDb(
            float[] samples, int offset, int count, double[] win,
            double[] re, double[] im, float[] outDb,
            out double rmsDbfs, out double peakDbfs)
        {
            double sumW = 0.0, sumSq = 0.0, peak = 0.0;
            for (int i = 0; i < count; i++)
            {
                double s = samples[offset + i];
                re[i] = s * win[i];
                im[i] = 0.0;
                sumW += win[i];
                double a = s < 0 ? -s : s;
                if (a > peak) peak = a;
                sumSq += s * s;
            }

            Forward(re, im);

            // Coherent-gain scaling: |X[k]| = A·sumW/2 for a sine of amplitude A at bin k.
            double scale = 2.0 / (sumW <= 0 ? 1.0 : sumW);
            int half = count >> 1;
            for (int k = 0; k <= half; k++)
            {
                // bug-audit: the single-sided ×2 correction compensates for the negative-frequency
                // mirror image, which the DC bin (k=0) and the Nyquist bin (k=half) do not have — for
                // an even N those two must use 1/sumW, not 2/sumW, or they read +6 dB high.
                double binScale = (k == 0 || k == half) ? scale * 0.5 : scale;
                double mag = Math.Sqrt(re[k] * re[k] + im[k] * im[k]) * binScale;
                outDb[k] = (float)(mag > 1e-12 ? 20.0 * Math.Log10(mag) : -240.0);
            }

            double rms = Math.Sqrt(sumSq / count);
            rmsDbfs  = rms  > 1e-9 ? 20.0 * Math.Log10(rms)  : -240.0;
            peakDbfs = peak > 1e-9 ? 20.0 * Math.Log10(peak) : -240.0;
        }

        /// <summary>Frequency (Hz) of one-sided bin <paramref name="bin"/>.</summary>
        public static double BinToHz(int bin, double sampleRate, int fftSize)
            => bin * sampleRate / fftSize;

        /// <summary>Nearest one-sided bin index for a frequency, clamped to [0, fftSize/2].</summary>
        public static int HzToBin(double hz, double sampleRate, int fftSize)
        {
            int b = (int)Math.Round(hz * fftSize / sampleRate);
            if (b < 0) b = 0;
            int max = fftSize / 2;
            if (b > max) b = max;
            return b;
        }
    }
}
