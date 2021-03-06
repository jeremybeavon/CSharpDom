﻿using CSharpDom.CodeGeneration.Tree.Types;
using CSharpDom.Text;
using System.Collections.ObjectModel;
using System.Linq;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class CodeGenerationFile : TypeContainer
    {
        public CodeGenerationFile()
        {
            Usings = new Collection<UsingDeclaration>();
            Namespaces = new Collection<Namespace>();
        }

        public Collection<UsingDeclaration> Usings { get; set; }

        public Collection<Namespace> Namespaces { get; set; }

        public override string ToString()
        {
            return ToString(new ISourceCodeStyleRule[0]);
        }

        public string ToString(params ISourceCodeStyleRule[] styleRules)
        {
            return new ReadOnlyCodeGenerationFile(this).ToSourceCode(styleRules);
        }
    }
}
