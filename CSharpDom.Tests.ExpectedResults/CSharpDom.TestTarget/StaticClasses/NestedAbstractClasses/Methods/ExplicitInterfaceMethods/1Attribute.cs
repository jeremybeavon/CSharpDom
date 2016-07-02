namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Methods.ExplicitInterfaceMethods
{
    public static class StaticClassWithNestedAbstractClassWithExplicitInterfaceMethodWith1Attribute
    {
        public abstract class Class : IInterfaceWithMethod
        {
            [Attribute1]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
