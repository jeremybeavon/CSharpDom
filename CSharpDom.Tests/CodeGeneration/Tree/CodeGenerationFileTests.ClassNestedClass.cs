using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class CodeGenerationFileTests
    {
        [TestMethod]
        public void TestClassNestedClass()
        {
            const string expectedText = @"class TestClass
{
    class TestClassNestedClass
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedClasses = new Collection<ClassNestedClass>()
                            {
                                new ClassNestedClass("TestClassNestedClass")
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPublicClassNestedClass()
        {
            const string expectedText = @"class TestClass
{
    public class TestClassNestedClass
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedClasses = new Collection<ClassNestedClass>()
                            {
                                new ClassNestedClass("TestClassNestedClass")
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
        public void TestInternalClassNestedClass()
        {
            const string expectedText = @"class TestClass
{
    internal class TestClassNestedClass
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedClasses = new Collection<ClassNestedClass>()
                            {
                                new ClassNestedClass("TestClassNestedClass")
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
        public void TestProtectedInternalClassNestedClass()
        {
            const string expectedText = @"class TestClass
{
    protected internal class TestClassNestedClass
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedClasses = new Collection<ClassNestedClass>()
                            {
                                new ClassNestedClass("TestClassNestedClass")
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
        public void TestPrivateClassNestedClass()
        {
            const string expectedText = @"class TestClass
{
    private class TestClassNestedClass
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                       Body = new ClassBody()
                       {
                            NestedClasses = new Collection<ClassNestedClass>()
                            {
                                new ClassNestedClass("TestClassNestedClass")
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
        public void TestClassNestedClassWithBaseClass()
        {
            const string expectedText = @"class TestClass
{
    class TestClassNestedClass : BaseClass
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                       Body = new ClassBody()
                       {
                            NestedClasses = new Collection<ClassNestedClass>()
                            {
                                new ClassNestedClass("TestClassNestedClass")
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
        public void TestClassNestedClassWith1GenericParameter()
        {
            const string expectedText = @"class TestClass
{
    class TestClassNestedClass<T>
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                       Body = new ClassBody()
                       {
                            NestedClasses = new Collection<ClassNestedClass>()
                            {
                                new ClassNestedClass("TestClassNestedClass")
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
        public void TestClassNestedClassWith2GenericParameters()
        {
            const string expectedText = @"class TestClass
{
    class TestClassNestedClass<TKey, TValue>
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                       Body = new ClassBody()
                       {
                            NestedClasses = new Collection<ClassNestedClass>()
                            {
                                new ClassNestedClass("TestClassNestedClass")
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
        public void TestClassNestedClassWithClassGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    class TestClassNestedClass<T>
        where T : class
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                       Body = new ClassBody()
                       {
                            NestedClasses = new Collection<ClassNestedClass>()
                            {
                                new ClassNestedClass("TestClassNestedClass")
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
        public void TestClassNestedClassWithStructGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    class TestClassNestedClass<T>
        where T : struct
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                       Body = new ClassBody()
                       {
                            NestedClasses = new Collection<ClassNestedClass>()
                            {
                                new ClassNestedClass("TestClassNestedClass")
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
        public void TestClassNestedClassWithEmptyConstructorGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    class TestClassNestedClass<T>
        where T : new()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                       Body = new ClassBody()
                       {
                            NestedClasses = new Collection<ClassNestedClass>()
                            {
                                new ClassNestedClass("TestClassNestedClass")
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
        public void TestClassNestedClassWithBaseClassGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    class TestClassNestedClass<T>
        where T : BaseClass
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                       Body = new ClassBody()
                       {
                            NestedClasses = new Collection<ClassNestedClass>()
                            {
                                new ClassNestedClass("TestClassNestedClass")
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
        public void TestClassNestedClassWith1InterfaceGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    class TestClassNestedClass<T>
        where T : ITestInterface
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                       Body = new ClassBody()
                       {
                            NestedClasses = new Collection<ClassNestedClass>()
                            {
                                new ClassNestedClass("TestClassNestedClass")
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
        public void TestClassNestedClassWith2InterfaceGenericParameterConstraints()
        {
            const string expectedText = @"class TestClass
{
    class TestClassNestedClass<T>
        where T : ITestInterface, ITestInterface2
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                       Body = new ClassBody()
                       {
                            NestedClasses = new Collection<ClassNestedClass>()
                            {
                                new ClassNestedClass("TestClassNestedClass")
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
        public void TestClassNestedClassWith1GenericTypeGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    class TestClassNestedClass<TParent, TChild>
        where TChild : TParent
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                       Body = new ClassBody()
                       {
                            NestedClasses = new Collection<ClassNestedClass>()
                            {
                                new ClassNestedClass("TestClassNestedClass")
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
        public void TestClassNestedClassWith2GenericTypeGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    class TestClassNestedClass<TGrandparent, TParent, TChild>
        where TChild : TGrandparent, TParent
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                       Body = new ClassBody()
                       {
                            NestedClasses = new Collection<ClassNestedClass>()
                            {
                                new ClassNestedClass("TestClassNestedClass")
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
        public void TestClassNestedClassWithClassAndInterfaceAndEmptyConstructorGenericParameterConstraints()
        {
            const string expectedText = @"class TestClass
{
    class TestClassNestedClass<T>
        where T : class, ITestInterface, new()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                       Body = new ClassBody()
                       {
                            NestedClasses = new Collection<ClassNestedClass>()
                            {
                                new ClassNestedClass("TestClassNestedClass")
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
        public void TestClassNestedClassWith2GenericParameterConstraints()
        {
            const string expectedText = @"class TestClass
{
    class TestClassNestedClass<TKey, TValue>
        where TKey : ITestInterface
        where TValue : TKey
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                       Body = new ClassBody()
                       {
                            NestedClasses = new Collection<ClassNestedClass>()
                            {
                                new ClassNestedClass("TestClassNestedClass")
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

        /*[TestMethod]
        public void TestAbstractClassNestedClass()
        {
            const string expectedText = @"class TestClass
{
    abstract class TestClassNestedClass
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                       Body = new ClassBody()
                       {
                            NestedClasses = new Collection<ClassNestedClass>()
                            {
                                new ClassNestedClass("TestClassNestedClass")
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
        public void TestSealedClassNestedClass()
        {
            const string expectedText = @"class TestClass
{
    sealed class TestClassNestedClass
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                       Body = new ClassBody()
                       {
                            NestedClasses = new Collection<ClassNestedClass>()
                            {
                                new ClassNestedClass("TestClassNestedClass")
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
        public void TestStaticClassNestedClass()
        {
            const string expectedText = @"class TestClass
{
    static class TestClassNestedClass
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                       Body = new ClassBody()
                       {
                            NestedClasses = new Collection<ClassNestedClass>()
                            {
                                new ClassNestedClass("TestClassNestedClass")
                                {
                                    InheritanceModifier = TypeInheritanceModifier.Static
                                }
                            }
                       }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }*/

        [TestMethod]
        public void TestClassNestedClassWithInterface()
        {
            const string expectedText = @"class TestClass
{
    class TestClassNestedClass : ITestInterface
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                       Body = new ClassBody()
                       {
                            NestedClasses = new Collection<ClassNestedClass>()
                            {
                                new ClassNestedClass("TestClassNestedClass")
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
        public void TestClassNestedClassWith2Interfaces()
        {
            const string expectedText = @"class TestClass
{
    class TestClassNestedClass : ITestInterface, ITestInterface2
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                       Body = new ClassBody()
                       {
                            NestedClasses = new Collection<ClassNestedClass>()
                            {
                                new ClassNestedClass("TestClassNestedClass")
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

        /*[TestMethod]
        public void TestPartialClassNestedClass()
        {
            const string expectedText = @"class TestClass
{
    partial class TestClassNestedClass
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedClasses = new Collection<ClassNestedClass>()
                            {
                                new ClassNestedClass("TestClassNestedClass")
                                {
                                    IsPartial = true
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }*/
    }
}
