namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public abstract class AbstractClassWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup
    {
        public struct Struct : IInterfaceWithMethod
        {
            [Attribute1, Attribute2]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
