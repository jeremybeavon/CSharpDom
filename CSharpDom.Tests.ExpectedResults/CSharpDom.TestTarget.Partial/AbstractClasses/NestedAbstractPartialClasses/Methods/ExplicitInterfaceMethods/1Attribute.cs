namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Methods.ExplicitInterfaceMethods
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithExplicitInterfaceMethodWith1Attribute
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
