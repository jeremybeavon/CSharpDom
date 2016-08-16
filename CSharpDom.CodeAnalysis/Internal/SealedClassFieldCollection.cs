using System;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class SealedClassFieldCollection : AbstractClassFieldCollection
    {
        private readonly SealedTypeWithCodeAnalysis typeWithCodeAnalysis;

        public SealedClassFieldCollection(SealedTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            this.typeWithCodeAnalysis = typeWithCodeAnalysis;
        }

        public override IReadOnlyCollection<ClassConstantWithCodeAnalysis> Constants
        {
            get { return typeWithCodeAnalysis.FieldCollection.Fields.ConstantsWithCodeAnalysis; }
        }

        protected override IReadOnlyCollection<ClassFieldWithCodeAnalysis> Fields
        {
            get { return typeWithCodeAnalysis.FieldCollection.Fields.FieldsWithCodeAnalysis; }
        }
    }
}
