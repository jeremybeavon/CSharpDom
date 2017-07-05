namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithNestedPartialClassWithGenericParameterBaseClassConstraint
    {
        public static partial class Class
        {
            public class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
