using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class StructReferenceWithReflection :
        AbstractStructReference<GenericParameterWithReflection>,
        ITypeReferenceWithReflection//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly Type type;
        private readonly Lazy<GenericParameters> genericParameters;

        internal StructReferenceWithReflection(Type type)
        {
            this.type = type;
            genericParameters = new Lazy<GenericParameters>(() => new GenericParameters(type));
        }

        public override IReadOnlyList<GenericParameterWithReflection> GenericParameters
        {
            get { return genericParameters.Value.GenericParametersWithReflection; }
        }

        public override string Name
        {
            get { return type.Name; }
        }

        public Type Type
        {
            get { return type; }
        }
        
        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitStructReferenceWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
