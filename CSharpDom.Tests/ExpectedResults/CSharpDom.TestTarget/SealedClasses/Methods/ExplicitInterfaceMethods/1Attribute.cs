namespace CSharpDom.TestTarget.SealedClasses.Methods.ExplicitInterfaceMethods
{
    public sealed class SealedClassWithExplicitInterfaceMethodWith1Attribute : IInterfaceWithMethod
    {
        [Attribute1]
        void IInterfaceWithMethod.Method()
        {
        }
    }
}
