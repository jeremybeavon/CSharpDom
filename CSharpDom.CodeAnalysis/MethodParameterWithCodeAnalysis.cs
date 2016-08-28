using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class MethodParameterWithCodeAnalysis :
        EditableMethodParameter<AttributeGroupWithCodeAnalysis, ITypeReferenceWithCodeAnalysis>,
        IHasSyntax<ParameterSyntax>,
        IHasId
    {
        private readonly Guid internalId;
        private readonly ParameterWithCodeAnalysis parameter;

        internal MethodParameterWithCodeAnalysis(MethodWithCodeAnalysis parent)
            : this()
        {
            parameter = new ParameterWithCodeAnalysis(parent, this);
        }

        private MethodParameterWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
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

        public override ParameterModifier Modifier
        {
            get { return Syntax.Modifiers.ToParameterModifier(); }
            set { Syntax.Modifiers.WithParameterModifier(value); }
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

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }
    }
}
