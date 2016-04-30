namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedClassWithGenericParameterEmptyConstructorConstraint
    {
        public class Class<T>
            where T : new()
        {
        }
    }
}
