using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellLauncher2ConfigurationDesigner.Core.Models;
public class ProfileConfiguration
{
    public bool IsDefault
    {
        get; set;
    }

    public Guid ProfileId
    {
        get; set;
    }

    public string Shell
    {
        get; set;
    }

    public bool IsShellUwpApp
    {
        get; set;
    }

    public bool RunAppAsFullScreen
    {
        get; set;
    }

    public string AccountName
    {
        get; set;
    }
}
