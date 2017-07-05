namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithNestedPartialClassWithGenericParameterClassConstraint
    {
        public static partial class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
