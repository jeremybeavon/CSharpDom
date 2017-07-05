namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Methods
{
    public abstract partial class AbstractPartialClassWithNestedStructWithMethodWithGenericParameterClassConstraint
    {
        public struct Struct
        {
            public T Method<T>()
                where T : class
            {
                return default(T);
            }
        }
    }
}
