namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedStructWithGenericParameterStructConstraint
    {
        public sealed class Class
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}
