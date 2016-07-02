namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public static class StaticClassWithNestedClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup
    {
        public class Class : IInterfaceWithMethod
        {
            [Attribute1, Attribute2]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
