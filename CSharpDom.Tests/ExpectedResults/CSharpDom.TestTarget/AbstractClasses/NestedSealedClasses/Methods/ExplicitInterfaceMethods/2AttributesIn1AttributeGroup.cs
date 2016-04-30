namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public abstract class AbstractClassWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup
    {
        public sealed class Class : IInterfaceWithMethod
        {
            [Attribute1, Attribute2]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
