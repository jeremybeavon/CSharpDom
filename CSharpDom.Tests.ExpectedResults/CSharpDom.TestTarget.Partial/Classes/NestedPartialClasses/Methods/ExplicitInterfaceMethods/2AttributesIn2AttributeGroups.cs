namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public class ClassWithNestedPartialClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups
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
