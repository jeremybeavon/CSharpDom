using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ProjectClassCollectionWithCodeAnalysis :
        AbstractClassCollection<
            ClassWithCodeAnalysis,
            AbstractClassWithCodeAnalysis,
            SealedClassWithCodeAnalysis,
            StaticClassWithCodeAnalysis,
            ProjectPartialClassCollectionWithCodeAnalysis>,
        IClassCollectionWithCodeAnalysis
    {
        private readonly IReadOnlyCollection<AbstractClassWithCodeAnalysis> abstractClasses;
        private readonly IReadOnlyCollection<ClassWithCodeAnalysis> classes;
        private readonly IReadOnlyCollection<SealedClassWithCodeAnalysis> sealedClasses;
        private readonly IReadOnlyCollection<StaticClassWithCodeAnalysis> staticClasses;
        private readonly ProjectPartialClassCollectionWithCodeAnalysis partialClasses;
        
        public ProjectClassCollectionWithCodeAnalysis(LoadedProjectWithCodeAnalysis project)
        {
            classes = project.Members(document => document.Classes.Classes);
            abstractClasses = project.Members(document => document.Classes.AbstractClasses);
            sealedClasses = project.Members(document => document.Classes.SealedClasses);
            staticClasses = project.Members(document => document.Classes.StaticClasses);
            partialClasses = new ProjectPartialClassCollectionWithCodeAnalysis(project);
        }

        public override IReadOnlyCollection<AbstractClassWithCodeAnalysis> AbstractClasses => abstractClasses;

        public override ProjectPartialClassCollectionWithCodeAnalysis PartialClasses => partialClasses;

        public override IReadOnlyCollection<SealedClassWithCodeAnalysis> SealedClasses => sealedClasses;

        public override IReadOnlyCollection<StaticClassWithCodeAnalysis> StaticClasses => staticClasses;

        protected override IReadOnlyCollection<ClassWithCodeAnalysis> Classes => classes;
    }
}
