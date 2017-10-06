using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AbstractAccessorWithCodeAnalysis :
        EditableAbstractAccessor<AttributeGroupWithCodeAnalysis>,
        IHasSyntax<AccessorDeclarationSyntax>
    {
        private AccessorWithCodeAnalysis accessor;

        public AbstractAccessorWithCodeAnalysis(AccessorType type)
            : this(new AccessorWithCodeAnalysis(type))
        {
        }

        internal AbstractAccessorWithCodeAnalysis(AccessorWithCodeAnalysis accessor)
        {
            this.accessor = accessor;
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
        
        public AccessorDeclarationSyntax Syntax
        {
            get { return accessor.Syntax; }
            set { accessor.Syntax = value; }
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
