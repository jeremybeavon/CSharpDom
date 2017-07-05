namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public class ClassWithNestedPartialClassWithExplicitInterfaceMethodWith1Attribute
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
