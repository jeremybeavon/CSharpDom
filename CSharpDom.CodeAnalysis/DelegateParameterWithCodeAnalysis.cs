using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class DelegateParameterWithCodeAnalysis :
        EditableDelegateParameter<AttributeGroupWithCodeAnalysis, ITypeReferenceWithCodeAnalysis>,
        IHasSyntax<ParameterSyntax>,
        IHasNode<ParameterSyntax>
    {
        private readonly Guid internalId;
        private readonly ParameterWithCodeAnalysis parameter;
        
        internal DelegateParameterWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
            parameter = new ParameterWithCodeAnalysis(this);
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
        
        INode<ParameterSyntax> IHasNode<ParameterSyntax>.Node
        {
            get { return parameter.Node; }
        }
    }
}
