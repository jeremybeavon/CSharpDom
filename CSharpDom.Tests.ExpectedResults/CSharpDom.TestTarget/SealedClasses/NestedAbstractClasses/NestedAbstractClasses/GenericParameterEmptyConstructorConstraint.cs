namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class
        {
            public abstract class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
