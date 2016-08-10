using CSharpDom.TestTarget.Structs.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWith1GenericParameterUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedClassWith1ImplementedInterfaceUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWith2GenericParametersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedClassWith2ImplementedInterfacesUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithBaseClassUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithGenericParameterClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithGenericParameterStructConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithInternalNestedClassUsingReflection()
        {
            TestStructAsync(typeof(StructWithInternalNestedClass));
        }

        [TestMethod]
        public void TestStructWithPrivateNestedClassUsingReflection()
        {
            TestStructAsync(typeof(StructWithPrivateNestedClass));
        }

        [TestMethod]
        public void TestStructWithPublicNestedClassUsingReflection()
        {
            TestStructAsync(typeof(StructWithPublicNestedClass));
        }
    }
}
