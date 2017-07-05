namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup
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
