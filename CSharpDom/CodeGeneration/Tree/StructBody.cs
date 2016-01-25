using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StructBody
    {
        public StructBody()
        {
            Fields = new Collection<StructFieldDeclaration>();
            Events = new Collection<StructEvent>();
            Properties = new Collection<StructProperty>();
            Indexers = new Collection<StructIndexer>();
            Methods = new Collection<StructMethod>();
            UnaryOperators = new Collection<UnaryOperator>();
            BinaryOperators = new Collection<BinaryOperator>();
            ConversionOperators = new Collection<ConversionOperator>();
            NestedClasses = new Collection<StructNestedClass>();
            NestedDelegates = new Collection<StructNestedDelegate>();
            NestedEnums = new Collection<StructNestedEnum>();
            NestedInterfaces = new Collection<StructNestedInterface>();
            NestedStructs = new Collection<StructNestedStruct>();
        }

        public Collection<StructFieldDeclaration> Fields { get; set; }

        public Collection<StructEvent> Events { get; set; }

        public Collection<StructProperty> Properties { get; set; }

        public Collection<StructIndexer> Indexers { get; set; }

        public Collection<StructMethod> Methods { get; set; }

        public Collection<UnaryOperator> UnaryOperators { get; set; }

        public Collection<BinaryOperator> BinaryOperators { get; set; }

        public Collection<ConversionOperator> ConversionOperators { get; set; }

        public Collection<StructNestedClass> NestedClasses { get; set; }

        public Collection<StructNestedDelegate> NestedDelegates { get; set; }

        public Collection<StructNestedEnum> NestedEnums { get; set; }

        public Collection<StructNestedInterface> NestedInterfaces { get; set; }

        public Collection<StructNestedStruct> NestedStructs { get; set; }
    }
}
