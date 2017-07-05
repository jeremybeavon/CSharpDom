namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.NestedSealedClasses
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints
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
