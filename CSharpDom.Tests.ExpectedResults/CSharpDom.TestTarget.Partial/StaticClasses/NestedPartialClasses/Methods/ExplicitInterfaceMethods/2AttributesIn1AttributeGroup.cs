namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public static class StaticClassWithNestedPartialClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup
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
