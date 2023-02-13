using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static refactoring_guru.factory_method.example.factory.Dialog;
using static refactoring_guru.factory_method.example.factory.WindowsDialog;
using static refactoring_guru.factory_method.example.factory.HtmlDialog;


namespace refactoring_guru.factory_method.example
{
    public class Demo
{
    private  static Dialog dialog;

    static void Main(string[] args)
    {
        Configure();
        RunBusinessLogic();
    }

    static void Configure()
    {
        if (System.Environment.OSVersion.ToString().Contains("Windows 10"))
        {
            dialog = new WindowsDialog();
        }
        else
        {
            dialog = new HtmlDialog();
        }
    }

    static void RunBusinessLogic()
    {
        dialog.RenderWindow();
    }
}
}