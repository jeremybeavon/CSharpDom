namespace CSharpDom.TestTarget.Classes.Methods.ExplicitInterfaceMethods
{
    public class ClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup : IInterfaceWithMethod
    {
        [Attribute1, Attribute2]
        void IInterfaceWithMethod.Method()
        {
        }
    }
}
