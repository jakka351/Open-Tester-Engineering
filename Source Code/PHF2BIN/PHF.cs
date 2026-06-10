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
 * Project Name:      PHF2BIN
 * Original Author:   Rollsch
 * Source URL:        https://github.com/rollsch/PHF2BIN
 * License:           None
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
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//  Tester Present Specialist Automotive Solutions — File Utilities → PHF2BIN sub-tab
//  Copyright (c) 2026 Benjamin Jack Leighton. All rights reserved.
//
//  Converts a Ford IDS PHF file to a flat binary image, suitable for editing in the
//  Hex Editor sub-tab or flashing back to a vehicle (subject to the usual VIN/PATS
//  caveats — see the original PHF2BIN README).
//
//  Format primer (per the upstream PHF2BIN reference, Plugin.FileFormat.PHF.cs)
//  -------------------------------------------------------------------------
//   1. Within the first 0x100 bytes of the PHF, an ASCII strategy marker appears:
//        SPANISHOAK  → 1 MiB     (0x100000) Falcon EEC-VI
//        BOAK        → 1.5 MiB   (0x180000) Black Oak
//        GOAK        → 1.5 MiB   (0x180000) Green Oak
//
//   2. The actual data section is found by searching for an 0x12-byte magic header
//      where bytes [0x10..0x11] are:
//        Spanish Oak: 0x10 0x60
//        Black/Green Oak: 0x30 0x60
//      (the first 0x10 bytes of the magic are zero, so we just match all 0x12.)
//
//   3. From the magic-header offset onwards, the PHF interleaves payload bytes
//      with two kinds of inline header that we must skip:
//        • Every 0x10000 (64 KiB) output bytes: skip 8 input bytes
//        • Every 0x20    (32  B) output bytes: skip 6 input bytes
//      Output bytes 0x8000..0xFFFF are NOT in the PHF — they are filled with 0xFF
//      (RTOS / OBD / UDS dispatcher live there in the actual ECU and aren't part
//       of the calibration image).
//
//   4. Resulting binary is right-sized to outputSize.  Sections that fall off the
//      end of the input are left as 0xFF (default-initialised array).
//
//  This file is purely additive — drops a new "PHF → BIN" sub-tab into the existing
//  File Utilities TabControl.  No changes to other tabs, no protocol code touched.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TesterPresent.OBD2
{
    public partial class ElectiveGeneral
    {
        // ── UI fields ─────────────────────────────────────────────────────────
        private TextBox _phfTxtInputPath, _phfTxtOutputPath, _phfTxtLog;
        private Label   _phfLblDetected, _phfLblInSize, _phfLblOutSize;
        private Button  _phfBtnBrowse, _phfBtnConvert, _phfBtnSaveAs;
        private byte[]  _phfInputBytes  = Array.Empty<byte>();
        private byte[]  _phfOutputBytes = Array.Empty<byte>();
        private string  _phfDetectedType = "";

        // ── Strategy table ────────────────────────────────────────────────────
        private static readonly (string Marker, string Name, int OutputSize, byte HdrByte10)[] _phfStrategies =
        {
            ("SPANISHOAK", "Spanish Oak (Falcon EEC-VI)",        0x100000, 0x10),
            ("BOAK",       "Black Oak",                          0x180000, 0x30),
            ("GOAK",       "Green Oak",                          0x180000, 0x30),
        };

        // ── Tab builder ───────────────────────────────────────────────────────
        private TabPage BuildFA_PHF2BIN()
        {
            var tab = new TabPage("PHF → BIN") { BackColor = Color.FromArgb(18, 22, 30) };

            // ── Toolbar ──
            var pnlBar = new Panel { Dock = DockStyle.Top, Height = 38, BackColor = Color.FromArgb(24, 30, 42), Padding = new Padding(4) };
            int x = 4;
            _phfBtnBrowse = new Button {
                Text = "Open PHF...", Location = new Point(x, 6), Size = new Size(110, 26),
                FlatStyle = FlatStyle.Flat, BackColor = Color.FromArgb(40, 60, 100), ForeColor = Color.White,
            };
            _phfBtnBrowse.Click += (s, e) => PHF_OpenFile();
            pnlBar.Controls.Add(_phfBtnBrowse); x += 116;

            _phfBtnConvert = new Button {
                Text = "Convert", Location = new Point(x, 6), Size = new Size(80, 26),
                FlatStyle = FlatStyle.Flat, BackColor = Color.FromArgb(30, 100, 60), ForeColor = Color.White,
                Font = new Font("Segoe UI", 8.5f, FontStyle.Bold), Enabled = false,
            };
            _phfBtnConvert.Click += (s, e) => PHF_Convert();
            pnlBar.Controls.Add(_phfBtnConvert); x += 86;

            _phfBtnSaveAs = new Button {
                Text = "Save BIN...", Location = new Point(x, 6), Size = new Size(110, 26),
                FlatStyle = FlatStyle.Flat, BackColor = Color.FromArgb(40, 60, 100), ForeColor = Color.White, Enabled = false,
            };
            _phfBtnSaveAs.Click += (s, e) => PHF_SaveAs();
            pnlBar.Controls.Add(_phfBtnSaveAs); x += 116;

            tab.Controls.Add(pnlBar);

            // ── Body panel ──
            var bg = new Panel { Dock = DockStyle.Fill, BackColor = Color.FromArgb(18, 22, 30), Padding = new Padding(20) };
            tab.Controls.Add(bg);

            var lblHeader = new Label {
                Text = "FORD IDS PHF  →  RAW BINARY",
                Font = new Font("Segoe UI", 11f, FontStyle.Bold),
                ForeColor = Color.FromArgb(100, 180, 255),
                Location = new Point(20, 12), AutoSize = true,
            };
            bg.Controls.Add(lblHeader);

            var lblSub = new Label {
                Text = "Converts Ford IDS .phf calibration files into flat .bin images.\r\n"
                     + "Currently supports Spanish Oak (Falcon EEC-VI, 1 MiB), Black Oak and Green Oak (1.5 MiB).\r\n"
                     + "Bytes 0x8000–0xFFFF are missing from the PHF (RTOS / UDS dispatcher) and are padded with 0xFF.\r\n"
                     + "Thanks to Rolls https//github.com/rollsch/PHF2BIN",
                Font = new Font("Segoe UI", 8.5f, FontStyle.Italic),
                ForeColor = Color.FromArgb(140, 160, 190),
                Location = new Point(22, 38), AutoSize = true,
            };
            bg.Controls.Add(lblSub);

            int y = 110;

            bg.Controls.Add(new Label {
                Text = "Input PHF:", Location = new Point(22, y + 4), Width = 110,
                ForeColor = Color.FromArgb(180, 200, 220), Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
            });
            _phfTxtInputPath = new TextBox {
                Location = new Point(140, y), Width = 600,
                Font = new Font("Consolas", 9f),
                BackColor = Color.FromArgb(22, 28, 38), ForeColor = Color.FromArgb(220, 240, 255),
                BorderStyle = BorderStyle.FixedSingle, ReadOnly = true,
            };
            bg.Controls.Add(_phfTxtInputPath);

            y += 32;
            bg.Controls.Add(new Label {
                Text = "Detected:", Location = new Point(22, y), Width = 110,
                ForeColor = Color.FromArgb(180, 200, 220), Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
            });
            _phfLblDetected = new Label {
                Text = "—", Location = new Point(140, y), AutoSize = true,
                ForeColor = Color.FromArgb(255, 200, 80), Font = new Font("Consolas", 10f, FontStyle.Bold),
            };
            bg.Controls.Add(_phfLblDetected);

            y += 26;
            bg.Controls.Add(new Label {
                Text = "Input size:", Location = new Point(22, y), Width = 110,
                ForeColor = Color.FromArgb(180, 200, 220), Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
            });
            _phfLblInSize = new Label {
                Text = "—", Location = new Point(140, y), AutoSize = true,
                ForeColor = Color.FromArgb(220, 240, 255), Font = new Font("Consolas", 10f),
            };
            bg.Controls.Add(_phfLblInSize);

            y += 26;
            bg.Controls.Add(new Label {
                Text = "Output size:", Location = new Point(22, y), Width = 110,
                ForeColor = Color.FromArgb(180, 200, 220), Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
            });
            _phfLblOutSize = new Label {
                Text = "—", Location = new Point(140, y), AutoSize = true,
                ForeColor = Color.FromArgb(220, 240, 255), Font = new Font("Consolas", 10f),
            };
            bg.Controls.Add(_phfLblOutSize);

            y += 32;
            bg.Controls.Add(new Label {
                Text = "Output BIN:", Location = new Point(22, y + 4), Width = 110,
                ForeColor = Color.FromArgb(180, 200, 220), Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
            });
            _phfTxtOutputPath = new TextBox {
                Location = new Point(140, y), Width = 600,
                Font = new Font("Consolas", 9f),
                BackColor = Color.FromArgb(22, 28, 38), ForeColor = Color.FromArgb(220, 240, 255),
                BorderStyle = BorderStyle.FixedSingle, ReadOnly = true,
            };
            bg.Controls.Add(_phfTxtOutputPath);

            y += 40;
            bg.Controls.Add(new Label {
                Text = "Log:", Location = new Point(22, y), Width = 110,
                ForeColor = Color.FromArgb(180, 200, 220), Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
            });
            _phfTxtLog = new TextBox {
                Location = new Point(22, y + 24),
                Size = new Size(720, 220),
                Multiline = true, ReadOnly = true, ScrollBars = ScrollBars.Vertical,
                Font = new Font("Consolas", 9f),
                BackColor = Color.FromArgb(12, 16, 24), ForeColor = Color.FromArgb(180, 200, 220),
                BorderStyle = BorderStyle.FixedSingle,
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
            };
            bg.Controls.Add(_phfTxtLog);

            return tab;
        }

        // ── UI handlers ───────────────────────────────────────────────────────
        private void PHF_OpenFile()
        {
            using (var d = new OpenFileDialog
            {
                Title = "Select Ford IDS PHF file",
                Filter = "Ford IDS PHF (*.phf)|*.phf|All Files (*.*)|*.*",
            })
            {
                if (d.ShowDialog() != DialogResult.OK) return;
                try
                {
                    _phfInputBytes = File.ReadAllBytes(d.FileName);
                    _phfTxtInputPath.Text = d.FileName;
                    _phfLblInSize.Text = $"{_phfInputBytes.Length:N0} bytes  ({_phfInputBytes.Length / 1024.0:F1} KiB)";
                    _phfOutputBytes = Array.Empty<byte>();
                    _phfTxtOutputPath.Text = "";
                    _phfLblOutSize.Text = "—";
                    _phfBtnSaveAs.Enabled = false;

                    var strat = PHF_DetectStrategy(_phfInputBytes);
                    if (strat.HasValue)
                    {
                        _phfDetectedType = strat.Value.Name;
                        _phfLblDetected.Text = strat.Value.Name + $"  →  output {strat.Value.OutputSize:N0} bytes";
                        _phfLblDetected.ForeColor = Color.FromArgb(100, 220, 140);
                        _phfBtnConvert.Enabled = true;
                        PHF_Log($"Loaded {Path.GetFileName(d.FileName)} — detected {strat.Value.Name}");
                    }
                    else
                    {
                        _phfDetectedType = "";
                        _phfLblDetected.Text = "Unknown — no SPANISHOAK / BOAK / GOAK marker in first 0x100 bytes";
                        _phfLblDetected.ForeColor = Color.FromArgb(255, 130, 110);
                        _phfBtnConvert.Enabled = false;
                        PHF_Log($"Loaded {Path.GetFileName(d.FileName)} — strategy NOT detected.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to read file:\n{ex.Message}", "PHF → BIN",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PHF_Convert()
        {
            if (_phfInputBytes == null || _phfInputBytes.Length == 0) return;
            try
            {
                var strat = PHF_DetectStrategy(_phfInputBytes);
                if (!strat.HasValue)
                {
                    PHF_Log("No oak strategy marker — refusing to convert.");
                    return;
                }
                PHF_Log($"Converting using strategy: {strat.Value.Name}");

                _phfOutputBytes = PHF_ConvertCore(_phfInputBytes, strat.Value, out string detail);
                if (_phfOutputBytes == null || _phfOutputBytes.Length == 0)
                {
                    PHF_Log("Conversion FAILED: " + detail);
                    return;
                }
                _phfLblOutSize.Text = $"{_phfOutputBytes.Length:N0} bytes  ({_phfOutputBytes.Length / 1024.0:F1} KiB)";
                _phfBtnSaveAs.Enabled = true;
                PHF_Log("Conversion complete. " + detail);
                PHF_Log("Click Save BIN... to write to disk.");
            }
            catch (Exception ex)
            {
                PHF_Log("Conversion error: " + ex.Message);
            }
        }

        private void PHF_SaveAs()
        {
            if (_phfOutputBytes == null || _phfOutputBytes.Length == 0) return;
            string suggested = string.IsNullOrEmpty(_phfTxtInputPath.Text)
                ? "output.bin"
                : Path.GetFileNameWithoutExtension(_phfTxtInputPath.Text) + ".bin";
            using (var d = new SaveFileDialog
            {
                Title = "Save converted binary",
                Filter = "Binary File (*.bin)|*.bin|All Files (*.*)|*.*",
                FileName = suggested,
            })
            {
                if (d.ShowDialog() != DialogResult.OK) return;
                try
                {
                    File.WriteAllBytes(d.FileName, _phfOutputBytes);
                    _phfTxtOutputPath.Text = d.FileName;
                    PHF_Log("Saved: " + d.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Save failed:\n{ex.Message}", "PHF → BIN",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PHF_Log(string line)
        {
            if (_phfTxtLog == null) return;
            string stamped = $"[{DateTime.Now:HH:mm:ss}] {line}{Environment.NewLine}";
            if (_phfTxtLog.InvokeRequired) _phfTxtLog.BeginInvoke((Action)(() => _phfTxtLog.AppendText(stamped)));
            else _phfTxtLog.AppendText(stamped);
        }

        // ── Conversion core ───────────────────────────────────────────────────
        private static (string Marker, string Name, int OutputSize, byte HdrByte10)? PHF_DetectStrategy(byte[] phf)
        {
            if (phf == null || phf.Length < 0x100) return null;
            foreach (var s in _phfStrategies)
            {
                var needle = Encoding.ASCII.GetBytes(s.Marker);
                if (PHF_FindBytes(phf, needle, 0x100) != -1) return s;
            }
            return null;
        }

        /// <summary>
        /// Direct port of the upstream PHF2BIN converter (Plugin.FileFormat.PHF.cs):
        /// finds the magic 0x12-byte header, then iterates the PHF skipping the
        /// 8-byte 64 KiB-block headers and 6-byte 32-byte sub-block headers,
        /// padding 0x8000..0xFFFF with 0xFF.
        /// </summary>
        private static byte[] PHF_ConvertCore(
            byte[] phf,
            (string Marker, string Name, int OutputSize, byte HdrByte10) strategy,
            out string detail)
        {
            // Magic header: 0x12 bytes, all zero except [0x10] = HdrByte10, [0x11] = 0x60.
            var header = new byte[0x12];
            header[0x10] = strategy.HdrByte10;
            header[0x11] = 0x60;

            int magicOffset = PHF_FindBytes(phf, header);
            if (magicOffset == -1)
            {
                detail = "Magic header (0x12 bytes ending 0x" + strategy.HdrByte10.ToString("X2") + " 0x60) not found in PHF.";
                return Array.Empty<byte>();
            }

            byte[] outBytes = new byte[strategy.OutputSize];
            // Pre-fill 0xFF — anything we don't write stays 0xFF (matches Spanish Oak read-back behaviour).
            for (int p = 0; p < outBytes.Length; p++) outBytes[p] = 0xFF;

            int outIdx = 0;
            int inIdx  = magicOffset;
            int rtosPadCount = 0;

            while (inIdx < phf.Length)
            {
                // 8-byte block header at every 0x10000 boundary (except at 0).
                if (outIdx % 0x10000 == 0 && outIdx != 0) inIdx += 8;
                if (outIdx >= outBytes.Length) break;

                // RTOS hole — bytes 0x8000..0xFFFF aren't in the PHF, pad with 0xFF and skip output index.
                if (outIdx >= 0x8000 && outIdx < 0x10000)
                {
                    outBytes[outIdx] = 0xFF;
                    outIdx++;
                    rtosPadCount++;
                    continue;
                }

                // 6-byte sub-block header at every 0x20 boundary (except at 0).
                if (outIdx % 0x20 == 0 && outIdx != 0) inIdx += 6;
                if (outIdx >= outBytes.Length) break;
                if (inIdx >= phf.Length) break;

                outBytes[outIdx] = phf[inIdx];
                inIdx++;
                outIdx++;
            }

            int writtenFromPhf = outIdx - rtosPadCount;
            detail = $"wrote {outIdx:N0} of {strategy.OutputSize:N0} output bytes "
                   + $"({writtenFromPhf:N0} from PHF + {rtosPadCount:N0} 0xFF padding for RTOS hole 0x8000–0xFFFF). "
                   + $"Magic header at PHF offset 0x{magicOffset:X8}.";
            return outBytes;
        }

        /// <summary>Searches haystack for needle, returns index or -1. Limits search to first searchLimit bytes.</summary>
        private static int PHF_FindBytes(byte[] haystack, byte[] needle, int searchLimit = int.MaxValue)
        {
            if (haystack == null || needle == null || needle.Length == 0) return -1;
            int len = needle.Length;
            int limit = Math.Min(haystack.Length - len, searchLimit);
            for (int i = 0; i <= limit; i++)
            {
                int k = 0;
                for (; k < len; k++) if (needle[k] != haystack[i + k]) break;
                if (k == len) return i;
            }
            return -1;
        }
    }
}
