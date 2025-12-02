using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class NameTextBox: IUIComponent
    {
        private IMediator _mediator;
        internal NameTextBox(IMediator mediator) { _mediator = mediator; }

        void IUIComponent.Interact() 
        {
            _mediator.Notify(this, "WroteText");
        }
    }
}
