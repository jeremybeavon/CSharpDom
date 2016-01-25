using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using System;
using System.Collections.Generic;

namespace CSharpDom.Reflection
{
    public sealed class DelegateReferenceWithReflection :
        AbstractDelegateReference<GenericParameterWithReflection>,
        ITypeReferenceWithReflection
    {
        private readonly Type type;
        private readonly Lazy<GenericParameters> genericParameters;

        internal DelegateReferenceWithReflection(Type type)
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
    }
}
