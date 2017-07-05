namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.NestedAbstractClasses
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public abstract class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
