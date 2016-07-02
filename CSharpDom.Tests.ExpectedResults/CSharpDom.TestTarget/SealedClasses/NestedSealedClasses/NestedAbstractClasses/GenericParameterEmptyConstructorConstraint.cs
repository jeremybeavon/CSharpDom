namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class
        {
            public abstract class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
