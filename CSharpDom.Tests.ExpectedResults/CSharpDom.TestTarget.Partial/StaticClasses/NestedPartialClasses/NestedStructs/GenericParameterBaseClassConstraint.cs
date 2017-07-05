namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedStructs
{
    public static class StaticClassWithNestedPartialClassWithNestedStructWithGenericParameterBaseClassConstraint
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
