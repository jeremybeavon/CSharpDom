using CSharpDom.BaseClasses;
using System;

namespace CSharpDom.Reflection
{
    public sealed class EnumReferenceWithReflection : AbstractEnumReference, ITypeReferenceWithReflection
    {
        private readonly Type type;

        internal EnumReferenceWithReflection(Type type)
        {
            this.type = type;
        }

        public override string Name
        {
            get { return type.Name; }
        }

        public Type Type
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
