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
        ITypeReferenceWithReflection//,
        //IVisitable<IReflectionVisitor>
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

        Type IHasType.Type
        {
            get { return nestedType.Type; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitNestedTypeReferenceWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
