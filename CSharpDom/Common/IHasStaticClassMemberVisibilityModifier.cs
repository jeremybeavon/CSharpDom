namespace CSharpDom.Common
{
    public interface IHasStaticClassMemberVisibilityModifier
    {
        StaticClassMemberVisibilityModifier InheritanceModifier { get; }
    }
}
