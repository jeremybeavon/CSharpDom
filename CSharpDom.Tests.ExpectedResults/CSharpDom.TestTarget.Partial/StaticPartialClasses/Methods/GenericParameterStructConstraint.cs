namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.Methods
{
    public static partial class StaticPartialClassWithMethodWithGenericParameterStructConstraint
    {
        public static T Method<T>()
            where T : struct
        {
            return default(T);
        }
    }
}
