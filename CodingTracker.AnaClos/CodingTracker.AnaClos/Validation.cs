using System.Globalization;

namespace AnaClos.CodingTracker;

public class Validation
{
    public bool Validate2Dates(string startTime,string endTime)
    {
        bool ok;
        var codingSession = new CodingSession { StartTime = startTime, EndTime = endTime };
        codingSession.CalculateDuration();
        if (codingSession.Duration.TotalSeconds > 0)
        {
            ok = true;
        }
        else
        {
            ok = false;
        }
        return ok;
    }

    public bool ValidateDate(string date)
    {
        bool ok = false;
        DateTime dateTime = DateTime.MinValue;

        if (date == "r")
        {
            ok = true;
        }
        else
        {
            try
            {
                dateTime = DateTime.ParseExact(date, "dd/MM/yy HH:mm:ss", new CultureInfo("en-US"));
                ok = true;
            }
            catch (Exception ex)
            {
                ok = false;
            }
        }
        return ok;
    }

    public bool ValidateInt(string response)
    {
        bool ok = false;
        int number = 0;

        if (response == "r")
        {
            ok = true;
        }
        else
        {
            try
            {
                number = Int32.Parse(response);
                ok = true;
            }
            catch (Exception ex)
            {
                ok = false;
            }
        }
        return ok;
    }
}