namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public static class StaticClassWithNestedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups
    {
        public class Class : IInterfaceWithMethod
        {
            [Attribute1]
            [Attribute2]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
