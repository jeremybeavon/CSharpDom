namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedStaticClasses
{
    public class ClassWithNestedPartialClassWithNestedStaticPartialClassWithGenericParameterGenericParameterConstraint
    {
        public partial class Class
        {
            public static class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
