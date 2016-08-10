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
            TestStructAsync(typeof(StructWithNestedSealedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstructorWith1ParameterUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstructorWith2ParametersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalConstructorUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateConstructorUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedConstructorUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalConstructorUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicConstructorUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPublicConstructor));
        }
    }
}
