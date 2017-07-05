namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedAbstractClasses
{
    public partial struct PartialStructWithWithNestedStructWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct
        {
            public abstract class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
