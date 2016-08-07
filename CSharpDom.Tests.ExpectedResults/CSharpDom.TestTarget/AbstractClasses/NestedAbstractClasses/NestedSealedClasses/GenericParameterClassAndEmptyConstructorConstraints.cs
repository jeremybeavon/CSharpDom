namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedAbstractClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public sealed class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
