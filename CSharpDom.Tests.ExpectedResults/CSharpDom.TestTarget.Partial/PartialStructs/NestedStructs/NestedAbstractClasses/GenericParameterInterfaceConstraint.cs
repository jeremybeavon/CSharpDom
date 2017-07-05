namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedAbstractClasses
{
    public partial struct PartialStructWithWithNestedStructWithNestedAbstractClassWithGenericParameterInterfaceConstraint
    {
        public struct Struct
        {
            public abstract class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
