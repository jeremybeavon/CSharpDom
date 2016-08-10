using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedSealedClasses_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        public Reflection_SealedClasses_NestedSealedClasses_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithConstructorWith1AttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithConstructorWith1ParameterUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithConstructorWith2ParametersUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithInternalConstructorUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPrivateConstructorUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedConstructorUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedInternalConstructorUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPublicConstructorUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPublicConstructor));
        }
    }
}
