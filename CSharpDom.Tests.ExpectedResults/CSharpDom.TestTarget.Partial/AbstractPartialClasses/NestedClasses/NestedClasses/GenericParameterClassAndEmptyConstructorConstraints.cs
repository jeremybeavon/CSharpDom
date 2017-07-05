namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.NestedClasses
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
