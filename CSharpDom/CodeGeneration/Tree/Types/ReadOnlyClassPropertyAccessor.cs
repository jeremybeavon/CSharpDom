using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyClassPropertyAccessor : AbstractClassAccessor<AttributeGroupNotSupported, ReadOnlyMethodBody>
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

        public override ClassMemberVisibilityModifier Visibility
        {
            get
            {
                switch (visibility)
                {
                    case ClassPropertyAccessorVisibilityModifier.None:
                        return CSharpDom.ClassMemberVisibilityModifier.None;
                    case ClassPropertyAccessorVisibilityModifier.Internal:
                        return CSharpDom.ClassMemberVisibilityModifier.Internal;
                    case ClassPropertyAccessorVisibilityModifier.ProtectedInternal:
                        return CSharpDom.ClassMemberVisibilityModifier.ProtectedInternal;
                    case ClassPropertyAccessorVisibilityModifier.Protected:
                        return CSharpDom.ClassMemberVisibilityModifier.Protected;
                    case ClassPropertyAccessorVisibilityModifier.Private:
                        return CSharpDom.ClassMemberVisibilityModifier.Private;
                    default:
                        throw new NotSupportedException();
                }
            }
        }
    }
}
