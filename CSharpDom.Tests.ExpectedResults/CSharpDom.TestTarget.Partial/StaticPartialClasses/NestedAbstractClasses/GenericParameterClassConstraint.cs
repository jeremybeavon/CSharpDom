namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithGenericParameterClassConstraint
    {
        public abstract class Class<T>
            where T : class
        {
        }
    }
}
