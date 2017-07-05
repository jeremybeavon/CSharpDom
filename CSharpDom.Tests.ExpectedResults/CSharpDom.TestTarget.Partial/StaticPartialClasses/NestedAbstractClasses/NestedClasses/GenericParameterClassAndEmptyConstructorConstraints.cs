namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.NestedClasses
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints
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
