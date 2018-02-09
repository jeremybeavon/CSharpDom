using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ExtensionParameterWithCodeAnalysis :
        EditableExtensionParameter<AttributeGroupWithCodeAnalysis, ITypeReferenceWithCodeAnalysis>,
        IHasSyntax<ParameterSyntax>
    {
        private readonly ParameterWithCodeAnalysis parameter;

        public ExtensionParameterWithCodeAnalysis(ITypeReferenceWithCodeAnalysis type, string name)
        {
            parameter = new ParameterWithCodeAnalysis(type, name);
        }

        internal ExtensionParameterWithCodeAnalysis()
        {
            parameter = new ParameterWithCodeAnalysis();
        }

        public ParameterWithCodeAnalysis Parameter
        {
            get { return parameter; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return parameter.Attributes; }
            set { parameter.Attributes = value; }
        }
        
        public override string Name
        {
            get { return parameter.Name; }
            set { parameter.Name = value; }
        }

        public override ITypeReferenceWithCodeAnalysis ParameterType
        {
            get { return parameter.ParameterType; }
            set { parameter.ParameterType = value; }
        }

        public ParameterSyntax Syntax
        {
            get { return parameter.Syntax; }
            set { parameter.Syntax = value; }
        }
    }
}
