using System;
using System.Threading.Tasks;
using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis
{
    public sealed class DocumentWithCodeAnalysis :
        EditableDocument<ProjectWithCodeAnalysis, SolutionWithCodeAnalysis, LoadedDocumentWithCodeAnalysis>
    {
        public override string FullFilePath
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

        public override ProjectWithCodeAnalysis Project
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

        public override Task<LoadedDocumentWithCodeAnalysis> LoadAsync()
        {
            throw new NotImplementedException();
        }
    }
}
