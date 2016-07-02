namespace CSharpDom.TestTarget.AbstractClasses.Methods.ExplicitInterfaceMethods
{
    public abstract class AbstractClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups : IInterfaceWithMethod
    {
        [Attribute1]
        [Attribute2]
        void IInterfaceWithMethod.Method()
        {
        }
    }
}
