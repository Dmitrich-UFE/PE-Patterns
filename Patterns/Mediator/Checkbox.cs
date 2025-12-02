using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Checkbox: IUIComponent
    {
        private IMediator _mediator;
        private bool _isMarked;
        internal Checkbox(IMediator mediator) { _mediator = mediator; _isMarked = false; }
        void IUIComponent.Interact()
        {
            _isMarked = true;
            _mediator.Notify(this, "Clicked");
        }

        internal bool isMarked() { return _isMarked; }

    }
}
