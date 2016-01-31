using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class CodeGenerationFileTests
    {
        [TestMethod]
        public void TestStructWithProperty()
        {
            const string expectedText = @"struct TestStruct
{
    string Property1 { get; set; }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Properties = new Collection<StructProperty>()
                            {
                                new StructProperty("Property1")
                                {
                                    Type = new TypeReference("string")
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWith2Properties()
        {
            const string expectedText = @"struct TestStruct
{
    string Property1 { get; set; }

    string Property2 { get; set; }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Properties = new Collection<StructProperty>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithPublicProperty()
        {
            const string expectedText = @"struct TestStruct
{
    public string Property1 { get; set; }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Properties = new Collection<StructProperty>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithInternalProperty()
        {
            const string expectedText = @"struct TestStruct
{
    internal string Property1 { get; set; }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Properties = new Collection<StructProperty>()
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
            }).ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestStructWithPrivateProperty()
        {
            const string expectedText = @"struct TestStruct
{
    private string Property1 { get; set; }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Properties = new Collection<StructProperty>()
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
            }).ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestStructWithPublicStaticProperty()
        {
            const string expectedText = @"struct TestStruct
{
    public static string Property1 { get; set; }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Properties = new Collection<StructProperty>()
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
            }).ToString().Should().Be(expectedText);
        }
    }
}
