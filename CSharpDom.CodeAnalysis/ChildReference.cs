using System;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class ChildReference<TParent, TChild>
        where TParent : class
    {
        public ChildReference(TChild child, Action<TParent> setParentAction)
        {
            Child = child;
            SetParent = setParentAction;
        }

        public TChild Child { get; private set; }

        public Action<TParent> SetParent { get; private set; }
    }
}
