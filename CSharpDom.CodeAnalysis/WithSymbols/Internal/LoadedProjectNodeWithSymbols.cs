using CSharpDom.CodeAnalysis.WithSyntax.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.WithSymbols.Internal
{
    internal class LoadedProjectNodeWithSymbols : LoadedProjectNodeWithSyntax
    {
        public LoadedProjectNodeWithSymbols(ProjectNode project)
            : base(project)
        {
        }
    }
}
