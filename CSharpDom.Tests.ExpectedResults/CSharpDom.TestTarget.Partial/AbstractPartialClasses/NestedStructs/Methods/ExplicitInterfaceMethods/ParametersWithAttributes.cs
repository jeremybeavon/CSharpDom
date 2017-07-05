namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public abstract partial class AbstractPartialClassWithNestedStructWithExplicitInterfaceMethodWithParametersWithAttributes
    {
        public struct Struct : IInterfaceWithMethodWith2Parameters
        {
            void IInterfaceWithMethodWith2Parameters.Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
