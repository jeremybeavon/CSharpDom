namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class
        {
            public sealed class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
