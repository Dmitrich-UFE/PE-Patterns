using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class PhysicalObjectsCompositor: IPhysicalObject
    {
        private List<IPhysicalObject> _physicalObjects;

        internal PhysicalObjectsCompositor() 
        {
            _physicalObjects = new List<IPhysicalObject>();
        }

        void IPhysicalObject.CalculatePhysics() 
        {
            foreach(var physicalObject in _physicalObjects) 
            {
                physicalObject.CalculatePhysics();
            }
        }

        internal void Add(IPhysicalObject physicalObject) 
        {
            _physicalObjects.Add(physicalObject);
        }

        internal void Remove(IPhysicalObject physicalObject) 
        {
            _physicalObjects?.Remove(physicalObject);
        }
    }
}
