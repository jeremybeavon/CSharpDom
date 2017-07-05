namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public partial class PartialClassWithNestedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups
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
