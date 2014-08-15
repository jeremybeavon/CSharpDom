namespace CSharpDom.WithSymbols
{
    public abstract class AbstractSymbolNode
    {
        public abstract void Accept(SymbolsVisitor visitor);

        public abstract override string ToString();
    }
}
