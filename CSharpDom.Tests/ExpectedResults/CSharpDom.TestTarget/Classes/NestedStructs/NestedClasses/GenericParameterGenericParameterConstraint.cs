namespace CSharpDom.TestTarget.Classes.NestedStructs.NestedClasses
{
    public class ClassWithNestedStructWithNestedClassWithGenericParameterGenericParameterConstraint
    {
        public struct Struct
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
