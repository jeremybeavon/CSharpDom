namespace CSharpDom.TestTarget.Partial.PartialClasses.Methods.ExplicitInterfaceMethods
{
    public partial class PartialClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups : IInterfaceWithMethod
    {
        [Attribute1]
        [Attribute2]
        void IInterfaceWithMethod.Method()
        {
        }
    }
}
