using CSharpDom.TestTarget.Structs.NestedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedClasses_Constructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        public MonoCecil_Structs_NestedClasses_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestStructWithNestedClassWithConstructorWith1AttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithConstructorWith1ParameterUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithConstructorWith2ParametersUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalConstructorUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateConstructorUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedConstructorUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalConstructorUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicConstructorUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithPublicConstructor));
        }
    }
}
