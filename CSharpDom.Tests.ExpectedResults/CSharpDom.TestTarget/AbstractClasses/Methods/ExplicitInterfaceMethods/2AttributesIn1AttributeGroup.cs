namespace CSharpDom.TestTarget.AbstractClasses.Methods.ExplicitInterfaceMethods
{
    public abstract class AbstractClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup : IInterfaceWithMethod
    {
        [Attribute1, Attribute2]
        void IInterfaceWithMethod.Method()
        {
        }
    }
}
