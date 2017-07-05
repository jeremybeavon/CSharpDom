namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.NestedAbstractClasses
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class
        {
            public abstract class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
