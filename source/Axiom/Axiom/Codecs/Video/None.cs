﻿/* ----------------------------------------------------------------------
Axiom UI
Copyright (C) 2017-2019 Matt McManis
https://github.com/MattMcManis/Axiom
https://axiomui.github.io
mattmcmanis@outlook.com

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.If not, see <http://www.gnu.org/licenses/>. 
---------------------------------------------------------------------- */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axiom
{
    public class VideoNone
    {
        // ---------------------------------------------------------------------------
        // Codec
        // ---------------------------------------------------------------------------
        public static void Codec_Set()
        {
            VM.VideoView.Video_Codec = string.Empty;
        }



        // ---------------------------------------------------------------------------
        // Items Source
        // ---------------------------------------------------------------------------

        // -------------------------
        // Encode Speed
        // -------------------------
        public static List<VideoViewModel.VideoEncodeSpeed> encodeSpeed = new List<VideoViewModel.VideoEncodeSpeed>()
        {
             new VideoViewModel.VideoEncodeSpeed() { Name = "none", Command = ""},
        };

        // -------------------------
        // Pixel Format
        // -------------------------
        public static List<string> pixelFormat = new List<string>()
        {
            "none"
        };

        // -------------------------
        // Quality
        // -------------------------
        public static List<VideoViewModel.VideoQuality> quality = new List<VideoViewModel.VideoQuality>()
        {
             new VideoViewModel.VideoQuality() { Name = "None", }
        };

        // -------------------------
        // Pass
        // -------------------------
        public static void EncodingPass()
        {
            // Items Source
            VM.VideoView.Video_Pass_Items = new List<string>()
            {
                "auto"
            };

            VM.VideoView.Video_Pass_SelectedItem = "auto";
            VM.VideoView.Video_Pass_IsEnabled = false;
            VideoControls.passUserSelected = false;

            VM.VideoView.Video_CRF_IsEnabled = false;
            VM.VideoView.Video_CRF_Text = string.Empty;
            VM.VideoView.Video_BitRate_Text = string.Empty;
            VM.VideoView.Video_MinRate_Text = string.Empty;
            VM.VideoView.Video_MaxRate_Text = string.Empty;
            VM.VideoView.Video_BufSize_Text = string.Empty;
        }

        // -------------------------
        // Optimize
        // -------------------------
        public static List<VideoViewModel.VideoOptimize> optimize = new List<VideoViewModel.VideoOptimize>()
        {
            new VideoViewModel.VideoOptimize() { Name = "None", Tune = "none", Profile = "none", Level = "none", Command = "" }
        };

        // -------------------------
        // Tune
        // -------------------------
        public static List<string> tune = new List<string>()
        {
            "none"
        };

        // -------------------------
        // Profile
        // -------------------------
        public static List<string> profile = new List<string>()
        {
            "none"
        };

        // -------------------------
        // Level
        // -------------------------
        public static List<string> level = new List<string>()
        {
            "none"
        };



        // ---------------------------------------------------------------------------
        // Controls Behavior
        // ---------------------------------------------------------------------------

        // -------------------------
        // Items Source
        // -------------------------
        public static void Controls_ItemsSource()
        {
            // Encode Speed
            VM.VideoView.Video_EncodeSpeed_Items = encodeSpeed;

            // Pixel Format
            VM.VideoView.Video_PixelFormat_Items = pixelFormat;

            // Pass
            //VM.VideoView.Video_Pass_Items = pass;
            EncodingPass();

            // Video Quality
            VM.VideoView.Video_Quality_Items = quality;

            // Optimize
            VM.VideoView.Video_Optimize_Items = optimize;
            // Tune
            VM.VideoView.Video_Optimize_Tune_Items = tune;
            // Profile
            VM.VideoView.Video_Optimize_Profile_Items = profile;
            // Level
            VM.VideoView.Video_Optimize_Level_Items = level;
        }

        // -------------------------
        // Selected Items
        // -------------------------
        public static void Controls_Selected()
        {

            // Pixel Format
            VM.VideoView.Video_PixelFormat_SelectedItem = "none";

            // Framerate
            VM.VideoView.Video_FPS_SelectedItem = "auto";
        }


        // -------------------------
        // Expanded
        // -------------------------
        public static void Controls_Expanded()
        {
            // None
        }

        // -------------------------
        // Collapsed
        // -------------------------
        public static void Controls_Collapsed()
        {
            VM.VideoView.Video_Optimize_IsExpanded = false;
        }


        // -------------------------
        // Checked
        // -------------------------
        public static void Controls_Checked()
        {
            // None
        }

        // -------------------------
        // Unchecked
        // -------------------------
        public static void Controls_Unhecked()
        {
            // BitRate Mode
            VM.VideoView.Video_VBR_IsChecked = false;
        }


        // -------------------------
        // Enabled
        // -------------------------
        public static void Controls_Enable()
        {
            // None
        }

        // -------------------------
        // Disabled
        // -------------------------
        public static void Controls_Disable()
        {
            // Video Encode Speed
            VM.VideoView.Video_EncodeSpeed_IsEnabled = false;

            // Video Codec
            //VM.VideoView.Video_Codec_IsEnabled = false;

            // Video Quality
            VM.VideoView.Video_Quality_IsEnabled = false;

            // Video VBR
            VM.VideoView.Video_VBR_IsEnabled = false;

            // Pixel Format
            VM.VideoView.Video_PixelFormat_IsEnabled = false;

            // FPS ComboBox
            VM.VideoView.Video_FPS_IsEnabled = false;

            // Optimize ComboBox
            VM.VideoView.Video_Optimize_IsEnabled = false;

            // Scaling ComboBox
            VM.VideoView.Video_ScalingAlgorithm_IsEnabled = false;

            // Crop
            VM.VideoView.Video_Crop_IsEnabled = false;

            // Subtitle Codec
            VM.SubtitleView.Subtitle_Codec_IsEnabled = false;

            // Subtitle Stream
            VM.SubtitleView.Subtitle_Stream_IsEnabled = false;
        }

    }
}
