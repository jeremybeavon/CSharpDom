namespace CSharpDom.TestTarget.Classes.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public class ClassWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups
    {
        public struct Struct : IInterfaceWithMethod
        {
            [Attribute1]
            [Attribute2]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
