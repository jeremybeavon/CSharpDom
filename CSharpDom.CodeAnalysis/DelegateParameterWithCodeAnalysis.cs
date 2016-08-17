﻿using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.CodeAnalysis
{
    public sealed class DelegateParameterWithCodeAnalysis :
        AbstractDelegateParameter<AttributeGroupWithCodeAnalysis, ITypeReferenceWithCodeAnalysis>
    {
        private readonly ParameterWithCodeAnalysis parameter;

        internal DelegateParameterWithCodeAnalysis(ParameterWithCodeAnalysis parameter)
        {
            this.parameter = parameter;
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
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

        public override ITypeReferenceWithCodeAnalysis ParameterType
        {
            get { return parameter.ParameterType; }
        }
    }
}