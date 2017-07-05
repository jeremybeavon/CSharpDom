namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public static partial class StaticPartialClassWithNestedClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup
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
