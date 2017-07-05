namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedAbstractClasses
{
    public partial struct PartialStructWithWithNestedStructWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public abstract class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
