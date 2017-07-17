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
            ClassNestedStructWithCodeAnalysis,
            AbstractPartialClassNestedStructWithCodeAnalysis> structs;
        private readonly WrappedCollection<
            ClassNestedPartialStructWithCodeAnalysis,
            AbstractPartialClassNestedPartialStructWithCodeAnalysis> partialStructs;

        internal AbstractPartialClassNestedStructCollectionWithCodeAnalysis(
            ClassNestedStructCollectionWithCodeAnalysis structCollection)
        {
            structs = new WrappedCollection<ClassNestedStructWithCodeAnalysis, AbstractPartialClassNestedStructWithCodeAnalysis>(
                structCollection.Structs,
                parent => new AbstractPartialClassNestedStructWithCodeAnalysis(parent),
                child => child.InternalStruct,
                value => structCollection.Structs = value);
            partialStructs = new WrappedCollection<ClassNestedPartialStructWithCodeAnalysis, AbstractPartialClassNestedPartialStructWithCodeAnalysis>(
                structCollection.PartialStructs,
                parent => new AbstractPartialClassNestedPartialStructWithCodeAnalysis(parent),
                child => child.InternalStruct,
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
