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
            TestSealedClass(typeof(SealedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithConstructorWith1ParameterUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestSealedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithConstructorWith2ParametersUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestSealedClassWithInternalConstructorUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateConstructorUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithPublicConstructorUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithPublicConstructor));
        }
    }
}
