namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithExplicitInterfaceMethodWith1Attribute
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
