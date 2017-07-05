namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class<T>
            where T : new()
        {
        }
    }
}
