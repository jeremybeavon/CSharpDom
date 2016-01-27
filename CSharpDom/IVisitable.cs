namespace CSharpDom
{
    public interface IVisitable<TVisitor>
    {
        void Accept(TVisitor visitor);

        void AcceptChildren(TVisitor visitor);
    }
}
