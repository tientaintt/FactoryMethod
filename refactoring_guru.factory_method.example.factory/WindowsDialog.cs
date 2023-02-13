using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using refactoring_guru.factory_method.example.buttons.Button;
using refactoring_guru.factory_method.example.buttons.WindowsButton;
namespace refactoring_guru.factory_method.example.factory
{
    public class WindowsDialog : Dialog {

    
    public Button createButton() {
        return new WindowsButton();
    }
    }
}