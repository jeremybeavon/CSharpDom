namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedStructWithGenericParameterBaseClassConstraint
    {
        public sealed partial class Class
        {
            public struct NestedStruct<T>
                where T : BaseClass
            {
            }
        }
    }
}
