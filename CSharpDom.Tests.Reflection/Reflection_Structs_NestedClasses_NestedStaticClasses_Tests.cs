using CSharpDom.TestTarget.Structs.NestedClasses.NestedStaticClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedClasses_NestedStaticClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithNestedStaticClassWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedStaticClassWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStaticClassWith1GenericParameterUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedStaticClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStaticClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedStaticClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStaticClassWith2GenericParametersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedStaticClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStaticClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedStaticClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStaticClassWithGenericParameterClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedStaticClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStaticClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStaticClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedStaticClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStaticClassWithGenericParameterStructConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedStaticClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalNestedStaticClassUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithInternalNestedStaticClass));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateNestedStaticClassUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPrivateNestedStaticClass));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedNestedStaticClassUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedNestedStaticClass));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalNestedStaticClassUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalNestedStaticClass));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicNestedStaticClassUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPublicNestedStaticClass));
        }
    }
}
