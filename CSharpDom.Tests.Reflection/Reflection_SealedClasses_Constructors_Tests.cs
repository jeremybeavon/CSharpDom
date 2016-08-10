using CSharpDom.TestTarget.SealedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        public Reflection_SealedClasses_Constructors_Tests()
        {
            IsConstructorTest = true;
        }

        [TestMethod]
        public void TestSealedClassWithConstructorWith1AttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithConstructorWith1ParameterUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestSealedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithConstructorWith2ParametersUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestSealedClassWithInternalConstructorUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateConstructorUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithPublicConstructorUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithPublicConstructor));
        }
    }
}
