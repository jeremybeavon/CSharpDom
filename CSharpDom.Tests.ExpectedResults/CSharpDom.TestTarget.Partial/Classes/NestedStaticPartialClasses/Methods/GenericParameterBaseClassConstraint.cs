namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.Methods
{
    public class ClassWithNestedStaticPartialClassWithMethodWithGenericParameterBaseClassConstraint
    {
        public static partial class Class
        {
            public static T Method<T>()
                where T : BaseClass
            {
                return default(T);
            }
        }
    }
}
