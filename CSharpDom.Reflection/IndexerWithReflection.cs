using CSharpDom.BaseClasses;
using System;
using System.Reflection;
using System.Collections.Generic;

namespace CSharpDom.Reflection
{
    public sealed class IndexerWithReflection :
        AbstractIndexer<AttributeWithReflection, IBasicTypeWithReflection, ParameterWithReflection>
    {
        internal IndexerWithReflection(IBasicTypeWithReflection declaringType, PropertyInfo indexer)
        {

        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IBasicTypeWithReflection DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override bool HasGet
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override bool HasSet
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyList<ParameterWithReflection> Parameters
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
