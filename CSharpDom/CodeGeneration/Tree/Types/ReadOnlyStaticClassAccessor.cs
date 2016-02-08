using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStaticClassAccessor :
        AbstractStaticClassAccessor<AttributeGroupNotSupported, ReadOnlyMethodBody>
    {
        private readonly ReadOnlyMethodBody body;
        private readonly ClassAccessorVisibilityModifier visibility;

        public ReadOnlyStaticClassAccessor(StaticClassAccessor accessor)
            : this(accessor.Visibility)
        {
            body = new ReadOnlyMethodBody(accessor.Body);
        }

        public ReadOnlyStaticClassAccessor(ClassAccessorVisibilityModifier visibility)
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

        public override StaticClassMemberVisibilityModifier Visibility
        {
            get
            {
                switch (visibility)
                {
                    case ClassAccessorVisibilityModifier.None:
                        return StaticClassMemberVisibilityModifier.None;
                    case ClassAccessorVisibilityModifier.Internal:
                        return StaticClassMemberVisibilityModifier.Internal;
                    case ClassAccessorVisibilityModifier.Private:
                        return StaticClassMemberVisibilityModifier.Private;
                    default:
                        throw new NotSupportedException();
                }
            }
        }
    }
}
