using System;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class GenericParameterWithReflection :
        AbstractGenericParameter<ITypeReferenceWithReflection>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ITypeReferenceWithReflection typeReference;

        internal GenericParameterWithReflection(Type type)
        {
            typeReference = TypeReferenceWithReflectionFactory.CreateReference(type);
        }

        public override ITypeReferenceWithReflection Type
        {
            get { return typeReference; }
        }


        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitGenericParameterWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
