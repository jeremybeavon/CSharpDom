namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.NestedSealedClasses
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public sealed class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
