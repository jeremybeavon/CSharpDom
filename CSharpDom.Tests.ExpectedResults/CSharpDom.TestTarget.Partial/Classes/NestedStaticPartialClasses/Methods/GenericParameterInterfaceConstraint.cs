namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.Methods
{
    public class ClassWithNestedStaticPartialClassWithMethodWithGenericParameterInterfaceConstraint
    {
        public static partial class Class
        {
            public static T Method<T>()
                where T : IInterface
            {
                return default(T);
            }
        }
    }
}
