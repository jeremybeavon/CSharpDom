using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyClassAccessor : AbstractClassAccessor<AttributeGroupNotSupported, ReadOnlyMethodBody>
    {
        private readonly ReadOnlyMethodBody body;
        private readonly ClassAccessorVisibilityModifier visibility;

        public ReadOnlyClassAccessor(ClassAccessor accessor)
            : this(accessor.Visibility)
        {
            body = new ReadOnlyMethodBody(accessor.Body);
        }

        public ReadOnlyClassAccessor(ClassAccessorVisibilityModifier visibility)
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
                    case ClassAccessorVisibilityModifier.None:
                        return CSharpDom.ClassMemberVisibilityModifier.None;
                    case ClassAccessorVisibilityModifier.Internal:
                        return CSharpDom.ClassMemberVisibilityModifier.Internal;
                    case ClassAccessorVisibilityModifier.ProtectedInternal:
                        return CSharpDom.ClassMemberVisibilityModifier.ProtectedInternal;
                    case ClassAccessorVisibilityModifier.Protected:
                        return CSharpDom.ClassMemberVisibilityModifier.Protected;
                    case ClassAccessorVisibilityModifier.Private:
                        return CSharpDom.ClassMemberVisibilityModifier.Private;
                    default:
                        throw new NotSupportedException();
                }
            }
        }
    }
}
