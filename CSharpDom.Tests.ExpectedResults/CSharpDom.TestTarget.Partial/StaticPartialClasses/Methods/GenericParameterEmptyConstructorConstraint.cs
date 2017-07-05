namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.Methods
{
    public static partial class StaticPartialClassWithMethodWithGenericParameterEmptyConstructorConstraint
    {
        public static T Method<T>()
            where T : new()
        {
            return default(T);
        }
    }
}
