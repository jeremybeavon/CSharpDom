namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedStaticPartialClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
    {
        public static partial class Class
        {
            public interface Interface<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
