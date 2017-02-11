using CSharpDom.TestTarget.Classes.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        public Reflection_Classes_Constructors_Tests()
        {
            IsConstructorTest = true;
        }

        [TestMethod]
        public void TestClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestClass(typeof(ClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithConstructorWith1AttributeUsingReflection()
        {
            TestClass(typeof(ClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestClass(typeof(ClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithConstructorWith2ParametersUsingReflection()
        {
            TestClass(typeof(ClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithConstructorWith1ParameterUsingReflection()
        {
            TestClass(typeof(ClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestClassWithPublicConstructorUsingReflection()
        {
            TestClass(typeof(ClassWithPublicConstructor));
        }

        [TestMethod]
        public void TestClassWithProtectedConstructorUsingReflection()
        {
            TestClass(typeof(ClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalConstructorUsingReflection()
        {
            TestClass(typeof(ClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithPrivateConstructorUsingReflection()
        {
            TestClass(typeof(ClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestClassWithInternalConstructorUsingReflection()
        {
            TestClass(typeof(ClassWithInternalConstructor));
        }
    }
}
