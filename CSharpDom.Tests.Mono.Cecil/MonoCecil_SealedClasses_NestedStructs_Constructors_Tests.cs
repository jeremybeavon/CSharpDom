using CSharpDom.TestTarget.SealedClasses.NestedStructs.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedStructs_Constructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        public MonoCecil_SealedClasses_NestedStructs_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithConstructorWith1AttributeUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithConstructorWith1ParameterUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithConstructorWith2ParametersUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithInternalConstructorUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPrivateConstructorUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPublicConstructorUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicConstructor));
        }
    }
}
