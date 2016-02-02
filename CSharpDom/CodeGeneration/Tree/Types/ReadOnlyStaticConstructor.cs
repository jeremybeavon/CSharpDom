using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStaticConstructor :
        AbstractStaticConstructor<AttributeGroupNotSupported, IType, ReadOnlyMethodBody>
    {
        private readonly ReadOnlyMethodBody body;

        public ReadOnlyStaticConstructor(StaticConstructor staticConstructor)
        {
            body = new ReadOnlyMethodBody(staticConstructor.Body);
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override ReadOnlyMethodBody Body
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IType DeclaringType
        {
            get { return null; }
        }
    }
}
