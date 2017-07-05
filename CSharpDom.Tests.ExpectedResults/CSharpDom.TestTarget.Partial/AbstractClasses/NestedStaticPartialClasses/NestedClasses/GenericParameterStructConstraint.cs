namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithNestedPartialClassWithGenericParameterStructConstraint
    {
        public static partial class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
