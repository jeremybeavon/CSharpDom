namespace CSharpDom.Common.Editable
{
    public interface IHasEditableInterfaceMemberInheritanceModifier : IHasInterfaceMemberInheritanceModifier
    {
        new InterfaceMemberInheritanceModifier InheritanceModifier { get; set; }
    }
}