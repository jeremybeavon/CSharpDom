using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.Reflection
{
    public sealed class InterfaceReferenceWithReflection :
        AbstractInterfaceReference<GenericParameterWithReflection>
    {
        private readonly Type type;

        internal InterfaceReferenceWithReflection(Type type)
        {
            this.type = type;
        }

        public override IReadOnlyList<GenericParameterWithReflection> GenericParameters
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string Name
        {
            get { return type.Name; }
        }
    }
}
