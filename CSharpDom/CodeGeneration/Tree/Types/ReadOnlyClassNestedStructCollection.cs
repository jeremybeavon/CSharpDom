using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using CSharpDom.Common.Partial;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyClassNestedStructCollection :
        AbstractClassNestedStructCollection<ReadOnlyClassNestedStruct, IPartialStruct>
    {
        private readonly IReadOnlyCollection<ReadOnlyClassNestedStruct> structs;

        public ReadOnlyClassNestedStructCollection(ClassBody classBody)
        {
            structs = classBody.NestedStructs.ToArray(@struct => new ReadOnlyClassNestedStruct(@struct));
        }

        public override IReadOnlyCollection<IPartialStruct> PartialStructs
        {
            get { return new IPartialStruct[0]; }
        }

        protected override IReadOnlyCollection<ReadOnlyClassNestedStruct> Structs
        {
            get { return structs; }
        }
    }
}
