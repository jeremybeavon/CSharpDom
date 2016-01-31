using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class CodeGenerationFileTests
    {
        [TestMethod]
        public void TestStructNestedClass()
        {
            const string expectedText = @"struct TestStruct
{
    class TestStructNestedClass
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedClasses = new Collection<StructNestedClass>()
                            {
                                new StructNestedClass("TestStructNestedClass")
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPublicStructNestedClass()
        {
            const string expectedText = @"struct TestStruct
{
    public class TestStructNestedClass
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedClasses = new Collection<StructNestedClass>()
                            {
                                new StructNestedClass("TestStructNestedClass")
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
        public void TestInternalStructNestedClass()
        {
            const string expectedText = @"struct TestStruct
{
    internal class TestStructNestedClass
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedClasses = new Collection<StructNestedClass>()
                            {
                                new StructNestedClass("TestStructNestedClass")
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
        public void TestPrivateStructNestedClass()
        {
            const string expectedText = @"struct TestStruct
{
    private class TestStructNestedClass
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                       Body = new StructBody()
                       {
                            NestedClasses = new Collection<StructNestedClass>()
                            {
                                new StructNestedClass("TestStructNestedClass")
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
        public void TestStructNestedClassWithBaseClass()
        {
            const string expectedText = @"struct TestStruct
{
    class TestStructNestedClass : BaseClass
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                       Body = new StructBody()
                       {
                            NestedClasses = new Collection<StructNestedClass>()
                            {
                                new StructNestedClass("TestStructNestedClass")
                                {
                                    BaseClass = new ClassReference("BaseClass")
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedClassWith1GenericParameter()
        {
            const string expectedText = @"struct TestStruct
{
    class TestStructNestedClass<T>
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                       Body = new StructBody()
                       {
                            NestedClasses = new Collection<StructNestedClass>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedClassWith2GenericParameters()
        {
            const string expectedText = @"struct TestStruct
{
    class TestStructNestedClass<TKey, TValue>
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                       Body = new StructBody()
                       {
                            NestedClasses = new Collection<StructNestedClass>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedClassWithClassGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    class TestStructNestedClass<T>
        where T : class
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                       Body = new StructBody()
                       {
                            NestedClasses = new Collection<StructNestedClass>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedClassWithStructGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    class TestStructNestedClass<T>
        where T : struct
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                       Body = new StructBody()
                       {
                            NestedClasses = new Collection<StructNestedClass>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedClassWithEmptyConstructorGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    class TestStructNestedClass<T>
        where T : new()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                       Body = new StructBody()
                       {
                            NestedClasses = new Collection<StructNestedClass>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedClassWithBaseClassGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    class TestStructNestedClass<T>
        where T : BaseClass
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                       Body = new StructBody()
                       {
                            NestedClasses = new Collection<StructNestedClass>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedClassWith1InterfaceGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    class TestStructNestedClass<T>
        where T : ITestInterface
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                       Body = new StructBody()
                       {
                            NestedClasses = new Collection<StructNestedClass>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedClassWith2InterfaceGenericParameterConstraints()
        {
            const string expectedText = @"struct TestStruct
{
    class TestStructNestedClass<T>
        where T : ITestInterface, ITestInterface2
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                       Body = new StructBody()
                       {
                            NestedClasses = new Collection<StructNestedClass>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedClassWith1GenericTypeGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    class TestStructNestedClass<TParent, TChild>
        where TChild : TParent
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                       Body = new StructBody()
                       {
                            NestedClasses = new Collection<StructNestedClass>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedClassWith2GenericTypeGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    class TestStructNestedClass<TGrandparent, TParent, TChild>
        where TChild : TGrandparent, TParent
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                       Body = new StructBody()
                       {
                            NestedClasses = new Collection<StructNestedClass>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedClassWithClassAndInterfaceAndEmptyConstructorGenericParameterConstraints()
        {
            const string expectedText = @"struct TestStruct
{
    class TestStructNestedClass<T>
        where T : class, ITestInterface, new()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                       Body = new StructBody()
                       {
                            NestedClasses = new Collection<StructNestedClass>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedClassWith2GenericParameterConstraints()
        {
            const string expectedText = @"struct TestStruct
{
    class TestStructNestedClass<TKey, TValue>
        where TKey : ITestInterface
        where TValue : TKey
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                       Body = new StructBody()
                       {
                            NestedClasses = new Collection<StructNestedClass>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestAbstractStructNestedClass()
        {
            const string expectedText = @"struct TestStruct
{
    abstract class TestStructNestedClass
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                       Body = new StructBody()
                       {
                            NestedClasses = new Collection<StructNestedClass>()
                            {
                                new StructNestedClass("TestStructNestedClass")
                                {
                                    InheritanceModifier = TypeInheritanceModifier.Abstract
                                }
                            }
                       }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestSealedStructNestedClass()
        {
            const string expectedText = @"struct TestStruct
{
    sealed class TestStructNestedClass
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                       Body = new StructBody()
                       {
                            NestedClasses = new Collection<StructNestedClass>()
                            {
                                new StructNestedClass("TestStructNestedClass")
                                {
                                    InheritanceModifier = TypeInheritanceModifier.Sealed
                                }
                            }
                       }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStaticStructNestedClass()
        {
            const string expectedText = @"struct TestStruct
{
    static class TestStructNestedClass
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                       Body = new StructBody()
                       {
                            NestedClasses = new Collection<StructNestedClass>()
                            {
                                new StructNestedClass("TestStructNestedClass")
                                {
                                    InheritanceModifier = TypeInheritanceModifier.Static
                                }
                            }
                       }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedClassWithInterface()
        {
            const string expectedText = @"struct TestStruct
{
    class TestStructNestedClass : ITestInterface
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                       Body = new StructBody()
                       {
                            NestedClasses = new Collection<StructNestedClass>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedClassWith2Interfaces()
        {
            const string expectedText = @"struct TestStruct
{
    class TestStructNestedClass : ITestInterface, ITestInterface2
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                       Body = new StructBody()
                       {
                            NestedClasses = new Collection<StructNestedClass>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPartialStructNestedClass()
        {
            const string expectedText = @"struct TestStruct
{
    partial class TestStructNestedClass
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedClasses = new Collection<StructNestedClass>()
                            {
                                new StructNestedClass("TestStructNestedClass")
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
