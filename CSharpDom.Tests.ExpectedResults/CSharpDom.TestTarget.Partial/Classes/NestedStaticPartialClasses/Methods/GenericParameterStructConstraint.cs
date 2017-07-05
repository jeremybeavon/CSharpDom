namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.Methods
{
    public class ClassWithNestedStaticPartialClassWithMethodWithGenericParameterStructConstraint
    {
        public static partial class Class
        {
            public static T Method<T>()
                where T : struct
            {
                return default(T);
            }
        }
    }
}
