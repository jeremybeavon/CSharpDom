namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.Methods.ExplicitInterfaceMethods
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithExplicitInterfaceMethodWith1Attribute
    {
        public abstract class Class : IInterfaceWithMethod
        {
            [Attribute1]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
