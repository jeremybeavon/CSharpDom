using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ProjectStructCollectionWithCodeAnalysis :
        AbstractStructCollection<StructWithCodeAnalysis, PartialStructWithCodeAnalysis>
    {
        private readonly IReadOnlyCollection<StructWithCodeAnalysis> structs;
        private readonly IReadOnlyCollection<PartialStructWithCodeAnalysis> partialStructs;

        internal ProjectStructCollectionWithCodeAnalysis(LoadedProjectWithCodeAnalysis project)
        {
            structs = project.Members(document => document.Structs.Structs);
            partialStructs = project.Members(document => document.Structs.PartialStructs);
        }

        public override IReadOnlyCollection<PartialStructWithCodeAnalysis> PartialStructs => partialStructs;

        protected override IReadOnlyCollection<StructWithCodeAnalysis> Structs => structs;
    }
}
