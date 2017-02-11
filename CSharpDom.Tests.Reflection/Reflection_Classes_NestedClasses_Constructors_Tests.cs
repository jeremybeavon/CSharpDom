using CSharpDom.TestTarget.Classes.NestedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedClasses_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        public Reflection_Classes_NestedClasses_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestClassWithNestedClassWithConstructorWith1AttributeUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithConstructorWith1ParameterUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithConstructorWith2ParametersUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalConstructorUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateConstructorUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedConstructorUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalConstructorUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicConstructorUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithPublicConstructor));
        }
    }
}
