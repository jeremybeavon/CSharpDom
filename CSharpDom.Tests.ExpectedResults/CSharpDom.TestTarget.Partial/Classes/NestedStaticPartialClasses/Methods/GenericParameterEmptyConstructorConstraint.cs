namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.Methods
{
    public class ClassWithNestedStaticPartialClassWithMethodWithGenericParameterEmptyConstructorConstraint
    {
        public static partial class Class
        {
            public static T Method<T>()
                where T : new()
            {
                return default(T);
            }
        }
    }
}
