namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.NestedStructs
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNestedStructWithGenericParameterBaseClassConstraint
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
