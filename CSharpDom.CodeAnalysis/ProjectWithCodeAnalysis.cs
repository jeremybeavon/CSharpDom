using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ProjectWithCodeAnalysis :
        EditableProject<SolutionWithCodeAnalysis, DocumentWithCodeAnalysis, LoadedProjectWithCodeAnalysis>
    {
        public override ICollection<DocumentWithCodeAnalysis> Documents
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override SolutionWithCodeAnalysis Solution
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override Task<LoadedProjectWithCodeAnalysis> LoadAsync()
        {
            throw new NotImplementedException();
        }
    }
}
