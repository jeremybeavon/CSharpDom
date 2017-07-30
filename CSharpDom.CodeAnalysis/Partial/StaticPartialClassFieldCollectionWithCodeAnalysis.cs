using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class StaticPartialClassFieldCollectionWithCodeAnalysis :
        EditableStaticClassFieldCollection<StaticPartialClassFieldWithCodeAnalysis, StaticPartialClassConstantWithCodeAnalysis>
    {
        private readonly WrappedCollection<
            StaticClassConstantWithCodeAnalysis,
            StaticPartialClassConstantWithCodeAnalysis> constants;
        private readonly WrappedCollection<
            StaticClassFieldWithCodeAnalysis,
            StaticPartialClassFieldWithCodeAnalysis> fields;

        internal StaticPartialClassFieldCollectionWithCodeAnalysis(
            StaticClassFieldCollectionWithCodeAnalysis fieldCollection)
        {
            constants = new WrappedCollection<StaticClassConstantWithCodeAnalysis, StaticPartialClassConstantWithCodeAnalysis>(
                fieldCollection.Constants,
                parent => new StaticPartialClassConstantWithCodeAnalysis(parent),
                child => child.Constant,
                value => fieldCollection.Constants = value);
            fields = new WrappedCollection<StaticClassFieldWithCodeAnalysis, StaticPartialClassFieldWithCodeAnalysis>(
                fieldCollection.Fields,
                parent => new StaticPartialClassFieldWithCodeAnalysis(parent),
                child => child.Field,
                value => fieldCollection.Fields = value);
        }

        public override ICollection<StaticPartialClassConstantWithCodeAnalysis> Constants
        {
            get { return constants; }
            set { constants.Replace(value); }
        }

        public override ICollection<StaticPartialClassFieldWithCodeAnalysis> Fields
        {
            get { return fields; }
            set { fields.Replace(value); }
        }
    }
}
