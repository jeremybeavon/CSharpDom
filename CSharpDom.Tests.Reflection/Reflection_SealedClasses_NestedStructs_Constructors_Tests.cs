using CSharpDom.TestTarget.SealedClasses.NestedStructs.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedStructs_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        public Reflection_SealedClasses_NestedStructs_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithConstructorWith1AttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithConstructorWith1ParameterUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithConstructorWith2ParametersUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithInternalConstructorUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPrivateConstructorUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPublicConstructorUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicConstructor));
        }
    }
}
