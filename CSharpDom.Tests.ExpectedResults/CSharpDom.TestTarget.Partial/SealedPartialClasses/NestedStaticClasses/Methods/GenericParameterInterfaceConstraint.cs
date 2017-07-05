namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.Methods
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithMethodWithGenericParameterInterfaceConstraint
    {
        public static class Class
        {
            public static T Method<T>()
                where T : IInterface
            {
                return default(T);
            }
        }
    }
}
