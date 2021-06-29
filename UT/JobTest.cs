using NUnit.Framework;
using System.Collections.Generic;

using BL;
using DAL;

namespace UT
{
    public class Tests
    {
        public static IEnumerable<(Job, double)> GetRanksTestCases
        {
            get
            {
                yield return (new Job("test job","A job for unit tests", 100, new HashSet<ERank>{ERank.senior, ERank.decisionMaker}), 155);
            }
        }
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        [TestCaseSource("GetRanksTestCases")]
        public void TestJobsPayRate((Job, double) testCase)
        {
            var (job, expectedPayRate) = testCase;
            Assert.AreEqual(job.GetHourlyRate(), expectedPayRate);
        }
    }
}