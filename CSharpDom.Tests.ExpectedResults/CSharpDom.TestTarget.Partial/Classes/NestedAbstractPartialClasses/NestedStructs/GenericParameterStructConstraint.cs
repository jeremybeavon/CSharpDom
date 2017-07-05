namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedStructs
{
    public class ClassWithNestedAbstractPartialClassWithNestedStructWithGenericParameterStructConstraint
    {
        public abstract partial class Class
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}
