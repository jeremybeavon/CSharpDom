using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class SealedPartialClassStaticConstructorWithCodeAnalysis :
        EditableStaticConstructor<
            AttributeGroupWithCodeAnalysis,
            ISealedPartialTypeWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasSyntax<ConstructorDeclarationSyntax>
    {
        private readonly SealedClassStaticConstructorWithCodeAnalysis staticConstructor;

        public SealedPartialClassStaticConstructorWithCodeAnalysis(
            string name,
            MethodBodyWithCodeAnalysis body)
            : this(new SealedClassStaticConstructorWithCodeAnalysis(name, body))
        {
        }

        internal SealedPartialClassStaticConstructorWithCodeAnalysis(
            SealedClassStaticConstructorWithCodeAnalysis staticConstructor)
        {
            this.staticConstructor = staticConstructor;
            staticConstructor.DeclaringTypeFunc = () => DeclaringType.Class;
        }

        public SealedClassStaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return staticConstructor; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return staticConstructor.Attributes; }
            set { staticConstructor.Attributes = value; }
        }

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return staticConstructor.Body; }
            set { staticConstructor.Body = value; }
        }

        public override ISealedPartialTypeWithCodeAnalysis DeclaringType
        {
            get { return staticConstructor.StaticConstructor.StaticConstructor.Node.GetParentNode<ISealedPartialTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public ConstructorDeclarationSyntax Syntax
        {
            get { return staticConstructor.Syntax; }
            set { staticConstructor.Syntax = value; }
        }
    }
}
