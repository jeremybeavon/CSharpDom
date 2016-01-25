using System;
using CSharpDom.BaseClasses;

namespace CSharpDom.Reflection
{
    public sealed class InterfaceReferenceWithReflection : AbstractInterfaceReference
    {
        private readonly Type type;

        internal InterfaceReferenceWithReflection(Type type)
        {
            this.type = type;
        }

        public override string Name
        {
            get { return type.Name; }
        }
    }
}
