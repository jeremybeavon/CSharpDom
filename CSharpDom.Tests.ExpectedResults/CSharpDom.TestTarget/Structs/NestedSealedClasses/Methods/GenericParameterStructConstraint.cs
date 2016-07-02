namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Methods
{
    public struct StructWithNestedSealedClassWithMethodWithGenericParameterStructConstraint
    {
        public sealed class Class
        {
            public T Method<T>()
                where T : struct
            {
                return default(T);
            }
        }
    }
}
