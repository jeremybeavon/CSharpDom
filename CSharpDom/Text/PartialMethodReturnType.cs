using CSharpDom.BaseClasses;

namespace CSharpDom.Text
{
    internal sealed class PartialMethodReturnType : AbstractBuiltInTypeReference
    {
        public static readonly PartialMethodReturnType Instance = new PartialMethodReturnType();

        public override BuiltInType Type => BuiltInType.Void;
    }
}
