namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.NestedStructs
{
    public abstract class AbstractClassWithNestedStructWithNestedStructWithGenericParameterStructConstraint
    {
        public struct Struct
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}
