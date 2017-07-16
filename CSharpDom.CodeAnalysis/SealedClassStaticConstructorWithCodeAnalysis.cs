﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class SealedClassStaticConstructorWithCodeAnalysis :
        EditableStaticConstructor<
            AttributeGroupWithCodeAnalysis, 
            ISealedTypeWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasSyntax<ConstructorDeclarationSyntax>
    {
        private readonly ClassStaticConstructorWithCodeAnalysis staticConstructor;

        internal SealedClassStaticConstructorWithCodeAnalysis(ClassStaticConstructorWithCodeAnalysis staticConstructor)
        {
            this.staticConstructor = staticConstructor;
        }

        public StaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return staticConstructor.StaticConstructor; }
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

        public override ISealedTypeWithCodeAnalysis DeclaringType
        {
            get { return staticConstructor.StaticConstructor.Node.GetParentNode<ISealedTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public ConstructorDeclarationSyntax Syntax
        {
            get { return staticConstructor.Syntax; }
            set { staticConstructor.Syntax = value; }
        }

        internal ClassStaticConstructorWithCodeAnalysis InternalStaticConstructor
        {
            get { return staticConstructor; }
        }
    }
}
