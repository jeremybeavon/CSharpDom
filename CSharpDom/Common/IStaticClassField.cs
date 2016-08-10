namespace CSharpDom.Common
{
    public interface IStaticClassField : IStaticClassMember,
        IFieldGroup,
        IHasStaticClassMemberVisibilityModifier,
        IHasStaticClassFieldModifier
    {
    }
}
