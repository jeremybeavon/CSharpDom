namespace CSharpDom.TestTarget.Partial.PartialClasses.Methods.ExplicitInterfaceMethods
{
    public partial class PartialClassWithExplicitInterfaceMethodWith1Attribute : IInterfaceWithMethod
    {
        [Attribute1]
        void IInterfaceWithMethod.Method()
        {
        }
    }
}
