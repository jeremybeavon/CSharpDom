namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Methods
{
    public sealed class SealedClassWithNestedStructWithMethodWithGenericParameterBaseClassConstraint
    {
        public struct Struct
        {
            public T Method<T>()
                where T : BaseClass
            {
                return default(T);
            }
        }
    }
}
