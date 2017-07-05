namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public partial class PartialClassWithNestedStructWithExplicitInterfaceMethodWithParametersWithAttributes
    {
        public struct Struct : IInterfaceWithMethodWith2Parameters
        {
            void IInterfaceWithMethodWith2Parameters.Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
