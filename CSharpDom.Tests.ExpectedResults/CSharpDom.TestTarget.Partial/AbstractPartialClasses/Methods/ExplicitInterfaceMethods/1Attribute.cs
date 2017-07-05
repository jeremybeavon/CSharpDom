namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Methods.ExplicitInterfaceMethods
{
    public abstract partial class AbstractPartialClassWithExplicitInterfaceMethodWith1Attribute : IInterfaceWithMethod
    {
        [Attribute1]
        void IInterfaceWithMethod.Method()
        {
        }
    }
}
