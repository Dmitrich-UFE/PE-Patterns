using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Mediator: IMediator
    {
        private NameTextBox _nameTextBox, _surnameTextBox;
        private Checkbox _agree;

        internal Mediator() 
        {
            _nameTextBox = new NameTextBox(this);
            _surnameTextBox = new NameTextBox(this);
            _agree = new Checkbox(this);
        }

        void IMediator.Notify(IUIComponent sender, string _event) 
        {
            if (sender == _nameTextBox && _event == "WroteText") 
            {
                Console.WriteLine($"Что-то было написано в {nameof(_nameTextBox)}");
            }
            if (sender == _surnameTextBox && _event == "WroteText") 
            {
                Console.WriteLine($"Что-то было написано в {nameof(_surnameTextBox)}");
            }
            if (sender == _agree &&  _event == "Clicked") 
            {
                if (_agree.isMarked()) 
                {
                    Console.WriteLine("Отмечена галочка согласия");
                }
                else 
                {
                    Console.WriteLine("Нет галочки согласия");
                }
            }

        }
    }
}
