namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.NestedAbstractClasses
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
