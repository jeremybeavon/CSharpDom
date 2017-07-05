namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Methods
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithMethodWithGenericParameterStructConstraint
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
