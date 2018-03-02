using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyClassAccessor :
        AbstractClassAccessor<AttributeGroupNotSupported, ReadOnlyMethodBody>,
        IClassAutoPropertyAccessor<AttributeGroupNotSupported>
    {
        private readonly ClassAccessorVisibilityModifier visibility;
        private readonly ReadOnlyMethodBody body;

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

        public override ClassAccessorVisibilityModifier Visibility
        {
            get { return visibility; }
        }
    }
}
