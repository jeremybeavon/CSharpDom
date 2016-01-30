using CSharpDom.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ProjectFactory : AbstractAsyncFactory<IProject, Project>
    {
        public ProjectFactory(IProject project)
            : base(project)
        {
        }

        public override async Task VisitProjectAsync<TSolution, TDocument, TLoadedProject>(
            IProject<TSolution, TDocument, TLoadedProject> project)
        {
            List<Document> documents = new List<Document>();
            foreach (TDocument document in project.Documents)
            {
                documents.Add(await new DocumentFactory(document).ValueAsync());
            }

            Value = new Project()
            {
                Documents = documents
            };
        }
    }
}
