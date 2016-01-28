using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyInterfacePropertyAccessor : AbstractAccessor<AttributeGroupNotSupported, MethodBodyNotSupported>
    {
        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override MethodBodyNotSupported Body
        {
            get { return new MethodBodyNotSupported(); }
        }

        public override MemberVisibilityModifier Visibility
        {
            get { return MemberVisibilityModifier.None; }
        }
    }
}
