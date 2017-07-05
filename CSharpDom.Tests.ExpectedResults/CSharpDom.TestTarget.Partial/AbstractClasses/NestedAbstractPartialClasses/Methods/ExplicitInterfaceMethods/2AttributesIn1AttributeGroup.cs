namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Methods.ExplicitInterfaceMethods
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup
    {
        public abstract class Class : IInterfaceWithMethod
        {
            [Attribute1, Attribute2]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
