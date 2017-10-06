using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassConversionOperatorWithCodeAnalysis :
        EditableConversionOperator<
            AttributeGroupWithCodeAnalysis,
            IClassTypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            OperatorParameterWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasSyntax<ConversionOperatorDeclarationSyntax>,
        IHasNode<ConversionOperatorDeclarationSyntax>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ConversionOperatorWithCodeAnalysis conversionOperator;

        public ClassConversionOperatorWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            ConversionOperatorType operatorType,
            ITypeReferenceWithCodeAnalysis returnType,
            OperatorParameterWithCodeAnalysis parameter,
            MethodBodyWithCodeAnalysis body)
            : this()
        {
            Syntax = SyntaxFactory.ConversionOperatorDeclaration(
                default(SyntaxList<AttributeListSyntax>),
                default(SyntaxTokenList).WithClassMemberVisibilityModifier(visibility).Add(SyntaxKind.StaticKeyword),
                SyntaxFactory.Token(operatorType == ConversionOperatorType.Implicit ? SyntaxKind.ImplicitKeyword : SyntaxKind.ExplicitKeyword),
                returnType.Syntax,
                SyntaxFactory.ParameterList(SyntaxFactory.SingletonSeparatedList(parameter.Syntax)),
                body.Syntax,
                null);
        }

        internal ClassConversionOperatorWithCodeAnalysis()
        {
            conversionOperator = new ConversionOperatorWithCodeAnalysis();
        }

        public ConversionOperatorWithCodeAnalysis ConversionOperator
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

        public override IClassTypeWithCodeAnalysis DeclaringType
        {
            get { return DeclaringTypeFunc?.Invoke() ?? conversionOperator.Node.GetParentNode<IClassTypeWithCodeAnalysis>(); }
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
        
        INode<ConversionOperatorDeclarationSyntax> IHasNode<ConversionOperatorDeclarationSyntax>.Node
        {
            get { return conversionOperator.Node; }
        }

        internal Func<IClassTypeWithCodeAnalysis> DeclaringTypeFunc { get; set; }

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
