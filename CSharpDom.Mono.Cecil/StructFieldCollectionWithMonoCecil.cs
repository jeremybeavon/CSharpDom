using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StructFieldCollectionWithMonoCecil :
        AbstractStructFieldCollection<StructFieldWithMonoCecil, IStructConstant>
    {
        private readonly StructTypeWithMonoCecil typeWithMonoCecil;

        internal StructFieldCollectionWithMonoCecil(StructTypeWithMonoCecil typeWithMonoCecil)
        {
            this.typeWithMonoCecil = typeWithMonoCecil;
        }

        public override IReadOnlyCollection<IStructConstant> Constants
        {
            get { return new IStructConstant[0]; }
        }

        protected override IReadOnlyCollection<StructFieldWithMonoCecil> Fields
        {
            get { return typeWithMonoCecil.FieldCollection.Fields; }
        }
    }
}
