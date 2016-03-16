namespace CSharpDom.TestTarget.AbstractClasses.Methods.ExplicitInterfaceMethods
{
    public abstract class AbstractClassWithExplicitInterfaceMethodWith1Attribute : IInterfaceWithMethod
    {
        [Attribute1]
        void IInterfaceWithMethod.Method()
        {
        }
    }
}
