using Politician_Rating.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Politician_Rating.Test.Testcases
{
   public class BounadryTest
    {
        [Fact]
        public void Boundary_Testfor_ValidContactNumber()
        {
            //Action
            var Candidate = new Candidate()
            {
              PhoneNumber="11111111111"
            };

            //Assert
            Assert.Equal(10, Candidate.PhoneNumber.ToString().Length);
        }

        [Fact]
        public void BoundaryTest_ForUserName_Length()
        {

            Candidate candidate = new Candidate()
            {
                CandidateName = "111"
            };
            //Arrange
            var MinLength = 0;
            var MaxLength = 50;

            //Action
            var actualLength = candidate.CandidateName.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }
    }
}
