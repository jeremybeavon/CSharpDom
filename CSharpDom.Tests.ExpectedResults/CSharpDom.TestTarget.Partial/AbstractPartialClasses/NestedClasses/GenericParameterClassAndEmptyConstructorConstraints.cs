namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses
{
    public abstract partial class AbstractPartialClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class<T>
            where T : class, new()
        {
        }
    }
}
