namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public abstract class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
