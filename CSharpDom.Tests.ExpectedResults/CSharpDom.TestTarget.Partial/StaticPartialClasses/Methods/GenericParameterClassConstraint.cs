namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.Methods
{
    public static partial class StaticPartialClassWithMethodWithGenericParameterClassConstraint
    {
        public static T Method<T>()
            where T : class
        {
            return default(T);
        }
    }
}
