using System;
using System.Diagnostics;
using System.IO;
using WindowsRemoveAd.Base;

namespace WindowsRemoveAd.Control;

public class VersionControl : PropertyBase
{
    public VersionControl()
    { 
        var version = FileVersionInfo.GetVersionInfo(GetType().Assembly.Location);

        CurrentDisplayName = $"DangWang {version.FileVersion}";
    }

    public string? CurrentDisplayName
    {
        get => _CurrentVersion; 
        private set => SetProperty(ref _CurrentVersion, value); 
    }
    string? _CurrentVersion;
}
