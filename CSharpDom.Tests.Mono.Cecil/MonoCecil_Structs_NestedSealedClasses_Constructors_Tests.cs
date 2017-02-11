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
            TestStruct(typeof(StructWithNestedSealedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstructorWith1ParameterUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstructorWith2ParametersUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalConstructorUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateConstructorUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedConstructorUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalConstructorUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicConstructorUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPublicConstructor));
        }
    }
}
