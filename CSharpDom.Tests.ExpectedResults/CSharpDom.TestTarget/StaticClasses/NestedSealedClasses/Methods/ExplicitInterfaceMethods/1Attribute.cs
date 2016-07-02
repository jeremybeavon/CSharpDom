namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public static class StaticClassWithNestedSealedClassWithExplicitInterfaceMethodWith1Attribute
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
