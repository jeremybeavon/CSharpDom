namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.NestedStructs
{
    public static class StaticClassWithNestedAbstractPartialClassWithNestedStructWithGenericParameterBaseClassConstraint
    {
        public abstract partial class Class
        {
            public struct NestedStruct<T>
                where T : BaseClass
            {
            }
        }
    }
}
