using System;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class GenericParameterWithMonoCecil :
        AbstractGenericParameter<ITypeReferenceWithMonoCecil>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ITypeReferenceWithMonoCecil typeReference;

        internal GenericParameterWithMonoCecil(AssemblyWithMonoCecil assembly, GenericParameter type)
        {
            typeReference = TypeReferenceWithMonoCecilFactory.CreateReference(assembly, type);
        }

        public override ITypeReferenceWithMonoCecil Type
        {
            get { return typeReference; }
        }
        
        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitGenericParameterWithMonoCecil(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
