using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using System;

namespace CSharpDom.Reflection
{
    public sealed class EnumReferenceWithReflection :
        AbstractEnumReference,
        ITypeReferenceWithReflection,
        IVisitable<IReflectionVisitor>
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
            get { return type; }
        }
        
        public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitEnumReferenceWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }
    }
}
