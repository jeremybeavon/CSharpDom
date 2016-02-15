using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.Reflection
{
    public sealed class DelegateParameterWithReflection :
        AbstractDelegateParameter<AttributeWithReflection, ITypeReferenceWithReflection>
    {
        private readonly ParameterWithReflection parameter;

        internal DelegateParameterWithReflection(ParameterWithReflection parameter)
        {
            this.parameter = parameter;
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return parameter.Attributes; }
        }

        public override ParameterModifier Modifier
        {
            get { return parameter.Modifier; }
        }

        public override string Name
        {
            get { return parameter.Name; }
        }

        public override ITypeReferenceWithReflection ParameterType
        {
            get { return parameter.ParameterType; }
        }
    }
}
