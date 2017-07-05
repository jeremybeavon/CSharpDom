namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Methods.ExplicitInterfaceMethods
{
    public static class StaticClassWithNestedAbstractPartialClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups
    {
        public abstract class Class : IInterfaceWithMethod
        {
            [Attribute1]
            [Attribute2]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
