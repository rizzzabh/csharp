
enum Status
{
  Scheduled,
  Canceled,
  Completed ,
}
public class Meeting
{
  public int Id {get ; set ; }
  public string Name {get ; set ; }

  public DateTime StartTime {get ; set ; }

  public DateTime EndTime {get ; set ; }

  public Status MeetingStatus {get ; set ; }

  public ICollection<MeetingAttendee> MeetingAttendees {get ; set ; } = new List<MeetingAttendee>() ; 


}