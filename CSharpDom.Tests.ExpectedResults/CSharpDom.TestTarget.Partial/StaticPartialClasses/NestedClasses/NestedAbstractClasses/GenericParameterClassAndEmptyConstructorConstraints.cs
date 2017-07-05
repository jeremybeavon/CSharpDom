namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.NestedAbstractClasses
{
    public static partial class StaticPartialClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
