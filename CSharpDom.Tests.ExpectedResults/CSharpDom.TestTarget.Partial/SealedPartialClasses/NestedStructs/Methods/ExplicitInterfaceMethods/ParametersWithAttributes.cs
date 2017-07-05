namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public sealed partial class SealedPartialClassWithNestedStructWithExplicitInterfaceMethodWithParametersWithAttributes
    {
        public struct Struct : IInterfaceWithMethodWith2Parameters
        {
            void IInterfaceWithMethodWith2Parameters.Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
