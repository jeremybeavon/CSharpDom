namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedAbstractClasses
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints
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
