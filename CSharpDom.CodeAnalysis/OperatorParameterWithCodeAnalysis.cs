﻿using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;


namespace CSharpDom.CodeAnalysis
{
    public sealed class OperatorParameterWithCodeAnalysis :
        EditableOperatorParameter<AttributeGroupWithCodeAnalysis, ITypeReferenceWithCodeAnalysis>,
        IHasSyntax<ParameterSyntax>,
        IHasId,
        IHasNode<ParameterSyntax>
    {
        private readonly Guid internalId;
        private readonly ParameterWithCodeAnalysis parameter;

        internal OperatorParameterWithCodeAnalysis(ConversionOperatorWithCodeAnalysis parent)
            : this()
        {
            parameter = new ParameterWithCodeAnalysis(parent, this);
        }

        internal OperatorParameterWithCodeAnalysis(OperatorOverloadWithCodeAnalysis parent)
            : this()
        {
            parameter = new ParameterWithCodeAnalysis(parent, this);
        }

        internal OperatorParameterWithCodeAnalysis()
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

        INode<ParameterSyntax> IHasNode<ParameterSyntax>.Node
        {
            get { return parameter.Node; }
        }
    }
}
