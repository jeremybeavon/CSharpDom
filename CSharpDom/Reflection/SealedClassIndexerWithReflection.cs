using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class SealedClassIndexerWithReflection :
        AbstractSealedClassIndexer<
            AttributeWithReflection,
            ITypeWithReflection,
            ITypeReferenceWithReflection,
            IndexerParameterWithReflection,
            ClassAccessorWithReflection>
    {
        private readonly IndexerWithReflection indexer;

        internal SealedClassIndexerWithReflection(ITypeWithReflection declaringType, PropertyInfo indexer)
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

        public override ClassAccessorWithReflection GetAccessor
        {
            get { throw new NotImplementedException(); }
            //get { return indexer.GetAccessor; }
        }

        public override ITypeReferenceWithReflection IndexerType
        {
            get { return indexer.IndexerType; }
        }

        public override SealedClassMemberInheritanceModifier InheritanceModifier
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /*public override IndexerInheritanceModifier InheritanceModifier
        {
            get { throw new NotImplementedException(); }
            //get { return indexer.PropertyInfo.InheritanceModifier(); }
        }*/

        public override IReadOnlyList<IndexerParameterWithReflection> Parameters
        {
            get { return indexer.Parameters; }
        }

        public override ClassAccessorWithReflection SetAccessor
        {
            get { throw new NotImplementedException(); }
            //get { return indexer.SetAccessor; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { throw new NotImplementedException(); }
            //get { return indexer.PropertyInfo.SealedClassVisibility(); }
        }
    }
}
