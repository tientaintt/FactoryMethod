using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace refactoring_guru.factory_method.example.buttons
{
   /**
 * Common interface for all buttons.
 */
public interface Button {
    void render();
    void onClick();
}
}