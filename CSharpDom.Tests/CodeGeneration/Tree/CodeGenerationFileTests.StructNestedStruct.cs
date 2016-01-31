using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class CodeGenerationFileTests
    {
        [TestMethod]
        public void TestStructNestedStruct()
        {
            const string expectedText = @"struct TestStruct
{
    struct TestStructNestedStruct
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new Collection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPublicStructNestedStruct()
        {
            const string expectedText = @"struct TestStruct
{
    public struct TestStructNestedStruct
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new Collection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
                                {
                                    Visibility = StructMemberVisibilityModifier.Public
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInternalStructNestedStruct()
        {
            const string expectedText = @"struct TestStruct
{
    internal struct TestStructNestedStruct
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new Collection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
                                {
                                    Visibility = StructMemberVisibilityModifier.Internal
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestPrivateStructNestedStruct()
        {
            const string expectedText = @"struct TestStruct
{
    private struct TestStructNestedStruct
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new Collection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
                                {
                                    Visibility = StructMemberVisibilityModifier.Private
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedStructWith1GenericParameter()
        {
            const string expectedText = @"struct TestStruct
{
    struct TestStructNestedStruct<T>
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new Collection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
                                {
                                    GenericParameters =
                                    {
                                        new GenericParameter("T")
                                    }
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedStructWith2GenericParameters()
        {
            const string expectedText = @"struct TestStruct
{
    struct TestStructNestedStruct<TKey, TValue>
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new Collection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
                                {
                                    GenericParameters =
                                    {
                                        new GenericParameter("TKey"),
                                        new GenericParameter("TValue")
                                    }
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedStructWithClassGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    struct TestStructNestedStruct<T>
        where T : class
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new Collection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
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
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedStructWithStructGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    struct TestStructNestedStruct<T>
        where T : struct
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new Collection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
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
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedStructWithEmptyConstructorGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    struct TestStructNestedStruct<T>
        where T : new()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new Collection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
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
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedStructWithBaseClassGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    struct TestStructNestedStruct<T>
        where T : BaseClass
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new Collection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
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
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedStructWith1InterfaceGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    struct TestStructNestedStruct<T>
        where T : ITestInterface
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new Collection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
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
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedStructWith2InterfaceGenericParameterConstraints()
        {
            const string expectedText = @"struct TestStruct
{
    struct TestStructNestedStruct<T>
        where T : ITestInterface, ITestInterface2
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new Collection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
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
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedStructWith1GenericTypeGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    struct TestStructNestedStruct<TParent, TChild>
        where TChild : TParent
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new Collection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
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
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedStructWith2GenericTypeGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    struct TestStructNestedStruct<TGrandparent, TParent, TChild>
        where TChild : TGrandparent, TParent
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new Collection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
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
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedStructWithStructAndInterfaceAndEmptyConstructorGenericParameterConstraints()
        {
            const string expectedText = @"struct TestStruct
{
    struct TestStructNestedStruct<T>
        where T : struct, ITestInterface, new()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new Collection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
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
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedStructWith2GenericParameterConstraints()
        {
            const string expectedText = @"struct TestStruct
{
    struct TestStructNestedStruct<TKey, TValue>
        where TKey : ITestInterface
        where TValue : TKey
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new Collection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
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
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestStructNestedStructWithInterface()
        {
            const string expectedText = @"struct TestStruct
{
    struct TestStructNestedStruct : ITestInterface
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new Collection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
                                {
                                    Interfaces =
                                    {
                                        new InterfaceReference("ITestInterface")
                                    }
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedStructWith2Interfaces()
        {
            const string expectedText = @"struct TestStruct
{
    struct TestStructNestedStruct : ITestInterface, ITestInterface2
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new Collection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
                                {
                                    Interfaces =
                                    {
                                        new InterfaceReference("ITestInterface"),
                                        new InterfaceReference("ITestInterface2")
                                    }
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPartialStructNestedStruct()
        {
            const string expectedText = @"struct TestStruct
{
    partial struct TestStructNestedStruct
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new Collection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
                                {
                                    IsPartial = true
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }
    }
}
