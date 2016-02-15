using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.Reflection
{
    public sealed class OperatorParameterWithReflection :
        AbstractOperatorParameter<AttributeWithReflection, ITypeReferenceWithReflection>
    {
        private readonly ParameterWithReflection parameter;

        internal OperatorParameterWithReflection(ParameterWithReflection parameter)
        {
            this.parameter = parameter;
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return parameter.Attributes; }
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
