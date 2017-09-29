namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.NestedStructs
{
    public partial struct PartialStructWithNestedAbstractClassWithNestedStructWithGenericParameterStructConstraint
    {
        public abstract class Class
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}
