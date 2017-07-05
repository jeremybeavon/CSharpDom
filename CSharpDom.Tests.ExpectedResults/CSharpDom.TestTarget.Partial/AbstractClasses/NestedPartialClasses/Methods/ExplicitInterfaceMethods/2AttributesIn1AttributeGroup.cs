namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public abstract class AbstractClassWithNestedPartialClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup
    {
        public class Class : IInterfaceWithMethod
        {
            [Attribute1, Attribute2]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
