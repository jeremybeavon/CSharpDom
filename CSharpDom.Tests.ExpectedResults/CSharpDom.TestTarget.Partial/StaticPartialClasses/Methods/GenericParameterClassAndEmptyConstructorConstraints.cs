namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.Methods
{
    public static partial class StaticPartialClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static T Method<T>()
            where T : class, new()
        {
            return default(T);
        }
    }
}
