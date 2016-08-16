using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.Internal.Hiding
{
    internal sealed class AccessorSignature : AbstractAccessor<AttributeGroupNotSupported, EmptyMethodBody>
    {
        public static readonly AccessorSignature Default = new AccessorSignature();

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override EmptyMethodBody Body
        {
            get { return EmptyMethodBody.Default; }
        }
    }
}
