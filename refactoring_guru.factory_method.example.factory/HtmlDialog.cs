using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using refactoring_guru.factory_method.example.buttons.HtmlButton;
using refactoring_guru.factory_method.example.buttons.Button;
namespace refactoring_guru.factory_method.example.factory
{
    public class HtmlDialog :Dialog {

    
    public override Button createButton() {
        return new HtmlButton();
    }
}
}