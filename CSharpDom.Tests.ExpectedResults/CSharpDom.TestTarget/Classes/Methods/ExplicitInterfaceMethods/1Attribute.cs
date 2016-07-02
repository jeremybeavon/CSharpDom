namespace CSharpDom.TestTarget.Classes.Methods.ExplicitInterfaceMethods
{
    public class ClassWithExplicitInterfaceMethodWith1Attribute : IInterfaceWithMethod
    {
        [Attribute1]
        void IInterfaceWithMethod.Method()
        {
        }
    }
}
