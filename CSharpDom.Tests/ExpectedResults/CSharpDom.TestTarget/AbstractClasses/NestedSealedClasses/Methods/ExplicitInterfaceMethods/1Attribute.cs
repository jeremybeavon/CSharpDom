namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public abstract class AbstractClassWithNestedSealedClassWithExplicitInterfaceMethodWith1Attribute
    {
        public sealed class Class : IInterfaceWithMethod
        {
            [Attribute1]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
