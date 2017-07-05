namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.NestedStructs
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNestedStructWithGenericParameterBaseClassConstraint
    {
        public sealed class Class
        {
            public struct NestedStruct<T>
                where T : BaseClass
            {
            }
        }
    }
}
