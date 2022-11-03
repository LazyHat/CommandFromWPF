﻿using MaterialDesignThemes.Wpf.Converters;
using System.Diagnostics;
using System.Windows.Controls;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace CommandFromWPF
{
    static internal class MainModel
    {
        private static string BakPath = "null";
        private static string FolderPath = "null";
        private static Page SecP = new Views.SecondPage();
        private static Page MainP = new MainPage();
        public static void ButtonClick()
        {
            using (var dialog = new CommonOpenFileDialog())
            {
                dialog.Title = "Select Folder";
                dialog.IsFolderPicker = true;
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    FolderPath = dialog.FileName;
                }
            }
            Process.Start("cmd", "%comspec% /C \"C:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\Common7\\Tools\\VsDevCmd.bat\"&&code " + FolderPath + " &&exit");
            if (BakPath != FolderPath)
            {
                BakPath = FolderPath;
            }
        }
        public static void Button2Click()
        {
            Process.Start("cmd", "%comspec% /C \"C:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\Common7\\Tools\\VsDevCmd.bat\"&&code " + BakPath + " &&exit");
        }
        public static string GetButtonText()
        {
            return "Open VS Code from VSDevCmd";
        }
        public static Page GetPage(int indexpage)
        {
            switch (indexpage)
            {
                case 0:
                    return MainP;
                    case 1:
                    return SecP;
                default:
                    return MainP;
            }
        }
        public static string GetButton2Text()
        {
            return "Open VS Code in " + BakPath.Substring(BakPath.LastIndexOf('\\') + 1) + " folder";
        }
        public static bool BakPathExist()
        {
            return BakPath != "";
        }
    }
}
