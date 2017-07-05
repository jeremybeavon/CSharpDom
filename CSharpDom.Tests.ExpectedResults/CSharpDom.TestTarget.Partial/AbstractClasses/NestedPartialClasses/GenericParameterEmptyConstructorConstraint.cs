namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public class Class<T>
            where T : new()
        {
        }
    }
}
