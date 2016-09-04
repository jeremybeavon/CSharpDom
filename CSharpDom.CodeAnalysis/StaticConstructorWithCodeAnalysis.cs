//using System;
//using System.Collections.Generic;
//using CSharpDom.Common;
//using CSharpDom.Editable;
//using Microsoft.CodeAnalysis.CSharp.Syntax;

//namespace CSharpDom.CodeAnalysis
//{
//    public sealed class StaticConstructorWithCodeAnalysis :
//        EditableStaticConstructor<AttributeGroupWithCodeAnalysis, IType, MethodBodyWithCodeAnalysis>,
//        IHasSyntax<ConstructorDeclarationSyntax>
//    {
//        private readonly Node<StaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax> node;
//        private readonly 

//        private StaticConstructorWithCodeAnalysis()
//        {
//            node = new Node<StaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax>(this);
//        }

//        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
//        {
//            get { return attributes.Value.AttributesWithCodeAnalysis; }
//        }

//        public override MethodBodyWithCodeAnalysis Body
//        {
//            get { return body.Value; }
//        }

//        public MethodDefinition MethodDefinition { get; private set; }

//        public override ITypeWithCodeAnalysis DeclaringType
//        {
//            get { return declaringType; }
//        }
//    }
//}
