using CleanCodeDesign.Application.Common.Interfaces;

namespace CleanCodeDesign.Infrastructure.Services;
public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
