using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace refactoring_guru.factory_method.example.buttons
{
   /**
 * HTML button implementation.
 */
public class HtmlButton : Button {

    public void render() {
        Console.WriteLine("<button>Test Button</button>");
        onClick();
    }

    public void onClick() {
        Console.WriteLine("Click! Button says - 'Hello World!'");
    }
}
}