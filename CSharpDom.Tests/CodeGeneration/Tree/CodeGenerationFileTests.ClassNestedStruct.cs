using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class CodeGenerationFileTests
    {
        [TestMethod]
        public void TestClassNestedStruct()
        {
            const string expectedText = @"class TestClass
{
    struct TestClassNestedStruct
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new Collection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPublicClassNestedStruct()
        {
            const string expectedText = @"class TestClass
{
    public struct TestClassNestedStruct
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new Collection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInternalClassNestedStruct()
        {
            const string expectedText = @"class TestClass
{
    internal struct TestClassNestedStruct
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new Collection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Internal
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestProtectedInternalClassNestedStruct()
        {
            const string expectedText = @"class TestClass
{
    protected internal struct TestClassNestedStruct
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new Collection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
                                {
                                    Visibility = ClassMemberVisibilityModifier.ProtectedInternal
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestProtectedClassNestedStruct()
        {
            const string expectedText = @"class TestClass
{
    protected struct TestClassNestedStruct
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new Collection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Protected
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPrivateClassNestedStruct()
        {
            const string expectedText = @"class TestClass
{
    private struct TestClassNestedStruct
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new Collection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Private
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedStructWith1GenericParameter()
        {
            const string expectedText = @"class TestClass
{
    struct TestClassNestedStruct<T>
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new Collection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
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
        public void TestClassNestedStructWith2GenericParameters()
        {
            const string expectedText = @"class TestClass
{
    struct TestClassNestedStruct<TKey, TValue>
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new Collection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
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
        public void TestClassNestedStructWithClassGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    struct TestClassNestedStruct<T>
        where T : class
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new Collection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
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
        public void TestClassNestedStructWithStructGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    struct TestClassNestedStruct<T>
        where T : struct
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new Collection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
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
        public void TestClassNestedStructWithEmptyConstructorGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    struct TestClassNestedStruct<T>
        where T : new()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new Collection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
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
        public void TestClassNestedStructWithBaseClassGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    struct TestClassNestedStruct<T>
        where T : BaseClass
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new Collection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
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
        public void TestClassNestedStructWith1InterfaceGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    struct TestClassNestedStruct<T>
        where T : ITestInterface
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new Collection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
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
        public void TestClassNestedStructWith2InterfaceGenericParameterConstraints()
        {
            const string expectedText = @"class TestClass
{
    struct TestClassNestedStruct<T>
        where T : ITestInterface, ITestInterface2
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new Collection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
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
        public void TestClassNestedStructWith1GenericTypeGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    struct TestClassNestedStruct<TParent, TChild>
        where TChild : TParent
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new Collection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
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
        public void TestClassNestedStructWith2GenericTypeGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    struct TestClassNestedStruct<TGrandparent, TParent, TChild>
        where TChild : TGrandparent, TParent
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new Collection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
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
        public void TestClassNestedStructWithClassAndInterfaceAndEmptyConstructorGenericParameterConstraints()
        {
            const string expectedText = @"class TestClass
{
    struct TestClassNestedStruct<T>
        where T : class, ITestInterface, new()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new Collection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
                                {
                                    GenericParameters =
                                    {
                                        new GenericParameter("T")
                                        {
                                            TypeConstraint = GenericParameterTypeConstraint.Class,
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
        public void TestClassNestedStructWith2GenericParameterConstraints()
        {
            const string expectedText = @"class TestClass
{
    struct TestClassNestedStruct<TKey, TValue>
        where TKey : ITestInterface
        where TValue : TKey
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new Collection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
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
        public void TestClassNestedStructWithInterface()
        {
            const string expectedText = @"class TestClass
{
    struct TestClassNestedStruct : ITestInterface
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new Collection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
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
        public void TestClassNestedStructWith2Interfaces()
        {
            const string expectedText = @"class TestClass
{
    struct TestClassNestedStruct : ITestInterface, ITestInterface2
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new Collection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
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
        public void TestPartialClassNestedStruct()
        {
            const string expectedText = @"class TestClass
{
    partial struct TestClassNestedStruct
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedStructs = new Collection<ClassNestedStruct>()
                            {
                                new ClassNestedStruct("TestClassNestedStruct")
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
