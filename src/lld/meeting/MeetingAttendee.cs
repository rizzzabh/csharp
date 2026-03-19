using System.Data.Common;
using System.Net;
enum Status
  {
    Accepted , 
    Declined , 
    Tentative,
    Pending ,
  }

public class MeetingAttendee
{
  public int Id {get ; set ;} 
  public int UserId {get ; set ; }

  public int MeetingId {get ; set ; }

  public Status RSVPStatus {get ; set ; }
}