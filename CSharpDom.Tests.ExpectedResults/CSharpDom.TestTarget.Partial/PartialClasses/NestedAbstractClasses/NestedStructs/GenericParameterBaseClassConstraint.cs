namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedStructs
{
    public partial class PartialClassWithNestedAbstractClassWithNestedStructWithGenericParameterBaseClassConstraint
    {
        public abstract class Class
        {
            public struct NestedStruct<T>
                where T : BaseClass
            {
            }
        }
    }
}
