using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStructPropertyAccessor : AbstractStructAccessor<AttributeGroupNotSupported, ReadOnlyMethodBody>
    {
        private readonly ReadOnlyMethodBody body;
        private readonly StructPropertyAccessorVisibilityModifier visibility;

        public ReadOnlyStructPropertyAccessor(StructPropertyAccessor accessor)
            : this(accessor.Visibility)
        {
            body = new ReadOnlyMethodBody(accessor.Body);
        }

        public ReadOnlyStructPropertyAccessor(StructPropertyAccessorVisibilityModifier visibility)
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

        public override StructMemberVisibilityModifier Visibility
        {
            get
            {
                switch (visibility)
                {
                    case StructPropertyAccessorVisibilityModifier.None:
                        return StructMemberVisibilityModifier.None;
                    case StructPropertyAccessorVisibilityModifier.Internal:
                        return StructMemberVisibilityModifier.Internal;
                    case StructPropertyAccessorVisibilityModifier.Private:
                        return StructMemberVisibilityModifier.Private;
                    default:
                        throw new NotSupportedException();
                }
            }
        }
    }
}
