namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public partial struct PartialStructWithWithNestedStructWithExplicitInterfaceMethodWith1Attribute
    {
        public struct Struct : IInterfaceWithMethod
        {
            [Attribute1]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
