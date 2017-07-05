namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedAbstractClasses
{
    public class ClassWithNestedStaticPartialClassWithNestedAbstractPartialClassWithGenericParameterClassConstraint
    {
        public static partial class Class
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
