using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructFieldCollectionWithCodeAnalysis :
        AbstractStructFieldCollection<StructFieldWithCodeAnalysis, IStructConstant>
    {
        private readonly StructTypeWithCodeAnalysis typeWithCodeAnalysis;

        internal StructFieldCollectionWithCodeAnalysis(StructTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            this.typeWithCodeAnalysis = typeWithCodeAnalysis;
        }

        public override IReadOnlyCollection<IStructConstant> Constants
        {
            get { return typeWithCodeAnalysis.FieldCollection.Fields.ConstantsWithCodeAnalysis; }
        }

        protected override IReadOnlyCollection<StructFieldWithCodeAnalysis> Fields
        {
            get { return typeWithCodeAnalysis.FieldCollection.Fields.FieldsWithCodeAnalysis; }
        }
    }
}
