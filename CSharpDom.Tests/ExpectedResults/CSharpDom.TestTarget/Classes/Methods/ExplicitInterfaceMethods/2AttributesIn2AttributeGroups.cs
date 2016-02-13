namespace CSharpDom.TestTarget.Classes.Methods.ExplicitInterfaceMethods
{
    public class ClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups : IInterfaceWithMethod
    {
        [Attribute1]
        [Attribute2]
        void IInterfaceWithMethod.Method()
        {
        }
    }
}
