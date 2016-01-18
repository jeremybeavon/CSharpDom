namespace CSharpDom.Common
{
    public interface IProperty<TDeclaringType> : IHasName, IHasDeclaringType<TDeclaringType>
    {
        bool HasGet { get; }

        bool HasSet { get; }
    }
}
