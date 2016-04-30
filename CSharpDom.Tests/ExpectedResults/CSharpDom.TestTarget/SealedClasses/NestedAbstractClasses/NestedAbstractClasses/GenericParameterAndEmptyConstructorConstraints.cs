namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public abstract class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
