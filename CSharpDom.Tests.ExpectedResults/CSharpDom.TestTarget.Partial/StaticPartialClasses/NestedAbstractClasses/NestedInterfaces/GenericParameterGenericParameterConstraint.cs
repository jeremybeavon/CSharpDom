namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.NestedInterfaces
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class
        {
            public interface Interface<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
