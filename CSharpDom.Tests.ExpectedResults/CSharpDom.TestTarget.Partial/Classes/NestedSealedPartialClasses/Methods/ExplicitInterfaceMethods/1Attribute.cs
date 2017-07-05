namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public class ClassWithNestedSealedPartialClassWithExplicitInterfaceMethodWith1Attribute
    {
        public sealed class Class : IInterfaceWithMethod
        {
            [Attribute1]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
