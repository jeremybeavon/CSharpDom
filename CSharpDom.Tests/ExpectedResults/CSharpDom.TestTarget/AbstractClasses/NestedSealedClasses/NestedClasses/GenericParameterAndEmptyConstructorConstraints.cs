namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
