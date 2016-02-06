using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StaticClassBody
    {
        public StaticClassBody()
        {
            Fields = new Collection<StaticClassField>();
            Events = new Collection<StaticClassEvent>();
            Properties = new Collection<StaticClassProperty>();
            Methods = new Collection<StaticClassMethod>();
            NestedClasses = new Collection<StaticClassNestedClass>();
            NestedDelegates = new Collection<StaticClassNestedDelegate>();
            NestedEnums = new Collection<StaticClassNestedEnum>();
            NestedInterfaces = new Collection<StaticClassNestedInterface>();
            NestedStructs = new Collection<StaticClassNestedStruct>();
        }

        public Collection<StaticClassField> Fields { get; set; }

        public Collection<StaticClassEvent> Events { get; set; }

        public Collection<StaticClassProperty> Properties { get; set; }
        
        public Collection<StaticClassMethod> Methods { get; set; }
        
        public Collection<StaticClassNestedClass> NestedClasses { get; set; }

        public Collection<StaticClassNestedDelegate> NestedDelegates { get; set; }

        public Collection<StaticClassNestedEnum> NestedEnums { get; set; }

        public Collection<StaticClassNestedInterface> NestedInterfaces { get; set; }

        public Collection<StaticClassNestedStruct> NestedStructs { get; set; }

        public StaticConstructor StaticConstructor { get; set; }
    }
}
