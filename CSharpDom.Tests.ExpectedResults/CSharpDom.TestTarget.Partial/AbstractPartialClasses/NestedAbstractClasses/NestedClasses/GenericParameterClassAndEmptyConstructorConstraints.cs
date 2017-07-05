namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.NestedClasses
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
