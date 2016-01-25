using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Reflection
{
    public sealed class NestedTypeReferenceWithReflection :
        AbstractNestedTypeReference<ITypeReferenceWithReflection>,
        ITypeReferenceWithReflection
    {
        private readonly ITypeReferenceWithReflection type;
        private readonly ITypeReferenceWithReflection nestedType;

        internal NestedTypeReferenceWithReflection(Type nestedType)
        {
            type = TypeReferenceWithReflectionFactory.CreateReference(nestedType.DeclaringType);
            this.nestedType = TypeReferenceWithReflectionFactory.CreateReference(nestedType, ignoreNestedType: true);
        }

        public override ITypeReferenceWithReflection NestedType
        {
            get { return nestedType; }
        }

        public override ITypeReferenceWithReflection Type
        {
            get { return type; }
        }
    }
}
