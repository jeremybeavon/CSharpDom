namespace CSharpDom.Common.IL
{
    public interface ILoadMemberTokenInstruction<TMemberReference> : ILoadMemberTokenInstruction
    {
        TMemberReference Member { get; }
    }
}
