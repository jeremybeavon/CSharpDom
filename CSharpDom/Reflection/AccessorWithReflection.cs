using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Reflection.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class AccessorWithReflection : AbstractAccessor<AttributeWithReflection>, IHasMethodInfo
    {
        private readonly MemberVisibilityModifier visibility;
        private readonly MethodInfo method;
        private readonly Lazy<Attributes> attributes;

        internal AccessorWithReflection(IHasMemberVisibilityModifier parentVisibility, MethodInfo method)
        {
            this.method = method;
            attributes = new Lazy<Attributes>(() => new Attributes(method));
            visibility = method.Visibility();
            if (parentVisibility.Visibility == visibility)
            {
                visibility = MemberVisibilityModifier.None;
            }
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override MemberVisibilityModifier Visibility
        {
            get { return visibility; }
        }

        public MethodInfo MethodInfo
        {
            get { return method; }
        }
    }
}
