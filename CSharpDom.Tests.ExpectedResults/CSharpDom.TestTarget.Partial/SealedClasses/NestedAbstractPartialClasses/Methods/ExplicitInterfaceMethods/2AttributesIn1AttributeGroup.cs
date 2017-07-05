namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Methods.ExplicitInterfaceMethods
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup
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
