namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public sealed class SealedClassWithNestedStructWithExplicitInterfaceMethodWith1Attribute
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
