using CSharpDom.BaseClasses;
using System;
using System.Reflection;
using System.Collections.Generic;

namespace CSharpDom.Reflection
{
    public sealed class PropertyWithReflection : AbstractProperty<AttributeWithReflection, IBasicTypeWithReflection>
    {
        internal PropertyWithReflection(IBasicTypeWithReflection declaringType, PropertyInfo property)
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

        public override string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
