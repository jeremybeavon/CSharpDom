namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.NestedStructs
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNestedStructWithGenericParameterClassConstraint
    {
        public abstract partial class Class
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}
