namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public sealed class SealedClassWithNestedSealedPartialClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup
    {
        public sealed class Class : IInterfaceWithMethod
        {
            [Attribute1, Attribute2]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
