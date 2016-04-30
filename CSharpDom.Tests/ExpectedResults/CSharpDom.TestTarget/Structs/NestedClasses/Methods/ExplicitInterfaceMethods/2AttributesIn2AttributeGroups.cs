namespace CSharpDom.TestTarget.Structs.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public struct StructWithNestedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups
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
