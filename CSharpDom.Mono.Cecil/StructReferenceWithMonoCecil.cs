using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StructReferenceWithMonoCecil :
        AbstractStructReference<GenericParameterWithMonoCecil>,
        ITypeReferenceWithMonoCecil//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly TypeReference type;
        private readonly Lazy<GenericParameters> genericParameters;

        internal StructReferenceWithMonoCecil(AssemblyWithMonoCecil assembly, TypeReference type)
        {
            this.type = type;
            genericParameters = new Lazy<GenericParameters>(() => new GenericParameters(assembly, type));
        }

        public override IReadOnlyList<GenericParameterWithMonoCecil> GenericParameters
        {
            get { return genericParameters.Value.GenericParametersWithMonoCecil; }
        }

        public override string Name
        {
            get { return type.Name; }
        }

        public TypeReference TypeReference
        {
            get { return type; }
        }
        
        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitStructReferenceWithMonoCecil(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
