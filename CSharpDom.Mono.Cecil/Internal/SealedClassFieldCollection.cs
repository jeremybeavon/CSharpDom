using System;
using System.Collections.Generic;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class SealedClassFieldCollection : AbstractClassFieldCollection
    {
        private readonly SealedTypeWithMonoCecil typeWithMonoCecil;

        public SealedClassFieldCollection(SealedTypeWithMonoCecil typeWithMonoCecil)
        {
            this.typeWithMonoCecil = typeWithMonoCecil;
        }

        public override IReadOnlyCollection<ClassConstantWithMonoCecil> Constants
        {
            get { return new ClassConstantWithMonoCecil[0]; }
        }

        protected override IReadOnlyCollection<ClassFieldWithMonoCecil> Fields
        {
            get { return typeWithMonoCecil.FieldCollection.Fields; }
        }
    }
}
