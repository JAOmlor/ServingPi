using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace spcs
{
    public static class Console
    {
        static private RichTextBlock consolebuffer = new RichTextBlock();
        static private TextBox inputbox = new TextBox();
        static public StackPanel MainPanel = new StackPanel();
        
        public static void Init()
        {
            //initialize our consolebuffer defaults
            MainPanel.Children.Add(consolebuffer);
            MainPanel.Children.Add(inputbox);
        }
    }
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Console.Init();

            Content = Console.MainPanel;
        }
    }
}
