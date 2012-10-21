using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CassiniDev;

namespace TallyJCore
{
  public class Main
  {
    private MainForm _form;
    private string _webFolderPath;
    private Server _server;
    private int _port;
    private string _url;

    public Main(MainForm mainForm)
    {
      _form = mainForm;
    }

    public Status Status { get; set; }

    public void StopServer()
    {
      _server.ShutDown();
      _form.SetButtonStates(Status.Stopped);
      _form.ShowStatusText("Stopped");
    }

    public void StartServer()
    {
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

      try
      {
        _server = new Server(_port, "/", _webFolderPath, false, true);

        _server.RequestComplete += _server_RequestComplete;
        _server.Start();

        _url = _server.RootUrl;
        _form.SetUrl(_url);
        _form.SetButtonStates(Status.Running);
        _form.ShowStatusText("Running");
      }
      catch (Exception ex)
      {
        _form.SetButtonStates(Status.Stopped);
        _form.ShowStatusText(ex.Message);
      }
    }

    void _server_RequestComplete(object sender, RequestEventArgs e)
    {
      var x = 1;
    }

    public void SetFolder(string selectedPath)
    {
      _webFolderPath = selectedPath;
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
