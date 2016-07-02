namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public static class StaticClassWithNestedClassWithExplicitInterfaceMethodWith1Attribute
    {
        public class Class : IInterfaceWithMethod
        {
            [Attribute1]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
