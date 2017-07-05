namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedSealedClasses
{
    public class ClassWithNestedPartialClassWithNestedSealedPartialClassWithGenericParameterGenericParameterConstraint
    {
        public partial class Class
        {
            public sealed class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
