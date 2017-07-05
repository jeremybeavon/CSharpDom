namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public class ClassWithNestedPartialClassWithExplicitInterfaceMethodWithParametersWithAttributes
    {
        public class Class : IInterfaceWithMethodWith2Parameters
        {
            void IInterfaceWithMethodWith2Parameters.Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
