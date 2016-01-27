using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class SourceCodeBuilderTests
    {
        [TestMethod]
        public void TestStructWithProperty()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Properties = new CodeGenerationCollection<StructProperty>()
                            {
                                new StructProperty("Property1")
                                {
                                    Type = new TypeReference("string")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    string Property1 { get; set; }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWith2Properties()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Properties = new CodeGenerationCollection<StructProperty>()
                            {
                                new StructProperty("Property1")
                                {
                                    Type = new TypeReference("string")
                                },
                                new StructProperty("Property2")
                                {
                                    Type = new TypeReference("string")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    string Property1 { get; set; }

    string Property2 { get; set; }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithPublicProperty()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Properties = new CodeGenerationCollection<StructProperty>()
                            {
                                new StructProperty("Property1")
                                {
                                    Visibility = StructMemberVisibilityModifier.Public,
                                    Type = new TypeReference("string")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    public string Property1 { get; set; }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithInternalProperty()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Properties = new CodeGenerationCollection<StructProperty>()
                            {
                                new StructProperty("Property1")
                                {
                                    Visibility = StructMemberVisibilityModifier.Internal,
                                    Type = new TypeReference("string")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    internal string Property1 { get; set; }
}";
            builder.ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestStructWithPrivateProperty()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Properties = new CodeGenerationCollection<StructProperty>()
                            {
                                new StructProperty("Property1")
                                {
                                    Visibility = StructMemberVisibilityModifier.Private,
                                    Type = new TypeReference("string")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    private string Property1 { get; set; }
}";
            builder.ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestStructWithPublicStaticProperty()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Properties = new CodeGenerationCollection<StructProperty>()
                            {
                                new StructProperty("Property1")
                                {
                                    Visibility = StructMemberVisibilityModifier.Public,
                                    IsStatic = true,
                                    Type = new TypeReference("string")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    public static string Property1 { get; set; }
}";
            builder.ToString().Should().Be(expectedText);
        }
    }
}
