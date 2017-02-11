using CSharpDom.TestTarget.Classes.NestedSealedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedSealedClasses_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        public Reflection_Classes_NestedSealedClasses_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithConstructorWith1AttributeUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithConstructorWith1ParameterUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithConstructorWith2ParametersUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalConstructorUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateConstructorUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedConstructorUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalConstructorUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicConstructorUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPublicConstructor));
        }
    }
}
