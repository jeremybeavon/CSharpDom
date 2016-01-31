using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class CodeGenerationFileTests
    {
        [TestMethod]
        public void TestStruct()
        {
            const string expectedText = @"struct TestStruct
{
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPublicStruct()
        {
            const string expectedText = @"public struct TestStruct
{
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Visibility = TypeVisibilityModifier.Public
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInternalStruct()
        {
            const string expectedText = @"internal struct TestStruct
{
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Visibility = TypeVisibilityModifier.Internal
                    }
                }
            }).ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestStructWith1GenericParameter()
        {
            const string expectedText = @"struct TestStruct<T>
{
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWith2GenericParameters()
        {
            const string expectedText = @"struct TestStruct<TKey, TValue>
{
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("TKey"),
                            new GenericParameter("TValue")
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithClassGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct<T>
    where T : class
{
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                            {
                                TypeConstraint = GenericParameterTypeConstraint.Class
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithStructGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct<T>
    where T : struct
{
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                            {
                                TypeConstraint = GenericParameterTypeConstraint.Struct
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithEmptyConstructorGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct<T>
    where T : new()
{
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                            {
                                HasEmptyConstructorConstraint = true
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithBaseClassGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct<T>
    where T : BaseClass
{
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                            {
                                BaseClassConstraint = new ClassReference("BaseClass")
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWith1InterfaceGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct<T>
    where T : ITestInterface
{
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                            {
                                InterfaceConstraints =
                                {
                                    new InterfaceReference("ITestInterface")
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWith2InterfaceGenericParameterConstraints()
        {
            const string expectedText = @"struct TestStruct<T>
    where T : ITestInterface, ITestInterface2
{
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                            {
                                InterfaceConstraints =
                                {
                                    new InterfaceReference("ITestInterface"),
                                    new InterfaceReference("ITestInterface2")
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWith1GenericTypeGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct<TParent, TChild>
    where TChild : TParent
{
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("TParent"),
                            new GenericParameter("TChild")
                            {
                                GenericParameterConstraints =
                                {
                                    new GenericParameterReference("TParent")
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWith2GenericTypeGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct<TGrandparent, TParent, TChild>
    where TChild : TGrandparent, TParent
{
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("TGrandparent"),
                            new GenericParameter("TParent"),
                            new GenericParameter("TChild")
                            {
                                GenericParameterConstraints =
                                {
                                    new GenericParameterReference("TGrandparent"),
                                    new GenericParameterReference("TParent")
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithStructAndInterfaceAndEmptyConstructorGenericParameterConstraints()
        {
            const string expectedText = @"struct TestStruct<T>
    where T : struct, ITestInterface, new()
{
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                            {
                                TypeConstraint = GenericParameterTypeConstraint.Struct,
                                InterfaceConstraints =
                                {
                                    new InterfaceReference("ITestInterface")
                                },
                                HasEmptyConstructorConstraint = true
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWith2GenericParameterConstraints()
        {
            const string expectedText = @"struct TestStruct<TKey, TValue>
    where TKey : ITestInterface
    where TValue : TKey
{
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("TKey")
                            {
                                InterfaceConstraints =
                                {
                                    new InterfaceReference("ITestInterface")
                                }
                            },
                            new GenericParameter("TValue")
                            {
                                GenericParameterConstraints =
                                {
                                    new GenericParameterReference("TKey")
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestStructWithInterface()
        {
            const string expectedText = @"struct TestStruct : ITestInterface
{
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Interfaces =
                        {
                            new InterfaceReference("ITestInterface")
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWith2Interfaces()
        {
            const string expectedText = @"struct TestStruct : ITestInterface, ITestInterface2
{
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Interfaces =
                        {
                            new InterfaceReference("ITestInterface"),
                            new InterfaceReference("ITestInterface2")
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPartialStruct()
        {
            const string expectedText = @"partial struct TestStruct
{
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        IsPartial = true
                    }
                }
            }).ToString().Should().Be(expectedText);
        }
    }
}
