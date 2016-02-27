using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class InterfaceReferenceWithMonoCecil :
        AbstractInterfaceReference<GenericParameterWithMonoCecil>,
        ITypeReferenceWithMonoCecil//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly Type type;
        private readonly Lazy<GenericParameters> genericParameters;

        internal InterfaceReferenceWithMonoCecil(Type type)
        {
            this.type = type;
            genericParameters = new Lazy<GenericParameters>(() => new GenericParameters(type));
        }

        public override IReadOnlyList<GenericParameterWithMonoCecil> GenericParameters
        {
            get { return genericParameters.Value.GenericParametersWithMonoCecil; }
        }

        public override string Name
        {
            get { return type.Name(); }
        }

        public Type Type
        {
            get { return type; }
        }
        
        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitInterfaceReferenceWithMonoCecil(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
