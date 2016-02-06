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

        public override ClassMemberVisibilityModifier Visibility
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /*public override StaticClassMemberVisibilityModifier Visibility
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
        }*/
    }
}
