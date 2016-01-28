using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyClassPropertyAccessor : AbstractAccessor<AttributeGroupNotSupported, ReadOnlyMethodBody>
    {
        private readonly ReadOnlyMethodBody body;
        private readonly ClassPropertyAccessorVisibilityModifier visibility;

        public ReadOnlyClassPropertyAccessor(ClassPropertyAccessor accessor)
            : this(accessor.Visibility)
        {
            body = new ReadOnlyMethodBody(accessor.Body);
        }

        public ReadOnlyClassPropertyAccessor(ClassPropertyAccessorVisibilityModifier visibility)
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

        public override MemberVisibilityModifier Visibility
        {
            get
            {
                switch (visibility)
                {
                    case ClassPropertyAccessorVisibilityModifier.None:
                        return MemberVisibilityModifier.None;
                    case ClassPropertyAccessorVisibilityModifier.Internal:
                        return MemberVisibilityModifier.Internal;
                    case ClassPropertyAccessorVisibilityModifier.ProtectedInternal:
                        return MemberVisibilityModifier.ProtectedInternal;
                    case ClassPropertyAccessorVisibilityModifier.Protected:
                        return MemberVisibilityModifier.Protected;
                    case ClassPropertyAccessorVisibilityModifier.Private:
                        return MemberVisibilityModifier.Private;
                    default:
                        throw new NotSupportedException();
                }
            }
        }
    }
}
