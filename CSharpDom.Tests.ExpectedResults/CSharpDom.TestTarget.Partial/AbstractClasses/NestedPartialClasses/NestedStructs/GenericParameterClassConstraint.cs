namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedStructWithGenericParameterClassConstraint
    {
        public partial class Class
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}
