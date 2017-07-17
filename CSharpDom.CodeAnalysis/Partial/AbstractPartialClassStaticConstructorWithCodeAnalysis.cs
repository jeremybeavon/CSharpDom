﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class AbstractPartialClassStaticConstructorWithCodeAnalysis :
        EditableStaticConstructor<
            AttributeGroupWithCodeAnalysis,
            IAbstractPartialTypeWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasSyntax<ConstructorDeclarationSyntax>
    {
        private readonly ClassStaticConstructorWithCodeAnalysis staticConstructor;

        internal AbstractPartialClassStaticConstructorWithCodeAnalysis(ClassStaticConstructorWithCodeAnalysis staticConstructor)
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

        public override IAbstractPartialTypeWithCodeAnalysis DeclaringType
        {
            get { return staticConstructor.StaticConstructor.Node.GetParentNode<IAbstractPartialTypeWithCodeAnalysis>(); }
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
