namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public static class StaticClassWithNestedSealedPartialClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup
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
