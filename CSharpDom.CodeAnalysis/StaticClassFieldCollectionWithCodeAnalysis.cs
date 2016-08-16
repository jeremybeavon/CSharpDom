using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassFieldCollectionWithCodeAnalysis :
        AbstractStaticClassFieldCollection<StaticClassFieldWithCodeAnalysis, StaticClassConstantWithCodeAnalysis>
    {
        private readonly StaticTypeWithCodeAnalysis typeWithCodeAnalysis;

        internal StaticClassFieldCollectionWithCodeAnalysis(StaticTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            this.typeWithCodeAnalysis = typeWithCodeAnalysis;
        }
        
        public override IReadOnlyCollection<StaticClassConstantWithCodeAnalysis> Constants
        {
            get { return typeWithCodeAnalysis.FieldCollection.Fields.ConstantsWithCodeAnalysis; }
        }

        protected override IReadOnlyCollection<StaticClassFieldWithCodeAnalysis> Fields
        {
            get { return typeWithCodeAnalysis.FieldCollection.Fields.FieldsWithCodeAnalysis; }
        }
    }
}
