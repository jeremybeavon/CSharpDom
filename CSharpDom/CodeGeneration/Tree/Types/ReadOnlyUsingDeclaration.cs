using System;
using CSharpDom.BaseClasses;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyUsingDeclaration : AbstractUsingDirective
    {
        private readonly string name;

        public ReadOnlyUsingDeclaration(UsingDeclaration usingDeclaration)
        {
            name = usingDeclaration.Namespace;
        }

        public override string Name
        {
            get { return name; }
        }
    }
}
