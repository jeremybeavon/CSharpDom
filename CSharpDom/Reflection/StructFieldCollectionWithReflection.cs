using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class StructFieldCollectionWithReflection :
        AbstractStructFieldCollection<StructFieldWithReflection, IStructConstant>
    {
        private readonly StructTypeWithReflection typeWithReflection;

        internal StructFieldCollectionWithReflection(StructTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }

        public override IReadOnlyCollection<IStructConstant> Constants
        {
            get { return typeWithReflection.FieldCollection.Fields.ConstantsWithReflection; }
        }

        protected override IReadOnlyCollection<StructFieldWithReflection> Fields
        {
            get { return typeWithReflection.FieldCollection.Fields.FieldsWithReflection; }
        }
    }
}
