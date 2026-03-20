using System.Runtime.CompilerServices;

public class MeetingSummaryDto
{
    public string MeetingName { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int AttendeeCount { get; set; }

    public MeetingSummaryDto(Meeting meeting)
  {
    this.MeetingName = meeting.Name ; 
    this.StartTime = meeting.StartTime ; 
    this.EndTime = meeting.EndTime ; 
    this.AttendeeCount = meeting.MeetingAttendees.Count; 
  }
}