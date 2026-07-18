public class Reception : Event
{
    private string _email;

    public Reception(string title, string description, string date, string time,
                     Address address, string email)
        : base(title, description, date, time, address)
    {
        _email = email;
    }

    public string FullDetails()
    {
        return $"{StandardDetails()}\nEvent Type: Reception\nRSVP Email: {_email}";
    }

    public string ShortDescription()
    {
        return $"Event Type: Reception\nTitle: {GetTitle()}\nDate: {GetDate()}";
    }
}