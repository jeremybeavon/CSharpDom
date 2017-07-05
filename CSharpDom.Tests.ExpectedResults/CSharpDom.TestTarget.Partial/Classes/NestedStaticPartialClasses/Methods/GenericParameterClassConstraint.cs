namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.Methods
{
    public class ClassWithNestedStaticPartialClassWithMethodWithGenericParameterClassConstraint
    {
        public static partial class Class
        {
            public static T Method<T>()
                where T : class
            {
                return default(T);
            }
        }
    }
}
