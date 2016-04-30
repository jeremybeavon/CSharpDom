namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public struct StructWithNestedSealedClassWithExplicitInterfaceMethodWith1Attribute
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
