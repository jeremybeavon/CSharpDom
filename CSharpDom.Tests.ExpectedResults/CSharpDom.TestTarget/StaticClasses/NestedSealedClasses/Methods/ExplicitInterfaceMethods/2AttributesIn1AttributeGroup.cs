namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public static class StaticClassWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup
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
