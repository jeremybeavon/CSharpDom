﻿using CSharpDom.Editable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AccessorWithBodyWithCodeAnalysis :
        EditableAccessor<AttributeGroupWithCodeAnalysis, MethodBodyWithCodeAnalysis>,
        IHasSyntax<AccessorDeclarationSyntax>
    {
        private readonly AccessorWithCodeAnalysis accessor;
        private readonly MethodBodyNode<AccessorWithCodeAnalysis, AccessorDeclarationSyntax> body;

        internal AccessorWithBodyWithCodeAnalysis(AccessorWithCodeAnalysis accessor)
        {
            this.accessor = accessor;
            body = new MethodBodyNode<AccessorWithCodeAnalysis, AccessorDeclarationSyntax>(
                accessor.Node,
                (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax),
                parent => new MethodBodyWithCodeAnalysis(parent),
                (child, parent) => child.AccessorParent = parent);
        }

        public AccessorWithCodeAnalysis Accessor
        {
            get { return accessor; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return accessor.Attributes; }
            set { accessor.Attributes = value; }
        }

        public override MethodBodyWithCodeAnalysis Body
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public AccessorDeclarationSyntax Syntax
        {
            get { return accessor.Syntax; }
            set { accessor.Syntax = value; }
        }
    }
}
