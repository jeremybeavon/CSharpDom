namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public static class StaticClassWithNestedSealedPartialClassWithExplicitInterfaceMethodWith1Attribute
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
