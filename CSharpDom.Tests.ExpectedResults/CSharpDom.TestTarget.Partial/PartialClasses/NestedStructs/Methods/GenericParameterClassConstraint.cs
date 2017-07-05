namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Methods
{
    public partial class PartialClassWithNestedStructWithMethodWithGenericParameterClassConstraint
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
