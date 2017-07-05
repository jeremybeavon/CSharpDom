namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public struct StructWithNestedSealedPartialClassWithExplicitInterfaceMethodWith1Attribute
    {
        public sealed class Class : IInterfaceWithMethod
        {
            [Attribute1]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
