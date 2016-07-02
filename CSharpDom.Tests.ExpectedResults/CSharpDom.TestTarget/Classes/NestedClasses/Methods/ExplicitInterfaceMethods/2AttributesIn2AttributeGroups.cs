namespace CSharpDom.TestTarget.Classes.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public class ClassWithNestedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups
    {
        public class Class : IInterfaceWithMethod
        {
            [Attribute1]
            [Attribute2]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
