using System;
using CSharpDom.BaseClasses;

namespace CSharpDom.Reflection
{
    public sealed class GenericParameterReferenceWithReflection : AbstractGenericParameterReference, ITypeReferenceWithReflection
    {
        private readonly Type type;

        internal GenericParameterReferenceWithReflection(Type type)
        {
            this.type = type;
        }

        public override string Name
        {
            get { return type.Name; }
        }
    }
}
