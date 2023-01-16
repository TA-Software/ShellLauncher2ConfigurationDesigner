using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ShellLauncher2ConfigurationDesigner.Core.Models;

[XmlRoot(ElementName = "DefaultAction", Namespace = "http://schemas.microsoft.com/ShellLauncher/2018/Configuration")]
public class DefaultAction
{
    [XmlAttribute(AttributeName = "Action")]
    public string Action
    {
        get; set;
    }
}

[XmlRoot(ElementName = "Shell", Namespace = "http://schemas.microsoft.com/ShellLauncher/2018/Configuration")]
public class Shell
{
    [XmlElement(ElementName = "DefaultAction", Namespace = "http://schemas.microsoft.com/ShellLauncher/2018/Configuration")]
    public DefaultAction DefaultAction
    {
        get; set;
    }
    [XmlAttribute(AttributeName = "Shell")]
    public string _Shell
    {
        get; set;
    }
    [XmlAttribute(AttributeName = "AppType", Namespace = "http://schemas.microsoft.com/ShellLauncher/2019/Configuration")]
    public string AppType
    {
        get; set;
    }
    [XmlAttribute(AttributeName = "AllAppsFullScreen", Namespace = "http://schemas.microsoft.com/ShellLauncher/2019/Configuration")]
    public string AllAppsFullScreen
    {
        get; set;
    }
}

[XmlRoot(ElementName = "DefaultProfile", Namespace = "http://schemas.microsoft.com/ShellLauncher/2018/Configuration")]
public class DefaultProfile
{
    [XmlElement(ElementName = "Shell", Namespace = "http://schemas.microsoft.com/ShellLauncher/2018/Configuration")]
    public Shell Shell
    {
        get; set;
    }
}

[XmlRoot(ElementName = "Profile", Namespace = "http://schemas.microsoft.com/ShellLauncher/2018/Configuration")]
public class Profile
{
    [XmlElement(ElementName = "Shell", Namespace = "http://schemas.microsoft.com/ShellLauncher/2018/Configuration")]
    public Shell Shell
    {
        get; set;
    }
    [XmlAttribute(AttributeName = "Id")]
    public string Id
    {
        get; set;
    }
}

[XmlRoot(ElementName = "Profiles", Namespace = "http://schemas.microsoft.com/ShellLauncher/2018/Configuration")]
public class Profiles
{
    [XmlElement(ElementName = "DefaultProfile", Namespace = "http://schemas.microsoft.com/ShellLauncher/2018/Configuration")]
    public DefaultProfile DefaultProfile
    {
        get; set;
    }
    [XmlElement(ElementName = "Profile", Namespace = "http://schemas.microsoft.com/ShellLauncher/2018/Configuration")]
    public List<Profile> Profile
    {
        get; set;
    }
}

[XmlRoot(ElementName = "Account", Namespace = "http://schemas.microsoft.com/ShellLauncher/2018/Configuration")]
public class Account
{
    [XmlAttribute(AttributeName = "Name")]
    public string Name
    {
        get; set;
    }
}

[XmlRoot(ElementName = "Config", Namespace = "http://schemas.microsoft.com/ShellLauncher/2018/Configuration")]
public class Config
{
    [XmlElement(ElementName = "Account", Namespace = "http://schemas.microsoft.com/ShellLauncher/2018/Configuration")]
    public Account Account
    {
        get; set;
    }
    [XmlElement(ElementName = "Profile", Namespace = "http://schemas.microsoft.com/ShellLauncher/2018/Configuration")]
    public Profile Profile
    {
        get; set;
    }
}

[XmlRoot(ElementName = "Configs", Namespace = "http://schemas.microsoft.com/ShellLauncher/2018/Configuration")]
public class Configs
{
    [XmlElement(ElementName = "Config", Namespace = "http://schemas.microsoft.com/ShellLauncher/2018/Configuration")]
    public List<Config> Config
    {
        get; set;
    }
}

[XmlRoot(ElementName = "ShellLauncherConfiguration", Namespace = "http://schemas.microsoft.com/ShellLauncher/2018/Configuration")]
public class ShellLauncherConfiguration
{
    [XmlElement(ElementName = "Profiles", Namespace = "http://schemas.microsoft.com/ShellLauncher/2018/Configuration")]
    public Profiles Profiles
    {
        get; set;
    }
    [XmlElement(ElementName = "Configs", Namespace = "http://schemas.microsoft.com/ShellLauncher/2018/Configuration")]
    public Configs Configs
    {
        get; set;
    }
    [XmlAttribute(AttributeName = "xmlns")]
    public string Xmlns
    {
        get; set;
    }
    [XmlAttribute(AttributeName = "v2", Namespace = "http://www.w3.org/2000/xmlns/")]
    public string V2
    {
        get; set;
    }
}
