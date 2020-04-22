using System;
using Xunit;

namespace InterviewTest
{
    public class EmailBuilder
    {
        public string GetFooter()
        {
            return $"Best regards. EmailId =1";// { Guid.NewGuid()}";
        }
    }

    public class EmailBuilderTest
    {
       
    }
}