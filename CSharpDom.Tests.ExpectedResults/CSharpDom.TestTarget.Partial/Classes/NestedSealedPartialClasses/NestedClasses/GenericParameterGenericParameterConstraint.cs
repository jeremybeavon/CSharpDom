namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedClasses
{
    public class ClassWithNestedSealedPartialClassWithNestedPartialClassWithGenericParameterGenericParameterConstraint
    {
        public sealed partial class Class
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
