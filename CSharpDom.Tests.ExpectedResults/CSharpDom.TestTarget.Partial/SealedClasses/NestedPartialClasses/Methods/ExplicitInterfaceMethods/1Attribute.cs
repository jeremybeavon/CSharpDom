namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public sealed class SealedClassWithNestedPartialClassWithExplicitInterfaceMethodWith1Attribute
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
