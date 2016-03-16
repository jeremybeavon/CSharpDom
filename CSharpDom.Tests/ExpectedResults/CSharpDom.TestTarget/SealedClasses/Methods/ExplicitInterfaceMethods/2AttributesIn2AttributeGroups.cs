namespace CSharpDom.TestTarget.SealedClasses.Methods.ExplicitInterfaceMethods
{
    public sealed class SealedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups : IInterfaceWithMethod
    {
        [Attribute1]
        [Attribute2]
        void IInterfaceWithMethod.Method()
        {
        }
    }
}
