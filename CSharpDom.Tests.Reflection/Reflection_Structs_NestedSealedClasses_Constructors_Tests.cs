using CSharpDom.TestTarget.Structs.NestedSealedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedSealedClasses_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        public Reflection_Structs_NestedSealedClasses_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstructorWith1AttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstructorWith1ParameterUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstructorWith2ParametersUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalConstructorUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateConstructorUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedConstructorUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalConstructorUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicConstructorUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPublicConstructor));
        }
    }
}
