namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public sealed class SealedClassWithNestedSealedPartialClassWithExplicitInterfaceMethodWith1Attribute
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
