using CSharpDom.TestTarget.SealedClasses.NestedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedClasses_Constructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        public MonoCecil_SealedClasses_NestedClasses_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }
        
        [TestMethod]
        public void TestSealedClassWithNestedClassWithConstructorWith1AttributeUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithConstructorWith1ParameterUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithConstructorWith2ParametersUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalConstructorUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateConstructorUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedConstructorUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalConstructorUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicConstructorUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPublicConstructor));
        }
    }
}
