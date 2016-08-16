using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ExtensionParameterWithCodeAnalysis :
        AbstractExtensionParameter<AttributeGroupWithCodeAnalysis, ITypeReferenceWithCodeAnalysis>
    {
        private readonly MethodParameterWithCodeAnalysis parameter;

        internal ExtensionParameterWithCodeAnalysis(MethodParameterWithCodeAnalysis parameter)
        {
            this.parameter = parameter;
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return parameter.Attributes; }
        }
        
        public override string Name
        {
            get { return parameter.Name; }
        }

        public override ITypeReferenceWithCodeAnalysis ParameterType
        {
            get { return parameter.ParameterType; }
        }
    }
}
