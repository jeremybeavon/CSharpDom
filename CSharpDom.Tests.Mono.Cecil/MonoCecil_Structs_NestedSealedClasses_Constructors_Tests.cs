using CSharpDom.TestTarget.Structs.NestedSealedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedSealedClasses_Constructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        public MonoCecil_Structs_NestedSealedClasses_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstructorWith1AttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstructorWith1ParameterUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstructorWith2ParametersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalConstructorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateConstructorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedConstructorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalConstructorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicConstructorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPublicConstructor));
        }
    }
}
