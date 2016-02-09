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
            ClassAccessorWithReflection>
    {
        private readonly IndexerWithReflection indexer;
        private readonly IInternalTypeWithReflection declaringType;
        private readonly ClassAccessorWithReflection getAccessor;
        private readonly ClassAccessorWithReflection setAccessor;

        internal ClassIndexerWithReflection(IInternalTypeWithReflection declaringType, PropertyInfo indexer)
        {
            this.indexer = new IndexerWithReflection(declaringType, indexer);
            this.declaringType = declaringType;
            if (this.indexer.GetAccessor != null)
            {
                getAccessor = new ClassAccessorWithReflection(this, this.indexer.GetAccessor);
            }

            if (this.indexer.SetAccessor != null)
            {
                setAccessor = new ClassAccessorWithReflection(this, this.indexer.SetAccessor);
            }
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return indexer.Attributes; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return indexer.DeclaringType; }
        }

        public override ClassAccessorWithReflection GetAccessor
        {
            get { return getAccessor; }
        }

        public override ITypeReferenceWithReflection IndexerType
        {
            get { return indexer.IndexerType; }
        }

        public override IndexerInheritanceModifier InheritanceModifier
        {
            get { return indexer.PropertyInfo.IndexerInheritanceModifier(declaringType); }
        }

        public override IReadOnlyList<ParameterWithReflection> Parameters
        {
            get { return indexer.Parameters; }
        }

        public override ClassAccessorWithReflection SetAccessor
        {
            get { return setAccessor; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return indexer.PropertyInfo.ClassVisibility(); }
        }
    }
}
