using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class ClassIndexerWithReflection :
        AbstractClassIndexer<
            AttributeWithReflection,
            ITypeWithReflection,
            ITypeReferenceWithReflection,
            ParameterWithReflection,
            AccessorWithReflection>
    {
        private readonly IndexerWithReflection indexer;

        internal ClassIndexerWithReflection(ITypeWithReflection declaringType, PropertyInfo indexer)
        {
            this.indexer = new IndexerWithReflection(declaringType, indexer);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return indexer.Attributes; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return indexer.DeclaringType; }
        }

        public override AccessorWithReflection GetAccessor
        {
            get { return indexer.GetAccessor; }
        }

        public override ITypeReferenceWithReflection IndexerType
        {
            get { return indexer.IndexerType; }
        }

        public override ClassMemberInheritanceModifier InheritanceModifier
        {
            get { return indexer.PropertyInfo.InheritanceModifier(); }
        }

        public override IReadOnlyList<ParameterWithReflection> Parameters
        {
            get { return indexer.Parameters; }
        }

        public override AccessorWithReflection SetAccessor
        {
            get { return indexer.SetAccessor; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return indexer.PropertyInfo.ClassVisibility(); }
        }
    }
}
