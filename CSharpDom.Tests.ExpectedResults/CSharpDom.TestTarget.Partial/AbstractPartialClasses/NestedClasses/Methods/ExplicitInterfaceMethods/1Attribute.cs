namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public abstract partial class AbstractPartialClassWithNestedClassWithExplicitInterfaceMethodWith1Attribute
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
