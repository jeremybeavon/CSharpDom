using CSharpDom.BaseClasses.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class ProjectPartialClassCollectionWithCodeAnalysis :
        AbstractPartialClassCollection<
            PartialClassWithCodeAnalysis,
            AbstractPartialClassWithCodeAnalysis,
            SealedPartialClassWithCodeAnalysis,
            StaticPartialClassWithCodeAnalysis>
    {
        private readonly IReadOnlyCollection<PartialClassWithCodeAnalysis> classes;
        private readonly IReadOnlyCollection<AbstractPartialClassWithCodeAnalysis> abstractClasses;
        private readonly IReadOnlyCollection<SealedPartialClassWithCodeAnalysis> sealedClasses;
        private readonly IReadOnlyCollection<StaticPartialClassWithCodeAnalysis> staticClasses;

        internal ProjectPartialClassCollectionWithCodeAnalysis(LoadedProjectWithCodeAnalysis project)
        {
            abstractClasses = project.Members(document => document.Classes.PartialClasses.AbstractClasses);
            classes = project.Members(document => document.Classes.PartialClasses.Classes);
            sealedClasses = project.Members(document => document.Classes.PartialClasses.SealedClasses);
            staticClasses = project.Members(document => document.Classes.PartialClasses.StaticClasses);
        }

        public override IReadOnlyCollection<PartialClassWithCodeAnalysis> Classes => classes;

        public override IReadOnlyCollection<AbstractPartialClassWithCodeAnalysis> AbstractClasses => abstractClasses;

        public override IReadOnlyCollection<SealedPartialClassWithCodeAnalysis> SealedClasses => sealedClasses;

        public override IReadOnlyCollection<StaticPartialClassWithCodeAnalysis> StaticClasses => staticClasses;
    }
}
