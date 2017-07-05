namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedClasses
{
    public class ClassWithNestedPartialClassWithNestedPartialClassWithGenericParameterGenericParameterConstraint
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
