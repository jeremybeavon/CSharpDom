using System;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class GenericParameterWithReflection :
        AbstractGenericParameter<ITypeReferenceWithReflection>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ITypeReferenceWithReflection typeReference;

        internal GenericParameterWithReflection(Type type, MemberInfo member)
        {
            typeReference = TypeReferenceWithReflectionFactory.CreateReference(type, member);
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
