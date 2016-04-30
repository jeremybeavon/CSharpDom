namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public abstract class AbstractClassWithNestedClassWithExplicitInterfaceMethodWith1Attribute
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
