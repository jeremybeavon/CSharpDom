﻿using System;
using System.Collections.Generic;
using System.Reflection;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassConstructorWithCodeAnalysis :
        EditableClassConstructor<
            AttributeGroupWithCodeAnalysis,
            IClassTypeWithCodeAnalysis,
            ConstructorParameterWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasSyntax<ConstructorDeclarationSyntax>,
        IHasId
    {
        private readonly Guid internalId;
        private readonly ConstructorWithCodeAnalysis constructor;

        internal ClassConstructorWithCodeAnalysis(ClassTypeWithCodeAnalysis parent)
            : this()
        {
            constructor = new ConstructorWithCodeAnalysis(parent, this);
        }

        private ClassConstructorWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
        }

        internal ConstructorWithCodeAnalysis Constructor
        {
            get { return constructor; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return constructor.Attributes; }
            set { constructor.Attributes = value; }
        }

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return constructor.Body; }
            set { constructor.Body = value; }
        }
        
        public override IClassTypeWithCodeAnalysis DeclaringType
        {
            get { return constructor.Node.GetParentNode<IClassTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override IList<ConstructorParameterWithCodeAnalysis> Parameters
        {
            get { return constructor.Parameters; }
            set { constructor.Parameters = value; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToClassMemberVisibilityModifier(); }
            set
            {
                ConstructorDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithClassMemberVisibilityModifier(value));
            }
        }

        public ConstructorDeclarationSyntax Syntax
        {
            get { return constructor.Syntax; }
            set { constructor.Syntax = value; }
        }

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }
    }
}
