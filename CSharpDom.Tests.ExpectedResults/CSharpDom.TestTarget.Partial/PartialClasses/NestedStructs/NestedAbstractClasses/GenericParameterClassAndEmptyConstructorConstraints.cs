namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedAbstractClasses
{
    public partial class PartialClassWithNestedStructWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints
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
