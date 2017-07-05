namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedInterfaces
{
    public class ClassWithNestedStructWithNestedInterfaceWithGenericParameterGenericParameterConstraint
    {
        public struct Struct
        {
            public interface Interface<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
