using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class SourceCodeBuilderTests
    {
        [TestMethod]
        public void TestStructNestedClass()
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
                            NestedClasses = new CodeGenerationCollection<StructNestedClass>()
                            {
                                new StructNestedClass("TestStructNestedClass")
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    class TestStructNestedClass
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPublicStructNestedClass()
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
                            NestedClasses = new CodeGenerationCollection<StructNestedClass>()
                            {
                                new StructNestedClass("TestStructNestedClass")
                                {
                                    Visibility = StructMemberVisibilityModifier.Public
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    public class TestStructNestedClass
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInternalStructNestedClass()
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
                            NestedClasses = new CodeGenerationCollection<StructNestedClass>()
                            {
                                new StructNestedClass("TestStructNestedClass")
                                {
                                    Visibility = StructMemberVisibilityModifier.Internal
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    internal class TestStructNestedClass
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestPrivateStructNestedClass()
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
                            NestedClasses = new CodeGenerationCollection<StructNestedClass>()
                            {
                                new StructNestedClass("TestStructNestedClass")
                                {
                                    Visibility = StructMemberVisibilityModifier.Private
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    private class TestStructNestedClass
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedClassWithBaseClass()
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
                            NestedClasses = new CodeGenerationCollection<StructNestedClass>()
                            {
                                new StructNestedClass("TestStructNestedClass")
                                {
                                    BaseClass = new ClassReference("BaseClass")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    class TestStructNestedClass : BaseClass
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedClassWith1GenericParameter()
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
                            NestedClasses = new CodeGenerationCollection<StructNestedClass>()
                            {
                                new StructNestedClass("TestStructNestedClass")
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
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    class TestStructNestedClass<T>
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedClassWith2GenericParameters()
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
                            NestedClasses = new CodeGenerationCollection<StructNestedClass>()
                            {
                                new StructNestedClass("TestStructNestedClass")
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
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    class TestStructNestedClass<TKey, TValue>
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedClassWithClassGenericParameterConstraint()
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
                            NestedClasses = new CodeGenerationCollection<StructNestedClass>()
                            {
                                new StructNestedClass("TestStructNestedClass")
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
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    class TestStructNestedClass<T>
        where T : class
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedClassWithStructGenericParameterConstraint()
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
                            NestedClasses = new CodeGenerationCollection<StructNestedClass>()
                            {
                                new StructNestedClass("TestStructNestedClass")
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
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    class TestStructNestedClass<T>
        where T : struct
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedClassWithEmptyConstructorGenericParameterConstraint()
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
                            NestedClasses = new CodeGenerationCollection<StructNestedClass>()
                            {
                                new StructNestedClass("TestStructNestedClass")
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
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    class TestStructNestedClass<T>
        where T : new()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedClassWithBaseClassGenericParameterConstraint()
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
                            NestedClasses = new CodeGenerationCollection<StructNestedClass>()
                            {
                                new StructNestedClass("TestStructNestedClass")
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
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    class TestStructNestedClass<T>
        where T : BaseClass
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedClassWith1InterfaceGenericParameterConstraint()
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
                            NestedClasses = new CodeGenerationCollection<StructNestedClass>()
                            {
                                new StructNestedClass("TestStructNestedClass")
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
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    class TestStructNestedClass<T>
        where T : ITestInterface
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedClassWith2InterfaceGenericParameterConstraints()
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
                            NestedClasses = new CodeGenerationCollection<StructNestedClass>()
                            {
                                new StructNestedClass("TestStructNestedClass")
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
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    class TestStructNestedClass<T>
        where T : ITestInterface, ITestInterface2
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedClassWith1GenericTypeGenericParameterConstraint()
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
                            NestedClasses = new CodeGenerationCollection<StructNestedClass>()
                            {
                                new StructNestedClass("TestStructNestedClass")
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
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    class TestStructNestedClass<TParent, TChild>
        where TChild : TParent
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedClassWith2GenericTypeGenericParameterConstraint()
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
                            NestedClasses = new CodeGenerationCollection<StructNestedClass>()
                            {
                                new StructNestedClass("TestStructNestedClass")
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
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    class TestStructNestedClass<TGrandparent, TParent, TChild>
        where TChild : TGrandparent, TParent
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedClassWithClassAndInterfaceAndEmptyConstructorGenericParameterConstraints()
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
                            NestedClasses = new CodeGenerationCollection<StructNestedClass>()
                            {
                                new StructNestedClass("TestStructNestedClass")
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
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    class TestStructNestedClass<T>
        where T : class, ITestInterface, new()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedClassWith2GenericParameterConstraints()
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
                            NestedClasses = new CodeGenerationCollection<StructNestedClass>()
                            {
                                new StructNestedClass("TestStructNestedClass")
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
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    class TestStructNestedClass<TKey, TValue>
        where TKey : ITestInterface
        where TValue : TKey
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestAbstractStructNestedClass()
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
                            NestedClasses = new CodeGenerationCollection<StructNestedClass>()
                            {
                                new StructNestedClass("TestStructNestedClass")
                                {
                                    InheritanceModifier = TypeInheritanceModifier.Abstract
                                }
                            }
                       }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    abstract class TestStructNestedClass
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestSealedStructNestedClass()
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
                            NestedClasses = new CodeGenerationCollection<StructNestedClass>()
                            {
                                new StructNestedClass("TestStructNestedClass")
                                {
                                    InheritanceModifier = TypeInheritanceModifier.Sealed
                                }
                            }
                       }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    sealed class TestStructNestedClass
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStaticStructNestedClass()
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
                            NestedClasses = new CodeGenerationCollection<StructNestedClass>()
                            {
                                new StructNestedClass("TestStructNestedClass")
                                {
                                    InheritanceModifier = TypeInheritanceModifier.Static
                                }
                            }
                       }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    static class TestStructNestedClass
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedClassWithInterface()
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
                            NestedClasses = new CodeGenerationCollection<StructNestedClass>()
                            {
                                new StructNestedClass("TestStructNestedClass")
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
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    class TestStructNestedClass : ITestInterface
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedClassWith2Interfaces()
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
                            NestedClasses = new CodeGenerationCollection<StructNestedClass>()
                            {
                                new StructNestedClass("TestStructNestedClass")
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
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    class TestStructNestedClass : ITestInterface, ITestInterface2
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPartialStructNestedClass()
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
                            NestedClasses = new CodeGenerationCollection<StructNestedClass>()
                            {
                                new StructNestedClass("TestStructNestedClass")
                                {
                                    IsPartial = true
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    partial class TestStructNestedClass
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }
    }
}
