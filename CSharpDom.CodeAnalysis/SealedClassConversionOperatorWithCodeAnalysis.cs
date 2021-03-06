﻿using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class SealedClassConversionOperatorWithCodeAnalysis :
        EditableConversionOperator<
            AttributeGroupWithCodeAnalysis,
            ISealedTypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            OperatorParameterWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasSyntax<ConversionOperatorDeclarationSyntax>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ClassConversionOperatorWithCodeAnalysis conversionOperator;

        public SealedClassConversionOperatorWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            ConversionOperatorType operatorType,
            ITypeReferenceWithCodeAnalysis returnType,
            OperatorParameterWithCodeAnalysis parameter,
            MethodBodyWithCodeAnalysis body)
            : this(new ClassConversionOperatorWithCodeAnalysis(visibility, operatorType, returnType, parameter, body))
        {
        }

        internal SealedClassConversionOperatorWithCodeAnalysis(ClassConversionOperatorWithCodeAnalysis conversionOperator)
        {
            this.conversionOperator = conversionOperator;
            conversionOperator.DeclaringTypeFunc = () => DeclaringType.Class;
        }

        public ClassConversionOperatorWithCodeAnalysis ConversionOperator
        {
            get { return conversionOperator; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return conversionOperator.Attributes; }
            set { conversionOperator.Attributes = value; }
        }

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return conversionOperator.Body; }
            set { conversionOperator.Body = value; }
        }

        public override ISealedTypeWithCodeAnalysis DeclaringType
        {
            get { return DeclaringTypeFunc?.Invoke() ?? conversionOperator.ConversionOperator.Node.GetParent<ISealedTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override ConversionOperatorType OperatorType
        {
            get { return conversionOperator.OperatorType; }
            set { conversionOperator.OperatorType = value; }
        }

        public override OperatorParameterWithCodeAnalysis Parameter
        {
            get { return conversionOperator.Parameter; }
            set { conversionOperator.Parameter = value; }
        }
        
        public override ICollection<AttributeGroupWithCodeAnalysis> ReturnAttributes
        {
            get { return conversionOperator.ReturnAttributes; }
            set { conversionOperator.ReturnAttributes = value; }
        }

        public override ITypeReferenceWithCodeAnalysis ReturnType
        {
            get { return conversionOperator.ReturnType; }
            set { conversionOperator.ReturnType = value; }
        }
        
        public ConversionOperatorDeclarationSyntax Syntax
        {
            get { return conversionOperator.Syntax; }
            set { conversionOperator.Syntax = value; }
        }

        internal Func<ISealedTypeWithCodeAnalysis> DeclaringTypeFunc { get; set; }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitConversionOperatorWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
