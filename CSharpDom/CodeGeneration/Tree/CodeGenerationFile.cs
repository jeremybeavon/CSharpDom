using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class CodeGenerationFile : CodeGenerationNode
    {
        public CodeGenerationFile()
        {
            Namespaces = new Collection<Namespace>();
        }

        public Collection<Namespace> Namespaces { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
