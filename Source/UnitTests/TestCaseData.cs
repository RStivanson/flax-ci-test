namespace UnitTests;

public class TestCaseData
{
    public TestCaseData(params object[] attributes)
    {
        Attributes = attributes;
    }

    public object[] Attributes { get; set; }

    public object ExpectedResult { get; set; }

    public TestCaseData Returns(object expectedResult)
    {
        ExpectedResult = expectedResult;
        return this;
    }
}
