using CSharpDom.Common;
using CSharpDom.Editable;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AbstractClassConversionOperatorWithCodeAnalysis :
        EditableConversionOperator<
            AttributeGroupWithCodeAnalysis,
            IAbstractTypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            OperatorParameterWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasSyntax<ConversionOperatorDeclarationSyntax>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ClassConversionOperatorWithCodeAnalysis conversionOperator;

        public AbstractClassConversionOperatorWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            ConversionOperatorType operatorType,
            ITypeReferenceWithCodeAnalysis returnType,
            OperatorParameterWithCodeAnalysis parameter,
            MethodBodyWithCodeAnalysis body)
            : this(new ClassConversionOperatorWithCodeAnalysis(visibility, operatorType, returnType, parameter, body))
        {
        }

        internal AbstractClassConversionOperatorWithCodeAnalysis(ClassConversionOperatorWithCodeAnalysis conversionOperator)
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

        public override IAbstractTypeWithCodeAnalysis DeclaringType
        {
            get { return DeclaringTypeFunc?.Invoke() ?? conversionOperator.ConversionOperator.Node.GetParentNode<IAbstractTypeWithCodeAnalysis>(); }
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
        
        internal Func<IAbstractTypeWithCodeAnalysis> DeclaringTypeFunc { get; set; }

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
