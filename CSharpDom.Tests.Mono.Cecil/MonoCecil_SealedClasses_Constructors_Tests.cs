using CSharpDom.TestTarget.SealedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_Constructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        public MonoCecil_SealedClasses_Constructors_Tests()
        {
            IsConstructorTest = true;
        }

        [TestMethod]
        public void TestSealedClassWithConstructorWith1AttributeUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithConstructorWith1ParameterUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestSealedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithConstructorWith2ParametersUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestSealedClassWithInternalConstructorUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateConstructorUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithPublicConstructorUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithPublicConstructor));
        }
    }
}
