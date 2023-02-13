using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using refactoring_guru.factory_method.example.buttons.Button;
namespace refactoring_guru.factory_method.example.factory
{
   /**
 * Base factory class. Note that "factory" is merely a role for the class. It
 * should have some core business logic which needs different products to be
 * created.
 */
public abstract class Dialog {

    public void renderWindow() {
        // ... other code ...

        Button okButton = createButton();
        okButton.render();
    }

    /**
     * Subclasses will override this method in order to create specific button
     * objects.
     */
    public abstract Button createButton();
}
}