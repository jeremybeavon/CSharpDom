namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.Methods
{
    public static partial class StaticPartialClassWithMethodWithGenericParameterBaseClassConstraint
    {
        public static T Method<T>()
            where T : BaseClass
        {
            return default(T);
        }
    }
}
