namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.NestedClasses
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNestedClassWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class
        {
            public class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
