namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public sealed class SealedClassWithNestedSealedClassWithExplicitInterfaceMethodWith1Attribute
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
