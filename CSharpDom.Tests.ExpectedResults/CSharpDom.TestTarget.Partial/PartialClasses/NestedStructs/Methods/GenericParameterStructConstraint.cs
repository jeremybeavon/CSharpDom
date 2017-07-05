namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Methods
{
    public partial class PartialClassWithNestedStructWithMethodWithGenericParameterStructConstraint
    {
        public struct Struct
        {
            public T Method<T>()
                where T : struct
            {
                return default(T);
            }
        }
    }
}
