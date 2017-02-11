using CSharpDom.TestTarget.SealedClasses.NestedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedClasses_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        public Reflection_SealedClasses_NestedClasses_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithConstructorWith1AttributeUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithConstructorWith1ParameterUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithConstructorWith2ParametersUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalConstructorUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateConstructorUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedConstructorUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalConstructorUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicConstructorUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPublicConstructor));
        }
    }
}
