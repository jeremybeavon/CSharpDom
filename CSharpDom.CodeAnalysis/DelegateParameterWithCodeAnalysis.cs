using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class DelegateParameterWithCodeAnalysis :
        EditableDelegateParameter<AttributeGroupWithCodeAnalysis, ITypeReferenceWithCodeAnalysis>,
        IHasSyntax<ParameterSyntax>
    {
        private readonly ParameterWithCodeAnalysis parameter;

        internal DelegateParameterWithCodeAnalysis(ParameterWithCodeAnalysis parameter)
        {
            this.parameter = parameter;
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return parameter.Attributes; }
            set { parameter.Attributes = value; }
        }

        public override ParameterModifier Modifier
        {
            get { return Syntax.Modifiers.ToParameterModifier(); }
            set
            {
                ParameterSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithParameterModifier(value));
            }
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
