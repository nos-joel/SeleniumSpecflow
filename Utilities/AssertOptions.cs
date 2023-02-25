/// <summary>
/// The AssertOptions class is used to define the available options when performing an Assert over an object
/// </summary>
public class AssertOptions
{
    public string current_value;

    /// <summary>
    /// Assert option to validate whether an object's property exactly matches the expected_value
    /// </summary>
    public void Equals(string expected_value)
    {
        // Include private variable for Assert Contidtion (like Is,Contains). This would help
        // include more validations in  case user leave something incomplete(AssertThat();) leaving the statement incomplete

        Assert.Equal(expected_value, current_value);
    }

    /// <summary>
    /// Assert option to validate whether an object's property partially matches the expected_value
    /// </summary>
    public void Contains(string expected_value)
    {
        Assert.Contains(expected_value, current_value);
    }
}