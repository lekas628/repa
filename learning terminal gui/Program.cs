using System;
using Terminal.Gui;

// https://sirwan.info/archive/2018/05/02/Developing-Console-based-UI-in-C/


namespace learning_terminal_gui
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.Init();
            var top = Application.Top;


            //var n = MessageBox.Query(50, 7, "Question", "Do you like console apps?", "Yes", "No");
            //Console.WriteLine(n);

            var win = new Window(new Rect(0, 1, top.Frame.Width, top.Frame.Height - 1), "Myapp");
            top.Add(win);

            var menu = new MenuBar(new MenuBarItem[] {
                new MenuBarItem("_File", new MenuItem []
                {
                    new MenuItem("_New", "Creates new file", ()=> {}),
                    new MenuItem("_Close", "", ()=> {}),
                    new MenuItem("_Quit", "", ()=> {top.Running = false; }),
                }),
                new MenuBarItem("_Edit", new MenuItem[]
                {
                    new MenuItem ("_Copy", "", null),
                    new MenuItem ("_Cut", "", null),
                    new MenuItem ("_Paste", "", null),
                })
            });
            top.Add(menu);

            win.Add(
                new Label(3, 2, "Login: "),
                new TextField(14, 2, 40, ""),
                new Label(3, 4, "Password: "),
                new TextField(14, 4, 40, "") { },
                new CheckBox(3, 6, "Remember me"),
                new RadioGroup(3, 8, new NStack.ustring[] { "_Personal", "_Company" }),
                new Button(3, 14, "Ok"),
                new Button(10, 14, "Cancel"),
                new Label(3, 18, "Press ESC and 9 to activate the menubar"));





            Application.Run();
        }
    }

}
