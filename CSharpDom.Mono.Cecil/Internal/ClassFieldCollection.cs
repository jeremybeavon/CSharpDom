using System;
using System.Collections.Generic;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class ClassFieldCollection : AbstractClassFieldCollection
    {
        private readonly ClassTypeWithMonoCecil typeWithMonoCecil;

        public ClassFieldCollection(ClassTypeWithMonoCecil typeWithMonoCecil)
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
