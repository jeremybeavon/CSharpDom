using CSharpDom.Editable;
using CSharpDom.CodeAnalysis.Partial;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class AbstractPartialClassNestedStructCollectionWithCodeAnalysis :
        EditableClassNestedStructCollection<
            AbstractPartialClassNestedStructWithCodeAnalysis,
            AbstractPartialClassNestedPartialStructWithCodeAnalysis>
    {
        private readonly WrappedCollection<
            AbstractClassNestedStructWithCodeAnalysis,
            AbstractPartialClassNestedStructWithCodeAnalysis> structs;
        private readonly WrappedCollection<
            AbstractClassNestedPartialStructWithCodeAnalysis,
            AbstractPartialClassNestedPartialStructWithCodeAnalysis> partialStructs;

        internal AbstractPartialClassNestedStructCollectionWithCodeAnalysis(
            AbstractClassNestedStructCollectionWithCodeAnalysis structCollection)
        {
            structs = new WrappedCollection<AbstractClassNestedStructWithCodeAnalysis, AbstractPartialClassNestedStructWithCodeAnalysis>(
                structCollection.Structs,
                parent => new AbstractPartialClassNestedStructWithCodeAnalysis(parent),
                child => child.Struct,
                value => structCollection.Structs = value);
            partialStructs = new WrappedCollection<AbstractClassNestedPartialStructWithCodeAnalysis, AbstractPartialClassNestedPartialStructWithCodeAnalysis>(
                structCollection.PartialStructs,
                parent => new AbstractPartialClassNestedPartialStructWithCodeAnalysis(parent),
                child => child.Struct,
                value => structCollection.PartialStructs = value);
        }

        public override ICollection<AbstractPartialClassNestedPartialStructWithCodeAnalysis> PartialStructs
        {
            get { return partialStructs; }
            set { partialStructs.Replace(value); }
        }

        public override ICollection<AbstractPartialClassNestedStructWithCodeAnalysis> Structs
        {
            get { return structs; }
            set { structs.Replace(value); }
        }
    }
}
