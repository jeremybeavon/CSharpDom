namespace CSharpDom.TestTarget.Classes.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public class ClassWithNestedClassWithExplicitInterfaceMethodWith1Attribute
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
