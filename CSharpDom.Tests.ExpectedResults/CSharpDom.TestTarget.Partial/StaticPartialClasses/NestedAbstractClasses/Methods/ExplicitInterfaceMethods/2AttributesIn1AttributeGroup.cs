namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.Methods.ExplicitInterfaceMethods
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup
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
