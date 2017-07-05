namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public static partial class StaticPartialClassWithNestedClassWithExplicitInterfaceMethodWith1Attribute
    {
        public class Class : IInterfaceWithMethod
        {
            [Attribute1]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
