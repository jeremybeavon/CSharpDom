﻿using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStaticClassAccessor :
        AbstractStaticClassAccessor<AttributeGroupNotSupported, ReadOnlyMethodBody>
    {
        private readonly StaticClassAccessorVisibilityModifier visibility;
        private readonly ReadOnlyMethodBody body;

        public ReadOnlyStaticClassAccessor(StaticClassAccessor accessor)
            : this(accessor.Visibility)
        {
            body = new ReadOnlyMethodBody(accessor.Body);
        }

        public ReadOnlyStaticClassAccessor(StaticClassAccessorVisibilityModifier visibility)
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

        public override StaticClassAccessorVisibilityModifier Visibility
        {
            get { return visibility; }
        }
    }
}
