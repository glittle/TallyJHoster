using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Xml;
using CassiniDev;

namespace TallyJCore
{
  public class Main
  {
    private string _connectionString;
    private MainForm _form;
    private int _port;
    private Server _server;
    private bool _serverIsRunning;
    private string _url;
    private string _webFolderPath;

    public Main(MainForm mainForm)
    {
      _form = mainForm;

      _form.SetUrl("");
    }

    public Status Status { get; set; }

    public void StopServer()
    {
      if (_server != null)
      {
        _server.ShutDown();
      }
      _serverIsRunning = false;
      _form.SetButtonStates(Status.Stopped);
      _form.ShowStatusText("Server is Stopped");
    }

    public void StartServer()
    {
      if (!UpdateTargetWebConfig(_connectionString))
      {
        return;
      }
      if (!Directory.Exists(_webFolderPath))
      {
        _form.ShowStatusText("Folder not found");
        return;
      }
      if (!File.Exists(Path.Combine(_webFolderPath, "web.config")))
      {
        _form.ShowStatusText("Folder does not contain web files");
        return;
      }

      var hostname = Dns.GetHostName();

      try
      {
        _server = new Server(_port, "/TallyJ/", _webFolderPath, IPAddress.Any, hostname);

        _server.RequestComplete += _server_RequestComplete;
        _server.Start();
        _url = _server.RootUrl;

        _form.SetUrl(_url);
        _form.SetButtonStates(Status.Running);
        _form.ShowStatusText("Server is Running");
        _serverIsRunning = true;
      }
      catch (Exception ex)
      {
        _serverIsRunning = false;
        _form.SetButtonStates(Status.Stopped);
        _form.ShowStatusText(ex.Message);
      }
    }

    private void _server_RequestComplete(object sender, RequestEventArgs e)
    {
      var dummyForDebugging = 1;
    }

    public void SetFolder(string selectedPath)
    {
      _webFolderPath = selectedPath;
    }

    public void SetConnection(string connectionString)
    {
      _connectionString = connectionString;
    }

    public string GetCurrentMainConnection()
    {
      if (!Directory.Exists(_webFolderPath))
      {
        _form.ShowStatusText("Folder not found");
        return "";
      }
      var webConfigPath = Path.Combine(_webFolderPath, "web.config");
      if (!File.Exists(webConfigPath))
      {
        _form.ShowStatusText("Folder does not contain web files");
        return "";
      }

      var configDom = new XmlDocument();
      configDom.Load(webConfigPath);
      var node = configDom.SelectSingleNode("//connectionStrings/add[@name='MainConnection']") as XmlElement;
      if (node == null)
      {
        _form.ShowStatusText("Unable to find MainConnection in web.config file.");
        return "";
      }
      return node.GetAttribute("connectionString");
    }

    private bool UpdateTargetWebConfig(string connectionString)
    {
      if (!Directory.Exists(_webFolderPath))
      {
        _form.ShowStatusText("Folder not found");
        return false;
      }
      var webConfigPath = Path.Combine(_webFolderPath, "web.config");
      if (!File.Exists(webConfigPath))
      {
        _form.ShowStatusText("Folder does not contain web files");
        return false;
      }

      var saveNeeded = false;

      var configDom = new XmlDocument();
      configDom.Load(webConfigPath);
      var node = configDom.SelectSingleNode("//connectionStrings/add[@name='MainConnection']") as XmlElement;
      if (node == null)
      {
        _form.ShowStatusText("Unable to update web.config file (1).");
        return false;
      }
      if (node.GetAttribute("connectionString") != connectionString)
      {
        node.SetAttribute("connectionString", connectionString);
        saveNeeded = true;
      }

      var settings = configDom.SelectSingleNode("/configuration/appSettings");
      if (settings == null)
      {
        _form.ShowStatusText("Unable to update web.config file (2).");
        return false;
      }
      var env = settings.SelectSingleNode("add[@key='Environment']") as XmlElement;
      if (env == null)
      {
        settings.AppendChild(env = configDom.CreateElement("add"));
        env.SetAttribute("key", "Environment");
      }
      if (env.GetAttribute("value") != "SelfHostCassini")
      {
        env.SetAttribute("value", "SelfHostCassini");
        saveNeeded = true;
      }

      if (saveNeeded)
      {
        configDom.Save(webConfigPath);
      }

      return true;
    }

    public void ShowAbout()
    {
    }

    public void ExitProgram()
    {
      StopServer();

      Environment.Exit(0);
    }

    public void CopyUrlToClipboard()
    {
      Clipboard.SetText(_url);
    }

    public void SetPort(int value)
    {
      _port = value;
    }
  }
}