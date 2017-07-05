namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedClasses
{
    public sealed class SealedClassWithNestedPartialClassWithNestedPartialClassWithGenericParameterGenericParameterConstraint
    {
        public partial class Class
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
