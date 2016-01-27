using System;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class GenericParameterReferenceWithReflection :
        AbstractGenericParameterReference,
        ITypeReferenceWithReflection,
        IVisitable<IReflectionVisitor>
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

        public Type Type
        {
            get { return type; }
        }


        public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitGenericParameterReferenceWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }
    }
}
