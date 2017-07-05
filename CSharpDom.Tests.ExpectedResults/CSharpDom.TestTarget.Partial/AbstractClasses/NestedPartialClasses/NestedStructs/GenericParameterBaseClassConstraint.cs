namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedStructWithGenericParameterBaseClassConstraint
    {
        public partial class Class
        {
            public struct NestedStruct<T>
                where T : BaseClass
            {
            }
        }
    }
}
