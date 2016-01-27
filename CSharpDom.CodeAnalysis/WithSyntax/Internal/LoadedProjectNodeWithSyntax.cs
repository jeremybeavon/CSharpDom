using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.WithSyntax.Internal
{
    internal class LoadedProjectNodeWithSyntax : LoadedProjectNode
    {
        public LoadedProjectNodeWithSyntax(ProjectNode project)
            : base(project)
        {
        }

        public override AbstractSyntaxNode CreateNode()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
