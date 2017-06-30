using System;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class GenericParameterWithMonoCecil :
        AbstractGenericParameter<ITypeReferenceWithMonoCecil>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ITypeReferenceWithMonoCecil typeReference;

        internal GenericParameterWithMonoCecil(AssemblyWithMonoCecil assembly, TypeReference type)
        {
            typeReference = TypeReferenceWithMonoCecilFactory.CreateReference(assembly, type, type);
        }

        public ITypeReferenceWithMonoCecil Type
        {
            get { return typeReference; }
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitIfNotNull(Type, visitor);
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
