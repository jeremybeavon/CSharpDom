namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public partial struct PartialStructWithWithNestedStructWithExplicitInterfaceMethodWithParametersWithAttributes
    {
        public struct Struct : IInterfaceWithMethodWith2Parameters
        {
            void IInterfaceWithMethodWith2Parameters.Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
