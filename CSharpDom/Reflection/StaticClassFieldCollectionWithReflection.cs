using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class StaticClassFieldCollectionWithReflection :
        AbstractStaticClassFieldCollection<StaticClassFieldWithReflection, StaticClassConstantWithReflection>
    {
        private readonly StaticTypeWithReflection typeWithReflection;

        internal StaticClassFieldCollectionWithReflection(StaticTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }
        
        public override IReadOnlyCollection<StaticClassConstantWithReflection> Constants
        {
            get { return typeWithReflection.FieldCollection.Fields.ConstantsWithReflection; }
        }

        protected override IReadOnlyCollection<StaticClassFieldWithReflection> Fields
        {
            get { return typeWithReflection.FieldCollection.Fields.FieldsWithReflection; }
        }
    }
}
