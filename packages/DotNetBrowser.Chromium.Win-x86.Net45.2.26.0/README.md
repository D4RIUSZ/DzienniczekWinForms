# DotNetBrowser

Integrate a Chromium-based browser into your .NET application to load and process modern web pages built with HTML5, CSS3, JavaScript etc.

To be able to use DotNetBrowser, you should obtain a license. A free 30-day evaluation license can be requested by filling a form at https://www.teamdev.com/dotnetbrowser#evaluate

## Deep Chromium integration

DotNetBrowser provides API that can be used to interact with a huge set of various Chromium features directly from the code:

- DOM API: you can access Document Object Model of the loaded web page, find elements and interact with them, handle and dispatch DOM events for the particular nodes.
- JS-.NET bridge: you can execute JavaScript on the web page and process the results. You can also inject any .NET object into the web page and then use it in your JavaScript code.
- Printing API: you can initiate and configure printing programmatically. Printing to PDF is also supported out of box.
- Network API: you can intercept, redirect, handle, and suppress network requests, override HTTP headers and POST data, filter out incoming and outgoing cookies, change proxy settings on the fly.

See the [examples](https://github.com/TeamDev-IP/DotNetBrowser-Examples) to understand what can be implemented with DotNetBrowser.

## Easy deployment

All required Chromium binaries are deployed as DotNetBrowser DLLs and can be extracted automatically during execution. You don't need to pre-install Chromium, Google Chrome, or a Chromium-based runtime to work with DotNetBrowser. 

The current release of DotNetBrowser uses Chromium build 121.0.6167.184.

## Headless mode

DotNetBrowser can be used in Windows services and server apps. The web page can be loaded and rendered completely in memory without displaying any visible windows. You can then [take a screenshot](https://teamdev.com/dotnetbrowser/docs/guides/gs/content.html#taking-bitmap-of-a-web-page) of the loaded web page.

## User input simulation

DotNetBrowser provides means to [simulate mouse and keyboard input](https://teamdev.com/dotnetbrowser/docs/guides/gs/browser.html#simulating-user-input) and interact with the web page programmatically - exactly as regular users do.

## UI

DotNetBrowser provides UI controls for [WPF](https://teamdev.com/dotnetbrowser/docs/quickstart/wpf.html) and [Windows Forms](https://teamdev.com/dotnetbrowser/docs/quickstart/winforms.html) applications. These controls can be used to display web pages as integral parts of the .NET applications. It is also possible to use DotNetBrowser to create [VSTO add-ins](https://teamdev.com/dotnetbrowser/docs/tutorials/use-cases/vsto.html).

## Usage

Note: The VB.NET examples can be found in the [examples repository](https://github.com/TeamDev-IP/DotNetBrowser-Examples).

### WPF

**XAML**

```xml
<Window x:Class="Sample.Wpf.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:wpf="clr-namespace:DotNetBrowser.Wpf;assembly=DotNetBrowser.Wpf"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800" Closed="MainWindow_OnClosed">
    <Grid>
        <wpf:BrowserView x:Name="browserView"/>
    </Grid>
</Window>
```

**Code**

```csharp
using System;
using System.Windows
using DotNetBrowser.Browser;
using DotNetBrowser.Engine;

namespace Sample.Wpf {
    public partial class MainWindow : Window {
        private readonly IEngine engine;
        private readonly IBrowser browser;
         
        public MainWindow() {
            InitializeComponent();
             
            // Create and initialize the IEngine
            engine = EngineFactory.Create();
             
            // Create the IBrowser
            browser = engine.CreateBrowser();
            browser.Navigation.LoadUrl("https://html5test.teamdev.com/");
             
            // Initialize the WPF BrowserView control
            browserView.InitializeFrom(browser);
        }
         
        private void MainWindow_OnClosed(object sender, EventArgs e) {
            browser.Dispose();
            engine.Dispose();
        }
    }
}
```

### Windows Forms

```csharp
using System;
using System.Windows.Forms;
using DotNetBrowser.Browser;
using DotNetBrowser.Engine;
using DotNetBrowser.WinForms;

namespace Sample.WinForms {
    public partial class Form1 : Form {
        private readonly IEngine engine;
        private readonly IBrowser browser;
         
        public Form1() {
            InitializeComponent();
             
            // Create and initialize the IEngine
            engine = EngineFactory.Create();
             
            // Create the Windows Forms BrowserView control
            BrowserView browserView = new BrowserView() {
                Dock = DockStyle.Fill
            };
             
            // Create the IBrowser
            browser = engine.CreateBrowser();
            browser.Navigation.LoadUrl("https://html5test.teamdev.com/");
             
            // Initialize the Windows Forms BrowserView control
            browserView.InitializeFrom(browser);
             
            // Add the BrowserView control to the Form
            Controls.Add(browserView);
            Closed += Form1Closed;
        }
         
        private void Form1Closed(object sender, EventArgs e) {
            browser.Dispose();
            engine.Dispose();
        }
    }
}
```

### Avalonia UI

**AXAML**

```xml
<Window xmlns="https://github.com/avaloniaui"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:app="clr-namespace:DotNetBrowser.AvaloniaUi;assembly=DotNetBrowser.AvaloniaUi"
        mc:Ignorable="d" d:DesignWidth="800" d:DesignHeight="450"
        x:Class="Embedding.AvaloniaUi.MainWindow"
        Title="Embedding.AvaloniaUi" Closed="Window_Closed">
    <app:BrowserView x:Name="BrowserView"/>
</Window>
```

**Code**

```csharp
using System;
using Avalonia.Controls;
using DotNetBrowser.Browser;
using DotNetBrowser.Engine;

namespace Embedding.AvaloniaUi
{

    /// <summary>
    ///     This example demonstrates how to embed DotNetBrowser
    ///     into an Avalonia application.
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string Url = "https://html5test.teamdev.com/";
        private readonly IBrowser browser;
        private readonly IEngine engine;

        public MainWindow()
        {
            // Create and initialize the IEngine
            engine = EngineFactory.Create();

            // Create the IBrowser instance.
            browser = engine.CreateBrowser();

            InitializeComponent();

            // Initialize the Avalonia UI BrowserView control.
            BrowserView.InitializeFrom(browser);
            browser.Navigation.LoadUrl(Url);
        }

        private void Window_Closed(object? sender, EventArgs e)
        {
            browser?.Dispose();
            engine?.Dispose();
        }
    }
}
```
