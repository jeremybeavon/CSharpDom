namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public sealed class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
