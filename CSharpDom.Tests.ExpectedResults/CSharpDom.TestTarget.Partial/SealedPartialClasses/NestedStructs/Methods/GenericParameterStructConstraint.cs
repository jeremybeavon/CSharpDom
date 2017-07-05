namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Methods
{
    public sealed partial class SealedPartialClassWithNestedStructWithMethodWithGenericParameterStructConstraint
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
