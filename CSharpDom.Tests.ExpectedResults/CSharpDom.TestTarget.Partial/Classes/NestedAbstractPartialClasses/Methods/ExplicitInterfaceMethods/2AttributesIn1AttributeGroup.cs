namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Methods.ExplicitInterfaceMethods
{
    public class ClassWithNestedAbstractPartialClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup
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
