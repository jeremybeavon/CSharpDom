namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class<T>
            where T : class, new()
        {
        }
    }
}
