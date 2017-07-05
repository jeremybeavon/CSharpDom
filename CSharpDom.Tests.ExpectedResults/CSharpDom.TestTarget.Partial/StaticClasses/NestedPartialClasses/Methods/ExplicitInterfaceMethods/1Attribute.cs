namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public static class StaticClassWithNestedPartialClassWithExplicitInterfaceMethodWith1Attribute
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
