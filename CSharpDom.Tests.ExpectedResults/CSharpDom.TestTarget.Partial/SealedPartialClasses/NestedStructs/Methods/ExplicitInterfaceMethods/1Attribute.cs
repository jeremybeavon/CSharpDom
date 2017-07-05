namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public sealed partial class SealedPartialClassWithNestedStructWithExplicitInterfaceMethodWith1Attribute
    {
        public struct Struct : IInterfaceWithMethod
        {
            [Attribute1]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
