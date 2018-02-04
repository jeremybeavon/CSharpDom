using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class InterfaceAccessorWithCodeAnalysis :
        EditableInterfaceAccessor<AttributeGroupWithCodeAnalysis>,
        IHasSyntax<AccessorDeclarationSyntax>
    {
        private readonly AccessorWithCodeAnalysis accessor;

        public InterfaceAccessorWithCodeAnalysis(AccessorType accessorType)
            : this(new AccessorWithCodeAnalysis(accessorType))
        {
        }

        internal InterfaceAccessorWithCodeAnalysis(AccessorWithCodeAnalysis accessor)
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

        public AccessorDeclarationSyntax Syntax { get => accessor.Syntax; set => accessor.Syntax = value; }
    }
}
