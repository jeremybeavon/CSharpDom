namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.Methods
{
    public static partial class StaticPartialClassWithMethodWithGenericParameterInterfaceConstraint
    {
        public static T Method<T>()
            where T : IInterface
        {
            return default(T);
        }
    }
}
