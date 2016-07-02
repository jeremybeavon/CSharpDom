namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public sealed class SealedClassWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup
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
