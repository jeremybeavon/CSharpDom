using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStructAccessor :
        AbstractStructAccessor<AttributeGroupNotSupported, ReadOnlyMethodBody>,
        IStructAutoPropertyAccessor<AttributeGroupNotSupported>
    {
        private readonly StructAccessorVisibilityModifier visibility;
        private readonly ReadOnlyMethodBody body;

        public ReadOnlyStructAccessor(StructAccessor accessor)
            : this(accessor.Visibility)
        {
            body = new ReadOnlyMethodBody(accessor.Body);
        }

        public ReadOnlyStructAccessor(StructAccessorVisibilityModifier visibility)
        {
            this.visibility = visibility;
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override ReadOnlyMethodBody Body
        {
            get { return body; }
        }

        public override StructAccessorVisibilityModifier Visibility
        {
            get { return visibility; }
        }
    }
}
