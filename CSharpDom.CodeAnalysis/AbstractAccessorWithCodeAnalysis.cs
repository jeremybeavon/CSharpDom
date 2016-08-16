using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AbstractAccessorWithCodeAnalysis :
        AbstractAbstractAccessor<AttributeGroupWithCodeAnalysis>,
        //IVisitable<IReflectionVisitor>,
        IStructAccessor
    {
        private AccessorWithCodeAnalysis accessor;

        internal AbstractAccessorWithCodeAnalysis(IHasClassMemberVisibilityModifier parentVisibility, AccessorWithCodeAnalysis accessor)
        {
            this.accessor = accessor;
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return accessor.Attributes; }
        }
        
        public AccessorDeclarationSyntax Syntax
        {
            get { return accessor.Syntax; }
        }
        
        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitAccessorWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
