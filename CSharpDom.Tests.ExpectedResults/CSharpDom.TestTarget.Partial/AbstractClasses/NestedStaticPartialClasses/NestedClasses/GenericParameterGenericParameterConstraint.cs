namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithNestedPartialClassWithGenericParameterGenericParameterConstraint
    {
        public static partial class Class
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
